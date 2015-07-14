using ns48;
using System;

namespace ns45
{
	// Token: 0x020002ED RID: 749
	internal sealed class Class272 : IEquatable<Class272>
	{
		// Token: 0x040011D9 RID: 4569
		private byte[] byte_0;

		// Token: 0x06001719 RID: 5913
		// RVA: 0x000144AB File Offset: 0x000126AB
		public override bool Equals(object obj)
		{
			return this.Equals(obj as Class272);
		}

		// Token: 0x0600171A RID: 5914
		// RVA: 0x000144B9 File Offset: 0x000126B9
		public bool Equals(byte[] byte_1)
		{
			return byte_1 != null && byte_1.Length == 20 && Class275.smethod_1(this.method_0(), byte_1);
		}

		// Token: 0x0600171B RID: 5915
		// RVA: 0x000144D3 File Offset: 0x000126D3
		public bool Equals(Class272 other)
		{
			return Class272.smethod_0(this, other);
		}

		// Token: 0x0600171C RID: 5916
		// RVA: 0x000144DC File Offset: 0x000126DC
		public override int GetHashCode()
		{
			return (int)this.method_0()[0] | (int)this.method_0()[1] << 8 | (int)this.method_0()[2] << 16 | (int)this.method_0()[3] << 24;
		}

		// Token: 0x06001718 RID: 5912
		// RVA: 0x000144A3 File Offset: 0x000126A3
		internal byte[] method_0()
		{
			return this.byte_0;
		}

		// Token: 0x0600171E RID: 5918
		// RVA: 0x00014516 File Offset: 0x00012716
		public static bool smethod_0(Class272 class272_0, Class272 class272_1)
		{
			if (class272_0 == null)
			{
				return class272_1 == null;
			}
			return class272_1 != null && Class275.smethod_1(class272_0.method_0(), class272_1.method_0());
		}

		// Token: 0x0600171D RID: 5917
		// RVA: 0x00014509 File Offset: 0x00012709
		public override string ToString()
		{
			return BitConverter.ToString(this.byte_0);
		}
	}
}
