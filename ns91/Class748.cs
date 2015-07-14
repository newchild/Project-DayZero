using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns29;
using osu.Graphics.OpenGl;
using osu_common.Helpers;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

namespace ns91
{
	// Token: 0x0200058B RID: 1419
	internal sealed class Class748 : IDisposable
	{
		// Token: 0x0200058C RID: 1420
		[CompilerGenerated]
		private sealed class Class749
		{
			// Token: 0x0400260F RID: 9743
			public int int_0;

			// Token: 0x06002D6E RID: 11630
			// RVA: 0x00127974 File Offset: 0x00125B74
			public void method_0()
			{
				try
				{
					if (Gl.glIsTexture(this.int_0) > 0u)
					{
						int[] array = new int[]
						{
							this.int_0
						};
						Gl.glDeleteTextures(1, array);
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x0400260A RID: 9738
		private readonly int int_0;

		// Token: 0x0400260B RID: 9739
		private readonly int int_1;

		// Token: 0x0400260C RID: 9740
		private readonly int int_2;

		// Token: 0x0400260D RID: 9741
		private readonly int int_3;

		// Token: 0x0400260E RID: 9742
		private int int_4;

		// Token: 0x06002D63 RID: 11619
		// RVA: 0x0012738C File Offset: 0x0012558C
		public Class748(int int_5, int int_6)
		{
			this.int_4 = -1;
			this.int_3 = int_5;
			this.int_2 = int_6;
			if (BaseGLControl.uint_0 == 3553u)
			{
				this.int_1 = Class748.smethod_0(int_5);
				this.int_0 = Class748.smethod_0(int_6);
			}
		}

		// Token: 0x06002D64 RID: 11620
		// RVA: 0x00022517 File Offset: 0x00020717
		public void Dispose()
		{
			this.Dispose(true);
		}

		// Token: 0x06002D66 RID: 11622
		// RVA: 0x00022520 File Offset: 0x00020720
		protected virtual void Dispose(bool bool_0)
		{
			if (bool_0)
			{
				this.method_1();
			}
		}

		// Token: 0x06002D67 RID: 11623
		// RVA: 0x0012742C File Offset: 0x0012562C
		public void Draw(Vector2 vector2_0, Vector2 vector2_1, Color color_0, Vector2 vector2_2, float float_0, Rectangle? nullable_0)
		{
			if (this.int_4 < 0)
			{
				return;
			}
			Rectangle rectangle = (!nullable_0.HasValue) ? new Rectangle(0, 0, this.int_3, this.int_2) : nullable_0.Value;
			float num = (float)rectangle.Height * Math.Abs(vector2_2.Y);
			float num2 = (float)rectangle.Width * Math.Abs(vector2_2.X);
			Vector2 vector;
			vector..ctor(vector2_1.X * num2 / (float)rectangle.Width, vector2_1.Y * num / (float)rectangle.Height);
			bool flag = vector2_2.Y < 0f;
			bool flag2 = vector2_2.X < 0f;
			BaseGLControl.smethod_4(color_0);
			BaseGLControl.smethod_3(this.int_4);
			Gl.glPushMatrix();
			Gl.glTranslatef(vector2_0.X, vector2_0.Y, 0f);
			if (float_0 != 0f)
			{
				Gl.glRotatef(MathHelper.ToDegrees(float_0), 0f, 0f, 1f);
			}
			if (vector != Vector2.get_Zero())
			{
				Gl.glTranslatef(-vector.X, -vector.Y, 0f);
			}
			Gl.glBegin(7u);
			if (BaseGLControl.uint_0 == 3553u)
			{
				float num3 = (float)rectangle.get_Left() / (float)this.int_1;
				float num4 = (float)rectangle.get_Right() / (float)this.int_1;
				float num5 = (float)rectangle.get_Top() / (float)this.int_0;
				float num6 = (float)rectangle.get_Bottom() / (float)this.int_0;
				Gl.glTexCoord2f(flag2 ? num4 : num3, flag ? num5 : num6);
				Gl.glVertex2f(0f, num);
				Gl.glTexCoord2f(flag2 ? num3 : num4, flag ? num5 : num6);
				Gl.glVertex2f(num2, num);
				Gl.glTexCoord2f(flag2 ? num3 : num4, flag ? num6 : num5);
				Gl.glVertex2f(num2, 0f);
				Gl.glTexCoord2f(flag2 ? num4 : num3, flag ? num6 : num5);
				Gl.glVertex2f(0f, 0f);
			}
			else
			{
				Gl.glTexCoord2f((float)(flag2 ? rectangle.get_Right() : rectangle.get_Left()), (float)(flag ? rectangle.get_Top() : rectangle.get_Bottom()));
				Gl.glVertex2f(0f, num);
				Gl.glTexCoord2f((float)(flag2 ? rectangle.get_Left() : rectangle.get_Right()), (float)(flag ? rectangle.get_Top() : rectangle.get_Bottom()));
				Gl.glVertex2f(num2, num);
				Gl.glTexCoord2f((float)(flag2 ? rectangle.get_Left() : rectangle.get_Right()), (float)(flag ? rectangle.get_Bottom() : rectangle.get_Top()));
				Gl.glVertex2f(num2, 0f);
				Gl.glTexCoord2f((float)(flag2 ? rectangle.get_Right() : rectangle.get_Left()), (float)(flag ? rectangle.get_Bottom() : rectangle.get_Top()));
				Gl.glVertex2f(0f, 0f);
			}
			Gl.glEnd();
			Gl.glPopMatrix();
		}

		// Token: 0x06002D62 RID: 11618
		// RVA: 0x0002250C File Offset: 0x0002070C
		public bool method_0()
		{
			return this.int_4 > 0;
		}

		// Token: 0x06002D65 RID: 11621
		// RVA: 0x001273D8 File Offset: 0x001255D8
		public void method_1()
		{
			Class748.Class749 class = new Class748.Class749();
			if (this.int_4 == -1)
			{
				return;
			}
			if (Class115.baseGLControl_0.IsDisposed)
			{
				return;
			}
			class.int_0 = this.int_4;
			Class115.class47_0.Add(new VoidDelegate(class.method_0), false);
			this.int_4 = -1;
		}

		// Token: 0x06002D68 RID: 11624
		// RVA: 0x0002252B File Offset: 0x0002072B
		public void method_2(int int_5)
		{
			this.int_4 = int_5;
		}

		// Token: 0x06002D69 RID: 11625
		// RVA: 0x00127740 File Offset: 0x00125940
		public void method_3(byte[] byte_0, int int_5, int int_6)
		{
			GCHandle gCHandle = GCHandle.Alloc(byte_0, GCHandleType.Pinned);
			this.method_4(gCHandle.AddrOfPinnedObject(), int_5, int_6);
			gCHandle.Free();
		}

		// Token: 0x06002D6B RID: 11627
		// RVA: 0x00127788 File Offset: 0x00125988
		public void method_4(IntPtr intptr_0, int int_5, int int_6)
		{
			if (int_6 == 0)
			{
				int_6 = 32993;
			}
			bool flag = false;
			int num = this.int_4;
			if (int_5 == 0 && this.int_4 < 0)
			{
				this.method_1();
				flag = true;
				int[] array = new int[1];
				Gl.glGenTextures(1, array);
				num = array[0];
			}
			if (int_5 > 0)
			{
				return;
			}
			BaseGLControl.smethod_2(true);
			BaseGLControl.smethod_3(num);
			Gl.glTexParameteri(BaseGLControl.uint_0, 10241u, 9729);
			Gl.glTexParameteri(BaseGLControl.uint_0, 10240u, 9729);
			if (flag)
			{
				if (BaseGLControl.uint_0 == 3553u)
				{
					if (this.int_1 == this.int_3 && this.int_0 == this.int_2)
					{
						Gl.glTexImage2D(BaseGLControl.uint_0, int_5, 6408u, this.int_1, this.int_0, 0, int_6, 5121, intptr_0);
					}
					else
					{
						byte[] value = new byte[this.int_1 * this.int_0 * 4];
						GCHandle gCHandle = GCHandle.Alloc(value, GCHandleType.Pinned);
						Gl.glTexImage2D(BaseGLControl.uint_0, int_5, 6408u, this.int_1, this.int_0, 0, int_6, 5121, gCHandle.AddrOfPinnedObject());
						gCHandle.Free();
						Gl.glTexSubImage2D(BaseGLControl.uint_0, int_5, 0, 0, this.int_3, this.int_2, int_6, 5121u, intptr_0);
					}
				}
				else
				{
					Gl.glTexImage2D(BaseGLControl.uint_0, int_5, 6408u, this.int_3, this.int_2, 0, int_6, 5121, intptr_0);
				}
			}
			else
			{
				lock (BaseGLControl.object_0)
				{
					Gl.glTexSubImage2D(BaseGLControl.uint_0, int_5, 0, 0, this.int_3, this.int_2, int_6, 5121u, intptr_0);
					if (Class115.thread_2 != Thread.CurrentThread)
					{
						Gl.glFinish();
					}
				}
			}
			if (Class115.thread_2 != Thread.CurrentThread && this.int_4 != num)
			{
				Gl.glFinish();
			}
			this.int_4 = num;
		}

		// Token: 0x06002D6C RID: 11628
		// RVA: 0x00022534 File Offset: 0x00020734
		public int method_5()
		{
			return this.int_4;
		}

		// Token: 0x06002D6A RID: 11626
		// RVA: 0x0012776C File Offset: 0x0012596C
		internal static int smethod_0(int int_5)
		{
			int i;
			for (i = 1; i < int_5; i *= 2)
			{
			}
			return i;
		}
	}
}
