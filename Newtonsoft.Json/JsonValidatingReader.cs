using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities;
using Newtonsoft.Json.Utilities.LinqBridge;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;

namespace Newtonsoft.Json
{
	// Token: 0x020000B8 RID: 184
	public sealed class JsonValidatingReader : JsonReader, IJsonLineInfo
	{
		// Token: 0x020000B9 RID: 185
		private sealed class SchemaScope
		{
			// Token: 0x0400031B RID: 795
			private readonly Dictionary<string, bool> _requiredProperties;

			// Token: 0x0400031A RID: 794
			private readonly IList<JsonSchemaModel> _schemas;

			// Token: 0x04000319 RID: 793
			private readonly JTokenType _tokenType;

			// Token: 0x170000F9 RID: 249
			public int ArrayItemCount
			{
				// Token: 0x06000666 RID: 1638
				// RVA: 0x00009A9A File Offset: 0x00007C9A
				get;
				// Token: 0x06000667 RID: 1639
				// RVA: 0x00009AA2 File Offset: 0x00007CA2
				set;
			}

			// Token: 0x170000FC RID: 252
			public JTokenWriter CurrentItemWriter
			{
				// Token: 0x0600066C RID: 1644
				// RVA: 0x00009ACD File Offset: 0x00007CCD
				get;
				// Token: 0x0600066D RID: 1645
				// RVA: 0x00009AD5 File Offset: 0x00007CD5
				set;
			}

			// Token: 0x170000F8 RID: 248
			public string CurrentPropertyName
			{
				// Token: 0x06000664 RID: 1636
				// RVA: 0x00009A89 File Offset: 0x00007C89
				get;
				// Token: 0x06000665 RID: 1637
				// RVA: 0x00009A91 File Offset: 0x00007C91
				set;
			}

			// Token: 0x170000FA RID: 250
			public bool IsUniqueArray
			{
				// Token: 0x06000668 RID: 1640
				// RVA: 0x00009AAB File Offset: 0x00007CAB
				get;
				// Token: 0x06000669 RID: 1641
				// RVA: 0x00009AB3 File Offset: 0x00007CB3
				set;
			}

			// Token: 0x170000FE RID: 254
			public Dictionary<string, bool> RequiredProperties
			{
				// Token: 0x0600066F RID: 1647
				// RVA: 0x00009AE6 File Offset: 0x00007CE6
				get
				{
					return this._requiredProperties;
				}
			}

			// Token: 0x170000FD RID: 253
			public IList<JsonSchemaModel> Schemas
			{
				// Token: 0x0600066E RID: 1646
				// RVA: 0x00009ADE File Offset: 0x00007CDE
				get
				{
					return this._schemas;
				}
			}

			// Token: 0x170000FF RID: 255
			public JTokenType TokenType
			{
				// Token: 0x06000670 RID: 1648
				// RVA: 0x00009AEE File Offset: 0x00007CEE
				get
				{
					return this._tokenType;
				}
			}

			// Token: 0x170000FB RID: 251
			public IList<JToken> UniqueArrayItems
			{
				// Token: 0x0600066A RID: 1642
				// RVA: 0x00009ABC File Offset: 0x00007CBC
				get;
				// Token: 0x0600066B RID: 1643
				// RVA: 0x00009AC4 File Offset: 0x00007CC4
				set;
			}

			// Token: 0x06000671 RID: 1649
			// RVA: 0x000372C4 File Offset: 0x000354C4
			public SchemaScope(JTokenType tokenType, IList<JsonSchemaModel> schemas)
			{
				this._tokenType = tokenType;
				this._schemas = schemas;
				this._requiredProperties = Enumerable.ToDictionary<string, string, bool>(Enumerable.Distinct<string>(Enumerable.SelectMany<JsonSchemaModel, string>(schemas, new Func<JsonSchemaModel, IEnumerable<string>>(this.GetRequiredProperties))), (string p) => p, (string p) => false);
				if (tokenType == JTokenType.Array)
				{
					if (Enumerable.Any<JsonSchemaModel>(schemas, (JsonSchemaModel s) => s.UniqueItems))
					{
						this.IsUniqueArray = true;
						this.UniqueArrayItems = new List<JToken>();
					}
				}
			}

			// Token: 0x06000672 RID: 1650
			// RVA: 0x0003737C File Offset: 0x0003557C
			private IEnumerable<string> GetRequiredProperties(JsonSchemaModel schema)
			{
				if (schema != null && schema.Properties != null)
				{
					return Enumerable.Select<KeyValuePair<string, JsonSchemaModel>, string>(Enumerable.Where<KeyValuePair<string, JsonSchemaModel>>(schema.Properties, (KeyValuePair<string, JsonSchemaModel> p) => p.Value.Required), (KeyValuePair<string, JsonSchemaModel> p) => p.Key);
				}
				return Enumerable.Empty<string>();
			}
		}

