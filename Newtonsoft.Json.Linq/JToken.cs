using Newtonsoft.Json.Linq.JsonPath;
using Newtonsoft.Json.Utilities;
using Newtonsoft.Json.Utilities.LinqBridge;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000A6 RID: 166
	public abstract class JToken : IEnumerable<JToken>, IEnumerable, IJEnumerable<JToken>, ICloneable, IJsonLineInfo
	{
		// Token: 0x020000A7 RID: 167
		private sealed class LineInfoAnnotation
		{
			// Token: 0x0400029E RID: 670
			internal readonly int LineNumber;

			// Token: 0x0400029F RID: 671
			internal readonly int LinePosition;

			// Token: 0x06000574 RID: 1396
			// RVA: 0x000092A3 File Offset: 0x000074A3
			public LineInfoAnnotation(int lineNumber, int linePosition)
			{
				this.LineNumber = lineNumber;
				this.LinePosition = linePosition;
			}
		}

		// Token: 0x04000295 RID: 661
		private static readonly JTokenType[] BooleanTypes = new JTokenType[]
		{
			JTokenType.Integer,
			JTokenType.Float,
			JTokenType.String,
			JTokenType.Comment,
			JTokenType.Raw,
			JTokenType.Boolean
		};

		// Token: 0x0400029D RID: 669
		private static readonly JTokenType[] BytesTypes = new JTokenType[]
		{
			JTokenType.Bytes,
			JTokenType.String,
			JTokenType.Comment,
			JTokenType.Raw,
			JTokenType.Integer
		};

		// Token: 0x0400029B RID: 667
		private static readonly JTokenType[] CharTypes = new JTokenType[]
		{
			JTokenType.Integer,
			JTokenType.Float,
			JTokenType.String,
			JTokenType.Comment,
			JTokenType.Raw
		};

		// Token: 0x0400029C RID: 668
		private static readonly JTokenType[] DateTimeTypes = new JTokenType[]
		{
			JTokenType.Date,
			JTokenType.String,
			JTokenType.Comment,
			JTokenType.Raw
		};

		// Token: 0x04000298 RID: 664
		private static readonly JTokenType[] GuidTypes = new JTokenType[]
		{
			JTokenType.String,
			JTokenType.Comment,
			JTokenType.Raw,
			JTokenType.Guid,
			JTokenType.Bytes
		};

		// Token: 0x04000296 RID: 662
		private static readonly JTokenType[] NumberTypes = new JTokenType[]
		{
			JTokenType.Integer,
			JTokenType.Float,
			JTokenType.String,
			JTokenType.Comment,
			JTokenType.Raw,
			JTokenType.Boolean
		};

		// Token: 0x04000297 RID: 663
		private static readonly JTokenType[] StringTypes = new JTokenType[]
		{
			JTokenType.Date,
			JTokenType.Integer,
			JTokenType.Float,
			JTokenType.String,
			JTokenType.Comment,
			JTokenType.Raw,
			JTokenType.Boolean,
			JTokenType.Bytes,
			JTokenType.Guid,
			JTokenType.TimeSpan,
			JTokenType.Uri
		};

		// Token: 0x04000299 RID: 665
		private static readonly JTokenType[] TimeSpanTypes = new JTokenType[]
		{
			JTokenType.String,
			JTokenType.Comment,
			JTokenType.Raw,
			JTokenType.TimeSpan
		};

		// Token: 0x0400029A RID: 666
		private static readonly JTokenType[] UriTypes = new JTokenType[]
		{
			JTokenType.String,
			JTokenType.Comment,
			JTokenType.Raw,
			JTokenType.Uri
		};

		// Token: 0x04000294 RID: 660
		private object _annotations;

		// Token: 0x04000290 RID: 656
		private static JTokenEqualityComparer _equalityComparer;

		// Token: 0x04000293 RID: 659
		private JToken _next;

		// Token: 0x04000291 RID: 657
		private JContainer _parent;

		// Token: 0x04000292 RID: 658
		private JToken _previous;

		// Token: 0x170000B0 RID: 176
		public static JTokenEqualityComparer EqualityComparer
		{
			// Token: 0x060004E8 RID: 1256
			// RVA: 0x00008F24 File Offset: 0x00007124
			get
			{
				if (JToken._equalityComparer == null)
				{
					JToken._equalityComparer = new JTokenEqualityComparer();
				}
				return JToken._equalityComparer;
			}
		}

		// Token: 0x170000B9 RID: 185
		public virtual JToken First
		{
			// Token: 0x06000501 RID: 1281
			// RVA: 0x00008F98 File Offset: 0x00007198
			get
			{
				throw new InvalidOperationException(StringUtils.FormatWith("Cannot access child value on {0}.", CultureInfo.InvariantCulture, base.GetType()));
			}
		}

		// Token: 0x170000B4 RID: 180
		public abstract bool HasValues
		{
			// Token: 0x060004EF RID: 1263
			get;
		}

		// Token: 0x170000B8 RID: 184
		public virtual JToken this[object key]
		{
			// Token: 0x060004FE RID: 1278
			// RVA: 0x00008F98 File Offset: 0x00007198
			get
			{
				throw new InvalidOperationException(StringUtils.FormatWith("Cannot access child value on {0}.", CultureInfo.InvariantCulture, base.GetType()));
			}
			// Token: 0x060004FF RID: 1279
			// RVA: 0x00008FB4 File Offset: 0x000071B4
			set
			{
				throw new InvalidOperationException(StringUtils.FormatWith("Cannot set child value on {0}.", CultureInfo.InvariantCulture, base.GetType()));
			}
		}

		// Token: 0x170000BA RID: 186
		public virtual JToken Last
		{
			// Token: 0x06000502 RID: 1282
			// RVA: 0x00008F98 File Offset: 0x00007198
			get
			{
				throw new InvalidOperationException(StringUtils.FormatWith("Cannot access child value on {0}.", CultureInfo.InvariantCulture, base.GetType()));
			}
		}

		// Token: 0x170000BC RID: 188
		int IJsonLineInfo.LineNumber
		{
			// Token: 0x06000564 RID: 1380
			// RVA: 0x000347F0 File Offset: 0x000329F0
			get
			{
				JToken.LineInfoAnnotation lineInfoAnnotation = this.Annotation<JToken.LineInfoAnnotation>();
				if (lineInfoAnnotation != null)
				{
					return lineInfoAnnotation.LineNumber;
				}
				return 0;
			}
		}

		// Token: 0x170000BD RID: 189
		int IJsonLineInfo.LinePosition
		{
			// Token: 0x06000565 RID: 1381
			// RVA: 0x00034810 File Offset: 0x00032A10
			get
			{
				JToken.LineInfoAnnotation lineInfoAnnotation = this.Annotation<JToken.LineInfoAnnotation>();
				if (lineInfoAnnotation != null)
				{
					return lineInfoAnnotation.LinePosition;
				}
				return 0;
			}
		}

		// Token: 0x170000BB RID: 187
		IJEnumerable<JToken> IJEnumerable<JToken>.this[object key]
		{
			// Token: 0x06000555 RID: 1365
			// RVA: 0x000091DE File Offset: 0x000073DE
			get
			{
				return this[key];
			}
		}

		// Token: 0x170000B5 RID: 181
		public JToken Next
		{
			// Token: 0x060004F1 RID: 1265
			// RVA: 0x00008F64 File Offset: 0x00007164
			get
			{
				return this._next;
			}
			// Token: 0x060004F2 RID: 1266
			// RVA: 0x00008F6C File Offset: 0x0000716C
			internal set
			{
				this._next = value;
			}
		}

		// Token: 0x170000B1 RID: 177
		public JContainer Parent
		{
			// Token: 0x060004E9 RID: 1257
			// RVA: 0x00008F3C File Offset: 0x0000713C
			[DebuggerStepThrough]
			get
			{
				return this._parent;
			}
			// Token: 0x060004EA RID: 1258
			// RVA: 0x00008F44 File Offset: 0x00007144
			internal set
			{
				this._parent = value;
			}
		}

		// Token: 0x170000B7 RID: 183
		public string Path
		{
			// Token: 0x060004F5 RID: 1269
			// RVA: 0x000331BC File Offset: 0x000313BC
			get
			{
				if (this.Parent == null)
				{
					return string.Empty;
				}
				IList<JToken> list = Enumerable.ToList<JToken>(Enumerable.Reverse<JToken>(this.AncestorsAndSelf()));
				IList<JsonPosition> list2 = new List<JsonPosition>();
				for (int i = 0; i < list.Count; i++)
				{
					JToken jToken = list[i];
					JToken jToken2 = null;
					if (i + 1 < list.Count)
					{
						jToken2 = list[i + 1];
					}
					else if (list[i].Type == JTokenType.Property)
					{
						jToken2 = list[i];
					}
					if (jToken2 != null)
					{
						switch (jToken.Type)
						{
						case JTokenType.Array:
						case JTokenType.Constructor:
						{
							int position = ((IList<JToken>)jToken).IndexOf(jToken2);
							list2.Add(new JsonPosition(JsonContainerType.Array)
							{
								Position = position
							});
							break;
						}
						case JTokenType.Property:
						{
							JProperty jProperty = (JProperty)jToken;
							list2.Add(new JsonPosition(JsonContainerType.Object)
							{
								PropertyName = jProperty.Name
							});
							break;
						}
						}
					}
				}
				return JsonPosition.BuildPath(list2);
			}
		}

		// Token: 0x170000B6 RID: 182
		public JToken Previous
		{
			// Token: 0x060004F3 RID: 1267
			// RVA: 0x00008F75 File Offset: 0x00007175
			get
			{
				return this._previous;
			}
			// Token: 0x060004F4 RID: 1268
			// RVA: 0x00008F7D File Offset: 0x0000717D
			internal set
			{
				this._previous = value;
			}
		}

		// Token: 0x170000B2 RID: 178
		public JToken Root
		{
			// Token: 0x060004EB RID: 1259
			// RVA: 0x00033190 File Offset: 0x00031390
			get
			{
				JContainer parent = this.Parent;
				if (parent == null)
				{
					return this;
				}
				while (parent.Parent != null)
				{
					parent = parent.Parent;
				}
				return parent;
			}
		}

		// Token: 0x170000B3 RID: 179
		public abstract JTokenType Type
		{
			// Token: 0x060004EE RID: 1262
			get;
		}

		// Token: 0x060004F6 RID: 1270
		// RVA: 0x00005E0F File Offset: 0x0000400F
		internal JToken()
		{
		}

		// Token: 0x060004F7 RID: 1271
		// RVA: 0x000332BC File Offset: 0x000314BC
		public void AddAfterSelf(object content)
		{
			if (this._parent == null)
			{
				throw new InvalidOperationException("The parent is missing.");
			}
			int num = this._parent.IndexOfItem(this);
			this._parent.AddInternal(num + 1, content, false);
		}

		// Token: 0x0600056C RID: 1388
		// RVA: 0x000348B4 File Offset: 0x00032AB4
		public void AddAnnotation(object annotation)
		{
			if (annotation == null)
			{
				throw new ArgumentNullException("annotation");
			}
			if (this._annotations == null)
			{
				this._annotations = ((annotation is object[]) ? new object[]
				{
					annotation
				} : annotation);
				return;
			}
			object[] array = this._annotations as object[];
			if (array == null)
			{
				this._annotations = new object[]
				{
					this._annotations,
					annotation
				};
				return;
			}
			int num = 0;
			while (num < array.Length && array[num] != null)
			{
				num++;
			}
			if (num == array.Length)
			{
				Array.Resize<object>(ref array, num * 2);
				this._annotations = array;
			}
			array[num] = annotation;
		}

		// Token: 0x060004F8 RID: 1272
		// RVA: 0x000332FC File Offset: 0x000314FC
		public void AddBeforeSelf(object content)
		{
			if (this._parent == null)
			{
				throw new InvalidOperationException("The parent is missing.");
			}
			int index = this._parent.IndexOfItem(this);
			this._parent.AddInternal(index, content, false);
		}

		// Token: 0x060004FC RID: 1276
		// RVA: 0x0003335C File Offset: 0x0003155C
		public IEnumerable<JToken> AfterSelf()
		{
			JToken.<AfterSelf>d__6 <AfterSelf>d__ = new JToken.<AfterSelf>d__6(-2);
			<AfterSelf>d__.<>4__this = this;
			return <AfterSelf>d__;
		}

		// Token: 0x060004F9 RID: 1273
		// RVA: 0x00008F86 File Offset: 0x00007186
		public IEnumerable<JToken> Ancestors()
		{
			return this.GetAncestors(false);
		}

		// Token: 0x060004FA RID: 1274
		// RVA: 0x00008F8F File Offset: 0x0000718F
		public IEnumerable<JToken> AncestorsAndSelf()
		{
			return this.GetAncestors(true);
		}

		// Token: 0x0600056D RID: 1389
		// RVA: 0x00034950 File Offset: 0x00032B50
		public T Annotation<T>() where T : class
		{
			if (this._annotations != null)
			{
				object[] array = this._annotations as object[];
				if (array == null)
				{
					return this._annotations as T;
				}
				for (int i = 0; i < array.Length; i++)
				{
					object obj = array[i];
					if (obj == null)
					{
						break;
					}
					T t = obj as T;
					if (t != null)
					{
						return t;
					}
				}
			}
			return default(T);
		}

		// Token: 0x0600056E RID: 1390
		// RVA: 0x000349BC File Offset: 0x00032BBC
		public object Annotation(Type type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			if (this._annotations != null)
			{
				object[] array = this._annotations as object[];
				if (array == null)
				{
					if (type.IsInstanceOfType(this._annotations))
					{
						return this._annotations;
					}
				}
				else
				{
					for (int i = 0; i < array.Length; i++)
					{
						object obj = array[i];
						if (obj == null)
						{
							break;
						}
						if (type.IsInstanceOfType(obj))
						{
							return obj;
						}
					}
				}
			}
			return null;
		}

		// Token: 0x0600056F RID: 1391
		// RVA: 0x00034A28 File Offset: 0x00032C28
		public IEnumerable<T> Annotations<T>() where T : class
		{
			if (this._annotations != null)
			{
				object[] array = this._annotations as object[];
				if (array != null)
				{
					for (int i = 0; i < array.Length; i++)
					{
						object obj = array[i];
						if (obj == null)
						{
							break;
						}
						T t = obj as T;
						if (t != null)
						{
							yield return t;
						}
					}
				}
				else
				{
					T t2 = this._annotations as T;
					if (t2 != null)
					{
						yield return t2;
					}
				}
			}
			yield break;
		}

		// Token: 0x06000570 RID: 1392
		// RVA: 0x00034A48 File Offset: 0x00032C48
		public IEnumerable<object> Annotations(Type type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			if (this._annotations != null)
			{
				object[] array = this._annotations as object[];
				if (array != null)
				{
					for (int i = 0; i < array.Length; i++)
					{
						object obj = array[i];
						if (obj == null)
						{
							break;
						}
						if (type.IsInstanceOfType(obj))
						{
							yield return obj;
						}
					}
				}
				else if (type.IsInstanceOfType(this._annotations))
				{
					yield return this._annotations;
				}
			}
			yield break;
		}

		// Token: 0x060004FD RID: 1277
		// RVA: 0x0003337C File Offset: 0x0003157C
		public IEnumerable<JToken> BeforeSelf()
		{
			JToken.<BeforeSelf>d__a <BeforeSelf>d__a = new JToken.<BeforeSelf>d__a(-2);
			<BeforeSelf>d__a.<>4__this = this;
			return <BeforeSelf>d__a;
		}

		// Token: 0x06000503 RID: 1283
		// RVA: 0x00008FD0 File Offset: 0x000071D0
		public virtual JEnumerable<JToken> Children()
		{
			return JEnumerable<JToken>.Empty;
		}

		// Token: 0x06000504 RID: 1284
		// RVA: 0x00008FD7 File Offset: 0x000071D7
		public JEnumerable<T> Children<T>() where T : JToken
		{
			return new JEnumerable<T>(Enumerable.OfType<T>(this.Children()));
		}

		// Token: 0x060004EC RID: 1260
		internal abstract JToken CloneToken();

		// Token: 0x06000556 RID: 1366
		// RVA: 0x000091E7 File Offset: 0x000073E7
		public JsonReader CreateReader()
		{
			return new JTokenReader(this, this.Path);
		}

		// Token: 0x0600056B RID: 1387
		// RVA: 0x0000929B File Offset: 0x0000749B
		public JToken DeepClone()
		{
			return this.CloneToken();
		}

		// Token: 0x060004ED RID: 1261
		internal abstract bool DeepEquals(JToken node);

		// Token: 0x060004F0 RID: 1264
		// RVA: 0x00008F4D File Offset: 0x0000714D
		public static bool DeepEquals(JToken t1, JToken t2)
		{
			return t1 == t2 || (t1 != null && t2 != null && t1.DeepEquals(t2));
		}

		// Token: 0x0600050B RID: 1291
		// RVA: 0x00033418 File Offset: 0x00031618
		private static JValue EnsureValue(JToken value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (value is JProperty)
			{
				value = ((JProperty)value).Value;
			}
			return value as JValue;
		}

		// Token: 0x06000558 RID: 1368
		// RVA: 0x000091F5 File Offset: 0x000073F5
		public static JToken FromObject(object o)
		{
			return JToken.FromObjectInternal(o, JsonSerializer.CreateDefault());
		}

		// Token: 0x06000559 RID: 1369
		// RVA: 0x00009202 File Offset: 0x00007402
		public static JToken FromObject(object o, JsonSerializer jsonSerializer)
		{
			return JToken.FromObjectInternal(o, jsonSerializer);
		}

		// Token: 0x06000557 RID: 1367
		// RVA: 0x0003430C File Offset: 0x0003250C
		internal static JToken FromObjectInternal(object o, JsonSerializer jsonSerializer)
		{
			ValidationUtils.ArgumentNotNull(o, "o");
			ValidationUtils.ArgumentNotNull(jsonSerializer, "jsonSerializer");
			JToken token;
			using (JTokenWriter jTokenWriter = new JTokenWriter())
			{
				jsonSerializer.Serialize(jTokenWriter, o);
				token = jTokenWriter.Token;
			}
			return token;
		}

		// Token: 0x060004FB RID: 1275
		// RVA: 0x00033338 File Offset: 0x00031538
		internal IEnumerable<JToken> GetAncestors(bool self)
		{
			JToken.<GetAncestors>d__2 <GetAncestors>d__ = new JToken.<GetAncestors>d__2(-2);
			<GetAncestors>d__.<>4__this = this;
			<GetAncestors>d__.<>3__self = self;
			return <GetAncestors>d__;
		}

		// Token: 0x06000554 RID: 1364
		internal abstract int GetDeepHashCode();

		// Token: 0x0600050C RID: 1292
		// RVA: 0x00009041 File Offset: 0x00007241
		private static string GetType(JToken token)
		{
			ValidationUtils.ArgumentNotNull(token, "token");
			if (token is JProperty)
			{
				token = ((JProperty)token).Value;
			}
			return token.Type.ToString();
		}

		// Token: 0x06000560 RID: 1376
		// RVA: 0x0000923A File Offset: 0x0000743A
		public static JToken Load(JsonReader reader)
		{
			return JToken.ReadFrom(reader);
		}

		// Token: 0x06000563 RID: 1379
		// RVA: 0x00009271 File Offset: 0x00007471
		bool IJsonLineInfo.HasLineInfo()
		{
			return this.Annotation<JToken.LineInfoAnnotation>() != null;
		}

		// Token: 0x0600050E RID: 1294
		// RVA: 0x00033450 File Offset: 0x00031650
		public static explicit operator bool(JToken value)
		{
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateToken(jValue, JToken.BooleanTypes, false))
			{
				throw new ArgumentException(StringUtils.FormatWith("Can not convert {0} to Boolean.", CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			return Convert.ToBoolean(jValue.Value, CultureInfo.InvariantCulture);
		}

		// Token: 0x0600050F RID: 1295
		// RVA: 0x000334A0 File Offset: 0x000316A0
		public static explicit operator bool?(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateToken(jValue, JToken.BooleanTypes, true))
			{
				throw new ArgumentException(StringUtils.FormatWith("Can not convert {0} to Boolean.", CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			if (jValue.Value == null)
			{
				return null;
			}
			return new bool?(Convert.ToBoolean(jValue.Value, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000510 RID: 1296
		// RVA: 0x00033514 File Offset: 0x00031714
		public static explicit operator long(JToken value)
		{
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateToken(jValue, JToken.NumberTypes, false))
			{
				throw new ArgumentException(StringUtils.FormatWith("Can not convert {0} to Int64.", CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			return Convert.ToInt64(jValue.Value, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000511 RID: 1297
		// RVA: 0x00033564 File Offset: 0x00031764
		public static explicit operator DateTime?(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateToken(jValue, JToken.DateTimeTypes, true))
			{
				throw new ArgumentException(StringUtils.FormatWith("Can not convert {0} to DateTime.", CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			if (jValue.Value == null)
			{
				return null;
			}
			return new DateTime?(Convert.ToDateTime(jValue.Value, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000512 RID: 1298
		// RVA: 0x000335D8 File Offset: 0x000317D8
		public static explicit operator decimal?(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateToken(jValue, JToken.NumberTypes, true))
			{
				throw new ArgumentException(StringUtils.FormatWith("Can not convert {0} to Decimal.", CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			if (jValue.Value == null)
			{
				return null;
			}
			return new decimal?(Convert.ToDecimal(jValue.Value, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000513 RID: 1299
		// RVA: 0x0003364C File Offset: 0x0003184C
		public static explicit operator double?(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateToken(jValue, JToken.NumberTypes, true))
			{
				throw new ArgumentException(StringUtils.FormatWith("Can not convert {0} to Double.", CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			if (jValue.Value == null)
			{
				return null;
			}
			return new double?(Convert.ToDouble(jValue.Value, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000514 RID: 1300
		// RVA: 0x000336C0 File Offset: 0x000318C0
		public static explicit operator char?(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateToken(jValue, JToken.CharTypes, true))
			{
				throw new ArgumentException(StringUtils.FormatWith("Can not convert {0} to Char.", CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			if (jValue.Value == null)
			{
				return null;
			}
			return new char?(Convert.ToChar(jValue.Value, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000515 RID: 1301
		// RVA: 0x00033734 File Offset: 0x00031934
		public static explicit operator int(JToken value)
		{
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateToken(jValue, JToken.NumberTypes, false))
			{
				throw new ArgumentException(StringUtils.FormatWith("Can not convert {0} to Int32.", CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			return Convert.ToInt32(jValue.Value, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000516 RID: 1302
		// RVA: 0x00033784 File Offset: 0x00031984
		public static explicit operator short(JToken value)
		{
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateToken(jValue, JToken.NumberTypes, false))
			{
				throw new ArgumentException(StringUtils.FormatWith("Can not convert {0} to Int16.", CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			return Convert.ToInt16(jValue.Value, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000517 RID: 1303
		// RVA: 0x000337D4 File Offset: 0x000319D4
		[CLSCompliant(false)]
		public static explicit operator ushort(JToken value)
		{
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateToken(jValue, JToken.NumberTypes, false))
			{
				throw new ArgumentException(StringUtils.FormatWith("Can not convert {0} to UInt16.", CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			return Convert.ToUInt16(jValue.Value, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000518 RID: 1304
		// RVA: 0x00033824 File Offset: 0x00031A24
		[CLSCompliant(false)]
		public static explicit operator char(JToken value)
		{
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateToken(jValue, JToken.CharTypes, false))
			{
				throw new ArgumentException(StringUtils.FormatWith("Can not convert {0} to Char.", CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			return Convert.ToChar(jValue.Value, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000519 RID: 1305
		// RVA: 0x00033874 File Offset: 0x00031A74
		public static explicit operator byte(JToken value)
		{
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateToken(jValue, JToken.NumberTypes, false))
			{
				throw new ArgumentException(StringUtils.FormatWith("Can not convert {0} to Byte.", CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			return Convert.ToByte(jValue.Value, CultureInfo.InvariantCulture);
		}

		// Token: 0x0600051A RID: 1306
		// RVA: 0x000338C4 File Offset: 0x00031AC4
		[CLSCompliant(false)]
		public static explicit operator sbyte(JToken value)
		{
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateToken(jValue, JToken.NumberTypes, false))
			{
				throw new ArgumentException(StringUtils.FormatWith("Can not convert {0} to SByte.", CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			return Convert.ToSByte(jValue.Value, CultureInfo.InvariantCulture);
		}

		// Token: 0x0600051B RID: 1307
		// RVA: 0x00033914 File Offset: 0x00031B14
		public static explicit operator int?(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateToken(jValue, JToken.NumberTypes, true))
			{
				throw new ArgumentException(StringUtils.FormatWith("Can not convert {0} to Int32.", CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			if (jValue.Value == null)
			{
				return null;
			}
			return new int?(Convert.ToInt32(jValue.Value, CultureInfo.InvariantCulture));
		}

		// Token: 0x0600051C RID: 1308
		// RVA: 0x00033988 File Offset: 0x00031B88
		public static explicit operator short?(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateToken(jValue, JToken.NumberTypes, true))
			{
				throw new ArgumentException(StringUtils.FormatWith("Can not convert {0} to Int16.", CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			if (jValue.Value == null)
			{
				return null;
			}
			return new short?(Convert.ToInt16(jValue.Value, CultureInfo.InvariantCulture));
		}

		// Token: 0x0600051D RID: 1309
		// RVA: 0x000339FC File Offset: 0x00031BFC
		[CLSCompliant(false)]
		public static explicit operator ushort?(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateToken(jValue, JToken.NumberTypes, true))
			{
				throw new ArgumentException(StringUtils.FormatWith("Can not convert {0} to UInt16.", CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			if (jValue.Value == null)
			{
				return null;
			}
			return new ushort?(Convert.ToUInt16(jValue.Value, CultureInfo.InvariantCulture));
		}

		// Token: 0x0600051E RID: 1310
		// RVA: 0x00033A70 File Offset: 0x00031C70
		public static explicit operator byte?(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateToken(jValue, JToken.NumberTypes, true))
			{
				throw new ArgumentException(StringUtils.FormatWith("Can not convert {0} to Byte.", CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			if (jValue.Value == null)
			{
				return null;
			}
			return new byte?(Convert.ToByte(jValue.Value, CultureInfo.InvariantCulture));
		}

		// Token: 0x0600051F RID: 1311
		// RVA: 0x00033AE4 File Offset: 0x00031CE4
		[CLSCompliant(false)]
		public static explicit operator sbyte?(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateToken(jValue, JToken.NumberTypes, true))
			{
				throw new ArgumentException(StringUtils.FormatWith("Can not convert {0} to SByte.", CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			if (jValue.Value == null)
			{
				return null;
			}
			return new sbyte?(Convert.ToSByte(jValue.Value, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000520 RID: 1312
		// RVA: 0x00033B58 File Offset: 0x00031D58
		public static explicit operator DateTime(JToken value)
		{
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateToken(jValue, JToken.DateTimeTypes, false))
			{
				throw new ArgumentException(StringUtils.FormatWith("Can not convert {0} to DateTime.", CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			return Convert.ToDateTime(jValue.Value, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000521 RID: 1313
		// RVA: 0x00033BA8 File Offset: 0x00031DA8
		public static explicit operator long?(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateToken(jValue, JToken.NumberTypes, true))
			{
				throw new ArgumentException(StringUtils.FormatWith("Can not convert {0} to Int64.", CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			if (jValue.Value == null)
			{
				return null;
			}
			return new long?(Convert.ToInt64(jValue.Value, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000522 RID: 1314
		// RVA: 0x00033C1C File Offset: 0x00031E1C
		public static explicit operator float?(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateToken(jValue, JToken.NumberTypes, true))
			{
				throw new ArgumentException(StringUtils.FormatWith("Can not convert {0} to Single.", CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			if (jValue.Value == null)
			{
				return null;
			}
			return new float?(Convert.ToSingle(jValue.Value, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000523 RID: 1315
		// RVA: 0x00033C90 File Offset: 0x00031E90
		public static explicit operator decimal(JToken value)
		{
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateToken(jValue, JToken.NumberTypes, false))
			{
				throw new ArgumentException(StringUtils.FormatWith("Can not convert {0} to Decimal.", CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			return Convert.ToDecimal(jValue.Value, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000524 RID: 1316
		// RVA: 0x00033CE0 File Offset: 0x00031EE0
		[CLSCompliant(false)]
		public static explicit operator uint?(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateToken(jValue, JToken.NumberTypes, true))
			{
				throw new ArgumentException(StringUtils.FormatWith("Can not convert {0} to UInt32.", CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			if (jValue.Value == null)
			{
				return null;
			}
			return new uint?(Convert.ToUInt32(jValue.Value, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000525 RID: 1317
		// RVA: 0x00033D54 File Offset: 0x00031F54
		[CLSCompliant(false)]
		public static explicit operator ulong?(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateToken(jValue, JToken.NumberTypes, true))
			{
				throw new ArgumentException(StringUtils.FormatWith("Can not convert {0} to UInt64.", CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			if (jValue.Value == null)
			{
				return null;
			}
			return new ulong?(Convert.ToUInt64(jValue.Value, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000526 RID: 1318
		// RVA: 0x00033DC8 File Offset: 0x00031FC8
		public static explicit operator double(JToken value)
		{
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateToken(jValue, JToken.NumberTypes, false))
			{
				throw new ArgumentException(StringUtils.FormatWith("Can not convert {0} to Double.", CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			return Convert.ToDouble(jValue.Value, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000527 RID: 1319
		// RVA: 0x00033E18 File Offset: 0x00032018
		public static explicit operator float(JToken value)
		{
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateToken(jValue, JToken.NumberTypes, false))
			{
				throw new ArgumentException(StringUtils.FormatWith("Can not convert {0} to Single.", CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			return Convert.ToSingle(jValue.Value, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000528 RID: 1320
		// RVA: 0x00033E68 File Offset: 0x00032068
		public static explicit operator string(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateToken(jValue, JToken.StringTypes, true))
			{
				throw new ArgumentException(StringUtils.FormatWith("Can not convert {0} to String.", CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			if (jValue.Value == null)
			{
				return null;
			}
			if (jValue.Value is byte[])
			{
				return Convert.ToBase64String((byte[])jValue.Value);
			}
			return Convert.ToString(jValue.Value, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000529 RID: 1321
		// RVA: 0x00033EE8 File Offset: 0x000320E8
		[CLSCompliant(false)]
		public static explicit operator uint(JToken value)
		{
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateToken(jValue, JToken.NumberTypes, false))
			{
				throw new ArgumentException(StringUtils.FormatWith("Can not convert {0} to UInt32.", CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			return Convert.ToUInt32(jValue.Value, CultureInfo.InvariantCulture);
		}

		// Token: 0x0600052A RID: 1322
		// RVA: 0x00033F38 File Offset: 0x00032138
		[CLSCompliant(false)]
		public static explicit operator ulong(JToken value)
		{
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateToken(jValue, JToken.NumberTypes, false))
			{
				throw new ArgumentException(StringUtils.FormatWith("Can not convert {0} to UInt64.", CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			return Convert.ToUInt64(jValue.Value, CultureInfo.InvariantCulture);
		}

		// Token: 0x0600052B RID: 1323
		// RVA: 0x00033F88 File Offset: 0x00032188
		public static explicit operator byte[](JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateToken(jValue, JToken.BytesTypes, false))
			{
				throw new ArgumentException(StringUtils.FormatWith("Can not convert {0} to byte array.", CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			if (jValue.Value is string)
			{
				return Convert.FromBase64String(Convert.ToString(jValue.Value, CultureInfo.InvariantCulture));
			}
			if (!(jValue.Value is byte[]))
			{
				throw new ArgumentException(StringUtils.FormatWith("Can not convert {0} to byte array.", CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			return (byte[])jValue.Value;
		}

		// Token: 0x0600052C RID: 1324
		// RVA: 0x00034024 File Offset: 0x00032224
		public static explicit operator Guid(JToken value)
		{
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateToken(jValue, JToken.GuidTypes, false))
			{
				throw new ArgumentException(StringUtils.FormatWith("Can not convert {0} to Guid.", CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			if (jValue.Value is byte[])
			{
				return new Guid((byte[])jValue.Value);
			}
			if (!(jValue.Value is Guid))
			{
				return new Guid(Convert.ToString(jValue.Value, CultureInfo.InvariantCulture));
			}
			return (Guid)jValue.Value;
		}

		// Token: 0x0600052D RID: 1325
		// RVA: 0x000340B0 File Offset: 0x000322B0
		public static explicit operator Guid?(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateToken(jValue, JToken.GuidTypes, true))
			{
				throw new ArgumentException(StringUtils.FormatWith("Can not convert {0} to Guid.", CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			if (jValue.Value == null)
			{
				return null;
			}
			if (jValue.Value is byte[])
			{
				return new Guid?(new Guid((byte[])jValue.Value));
			}
			return new Guid?((jValue.Value is Guid) ? ((Guid)jValue.Value) : new Guid(Convert.ToString(jValue.Value, CultureInfo.InvariantCulture)));
		}

		// Token: 0x0600052E RID: 1326
		// RVA: 0x00034168 File Offset: 0x00032368
		public static explicit operator TimeSpan(JToken value)
		{
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateToken(jValue, JToken.TimeSpanTypes, false))
			{
				throw new ArgumentException(StringUtils.FormatWith("Can not convert {0} to TimeSpan.", CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			if (!(jValue.Value is TimeSpan))
			{
				return ConvertUtils.ParseTimeSpan(Convert.ToString(jValue.Value, CultureInfo.InvariantCulture));
			}
			return (TimeSpan)jValue.Value;
		}

		// Token: 0x0600052F RID: 1327
		// RVA: 0x000341D8 File Offset: 0x000323D8
		public static explicit operator TimeSpan?(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateToken(jValue, JToken.TimeSpanTypes, true))
			{
				throw new ArgumentException(StringUtils.FormatWith("Can not convert {0} to TimeSpan.", CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			if (jValue.Value == null)
			{
				return null;
			}
			return new TimeSpan?((jValue.Value is TimeSpan) ? ((TimeSpan)jValue.Value) : ConvertUtils.ParseTimeSpan(Convert.ToString(jValue.Value, CultureInfo.InvariantCulture)));
		}

		// Token: 0x06000530 RID: 1328
		// RVA: 0x00034270 File Offset: 0x00032470
		public static explicit operator Uri(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateToken(jValue, JToken.UriTypes, true))
			{
				throw new ArgumentException(StringUtils.FormatWith("Can not convert {0} to Uri.", CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			if (jValue.Value == null)
			{
				return null;
			}
			if (!(jValue.Value is Uri))
			{
				return new Uri(Convert.ToString(jValue.Value, CultureInfo.InvariantCulture));
			}
			return (Uri)jValue.Value;
		}

		// Token: 0x06000531 RID: 1329
		// RVA: 0x000090A1 File Offset: 0x000072A1
		public static implicit operator JToken(bool value)
		{
			return new JValue(value);
		}

		// Token: 0x06000532 RID: 1330
		// RVA: 0x000090A9 File Offset: 0x000072A9
		public static implicit operator JToken(byte value)
		{
			return new JValue((long)((ulong)value));
		}

		// Token: 0x06000533 RID: 1331
		// RVA: 0x000090B2 File Offset: 0x000072B2
		public static implicit operator JToken(byte? value)
		{
			return new JValue(value);
		}

		// Token: 0x06000534 RID: 1332
		// RVA: 0x000090BF File Offset: 0x000072BF
		[CLSCompliant(false)]
		public static implicit operator JToken(sbyte value)
		{
			return new JValue((long)value);
		}

		// Token: 0x06000535 RID: 1333
		// RVA: 0x000090C8 File Offset: 0x000072C8
		[CLSCompliant(false)]
		public static implicit operator JToken(sbyte? value)
		{
			return new JValue(value);
		}

		// Token: 0x06000536 RID: 1334
		// RVA: 0x000090D5 File Offset: 0x000072D5
		public static implicit operator JToken(bool? value)
		{
			return new JValue(value);
		}

		// Token: 0x06000537 RID: 1335
		// RVA: 0x000090E2 File Offset: 0x000072E2
		public static implicit operator JToken(long value)
		{
			return new JValue(value);
		}

		// Token: 0x06000538 RID: 1336
		// RVA: 0x000090EA File Offset: 0x000072EA
		public static implicit operator JToken(DateTime? value)
		{
			return new JValue(value);
		}

		// Token: 0x06000539 RID: 1337
		// RVA: 0x000090F7 File Offset: 0x000072F7
		public static implicit operator JToken(decimal? value)
		{
			return new JValue(value);
		}

		// Token: 0x0600053A RID: 1338
		// RVA: 0x00009104 File Offset: 0x00007304
		public static implicit operator JToken(double? value)
		{
			return new JValue(value);
		}

		// Token: 0x0600053B RID: 1339
		// RVA: 0x000090BF File Offset: 0x000072BF
		[CLSCompliant(false)]
		public static implicit operator JToken(short value)
		{
			return new JValue((long)value);
		}

		// Token: 0x0600053C RID: 1340
		// RVA: 0x000090A9 File Offset: 0x000072A9
		[CLSCompliant(false)]
		public static implicit operator JToken(ushort value)
		{
			return new JValue((long)((ulong)value));
		}

		// Token: 0x0600053D RID: 1341
		// RVA: 0x000090BF File Offset: 0x000072BF
		public static implicit operator JToken(int value)
		{
			return new JValue((long)value);
		}

		// Token: 0x0600053E RID: 1342
		// RVA: 0x00009111 File Offset: 0x00007311
		public static implicit operator JToken(int? value)
		{
			return new JValue(value);
		}

		// Token: 0x0600053F RID: 1343
		// RVA: 0x0000911E File Offset: 0x0000731E
		public static implicit operator JToken(DateTime value)
		{
			return new JValue(value);
		}

		// Token: 0x06000540 RID: 1344
		// RVA: 0x00009126 File Offset: 0x00007326
		public static implicit operator JToken(long? value)
		{
			return new JValue(value);
		}

		// Token: 0x06000541 RID: 1345
		// RVA: 0x00009133 File Offset: 0x00007333
		public static implicit operator JToken(float? value)
		{
			return new JValue(value);
		}

		// Token: 0x06000542 RID: 1346
		// RVA: 0x00009140 File Offset: 0x00007340
		public static implicit operator JToken(decimal value)
		{
			return new JValue(value);
		}

		// Token: 0x06000543 RID: 1347
		// RVA: 0x00009148 File Offset: 0x00007348
		[CLSCompliant(false)]
		public static implicit operator JToken(short? value)
		{
			return new JValue(value);
		}

		// Token: 0x06000544 RID: 1348
		// RVA: 0x00009155 File Offset: 0x00007355
		[CLSCompliant(false)]
		public static implicit operator JToken(ushort? value)
		{
			return new JValue(value);
		}

		// Token: 0x06000545 RID: 1349
		// RVA: 0x00009162 File Offset: 0x00007362
		[CLSCompliant(false)]
		public static implicit operator JToken(uint? value)
		{
			return new JValue(value);
		}

		// Token: 0x06000546 RID: 1350
		// RVA: 0x0000916F File Offset: 0x0000736F
		[CLSCompliant(false)]
		public static implicit operator JToken(ulong? value)
		{
			return new JValue(value);
		}

		// Token: 0x06000547 RID: 1351
		// RVA: 0x0000917C File Offset: 0x0000737C
		public static implicit operator JToken(double value)
		{
			return new JValue(value);
		}

		// Token: 0x06000548 RID: 1352
		// RVA: 0x00009184 File Offset: 0x00007384
		public static implicit operator JToken(float value)
		{
			return new JValue(value);
		}

		// Token: 0x06000549 RID: 1353
		// RVA: 0x0000918C File Offset: 0x0000738C
		public static implicit operator JToken(string value)
		{
			return new JValue(value);
		}

		// Token: 0x0600054A RID: 1354
		// RVA: 0x000090A9 File Offset: 0x000072A9
		[CLSCompliant(false)]
		public static implicit operator JToken(uint value)
		{
			return new JValue((long)((ulong)value));
		}

		// Token: 0x0600054B RID: 1355
		// RVA: 0x00009194 File Offset: 0x00007394
		[CLSCompliant(false)]
		public static implicit operator JToken(ulong value)
		{
			return new JValue(value);
		}

		// Token: 0x0600054C RID: 1356
		// RVA: 0x0000919C File Offset: 0x0000739C
		public static implicit operator JToken(byte[] value)
		{
			return new JValue(value);
		}

		// Token: 0x0600054D RID: 1357
		// RVA: 0x000091A4 File Offset: 0x000073A4
		public static implicit operator JToken(Uri value)
		{
			return new JValue(value);
		}

		// Token: 0x0600054E RID: 1358
		// RVA: 0x000091AC File Offset: 0x000073AC
		public static implicit operator JToken(TimeSpan value)
		{
			return new JValue(value);
		}

		// Token: 0x0600054F RID: 1359
		// RVA: 0x000091B4 File Offset: 0x000073B4
		public static implicit operator JToken(TimeSpan? value)
		{
			return new JValue(value);
		}

		// Token: 0x06000550 RID: 1360
		// RVA: 0x000091C1 File Offset: 0x000073C1
		public static implicit operator JToken(Guid value)
		{
			return new JValue(value);
		}

		// Token: 0x06000551 RID: 1361
		// RVA: 0x000091C9 File Offset: 0x000073C9
		public static implicit operator JToken(Guid? value)
		{
			return new JValue(value);
		}

		// Token: 0x0600055F RID: 1375
		// RVA: 0x00034794 File Offset: 0x00032994
		public static JToken Parse(string json)
		{
			JToken result;
			using (JsonReader jsonReader = new JsonTextReader(new StringReader(json)))
			{
				JToken jToken = JToken.Load(jsonReader);
				if (jsonReader.Read() && jsonReader.TokenType != JsonToken.Comment)
				{
					throw JsonReaderException.Create(jsonReader, "Additional text found in JSON string after parsing content.");
				}
				result = jToken;
			}
			return result;
		}

		// Token: 0x0600055E RID: 1374
		// RVA: 0x00034678 File Offset: 0x00032878
		public static JToken ReadFrom(JsonReader reader)
		{
			ValidationUtils.ArgumentNotNull(reader, "reader");
			if (reader.TokenType == JsonToken.None && !reader.Read())
			{
				throw JsonReaderException.Create(reader, "Error reading JToken from JsonReader.");
			}
			IJsonLineInfo lineInfo = reader as IJsonLineInfo;
			switch (reader.TokenType)
			{
			case JsonToken.StartObject:
				return JObject.Load(reader);
			case JsonToken.StartArray:
				return JArray.Load(reader);
			case JsonToken.StartConstructor:
				return JConstructor.Load(reader);
			case JsonToken.PropertyName:
				return JProperty.Load(reader);
			case JsonToken.Comment:
			{
				JValue jValue = JValue.CreateComment(reader.Value.ToString());
				jValue.SetLineInfo(lineInfo);
				return jValue;
			}
			case JsonToken.Integer:
			case JsonToken.Float:
			case JsonToken.String:
			case JsonToken.Boolean:
			case JsonToken.Date:
			case JsonToken.Bytes:
			{
				JValue jValue = new JValue(reader.Value);
				jValue.SetLineInfo(lineInfo);
				return jValue;
			}
			case JsonToken.Null:
			{
				JValue jValue = JValue.CreateNull();
				jValue.SetLineInfo(lineInfo);
				return jValue;
			}
			case JsonToken.Undefined:
			{
				JValue jValue = JValue.CreateUndefined();
				jValue.SetLineInfo(lineInfo);
				return jValue;
			}
			}
			throw JsonReaderException.Create(reader, StringUtils.FormatWith("Error reading JToken from JsonReader. Unexpected token: {0}", CultureInfo.InvariantCulture, reader.TokenType));
		}

		// Token: 0x06000506 RID: 1286
		// RVA: 0x00008FEE File Offset: 0x000071EE
		public void Remove()
		{
			if (this._parent == null)
			{
				throw new InvalidOperationException("The parent is missing.");
			}
			this._parent.RemoveItem(this);
		}

		// Token: 0x06000571 RID: 1393
		// RVA: 0x00034A6C File Offset: 0x00032C6C
		public void RemoveAnnotations<T>() where T : class
		{
			if (this._annotations != null)
			{
				object[] array = this._annotations as object[];
				if (array == null)
				{
					if (this._annotations is T)
					{
						this._annotations = null;
						return;
					}
				}
				else
				{
					int i = 0;
					int j = 0;
					while (i < array.Length)
					{
						object obj = array[i];
						if (obj == null)
						{
							break;
						}
						if (!(obj is T))
						{
							array[j++] = obj;
						}
						i++;
					}
					if (j != 0)
					{
						while (j < i)
						{
							array[j++] = null;
						}
						return;
					}
					this._annotations = null;
				}
			}
		}

		// Token: 0x06000572 RID: 1394
		// RVA: 0x00034AE8 File Offset: 0x00032CE8
		public void RemoveAnnotations(Type type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			if (this._annotations != null)
			{
				object[] array = this._annotations as object[];
				if (array == null)
				{
					if (type.IsInstanceOfType(this._annotations))
					{
						this._annotations = null;
						return;
					}
				}
				else
				{
					int i = 0;
					int j = 0;
					while (i < array.Length)
					{
						object obj = array[i];
						if (obj == null)
						{
							break;
						}
						if (!type.IsInstanceOfType(obj))
						{
							array[j++] = obj;
						}
						i++;
					}
					if (j != 0)
					{
						while (j < i)
						{
							array[j++] = null;
						}
						return;
					}
					this._annotations = null;
				}
			}
		}

		// Token: 0x06000507 RID: 1287
		// RVA: 0x00009010 File Offset: 0x00007210
		public void Replace(JToken value)
		{
			if (this._parent == null)
			{
				throw new InvalidOperationException("The parent is missing.");
			}
			this._parent.ReplaceItem(this, value);
		}

		// Token: 0x06000566 RID: 1382
		// RVA: 0x0000927F File Offset: 0x0000747F
		public JToken SelectToken(string path)
		{
			return this.SelectToken(path, false);
		}

		// Token: 0x06000567 RID: 1383
		// RVA: 0x00034830 File Offset: 0x00032A30
		public JToken SelectToken(string path, bool errorWhenNoMatch)
		{
			JPath jPath = new JPath(path);
			JToken jToken = null;
			foreach (JToken current in jPath.Evaluate(this, errorWhenNoMatch))
			{
				if (jToken != null)
				{
					throw new JsonException("Path returned multiple tokens.");
				}
				jToken = current;
			}
			return jToken;
		}

		// Token: 0x06000568 RID: 1384
		// RVA: 0x00009289 File Offset: 0x00007489
		public IEnumerable<JToken> SelectTokens(string path)
		{
			return this.SelectTokens(path, false);
		}

		// Token: 0x06000569 RID: 1385
		// RVA: 0x00034898 File Offset: 0x00032A98
		public IEnumerable<JToken> SelectTokens(string path, bool errorWhenNoMatch)
		{
			JPath jPath = new JPath(path);
			return jPath.Evaluate(this, errorWhenNoMatch);
		}

		// Token: 0x06000561 RID: 1377
		// RVA: 0x00009242 File Offset: 0x00007442
		internal void SetLineInfo(IJsonLineInfo lineInfo)
		{
			if (lineInfo != null && lineInfo.HasLineInfo())
			{
				this.SetLineInfo(lineInfo.LineNumber, lineInfo.LinePosition);
				return;
			}
		}

		// Token: 0x06000562 RID: 1378
		// RVA: 0x00009262 File Offset: 0x00007462
		internal void SetLineInfo(int lineNumber, int linePosition)
		{
			this.AddAnnotation(new JToken.LineInfoAnnotation(lineNumber, linePosition));
		}

		// Token: 0x06000553 RID: 1363
		// RVA: 0x000342F0 File Offset: 0x000324F0
		IEnumerator<JToken> IEnumerable<JToken>.GetEnumerator()
		{
			return this.Children().GetEnumerator();
		}

		// Token: 0x06000552 RID: 1362
		// RVA: 0x000091D6 File Offset: 0x000073D6
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<JToken>)this).GetEnumerator();
		}

		// Token: 0x0600056A RID: 1386
		// RVA: 0x00009293 File Offset: 0x00007493
		object ICloneable.Clone()
		{
			return this.DeepClone();
		}

		// Token: 0x0600055A RID: 1370
		// RVA: 0x0000920B File Offset: 0x0000740B
		public T ToObject<T>()
		{
			return (T)((object)this.ToObject(typeof(T)));
		}

		// Token: 0x0600055B RID: 1371
		// RVA: 0x00034364 File Offset: 0x00032564
		public object ToObject(Type objectType)
		{
			if (JsonConvert.DefaultSettings == null)
			{
				bool flag;
				PrimitiveTypeCode typeCode = ConvertUtils.GetTypeCode(objectType, out flag);
				if (flag && this.Type == JTokenType.String)
				{
					Type type = TypeExtensions.IsEnum(objectType) ? objectType : Nullable.GetUnderlyingType(objectType);
					object result;
					try
					{
						result = Enum.Parse(type, (string)this, true);
					}
					catch (Exception innerException)
					{
						throw new ArgumentException(StringUtils.FormatWith("Could not convert '{0}' to {1}.", CultureInfo.InvariantCulture, (string)this, type.Name), innerException);
					}
					return result;
				}
				switch (typeCode)
				{
				case PrimitiveTypeCode.Char:
					return (char)this;
				case PrimitiveTypeCode.CharNullable:
					return (char?)this;
				case PrimitiveTypeCode.Boolean:
					return (bool)this;
				case PrimitiveTypeCode.BooleanNullable:
					return (bool?)this;
				case PrimitiveTypeCode.SByte:
					return (sbyte?)this;
				case PrimitiveTypeCode.SByteNullable:
					return (sbyte)this;
				case PrimitiveTypeCode.Int16:
					return (short)this;
				case PrimitiveTypeCode.Int16Nullable:
					return (short?)this;
				case PrimitiveTypeCode.UInt16:
					return (ushort)this;
				case PrimitiveTypeCode.UInt16Nullable:
					return (ushort?)this;
				case PrimitiveTypeCode.Int32:
					return (int)this;
				case PrimitiveTypeCode.Int32Nullable:
					return (int?)this;
				case PrimitiveTypeCode.Byte:
					return (byte)this;
				case PrimitiveTypeCode.ByteNullable:
					return (byte?)this;
				case PrimitiveTypeCode.UInt32:
					return (uint)this;
				case PrimitiveTypeCode.UInt32Nullable:
					return (uint?)this;
				case PrimitiveTypeCode.Int64:
					return (long)this;
				case PrimitiveTypeCode.Int64Nullable:
					return (long?)this;
				case PrimitiveTypeCode.UInt64:
					return (ulong)this;
				case PrimitiveTypeCode.UInt64Nullable:
					return (ulong?)this;
				case PrimitiveTypeCode.Single:
					return (float)this;
				case PrimitiveTypeCode.SingleNullable:
					return (float?)this;
				case PrimitiveTypeCode.Double:
					return (double)this;
				case PrimitiveTypeCode.DoubleNullable:
					return (double?)this;
				case PrimitiveTypeCode.DateTime:
					return (DateTime)this;
				case PrimitiveTypeCode.DateTimeNullable:
					return (DateTime?)this;
				case PrimitiveTypeCode.Decimal:
					return (decimal)this;
				case PrimitiveTypeCode.DecimalNullable:
					return (decimal?)this;
				case PrimitiveTypeCode.Guid:
					return (Guid)this;
				case PrimitiveTypeCode.GuidNullable:
					return (Guid?)this;
				case PrimitiveTypeCode.TimeSpan:
					return (TimeSpan)this;
				case PrimitiveTypeCode.TimeSpanNullable:
					return (TimeSpan?)this;
				case PrimitiveTypeCode.Uri:
					return (Uri)this;
				case PrimitiveTypeCode.String:
					return (string)this;
				}
			}
			return this.ToObject(objectType, JsonSerializer.CreateDefault());
		}

		// Token: 0x0600055C RID: 1372
		// RVA: 0x00009222 File Offset: 0x00007422
		public T ToObject<T>(JsonSerializer jsonSerializer)
		{
			return (T)((object)this.ToObject(typeof(T), jsonSerializer));
		}

		// Token: 0x0600055D RID: 1373
		// RVA: 0x00034630 File Offset: 0x00032830
		public object ToObject(Type objectType, JsonSerializer jsonSerializer)
		{
			ValidationUtils.ArgumentNotNull(jsonSerializer, "jsonSerializer");
			object result;
			using (JTokenReader jTokenReader = new JTokenReader(this))
			{
				result = jsonSerializer.Deserialize(jTokenReader, objectType);
			}
			return result;
		}

		// Token: 0x06000509 RID: 1289
		// RVA: 0x00009032 File Offset: 0x00007232
		public override string ToString()
		{
			return this.ToString(Formatting.Indented, new JsonConverter[0]);
		}

		// Token: 0x0600050A RID: 1290
		// RVA: 0x000333C4 File Offset: 0x000315C4
		public string ToString(Formatting formatting, params JsonConverter[] converters)
		{
			string result;
			using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
			{
				this.WriteTo(new JsonTextWriter(stringWriter)
				{
					Formatting = formatting
				}, converters);
				result = stringWriter.ToString();
			}
			return result;
		}

		// Token: 0x0600050D RID: 1293
		// RVA: 0x00009073 File Offset: 0x00007273
		private static bool ValidateToken(JToken o, JTokenType[] validTypes, bool nullable)
		{
			return Array.IndexOf<JTokenType>(validTypes, o.Type) != -1 || (nullable && (o.Type == JTokenType.Null || o.Type == JTokenType.Undefined));
		}

		// Token: 0x06000500 RID: 1280
		// RVA: 0x0003339C File Offset: 0x0003159C
		public virtual T Value<T>(object key)
		{
			JToken jToken = this[key];
			if (jToken != null)
			{
				return Extensions.Convert<JToken, T>(jToken);
			}
			return default(T);
		}

		// Token: 0x06000505 RID: 1285
		// RVA: 0x00008F98 File Offset: 0x00007198
		public virtual IEnumerable<T> Values<T>()
		{
			throw new InvalidOperationException(StringUtils.FormatWith("Cannot access child value on {0}.", CultureInfo.InvariantCulture, base.GetType()));
		}

		// Token: 0x06000508 RID: 1288
		public abstract void WriteTo(JsonWriter writer, params JsonConverter[] converters);
	}
}
