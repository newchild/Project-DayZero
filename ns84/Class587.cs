using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns14;
using ns85;
using ns91;
using osu.Graphics.OpenGl;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace ns84
{
	// Token: 0x02000485 RID: 1157
	internal abstract class Class587 : IDisposable, Interface16, Interface17
	{
		// Token: 0x04001EEE RID: 7918
		private bool bool_0;

		// Token: 0x04001EEF RID: 7919
		private bool bool_1;

		// Token: 0x04001EEA RID: 7914
		protected Class748[] class748_0;

		// Token: 0x04001EEB RID: 7915
		protected Class748 class748_1;

		// Token: 0x04001EEC RID: 7916
		protected Class748 class748_2;

		// Token: 0x04001EF1 RID: 7921
		private Color color_0 = Color.get_Gray();

		// Token: 0x04001EF2 RID: 7922
		private Color color_1 = Color.get_Gray();

		// Token: 0x04001EF3 RID: 7923
		private Color color_2 = Color.get_White();

		// Token: 0x04001EF4 RID: 7924
		private float float_0 = 64f;

		// Token: 0x04001EE4 RID: 7908
		private int int_0;

		// Token: 0x04001EE5 RID: 7909
		private int int_1;

		// Token: 0x04001EE6 RID: 7910
		private int int_2;

		// Token: 0x04001EE7 RID: 7911
		private int int_3;

		// Token: 0x04001EE8 RID: 7912
		private int int_4;

		// Token: 0x04001EE9 RID: 7913
		private int int_5;

		// Token: 0x04001EF0 RID: 7920
		private List<Color> list_0 = new List<Color>();

		// Token: 0x04001EED RID: 7917
		private Vector3[] vector3_0;

		// Token: 0x0600255C RID: 9564
		// RVA: 0x0001D0E6 File Offset: 0x0001B2E6
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x0600255D RID: 9565
		// RVA: 0x000E17C0 File Offset: 0x000DF9C0
		protected virtual void Dispose(bool bool_2)
		{
			if (bool_2)
			{
				if (this.class748_0 == null)
				{
					return;
				}
				Class748[] array = this.class748_0;
				for (int i = 0; i < array.Length; i++)
				{
					Class748 idisposable_ = array[i];
					this.method_9(idisposable_);
				}
				this.method_9(this.class748_1);
				this.method_9(this.class748_2);
			}
		}

		// Token: 0x06002552 RID: 9554
		// RVA: 0x000E1188 File Offset: 0x000DF388
		public void Draw(Class880 class880_0, float float_1, Color color_3)
		{
			this.Draw(new List<Class880>(1)
			{
				class880_0
			}, null, float_1, color_3);
		}

		// Token: 0x06002553 RID: 9555
		// RVA: 0x0001D0B9 File Offset: 0x0001B2B9
		public void Draw(List<Class880> list_1, Class880 class880_0, float float_1, Color color_3)
		{
			this.Draw(list_1, class880_0, float_1, color_3, this.color_2);
		}

		// Token: 0x06002555 RID: 9557
		// RVA: 0x000E11D8 File Offset: 0x000DF3D8
		public void Draw(List<Class880> list_1, Class880 class880_0, float float_1, int int_6)
		{
			switch (int_6)
			{
			case -2:
				this.method_7(list_1, float_1, this.class748_2, class880_0);
				return;
			case -1:
				this.method_7(list_1, float_1, this.class748_1, class880_0);
				return;
			default:
				if (int_6 < this.class748_0.Length && int_6 >= 0)
				{
					this.method_7(list_1, float_1, this.class748_0[int_6], class880_0);
					return;
				}
				this.method_7(list_1, float_1, this.class748_1, class880_0);
				return;
			}
		}

		// Token: 0x06002554 RID: 9556
		// RVA: 0x000E11B0 File Offset: 0x000DF3B0
		public void Draw(List<Class880> list_1, Class880 class880_0, float float_1, Color color_3, Color color_4)
		{
			Class748 class = this.vmethod_3(color_3, color_4);
			this.method_7(list_1, float_1, class, class880_0);
			class.Dispose();
		}

		// Token: 0x06002556 RID: 9558
		// RVA: 0x0001D0CC File Offset: 0x0001B2CC
		public void Draw(List<Class880> list_1, Class880 class880_0, float float_1, int int_6, Color color_3)
		{
			this.Draw(list_1, class880_0, float_1, this.list_0[int_6], color_3);
		}

		// Token: 0x0600255B RID: 9563
		// RVA: 0x000E1790 File Offset: 0x000DF990
		~Class587()
		{
			this.Dispose(false);
		}

		// Token: 0x06002545 RID: 9541
		// RVA: 0x0001CFE7 File Offset: 0x0001B1E7
		public Color imethod_0()
		{
			return this.color_0;
		}

		// Token: 0x06002546 RID: 9542
		// RVA: 0x0001CFEF File Offset: 0x0001B1EF
		public void imethod_1(Color color_3)
		{
			if (this.color_0 == color_3)
			{
				return;
			}
			this.color_0 = color_3;
			if (this.bool_1)
			{
				this.method_1();
			}
		}

		// Token: 0x06002547 RID: 9543
		// RVA: 0x0001D015 File Offset: 0x0001B215
		public Color imethod_2()
		{
			return this.color_1;
		}

		// Token: 0x0600254A RID: 9546
		// RVA: 0x000E0FB0 File Offset: 0x000DF1B0
		public void imethod_3(List<Color> list_1, Color color_3, Color color_4, Color color_5, float float_1)
		{
			if (!(this.color_2 != color_5))
			{
				if (this.float_0 == float_1)
				{
					this.vmethod_0(list_1);
					this.imethod_1(color_3);
					this.vmethod_1(color_4);
					return;
				}
			}
			this.list_0 = new List<Color>(list_1);
			this.color_0 = color_3;
			this.color_1 = color_4;
			this.color_2 = color_5;
			this.float_0 = float_1;
			if (this.bool_1)
			{
				this.method_3();
			}
		}

		// Token: 0x06002543 RID: 9539
		// RVA: 0x000E0EC8 File Offset: 0x000DF0C8
		internal void Initialize()
		{
			if (!this.bool_0)
			{
				this.int_4 = 6;
				this.int_2 = 4;
				this.int_0 = 6;
				this.int_5 = 26;
				this.int_3 = 24;
				this.int_1 = 72;
				this.method_4();
				this.bool_0 = true;
			}
			if (!this.bool_1)
			{
				this.method_3();
				this.bool_1 = true;
			}
		}

		// Token: 0x0600254B RID: 9547
		// RVA: 0x000E1028 File Offset: 0x000DF228
		private void method_0()
		{
			int count = this.list_0.Count;
			if (count == 0)
			{
				this.class748_0 = new Class748[1];
				this.class748_0[0] = this.vmethod_3(Color.get_TransparentBlack(), this.color_2);
				return;
			}
			if (this.class748_0 != null)
			{
				Class748[] array = this.class748_0;
				for (int i = 0; i < array.Length; i++)
				{
					Class748 class = array[i];
					if (class != null)
					{
						class.Dispose();
					}
				}
			}
			this.class748_0 = new Class748[count];
			for (int j = 0; j < count; j++)
			{
				this.class748_0[j] = this.vmethod_3(this.list_0[j], this.color_2);
			}
		}

		// Token: 0x0600254C RID: 9548
		// RVA: 0x0001D04B File Offset: 0x0001B24B
		private void method_1()
		{
			if (this.class748_2 != null)
			{
				this.class748_2.Dispose();
			}
			this.class748_2 = this.vmethod_3(this.color_0, this.color_2);
		}

		// Token: 0x0600254D RID: 9549
		// RVA: 0x0001D078 File Offset: 0x0001B278
		private void method_2()
		{
			if (this.class748_1 != null)
			{
				this.class748_1.Dispose();
			}
			this.class748_1 = this.vmethod_3(this.color_1, this.color_2);
		}

		// Token: 0x0600254E RID: 9550
		// RVA: 0x0001D0A5 File Offset: 0x0001B2A5
		private void method_3()
		{
			this.method_0();
			this.method_1();
			this.method_2();
		}

		// Token: 0x06002551 RID: 9553
		// RVA: 0x000E10D4 File Offset: 0x000DF2D4
		private void method_4()
		{
			this.vector3_0 = new Vector3[this.int_5 - 1];
			float num = (float)0.13089958826700845;
			this.vector3_0[0] = new Vector3(0f, -1f, 0f);
			for (int i = 1; i < 24; i++)
			{
				float num2 = (float)i * num;
				this.vector3_0[i] = new Vector3((float)Math.Sin((double)num2), -(float)Math.Cos((double)num2), 0f);
			}
			this.vector3_0[24] = new Vector3(0f, 1f, 0f);
		}

		// Token: 0x06002557 RID: 9559
		// RVA: 0x000E124C File Offset: 0x000DF44C
		private void method_5()
		{
			Gl.glBegin(5u);
			Gl.glTexCoord2f(0f, 0f);
			Gl.glVertex3f(-0.0003f, -1f, 0f);
			Gl.glVertex3f(1.0003f, -1f, 0f);
			Gl.glTexCoord2f((BaseGLControl.uint_0 == 3553u) ? (1f - 1f / (float)this.vmethod_4().Width) : ((float)this.vmethod_4().Width), 0f);
			Gl.glVertex3f(-0.0003f, 0.0001f, 1f);
			Gl.glVertex3f(1.0003f, 0.0001f, 1f);
			Gl.glTexCoord2f(0f, 0f);
			Gl.glVertex3f(-0.0003f, 1f, 0f);
			Gl.glVertex3f(1.0003f, 1f, 0f);
			Gl.glEnd();
		}

		// Token: 0x06002558 RID: 9560
		// RVA: 0x000E133C File Offset: 0x000DF53C
		private void method_6(int int_6)
		{
			if (int_6 > 0)
			{
				Gl.glBegin(6u);
				Gl.glTexCoord2f((BaseGLControl.uint_0 == 3553u) ? (1f - 1f / (float)this.vmethod_4().Width) : ((float)this.vmethod_4().Width), 0f);
				Gl.glVertex3f(0f, 0f, 1f);
				Gl.glTexCoord2f(0f, 0f);
				for (int i = 0; i <= int_6; i++)
				{
					Vector3 vector = this.vector3_0[i];
					Gl.glVertex3f(vector.X, vector.Y, vector.Z);
				}
				Gl.glEnd();
			}
		}

		// Token: 0x06002559 RID: 9561
		// RVA: 0x000E13F8 File Offset: 0x000DF5F8
		private void method_7(List<Class880> list_1, float float_1, Class748 class748_3, Class880 class880_0)
		{
			Gl.glPushAttrib(8192u);
			BaseGLControl.smethod_2(false);
			Gl.glDisable(2884u);
			Gl.glDisable(3042u);
			Gl.glEnable(2929u);
			Gl.glDepthMask(1);
			Gl.glDepthFunc(515u);
			BaseGLControl.smethod_2(true);
			Gl.glColor3ub(255, 255, 255);
			Gl.glMatrixMode(5888u);
			Gl.glLoadIdentity();
			BaseGLControl.smethod_3(class748_3.method_5());
			Gl.glTexParameteri(BaseGLControl.uint_0, 10241u, 9729);
			Gl.glTexParameteri(BaseGLControl.uint_0, 10240u, 9729);
			int count = list_1.Count;
			for (int i = 1; i < count; i++)
			{
				this.method_8(class880_0, list_1[i - 1], list_1[i], float_1);
				class880_0 = list_1[i - 1];
			}
			this.method_8(class880_0, list_1[count - 1], null, float_1);
			Gl.glLoadIdentity();
			Gl.glPopAttrib();
		}

		// Token: 0x0600255A RID: 9562
		// RVA: 0x000E14F4 File Offset: 0x000DF6F4
		private void method_8(Class880 class880_0, Class880 class880_1, Class880 class880_2, float float_1)
		{
			Gl.glLoadMatrixf(Class778.smethod_7(new Matrix(class880_1.method_0(), 0f, 0f, 0f, 0f, float_1, 0f, 0f, 0f, 0f, 1f, 0f, 0f, 0f, 0f, 1f) * class880_1.method_2()));
			this.method_5();
			bool flag;
			int num;
			if (class880_2 == null)
			{
				flag = false;
				num = this.int_3;
			}
			else
			{
				float num2 = class880_2.method_1() - class880_1.method_1();
				if ((double)num2 > 3.1415926535897931)
				{
					num2 -= 6.28318548f;
				}
				if ((double)num2 < -3.1415926535897931)
				{
					num2 += 6.28318548f;
				}
				if (num2 < 0f)
				{
					flag = true;
					num = (int)Math.Ceiling((double)(-(double)num2 * 24f) / 3.1415926535897931 + 0.0);
				}
				else if (num2 > 0f)
				{
					flag = false;
					num = (int)Math.Ceiling((double)(num2 * 24f) / 3.1415926535897931 + 0.0);
				}
				else
				{
					flag = false;
					num = 0;
				}
			}
			num = Math.Min(num, this.int_3);
			if (flag)
			{
				Gl.glLoadMatrixf(Class778.smethod_7(new Matrix(float_1, 0f, 0f, 0f, 0f, -float_1, 0f, 0f, 0f, 0f, 1f, 0f, 0f, 0f, 0f, 1f) * class880_1.method_3()));
			}
			else
			{
				Gl.glLoadMatrixf(Class778.smethod_7(new Matrix(float_1, 0f, 0f, 0f, 0f, float_1, 0f, 0f, 0f, 0f, 1f, 0f, 0f, 0f, 0f, 1f) * class880_1.method_3()));
			}
			this.method_6(num);
			bool flag2 = false;
			if (class880_0 == null)
			{
				flag2 = true;
			}
			else if (class880_1.vector2_0 != class880_0.vector2_1)
			{
				flag2 = true;
			}
			if (flag2)
			{
				Gl.glLoadMatrixf(Class778.smethod_7(new Matrix(-float_1, 0f, 0f, 0f, 0f, -float_1, 0f, 0f, 0f, 0f, 1f, 0f, 0f, 0f, 0f, 1f) * class880_1.method_2()));
				this.method_6(this.int_3);
			}
		}

		// Token: 0x0600255E RID: 9566
		// RVA: 0x0001CE1C File Offset: 0x0001B01C
		private void method_9(IDisposable idisposable_0)
		{
			if (idisposable_0 != null)
			{
				idisposable_0.Dispose();
			}
		}

		// Token: 0x06002544 RID: 9540
		// RVA: 0x000E0F2C File Offset: 0x000DF12C
		public void vmethod_0(List<Color> list_1)
		{
			if (list_1.Count != this.list_0.Count)
			{
				this.list_0 = new List<Color>(list_1);
				if (this.bool_1)
				{
					this.method_0();
				}
				return;
			}
			for (int i = 0; i < list_1.Count; i++)
			{
				if (list_1[i] != this.list_0[i])
				{
					this.list_0 = new List<Color>(list_1);
					if (this.bool_1)
					{
						this.method_0();
					}
					return;
				}
			}
		}

		// Token: 0x06002548 RID: 9544
		// RVA: 0x0001D01D File Offset: 0x0001B21D
		public void vmethod_1(Color color_3)
		{
			if (this.color_1 == color_3)
			{
				return;
			}
			this.color_1 = color_3;
			if (this.bool_1)
			{
				this.method_2();
			}
		}

		// Token: 0x06002549 RID: 9545
		// RVA: 0x0001D043 File Offset: 0x0001B243
		public float vmethod_2()
		{
			return this.float_0;
		}

		// Token: 0x0600254F RID: 9551
		protected abstract Class748 vmethod_3(Color color_3, Color color_4);

		// Token: 0x06002550 RID: 9552
		protected abstract Size vmethod_4();
	}
}
