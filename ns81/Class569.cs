using Microsoft.Xna.Framework.Input;
using ns29;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;

namespace ns81
{
	// Token: 0x020005F3 RID: 1523
	internal sealed class Class569 : Class563
	{
		// Token: 0x020005F4 RID: 1524
		// Token: 0x06002F6A RID: 12138
		internal delegate void Delegate43(object object_0, List<Keys> list_0);

		// Token: 0x04002AAA RID: 10922
		private bool[] bool_0;

		// Token: 0x04002AAB RID: 10923
		private bool[] bool_1;

		// Token: 0x04002AAC RID: 10924
		private bool bool_2;

		// Token: 0x04002AA4 RID: 10916
		private static Class569.Delegate43 delegate43_0;

		// Token: 0x04002AA5 RID: 10917
		private static Class569.Delegate43 delegate43_1;

		// Token: 0x04002AA6 RID: 10918
		internal int int_0;

		// Token: 0x04002AA7 RID: 10919
		internal int int_1;

		// Token: 0x04002AAD RID: 10925
		private int int_2;

		// Token: 0x04002AAE RID: 10926
		private int int_3;

		// Token: 0x04002AAF RID: 10927
		private int int_4;

		// Token: 0x04002AB0 RID: 10928
		private int int_5;

		// Token: 0x04002AB1 RID: 10929
		private int int_6;

		// Token: 0x04002AB2 RID: 10930
		private int int_7;

		// Token: 0x04002AB3 RID: 10931
		private int int_8;

		// Token: 0x04002AB4 RID: 10932
		private int int_9;

		// Token: 0x04002AA8 RID: 10920
		internal static List<Keys> list_0 = new List<Keys>(40);

		// Token: 0x04002AA9 RID: 10921
		internal static List<Keys> list_1 = new List<Keys>(40);

		// Token: 0x06002F63 RID: 12131
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal override void Dispose()
		{
		}

		// Token: 0x06002F62 RID: 12130
		// RVA: 0x00133350 File Offset: 0x00131550
		internal override bool Initialize()
		{
			int num = Class569.joyGetNumDevs();
			if (num == 0)
			{
				return false;
			}
			this.int_3 = -1;
			Struct65 struct = default(Struct65);
			int i = 0;
			while (i < num)
			{
				if (Class569.joyGetPos(i, ref struct) != 0)
				{
					i++;
				}
				else
				{
					this.int_3 = i;
					IL_39:
					if (this.int_3 == -1)
					{
						return false;
					}
					Struct67 struct2 = default(Struct67);
					int num2 = Class569.joyGetDevCaps(this.int_3, ref struct2, Marshal.SizeOf(typeof(Struct67)));
					if (num2 > 0)
					{
						return false;
					}
					if (struct2.string_1 != null && !(struct2.string_1 == string.Empty) && struct2.string_0 != null && !(struct2.string_0 == string.Empty))
					{
						this.int_0 = (int)struct2.ushort_0;
						this.int_1 = (int)struct2.ushort_1;
						this.int_4 = (int)struct2.uint_1;
						this.int_5 = (int)struct2.uint_3;
						this.int_6 = (int)struct2.uint_0;
						this.int_7 = (int)struct2.uint_2;
						this.int_2 = (int)struct2.uint_6;
						this.bool_0 = new bool[this.int_2 + 4];
						this.bool_1 = new bool[this.int_2 + 4];
						this.bool_2 = true;
						return true;
					}
					return false;
				}
			}
			goto IL_39;
		}

		// Token: 0x06002F5B RID: 12123
		[DllImport("WinMM.dll", CharSet = CharSet.Ansi)]
		public static extern int joyGetDevCaps(int int_10, ref Struct67 struct67_0, int int_11);

		// Token: 0x06002F5A RID: 12122
		[DllImport("WinMM.dll")]
		public static extern int joyGetNumDevs();

		// Token: 0x06002F5C RID: 12124
		[DllImport("WinMM.dll", CharSet = CharSet.Ansi)]
		public static extern int joyGetPos(int int_10, ref Struct65 struct65_0);

		// Token: 0x06002F5D RID: 12125
		[DllImport("WinMM.dll", CharSet = CharSet.Ansi)]
		public static extern int joyGetPosEx(int int_10, ref Struct66 struct66_0);

