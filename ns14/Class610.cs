using Microsoft.Xna.Framework.Graphics;
using System;
using System.Drawing;

namespace ns14
{
	// Token: 0x020004A1 RID: 1185
	internal static class Class610
	{
		// Token: 0x060025F1 RID: 9713
		// RVA: 0x000E38DC File Offset: 0x000E1ADC
		internal static Color smethod_0(Color color_0, float float_0)
		{
			return new Color((byte)Math.Min(255f, (float)color_0.get_R() * (1f + float_0)), (byte)Math.Min(255f, (float)color_0.get_G() * (1f + float_0)), (byte)Math.Min(255f, (float)color_0.get_B() * (1f + float_0)), color_0.get_A());
		}

		// Token: 0x060025F2 RID: 9714
		// RVA: 0x000E3948 File Offset: 0x000E1B48
		internal static Color smethod_1(Color color_0, float float_0)
		{
			float_0 *= 0.5f;
			return new Color((byte)Math.Min(255f, (float)color_0.get_R() * (1f + 0.5f * float_0) + 255f * float_0), (byte)Math.Min(255f, (float)color_0.get_G() * (1f + 0.5f * float_0) + 255f * float_0), (byte)Math.Min(255f, (float)color_0.get_B() * (1f + 0.5f * float_0) + 255f * float_0), color_0.get_A());
		}

		// Token: 0x060025F3 RID: 9715
		// RVA: 0x000E39E8 File Offset: 0x000E1BE8
		internal static Color smethod_2(Color color_0, float float_0)
		{
			return new Color((byte)Math.Min(255f, (float)color_0.get_R() / (1f + float_0)), (byte)Math.Min(255f, (float)color_0.get_G() / (1f + float_0)), (byte)Math.Min(255f, (float)color_0.get_B() / (1f + float_0)), color_0.get_A());
		}

		// Token: 0x060025F4 RID: 9716
		// RVA: 0x000E3A54 File Offset: 0x000E1C54
		internal static Color smethod_3(Color color_0, Color color_1, float float_0)
		{
			return new Color((byte)Class778.smethod_0((float)color_0.get_R(), (float)color_1.get_R(), float_0), (byte)Class778.smethod_0((float)color_0.get_G(), (float)color_1.get_G(), float_0), (byte)Class778.smethod_0((float)color_0.get_B(), (float)color_1.get_B(), float_0), (byte)Class778.smethod_0((float)color_0.get_A(), (float)color_1.get_A(), float_0));
		}

		// Token: 0x060025F5 RID: 9717
		// RVA: 0x000E3AC4 File Offset: 0x000E1CC4
		internal static Color smethod_4(Color color_0, Color color_1, float float_0)
		{
			return Color.FromArgb((int)((byte)Class778.smethod_0((float)color_0.A, (float)color_1.A, float_0)), (int)((byte)Class778.smethod_0((float)color_0.R, (float)color_1.R, float_0)), (int)((byte)Class778.smethod_0((float)color_0.G, (float)color_1.G, float_0)), (int)((byte)Class778.smethod_0((float)color_0.B, (float)color_1.B, float_0)));
		}

		// Token: 0x060025F6 RID: 9718
		// RVA: 0x0001D75F File Offset: 0x0001B95F
		internal static string smethod_5(Color color_0)
		{
			return string.Format("{0:X2}{1:X2}{2:X2}", color_0.get_R(), color_0.get_G(), color_0.get_B());
		}

		// Token: 0x060025F7 RID: 9719
		// RVA: 0x000E3B34 File Offset: 0x000E1D34
		internal static Color smethod_6(string string_0)
		{
			if (string_0.Length != 6)
			{
				return Color.get_White();
			}
			string value = string_0.Substring(0, 2);
			string value2 = string_0.Substring(2, 2);
			string value3 = string_0.Substring(4, 2);
			return new Color(Convert.ToByte(value, 16), Convert.ToByte(value2, 16), Convert.ToByte(value3, 16));
		}

		// Token: 0x060025F8 RID: 9720
		// RVA: 0x0001D78F File Offset: 0x0001B98F
		internal static Color smethod_7(Color color_0, byte byte_0)
		{
			return new Color(color_0.get_R(), color_0.get_G(), color_0.get_B(), byte_0);
		}
	}
}
