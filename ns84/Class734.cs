using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns26;
using ns29;
using ns64;
using ns77;
using ns8;
using ns80;
using ns90;
using System;

namespace ns84
{
	// Token: 0x0200056C RID: 1388
	internal sealed class Class734 : IDisposable
	{
		// Token: 0x0200056D RID: 1389
		private struct Struct50
		{
			// Token: 0x0400251A RID: 9498
			internal const int int_0 = 28;

			// Token: 0x0400251D RID: 9501
			private Vector3 vector3_0;

			// Token: 0x0400251C RID: 9500
			private Vector4 vector4_0;

			// Token: 0x0400251B RID: 9499
			internal static readonly VertexElement[] vertexElement_0 = new VertexElement[]
			{
				new VertexElement(0, 0, 3, 0, 0, 0),
				new VertexElement(0, 0, 2, 0, 5, 0)
			};

			// Token: 0x06002CE9 RID: 11497
			// RVA: 0x0002204C File Offset: 0x0002024C
			internal Struct50(Vector4 vector4_1, Vector3 vector3_1)
			{
				this.vector4_0 = vector4_1;
				this.vector3_0 = vector3_1;
			}
		}

		// Token: 0x04002519 RID: 9497
		private bool bool_0;

		// Token: 0x04002517 RID: 9495
		private Class731 class731_0;

		// Token: 0x04002518 RID: 9496
		private Class731 class731_1;

		// Token: 0x04002513 RID: 9491
		private EffectParameter effectParameter_0;

		// Token: 0x04002514 RID: 9492
		private EffectParameter effectParameter_1;

		// Token: 0x04002512 RID: 9490
		private Effect effect_0;

		// Token: 0x04002515 RID: 9493
		private GraphicsDevice graphicsDevice_0;

		// Token: 0x04002516 RID: 9494
		private VertexBuffer vertexBuffer_0;

		// Token: 0x06002CE3 RID: 11491
		// RVA: 0x00021FE8 File Offset: 0x000201E8
		internal Class734()
		{
			Class115.smethod_53(new Delegate1(this.method_1));
			Class115.smethod_50(new Delegate1(this.method_0));
			this.Initialize();
		}

		// Token: 0x06002CE6 RID: 11494
		// RVA: 0x00122D90 File Offset: 0x00120F90
		public void Dispose()
		{
			if (this.effect_0 != null)
			{
				this.effect_0.Dispose();
			}
			if (this.vertexBuffer_0 != null)
			{
				this.vertexBuffer_0.Dispose();
			}
			if (this.class731_0 != null)
			{
				this.class731_0.Dispose();
			}
			if (this.class731_1 != null)
			{
				this.class731_1.Dispose();
			}
			Class115.smethod_54(new Delegate1(this.method_1));
			Class115.smethod_51(new Delegate1(this.method_0));
		}

		// Token: 0x06002CE8 RID: 11496
		// RVA: 0x00123154 File Offset: 0x00121354
		internal void Draw(float float_0, int int_0)
		{
			if (int_0 >= 500 && !this.bool_0)
			{
				this.effect_0 = Class115.contentManager_0.Load<Effect>("Fire");
				this.effect_0.set_CurrentTechnique(this.effect_0.get_Techniques().get_Item("Fire"));
				this.effect_0.get_Parameters().get_Item("fire_base_Tex").SetValue(Class885.Load("FireBase2", Enum112.flag_1).method_2());
				this.effect_0.get_Parameters().get_Item("fire_distortion_Tex").SetValue(Class885.Load("FireDistortion", Enum112.flag_1).method_2());
				this.effect_0.get_Parameters().get_Item("fire_opacity_Tex").SetValue(Class885.Load("FireOpacity", Enum112.flag_1).method_2());
				this.effectParameter_1 = this.effect_0.get_Parameters().get_Item("Fire_Effects_Fire_Single_Pass_Vertex_Shader_time_0_X");
				this.effectParameter_0 = this.effect_0.get_Parameters().get_Item("height");
				this.effect_0.CommitChanges();
				this.bool_0 = true;
			}
			else if (int_0 < 500 && this.bool_0)
			{
				this.effect_0 = Class115.contentManager_0.Load<Effect>("Fire");
				this.effect_0.set_CurrentTechnique(this.effect_0.get_Techniques().get_Item("Fire"));
				this.effect_0.get_Parameters().get_Item("fire_base_Tex").SetValue(Class885.Load("FireBase", Enum112.flag_1).method_2());
				this.effect_0.get_Parameters().get_Item("fire_distortion_Tex").SetValue(Class885.Load("FireDistortion", Enum112.flag_1).method_2());
				this.effect_0.get_Parameters().get_Item("fire_opacity_Tex").SetValue(Class885.Load("FireOpacity", Enum112.flag_1).method_2());
				this.effectParameter_1 = this.effect_0.get_Parameters().get_Item("Fire_Effects_Fire_Single_Pass_Vertex_Shader_time_0_X");
				this.effectParameter_0 = this.effect_0.get_Parameters().get_Item("height");
				this.effect_0.CommitChanges();
				this.effect_0.get_Parameters().get_Item("fire_base_Tex").SetValue(this.class731_0.method_2());
				this.bool_0 = false;
			}
			try
			{
				this.effectParameter_1.SetValue((float)Class331.int_7 / 1000f);
				this.effectParameter_0.SetValue(float_0);
				this.effect_0.CommitChanges();
				this.effect_0.Begin();
				foreach (EffectPass current in this.effect_0.get_CurrentTechnique().get_Passes())
				{
					current.Begin();
					this.graphicsDevice_0.set_VertexDeclaration(new VertexDeclaration(this.graphicsDevice_0, Class734.Struct50.vertexElement_0));
					this.graphicsDevice_0.get_Vertices().get_Item(0).SetSource(this.vertexBuffer_0, 0, 28);
					this.graphicsDevice_0.DrawPrimitives(4, 0, 2);
					current.End();
				}
				this.effect_0.End();
			}
			catch (Exception)
			{
				Class341.class606_13.Value = false;
				this.Dispose();
				Class723.smethod_4("Rendering of fire effect failed - automatically disabling.");
			}
		}

