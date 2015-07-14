using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns14;
using System;

namespace ns84
{
	// Token: 0x02000484 RID: 1156
	internal sealed class Class586 : Class585
	{
		// Token: 0x06002540 RID: 9536
		// RVA: 0x000E0B84 File Offset: 0x000DED84
		private Texture2D method_11(Color color_3, Color color_4, Color color_5, Color color_6, float float_1)
		{
			RenderTarget2D renderTarget2D = new RenderTarget2D(base.method_8(), 128, 1, 1, 1);
			VertexPositionColor[] array = new VertexPositionColor[]
			{
				new VertexPositionColor(new Vector3(-0.5f, 0f, 0f), Color.get_TransparentBlack()),
				new VertexPositionColor(new Vector3(0f, 0f, 0f), Color.get_TransparentBlack()),
				new VertexPositionColor(new Vector3(0.078125f - float_1, 0f, 0f), color_3),
				new VertexPositionColor(new Vector3(0.078125f + float_1, 0f, 0f), color_4),
				new VertexPositionColor(new Vector3(0.1875f - float_1, 0f, 0f), color_4),
				new VertexPositionColor(new Vector3(0.1875f + float_1, 0f, 0f), color_6),
				new VertexPositionColor(new Vector3(1f, 0f, 0f), color_5),
				new VertexPositionColor(new Vector3(1.5f, 0f, 0f), color_5)
			};
			RenderTarget2D renderTarget2D2 = (RenderTarget2D)base.method_8().GetRenderTarget(0);
			base.method_8().SetRenderTarget(0, renderTarget2D);
			base.method_8().get_RenderState().set_AlphaBlendEnable(false);
			base.method_8().get_RenderState().set_DepthBufferEnable(false);
			base.method_8().get_RenderState().set_AlphaTestEnable(false);
			base.method_8().get_RenderState().set_BlendFunction(1);
			base.method_8().get_RenderState().set_AlphaBlendOperation(1);
			base.method_8().set_VertexDeclaration(new VertexDeclaration(base.method_8(), VertexPositionColor.VertexElements));
			base.method_8().Clear(Color.get_PaleVioletRed());
			base.method_9().set_World(Matrix.get_Identity());
			base.method_9().set_Projection(Matrix.CreateOrthographicOffCenter(0f, 1f, 1f, -1f, -1f, 1f));
			base.method_9().set_View(Matrix.get_Identity());
			base.method_9().set_TextureEnabled(false);
			base.method_9().set_Texture(null);
			base.method_9().set_VertexColorEnabled(true);
			base.method_9().Begin();
			base.method_9().get_CurrentTechnique().get_Passes().get_Item(0).Begin();
			base.method_8().DrawUserPrimitives<VertexPositionColor>(3, array, 0, 7);
			base.method_9().get_CurrentTechnique().get_Passes().get_Item(0).End();
			base.method_9().End();
			base.method_8().ResolveRenderTarget(0);
			Texture2D texture = renderTarget2D.GetTexture();
			base.method_8().SetRenderTarget(0, renderTarget2D2);
			return texture;
		}

		// Token: 0x06002541 RID: 9537
		// RVA: 0x000E0E80 File Offset: 0x000DF080
		private Texture2D method_12(Color color_3, Color color_4, Color color_5)
		{
			float float_ = Math.Min(Math.Max(0.5f / base.vmethod_2(), 0.005859375f), 0.0625f);
			Color color_6;
			color_6..ctor(0, 0, 0, 64);
			return this.method_11(color_6, color_3, color_4, color_5, float_);
		}

		// Token: 0x0600253F RID: 9535
		// RVA: 0x000E0B34 File Offset: 0x000DED34
		internal static void smethod_0(Color color_3, ref Color color_4, ref Color color_5)
		{
			Color color_6;
			color_6..ctor(color_3.get_R(), color_3.get_G(), color_3.get_B(), 180);
			color_4 = Class610.smethod_1(color_6, 0.5f);
			color_5 = Class610.smethod_2(color_6, 0.1f);
		}

		// Token: 0x0600253E RID: 9534
		// RVA: 0x000E0B14 File Offset: 0x000DED14
		protected override Texture2D vmethod_3(Color color_3, Color color_4)
		{
			Color color_5;
			Color color_6;
			Class586.smethod_0(color_3, ref color_5, ref color_6);
			return this.method_12(color_4, color_5, color_6);
		}
	}
}
