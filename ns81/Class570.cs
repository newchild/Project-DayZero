using Microsoft.Xna.Framework.Input;
using ns82;
using System;
using System.Collections.Generic;
using System.Threading;

namespace ns81
{
	// Token: 0x020005FE RID: 1534
	internal sealed class Class570 : Class563
	{
		// Token: 0x020005FF RID: 1535
		// Token: 0x06002F8A RID: 12170
		internal delegate bool Delegate44(object object_0, Keys keys_0);

		// Token: 0x02000600 RID: 1536
		// Token: 0x06002F8E RID: 12174
		internal delegate bool Delegate45(object object_0, Keys keys_0, bool bool_0);

		// Token: 0x04002B2F RID: 11055
		public static bool bool_0;

		// Token: 0x04002B30 RID: 11056
		public static bool bool_1;

		// Token: 0x04002B31 RID: 11057
		public static bool bool_2;

		// Token: 0x04002B32 RID: 11058
		private static Class570.Delegate44 delegate44_0;

		// Token: 0x04002B33 RID: 11059
		private static Class570.Delegate44 delegate44_1;

		// Token: 0x04002B34 RID: 11060
		private static Class570.Delegate45 delegate45_0;

		// Token: 0x06002F85 RID: 12165
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal override void Dispose()
		{
		}

		// Token: 0x06002F84 RID: 12164
		// RVA: 0x00006D2D File Offset: 0x00004F2D
		internal override bool Initialize()
		{
			return true;
		}