		// Token: 0x06002F5E RID: 12126
		// RVA: 0x001332E8 File Offset: 0x001314E8
		internal static void smethod_0(Class569.Delegate43 delegate43_2)
		{
			Class569.Delegate43 delegate = Class569.delegate43_0;
			Class569.Delegate43 delegate2;
			do
			{
				delegate2 = delegate;
				Class569.Delegate43 value = (Class569.Delegate43)Delegate.Combine(delegate2, delegate43_2);
				delegate = Interlocked.CompareExchange<Class569.Delegate43>(ref Class569.delegate43_0, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x06002F5F RID: 12127
		// RVA: 0x0013331C File Offset: 0x0013151C
		internal static void smethod_1(Class569.Delegate43 delegate43_2)
		{
			Class569.Delegate43 delegate = Class569.delegate43_0;
			Class569.Delegate43 delegate2;
			do
			{
				delegate2 = delegate;
				Class569.Delegate43 value = (Class569.Delegate43)Delegate.Remove(delegate2, delegate43_2);
				delegate = Interlocked.CompareExchange<Class569.Delegate43>(ref Class569.delegate43_0, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x06002F60 RID: 12128
		// RVA: 0x0002353A File Offset: 0x0002173A
		internal static bool smethod_2(Keys keys_0)
		{
			return keys_0 != null && Class569.list_0.Contains(keys_0);
		}

		// Token: 0x06002F61 RID: 12129
		// RVA: 0x0002354C File Offset: 0x0002174C
		internal static bool smethod_3(Keys keys_0)
		{
			return Class569.list_1.Contains(keys_0);
		}

		// Token: 0x06002F64 RID: 12132
		// RVA: 0x001334A0 File Offset: 0x001316A0
		internal override void vmethod_1(bool bool_3)
		{
			if (!Class115.bool_13)
			{
				return;
			}
			Struct66 struct = default(Struct66);
			struct.int_0 = Marshal.SizeOf(typeof(Struct66));
			struct.enum93_0 = (Enum93.flag_1 | Enum93.flag_2 | Enum93.flag_8);
			int num = Class569.joyGetPosEx(this.int_3, ref struct);
			if (num > 0)
			{
				return;
			}
			List<Keys> list = new List<Keys>(this.int_2 + 4);
			for (int i = 0; i < this.int_2; i++)
			{
				if ((struct.enum95_0 & (Enum95)(1 << i)) != (Enum95)0u)
				{
					this.bool_0[i] = true;
					list.Add(i + 301);
				}
				else
				{
					this.bool_0[i] = false;
				}
			}
			for (int j = this.int_2; j < this.int_2 + 4; j++)
			{
				this.bool_0[j] = false;
			}
			if (this.bool_2)
			{
				this.bool_2 = false;
				this.int_8 = struct.int_1;
				this.int_9 = struct.int_2;
			}
			if (this.int_6 != this.int_4 && this.int_8 != this.int_6 && this.int_8 != this.int_4)
			{
				if (struct.int_1 == this.int_6)
				{
					this.bool_0[this.int_2] = true;
					list.Add(340);
				}
				else if (struct.int_1 == this.int_4)
				{
					this.bool_0[this.int_2 + 1] = true;
					list.Add(341);
				}
			}
			if (this.int_7 != this.int_5 && this.int_9 != this.int_7 && this.int_9 != this.int_5)
			{
				if (struct.int_2 == this.int_7)
				{
					this.bool_0[this.int_2 + 2] = true;
					list.Add(342);
				}
				else if (struct.int_2 == this.int_5)
				{
					this.bool_0[this.int_2 + 3] = true;
					list.Add(343);
				}
			}
			if (Class569.delegate43_1 != null)
			{
				Class569.delegate43_1(null, list);
			}
			if (Class569.delegate43_0 != null)
			{
				List<Keys> list2 = new List<Keys>(this.int_2 + 4);
				for (int k = 0; k < this.int_2 + 4; k++)
				{
					if (this.bool_1[k] && !this.bool_0[k])
					{
						if (k >= this.int_2)
						{
							list2.Add(340 + k - this.int_2);
						}
						else
						{
							list2.Add(301 + k);
						}
					}
				}
				if (list2.Count != 0)
				{
					Class569.delegate43_0(null, list2);
				}
			}
			Class569.list_1.Clear();
			Class569.list_1.AddRange(Class569.list_0);
			Class569.list_0.Clear();
			Class569.list_0.AddRange(list);
			this.bool_0.CopyTo(this.bool_1, 0);
		}

		// Token: 0x06002F65 RID: 12133
		// RVA: 0x00006D86 File Offset: 0x00004F86
		internal override bool vmethod_2()
		{
			return false;
		}

		// Token: 0x06002F66 RID: 12134
		// RVA: 0x0000B7FB File Offset: 0x000099FB
		internal override int vmethod_3()
		{
			return 2;
		}
	}
}
