using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using ns14;
using ns29;
using ns64;
using ns82;
using ns9;
using System;
using System.Collections.Generic;

namespace ns81
{
	// Token: 0x020005ED RID: 1517
	internal sealed class Class567 : Class565, Interface15
	{
		// Token: 0x04002A81 RID: 10881
		private bool bool_0;

		// Token: 0x04002A83 RID: 10883
		private double double_0;

		// Token: 0x04002A84 RID: 10884
		private int int_1;

		// Token: 0x04002A86 RID: 10886
		private List<Vector2> list_0 = new List<Vector2>();

		// Token: 0x04002A87 RID: 10887
		private List<Vector2> list_1 = new List<Vector2>();

		// Token: 0x04002A82 RID: 10882
		private long long_0;

		// Token: 0x04002A85 RID: 10885
		private Vector2 vector2_0 = Vector2.get_One();

		// Token: 0x170003A5 RID: 933
		public Vector2 Position
		{
			// Token: 0x06002F3A RID: 12090
			// RVA: 0x00023450 File Offset: 0x00021650
			get
			{
				return this.vector2_0;
			}
		}

		// Token: 0x06002F34 RID: 12084
		// RVA: 0x0002342E File Offset: 0x0002162E
		internal override void Dispose()
		{
			Class565.smethod_3(new Delegate40(this.method_3));
			base.Dispose();
		}

		// Token: 0x06002F39 RID: 12089
		// RVA: 0x00023447 File Offset: 0x00021647
		public void imethod_0(Vector2 vector2_1)
		{
			this.vector2_0 = vector2_1;
		}

		// Token: 0x06002F3B RID: 12091
		// RVA: 0x000DD488 File Offset: 0x000DB688
		public ButtonState? imethod_1()
		{
			return null;
		}

		// Token: 0x06002F3C RID: 12092
		// RVA: 0x000DD488 File Offset: 0x000DB688
		public ButtonState? imethod_2()
		{
			return null;
		}

		// Token: 0x06002F3D RID: 12093
		// RVA: 0x000DD488 File Offset: 0x000DB688
		public ButtonState? imethod_3()
		{
			return null;
		}

		// Token: 0x06002F3E RID: 12094
		// RVA: 0x000DD488 File Offset: 0x000DB688
		public ButtonState? imethod_4()
		{
			return null;
		}

		// Token: 0x06002F3F RID: 12095
		// RVA: 0x000DD488 File Offset: 0x000DB688
		public ButtonState? imethod_5()
		{
			return null;
		}

		// Token: 0x06002F40 RID: 12096
		// RVA: 0x00023458 File Offset: 0x00021658
		public List<Vector2> imethod_6()
		{
			return this.list_0;
		}

		// Token: 0x06002F33 RID: 12083
		// RVA: 0x001328BC File Offset: 0x00130ABC
		internal override bool Initialize()
		{
			if (!base.Initialize())
			{
				return false;
			}
			try
			{
				if (!Class559.RegisterRawInputDevices(new Struct63[]
				{
					new Struct63
					{
						enum89_0 = Enum89.const_1,
						enum88_0 = Enum88.const_1,
						enum86_0 = Enum86.flag_0,
						intptr_0 = Class565.intptr_0
					}
				}, 1, sizeof(Struct63)))
				{
					return false;
				}
			}
			catch
			{
			}
			Class565.smethod_2(new Delegate40(this.method_3));
			return true;
		}

		// Token: 0x06002F31 RID: 12081
		// RVA: 0x00023407 File Offset: 0x00021607
		internal bool method_1()
		{
			return this.bool_0;
		}

		// Token: 0x06002F32 RID: 12082
		// RVA: 0x0002340F File Offset: 0x0002160F
		private void method_2(bool bool_1)
		{
			if (bool_1 != this.bool_0 && this.vmethod_2())
			{
				Class802.smethod_10();
			}
			this.bool_0 = bool_1;
		}