		// Token: 0x04000313 RID: 787
		private static readonly IList<JsonSchemaModel> EmptySchemaList = new List<JsonSchemaModel>();

		// Token: 0x04000311 RID: 785
		private JsonValidatingReader.SchemaScope _currentScope;

		// Token: 0x04000310 RID: 784
		private JsonSchemaModel _model;

		// Token: 0x0400030D RID: 781
		private readonly JsonReader _reader;

		// Token: 0x0400030F RID: 783
		private JsonSchema _schema;

		// Token: 0x0400030E RID: 782
		private readonly Stack<JsonValidatingReader.SchemaScope> _stack;

		public event ValidationEventHandler ValidationEventHandler;

		// Token: 0x170000F3 RID: 243
		private IList<JsonSchemaModel> CurrentMemberSchemas
		{
			// Token: 0x0600063B RID: 1595
			// RVA: 0x00035EDC File Offset: 0x000340DC
			get
			{
				if (this._currentScope == null)
				{
					return new List<JsonSchemaModel>(new JsonSchemaModel[]
					{
						this._model
					});
				}
				if (this._currentScope.Schemas == null || this._currentScope.Schemas.Count == 0)
				{
					return JsonValidatingReader.EmptySchemaList;
				}
				switch (this._currentScope.TokenType)
				{
				case JTokenType.None:
					return this._currentScope.Schemas;
				case JTokenType.Object:
				{
					if (this._currentScope.CurrentPropertyName == null)
					{
						throw new JsonReaderException("CurrentPropertyName has not been set on scope.");
					}
					IList<JsonSchemaModel> list = new List<JsonSchemaModel>();
					foreach (JsonSchemaModel current in this.CurrentSchemas)
					{
						JsonSchemaModel item;
						if (current.Properties != null && current.Properties.TryGetValue(this._currentScope.CurrentPropertyName, out item))
						{
							list.Add(item);
						}
						if (current.PatternProperties != null)
						{
							foreach (KeyValuePair<string, JsonSchemaModel> current2 in current.PatternProperties)
							{
								if (Regex.IsMatch(this._currentScope.CurrentPropertyName, current2.Key))
								{
									list.Add(current2.Value);
								}
							}
						}
						if (list.Count == 0 && current.AllowAdditionalProperties && current.AdditionalProperties != null)
						{
							list.Add(current.AdditionalProperties);
						}
					}
					return list;
				}
				case JTokenType.Array:
				{
					IList<JsonSchemaModel> list2 = new List<JsonSchemaModel>();
					foreach (JsonSchemaModel current3 in this.CurrentSchemas)
					{
						if (!current3.PositionalItemsValidation)
						{
							if (current3.Items != null && current3.Items.Count > 0)
							{
								list2.Add(current3.Items[0]);
							}
						}
						else
						{
							if (current3.Items != null && current3.Items.Count > 0 && current3.Items.Count > this._currentScope.ArrayItemCount - 1)
							{
								list2.Add(current3.Items[this._currentScope.ArrayItemCount - 1]);
							}
							if (current3.AllowAdditionalItems && current3.AdditionalItems != null)
							{
								list2.Add(current3.AdditionalItems);
							}
						}
					}
					return list2;
				}
				case JTokenType.Constructor:
					return JsonValidatingReader.EmptySchemaList;
				default:
					throw new ArgumentOutOfRangeException("TokenType", StringUtils.FormatWith("Unexpected token type: {0}", CultureInfo.InvariantCulture, this._currentScope.TokenType));
				}
			}
		}

		// Token: 0x170000F2 RID: 242
		private IList<JsonSchemaModel> CurrentSchemas
		{
			// Token: 0x0600063A RID: 1594
			// RVA: 0x00009914 File Offset: 0x00007B14
			get
			{
				return this._currentScope.Schemas;
			}
		}

		// Token: 0x170000ED RID: 237
		public override int Depth
		{
			// Token: 0x06000632 RID: 1586
			// RVA: 0x000098BE File Offset: 0x00007ABE
			get
			{
				return this._reader.Depth;
			}
		}

		// Token: 0x170000F6 RID: 246
		int IJsonLineInfo.LineNumber
		{
			// Token: 0x0600065C RID: 1628
			// RVA: 0x0003727C File Offset: 0x0003547C
			get
			{
				IJsonLineInfo jsonLineInfo = this._reader as IJsonLineInfo;
				if (jsonLineInfo == null)
				{
					return 0;
				}
				return jsonLineInfo.LineNumber;
			}
		}

