using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using ns29;
using ns85;
using System;
using System.Collections.Generic;

namespace ns84
{
	// Token: 0x02000483 RID: 1155
	internal abstract class Class585 : IDisposable, Interface16, Interface17
	{
		// Token: 0x04001ECD RID: 7885
		private BasicEffect basicEffect_0;

		// Token: 0x04001EDC RID: 7900
		private bool bool_0;

		// Token: 0x04001EDD RID: 7901
		private bool bool_1;

		// Token: 0x04001EDE RID: 7902
		private bool bool_2;

		// Token: 0x04001EE0 RID: 7904
		private Color color_0 = Color.get_Gray();

		// Token: 0x04001EE1 RID: 7905
		private Color color_1 = Color.get_Gray();

		// Token: 0x04001EE2 RID: 7906
		private Color color_2 = Color.get_White();

		// Token: 0x04001EE3 RID: 7907
		private float float_0 = 64f;

		// Token: 0x04001ECE RID: 7886
		private IndexBuffer indexBuffer_0;

		// Token: 0x04001ECF RID: 7887
		private IndexBuffer indexBuffer_1;

		// Token: 0x04001ECC RID: 7884
		private int int_0;

		// Token: 0x04001ED0 RID: 7888
		private int int_1;

		// Token: 0x04001ED1 RID: 7889
		private int int_2;

		// Token: 0x04001ED2 RID: 7890
		private int int_3;

		// Token: 0x04001ED3 RID: 7891
		private int int_4;

		// Token: 0x04001ED4 RID: 7892
		private int int_5;

		// Token: 0x04001ED5 RID: 7893
		private int int_6;

		// Token: 0x04001EDF RID: 7903
		private List<Color> list_0 = new List<Color>();

		// Token: 0x04001ED8 RID: 7896
		protected Texture2D[] texture2D_0;

		// Token: 0x04001ED9 RID: 7897
		protected Texture2D texture2D_1;

		// Token: 0x04001EDA RID: 7898
		protected Texture2D texture2D_2;

		// Token: 0x04001ED6 RID: 7894
		private VertexBuffer vertexBuffer_0;

		// Token: 0x04001ED7 RID: 7895
		private VertexDeclaration vertexDeclaration_0;

		// Token: 0x04001EDB RID: 7899
		private VertexPositionNormalTexture[] vertexPositionNormalTexture_0;

		// Token: 0x0600253A RID: 9530
		// RVA: 0x0001CF91 File Offset: 0x0001B191
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x0600253B RID: 9531
		// RVA: 0x000E0A74 File Offset: 0x000DEC74
		protected virtual void Dispose(bool bool_3)
		{
			if (bool_3)
			{
				this.method_10(this.basicEffect_0);
				this.method_10(this.indexBuffer_0);
				this.method_10(this.indexBuffer_1);
				this.method_10(this.vertexBuffer_0);
				this.method_10(this.vertexDeclaration_0);
				if (this.texture2D_0 == null)
				{
					return;
				}
				this.bool_2 = true;
				Texture2D[] array = this.texture2D_0;
				for (int i = 0; i < array.Length; i++)
				{
					Texture2D idisposable_ = array[i];
					this.method_10(idisposable_);
				}
				this.method_10(this.texture2D_1);
				this.method_10(this.texture2D_2);
				this.bool_2 = false;
			}
		}

		// Token: 0x06002530 RID: 9520
		// RVA: 0x000E0470 File Offset: 0x000DE670
		public void Draw(Class880 class880_0, float float_1, Color color_3)
		{
			this.Draw(new List<Class880>(1)
			{
				class880_0
			}, null, float_1, color_3);
		}

		// Token: 0x06002531 RID: 9521
		// RVA: 0x0001CF30 File Offset: 0x0001B130
		public void Draw(List<Class880> list_1, Class880 class880_0, float float_1, Color color_3)
		{
			this.Draw(list_1, class880_0, float_1, color_3, this.color_2);
		}

		// Token: 0x06002533 RID: 9523
		// RVA: 0x000E04C0 File Offset: 0x000DE6C0
		public void Draw(List<Class880> list_1, Class880 class880_0, float float_1, int int_7)
		{
			switch (int_7)
			{
			case -2:
				this.method_6(list_1, float_1, this.texture2D_2, class880_0);
				return;
			case -1:
				this.method_6(list_1, float_1, this.texture2D_1, class880_0);
				return;
			default:
				if (int_7 < this.texture2D_0.Length && int_7 >= 0)
				{
					this.method_6(list_1, float_1, this.texture2D_0[int_7], class880_0);
					return;
				}
				this.method_6(list_1, float_1, this.texture2D_1, class880_0);
				return;
			}
		}

