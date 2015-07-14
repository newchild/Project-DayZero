using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns29;
using ns91;
using osu.Graphics.OpenGl;
using System;

namespace ns85
{
	// Token: 0x0200068A RID: 1674
	internal sealed class Class882 : IDisposable
	{
		// Token: 0x040030A3 RID: 12451
		private BasicEffect basicEffect_0;

		// Token: 0x040030A5 RID: 12453
		private bool bool_0;

		// Token: 0x040030A6 RID: 12454
		private bool bool_1;

		// Token: 0x040030A4 RID: 12452
		private GraphicsDevice graphicsDevice_0;

		// Token: 0x040030A7 RID: 12455
		private int int_0;

		// Token: 0x040030A8 RID: 12456
		private int int_1;

		// Token: 0x040030A9 RID: 12457
		private PrimitiveType primitiveType_0;

		// Token: 0x040030AA RID: 12458
		private VertexDeclaration vertexDeclaration_0;

		// Token: 0x040030AB RID: 12459
		private VertexPositionColor[] vertexPositionColor_0 = new VertexPositionColor[500];

		// Token: 0x0600341E RID: 13342
		// RVA: 0x00166280 File Offset: 0x00164480
		internal Class882()
		{
			if (Class115.bool_26)
			{
				this.graphicsDevice_0 = Class115.class125_0.GraphicsDevice;
				this.vertexDeclaration_0 = new VertexDeclaration(this.graphicsDevice_0, VertexPositionColor.VertexElements);
				this.basicEffect_0 = new BasicEffect(this.graphicsDevice_0, null);
				this.basicEffect_0.set_VertexColorEnabled(true);
				this.basicEffect_0.set_Projection(Matrix.CreateOrthographicOffCenter(0f, (float)this.graphicsDevice_0.get_Viewport().get_Width(), (float)this.graphicsDevice_0.get_Viewport().get_Height(), 0f, 0f, 1f));
			}
		}

		// Token: 0x0600341F RID: 13343
		// RVA: 0x000265C8 File Offset: 0x000247C8
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06003420 RID: 13344
		// RVA: 0x00166340 File Offset: 0x00164540
		protected virtual void Dispose(bool bool_2)
		{
			if (bool_2 && !this.bool_1)
			{
				if (this.vertexDeclaration_0 != null)
				{
					this.vertexDeclaration_0.Dispose();
				}
				if (this.basicEffect_0 != null)
				{
					this.basicEffect_0.Dispose();
				}
				this.bool_1 = true;
			}
		}

		// Token: 0x06003424 RID: 13348
		// RVA: 0x00166554 File Offset: 0x00164754
		private void Flush()
		{
			if (!this.bool_0)
			{
				throw new InvalidOperationException("Begin must be called before Flush can be called.");
			}
			if (this.int_1 == 0)
			{
				return;
			}
			int num = this.int_1 / this.int_0;
			this.graphicsDevice_0.get_RenderState().set_AlphaSourceBlend(5);
			this.graphicsDevice_0.get_RenderState().set_DestinationBlend(6);
			this.graphicsDevice_0.DrawUserPrimitives<VertexPositionColor>(this.primitiveType_0, this.vertexPositionColor_0, 0, num);
			this.int_1 = 0;
		}

		// Token: 0x06003421 RID: 13345
		// RVA: 0x00166394 File Offset: 0x00164594
		internal void method_0()
		{
			if (this.bool_0)
			{
				throw new InvalidOperationException("End must be called before Begin can be called again.");
			}
			if (Class115.bool_26)
			{
				this.primitiveType_0 = 2;
				this.int_0 = Class882.smethod_0(this.primitiveType_0);
				this.graphicsDevice_0.set_VertexDeclaration(this.vertexDeclaration_0);
				this.basicEffect_0.Begin();
				this.basicEffect_0.get_CurrentTechnique().get_Passes().get_Item(0).Begin();
			}
			else
			{
				BaseGLControl.smethod_2(false);
				BaseGLControl.smethod_5(770u, 771u);
				Gl.glLineWidth(1f);
				Gl.glBegin(1u);
			}
			this.bool_0 = true;
		}

		// Token: 0x06003422 RID: 13346
		// RVA: 0x00166438 File Offset: 0x00164638
		internal void method_1(Vector2 vector2_0, Color color_0)
		{
			if (!this.bool_0)
			{
				throw new InvalidOperationException("Begin must be called before AddVertex can be called.");
			}
			if (Class115.bool_26)
			{
				if (this.int_1 % this.int_0 == 0 && this.int_1 + this.int_0 >= this.vertexPositionColor_0.Length)
				{
					this.Flush();
				}
				this.vertexPositionColor_0[this.int_1].Position = new Vector3(vector2_0, 0f);
				this.vertexPositionColor_0[this.int_1].Color = color_0;
				this.int_1++;
				return;
			}
			BaseGLControl.smethod_4(color_0);
			Gl.glVertex2f(vector2_0.X, vector2_0.Y);
		}

		// Token: 0x06003423 RID: 13347
		// RVA: 0x001664F0 File Offset: 0x001646F0
		internal void method_2()
		{
			if (!this.bool_0)
			{
				throw new InvalidOperationException("Begin must be called before End can be called.");
			}
			if (Class115.bool_26)
			{
				this.Flush();
				this.basicEffect_0.get_CurrentTechnique().get_Passes().get_Item(0).End();
				this.basicEffect_0.End();
			}
			else
			{
				Gl.glEnd();
			}
			this.bool_0 = false;
		}

		// Token: 0x06003425 RID: 13349
		// RVA: 0x001665D0 File Offset: 0x001647D0
		private static int smethod_0(PrimitiveType primitiveType_1)
		{
			switch (primitiveType_1)
			{
			case 1:
			{
				int result = 1;
				return result;
			}
			case 2:
			{
				int result = 2;
				return result;
			}
			case 4:
			{
				int result = 3;
				return result;
			}
			}
			throw new InvalidOperationException("primitive is not valid");
		}
	}
}
