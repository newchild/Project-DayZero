using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using ns23;
using ns29;
using ns84;
using ns91;
using osu.Graphics.OpenGl;
using System;
using System.Collections.Generic;

namespace ns85
{
	// Token: 0x02000481 RID: 1153
	internal class Class582 : IDisposable, Interface16
	{
		// Token: 0x04001EB9 RID: 7865
		private EffectParameter effectParameter_0;

		// Token: 0x04001EBA RID: 7866
		private EffectParameter effectParameter_1;

		// Token: 0x04001EC0 RID: 7872
		private EffectParameter effectParameter_2;

		// Token: 0x04001EC1 RID: 7873
		private EffectParameter effectParameter_3;

		// Token: 0x04001EC6 RID: 7878
		private EffectParameter effectParameter_4;

		// Token: 0x04001EB6 RID: 7862
		private Effect effect_0;

		// Token: 0x04001EB5 RID: 7861
		private GraphicsDevice graphicsDevice_0;

		// Token: 0x04001EB7 RID: 7863
		private IndexBuffer indexBuffer_0;

		// Token: 0x04001EB8 RID: 7864
		private IndexBuffer indexBuffer_1;

		// Token: 0x04001EB4 RID: 7860
		private int int_0;

		// Token: 0x04001EBB RID: 7867
		private int int_1;

		// Token: 0x04001EBC RID: 7868
		private int int_2;

		// Token: 0x04001EBD RID: 7869
		private int int_3;

		// Token: 0x04001EBE RID: 7870
		private int int_4;

		// Token: 0x04001EBF RID: 7871
		private int int_5;

		// Token: 0x04001EC2 RID: 7874
		private VertexBuffer vertexBuffer_0;

		// Token: 0x04001EC3 RID: 7875
		private VertexBuffer vertexBuffer_1;

		// Token: 0x04001EC4 RID: 7876
		private VertexDeclaration vertexDeclaration_0;

		// Token: 0x04001EC5 RID: 7877
		private VertexDeclaration vertexDeclaration_1;

		// Token: 0x06002511 RID: 9489
		// RVA: 0x0001CE0D File Offset: 0x0001B00D
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06002512 RID: 9490
		// RVA: 0x000DFBDC File Offset: 0x000DDDDC
		protected virtual void Dispose(bool bool_0)
		{
			if (bool_0)
			{
				this.method_5(this.indexBuffer_0);
				this.method_5(this.indexBuffer_1);
				this.method_5(this.vertexBuffer_0);
				this.method_5(this.vertexBuffer_1);
				this.method_5(this.vertexDeclaration_0);
				this.method_5(this.vertexDeclaration_1);
			}
		}

		// Token: 0x0600250B RID: 9483
		// RVA: 0x000DF4A4 File Offset: 0x000DD6A4
		public void Draw(Class880 class880_0, float float_0, Color color_0)
		{
			this.Draw(new List<Class880>(1)
			{
				class880_0
			}, null, float_0, color_0);
		}

		// Token: 0x0600250C RID: 9484
		// RVA: 0x0001CDF6 File Offset: 0x0001AFF6
		public virtual void Draw(List<Class880> list_0, Class880 class880_0, float float_0, Color color_0)
		{
			this.Draw(list_0, float_0, color_0, 0f, "StandardNoGradient", true);
		}