		// Token: 0x170000F7 RID: 247
		int IJsonLineInfo.LinePosition
		{
			// Token: 0x0600065D RID: 1629
			// RVA: 0x000372A0 File Offset: 0x000354A0
			get
			{
				IJsonLineInfo jsonLineInfo = this._reader as IJsonLineInfo;
				if (jsonLineInfo == null)
				{
					return 0;
				}
				return jsonLineInfo.LinePosition;
			}
		}

		// Token: 0x170000EE RID: 238
		public override string Path
		{
			// Token: 0x06000633 RID: 1587
			// RVA: 0x000098CB File Offset: 0x00007ACB
			get
			{
				return this._reader.Path;
			}
		}

		// Token: 0x170000EF RID: 239
		public override char QuoteChar
		{
			// Token: 0x06000634 RID: 1588
			// RVA: 0x000098D8 File Offset: 0x00007AD8
			get
			{
				return this._reader.QuoteChar;
			}
			// Token: 0x06000635 RID: 1589
			// RVA: 0x0000653E File Offset: 0x0000473E
			protected internal set
			{
			}
		}

		// Token: 0x170000F5 RID: 245
		public JsonReader Reader
		{
			// Token: 0x06000641 RID: 1601
			// RVA: 0x00009971 File Offset: 0x00007B71
			get
			{
				return this._reader;
			}
		}

		// Token: 0x170000F4 RID: 244
		public JsonSchema Schema
		{
			// Token: 0x0600063F RID: 1599
			// RVA: 0x00009946 File Offset: 0x00007B46
			get
			{
				return this._schema;
			}
			// Token: 0x06000640 RID: 1600
			// RVA: 0x0000994E File Offset: 0x00007B4E
			set
			{
				if (this.TokenType != JsonToken.None)
				{
					throw new InvalidOperationException("Cannot change schema while validating JSON.");
				}
				this._schema = value;
				this._model = null;
			}
		}

		// Token: 0x170000F0 RID: 240
		public override JsonToken TokenType
		{
			// Token: 0x06000636 RID: 1590
			// RVA: 0x000098E5 File Offset: 0x00007AE5
			get
			{
				return this._reader.TokenType;
			}
		}

		// Token: 0x170000EC RID: 236
		public override object Value
		{
			// Token: 0x06000631 RID: 1585
			// RVA: 0x000098B1 File Offset: 0x00007AB1
			get
			{
				return this._reader.Value;
			}
		}

		// Token: 0x170000F1 RID: 241
		public override Type ValueType
		{
			// Token: 0x06000637 RID: 1591
			// RVA: 0x000098F2 File Offset: 0x00007AF2
			get
			{
				return this._reader.ValueType;
			}
		}

		// Token: 0x0600063E RID: 1598
		// RVA: 0x00009921 File Offset: 0x00007B21
		public JsonValidatingReader(JsonReader reader)
		{
			ValidationUtils.ArgumentNotNull(reader, "reader");
			this._reader = reader;
			this._stack = new Stack<JsonValidatingReader.SchemaScope>();
		}

		// Token: 0x06000654 RID: 1620
		// RVA: 0x000099D2 File Offset: 0x00007BD2
		private static double FloatingPointRemainder(double dividend, double divisor)
		{
			return dividend - Math.Floor(dividend / divisor) * divisor;
		}

		// Token: 0x06000643 RID: 1603
		// RVA: 0x00036294 File Offset: 0x00034494
		private JsonSchemaType? GetCurrentNodeSchemaType()
		{
			switch (this._reader.TokenType)
			{
			case JsonToken.StartObject:
				return new JsonSchemaType?(JsonSchemaType.Object);
			case JsonToken.StartArray:
				return new JsonSchemaType?(JsonSchemaType.Array);
			case JsonToken.Integer:
				return new JsonSchemaType?(JsonSchemaType.Integer);
			case JsonToken.Float:
				return new JsonSchemaType?(JsonSchemaType.Float);
			case JsonToken.String:
				return new JsonSchemaType?(JsonSchemaType.String);
			case JsonToken.Boolean:
				return new JsonSchemaType?(JsonSchemaType.Boolean);
			case JsonToken.Null:
				return new JsonSchemaType?(JsonSchemaType.Null);
			}
			return null;
		}

		// Token: 0x06000657 RID: 1623
		// RVA: 0x000371DC File Offset: 0x000353DC
		private bool IsPropertyDefinied(JsonSchemaModel schema, string propertyName)
		{
			if (schema.Properties != null && schema.Properties.ContainsKey(propertyName))
			{
				return true;
			}
			if (schema.PatternProperties != null)
			{
				bool result;
				using (IEnumerator<string> enumerator = schema.PatternProperties.Keys.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						string current = enumerator.Current;
						if (Regex.IsMatch(propertyName, current))
						{
							result = true;
							return result;
						}
					}
					return false;
				}
				return result;
			}
			return false;
		}

