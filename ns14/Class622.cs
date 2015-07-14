using System;
using System.Reflection;

namespace ns14
{
	// Token: 0x020004B2 RID: 1202
	internal sealed class Class622<T> : Interface20<T>
	{
		// Token: 0x0600263D RID: 9789
		// RVA: 0x0001DAE5 File Offset: 0x0001BCE5
		public T imethod_0(T gparam_0, int int_0)
		{
			return this.method_0(gparam_0, int_0, false);
		}

		// Token: 0x0600263E RID: 9790
		// RVA: 0x0001DAF0 File Offset: 0x0001BCF0
		public T imethod_1(T gparam_0, int int_0)
		{
			return this.method_0(gparam_0, int_0, true);
		}

		// Token: 0x0600263C RID: 9788
		// RVA: 0x000E5BF4 File Offset: 0x000E3DF4
		public T method_0(T gparam_0, int int_0, bool bool_0)
		{
			Type type = gparam_0.GetType();
			if (type == typeof(string))
			{
				string text = Convert.ToString(gparam_0);
				char[] array = new char[text.Length];
				for (int i = 0; i < text.Length; i++)
				{
					array[i] = (char)((int)text[i] ^ int_0);
				}
				return (T)((object)Convert.ChangeType(new string(array), type));
			}
			if (type == typeof(int))
			{
				return (T)((object)((int)Convert.ChangeType(gparam_0, typeof(int)) ^ int_0));
			}
			if (type == typeof(double))
			{
				return (T)((object)((double)Convert.ChangeType(gparam_0, typeof(double)) * (bool_0 ? (1.0 / (double)int_0) : ((double)int_0))));
			}
			if (type == typeof(float))
			{
				return (T)((object)((float)Convert.ChangeType(gparam_0, typeof(float)) * (bool_0 ? (1f / (float)int_0) : ((float)int_0))));
			}
			if (type.BaseType == typeof(Enum))
			{
				return (T)((object)((int)Convert.ChangeType(gparam_0, typeof(int)) ^ int_0));
			}
			Type type2 = gparam_0.GetType();
			MethodInfo method = type2.GetMethod("op_ExclusiveOr");
			return (T)((object)method.Invoke(gparam_0, new object[]
			{
				int_0
			}));
		}
	}
}