		// Token: 0x0600250D RID: 9485
		// RVA: 0x000DF4CC File Offset: 0x000DD6CC
		internal void Draw(List<Class880> list_0, float float_0, Color color_0, float float_1, string string_0, bool bool_0)
		{
			if (Class115.bool_26)
			{
				if (Class115.int_0 < 2 && string_0.StartsWith("Standard"))
				{
					string_0 += "11";
				}
				if (string_0 == null)
				{
					this.effect_0.set_CurrentTechnique(this.effect_0.get_Techniques().get_Item(0));
				}
				else
				{
					EffectTechnique currentTechnique = this.effect_0.get_Techniques().get_Item(string_0);
					this.effect_0.set_CurrentTechnique(currentTechnique);
				}
				this.effect_0.Begin();
				EffectPass effectPass = this.effect_0.get_CurrentTechnique().get_Passes().get_Item(0);
				int num;
				int num2;
				if (bool_0)
				{
					this.graphicsDevice_0.set_VertexDeclaration(this.vertexDeclaration_0);
					this.graphicsDevice_0.get_Vertices().get_Item(0).SetSource(this.vertexBuffer_0, 0, this.int_0);
					this.graphicsDevice_0.set_Indices(this.indexBuffer_0);
					this.graphicsDevice_0.get_RenderState().set_CullMode(1);
					num = this.int_4;
					num2 = this.int_2;
				}
				else
				{
					this.graphicsDevice_0.set_VertexDeclaration(this.vertexDeclaration_1);
					this.graphicsDevice_0.get_Vertices().get_Item(0).SetSource(this.vertexBuffer_1, 0, this.int_0);
					this.graphicsDevice_0.set_Indices(this.indexBuffer_1);
					this.graphicsDevice_0.get_RenderState().set_CullMode(2);
					num = this.int_5;
					num2 = this.int_3;
				}
				effectPass.Begin();
				this.effectParameter_3.SetValue(float_1);
				Vector4 value;
				value..ctor((float)color_0.get_R() / 255f, (float)color_0.get_G() / 255f, (float)color_0.get_B() / 255f, (float)color_0.get_A() / 255f);
				this.effectParameter_1.SetValue(value);
				this.effectParameter_2.SetValue(float_0);
				Color color = color_0;
				foreach (Class880 current in list_0)
				{
					Matrix value2 = current.method_2() * Matrix.get_Identity() * Class297.matrix_0;
					this.effectParameter_4.SetValue(value2);
					Class881 class = current as Class881;
					if (class != null && class.color_0 != Color.get_White() && class.color_0 != color)
					{
						this.effectParameter_1.SetValue(new Vector4((float)class.color_0.get_R() / 255f, (float)class.color_0.get_G() / 255f, (float)class.color_0.get_B() / 255f, (float)class.color_0.get_A() / 255f));
						color = class.color_0;
					}
					this.effectParameter_0.SetValue(current.method_0());
					this.effect_0.CommitChanges();
					this.graphicsDevice_0.DrawIndexedPrimitives(4, 0, 0, num, 0, num2);
				}
				effectPass.End();
				this.effect_0.End();
				return;
			}
			BaseGLControl.smethod_2(false);
			BaseGLControl.smethod_4(color_0);
			bool flag = string_0 == "NoBlur";
			foreach (Class880 current2 in list_0)
			{
				Class881 class2 = current2 as Class881;
				Vector2 vector = Vector2.Normalize(current2.vector2_1 - current2.vector2_0);
				Vector2 vector2;
				vector2..ctor(float_0 * vector.Y, -float_0 * vector.X);
				if (class2 != null && class2.color_0 != Color.get_White())
				{
					color_0 = class2.color_0;
				}
				Gl.glBegin(7u);
				Vector2 vector3 = current2.vector2_0 + vector2;
				Vector2 vector4 = current2.vector2_0 - vector2;
				Vector2 vector5 = current2.vector2_1 - vector2;
				Vector2 vector6 = current2.vector2_1 + vector2;
				Gl.glVertex2f(vector3.X, vector3.Y);
				Gl.glVertex2f(vector6.X, vector6.Y);
				if (!flag)
				{
					BaseGLControl.smethod_4(new Color(color_0.get_R(), color_0.get_G(), color_0.get_B(), 128));
					Gl.glVertex2f(current2.vector2_1.X, current2.vector2_1.Y);
					Gl.glVertex2f(current2.vector2_0.X, current2.vector2_0.Y);
					Gl.glVertex2f(current2.vector2_0.X, current2.vector2_0.Y);
					Gl.glVertex2f(current2.vector2_1.X, current2.vector2_1.Y);
				}
				BaseGLControl.smethod_4(color_0);
				Gl.glVertex2f(vector5.X, vector5.Y);
				Gl.glVertex2f(vector4.X, vector4.Y);
				Gl.glEnd();
				if (bool_0)
				{
					this.method_3(current2.vector2_0.X, current2.vector2_0.Y, float_0, (float)((double)current2.method_1() + 7.8539816339744828), color_0, true);
					this.method_3(current2.vector2_1.X, current2.vector2_1.Y, float_0, (float)((double)current2.method_1() + 4.71238898038469), color_0, true);
				}
			}
		}