		// Token: 0x06002CE7 RID: 11495
		// RVA: 0x00122E18 File Offset: 0x00121018
		internal bool Initialize()
		{
			if (!Class115.bool_27)
			{
				bool result;
				try
				{
					this.graphicsDevice_0 = Class115.class125_0.GraphicsDevice;
					this.class731_0 = Class885.Load("FireBase", Enum112.flag_1);
					this.class731_1 = Class885.Load("FireBase2", Enum112.flag_1);
					this.effect_0 = Class115.contentManager_0.Load<Effect>("Fire").Clone(this.graphicsDevice_0);
					this.effect_0.set_CurrentTechnique(this.effect_0.get_Techniques().get_Item("Fire"));
					this.class731_0 = Class885.Load("FireBase", Enum112.flag_1);
					this.class731_1 = Class885.Load("FireBase2", Enum112.flag_1);
					this.effect_0.get_Parameters().get_Item("fire_base_Tex").SetValue(Class885.Load("FireBase", Enum112.flag_1).method_2());
					this.effect_0.get_Parameters().get_Item("fire_distortion_Tex").SetValue(Class885.Load("FireDistortion", Enum112.flag_1).method_2());
					this.effect_0.get_Parameters().get_Item("fire_opacity_Tex").SetValue(Class885.Load("FireOpacity", Enum112.flag_1).method_2());
					this.effectParameter_1 = this.effect_0.get_Parameters().get_Item("Fire_Effects_Fire_Single_Pass_Vertex_Shader_time_0_X");
					this.effectParameter_0 = this.effect_0.get_Parameters().get_Item("height");
					this.effect_0.CommitChanges();
					float num = Math.Max(0f, ((float)Class341.class607_1 - 5f) / 10f);
					Class734.Struct50[] data = new Class734.Struct50[]
					{
						new Class734.Struct50(new Vector4(-1f, -1f, 0f, 1f), Vector3.get_Zero()),
						new Class734.Struct50(new Vector4(1f, -1f, 0f, 1f), Vector3.get_Zero()),
						new Class734.Struct50(new Vector4(1f, num, 1f, 1f), Vector3.get_Zero()),
						new Class734.Struct50(new Vector4(-1f, -1f, 0f, 1f), Vector3.get_Zero()),
						new Class734.Struct50(new Vector4(-1f, num, 0f, 1f), Vector3.get_Zero()),
						new Class734.Struct50(new Vector4(1f, num, 0f, 1f), Vector3.get_Zero())
					};
					this.vertexBuffer_0 = new VertexBuffer(Class115.class125_0.GraphicsDevice, 168, 8);
					this.vertexBuffer_0.SetData<Class734.Struct50>(data);
					return true;
				}
				catch (Exception)
				{
					if (!Class341.class606_13)
					{
						return true;
					}
					Class341.class606_13.Value = false;
					this.Dispose();
					Class723.smethod_4("Rendering of fire effect failed - automatically disabling.");
					result = false;
				}
				return result;
			}
			if (Class341.class606_13)
			{
				Class341.class606_13.Value = false;
				Class723.smethod_4("Combo fire is not supported when running in OpenGl mode!");
				return false;
			}
			return false;
		}

		// Token: 0x06002CE4 RID: 11492
		// RVA: 0x00022019 File Offset: 0x00020219
		private void method_0(bool bool_1)
		{
			this.Dispose();
			Class115.smethod_53(new Delegate1(this.method_1));
			Class115.smethod_50(new Delegate1(this.method_0));
		}

		// Token: 0x06002CE5 RID: 11493
		// RVA: 0x00022043 File Offset: 0x00020243
		private void method_1(bool bool_1)
		{
			this.Initialize();
		}
	}
}
