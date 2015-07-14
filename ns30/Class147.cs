using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Text;

namespace ns30
{
	// Token: 0x020001F6 RID: 502
	[TypeConverter("Design.HttpRequestItemConverter, Design")]
	internal abstract class Class147
	{
		// Token: 0x04000DD2 RID: 3538
		private bool bool_0 = true;

		// Token: 0x04000DD1 RID: 3537
		private static readonly byte[] byte_0 = Encoding.ASCII.GetBytes("+&*%<>\"#{}|\\^~[]'?!=/:$");

		// Token: 0x04000DD3 RID: 3539
		protected internal Class167 class167_0;

		// Token: 0x06001180 RID: 4480
		// RVA: 0x00010ADA File Offset: 0x0000ECDA
		public bool method_0()
		{
			return this.bool_0;
		}

		// Token: 0x06001181 RID: 4481
		// RVA: 0x00010AE2 File Offset: 0x0000ECE2
		public Class167 method_1()
		{
			return this.class167_0;
		}

		// Token: 0x06001182 RID: 4482
		// RVA: 0x0005FDCC File Offset: 0x0005DFCC
		protected string method_2(string string_0)
		{
			if (this.method_0() && (this.method_1() == null || !this.method_1().method_11()))
			{
				byte[] bytes = Encoding.UTF8.GetBytes(string_0);
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 0; i < bytes.Length; i++)
				{
					if (!this.method_3(bytes[i]) && bytes[i] < 128)
					{
						if (bytes[i] == 32)
						{
							stringBuilder.Append('+');
						}
						else
						{
							stringBuilder.Append(Convert.ToChar(bytes[i], CultureInfo.InvariantCulture));
						}
					}
					else
					{
						stringBuilder.Append("%" + Convert.ToInt16(bytes[i], CultureInfo.InvariantCulture).ToString("X2", CultureInfo.InvariantCulture));
					}
				}
				return stringBuilder.ToString();
			}
			return string_0;
		}

		// Token: 0x06001184 RID: 4484
		// RVA: 0x0005FEA0 File Offset: 0x0005E0A0
		private bool method_3(byte byte_1)
		{
			for (int i = 0; i < Class147.byte_0.Length; i++)
			{
				if (Class147.byte_0[i] == byte_1)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001183 RID: 4483
		public abstract Stream vmethod_0();
	}
}