		// Token: 0x06002532 RID: 9522
		// RVA: 0x000E0498 File Offset: 0x000DE698
		public void Draw(List<Class880> list_1, Class880 class880_0, float float_1, Color color_3, Color color_4)
		{
			Texture2D texture2D = this.vmethod_3(color_3, color_4);
			this.method_6(list_1, float_1, texture2D, class880_0);
			texture2D.Dispose();
		}

		// Token: 0x06002534 RID: 9524
		// RVA: 0x0001CF43 File Offset: 0x0001B143
		public void Draw(List<Class880> list_1, Class880 class880_0, float float_1, int int_7, Color color_3)
		{
			if (int_7 >= this.list_0.Count)
			{
				this.Draw(list_1, class880_0, float_1, Color.get_Gray(), color_3);
				return;
			}
			this.Draw(list_1, class880_0, float_1, this.list_0[int_7], color_3);
		}

		// Token: 0x06002539 RID: 9529
		// RVA: 0x000E0A44 File Offset: 0x000DEC44
		~Class585()
		{
			this.Dispose(false);
		}

		// Token: 0x06002523 RID: 9507
		// RVA: 0x0001CEB8 File Offset: 0x0001B0B8
		public Color imethod_0()
		{
			return this.color_0;
		}

		// Token: 0x06002524 RID: 9508
		// RVA: 0x0001CEC0 File Offset: 0x0001B0C0
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

		// Token: 0x06002525 RID: 9509
		// RVA: 0x0001CEE6 File Offset: 0x0001B0E6
		public Color imethod_2()
		{
			return this.color_1;
		}

		// Token: 0x06002528 RID: 9512
		// RVA: 0x000DFE7C File Offset: 0x000DE07C
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

		// Token: 0x06002521 RID: 9505
		// RVA: 0x000DFD04 File Offset: 0x000DDF04
		internal void Initialize(GraphicsDevice graphicsDevice_0, ContentManager contentManager_0)
		{
			if (!(graphicsDevice_0 == null) && contentManager_0 != null)
			{
				this.basicEffect_0 = new BasicEffect(graphicsDevice_0, null);
				if (!this.bool_0)
				{
					this.int_0 = VertexPositionNormalTexture.get_SizeInBytes();
					this.vertexDeclaration_0 = new VertexDeclaration(graphicsDevice_0, VertexPositionNormalTexture.VertexElements);
					this.int_5 = 6;
					this.int_3 = 4;
					this.int_1 = 6;
					this.int_6 = 26;
					this.int_4 = 24;
					this.int_2 = 72;
					this.vertexPositionNormalTexture_0 = new VertexPositionNormalTexture[this.int_5 + this.int_6];
					this.method_4();
					this.method_5();
					this.vertexBuffer_0 = new VertexBuffer(graphicsDevice_0, (this.int_5 + this.int_6) * this.int_0, 0, 1);
					this.vertexBuffer_0.SetData<VertexPositionNormalTexture>(this.vertexPositionNormalTexture_0);
					this.bool_0 = true;
				}
				if (!this.bool_1)
				{
					this.method_3();
					this.bool_1 = true;
				}
				return;
			}
		}

		// Token: 0x06002529 RID: 9513
		// RVA: 0x000DFEF4 File Offset: 0x000DE0F4
		private void method_0()
		{
			int count = this.list_0.Count;
			if (this.texture2D_0 != null)
			{
				this.bool_2 = true;
				Texture2D[] array = this.texture2D_0;
				for (int i = 0; i < array.Length; i++)
				{
					Texture2D idisposable_ = array[i];
					this.method_10(idisposable_);
				}
				this.bool_2 = false;
			}
			if (count == 0)
			{
				this.texture2D_0 = new Texture2D[1];
				this.texture2D_0[0] = this.vmethod_3(Color.get_TransparentBlack(), this.color_2);
				return;
			}
			this.texture2D_0 = new Texture2D[count];
			for (int j = 0; j < count; j++)
			{
				this.texture2D_0[j] = this.vmethod_3(this.list_0[j], this.color_2);
			}
		}

		// Token: 0x0600252A RID: 9514
		// RVA: 0x000DFFAC File Offset: 0x000DE1AC
		private void method_1()
		{
			if (this.texture2D_2 != null)
			{
				this.bool_2 = true;
				this.method_10(this.texture2D_2);
				this.bool_2 = false;
			}
			this.texture2D_2 = this.vmethod_3(this.color_0, this.color_2);
		}

		// Token: 0x0600253C RID: 9532
		// RVA: 0x0001CE1C File Offset: 0x0001B01C
		private void method_10(IDisposable idisposable_0)
		{
			if (idisposable_0 != null)
			{
				idisposable_0.Dispose();
			}
		}

