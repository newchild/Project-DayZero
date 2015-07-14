using Newtonsoft.Json.Utilities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000DE RID: 222
	public sealed class JConstructor : JContainer
	{
		// Token: 0x040003BF RID: 959
		private string _name;

		// Token: 0x040003C0 RID: 960
		private readonly List<JToken> _values = new List<JToken>();

		// Token: 0x17000179 RID: 377
		protected override IList<JToken> ChildrenTokens
		{
			// Token: 0x060008C2 RID: 2242
			// RVA: 0x0000B443 File Offset: 0x00009643
			get
			{
				return this._values;
			}
		}

		// Token: 0x1700017C RID: 380
		public override JToken this[object key]
		{
			// Token: 0x060008CF RID: 2255
			// RVA: 0x0000B4D6 File Offset: 0x000096D6
			get
			{
				ValidationUtils.ArgumentNotNull(key, "o");
				if (!(key is int))
				{
					throw new ArgumentException(StringUtils.FormatWith("Accessed JConstructor values with invalid key value: {0}. Argument position index expected.", CultureInfo.InvariantCulture, MiscellaneousUtils.ToString(key)));
				}
				return this.GetItem((int)key);
			}
			// Token: 0x060008D0 RID: 2256
			// RVA: 0x0000B512 File Offset: 0x00009712
			set
			{
				ValidationUtils.ArgumentNotNull(key, "o");
				if (!(key is int))
				{
					throw new ArgumentException(StringUtils.FormatWith("Set JConstructor values with invalid key value: {0}. Argument position index expected.", CultureInfo.InvariantCulture, MiscellaneousUtils.ToString(key)));
				}
				this.SetItem((int)key, value);
			}
		}

		// Token: 0x1700017A RID: 378
		public string Name
		{
			// Token: 0x060008C4 RID: 2244
			// RVA: 0x0000B44B File Offset: 0x0000964B
			get
			{
				return this._name;
			}
			// Token: 0x060008C5 RID: 2245
			// RVA: 0x0000B453 File Offset: 0x00009653
			set
			{
				this._name = value;
			}
		}

		// Token: 0x1700017B RID: 379
		public override JTokenType Type
		{
			// Token: 0x060008C6 RID: 2246
			// RVA: 0x00006369 File Offset: 0x00004569
			get
			{
				return JTokenType.Constructor;
			}
		}

		// Token: 0x060008C7 RID: 2247
		// RVA: 0x0000B45C File Offset: 0x0000965C
		public JConstructor()
		{
		}

		// Token: 0x060008C8 RID: 2248
		// RVA: 0x0000B46F File Offset: 0x0000966F
		public JConstructor(JConstructor other) : base(other)
		{
			this._name = other.Name;
		}

		// Token: 0x060008CB RID: 2251
		// RVA: 0x0000B4A9 File Offset: 0x000096A9
		public JConstructor(string name)
		{
			ValidationUtils.ArgumentNotNullOrEmpty(name, "name");
			this._name = name;
		}

		// Token: 0x060008C9 RID: 2249
		// RVA: 0x0000B48F File Offset: 0x0000968F
		public JConstructor(string name, params object[] content) : this(name, content)
		{
		}

		// Token: 0x060008CA RID: 2250
		// RVA: 0x0000B499 File Offset: 0x00009699
		public JConstructor(string name, object content) : this(name)
		{
			this.Add(content);
		}

		// Token: 0x060008CD RID: 2253
		// RVA: 0x0000B4CE File Offset: 0x000096CE
		internal override JToken CloneToken()
		{
			return new JConstructor(this);
		}

		// Token: 0x060008CC RID: 2252
		// RVA: 0x0003D55C File Offset: 0x0003B75C
		internal override bool DeepEquals(JToken node)
		{
			JConstructor jConstructor = node as JConstructor;
			return jConstructor != null && this._name == jConstructor.Name && base.ContentsEqual(jConstructor);
		}

		// Token: 0x060008D1 RID: 2257
		// RVA: 0x0000B54F File Offset: 0x0000974F
		internal override int GetDeepHashCode()
		{
			return this._name.GetHashCode() ^ base.ContentsHashCode();
		}

		// Token: 0x060008D2 RID: 2258
		// RVA: 0x0003D5F4 File Offset: 0x0003B7F4
		public new static JConstructor Load(JsonReader reader)
		{
			if (reader.TokenType == JsonToken.None && !reader.Read())
			{
				throw JsonReaderException.Create(reader, "Error reading JConstructor from JsonReader.");
			}
			while (reader.TokenType == JsonToken.Comment)
			{
				reader.Read();
			}
			if (reader.TokenType != JsonToken.StartConstructor)
			{
				throw JsonReaderException.Create(reader, StringUtils.FormatWith("Error reading JConstructor from JsonReader. Current JsonReader item is not a constructor: {0}", CultureInfo.InvariantCulture, reader.TokenType));
			}
			JConstructor jConstructor = new JConstructor((string)reader.Value);
			jConstructor.SetLineInfo(reader as IJsonLineInfo);
			jConstructor.ReadTokenFrom(reader);
			return jConstructor;
		}

		// Token: 0x060008C3 RID: 2243
		// RVA: 0x0003D528 File Offset: 0x0003B728
		internal override void MergeItem(object content, JsonMergeSettings settings)
		{
			JConstructor jConstructor = content as JConstructor;
			if (jConstructor == null)
			{
				return;
			}
			if (jConstructor.Name != null)
			{
				this.Name = jConstructor.Name;
			}
			JContainer.MergeEnumerableContent(this, jConstructor, settings);
		}

		// Token: 0x060008CE RID: 2254
		// RVA: 0x0003D590 File Offset: 0x0003B790
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
			writer.WriteStartConstructor(this._name);
			foreach (JToken current in this.Children())
			{
				current.WriteTo(writer, converters);
			}
			writer.WriteEndConstructor();
		}
	}
}