		// Token: 0x06000655 RID: 1621
		// RVA: 0x000099E0 File Offset: 0x00007BE0
		private static bool IsZero(double value)
		{
			return Math.Abs(value) < 4.4408920985006262E-15;
		}

		// Token: 0x0600065B RID: 1627
		// RVA: 0x00037258 File Offset: 0x00035458
		bool IJsonLineInfo.HasLineInfo()
		{
			IJsonLineInfo jsonLineInfo = this._reader as IJsonLineInfo;
			return jsonLineInfo != null && jsonLineInfo.HasLineInfo();
		}

		// Token: 0x0600063D RID: 1597
		// RVA: 0x00036214 File Offset: 0x00034414
		private void OnValidationEvent(JsonSchemaException exception)
		{
			ValidationEventHandler validationEventHandler = this.ValidationEventHandler;
			if (validationEventHandler == null)
			{
				throw exception;
			}
			validationEventHandler(this, new ValidationEventArgs(exception));
		}

		// Token: 0x06000639 RID: 1593
		// RVA: 0x00035EA0 File Offset: 0x000340A0
		private JsonValidatingReader.SchemaScope Pop()
		{
			JsonValidatingReader.SchemaScope result = this._stack.Pop();
			this._currentScope = ((this._stack.Count != 0) ? this._stack.Peek() : null);
			return result;
		}

		// Token: 0x06000652 RID: 1618
		// RVA: 0x00036E98 File Offset: 0x00035098
		private void ProcessValue()
		{
			if (this._currentScope != null && this._currentScope.TokenType == JTokenType.Array)
			{
				this._currentScope.ArrayItemCount++;
				foreach (JsonSchemaModel current in this.CurrentSchemas)
				{
					if (current != null && current.PositionalItemsValidation && !current.AllowAdditionalItems && (current.Items == null || this._currentScope.ArrayItemCount - 1 >= current.Items.Count))
					{
						this.RaiseError(StringUtils.FormatWith("Index {0} has not been defined and the schema does not allow additional items.", CultureInfo.InvariantCulture, this._currentScope.ArrayItemCount), current);
					}
				}
			}
		}

		// Token: 0x06000638 RID: 1592
		// RVA: 0x000098FF File Offset: 0x00007AFF
		private void Push(JsonValidatingReader.SchemaScope scope)
		{
			this._stack.Push(scope);
			this._currentScope = scope;
		}

		// Token: 0x0600063C RID: 1596
		// RVA: 0x000361AC File Offset: 0x000343AC
		private void RaiseError(string message, JsonSchemaModel schema)
		{
			string message2 = ((IJsonLineInfo)this).HasLineInfo() ? (message + StringUtils.FormatWith(" Line {0}, position {1}.", CultureInfo.InvariantCulture, ((IJsonLineInfo)this).LineNumber, ((IJsonLineInfo)this).LinePosition)) : message;
			this.OnValidationEvent(new JsonSchemaException(message2, null, this.Path, ((IJsonLineInfo)this).LineNumber, ((IJsonLineInfo)this).LinePosition));
		}

		// Token: 0x06000649 RID: 1609
		// RVA: 0x00009979 File Offset: 0x00007B79
		public override bool Read()
		{
			if (!this._reader.Read())
			{
				return false;
			}
			if (this._reader.TokenType == JsonToken.Comment)
			{
				return true;
			}
			this.ValidateCurrentToken();
			return true;
		}

		// Token: 0x06000645 RID: 1605
		// RVA: 0x00036340 File Offset: 0x00034540
		public override byte[] ReadAsBytes()
		{
			byte[] result = this._reader.ReadAsBytes();
			this.ValidateCurrentToken();
			return result;
		}

		// Token: 0x06000648 RID: 1608
		// RVA: 0x000363A0 File Offset: 0x000345A0
		public override DateTime? ReadAsDateTime()
		{
			DateTime? result = this._reader.ReadAsDateTime();
			this.ValidateCurrentToken();
			return result;
		}

		// Token: 0x06000646 RID: 1606
		// RVA: 0x00036360 File Offset: 0x00034560
		public override decimal? ReadAsDecimal()
		{
			decimal? result = this._reader.ReadAsDecimal();
			this.ValidateCurrentToken();
			return result;
		}

		// Token: 0x06000644 RID: 1604
		// RVA: 0x00036320 File Offset: 0x00034520
		public override int? ReadAsInt32()
		{
			int? result = this._reader.ReadAsInt32();
			this.ValidateCurrentToken();
			return result;
		}

		// Token: 0x06000647 RID: 1607
		// RVA: 0x00036380 File Offset: 0x00034580
		public override string ReadAsString()
		{
			string result = this._reader.ReadAsString();
			this.ValidateCurrentToken();
			return result;
		}

