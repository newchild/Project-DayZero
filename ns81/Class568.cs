using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using ns18;
using ns29;
using ns64;
using ns82;
using ns9;
using ns90;
using osu;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;

namespace ns81
{
	// Token: 0x020005EE RID: 1518
	internal sealed class Class568 : Class563, Interface15
	{
		// Token: 0x020005EF RID: 1519
		private enum Enum91
		{
			// Token: 0x04002A98 RID: 10904
			const_0 = 1,
			// Token: 0x04002A99 RID: 10905
			const_1,
			// Token: 0x04002A9A RID: 10906
			const_2,
			// Token: 0x04002A9B RID: 10907
			const_3
		}

		// Token: 0x020005F0 RID: 1520
		private enum Enum92
		{
			// Token: 0x04002A9D RID: 10909
			const_0 = 1,
			// Token: 0x04002A9E RID: 10910
			const_1,
			// Token: 0x04002A9F RID: 10911
			const_2 = 4
		}

		// Token: 0x020005F1 RID: 1521
		private struct Struct64
		{
			// Token: 0x04002AA3 RID: 10915
			public Class568.Enum92 enum92_0;

			// Token: 0x04002AA0 RID: 10912
			public int int_0;

			// Token: 0x04002AA1 RID: 10913
			public int int_1;

			// Token: 0x04002AA2 RID: 10914
			public int int_2;
		}

		// Token: 0x04002A88 RID: 10888
		private bool bool_0;

		// Token: 0x04002A89 RID: 10889
		private bool bool_1;

		// Token: 0x04002A8A RID: 10890
		private bool bool_2;

		// Token: 0x04002A8B RID: 10891
		private bool bool_3;

		// Token: 0x04002A94 RID: 10900
		private ButtonState buttonState_0;

		// Token: 0x04002A95 RID: 10901
		private ButtonState buttonState_1;

		// Token: 0x04002A96 RID: 10902
		private ButtonState buttonState_2;

		// Token: 0x04002A8C RID: 10892
		private int int_0;

		// Token: 0x04002A8D RID: 10893
		private int int_1;

		// Token: 0x04002A8E RID: 10894
		private Point point_0;

		// Token: 0x04002A8F RID: 10895
		private Point point_1;

		// Token: 0x04002A90 RID: 10896
		private Point point_2;

		// Token: 0x04002A91 RID: 10897
		private Point point_3;

		// Token: 0x04002A92 RID: 10898
		private Vector2 vector2_0;

		// Token: 0x04002A93 RID: 10899
		private Vector2 vector2_1;

		// Token: 0x170003A6 RID: 934
		public Vector2 Position
		{
			// Token: 0x06002F48 RID: 12104
			// RVA: 0x000234D3 File Offset: 0x000216D3
			get
			{
				return new Vector2((float)this.int_0, (float)this.int_1);
			}
		}

		// Token: 0x06002F45 RID: 12101
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal override void Dispose()
		{
		}

		// Token: 0x06002F55 RID: 12117
		[SuppressUnmanagedCodeSecurity, SuppressUnmanagedCodeSecurity]
		[DllImport("EloPubIf.dll", CallingConvention = CallingConvention.Cdecl)]
		private static extern int EloGetScreenInfo(uint[] uint_0, ref int int_2);

		// Token: 0x06002F56 RID: 12118
		[SuppressUnmanagedCodeSecurity, SuppressUnmanagedCodeSecurity]
		[DllImport("EloPubIf.dll", CallingConvention = CallingConvention.Cdecl)]
		private unsafe static extern int EloGetTouch(Class568.Struct64* pStruct64_0, bool bool_4, Class568.Enum91 enum91_0, ref uint uint_0);

		// Token: 0x06002F47 RID: 12103
		// RVA: 0x0000653E File Offset: 0x0000473E
		public void imethod_0(Vector2 vector2_2)
		{
		}

		// Token: 0x06002F49 RID: 12105
		// RVA: 0x000234E8 File Offset: 0x000216E8
		public ButtonState? imethod_1()
		{
			return new ButtonState?(this.buttonState_1);
		}

		// Token: 0x06002F4A RID: 12106
		// RVA: 0x000234F5 File Offset: 0x000216F5
		public ButtonState? imethod_2()
		{
			return new ButtonState?(this.buttonState_2);
		}

		// Token: 0x06002F4B RID: 12107
		// RVA: 0x000DD488 File Offset: 0x000DB688
		public ButtonState? imethod_3()
		{
			return null;
		}

		// Token: 0x06002F4C RID: 12108
		// RVA: 0x000DD488 File Offset: 0x000DB688
		public ButtonState? imethod_4()
		{
			return null;
		}

		// Token: 0x06002F4D RID: 12109
		// RVA: 0x000DD488 File Offset: 0x000DB688
		public ButtonState? imethod_5()
		{
			return null;
		}

		// Token: 0x06002F4E RID: 12110
		// RVA: 0x0001CB28 File Offset: 0x0001AD28
		public List<Vector2> imethod_6()
		{
			return new List<Vector2>();
		}

		// Token: 0x06002F44 RID: 12100
		// RVA: 0x00132D54 File Offset: 0x00130F54
		internal override bool Initialize()
		{
			if (Class341.string_0 == "")
			{
				this.method_1();
			}
			else
			{
				string[] array = Class341.string_0.Split(new char[]
				{
					':'
				});
				this.vector2_1 = new Vector2(float.Parse(array[0]), float.Parse(array[1]));
				this.vector2_0 = new Vector2(float.Parse(array[2]), float.Parse(array[3]));
				this.bool_0 = true;
			}
			new Thread(new ThreadStart(this.method_0))
			{
				IsBackground = true
			}.Start();
			return true;
		}