		// Token: 0x06002510 RID: 9488
		// RVA: 0x000DFBAC File Offset: 0x000DDDAC
		~Class582()
		{
			this.Dispose(false);
		}

		// Token: 0x06002508 RID: 9480
		// RVA: 0x000DEA94 File Offset: 0x000DCC94
		internal void method_0(GraphicsDevice graphicsDevice_1, ContentManager contentManager_0)
		{
			if (Class115.bool_26)
			{
				this.graphicsDevice_0 = graphicsDevice_1;
				this.effect_0 = contentManager_0.Load<Effect>("Line");
				this.effectParameter_4 = this.effect_0.get_Parameters().get_Item("worldViewProj");
				this.effectParameter_3 = this.effect_0.get_Parameters().get_Item("time");
				this.effectParameter_0 = this.effect_0.get_Parameters().get_Item("length");
				this.effectParameter_2 = this.effect_0.get_Parameters().get_Item("radius");
				this.effectParameter_1 = this.effect_0.get_Parameters().get_Item("lineColor");
				this.method_1();
			}
		}

		// Token: 0x06002509 RID: 9481
		// RVA: 0x000DEB50 File Offset: 0x000DCD50
		private void method_1()
		{
			this.int_4 = 40;
			this.int_2 = 34;
			this.int_1 = 3 * this.int_2;
			short[] array = new short[this.int_1];
			this.int_0 = VertexPositionNormalTexture.get_SizeInBytes();
			VertexPositionNormalTexture[] array2 = new VertexPositionNormalTexture[this.int_4];
			array2[0] = new VertexPositionNormalTexture(new Vector3(0f, -1f, 0f), new Vector3(1f, 0f, 0f), Vector2.get_Zero());
			array2[1] = new VertexPositionNormalTexture(new Vector3(0f, -1f, 0f), new Vector3(1f, 0f, 0f), new Vector2(0f, 1f));
			array2[2] = new VertexPositionNormalTexture(new Vector3(0f, 0f, 0f), new Vector3(0f, 0f, 0f), new Vector2(0f, 1f));
			array2[3] = new VertexPositionNormalTexture(new Vector3(0f, 0f, 0f), new Vector3(0f, 0f, 0f), Vector2.get_Zero());
			array2[4] = new VertexPositionNormalTexture(new Vector3(0f, 1f, 0f), new Vector3(1f, 0f, 0f), new Vector2(0f, 1f));
			array2[5] = new VertexPositionNormalTexture(new Vector3(0f, 1f, 0f), new Vector3(1f, 0f, 0f), Vector2.get_Zero());
			array[0] = 0;
			array[1] = 1;
			array[2] = 2;
			array[3] = 2;
			array[4] = 3;
			array[5] = 0;
			array[6] = 2;
			array[7] = 4;
			array[8] = 3;
			array[9] = 4;
			array[10] = 5;
			array[11] = 3;
			int num = 6;
			int num2 = 12;
			for (int i = 0; i < 17; i++)
			{
				float num3;
				float num4;
				float num5;
				if (i == 0)
				{
					num3 = 0f;
					num4 = 0f;
					num5 = 0f;
				}
				else
				{
					float num6 = (float)(i - 1) / 30f * 6.28319f + 1.5708f;
					num3 = (float)Math.Cos((double)num6);
					num4 = (float)Math.Sin((double)num6);
					num5 = 1f;
				}
				array2[num + i] = new VertexPositionNormalTexture(new Vector3(num3, num4, 0f), new Vector3(num5, 0f, 0f), new Vector2(1f, 0f));
			}
			int num7 = 0;
			for (int j = 0; j < 15; j++)
			{
				array[num2 + num7++] = (short)num;
				array[num2 + num7++] = (short)(num + j + 1);
				array[num2 + num7++] = (short)(num + j + 2);
			}
			num += 17;
			num2 += 45;
			for (int k = 0; k < 17; k++)
			{
				float num8;
				float num9;
				float num10;
				if (k == 0)
				{
					num8 = 0f;
					num9 = 0f;
					num10 = 0f;
				}
				else
				{
					float num11 = (float)(k - 1) / 30f * 6.28319f - 1.5708f;
					num8 = (float)Math.Cos((double)num11);
					num9 = (float)Math.Sin((double)num11);
					num10 = 1f;
				}
				array2[num + k] = new VertexPositionNormalTexture(new Vector3(num8, num9, 0f), new Vector3(num10, 0f, 0f), new Vector2(1f, 1f));
			}
			num7 = 0;
			for (int l = 0; l < 15; l++)
			{
				array[num2 + num7++] = (short)num;
				array[num2 + num7++] = (short)(num + l + 1);
				array[num2 + num7++] = (short)(num + l + 2);
			}
			this.vertexBuffer_0 = new VertexBuffer(this.graphicsDevice_0, this.int_4 * this.int_0, 0, 1);
			this.vertexBuffer_0.SetData<VertexPositionNormalTexture>(array2);
			this.vertexDeclaration_0 = new VertexDeclaration(this.graphicsDevice_0, VertexPositionNormalTexture.VertexElements);
			this.indexBuffer_0 = new IndexBuffer(this.graphicsDevice_0, this.int_1 * 2, 0, 1, 0);
			this.indexBuffer_0.SetData<short>(array);
			this.int_5 = 6;
			this.int_3 = 4;
			array = new short[this.int_1];
			this.int_0 = VertexPositionNormalTexture.get_SizeInBytes();
			array2 = new VertexPositionNormalTexture[this.int_4];
			array2[0] = new VertexPositionNormalTexture(new Vector3(0f, -1f, 0f), new Vector3(1f, 0f, 0f), Vector2.get_Zero());
			array2[1] = new VertexPositionNormalTexture(new Vector3(0f, -1f, 0f), new Vector3(1f, 0f, 0f), new Vector2(0f, 1f));
			array2[2] = new VertexPositionNormalTexture(new Vector3(0f, 0f, 0f), new Vector3(0f, 0f, 0f), new Vector2(0f, 1f));
			array2[3] = new VertexPositionNormalTexture(new Vector3(0f, 0f, 0f), new Vector3(0f, 0f, 0f), Vector2.get_Zero());
			array2[4] = new VertexPositionNormalTexture(new Vector3(0f, 1f, 0f), new Vector3(1f, 0f, 0f), new Vector2(0f, 1f));
			array2[5] = new VertexPositionNormalTexture(new Vector3(0f, 1f, 0f), new Vector3(1f, 0f, 0f), Vector2.get_Zero());
			array[0] = 0;
			array[1] = 1;
			array[2] = 2;
			array[3] = 2;
			array[4] = 3;
			array[5] = 0;
			array[6] = 2;
			array[7] = 4;
			array[8] = 3;
			array[9] = 4;
			array[10] = 5;
			array[11] = 3;
			this.vertexBuffer_1 = new VertexBuffer(this.graphicsDevice_0, this.int_4 * this.int_0, 0, 1);
			this.vertexBuffer_1.SetData<VertexPositionNormalTexture>(array2);
			this.vertexDeclaration_1 = new VertexDeclaration(this.graphicsDevice_0, VertexPositionNormalTexture.VertexElements);
			this.indexBuffer_1 = new IndexBuffer(this.graphicsDevice_0, this.int_1 * 2, 0, 1, 0);
			this.indexBuffer_1.SetData<short>(array);
		}