		// Token: 0x0600065A RID: 1626
		// RVA: 0x00009A13 File Offset: 0x00007C13
		private bool TestType(JsonSchemaModel currentSchema, JsonSchemaType currentType)
		{
			if (!JsonSchemaGenerator.HasFlag(new JsonSchemaType?(currentSchema.Type), currentType))
			{
				this.RaiseError(StringUtils.FormatWith("Invalid type. Expected {0} but got {1}.", CultureInfo.InvariantCulture, currentSchema.Type, currentType), currentSchema);
				return false;
			}
			return true;
		}

		// Token: 0x06000658 RID: 1624
		// RVA: 0x000099F3 File Offset: 0x00007BF3
		private bool ValidateArray(JsonSchemaModel schema)
		{
			return schema == null || this.TestType(schema, JsonSchemaType.Array);
		}

		// Token: 0x0600064F RID: 1615
		// RVA: 0x000099BA File Offset: 0x00007BBA
		private void ValidateBoolean(JsonSchemaModel schema)
		{
			if (schema == null)
			{
				return;
			}
			if (!this.TestType(schema, JsonSchemaType.Boolean))
			{
				return;
			}
			this.ValidateNotDisallowed(schema);
		}

		// Token: 0x0600064A RID: 1610
		// RVA: 0x000363C0 File Offset: 0x000345C0
		private void ValidateCurrentToken()
		{
			if (this._model == null)
			{
				JsonSchemaModelBuilder jsonSchemaModelBuilder = new JsonSchemaModelBuilder();
				this._model = jsonSchemaModelBuilder.Build(this._schema);
				if (!JsonTokenUtils.IsStartToken(this._reader.TokenType))
				{
					this.Push(new JsonValidatingReader.SchemaScope(JTokenType.None, this.CurrentMemberSchemas));
				}
			}
			switch (this._reader.TokenType)
			{
			case JsonToken.None:
				return;
			case JsonToken.StartObject:
			{
				this.ProcessValue();
				IList<JsonSchemaModel> schemas = Enumerable.ToList<JsonSchemaModel>(Enumerable.Where<JsonSchemaModel>(this.CurrentMemberSchemas, new Func<JsonSchemaModel, bool>(this.ValidateObject)));
				this.Push(new JsonValidatingReader.SchemaScope(JTokenType.Object, schemas));
				this.WriteToken(this.CurrentSchemas);
				return;
			}
			case JsonToken.StartArray:
			{
				this.ProcessValue();
				IList<JsonSchemaModel> schemas2 = Enumerable.ToList<JsonSchemaModel>(Enumerable.Where<JsonSchemaModel>(this.CurrentMemberSchemas, new Func<JsonSchemaModel, bool>(this.ValidateArray)));
				this.Push(new JsonValidatingReader.SchemaScope(JTokenType.Array, schemas2));
				this.WriteToken(this.CurrentSchemas);
				return;
			}
			case JsonToken.StartConstructor:
				this.ProcessValue();
				this.Push(new JsonValidatingReader.SchemaScope(JTokenType.Constructor, null));
				this.WriteToken(this.CurrentSchemas);
				return;
			case JsonToken.PropertyName:
				this.WriteToken(this.CurrentSchemas);
				using (IEnumerator<JsonSchemaModel> enumerator = this.CurrentSchemas.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						JsonSchemaModel current = enumerator.Current;
						this.ValidatePropertyName(current);
					}
					return;
				}
				break;
			case JsonToken.Raw:
				this.ProcessValue();
				return;
			case JsonToken.Integer:
				this.ProcessValue();
				this.WriteToken(this.CurrentMemberSchemas);
				using (IEnumerator<JsonSchemaModel> enumerator2 = this.CurrentMemberSchemas.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						JsonSchemaModel current2 = enumerator2.Current;
						this.ValidateInteger(current2);
					}
					return;
				}
				goto IL_1DE;
			case JsonToken.Float:
				goto IL_1DE;
			case JsonToken.String:
				goto IL_22B;
			case JsonToken.Boolean:
				goto IL_278;
			case JsonToken.Null:
				goto IL_2C2;
			case JsonToken.Undefined:
			case JsonToken.Date:
			case JsonToken.Bytes:
				this.WriteToken(this.CurrentMemberSchemas);
				return;
			case JsonToken.EndObject:
				this.WriteToken(this.CurrentSchemas);
				foreach (JsonSchemaModel current3 in this.CurrentSchemas)
				{
					this.ValidateEndObject(current3);
				}
				this.Pop();
				return;
			case JsonToken.EndArray:
				this.WriteToken(this.CurrentSchemas);
				foreach (JsonSchemaModel current4 in this.CurrentSchemas)
				{
					this.ValidateEndArray(current4);
				}
				this.Pop();
				return;
			case JsonToken.EndConstructor:
				this.WriteToken(this.CurrentSchemas);
				this.Pop();
				return;
			}
			throw new ArgumentOutOfRangeException();
			IL_1DE:
			this.ProcessValue();
			this.WriteToken(this.CurrentMemberSchemas);
			using (IEnumerator<JsonSchemaModel> enumerator5 = this.CurrentMemberSchemas.GetEnumerator())
			{
				while (enumerator5.MoveNext())
				{
					JsonSchemaModel current5 = enumerator5.Current;
					this.ValidateFloat(current5);
				}
				return;
			}
			IL_22B:
			this.ProcessValue();
			this.WriteToken(this.CurrentMemberSchemas);
			using (IEnumerator<JsonSchemaModel> enumerator6 = this.CurrentMemberSchemas.GetEnumerator())
			{
				while (enumerator6.MoveNext())
				{
					JsonSchemaModel current6 = enumerator6.Current;
					this.ValidateString(current6);
				}
				return;
			}
			IL_278:
			this.ProcessValue();
			this.WriteToken(this.CurrentMemberSchemas);
			using (IEnumerator<JsonSchemaModel> enumerator7 = this.CurrentMemberSchemas.GetEnumerator())
			{
				while (enumerator7.MoveNext())
				{
					JsonSchemaModel current7 = enumerator7.Current;
					this.ValidateBoolean(current7);
				}
				return;
			}
			IL_2C2:
			this.ProcessValue();
			this.WriteToken(this.CurrentMemberSchemas);
			foreach (JsonSchemaModel current8 in this.CurrentMemberSchemas)
			{
				this.ValidateNull(current8);
			}
		}

		// Token: 0x0600064D RID: 1613
		// RVA: 0x00036AE0 File Offset: 0x00034CE0
		private void ValidateEndArray(JsonSchemaModel schema)
		{
			if (schema == null)
			{
				return;
			}
			int arrayItemCount = this._currentScope.ArrayItemCount;
			if (schema.MaximumItems.HasValue && arrayItemCount > schema.MaximumItems)
			{
				this.RaiseError(StringUtils.FormatWith("Array item count {0} exceeds maximum count of {1}.", CultureInfo.InvariantCulture, arrayItemCount, schema.MaximumItems), schema);
			}
			if (schema.MinimumItems.HasValue && arrayItemCount < schema.MinimumItems)
			{
				this.RaiseError(StringUtils.FormatWith("Array item count {0} is less than minimum count of {1}.", CultureInfo.InvariantCulture, arrayItemCount, schema.MinimumItems), schema);
			}
		}

		// Token: 0x0600064C RID: 1612
		// RVA: 0x00036A44 File Offset: 0x00034C44
		private void ValidateEndObject(JsonSchemaModel schema)
		{
			if (schema == null)
			{
				return;
			}
			Dictionary<string, bool> requiredProperties = this._currentScope.RequiredProperties;
			if (requiredProperties != null)
			{
				List<string> list = Enumerable.ToList<string>(Enumerable.Select<KeyValuePair<string, bool>, string>(Enumerable.Where<KeyValuePair<string, bool>>(requiredProperties, (KeyValuePair<string, bool> kv) => !kv.Value), (KeyValuePair<string, bool> kv) => kv.Key));
				if (list.Count > 0)
				{
					this.RaiseError(StringUtils.FormatWith("Required properties are missing from object: {0}.", CultureInfo.InvariantCulture, string.Join(", ", list.ToArray())), schema);
				}
			}
		}

		// Token: 0x06000653 RID: 1619
		// RVA: 0x00036F6C File Offset: 0x0003516C
		private void ValidateFloat(JsonSchemaModel schema)
		{
			if (schema == null)
			{
				return;
			}
			if (!this.TestType(schema, JsonSchemaType.Float))
			{
				return;
			}
			this.ValidateNotDisallowed(schema);
			double num = Convert.ToDouble(this._reader.Value, CultureInfo.InvariantCulture);
			if (schema.Maximum.HasValue)
			{
				double num2 = num;
				double? maximum = schema.Maximum;
				if (num2 > maximum.GetValueOrDefault() && maximum.HasValue)
				{
					this.RaiseError(StringUtils.FormatWith("Float {0} exceeds maximum value of {1}.", CultureInfo.InvariantCulture, JsonConvert.ToString(num), schema.Maximum), schema);
				}
				if (schema.ExclusiveMaximum)
				{
					double num3 = num;
					double? maximum2 = schema.Maximum;
					if (num3 == maximum2.GetValueOrDefault() && maximum2.HasValue)
					{
						this.RaiseError(StringUtils.FormatWith("Float {0} equals maximum value of {1} and exclusive maximum is true.", CultureInfo.InvariantCulture, JsonConvert.ToString(num), schema.Maximum), schema);
					}
				}
			}
			if (schema.Minimum.HasValue)
			{
				double num4 = num;
				double? minimum = schema.Minimum;
				if (num4 < minimum.GetValueOrDefault() && minimum.HasValue)
				{
					this.RaiseError(StringUtils.FormatWith("Float {0} is less than minimum value of {1}.", CultureInfo.InvariantCulture, JsonConvert.ToString(num), schema.Minimum), schema);
				}
				if (schema.ExclusiveMinimum)
				{
					double num5 = num;
					double? minimum2 = schema.Minimum;
					if (num5 == minimum2.GetValueOrDefault() && minimum2.HasValue)
					{
						this.RaiseError(StringUtils.FormatWith("Float {0} equals minimum value of {1} and exclusive minimum is true.", CultureInfo.InvariantCulture, JsonConvert.ToString(num), schema.Minimum), schema);
					}
				}
			}
			if (schema.DivisibleBy.HasValue)
			{
				double value = JsonValidatingReader.FloatingPointRemainder(num, schema.DivisibleBy.Value);
				if (!JsonValidatingReader.IsZero(value))
				{
					this.RaiseError(StringUtils.FormatWith("Float {0} is not evenly divisible by {1}.", CultureInfo.InvariantCulture, JsonConvert.ToString(num), schema.DivisibleBy), schema);
				}
			}
		}

		// Token: 0x06000651 RID: 1617
		// RVA: 0x00036D00 File Offset: 0x00034F00
		private void ValidateInteger(JsonSchemaModel schema)
		{
			if (schema == null)
			{
				return;
			}
			if (!this.TestType(schema, JsonSchemaType.Integer))
			{
				return;
			}
			this.ValidateNotDisallowed(schema);
			object value = this._reader.Value;
			if (schema.Maximum.HasValue)
			{
				if (JValue.Compare(JTokenType.Integer, value, schema.Maximum) > 0)
				{
					this.RaiseError(StringUtils.FormatWith("Integer {0} exceeds maximum value of {1}.", CultureInfo.InvariantCulture, value, schema.Maximum), schema);
				}
				if (schema.ExclusiveMaximum && JValue.Compare(JTokenType.Integer, value, schema.Maximum) == 0)
				{
					this.RaiseError(StringUtils.FormatWith("Integer {0} equals maximum value of {1} and exclusive maximum is true.", CultureInfo.InvariantCulture, value, schema.Maximum), schema);
				}
			}
			if (schema.Minimum.HasValue)
			{
				if (JValue.Compare(JTokenType.Integer, value, schema.Minimum) < 0)
				{
					this.RaiseError(StringUtils.FormatWith("Integer {0} is less than minimum value of {1}.", CultureInfo.InvariantCulture, value, schema.Minimum), schema);
				}
				if (schema.ExclusiveMinimum && JValue.Compare(JTokenType.Integer, value, schema.Minimum) == 0)
				{
					this.RaiseError(StringUtils.FormatWith("Integer {0} equals minimum value of {1} and exclusive minimum is true.", CultureInfo.InvariantCulture, value, schema.Minimum), schema);
				}
			}
			if (schema.DivisibleBy.HasValue && !JsonValidatingReader.IsZero((double)Convert.ToInt64(value, CultureInfo.InvariantCulture) % schema.DivisibleBy.Value))
			{
				this.RaiseError(StringUtils.FormatWith("Integer {0} is not evenly divisible by {1}.", CultureInfo.InvariantCulture, JsonConvert.ToString(value), schema.DivisibleBy), schema);
			}
		}

		// Token: 0x06000642 RID: 1602
		// RVA: 0x0003623C File Offset: 0x0003443C
		private void ValidateNotDisallowed(JsonSchemaModel schema)
		{
			if (schema == null)
			{
				return;
			}
			JsonSchemaType? currentNodeSchemaType = this.GetCurrentNodeSchemaType();
			if (currentNodeSchemaType.HasValue && JsonSchemaGenerator.HasFlag(new JsonSchemaType?(schema.Disallow), currentNodeSchemaType.Value))
			{
				this.RaiseError(StringUtils.FormatWith("Type {0} is disallowed.", CultureInfo.InvariantCulture, currentNodeSchemaType), schema);
			}
		}

		// Token: 0x0600064E RID: 1614
		// RVA: 0x000099A1 File Offset: 0x00007BA1
		private void ValidateNull(JsonSchemaModel schema)
		{
			if (schema == null)
			{
				return;
			}
			if (!this.TestType(schema, JsonSchemaType.Null))
			{
				return;
			}
			this.ValidateNotDisallowed(schema);
		}

		// Token: 0x06000659 RID: 1625
		// RVA: 0x00009A03 File Offset: 0x00007C03
		private bool ValidateObject(JsonSchemaModel schema)
		{
			return schema == null || this.TestType(schema, JsonSchemaType.Object);
		}

		// Token: 0x06000656 RID: 1622
		// RVA: 0x00037158 File Offset: 0x00035358
		private void ValidatePropertyName(JsonSchemaModel schema)
		{
			if (schema == null)
			{
				return;
			}
			string text = Convert.ToString(this._reader.Value, CultureInfo.InvariantCulture);
			if (this._currentScope.RequiredProperties.ContainsKey(text))
			{
				this._currentScope.RequiredProperties[text] = true;
			}
			if (!schema.AllowAdditionalProperties && !this.IsPropertyDefinied(schema, text))
			{
				this.RaiseError(StringUtils.FormatWith("Property '{0}' has not been defined and the schema does not allow additional properties.", CultureInfo.InvariantCulture, text), schema);
			}
			this._currentScope.CurrentPropertyName = text;
		}

		// Token: 0x06000650 RID: 1616
		// RVA: 0x00036BB0 File Offset: 0x00034DB0
		private void ValidateString(JsonSchemaModel schema)
		{
			if (schema == null)
			{
				return;
			}
			if (!this.TestType(schema, JsonSchemaType.String))
			{
				return;
			}
			this.ValidateNotDisallowed(schema);
			string text = this._reader.Value.ToString();
			if (schema.MaximumLength.HasValue && text.Length > schema.MaximumLength)
			{
				this.RaiseError(StringUtils.FormatWith("String '{0}' exceeds maximum length of {1}.", CultureInfo.InvariantCulture, text, schema.MaximumLength), schema);
			}
			if (schema.MinimumLength.HasValue && text.Length < schema.MinimumLength)
			{
				this.RaiseError(StringUtils.FormatWith("String '{0}' is less than minimum length of {1}.", CultureInfo.InvariantCulture, text, schema.MinimumLength), schema);
			}
			if (schema.Patterns != null)
			{
				foreach (string current in schema.Patterns)
				{
					if (!Regex.IsMatch(text, current))
					{
						this.RaiseError(StringUtils.FormatWith("String '{0}' does not match regex pattern '{1}'.", CultureInfo.InvariantCulture, text, current), schema);
					}
				}
			}
		}

		// Token: 0x0600064B RID: 1611
		// RVA: 0x000367F8 File Offset: 0x000349F8
		private void WriteToken(IList<JsonSchemaModel> schemas)
		{
			foreach (JsonValidatingReader.SchemaScope current in this._stack)
			{
				bool flag;
				if (!(flag = (current.TokenType == JTokenType.Array && current.IsUniqueArray && current.ArrayItemCount > 0)))
				{
					if (!Enumerable.Any<JsonSchemaModel>(schemas, (JsonSchemaModel s) => s.Enum != null))
					{
						continue;
					}
				}
				if (current.CurrentItemWriter == null)
				{
					if (JsonTokenUtils.IsEndToken(this._reader.TokenType))
					{
						continue;
					}
					current.CurrentItemWriter = new JTokenWriter();
				}
				current.CurrentItemWriter.WriteToken(this._reader, false);
				if (current.CurrentItemWriter.Top == 0 && this._reader.TokenType != JsonToken.PropertyName)
				{
					JToken token = current.CurrentItemWriter.Token;
					current.CurrentItemWriter = null;
					if (flag)
					{
						if (Enumerable.Contains<JToken>(current.UniqueArrayItems, token, JToken.EqualityComparer))
						{
							this.RaiseError(StringUtils.FormatWith("Non-unique array item at index {0}.", CultureInfo.InvariantCulture, current.ArrayItemCount - 1), Enumerable.First<JsonSchemaModel>(current.Schemas, (JsonSchemaModel s) => s.UniqueItems));
						}
						current.UniqueArrayItems.Add(token);
					}
					else if (Enumerable.Any<JsonSchemaModel>(schemas, (JsonSchemaModel s) => s.Enum != null))
					{
						foreach (JsonSchemaModel current2 in schemas)
						{
							if (current2.Enum != null && !CollectionUtils.ContainsValue<JToken>(current2.Enum, token, JToken.EqualityComparer))
							{
								StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture);
								token.WriteTo(new JsonTextWriter(stringWriter), new JsonConverter[0]);
								this.RaiseError(StringUtils.FormatWith("Value {0} is not defined in enum.", CultureInfo.InvariantCulture, stringWriter.ToString()), current2);
							}
						}
					}
				}
			}
		}
	}
}
