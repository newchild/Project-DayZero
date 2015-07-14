using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns29;
using ns64;
using ns90;
using System;

namespace ns84
{
	// Token: 0x0200056B RID: 1387
	internal static class Class733
	{
		// Token: 0x04002508 RID: 9480
		internal static bool bool_0;

		// Token: 0x0400250D RID: 9485
		internal static bool bool_1;

		// Token: 0x0400250E RID: 9486
		internal static bool bool_2;

		// Token: 0x0400250C RID: 9484
		internal static Color color_0 = Color.get_White();

		// Token: 0x0400250A RID: 9482
		private static Effect effect_0;

		// Token: 0x04002509 RID: 9481
		internal static float float_0 = 0.2f;

		// Token: 0x0400250F RID: 9487
		internal static float float_1 = 0.004f;

		// Token: 0x04002510 RID: 9488
		internal static float float_2;

		// Token: 0x0400250B RID: 9483
		private static RenderTarget2D renderTarget2D_0;

		// Token: 0x04002511 RID: 9489
		private static RenderTarget2D renderTarget2D_1;

		// Token: 0x06002CDF RID: 11487
		// RVA: 0x001229AC File Offset: 0x00120BAC
		internal static bool Initialize()
		{
			if (!Class341.class606_4)
			{
				return true;
			}
			if (Class115.bool_27)
			{
				Class341.class606_4.Value = false;
				Class723.smethod_4("Shaders are not yet implemented for OpenGL, sorry!");
				return false;
			}
			bool result;
			try
			{
				if (Class733.renderTarget2D_1 != null)
				{
					Class733.renderTarget2D_1.Dispose();
				}
				Class733.renderTarget2D_1 = new RenderTarget2D(Class115.class125_0.GraphicsDevice, Class115.int_22, Class115.int_23 + Class115.int_25, 1, 1);
				if (Class733.renderTarget2D_0 != null)
				{
					Class733.renderTarget2D_0.Dispose();
				}
				Class733.renderTarget2D_0 = new RenderTarget2D(Class115.class125_0.GraphicsDevice, 256, 256, 1, 1);
				Class733.effect_0 = Class115.contentManager_0.Load<Effect>("Bloom");
				return true;
			}
			catch
			{
				Class341.class606_4.Value = false;
				Class723.smethod_4("No shader support - disabling bloom effects.");
				result = false;
			}
			return result;
		}

		// Token: 0x06002CDE RID: 11486
		// RVA: 0x00122958 File Offset: 0x00120B58
		internal static void smethod_0()
		{
			if (!Class341.class606_4)
			{
				return;
			}
			if (Class733.renderTarget2D_1 != null)
			{
				Class733.renderTarget2D_1.Dispose();
			}
			Class733.renderTarget2D_1 = null;
			if (Class733.renderTarget2D_0 != null)
			{
				Class733.renderTarget2D_0.Dispose();
			}
			Class733.renderTarget2D_0 = null;
		}

		// Token: 0x06002CE0 RID: 11488
		// RVA: 0x00021F89 File Offset: 0x00020189
		internal static void smethod_1()
		{
			if (!Class341.class606_5 && !Class733.bool_1)
			{
				return;
			}
			Class115.class125_0.GraphicsDevice.SetRenderTarget(0, Class733.renderTarget2D_1);
			Class115.class125_0.GraphicsDevice.Clear(Color.get_Black());
		}

		// Token: 0x06002CE1 RID: 11489
		// RVA: 0x00122A9C File Offset: 0x00120C9C
		internal static void smethod_2()
		{
			if (!Class341.class606_5 && !Class733.bool_1)
			{
				return;
			}
			try
			{
				Class115.class125_0.GraphicsDevice.ResolveRenderTarget(0);
				Class115.class125_0.GraphicsDevice.SetRenderTarget(0, null);
				Class115.class125_0.GraphicsDevice.Clear(Color.get_Black());
				Texture2D texture = Class733.renderTarget2D_1.GetTexture();
				Class115.spriteBatch_0.Begin(1, 0, 0);
				Class115.spriteBatch_0.Draw(texture, new Rectangle(0, 0, Class115.int_22, Class115.int_23 + Class115.int_25), new Rectangle?(new Rectangle(0, 0, Class115.int_22, Class115.int_23 + Class115.int_25)), Color.get_White());
				Class115.spriteBatch_0.End();
				EffectPass effectPass = Class733.effect_0.get_CurrentTechnique().get_Passes().get_Item(0);
				Class733.effect_0.Begin();
				if (Class341.class606_5)
				{
					Class733.effect_0.get_Parameters().get_Item("mag").SetValue(0.004f);
					Class733.effect_0.get_Parameters().get_Item("alpha").SetValue(0.15f);
					Class733.effect_0.get_Parameters().get_Item("hirange").SetValue(false);
					Class733.effect_0.get_Parameters().get_Item("redtint").SetValue(0);
					Class115.spriteBatch_0.Begin(1, 0, 0);
					effectPass.Begin();
					Class115.spriteBatch_0.Draw(texture, new Rectangle(0, 0, Class115.int_22, Class115.int_23 + Class115.int_25), new Rectangle?(new Rectangle(0, 0, Class115.int_22, Class115.int_23 + Class115.int_25)), Color.get_White());
					effectPass.End();
					Class115.spriteBatch_0.End();
				}
				if (Class733.bool_1)
				{
					Class733.effect_0.get_Parameters().get_Item("mag").SetValue(Class733.float_1);
					Class733.effect_0.get_Parameters().get_Item("alpha").SetValue(Class733.float_0);
					Class733.effect_0.get_Parameters().get_Item("redtint").SetValue(Class733.float_2);
					Class733.effect_0.get_Parameters().get_Item("hirange").SetValue(Class733.bool_2);
					Class115.spriteBatch_0.Begin(Class733.bool_0 ? 2 : 1, 0, 0);
					effectPass.Begin();
					Class115.spriteBatch_0.Draw(texture, new Rectangle(0, 0, Class115.int_22, Class115.int_23 + Class115.int_25), new Rectangle?(new Rectangle(0, 0, Class115.int_22, Class115.int_23 + Class115.int_25)), Class733.color_0);
					effectPass.End();
					Class115.spriteBatch_0.End();
				}
				Class733.effect_0.End();
			}
			catch
			{
				Class341.class606_4.Value = false;
				Class723.smethod_4("No shader support - disabling bloom effects.");
			}
		}
	}
}