		// Token: 0x0600250A RID: 9482
		// RVA: 0x000DF21C File Offset: 0x000DD41C
		internal void method_2(Vector2 vector2_0, Vector2 vector2_1, Color color_0)
		{
			if (Class115.bool_26)
			{
				if (vector2_0.Y > vector2_1.Y)
				{
					Vector2 vector = vector2_0;
					vector2_0 = vector2_1;
					vector2_1 = vector;
				}
				this.effect_0.set_CurrentTechnique(this.effect_0.get_Techniques().get_Item("NoBlur"));
				this.effect_0.Begin();
				EffectPass effectPass = this.effect_0.get_CurrentTechnique().get_Passes().get_Item(0);
				this.graphicsDevice_0.set_VertexDeclaration(this.vertexDeclaration_1);
				this.graphicsDevice_0.get_Vertices().get_Item(0).SetSource(this.vertexBuffer_1, 0, this.int_0);
				this.graphicsDevice_0.set_Indices(this.indexBuffer_1);
				this.graphicsDevice_0.get_RenderState().set_CullMode(2);
				effectPass.Begin();
				this.effectParameter_3.SetValue(0);
				Vector4 value;
				value..ctor((float)color_0.get_R() / 255f, (float)color_0.get_G() / 255f, (float)color_0.get_B() / 255f, (float)color_0.get_A() / 255f);
				this.effectParameter_1.SetValue(value);
				float num = Math.Abs((vector2_1.Y - vector2_0.Y) / 2f);
				float num2 = vector2_0.Y + Math.Abs((vector2_1.Y - vector2_0.Y) / 2f);
				if (num != 0f)
				{
					this.effectParameter_2.SetValue(num);
				}
				Class880 class = new Class880(new Vector2(vector2_0.X, num2), new Vector2(vector2_1.X, num2));
				Matrix value2 = class.method_2() * Matrix.get_Identity() * Class297.matrix_0;
				this.effectParameter_4.SetValue(value2);
				this.effectParameter_0.SetValue(class.method_0());
				if (num == 0f)
				{
					this.effectParameter_2.SetValue(1);
				}
				this.effect_0.CommitChanges();
				this.graphicsDevice_0.DrawIndexedPrimitives(4, 0, 0, this.int_5, 0, this.int_3);
				effectPass.End();
				this.effect_0.End();
				return;
			}
			BaseGLControl.smethod_2(false);
			BaseGLControl.smethod_4(color_0);
			Gl.glBegin(7u);
			Gl.glVertex2f(vector2_0.X, vector2_1.Y);
			Gl.glVertex2f(vector2_1.X, vector2_1.Y);
			Gl.glVertex2f(vector2_1.X, vector2_0.Y);
			Gl.glVertex2f(vector2_0.X, vector2_0.Y);
			Gl.glEnd();
		}