		// Token: 0x0600252B RID: 9515
		// RVA: 0x000DFFFC File Offset: 0x000DE1FC
		private void method_2()
		{
			if (this.texture2D_1 != null)
			{
				this.bool_2 = true;
				this.method_10(this.texture2D_1);
				this.bool_2 = false;
			}
			this.texture2D_1 = this.vmethod_3(this.color_1, this.color_2);
		}

		// Token: 0x0600252C RID: 9516
		// RVA: 0x0001CF1C File Offset: 0x0001B11C
		private void method_3()
		{
			this.method_0();
			this.method_1();
			this.method_2();
		}

		// Token: 0x0600252E RID: 9518
		// RVA: 0x000E004C File Offset: 0x000DE24C
		private void method_4()
		{
			short[] array = new short[this.int_1];
			this.vertexPositionNormalTexture_0[0] = new VertexPositionNormalTexture(new Vector3(-0.0003f, -1f, 0f), new Vector3(0f, 0f, 1f), new Vector2(0f, 0f));
			this.vertexPositionNormalTexture_0[1] = new VertexPositionNormalTexture(new Vector3(1.0003f, -1f, 0f), new Vector3(0f, 0f, -1f), new Vector2(0f, 0f));
			this.vertexPositionNormalTexture_0[2] = new VertexPositionNormalTexture(new Vector3(-0.0003f, 0.0001f, 1f), new Vector3(0f, 0f, 1f), new Vector2(1f, 0f));
			this.vertexPositionNormalTexture_0[3] = new VertexPositionNormalTexture(new Vector3(1.0003f, 0.0001f, 1f), new Vector3(0f, 0f, -1f), new Vector2(1f, 0f));
			this.vertexPositionNormalTexture_0[4] = new VertexPositionNormalTexture(new Vector3(-0.0003f, 1f, 0f), new Vector3(0f, 0f, 1f), new Vector2(0f, 0f));
			this.vertexPositionNormalTexture_0[5] = new VertexPositionNormalTexture(new Vector3(1.0003f, 1f, 0f), new Vector3(0f, 0f, -1f), new Vector2(0f, 0f));
			array[0] = 0;
			array[1] = 1;
			array[2] = 2;
			array[3] = 3;
			array[4] = 4;
			array[5] = 5;
			this.indexBuffer_0 = new IndexBuffer(this.method_8(), this.int_1 * 2, 0, 1, 0);
			this.indexBuffer_0.SetData<short>(array);
		}

		// Token: 0x0600252F RID: 9519
		// RVA: 0x000E0274 File Offset: 0x000DE474
		private void method_5()
		{
			short[] array = new short[this.int_2];
			this.vertexPositionNormalTexture_0[this.int_5] = new VertexPositionNormalTexture(new Vector3(0f, 0f, 1f), new Vector3(0f, 0f, 1f), new Vector2(1f, 0f));
			float num = (float)0.13089958826700845;
			this.vertexPositionNormalTexture_0[this.int_5 + 1] = new VertexPositionNormalTexture(new Vector3(0f, -1f, 0f), new Vector3(0f, 0f, 1f), new Vector2(0f, 0f));
			for (int i = 1; i < 24; i++)
			{
				float num2 = (float)i * num;
				this.vertexPositionNormalTexture_0[this.int_5 + i + 1] = new VertexPositionNormalTexture(new Vector3((float)Math.Sin((double)num2), -(float)Math.Cos((double)num2), 0f), new Vector3(0f, 0f, 1f), new Vector2(0f, 0f));
			}
			this.vertexPositionNormalTexture_0[this.int_5 + 24] = new VertexPositionNormalTexture(new Vector3(0f, 1f, 0f), new Vector3(0f, 0f, 1f), new Vector2(0f, 0f));
			for (int j = 0; j < 24; j++)
			{
				array[3 * j] = (short)this.int_5;
				array[3 * j + 1] = (short)(this.int_5 + j + 1);
				array[3 * j + 2] = (short)(this.int_5 + j + 2);
			}
			this.indexBuffer_1 = new IndexBuffer(this.method_8(), this.int_2 * 2, 0, 1, 0);
			this.indexBuffer_1.SetData<short>(array);
		}

