using ns37;
using System;
using System.IO;

namespace ns35
{
	// Token: 0x02000267 RID: 615
	internal sealed class Class206 : Interface13
	{
		// Token: 0x02000268 RID: 616
		internal enum Enum27
		{
			// Token: 0x04000FE4 RID: 4068
			const_0,
			// Token: 0x04000FE5 RID: 4069
			const_1,
			// Token: 0x04000FE6 RID: 4070
			const_2,
			// Token: 0x04000FE7 RID: 4071
			const_3,
			// Token: 0x04000FE8 RID: 4072
			const_4,
			// Token: 0x04000FE9 RID: 4073
			const_5,
			// Token: 0x04000FEA RID: 4074
			const_6
		}

		// Token: 0x04000FE0 RID: 4064
		private bool bool_0;

		// Token: 0x04000FDE RID: 4062
		private DateTime dateTime_0 = DateTime.Now;

		// Token: 0x04000FDF RID: 4063
		private Class206.Enum27 enum27_0;

		// Token: 0x04000FDD RID: 4061
		private Interface11 interface11_0;

		// Token: 0x04000FE1 RID: 4065
		private int int_0 = -1;

		// Token: 0x04000FE2 RID: 4066
		private int int_1;

		// Token: 0x06001561 RID: 5473
		// RVA: 0x00013157 File Offset: 0x00011357
		public Class206()
		{
			this.interface11_0 = new Class212();
		}

		// Token: 0x06001563 RID: 5475
		// RVA: 0x00013194 File Offset: 0x00011394
		public Class205 imethod_0(string string_0)
		{
			return this.vmethod_0(string_0, true);
		}

		// Token: 0x06001565 RID: 5477
		// RVA: 0x0001319E File Offset: 0x0001139E
		public Class205 imethod_1(string string_0)
		{
			return this.vmethod_1(string_0, true);
		}

		// Token: 0x06001562 RID: 5474
		// RVA: 0x0001317C File Offset: 0x0001137C
		public void imethod_2(Interface11 interface11_1)
		{
			if (interface11_1 == null)
			{
				this.interface11_0 = new Class212();
				return;
			}
			this.interface11_0 = interface11_1;
		}

		// Token: 0x06001564 RID: 5476
		// RVA: 0x0006D494 File Offset: 0x0006B694
		public Class205 vmethod_0(string string_0, bool bool_1)
		{
			Class205 class = new Class205(this.interface11_0.imethod_0(string_0));
			class.method_2(this.bool_0);
			int num = 0;
			bool flag = this.int_1 != 0;
			FileInfo fileInfo = null;
			if (bool_1)
			{
				fileInfo = new FileInfo(string_0);
			}
			if (fileInfo != null && fileInfo.Exists)
			{
				switch (this.enum27_0)
				{
				case Class206.Enum27.const_0:
					class.method_22(fileInfo.LastWriteTime);
					break;
				case Class206.Enum27.const_1:
					class.method_22(fileInfo.LastWriteTimeUtc);
					break;
				case Class206.Enum27.const_2:
					class.method_22(fileInfo.CreationTime);
					break;
				case Class206.Enum27.const_3:
					class.method_22(fileInfo.CreationTimeUtc);
					break;
				case Class206.Enum27.const_4:
					class.method_22(fileInfo.LastAccessTime);
					break;
				case Class206.Enum27.const_5:
					class.method_22(fileInfo.LastAccessTimeUtc);
					break;
				case Class206.Enum27.const_6:
					class.method_22(this.dateTime_0);
					break;
				default:
					throw new Exception8("Unhandled time setting in MakeFileEntry");
				}
				class.method_24(fileInfo.Length);
				flag = true;
				num = (int)(fileInfo.Attributes & (FileAttributes)this.int_0);
			}
			else if (this.enum27_0 == Class206.Enum27.const_6)
			{
				class.method_22(this.dateTime_0);
			}
			if (flag)
			{
				num |= this.int_1;
				class.method_11(num);
			}
			return class;
		}

		// Token: 0x06001566 RID: 5478
		// RVA: 0x0006D5C8 File Offset: 0x0006B7C8
		public Class205 vmethod_1(string string_0, bool bool_1)
		{
			Class205 class = new Class205(this.interface11_0.imethod_1(string_0));
			class.method_24(0L);
			int num = 0;
			DirectoryInfo directoryInfo = null;
			if (bool_1)
			{
				directoryInfo = new DirectoryInfo(string_0);
			}
			if (directoryInfo != null && directoryInfo.Exists)
			{
				switch (this.enum27_0)
				{
				case Class206.Enum27.const_0:
					class.method_22(directoryInfo.LastWriteTime);
					break;
				case Class206.Enum27.const_1:
					class.method_22(directoryInfo.LastWriteTimeUtc);
					break;
				case Class206.Enum27.const_2:
					class.method_22(directoryInfo.CreationTime);
					break;
				case Class206.Enum27.const_3:
					class.method_22(directoryInfo.CreationTimeUtc);
					break;
				case Class206.Enum27.const_4:
					class.method_22(directoryInfo.LastAccessTime);
					break;
				case Class206.Enum27.const_5:
					class.method_22(directoryInfo.LastAccessTimeUtc);
					break;
				case Class206.Enum27.const_6:
					class.method_22(this.dateTime_0);
					break;
				default:
					throw new Exception8("Unhandled time setting in MakeDirectoryEntry");
				}
				num = (int)(directoryInfo.Attributes & (FileAttributes)this.int_0);
			}
			else if (this.enum27_0 == Class206.Enum27.const_6)
			{
				class.method_22(this.dateTime_0);
			}
			num |= (this.int_1 | 16);
			class.method_11(num);
			return class;
		}
	}
}