		// Token: 0x06002F52 RID: 12114
		// RVA: 0x00132F08 File Offset: 0x00131108
		private unsafe void method_0()
		{
			uint[] array = new uint[32];
			int num;
			Class568.EloGetScreenInfo(array, ref num);
			Class568.Struct64 struct64_ = default(Class568.Struct64);
			uint num2 = array[0];
			bool flag = false;
			int num3 = 0;
			int num4 = 0;
			while (true)
			{
				Class568.EloGetTouch(&struct64_, false, Class568.Enum91.const_3, ref num2);
				if (!this.bool_0)
				{
					this.method_2(struct64_);
				}
				else
				{
					this.int_0 = (int)(((float)struct64_.int_0 - this.vector2_0.X) / this.vector2_1.X);
					this.int_1 = (int)(((float)struct64_.int_1 - this.vector2_0.Y) / this.vector2_1.Y);
					if (!flag)
					{
						if (struct64_.int_2 > num3)
						{
							flag = true;
							this.bool_3 = true;
						}
					}
					else if (struct64_.int_2 <= Math.Max(12, num4 - (Class62.bool_12 ? 20 : 100)))
					{
						flag = false;
						num4 = 0;
					}
					if (flag && struct64_.int_2 > num4)
					{
						num4 = struct64_.int_2;
					}
					this.buttonState_0 = ((struct64_.enum92_0 == Class568.Enum92.const_2) ? 0 : 1);
					num3 = struct64_.int_2;
				}
			}
		}

		// Token: 0x06002F53 RID: 12115
		// RVA: 0x00023502 File Offset: 0x00021702
		internal void method_1()
		{
			Class723.smethod_1("Touchscreen Input Enabled - Please calibrate by touching top-left and bottom-right corners", 20000);
			this.bool_0 = false;
			this.point_0 = Point.get_Zero();
			this.point_2 = Point.get_Zero();
			Class341.string_0 = string.Empty;
		}

		// Token: 0x06002F54 RID: 12116
		// RVA: 0x00133028 File Offset: 0x00131228
		private void method_2(Class568.Struct64 struct64_0)
		{
			Thread.Sleep(50);
			Point point = Class800.smethod_14();
			if (this.point_0.X == 0)
			{
				if (point.X < 200)
				{
					this.point_0.X = struct64_0.int_0;
					this.point_1.X = point.X;
				}
			}
			else if (point.X > 600)
			{
				this.point_2.X = struct64_0.int_0;
				this.point_3.X = point.X;
			}
			if (this.point_0.Y == 0)
			{
				if (point.Y < 200)
				{
					this.point_0.Y = struct64_0.int_1;
					this.point_1.Y = point.Y;
				}
			}
			else if (point.Y > 600)
			{
				this.point_2.Y = struct64_0.int_1;
				this.point_3.Y = point.Y;
			}
			if (this.point_2.X > 0 && this.point_2.Y > 0)
			{
				this.bool_0 = true;
				this.vector2_1.X = (float)(this.point_2.X - this.point_0.X) / (float)(this.point_3.X - this.point_1.X);
				this.vector2_1.Y = (float)(this.point_2.Y - this.point_0.Y) / (float)(this.point_3.Y - this.point_1.Y);
				this.vector2_0.X = (float)this.point_0.X - (float)this.point_1.X * this.vector2_1.X;
				this.vector2_0.Y = (float)this.point_0.Y - (float)this.point_1.Y * this.vector2_1.Y;
				Class341.string_0 = string.Concat(new string[]
				{
					this.vector2_1.X.ToString(Class115.numberFormatInfo_0),
					":",
					this.vector2_1.Y.ToString(Class115.numberFormatInfo_0),
					":",
					this.vector2_0.X.ToString(Class115.numberFormatInfo_0),
					":",
					this.vector2_0.Y.ToString(Class115.numberFormatInfo_0)
				});
				Class723.smethod_1("Touchscreen Calibration Complete!", 2000);
			}
		}

		// Token: 0x06002F46 RID: 12102
		// RVA: 0x000234C5 File Offset: 0x000216C5
		internal override void vmethod_0()
		{
			this.method_1();
			base.vmethod_0();
		}

		// Token: 0x06002F51 RID: 12113
		// RVA: 0x00132E60 File Offset: 0x00131060
		internal override void vmethod_1(bool bool_4)
		{
			this.buttonState_1 = 0;
			this.buttonState_2 = 0;
			if (this.bool_3)
			{
				this.bool_2 = (Class62.bool_11 || Class802.smethod_0() || Class115.osuModes_1 != OsuModes.Play || !this.bool_2);
				if (this.bool_2)
				{
					this.buttonState_1 = 1;
				}
				else
				{
					this.buttonState_2 = 1;
				}
				this.bool_3 = false;
				return;
			}
			if (this.bool_2 && this.buttonState_0 == 1)
			{
				this.buttonState_1 = this.buttonState_0;
				return;
			}
			if (!this.bool_2 && this.buttonState_0 == 1)
			{
				this.buttonState_2 = this.buttonState_0;
			}
		}

		// Token: 0x06002F4F RID: 12111
		// RVA: 0x00132DF0 File Offset: 0x00130FF0
		internal override bool vmethod_2()
		{
			bool flag;
			if (!(flag = (Class341.class606_24 && this.bool_0 && (this.bool_3 || this.buttonState_0 == 1))) && this.bool_1)
			{
				flag = true;
				this.bool_1 = false;
			}
			else if (flag)
			{
				this.bool_1 = true;
			}
			return flag && Class114.bool_0 && !Class800.bool_5;
		}

		// Token: 0x06002F50 RID: 12112
		// RVA: 0x0000B7FB File Offset: 0x000099FB
		internal override int vmethod_3()
		{
			return 2;
		}
	}
}
