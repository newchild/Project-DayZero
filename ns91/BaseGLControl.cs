using Microsoft.Xna.Framework.Graphics;
using ns29;
using ns64;
using osu.Graphics.OpenGl;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ns91
{
	// Token: 0x0200056E RID: 1390
	internal sealed class BaseGLControl : UserControl
	{
		// Token: 0x04002524 RID: 9508
		internal static bool bool_0 = false;

		// Token: 0x04002527 RID: 9511
		private static bool bool_1;

		// Token: 0x04002528 RID: 9512
		private static int int_0 = -1;

		// Token: 0x04002529 RID: 9513
		private static Color? nullable_0;

		// Token: 0x04002526 RID: 9510
		public static object object_0 = new object();

		// Token: 0x04002525 RID: 9509
		internal static Rectangle rectangle_0;

		// Token: 0x0400251E RID: 9502
		private static string string_0;

		// Token: 0x0400251F RID: 9503
		internal static uint uint_0 = 3553u;

		// Token: 0x04002520 RID: 9504
		internal uint uint_1;

		// Token: 0x04002521 RID: 9505
		private uint uint_2;

		// Token: 0x04002522 RID: 9506
		internal uint uint_3;

		// Token: 0x04002523 RID: 9507
		internal uint uint_4;

		// Token: 0x0400252A RID: 9514
		private static uint uint_5;

		// Token: 0x0400252B RID: 9515
		private static uint uint_6;

		// Token: 0x06002CEB RID: 11499
		// RVA: 0x00123500 File Offset: 0x00121700
		public BaseGLControl()
		{
			base.CausesValidation = false;
			base.Capture = false;
			this.InitializeComponent();
			base.SizeChanged += new EventHandler(this.BaseGLControl_SizeChanged);
			base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			base.SetStyle(ControlStyles.DoubleBuffer, false);
			base.SetStyle(ControlStyles.Opaque, true);
			base.SetStyle(ControlStyles.ResizeRedraw, true);
			base.SetStyle(ControlStyles.UserPaint, true);
			this.DoubleBuffered = false;
		}

		// Token: 0x06002CF3 RID: 11507
		// RVA: 0x0012380C File Offset: 0x00121A0C
		internal void BaseGLControl_SizeChanged(object sender, EventArgs e)
		{
			if (this.uint_1 == 0u || this.uint_3 == 0u)
			{
				return;
			}
			if (base.Width != 0 && base.Height != 0)
			{
				base.Location = new Point(0, Class115.bool_12 ? Class115.editorControl_0.Height : 0);
				Class115.form_0.ClientSize = new Size(Class115.int_22, Class115.int_23 + (Class115.bool_12 ? Class115.editorControl_0.Height : 0));
				base.Size = new Size(Class115.int_22, Class115.int_23);
				BaseGLControl.smethod_1(true);
				return;
			}
		}

		// Token: 0x06002CEC RID: 11500
		// RVA: 0x00123574 File Offset: 0x00121774
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (this.uint_3 != 0u)
				{
					WGL.wglDeleteContext(this.uint_3);
					this.uint_3 = 0u;
				}
				if (this.uint_4 != 0u)
				{
					WGL.wglDeleteContext(this.uint_4);
					this.uint_4 = 0u;
				}
			}
			base.Dispose(disposing);
		}

		// Token: 0x06002CEF RID: 11503
		// RVA: 0x0002205C File Offset: 0x0002025C
		internal void Draw()
		{
			if (this.uint_1 == 0u || this.uint_3 == 0u)
			{
				return;
			}
			if (!Class341.smethod_0())
			{
				Gl.glFinish();
				return;
			}
			WGL.wglSwapBuffers(this.uint_1);
			base.Invalidate(false);
		}

		// Token: 0x06002CF5 RID: 11509
		// RVA: 0x000220B0 File Offset: 0x000202B0
		private void InitializeComponent()
		{
			base.Name = "BaseGLControl";
			this.method_1();
		}

		// Token: 0x06002CF0 RID: 11504
		// RVA: 0x0002208F File Offset: 0x0002028F
		internal bool method_0(bool bool_2)
		{
			return WGL.wglMakeCurrent(this.uint_1, bool_2 ? this.uint_4 : this.uint_3) == 0;
		}

		// Token: 0x06002CF1 RID: 11505
		// RVA: 0x001235C4 File Offset: 0x001217C4
		internal void method_1()
		{
			this.uint_2 = (uint)base.Handle.ToInt32();
			this.uint_1 = WGL.GetDC(this.uint_2);
			WGL.wglSwapBuffers(this.uint_1);
			if (Class341.smethod_0())
			{
				Gl.glReadBuffer(1029u);
				Gl.glDrawBuffer(1029u);
			}
			WGL.PIXELFORMATDESCRIPTOR pIXELFORMATDESCRIPTOR = default(WGL.PIXELFORMATDESCRIPTOR);
			WGL.ZeroPixelDescriptor(ref pIXELFORMATDESCRIPTOR);
			pIXELFORMATDESCRIPTOR.nVersion = 1;
			pIXELFORMATDESCRIPTOR.dwFlags = (36u | (Class341.smethod_0() ? 1u : 1073741824u));
			pIXELFORMATDESCRIPTOR.iPixelType = 0;
			pIXELFORMATDESCRIPTOR.cColorBits = 32;
			pIXELFORMATDESCRIPTOR.cAlphaBits = 8;
			pIXELFORMATDESCRIPTOR.cDepthBits = 32;
			pIXELFORMATDESCRIPTOR.iLayerType = 0;
			int num = WGL.ChoosePixelFormat(this.uint_1, ref pIXELFORMATDESCRIPTOR);
			if (num == 0)
			{
				MessageBox.Show("Unable to retrieve pixel format");
				return;
			}
			if (WGL.SetPixelFormat(this.uint_1, num, ref pIXELFORMATDESCRIPTOR) == 0u)
			{
				MessageBox.Show("Unable to set pixel format");
				return;
			}
			this.uint_3 = WGL.wglCreateContext(this.uint_1);
			try
			{
				this.uint_4 = WGL.wglCreateContext(this.uint_1);
				if (!WGL.wglShareLists(this.uint_3, this.uint_4))
				{
					throw new Exception();
				}
			}
			catch
			{
				BaseGLControl.bool_0 = false;
			}
			if (WGL.wglMakeCurrent(this.uint_1, this.uint_3) == 0)
			{
				MessageBox.Show("Unable to make rendering context current");
				return;
			}
			if (BaseGLControl.smethod_0("GL_NV_texture_rectangle"))
			{
				BaseGLControl.uint_0 = 34037u;
			}
			else if (BaseGLControl.smethod_0("GL_ARB_texture_rectangle"))
			{
				BaseGLControl.uint_0 = 34037u;
			}
			else
			{
				BaseGLControl.uint_0 = 3553u;
			}
			this.BaseGLControl_SizeChanged(null, null);
			Gl.glHint(3152u, 4354u);
			Gl.glDisable(2929u);
			Gl.glDisable(2896u);
			Gl.glEnable(3042u);
		}

		// Token: 0x06002CEE RID: 11502
		// RVA: 0x0000653E File Offset: 0x0000473E
		protected override void OnPaint(PaintEventArgs pevent)
		{
		}

		// Token: 0x06002CED RID: 11501
		// RVA: 0x0000653E File Offset: 0x0000473E
		protected override void OnPaintBackground(PaintEventArgs e)
		{
		}

		// Token: 0x06002CF2 RID: 11506
		// RVA: 0x00123798 File Offset: 0x00121998
		private unsafe static bool smethod_0(string string_1)
		{
			try
			{
				if (BaseGLControl.string_0 == null)
				{
					byte* ptr = (byte*)((void*)Gl.glGetString(7939u));
					int num = 0;
					StringBuilder stringBuilder = new StringBuilder();
					while (ptr[num] != 0)
					{
						stringBuilder.Append((char)ptr[num]);
						num++;
					}
					BaseGLControl.string_0 = stringBuilder.ToString();
				}
				return BaseGLControl.string_0.Contains(string_1);
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x06002CF4 RID: 11508
		// RVA: 0x001238A8 File Offset: 0x00121AA8
		internal static void smethod_1(bool bool_2)
		{
			if (bool_2)
			{
				BaseGLControl.rectangle_0 = new Rectangle(0, 0, Class115.int_22, Class115.int_23);
				Gl.glDrawBuffer(1032u);
			}
			Gl.glViewport(0, 0, Math.Abs(BaseGLControl.rectangle_0.Width), Math.Abs(BaseGLControl.rectangle_0.Height));
			if (bool_2)
			{
				Gl.glDrawBuffer(1029u);
			}
			Gl.glMatrixMode(5889u);
			Gl.glLoadIdentity();
			Gl.glOrtho((double)BaseGLControl.rectangle_0.Left, (double)BaseGLControl.rectangle_0.Right, (double)BaseGLControl.rectangle_0.Bottom, (double)BaseGLControl.rectangle_0.Top, -1.0, 1.0);
			Gl.glMatrixMode(5888u);
			Gl.glLoadIdentity();
		}

		// Token: 0x06002CF6 RID: 11510
		// RVA: 0x000220C3 File Offset: 0x000202C3
		public static void smethod_2(bool bool_2)
		{
			if (BaseGLControl.bool_1 == bool_2)
			{
				return;
			}
			BaseGLControl.bool_1 = bool_2;
			if (BaseGLControl.bool_1)
			{
				Gl.glEnable(BaseGLControl.uint_0);
				return;
			}
			Gl.glDisable(BaseGLControl.uint_0);
		}

		// Token: 0x06002CF7 RID: 11511
		// RVA: 0x000220F0 File Offset: 0x000202F0
		internal static void smethod_3(int int_1)
		{
			BaseGLControl.smethod_2(true);
			if (BaseGLControl.int_0 != int_1)
			{
				Gl.glBindTexture(BaseGLControl.uint_0, int_1);
				BaseGLControl.int_0 = int_1;
			}
		}

		// Token: 0x06002CF8 RID: 11512
		// RVA: 0x0012396C File Offset: 0x00121B6C
		internal static void smethod_4(Color color_0)
		{
			if (BaseGLControl.nullable_0 == color_0)
			{
				return;
			}
			Gl.glColor4ub(color_0.get_R(), color_0.get_G(), color_0.get_B(), color_0.get_A());
			BaseGLControl.nullable_0 = new Color?(color_0);
		}

		// Token: 0x06002CF9 RID: 11513
		// RVA: 0x00022111 File Offset: 0x00020311
		internal static void smethod_5(uint uint_7, uint uint_8)
		{
			if (BaseGLControl.uint_5 == uint_7 && BaseGLControl.uint_6 == uint_8)
			{
				return;
			}
			Gl.glBlendFunc(uint_7, uint_8);
			BaseGLControl.uint_5 = uint_7;
			BaseGLControl.uint_6 = uint_8;
		}
	}
}
