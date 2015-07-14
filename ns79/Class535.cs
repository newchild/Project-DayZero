using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns29;
using ns77;
using ns81;
using osu.Graphics.Sprites;
using System;
using System.Runtime.CompilerServices;

namespace ns79
{
	// Token: 0x02000460 RID: 1120
	internal sealed class Class535 : Class533
	{
		// Token: 0x04001E35 RID: 7733
		internal bool bool_21;

		// Token: 0x04001E3C RID: 7740
		private bool bool_22;

		// Token: 0x04001E3D RID: 7741
		[CompilerGenerated]
		private bool bool_23;

		// Token: 0x04001E36 RID: 7734
		private double double_0;

		// Token: 0x04001E3B RID: 7739
		internal double double_1 = 120.0;

		// Token: 0x04001E3A RID: 7738
		private Enum113 enum113_0 = Enum113.const_2;

		// Token: 0x04001E39 RID: 7737
		internal int int_10 = 200;

		// Token: 0x04001E38 RID: 7736
		internal int int_9 = 200;

		// Token: 0x04001E37 RID: 7735
		private static readonly Vector2 vector2_11 = new Vector2(10f, 10f);

		// Token: 0x1700037D RID: 893
		internal override string Text
		{
			// Token: 0x0600245D RID: 9309
			// RVA: 0x0001C82B File Offset: 0x0001AA2B
			get
			{
				return base.Text;
			}
			// Token: 0x0600245E RID: 9310
			// RVA: 0x000DC4DC File Offset: 0x000DA6DC
			set
			{
				this.bool_21 = (!string.IsNullOrEmpty(value) && (Class800.bool_7 || Class800.bool_5));
				if (string.IsNullOrEmpty(value) && this.float_3 > 0f)
				{
					this.bool_22 = true;
					return;
				}
				if (this.Text != value)
				{
					this.bool_22 = false;
					base.Text = value;
					this.vector2_9 = Vector2.get_Zero();
					if (this.vmethod_11().X > 400f)
					{
						this.vector2_9 = new Vector2(400f, 0f);
					}
				}
			}
		}

		// Token: 0x06002460 RID: 9312
		// RVA: 0x000DC574 File Offset: 0x000DA774
		internal Class535(string string_3, float float_8, Vector2 vector2_12, Vector2 vector2_13, float float_9, bool bool_24, Color color_5, bool bool_25) : base(string_3, float_8, vector2_12, vector2_13, float_9, bool_24, color_5, bool_25)
		{
			this.origins_0 = Origins.TopLeft;
			this.float_3 = 0f;
			this.vector4_0 = new Vector4(4f, 4f, 4f, 4f);
			this.enum115_0 = Enum115.const_5;
			base.method_53(new Color(10, 10, 10, 230));
			base.method_55(new Color(80, 80, 80, 255));
		}

		// Token: 0x0600245F RID: 9311
		// RVA: 0x0001C833 File Offset: 0x0001AA33
		public override bool Draw()
		{
			return base.Draw();
		}

		// Token: 0x0600245B RID: 9307
		// RVA: 0x0001C81A File Offset: 0x0001AA1A
		[CompilerGenerated]
		internal bool method_68()
		{
			return this.bool_23;
		}

		// Token: 0x0600245C RID: 9308
		// RVA: 0x0001C822 File Offset: 0x0001AA22
		[CompilerGenerated]
		private void method_69(bool bool_24)
		{
			this.bool_23 = bool_24;
		}

		// Token: 0x06002461 RID: 9313
		// RVA: 0x0001C83B File Offset: 0x0001AA3B
		internal void method_70()
		{
			if (this.enum113_0 == Enum113.const_1)
			{
				return;
			}
			base.method_14(this.int_9, Enum70.const_0);
			this.enum113_0 = Enum113.const_1;
			this.method_69(true);
		}

		// Token: 0x06002462 RID: 9314
		// RVA: 0x0001C862 File Offset: 0x0001AA62
		internal void method_71()
		{
			if (this.enum113_0 == Enum113.const_0)
			{
				return;
			}
			base.method_16(this.int_10, Enum70.const_0);
			this.enum113_0 = Enum113.const_0;
			this.method_69(false);
		}

		// Token: 0x06002463 RID: 9315
		// RVA: 0x000DC624 File Offset: 0x000DA824
		public override Enum51 vmethod_3()
		{
			if (this.float_3 <= 0f && !this.bool_21)
			{
				if (this.bool_22 && this.float_3 == 0f)
				{
					this.Text = null;
				}
				this.double_0 = 0.0;
			}
			else
			{
				base.method_61(9f - (float)(Class115.int_23 - 1024) / 256f);
				Vector2 vector = this.vmethod_11() * Class115.float_4;
				Vector2 vector2 = Class800.smethod_19() + vector - new Vector2((float)Class115.int_22, (float)(Class115.int_23 + Class115.int_25)) + Class535.vector2_11 * Class115.float_4 * 2f;
				Vector2 vector2_ = (Class800.smethod_19() + Class535.vector2_11) / Class115.float_4;
				vector2_.Y -= (float)Class115.int_25 / Class115.float_4;
				if (vector2_.X > (float)(Class115.int_22 - 120) && vector.X < (float)(Class115.int_22 - 120))
				{
					vector2_.X -= (vector.X + 20f) / Class115.float_4;
				}
				else if (vector2.X > 0f)
				{
					vector2_.X -= vector2.X / Class115.float_4;
				}
				if (vector2_.Y > (float)(Class115.int_23 - 80) && vector.Y < (float)(Class115.int_23 - 80))
				{
					vector2_.Y -= (vector.Y + 20f) / Class115.float_4;
				}
				else if (vector2.Y > 0f)
				{
					vector2_.Y -= vector2.Y / Class115.float_4;
				}
				this.vector2_1 = vector2_;
			}
			if (this.bool_21 && !this.method_68())
			{
				this.double_0 += Class115.double_9;
				if (this.double_0 > this.double_1)
				{
					this.method_70();
				}
			}
			else if (!this.bool_21 && this.method_68())
			{
				this.method_71();
			}
			return base.vmethod_3();
		}
	}
}
