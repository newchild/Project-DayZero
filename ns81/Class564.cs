using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using ns29;
using ns64;
using System;
using System.Collections.Generic;

namespace ns81
{
	// Token: 0x0200046F RID: 1135
	internal sealed class Class564 : Class563, Interface15
	{
		// Token: 0x04001E73 RID: 7795
		private bool bool_0;

		// Token: 0x04001E75 RID: 7797
		private Point point_0;

		// Token: 0x04001E74 RID: 7796
		private Vector2 vector2_0 = Vector2.get_One();

		// Token: 0x17000380 RID: 896
		public Vector2 Position
		{
			// Token: 0x060024AC RID: 9388
			// RVA: 0x0001CB20 File Offset: 0x0001AD20
			get
			{
				return this.vector2_0;
			}
		}

		// Token: 0x060024A9 RID: 9385
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal override void Dispose()
		{
		}

		// Token: 0x060024AB RID: 9387
		// RVA: 0x0001CB10 File Offset: 0x0001AD10
		public void imethod_0(Vector2 vector2_1)
		{
			this.vector2_0 = vector2_1;
			this.bool_0 = false;
		}

		// Token: 0x060024AD RID: 9389
		// RVA: 0x000DD488 File Offset: 0x000DB688
		public ButtonState? imethod_1()
		{
			return null;
		}

		// Token: 0x060024AE RID: 9390
		// RVA: 0x000DD488 File Offset: 0x000DB688
		public ButtonState? imethod_2()
		{
			return null;
		}

		// Token: 0x060024AF RID: 9391
		// RVA: 0x000DD488 File Offset: 0x000DB688
		public ButtonState? imethod_3()
		{
			return null;
		}

		// Token: 0x060024B0 RID: 9392
		// RVA: 0x000DD488 File Offset: 0x000DB688
		public ButtonState? imethod_4()
		{
			return null;
		}

		// Token: 0x060024B1 RID: 9393
		// RVA: 0x000DD488 File Offset: 0x000DB688
		public ButtonState? imethod_5()
		{
			return null;
		}

		// Token: 0x060024B2 RID: 9394
		// RVA: 0x0001CB28 File Offset: 0x0001AD28
		public List<Vector2> imethod_6()
		{
			return new List<Vector2>();
		}

		// Token: 0x060024A8 RID: 9384
		// RVA: 0x0001CB02 File Offset: 0x0001AD02
		internal override bool Initialize()
		{
			this.point_0 = Class800.smethod_14();
			return true;
		}

		// Token: 0x060024AA RID: 9386
		// RVA: 0x000DD1B0 File Offset: 0x000DB3B0
		internal override void vmethod_1(bool bool_1)
		{
			Point point_ = Class800.smethod_14();
			if (!bool_1)
			{
				this.bool_0 = false;
				this.vector2_0.X = this.vector2_0.X + (float)(point_.X - this.point_0.X);
				this.vector2_0.Y = this.vector2_0.Y + (float)(point_.Y - this.point_0.Y);
				this.point_0 = point_;
				return;
			}
			this.point_0 = point_;
			if (!this.bool_0)
			{
				if (Class115.long_0 != 0L && Class800.smethod_23(point_, 0))
				{
					Point point_2;
					point_2..ctor((int)Math.Round((double)this.vector2_0.X), (int)Math.Round((double)this.vector2_0.Y));
					Class800.smethod_13(point_2, true);
					point_ = Class800.smethod_14();
				}
				else
				{
					this.vector2_0.X = (float)point_.X;
					this.vector2_0.Y = (float)point_.Y;
				}
			}
			this.bool_0 = true;
			if (Class341.class607_3 != 1.0 && !Class800.bool_5 && !Class341.class606_79)
			{
				Point point_3;
				point_3..ctor((int)Math.Round((double)this.vector2_0.X), (int)Math.Round((double)this.vector2_0.Y));
				if (Class800.smethod_23(new Point(point_.X, point_.Y), 0))
				{
					this.vector2_0.X = this.vector2_0.X + (float)(point_.X - point_3.X) * (float)Class341.class607_3;
					this.vector2_0.Y = this.vector2_0.Y + (float)(point_.Y - point_3.Y) * (float)Class341.class607_3;
					point_3..ctor((int)Math.Round((double)this.vector2_0.X), (int)Math.Round((double)this.vector2_0.Y));
				}
				else
				{
					this.vector2_0.X = (float)point_.X;
					this.vector2_0.Y = (float)point_.Y;
					point_3..ctor(point_.X, point_.Y);
				}
				Class800.smethod_13(point_3, false);
				point_ = Class800.smethod_14();
				if (point_3.X != point_.X)
				{
					this.vector2_0.X = this.vector2_0.X + (float)(point_.X - point_3.X);
				}
				if (point_3.Y != point_.Y)
				{
					this.vector2_0.Y = this.vector2_0.Y + (float)(point_.Y - point_3.Y);
					return;
				}
			}
			else
			{
				this.vector2_0.X = (float)point_.X;
				this.vector2_0.Y = (float)point_.Y;
			}
		}

		// Token: 0x060024B3 RID: 9395
		// RVA: 0x00006D2D File Offset: 0x00004F2D
		internal override bool vmethod_2()
		{
			return true;
		}

		// Token: 0x060024B4 RID: 9396
		// RVA: 0x00006D86 File Offset: 0x00004F86
		internal override int vmethod_3()
		{
			return 0;
		}
	}
}