		// Token: 0x06002F35 RID: 12085
		// RVA: 0x00132950 File Offset: 0x00130B50
		private void method_3(Struct58 struct58_0)
		{
			Struct61 struct61_ = struct58_0.struct61_0;
			float num = (float)Class341.class607_3;
			this.method_2((ushort)(struct61_.enum82_0 & Enum82.flag_1) > 0);
			if (this.method_1())
			{
				if (Class341.class606_87)
				{
					this.vector2_0.X = ((float)(struct61_.int_0 - 32768) * num + 32768f) / 65536f * (float)Class115.int_22;
					this.vector2_0.Y = ((float)(struct61_.int_1 - 32768) * num + 32768f) / 65536f * (float)Class115.int_23;
				}
				else
				{
					this.vector2_0 = Class567.smethod_4(struct61_) - new Vector2((float)Class115.rectangle_2.X, (float)Class115.rectangle_2.Y);
					this.vector2_0.X = (this.vector2_0.X - (float)(Class115.int_22 / 2)) * num + (float)(Class115.int_22 / 2);
					this.vector2_0.Y = (this.vector2_0.Y - (float)(Class115.int_23 / 2)) * num + (float)(Class115.int_23 / 2);
				}
			}
			else
			{
				this.vector2_0.X = this.vector2_0.X + (float)struct61_.int_0 * num;
				this.vector2_0.Y = this.vector2_0.Y + (float)struct61_.int_1 * num;
			}
			if (Class802.bool_26)
			{
				this.vector2_0.X = Class778.smethod_2(this.vector2_0.X, 0f, (float)(Class115.int_22 - 1));
				this.vector2_0.Y = Class778.smethod_2(this.vector2_0.Y, 0f, (float)(Class115.int_23 - 1));
			}
			this.list_1.Add(this.vector2_0);
			this.int_1++;
			this.double_0 += (double)(Class115.stopwatch_0.ElapsedMilliseconds - this.long_0);
		}

		// Token: 0x06002F37 RID: 12087
		// RVA: 0x00132BE4 File Offset: 0x00130DE4
		private void method_4()
		{
			if (this.int_1 > 0)
			{
				this.double_0 /= (double)this.int_1;
			}
			float num = (float)Math.Pow(0.9, Class115.double_0);
			Class800.float_0 = Class800.float_0 * num + (1f - num) * ((float)this.int_1 / (float)Class115.double_9 * 1000f);
			Class800.int_0 = this.int_1;
			Class800.int_1 = (int)Math.Round(this.double_0);
			Class800.long_0 = this.long_0;
			this.int_1 = 0;
			this.double_0 = 0.0;
			this.long_0 = Class115.stopwatch_0.ElapsedMilliseconds;
		}

		// Token: 0x06002F36 RID: 12086
		// RVA: 0x00132B50 File Offset: 0x00130D50
		internal static Vector2 smethod_4(Struct61 struct61_0)
		{
			Rectangle rectangle = ((ushort)(struct61_0.enum82_0 & Enum82.flag_2) > 0) ? Class565.rectangle_0 : new Rectangle(Class115.point_0.X, Class115.point_0.Y, Class115.size_0.Width, Class115.size_0.Height);
			return new Vector2((float)struct61_0.int_0 / 65536f * (float)rectangle.Width + (float)rectangle.X, (float)struct61_0.int_1 / 65536f * (float)rectangle.Height + (float)rectangle.Y);
		}

		// Token: 0x06002F38 RID: 12088
		// RVA: 0x00132C9C File Offset: 0x00130E9C
		internal override void vmethod_1(bool bool_1)
		{
			this.method_4();
			this.list_0.Clear();
			this.list_0.AddRange(this.list_1);
			this.list_1.Clear();
			Point point_;
			point_..ctor((int)Math.Round((double)this.vector2_0.X), (int)Math.Round((double)this.vector2_0.Y));
			if (bool_1 && !this.method_1() && !Class800.smethod_23(point_, 1))
			{
				Point point_2 = Class800.smethod_14();
				if (!Class800.smethod_23(point_2, 0))
				{
					this.vector2_0.X = (float)point_2.X;
					this.vector2_0.Y = (float)point_2.Y;
					return;
				}
				Class800.smethod_13(point_, false);
			}
		}

		// Token: 0x06002F41 RID: 12097
		// RVA: 0x00023460 File Offset: 0x00021660
		internal override bool vmethod_2()
		{
			return Class341.class606_79 && Class114.bool_0 && !Class800.bool_6 && (this.method_1() || (!Class800.bool_5 && Class800.smethod_23(Class800.smethod_15(), 1)));
		}

		// Token: 0x06002F42 RID: 12098
		// RVA: 0x00006D2D File Offset: 0x00004F2D
		internal override int vmethod_3()
		{
			return 1;
		}
	}
}
