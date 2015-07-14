using Microsoft.Xna.Framework.Graphics;
using ns29;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace ns80
{
	// Token: 0x02000451 RID: 1105
	internal sealed class Class548 : IEnumerable, IEnumerable<string>
	{
		// Token: 0x02000453 RID: 1107
		[CompilerGenerated]
		private sealed class Class549
		{
			// Token: 0x04001BDC RID: 7132
			public string string_0;

			// Token: 0x060023D4 RID: 9172
			// RVA: 0x0001C376 File Offset: 0x0001A576
			public bool method_0(Class553 class553_0)
			{
				return class553_0.string_0 == this.string_0;
			}
		}

		// Token: 0x02000454 RID: 1108
		[CompilerGenerated]
		private sealed class Class550
		{
			// Token: 0x04001BDD RID: 7133
			public string string_0;

			// Token: 0x060023D6 RID: 9174
			// RVA: 0x0001C389 File Offset: 0x0001A589
			public bool method_0(Class553 class553_0)
			{
				return class553_0.string_0 == this.string_0;
			}
		}

		// Token: 0x02000455 RID: 1109
		[CompilerGenerated]
		private sealed class Class551
		{
			// Token: 0x04001BDE RID: 7134
			public string string_0;

			// Token: 0x060023D8 RID: 9176
			// RVA: 0x0001C39C File Offset: 0x0001A59C
			public bool method_0(PropertyInfo propertyInfo_0)
			{
				return propertyInfo_0.Name == this.string_0;
			}

			// Token: 0x060023D9 RID: 9177
			// RVA: 0x0001C39C File Offset: 0x0001A59C
			public bool method_1(FieldInfo fieldInfo_0)
			{
				return fieldInfo_0.Name == this.string_0;
			}
		}

		// Token: 0x02000452 RID: 1106
		// Token: 0x060023D0 RID: 9168
		internal delegate T Delegate36<T>(T gparam_0);

		// Token: 0x04001BDB RID: 7131
		internal bool bool_0 = true;

		// Token: 0x04001BD5 RID: 7125
		private Class544 class544_0;

		// Token: 0x04001BD6 RID: 7126
		private Class544 class544_1;

		// Token: 0x04001BD9 RID: 7129
		private Dictionary<string, string> dictionary_0 = new Dictionary<string, string>();

		// Token: 0x04001BD7 RID: 7127
		private List<PropertyInfo> list_0;

		// Token: 0x04001BD8 RID: 7128
		private List<FieldInfo> list_1;

		// Token: 0x04001BDA RID: 7130
		private List<Class553> list_2 = new List<Class553>();

		// Token: 0x17000379 RID: 889
		internal bool IsEmpty
		{
			// Token: 0x060023B9 RID: 9145
			// RVA: 0x0001C2E6 File Offset: 0x0001A4E6
			get
			{
				return this.list_2.Count == 0;
			}
		}

		// Token: 0x060023BA RID: 9146
		// RVA: 0x0001C2F6 File Offset: 0x0001A4F6
		internal Class548(Class544 class544_2)
		{
			this.class544_0 = class544_2;
		}

		// Token: 0x060023CC RID: 9164
		// RVA: 0x000D7E00 File Offset: 0x000D6000
		public IEnumerator<string> GetEnumerator()
		{
			Class548.Class552 class = new Class548.Class552(0);
			class.class548_0 = this;
			return class;
		}

		// Token: 0x060023BB RID: 9147
		// RVA: 0x000D74E0 File Offset: 0x000D56E0
		internal void method_0(string string_0)
		{
			Class553 class = new Class553(string_0);
			this.list_2.Add(class);
			if (!this.dictionary_0.ContainsKey(class.string_0) && !string_0.Contains("//") && !string.IsNullOrEmpty(string_0))
			{
				this.dictionary_0.Add(class.string_0, class.string_1);
			}
		}

		// Token: 0x060023BC RID: 9148
		// RVA: 0x000D7540 File Offset: 0x000D5740
		private bool method_1(string string_0, ref object object_0, Type type_0)
		{
			Type type = Nullable.GetUnderlyingType(type_0) ?? type_0;
			object_0 = null;
			string text;
			if (this.dictionary_0.TryGetValue(string_0, out text) && (!string.IsNullOrEmpty(text) || type == typeof(string) || type != type_0) && this.method_2(text, ref object_0, type_0))
			{
				return true;
			}
			object_0 = this.method_14(type_0);
			return false;
		}

		// Token: 0x060023C5 RID: 9157
		// RVA: 0x000D7B00 File Offset: 0x000D5D00
		private void method_10(string string_0, object object_0, object object_1, Type type_0, bool bool_1)
		{
			Class548.Class550 class = new Class548.Class550();
			class.string_0 = string_0;
			object object_2;
			Class553 class2;
			if (this.method_1(class.string_0, ref object_2, type_0) && (class2 = this.list_2.Find(new Predicate<Class553>(class.method_0))) != null)
			{
				if (this.method_9(object_2, type_0) != this.method_9(object_0, type_0))
				{
					class2.string_1 = this.method_9(object_0, type_0);
				}
			}
			else if ((object_1 == null && object_0 != null) || this.method_9(object_0, type_0) != this.method_9(object_1, type_0))
			{
				if (bool_1)
				{
					this.list_2.Insert(0, new Class553(class.string_0, this.method_9(object_0, type_0)));
				}
				else
				{
					this.list_2.Add(new Class553(class.string_0, this.method_9(object_0, type_0)));
				}
			}
			this.dictionary_0[class.string_0] = this.method_9(object_0, type_0);
		}

		// Token: 0x060023C8 RID: 9160
		// RVA: 0x000D7D04 File Offset: 0x000D5F04
		internal void method_11<T>(string string_0, List<T> list_3, T gparam_0, bool bool_1)
		{
			string gparam_ = string.Join(",", list_3.ConvertAll<string>(new Converter<T, string>(this.method_15<T>)).ToArray());
			string gparam_2 = this.method_12(this.method_9(gparam_0, typeof(T)), list_3.Count, ",");
			this.WriteValue<string>(string_0, gparam_, gparam_2, bool_1);
		}

		// Token: 0x060023C9 RID: 9161
		// RVA: 0x000D7D68 File Offset: 0x000D5F68
		private string method_12(string string_0, int int_0, string string_1)
		{
			string text = "";
			for (int i = 0; i < int_0; i++)
			{
				text = text + string_0 + ((i < int_0 - 1) ? string_1 : "");
			}
			return text;
		}

		// Token: 0x060023CA RID: 9162
		// RVA: 0x000D7DA0 File Offset: 0x000D5FA0
		internal void method_13<T>(Dictionary<string, T> dictionary_1, T gparam_0)
		{
			foreach (KeyValuePair<string, T> current in dictionary_1)
			{
				this.WriteValue<T>(current.Key, current.Value, gparam_0, false);
			}
		}

		// Token: 0x060023CB RID: 9163
		// RVA: 0x0001C343 File Offset: 0x0001A543
		private object method_14(Type type_0)
		{
			if (type_0.IsValueType)
			{
				return Activator.CreateInstance(type_0, true);
			}
			return null;
		}

		// Token: 0x060023CE RID: 9166
		// RVA: 0x0001C35E File Offset: 0x0001A55E
		[CompilerGenerated]
		private string method_15<T>(T gparam_0)
		{
			return this.method_9(gparam_0, typeof(T));
		}

		// Token: 0x060023BD RID: 9149
		// RVA: 0x000D759C File Offset: 0x000D579C
		private bool method_2(string string_0, ref object object_0, Type type_0)
		{
			Type type = Nullable.GetUnderlyingType(type_0) ?? type_0;
			try
			{
				if (type == typeof(Color))
				{
					string[] array = string_0.Split(new char[]
					{
						','
					});
					switch (array.Length)
					{
					case 3:
					{
						object_0 = Convert.ChangeType(new Color((byte)Convert.ToInt32(array[0]), (byte)Convert.ToInt32(array[1]), (byte)Convert.ToInt32(array[2])), type, Class115.numberFormatInfo_0);
						bool result = true;
						return result;
					}
					case 4:
					{
						object_0 = Convert.ChangeType(new Color((byte)Convert.ToInt32(array[0]), (byte)Convert.ToInt32(array[1]), (byte)Convert.ToInt32(array[2]), (byte)(this.bool_0 ? Convert.ToInt32(array[3]) : 255)), type, Class115.numberFormatInfo_0);
						bool result = true;
						return result;
					}
					default:
					{
						bool result = false;
						return result;
					}
					}
				}
				else if (type == typeof(bool))
				{
					bool flag;
					if (bool.TryParse(string_0, out flag))
					{
						object_0 = Convert.ChangeType(flag, type, Class115.numberFormatInfo_0);
					}
					else
					{
						object_0 = Convert.ChangeType(Convert.ToInt32(string_0), type, Class115.numberFormatInfo_0);
					}
				}
				else if (type.IsEnum)
				{
					object_0 = Enum.Parse(type, string_0, true);
				}
				else
				{
					object_0 = Convert.ChangeType(string_0, type, Class115.numberFormatInfo_0);
				}
			}
			catch
			{
				bool result = false;
				return result;
			}
			return true;
		}

		// Token: 0x060023BE RID: 9150
		// RVA: 0x000D7710 File Offset: 0x000D5910
		internal bool method_3<T>(string string_0, ref T gparam_0)
		{
			object obj;
			if (this.method_1(string_0, ref obj, typeof(T)))
			{
				gparam_0 = (T)((object)obj);
				return true;
			}
			return false;
		}

		// Token: 0x060023BF RID: 9151
		// RVA: 0x000D7744 File Offset: 0x000D5944
		internal void method_4(string string_0)
		{
			Predicate<Class553> predicate = null;
			Class548.Class549 class = new Class548.Class549();
			class.string_0 = string_0;
			if (this.dictionary_0.ContainsKey(class.string_0))
			{
				this.dictionary_0.Remove(class.string_0);
				List<Class553> arg_4B_0 = this.list_2;
				if (predicate == null)
				{
					predicate = new Predicate<Class553>(class.method_0);
				}
				arg_4B_0.RemoveAll(predicate);
			}
		}

		// Token: 0x060023C0 RID: 9152
		// RVA: 0x000D77A4 File Offset: 0x000D59A4
		internal Dictionary<string, string> method_5(Predicate<string> predicate_0)
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			foreach (KeyValuePair<string, string> current in this.dictionary_0)
			{
				if (predicate_0(current.Key))
				{
					dictionary[current.Key] = current.Value;
				}
			}
			return dictionary;
		}

		// Token: 0x060023C1 RID: 9153
		// RVA: 0x000D781C File Offset: 0x000D5A1C
		internal Dictionary<string, T> method_6<T>(Predicate<string> predicate_0)
		{
			Dictionary<string, T> dictionary = new Dictionary<string, T>();
			foreach (KeyValuePair<string, string> current in this.dictionary_0)
			{
				object obj;
				if (predicate_0(current.Key) && this.method_1(current.Key, ref obj, typeof(T)))
				{
					dictionary[current.Key] = (T)((object)obj);
				}
			}
			return dictionary;
		}

		// Token: 0x060023C2 RID: 9154
		// RVA: 0x000D78B0 File Offset: 0x000D5AB0
		internal void method_7<T>(string string_0, List<T> list_3, Class548.Delegate36<T> delegate36_0)
		{
			string text = null;
			if (this.method_3<string>(string_0, ref text))
			{
				string[] array = text.Split(new char[]
				{
					','
				});
				int num = (list_3.Count == 0) ? array.Length : Math.Min(array.Length, list_3.Count);
				for (int i = 0; i < num; i++)
				{
					object obj = null;
					if (this.method_2(array[i], ref obj, typeof(T)))
					{
						T t = (delegate36_0 != null) ? delegate36_0((T)((object)obj)) : ((T)((object)obj));
						if (i == list_3.Count)
						{
							list_3.Add(t);
						}
						else
						{
							list_3[i] = t;
						}
					}
				}
			}
		}

		// Token: 0x060023C3 RID: 9155
		// RVA: 0x000D7960 File Offset: 0x000D5B60
		internal Dictionary<string, T> method_8<T>()
		{
			Dictionary<string, T> dictionary = new Dictionary<string, T>();
			foreach (KeyValuePair<string, string> current in this.dictionary_0)
			{
				T value = default(T);
				if (this.method_3<T>(current.Key, ref value))
				{
					dictionary[current.Key] = value;
				}
			}
			return dictionary;
		}

		// Token: 0x060023C4 RID: 9156
		// RVA: 0x000D79DC File Offset: 0x000D5BDC
		private string method_9(object object_0, Type type_0)
		{
			if (object_0 == null)
			{
				return null;
			}
			Type type = Nullable.GetUnderlyingType(type_0) ?? type_0;
			if (type == typeof(Color))
			{
				Color? color = object_0 as Color?;
				string format = "{0},{1},{2}" + (this.bool_0 ? ",{3}" : "");
				return string.Format(format, new object[]
				{
					color.Value.get_R(),
					color.Value.get_G(),
					color.Value.get_B(),
					color.Value.get_A()
				});
			}
			if (type == typeof(bool))
			{
				return Convert.ToInt32(object_0).ToString(Class115.numberFormatInfo_0);
			}
			if (type != typeof(double))
			{
				if (type != typeof(float))
				{
					return object_0.ToString();
				}
			}
			return Convert.ToDouble(object_0).ToString(Class115.numberFormatInfo_0);
		}

		// Token: 0x060023CD RID: 9165
		// RVA: 0x0001C356 File Offset: 0x0001A556
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x060023C7 RID: 9159
		// RVA: 0x000D7BF0 File Offset: 0x000D5DF0
		internal void WriteValue(string string_0, string string_1, bool bool_1)
		{
			Class548.Class551 class = new Class548.Class551();
			class.string_0 = string_1;
			if (this.class544_1 == null || this.class544_0.GetType() != this.class544_1.GetType())
			{
				this.class544_1 = (Class544)Activator.CreateInstance(this.class544_0.GetType(), true);
				this.list_0 = new List<PropertyInfo>(this.class544_0.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
				this.list_1 = new List<FieldInfo>(this.class544_0.GetType().GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			}
			PropertyInfo propertyInfo = this.list_0.Find(new Predicate<PropertyInfo>(class.method_0));
			FieldInfo fieldInfo = this.list_1.Find(new Predicate<FieldInfo>(class.method_1));
			if (propertyInfo != null)
			{
				this.method_10(string_0, propertyInfo.GetValue(this.class544_0, null), propertyInfo.GetValue(this.class544_1, null), propertyInfo.PropertyType, bool_1);
			}
			if (fieldInfo != null)
			{
				this.method_10(string_0, fieldInfo.GetValue(this.class544_0), fieldInfo.GetValue(this.class544_1), fieldInfo.FieldType, bool_1);
			}
		}

		// Token: 0x060023C6 RID: 9158
		// RVA: 0x0001C322 File Offset: 0x0001A522
		internal void WriteValue<T>(string string_0, T gparam_0, T gparam_1, bool bool_1)
		{
			this.method_10(string_0, gparam_0, gparam_1, typeof(T), bool_1);
		}
	}
}
