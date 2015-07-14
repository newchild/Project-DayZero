using Microsoft.Xna.Framework.Graphics;
using ns14;
using ns91;
using osu.Graphics.OpenGl;
using System;
using System.Drawing;

namespace ns84
{
	// Token: 0x02000486 RID: 1158
	internal sealed class Class588 : Class587
	{
		// Token: 0x06002562 RID: 9570
		// RVA: 0x000E1834 File Offset: 0x000DFA34
		private Class748 method_10(Color color_3, Color color_4, Color color_5, Color color_6, float float_1)
		{
			Gl.glPushAttrib(8192u);
			BaseGLControl.smethod_2(false);
			Gl.glViewport(0, 0, 128, 1);
			Gl.glDisable(2929u);
			Gl.glDisable(3042u);
			Gl.glMatrixMode(5888u);
			Gl.glLoadIdentity();
			Gl.glMatrixMode(5889u);
			Gl.glLoadIdentity();
			Gl.glOrtho(0.0, 1.0, 1.0, -1.0, -1.0, 1.0);
			Gl.glClearColor(0.859f, 0.439f, 0.576f, 1f);
			Gl.glClear(16384u);
			Gl.glClearColor(0f, 0f, 0f, 0f);
			Gl.glBegin(3u);
			BaseGLControl.smethod_4(Color.get_TransparentBlack());
			Gl.glVertex2f(-0.5f, 0f);
			Gl.glVertex2f(0f, 0f);
			BaseGLControl.smethod_4(color_3);
			Gl.glVertex2f(0.078125f - float_1, 0f);
			BaseGLControl.smethod_4(color_4);
			Gl.glVertex2f(0.078125f + float_1, 0f);
			Gl.glVertex2f(0.1875f - float_1, 0f);
			BaseGLControl.smethod_4(color_6);
			Gl.glVertex2f(0.1875f + float_1, 0f);
			BaseGLControl.smethod_4(color_5);
			Gl.glVertex2f(1f, 0f);
			Gl.glVertex2f(1.5f, 0f);
			Gl.glEnd();
			Class748 class = new Class748(128, 1);
			int[] array = new int[1];
			Gl.glGenTextures(1, array);
			BaseGLControl.smethod_3(array[0]);
			Gl.glTexParameteri(BaseGLControl.uint_0, 10241u, 9729);
			Gl.glTexParameteri(BaseGLControl.uint_0, 10240u, 9729);
			Gl.glCopyTexImage2D(BaseGLControl.uint_0, 0, 6408u, 0, 0, 128, 1, 0);
			class.method_2(array[0]);
			Gl.glPopAttrib();
			BaseGLControl.smethod_1(false);
			Gl.glClear(16384u);
			return class;
		}

		// Token: 0x06002563 RID: 9571
		// RVA: 0x000E1A3C File Offset: 0x000DFC3C
		private Class748 method_11(Color color_3, Color color_4, Color color_5)
		{
			float float_ = Math.Min(Math.Max(0.5f / base.vmethod_2(), 0.01171875f), 0.0625f);
			Color color_6;
			color_6..ctor(0, 0, 0, 64);
			return this.method_10(color_6, color_3, color_4, color_5, float_);
		}

		// Token: 0x06002561 RID: 9569
		// RVA: 0x000E0B34 File Offset: 0x000DED34
		internal static void smethod_0(Color color_3, ref Color color_4, ref Color color_5)
		{
			Color color_6;
			color_6..ctor(color_3.get_R(), color_3.get_G(), color_3.get_B(), 180);
			color_4 = Class610.smethod_1(color_6, 0.5f);
			color_5 = Class610.smethod_2(color_6, 0.1f);
		}

		// Token: 0x06002560 RID: 9568
		// RVA: 0x000E1814 File Offset: 0x000DFA14
		protected override Class748 vmethod_3(Color color_3, Color color_4)
		{
			Color color_5;
			Color color_6;
			Class588.smethod_0(color_3, ref color_5, ref color_6);
			return this.method_11(color_4, color_5, color_6);
		}

		// Token: 0x06002564 RID: 9572
		// RVA: 0x0001D134 File Offset: 0x0001B334
		protected override Size vmethod_4()
		{
			return new Size(128, 1);
		}
	}
}