		// Token: 0x06002535 RID: 9525
		// RVA: 0x000E0534 File Offset: 0x000DE734
		private void method_6(List<Class880> list_1, float float_1, Texture2D texture2D_3, Class880 class880_0)
		{
			if (list_1.Count == 0)
			{
				return;
			}
			this.method_8().set_VertexDeclaration(this.vertexDeclaration_0);
			this.method_8().get_Vertices().get_Item(0).SetSource(this.vertexBuffer_0, 0, this.int_0);
			this.method_8().get_RenderState().set_CullMode(1);
			this.method_8().get_RenderState().set_AlphaBlendEnable(false);
			this.method_8().get_RenderState().set_DepthBufferEnable(true);
			this.method_8().get_RenderState().set_DepthBufferWriteEnable(true);
			this.method_8().get_RenderState().set_DepthBufferFunction(4);
			this.basicEffect_0.set_Texture(texture2D_3);
			this.basicEffect_0.set_TextureEnabled(true);
			this.basicEffect_0.set_VertexColorEnabled(false);
			this.method_8().get_SamplerStates().get_Item(0).set_AddressU(3);
			this.method_8().get_SamplerStates().get_Item(0).set_AddressV(3);
			this.basicEffect_0.set_Projection(Matrix.CreateOrthographicOffCenter(0f, (float)Class115.int_22, (float)(Class115.int_23 + Class115.int_25), 0f, -1f, 1.5f));
			this.basicEffect_0.set_View(Matrix.get_Identity());
			int count = list_1.Count;
			for (int i = 1; i < count; i++)
			{
				this.method_7(class880_0, list_1[i - 1], list_1[i], float_1);
				class880_0 = list_1[i - 1];
			}
			this.method_7(class880_0, list_1[count - 1], null, float_1);
		}

		// Token: 0x06002536 RID: 9526
		// RVA: 0x000E06B8 File Offset: 0x000DE8B8
		private void method_7(Class880 class880_0, Class880 class880_1, Class880 class880_2, float float_1)
		{
			EffectPass effectPass = this.basicEffect_0.get_CurrentTechnique().get_Passes().get_Item(0);
			this.method_8().set_Indices(this.indexBuffer_0);
			this.basicEffect_0.set_World(new Matrix(class880_1.method_0(), 0f, 0f, 0f, 0f, float_1, 0f, 0f, 0f, 0f, 1f, 0f, 0f, 0f, 0f, 1f) * class880_1.method_2());
			this.basicEffect_0.Begin();
			effectPass.Begin();
			this.method_8().DrawIndexedPrimitives(5, 0, 0, this.int_5, 0, this.int_3);
			effectPass.End();
			this.basicEffect_0.End();
			bool flag;
			int num;
			if (class880_2 == null)
			{
				flag = false;
				num = this.int_4;
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
			num = Math.Min(num, this.int_4);
			this.method_8().set_Indices(this.indexBuffer_1);
			if (flag)
			{
				this.basicEffect_0.set_World(new Matrix(float_1, 0f, 0f, 0f, 0f, -float_1, 0f, 0f, 0f, 0f, 1f, 0f, 0f, 0f, 0f, 1f) * class880_1.method_3());
			}
			else
			{
				this.basicEffect_0.set_World(new Matrix(float_1, 0f, 0f, 0f, 0f, float_1, 0f, 0f, 0f, 0f, 1f, 0f, 0f, 0f, 0f, 1f) * class880_1.method_3());
			}
			this.basicEffect_0.Begin();
			effectPass.Begin();
			if (num > 0)
			{
				this.method_8().DrawIndexedPrimitives(4, 0, 0, this.int_5 + this.int_6, 0, num);
			}
			effectPass.End();
			this.basicEffect_0.End();
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
				this.basicEffect_0.set_World(new Matrix(-float_1, 0f, 0f, 0f, 0f, -float_1, 0f, 0f, 0f, 0f, 1f, 0f, 0f, 0f, 0f, 1f) * class880_1.method_2());
				this.basicEffect_0.Begin();
				effectPass.Begin();
				this.method_8().DrawIndexedPrimitives(4, 0, 0, this.int_5 + this.int_6, 0, this.int_4);
				effectPass.End();
				this.basicEffect_0.End();
			}
		}

		// Token: 0x06002537 RID: 9527
		// RVA: 0x0001CF7D File Offset: 0x0001B17D
		protected GraphicsDevice method_8()
		{
			return Class115.class125_0.GraphicsDevice;
		}

		// Token: 0x06002538 RID: 9528
		// RVA: 0x0001CF89 File Offset: 0x0001B189
		protected BasicEffect method_9()
		{
			return this.basicEffect_0;
		}

		// Token: 0x06002522 RID: 9506
		// RVA: 0x000DFDF8 File Offset: 0x000DDFF8
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

		// Token: 0x06002526 RID: 9510
		// RVA: 0x0001CEEE File Offset: 0x0001B0EE
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

		// Token: 0x06002527 RID: 9511
		// RVA: 0x0001CF14 File Offset: 0x0001B114
		public float vmethod_2()
		{
			return this.float_0;
		}

		// Token: 0x0600252D RID: 9517
		protected abstract Texture2D vmethod_3(Color color_3, Color color_4);
	}
}