		// Token: 0x0600250E RID: 9486
		// RVA: 0x000DFA64 File Offset: 0x000DDC64
		internal void method_3(float float_0, float float_1, float float_2, float float_3, Color color_0, bool bool_0)
		{
			Gl.glBegin(6u);
			BaseGLControl.smethod_4(new Color(color_0.get_R(), color_0.get_G(), color_0.get_B(), 128));
			Gl.glVertex2d((double)float_0, (double)float_1);
			if (!bool_0)
			{
				BaseGLControl.smethod_4(color_0);
			}
			float num = (float)(3.1415926535897931 + (double)float_3);
			for (float num2 = float_3; num2 <= num; num2 += 0.209439516f)
			{
				if (bool_0)
				{
					float num3 = (float)Math.Max(0.550000011920929, Math.Sqrt(Math.Abs(((double)(num2 - float_3) - 1.5707963267948966) / 1.5707963267948966)));
					BaseGLControl.smethod_4(new Color(color_0.get_R(), color_0.get_G(), color_0.get_B(), (byte)(num3 * (float)color_0.get_A())));
				}
				Gl.glVertex2d((double)float_0 + Math.Cos((double)num2) * (double)float_2, (double)float_1 + Math.Sin((double)num2) * (double)float_2);
			}
			Gl.glEnd();
		}

		// Token: 0x0600250F RID: 9487
		// RVA: 0x000DFB5C File Offset: 0x000DDD5C
		public void method_4(double double_0, double double_1, Color color_0)
		{
			this.method_2(new Vector2((float)(double_0 - 2.0), (float)(double_1 - 2.0)), new Vector2((float)(double_0 + 2.0), (float)(double_1 + 2.0)), color_0);
		}

		// Token: 0x06002513 RID: 9491
		// RVA: 0x0001CE1C File Offset: 0x0001B01C
		private void method_5(IDisposable idisposable_0)
		{
			if (idisposable_0 != null)
			{
				idisposable_0.Dispose();
			}
		}
	}
}