		// Token: 0x06002F7A RID: 12154
		// RVA: 0x00133A90 File Offset: 0x00131C90
		internal static void smethod_0(Class570.Delegate44 delegate44_2)
		{
			Class570.Delegate44 delegate = Class570.delegate44_0;
			Class570.Delegate44 delegate2;
			do
			{
				delegate2 = delegate;
				Class570.Delegate44 value = (Class570.Delegate44)Delegate.Combine(delegate2, delegate44_2);
				delegate = Interlocked.CompareExchange<Class570.Delegate44>(ref Class570.delegate44_0, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x06002F7B RID: 12155
		// RVA: 0x00133AC4 File Offset: 0x00131CC4
		internal static void smethod_1(Class570.Delegate44 delegate44_2)
		{
			Class570.Delegate44 delegate = Class570.delegate44_0;
			Class570.Delegate44 delegate2;
			do
			{
				delegate2 = delegate;
				Class570.Delegate44 value = (Class570.Delegate44)Delegate.Remove(delegate2, delegate44_2);
				delegate = Interlocked.CompareExchange<Class570.Delegate44>(ref Class570.delegate44_0, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x06002F7C RID: 12156
		// RVA: 0x00133AF8 File Offset: 0x00131CF8
		internal static void smethod_2(Class570.Delegate44 delegate44_2)
		{
			Class570.Delegate44 delegate = Class570.delegate44_1;
			Class570.Delegate44 delegate2;
			do
			{
				delegate2 = delegate;
				Class570.Delegate44 value = (Class570.Delegate44)Delegate.Combine(delegate2, delegate44_2);
				delegate = Interlocked.CompareExchange<Class570.Delegate44>(ref Class570.delegate44_1, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x06002F7D RID: 12157
		// RVA: 0x00133B2C File Offset: 0x00131D2C
		internal static void smethod_3(Class570.Delegate44 delegate44_2)
		{
			Class570.Delegate44 delegate = Class570.delegate44_1;
			Class570.Delegate44 delegate2;
			do
			{
				delegate2 = delegate;
				Class570.Delegate44 value = (Class570.Delegate44)Delegate.Remove(delegate2, delegate44_2);
				delegate = Interlocked.CompareExchange<Class570.Delegate44>(ref Class570.delegate44_1, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x06002F7E RID: 12158
		// RVA: 0x00133B60 File Offset: 0x00131D60
		internal static void smethod_4(Class570.Delegate45 delegate45_1)
		{
			Class570.Delegate45 delegate = Class570.delegate45_0;
			Class570.Delegate45 delegate2;
			do
			{
				delegate2 = delegate;
				Class570.Delegate45 value = (Class570.Delegate45)Delegate.Combine(delegate2, delegate45_1);
				delegate = Interlocked.CompareExchange<Class570.Delegate45>(ref Class570.delegate45_0, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x06002F7F RID: 12159
		// RVA: 0x00133B94 File Offset: 0x00131D94
		internal static void smethod_5(Class570.Delegate45 delegate45_1)
		{
			Class570.Delegate45 delegate = Class570.delegate45_0;
			Class570.Delegate45 delegate2;
			do
			{
				delegate2 = delegate;
				Class570.Delegate45 value = (Class570.Delegate45)Delegate.Remove(delegate2, delegate45_1);
				delegate = Interlocked.CompareExchange<Class570.Delegate45>(ref Class570.delegate45_0, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x06002F80 RID: 12160
		// RVA: 0x00133BC8 File Offset: 0x00131DC8
		internal static bool smethod_6(Keys keys_0)
		{
			if (Class570.smethod_8(keys_0, true))
			{
				return true;
			}
			if (Class570.delegate44_0 != null)
			{
				Delegate[] array = Class570.delegate44_0.GetInvocationList();
				if (Class570.bool_0 && Class570.bool_2)
				{
					List<Delegate> list = new List<Delegate>(array);
					list.Reverse();
					array = list.ToArray();
				}
				if (array.Length == 0)
				{
					return false;
				}
				for (int i = array.Length - 1; i >= 0; i--)
				{
					Class570.Delegate44 delegate = array[i] as Class570.Delegate44;
					if (delegate != null && (bool)delegate.DynamicInvoke(new object[]
					{
						null,
						keys_0
					}))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06002F81 RID: 12161
		// RVA: 0x00133C60 File Offset: 0x00131E60
		internal static void smethod_7(Keys keys_0)
		{
			if (Class570.delegate44_1 != null)
			{
				Delegate[] array = Class570.delegate44_1.GetInvocationList();
				if (Class570.bool_0 && Class570.bool_2)
				{
					List<Delegate> list = new List<Delegate>(array);
					list.Reverse();
					array = list.ToArray();
				}
				if (array.Length == 0)
				{
					return;
				}
				for (int i = array.Length - 1; i >= 0; i--)
				{
					Class570.Delegate44 delegate = array[i] as Class570.Delegate44;
					if (delegate != null && (bool)delegate.DynamicInvoke(new object[]
					{
						null,
						keys_0
					}))
					{
						return;
					}
				}
			}
		}

		// Token: 0x06002F82 RID: 12162
		// RVA: 0x00133CE8 File Offset: 0x00131EE8
		internal static bool smethod_8(Keys keys_0, bool bool_3)
		{
			if (Class570.delegate45_0 != null)
			{
				Delegate[] array = Class570.delegate45_0.GetInvocationList();
				if (Class570.bool_0 && Class570.bool_2)
				{
					List<Delegate> list = new List<Delegate>(array);
					list.Reverse();
					array = list.ToArray();
				}
				if (array.Length == 0)
				{
					return false;
				}
				for (int i = array.Length - 1; i >= 0; i--)
				{
					Class570.Delegate45 delegate = array[i] as Class570.Delegate45;
					if (delegate != null && (bool)delegate.DynamicInvoke(new object[]
					{
						null,
						keys_0,
						bool_3
					}))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06002F83 RID: 12163
		// RVA: 0x000235C7 File Offset: 0x000217C7
		internal static bool smethod_9(Keys keys_0)
		{
			return keys_0 != null && Class802.list_1.Contains(keys_0);
		}

		// Token: 0x06002F86 RID: 12166
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal override void vmethod_1(bool bool_3)
		{
		}

		// Token: 0x06002F87 RID: 12167
		// RVA: 0x00006D86 File Offset: 0x00004F86
		internal override bool vmethod_2()
		{
			return false;
		}

		// Token: 0x06002F88 RID: 12168
		// RVA: 0x0000B7FB File Offset: 0x000099FB
		internal override int vmethod_3()
		{
			return 2;
		}
	}
}
