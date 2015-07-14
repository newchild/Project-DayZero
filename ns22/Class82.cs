using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns29;
using ns8;
using ns9;
using ns91;
using osu.Graphics.OpenGl;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns22
{
	// Token: 0x020003B9 RID: 953
	internal sealed class Class82 : Class55
	{
		// Token: 0x04001797 RID: 6039
		private BasicEffect basicEffect_0;

		// Token: 0x04001793 RID: 6035
		internal Color color_0;

		// Token: 0x04001792 RID: 6034
		internal float float_0 = 1f;

		// Token: 0x04001794 RID: 6036
		internal float float_1 = 10f;

		// Token: 0x04001795 RID: 6037
		internal float float_2;

		// Token: 0x04001796 RID: 6038
		internal float float_3;

		// Token: 0x04001798 RID: 6040
		private List<VertexPositionColor> list_0;

		// Token: 0x04001791 RID: 6033
		internal Vector2 vector2_0;

		// Token: 0x06001DB7 RID: 7607
		// RVA: 0x0001873D File Offset: 0x0001693D
		public Class82() : base(Class115.class114_0)
		{
			this.Initialize();
		}

		// Token: 0x06001DBB RID: 7611
		// RVA: 0x00018780 File Offset: 0x00016980
		protected override void Dispose(bool bool_2)
		{
			if (this.basicEffect_0 != null)
			{
				this.basicEffect_0.Dispose();
			}
			Class115.smethod_54(new Delegate1(this.method_3));
			Class115.smethod_51(new Delegate1(this.method_2));
		}

		// Token: 0x06001DB9 RID: 7609
		// RVA: 0x000A1CC4 File Offset: 0x0009FEC4
		public override void Draw()
		{
			if (this.float_0 > 0f)
			{
				if (this.float_3 != 0f)
				{
					try
					{
						float num = (float)((double)this.float_3 * 6.2831853071795862 + (double)this.method_1());
						float num2 = this.float_1 * Class115.float_4;
						Vector2 vector = this.vector2_0 * Class115.float_4 + new Vector2(0f, (float)Class115.int_25);
						float num3;
						float num4;
						if (num < this.method_1())
						{
							num3 = num;
							num4 = this.method_1();
						}
						else
						{
							num3 = this.method_1();
							num4 = num;
						}
						this.list_0 = new List<VertexPositionColor>();
						this.list_0.Add(new VertexPositionColor(new Vector3(vector.X, vector.Y, 0f), this.color_0));
						for (float num5 = num3; num5 < num4; num5 += 0.157079637f)
						{
							this.list_0.Add(new VertexPositionColor(new Vector3((float)((double)vector.X + Math.Cos((double)num5) * (double)num2), (float)((double)vector.Y + Math.Sin((double)num5) * (double)num2), 0f), this.color_0));
						}
						this.list_0.Add(new VertexPositionColor(new Vector3((float)((double)vector.X + Math.Cos((double)num4) * (double)num2), (float)((double)vector.Y + Math.Sin((double)num4) * (double)num2), 0f), this.color_0));
						if (this.list_0.Count >= 3)
						{
							if (Class115.bool_26)
							{
								short[] array = new short[this.list_0.Count];
								short num6 = 0;
								while ((int)num6 < this.list_0.Count)
								{
									array[(int)num6] = num6;
									num6 += 1;
								}
								this.basicEffect_0.Begin();
								foreach (EffectPass current in this.basicEffect_0.get_CurrentTechnique().get_Passes())
								{
									current.Begin();
									Class115.class125_0.GraphicsDevice.DrawUserIndexedPrimitives<VertexPositionColor>(6, this.list_0.ToArray(), 0, this.list_0.Count, array, 0, this.list_0.Count - 2);
									current.End();
								}
								this.basicEffect_0.End();
							}
							else
							{
								BaseGLControl.smethod_2(false);
								Gl.glBegin(6u);
								BaseGLControl.smethod_4(this.color_0);
								foreach (VertexPositionColor current2 in this.list_0)
								{
									Gl.glVertex2d((double)current2.Position.X, (double)current2.Position.Y);
								}
								Gl.glEnd();
							}
						}
					}
					catch (InvalidOperationException)
					{
					}
					return;
				}
			}
		}

		// Token: 0x06001DBA RID: 7610
		// RVA: 0x000A1FE8 File Offset: 0x000A01E8
		public override void Initialize()
		{
			VoidDelegate voidDelegate = null;
			base.Initialize();
			if (Class115.bool_26)
			{
				if (this.basicEffect_0 == null)
				{
					Class115.smethod_53(new Delegate1(this.method_3));
					Class115.smethod_50(new Delegate1(this.method_2));
					if (voidDelegate == null)
					{
						voidDelegate = new VoidDelegate(this.method_4);
					}
					Class115.smethod_18(voidDelegate);
				}
				else if (!this.basicEffect_0.get_IsDisposed())
				{
					this.basicEffect_0.Dispose();
				}
				this.basicEffect_0 = new BasicEffect(Class115.class125_0.GraphicsDevice, null);
				this.basicEffect_0.set_VertexColorEnabled(true);
				this.basicEffect_0.set_World(Matrix.CreateTranslation(0f, 0f, 0f));
				this.basicEffect_0.set_View(Matrix.CreateLookAt(new Vector3(0f, 0f, 1f), Vector3.get_Zero(), Vector3.get_Up()));
				this.basicEffect_0.set_Projection(Matrix.CreateOrthographicOffCenter(0f, (float)Class115.class125_0.GraphicsDevice.get_Viewport().get_Width(), (float)Class115.class125_0.GraphicsDevice.get_Viewport().get_Height(), 0f, 1f, 1000f));
			}
		}

		// Token: 0x06001DB8 RID: 7608
		// RVA: 0x00018766 File Offset: 0x00016966
		private float method_1()
		{
			return (float)((double)(this.float_2 - 0.5f) * 3.1415926535897931);
		}

		// Token: 0x06001DBC RID: 7612
		// RVA: 0x000187BD File Offset: 0x000169BD
		private void method_2(bool bool_2)
		{
			if (!bool_2)
			{
				return;
			}
			if (this.basicEffect_0 != null)
			{
				this.basicEffect_0.Dispose();
			}
		}

		// Token: 0x06001DBD RID: 7613
		// RVA: 0x000187DC File Offset: 0x000169DC
		private void method_3(bool bool_2)
		{
			if (!bool_2)
			{
				return;
			}
			this.Initialize();
		}

		// Token: 0x06001DBE RID: 7614
		// RVA: 0x000187E8 File Offset: 0x000169E8
		[CompilerGenerated]
		private void method_4()
		{
			this.Initialize();
		}
	}
}
