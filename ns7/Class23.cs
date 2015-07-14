using ns4;
using ns8;
using osu_common.Bancho;
using System;
using System.IO;

namespace ns7
{
	// Token: 0x02000185 RID: 389
	internal sealed class Class23
	{
		// Token: 0x04000677 RID: 1655
		public bool bool_0;

		// Token: 0x04000676 RID: 1654
		private byte[][] byte_0 = new byte[2][];

		// Token: 0x04000675 RID: 1653
		public Enum3 enum3_0;

		// Token: 0x04000674 RID: 1652
		public object object_0;

		// Token: 0x06000E44 RID: 3652
		// RVA: 0x0000EBF0 File Offset: 0x0000CDF0
		public Class23(Enum3 enum3_1, object object_1, bool bool_1)
		{
			this.enum3_0 = enum3_1;
			this.object_0 = object_1;
			this.bool_0 = bool_1;
		}

		// Token: 0x06000E45 RID: 3653
		// RVA: 0x0004E374 File Offset: 0x0004C574
		public int method_0(Stream stream_0, Class31 class31_0)
		{
			int num = this.method_1(Enum2.const_0, class31_0);
			stream_0.Write(((MemoryStream)class31_0.BaseStream).GetBuffer(), 0, num);
			return num;
		}

		// Token: 0x06000E46 RID: 3654
		// RVA: 0x0004E3A4 File Offset: 0x0004C5A4
		public int method_1(Enum2 enum2_0, Class31 class31_0)
		{
			if (this.bool_0)
			{
				byte[] array = this.byte_0[(int)enum2_0];
				if (array != null)
				{
					if (array.Length > 0)
					{
						class31_0.Seek(0, SeekOrigin.Begin);
						class31_0.BaseStream.Write(array, 0, array.Length);
					}
					return array.Length;
				}
			}
			int num;
			switch (enum2_0)
			{
			case Enum2.const_0:
				IL_47:
				num = this.method_2(class31_0);
				goto IL_59;
			case Enum2.const_1:
				num = this.method_3(class31_0);
				goto IL_59;
			}
			goto IL_47;
			IL_59:
			if (this.bool_0)
			{
				byte[] array2 = new byte[num];
				if (num > 0)
				{
					class31_0.Seek(0, SeekOrigin.Begin);
					class31_0.BaseStream.Read(array2, 0, num);
				}
				this.byte_0[(int)enum2_0] = array2;
			}
			return num;
		}

		// Token: 0x06000E47 RID: 3655
		// RVA: 0x0004E440 File Offset: 0x0004C640
		private int method_2(Class31 class31_0)
		{
			bSerializable bSerializable = this.object_0 as bSerializable;
			if (this.enum3_0 == Enum3.const_84)
			{
				return 0;
			}
			MemoryStream memoryStream = (MemoryStream)class31_0.BaseStream;
			class31_0.Seek(7, SeekOrigin.Begin);
			int num = 0;
			if (bSerializable != null)
			{
				bSerializable.WriteToStream(class31_0);
				num = (int)memoryStream.Position - 7;
			}
			class31_0.Seek(0, SeekOrigin.Begin);
			class31_0.Write((ushort)this.enum3_0);
			class31_0.Write(0);
			class31_0.Write((uint)num);
			return 7 + num;
		}

		// Token: 0x06000E48 RID: 3656
		// RVA: 0x0004E4B8 File Offset: 0x0004C6B8
		private int method_3(Class31 class31_0)
		{
			Interface5 interface = this.object_0 as Interface5;
			if (interface == null)
			{
				return 0;
			}
			MemoryStream memoryStream = (MemoryStream)class31_0.BaseStream;
			class31_0.Seek(0, SeekOrigin.Begin);
			interface.imethod_0(class31_0);
			return (int)memoryStream.Position;
		}
	}
}
