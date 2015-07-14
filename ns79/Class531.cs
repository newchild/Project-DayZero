using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns14;
using ns29;
using ns64;
using ns77;
using ns80;
using osu.Graphics.Primitives;
using osu.Graphics.Sprites;
using osu_common;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns79
{
	// Token: 0x0200045A RID: 1114
	internal class Class531 : Class530
	{
		// Token: 0x0200045B RID: 1115
		[CompilerGenerated]
		private sealed class Class554
		{
			// Token: 0x04001C3E RID: 7230
			public Class746 class746_0;

			// Token: 0x06002436 RID: 9270
			// RVA: 0x0001C639 File Offset: 0x0001A839
			public bool method_0(Class746 class746_1)
			{
				return class746_1.transformationType_0 == this.class746_0.transformationType_0;
			}
		}

		// Token: 0x04001C26 RID: 7206
		internal bool bool_10;

		// Token: 0x04001C27 RID: 7207
		internal bool bool_11;

		// Token: 0x04001C2D RID: 7213
		internal bool bool_12;

		// Token: 0x04001C34 RID: 7220
		internal bool bool_13 = true;

		// Token: 0x04001C35 RID: 7221
		[CompilerGenerated]
		private bool bool_14;

		// Token: 0x04001C10 RID: 7184
		internal bool bool_7;

		// Token: 0x04001C13 RID: 7187
		private bool bool_8;

		// Token: 0x04001C14 RID: 7188
		internal bool bool_9;

		// Token: 0x04001C21 RID: 7201
		internal Class731 class731_0;

		// Token: 0x04001C1C RID: 7196
		internal Class746 class746_1;

		// Token: 0x04001C11 RID: 7185
		internal Color color_1;

		// Token: 0x04001C1A RID: 7194
		internal Enum115 enum115_0;

		// Token: 0x04001C2B RID: 7211
		private EventHandler eventHandler_1;

		// Token: 0x04001C2C RID: 7212
		private EventHandler eventHandler_2;

		// Token: 0x04001C2E RID: 7214
		private EventHandler eventHandler_3;

		// Token: 0x04001C1F RID: 7199
		internal float float_4;

		// Token: 0x04001C28 RID: 7208
		internal float float_5;

		// Token: 0x04001C31 RID: 7217
		protected float float_6;

		// Token: 0x04001C15 RID: 7189
		internal int int_1;

		// Token: 0x04001C16 RID: 7190
		internal int int_2;

		// Token: 0x04001C17 RID: 7191
		internal int int_3;

		// Token: 0x04001C18 RID: 7192
		internal int int_4;

		// Token: 0x04001C1B RID: 7195
		internal int int_5;

		// Token: 0x04001C29 RID: 7209
		internal int int_6;

		// Token: 0x04001C1D RID: 7197
		internal List<Class746> list_1;

		// Token: 0x04001C1E RID: 7198
		internal List<Class746> list_2;

		// Token: 0x04001C19 RID: 7193
		internal bool? nullable_2;

		// Token: 0x04001C23 RID: 7203
		internal Origins origins_0;

		// Token: 0x04001C36 RID: 7222
		[CompilerGenerated]
		private static Predicate<Class746> predicate_14;

		// Token: 0x04001C37 RID: 7223
		[CompilerGenerated]
		private static Predicate<Class746> predicate_15;

		// Token: 0x04001C38 RID: 7224
		[CompilerGenerated]
		private static Predicate<Class746> predicate_16;

		// Token: 0x04001C39 RID: 7225
		[CompilerGenerated]
		private static Predicate<Class746> predicate_17;

		// Token: 0x04001C3A RID: 7226
		[CompilerGenerated]
		private static Predicate<Class746> predicate_18;

		// Token: 0x04001C3B RID: 7227
		[CompilerGenerated]
		private static Predicate<Class746> predicate_19;

		// Token: 0x04001C3C RID: 7228
		[CompilerGenerated]
		private static Predicate<Class746> predicate_20;

		// Token: 0x04001C3D RID: 7229
		[CompilerGenerated]
		private static Predicate<Class746> predicate_21;

		// Token: 0x04001C24 RID: 7204
		internal RectangleF rectangleF_0;

		// Token: 0x04001C33 RID: 7219
		private Rectangle rectangle_0;

		// Token: 0x04001C25 RID: 7205
		internal string string_0;

		// Token: 0x04001C12 RID: 7186
		internal Vector2 vector2_3;

		// Token: 0x04001C20 RID: 7200
		internal Vector2 vector2_4;

		// Token: 0x04001C22 RID: 7202
		internal Vector2 vector2_5;

		// Token: 0x04001C2F RID: 7215
		private Vector2 vector2_6;

		// Token: 0x04001C30 RID: 7216
		protected Vector2 vector2_7;

		// Token: 0x04001C32 RID: 7218
		private Vector2 vector2_8;

		// Token: 0x04001C2A RID: 7210
		private VoidDelegate voidDelegate_0;

		// Token: 0x0600240A RID: 9226
		// RVA: 0x000D8EA8 File Offset: 0x000D70A8
		internal Class531(string string_1, Vector2 vector2_9, Enum112 enum112_0, Origins origins_1, Enum115 enum115_1) : this(Class885.Load(string_1, enum112_0), enum115_1, origins_1, Enum114.const_0, vector2_9, 1f, true, Color.get_White(), null)
		{
		}

		// Token: 0x0600240B RID: 9227
		// RVA: 0x000D8ED4 File Offset: 0x000D70D4
		internal Class531(Class731 class731_1, Enum115 enum115_1, Origins origins_1, Enum114 enum114_1, Vector2 vector2_9) : this(class731_1, enum115_1, origins_1, enum114_1, vector2_9, 1f, false, Color.get_White(), null)
		{
		}

		// Token: 0x0600240D RID: 9229
		// RVA: 0x000D8F1C File Offset: 0x000D711C
		internal Class531(Class731 class731_1, Vector2 vector2_9, float float_7, bool bool_15, Color color_2) : this(class731_1, Enum115.const_5, Origins.TopLeft, Enum114.const_0, vector2_9, float_7, bool_15, color_2, null)
		{
		}

		// Token: 0x0600240C RID: 9228
		// RVA: 0x000D8EFC File Offset: 0x000D70FC
		internal Class531(Class731 class731_1, Origins origins_1, Vector2 vector2_9, float float_7, bool bool_15, Color color_2) : this(class731_1, Enum115.const_5, origins_1, Enum114.const_0, vector2_9, float_7, bool_15, color_2, null)
		{
		}

		// Token: 0x0600240E RID: 9230
		// RVA: 0x000D8F3C File Offset: 0x000D713C
		internal Class531(Class731 class731_1, Enum115 enum115_1, Origins origins_1, Enum114 enum114_1, Vector2 vector2_9, float float_7, bool bool_15, Color color_2, object object_1) : base(bool_15)
		{
			this.class731_0 = class731_1;
			this.origins_0 = origins_1;
			this.vmethod_8();
			this.vmethod_9();
			this.enum114_0 = enum114_1;
			this.vector2_1 = vector2_9;
			this.vector2_0 = this.vector2_1;
			this.float_2 = 1f;
			this.float_0 = float_7;
			this.float_4 = -this.float_0;
			this.enum115_0 = enum115_1;
			this.float_3 = (float)color_2.get_A() / 255f;
			this.color_0 = color_2;
			this.object_0 = object_1;
		}

		// Token: 0x06002423 RID: 9251
		// RVA: 0x000DB7BC File Offset: 0x000D99BC
		public virtual Class531 Clone()
		{
			Class531 class = new Class531(this.vmethod_6(), this.enum115_0, this.origins_0, this.enum114_0, this.vector2_0, this.float_0, this.bool_0, this.color_0, this.object_0);
			class.vector2_5 = this.vector2_5;
			class.vector2_1 = this.vector2_1;
			class.int_2 = this.int_2;
			class.int_3 = this.int_3;
			class.int_4 = this.int_4;
			class.int_1 = this.int_1;
			class.vector2_2 = this.vector2_2;
			class.bool_7 = this.bool_7;
			class.float_2 = this.float_2;
			foreach (Class746 current in this.class26_0)
			{
				if (!current.bool_1)
				{
					class.class26_0.Add(current.Clone());
				}
			}
			if (this.list_0 != null)
			{
				class.list_0 = new List<Class743>(this.list_0.Count);
				foreach (Class743 current2 in this.list_0)
				{
					class.list_0.Add(current2.Clone());
				}
			}
			return class;
		}

		// Token: 0x06002422 RID: 9250
		// RVA: 0x000DB748 File Offset: 0x000D9948
		internal override void Dispose(bool bool_15)
		{
			if (this.bool_6 && !this.bool_12)
			{
				base.method_1();
				this.eventHandler_1 = null;
				this.eventHandler_2 = null;
			}
			if (this.eventHandler_3 != null)
			{
				this.eventHandler_3(this.bool_6, null);
			}
			if (this.bool_6 && this.class731_0 != null)
			{
				this.class731_0.Dispose();
				this.class731_0 = null;
			}
		}

		// Token: 0x06002411 RID: 9233
		// RVA: 0x000DA9E4 File Offset: 0x000D8BE4
		public override bool Draw()
		{
			if (!base.Draw())
			{
				return false;
			}
			Class911.class911_0.method_20(this.bool_7);
			Class731 class = this.vmethod_6();
			if (class != null && !class.method_4())
			{
				if (class.int_3 != 1)
				{
					this.vector2_7 *= 1f / (float)class.int_3;
					this.rectangle_0.Width = this.rectangle_0.Width * class.int_3;
					this.rectangle_0.Height = this.rectangle_0.Height * class.int_3;
					this.rectangle_0.X = this.rectangle_0.X * class.int_3;
					this.rectangle_0.Y = this.rectangle_0.Y * class.int_3;
					this.vector2_6 *= (float)class.int_3;
				}
				Vector2 vector;
				vector..ctor(this.rectangleF_0.X + this.vector2_8.X, this.rectangleF_0.Y + this.vector2_8.Y);
				if (Class115.bool_26 && class.method_2() != null && !class.method_2().get_IsDisposed())
				{
					SpriteEffects spriteEffects = 0;
					if (this.vector2_7.X < 0f)
					{
						spriteEffects |= 1;
					}
					if (this.vector2_7.Y < 0f)
					{
						spriteEffects |= 256;
					}
					this.vector2_7.X = Math.Abs(this.vector2_7.X);
					this.vector2_7.Y = Math.Abs(this.vector2_7.Y);
					Class115.spriteBatch_0.Draw(class.method_2(), vector, new Rectangle?(this.rectangle_0), this.color_1, this.float_1, this.vector2_6, this.vector2_7, spriteEffects, 0f);
				}
				if (Class115.bool_27 && class.class748_0 != null)
				{
					class.class748_0.Draw(vector, this.vector2_6, this.color_1, this.vector2_7, this.float_1, new Rectangle?(this.rectangle_0));
				}
				if (Class911.class911_0.bool_2)
				{
					Class911.class911_0.int_3 += this.method_29();
				}
				return true;
			}
			return true;
		}

		// Token: 0x06002404 RID: 9220
		// RVA: 0x0001C52D File Offset: 0x0001A72D
		internal Vector2 method_28()
		{
			if (this.enum115_0 == Enum115.const_7)
			{
				return new Vector2((float)Class115.smethod_43() - this.vector2_1.X, this.vector2_1.Y);
			}
			return this.vector2_1;
		}

		// Token: 0x06002406 RID: 9222
		// RVA: 0x000D8E10 File Offset: 0x000D7010
		internal int method_29()
		{
			float num = (float)(Class115.int_19 * 16) / 9f;
			int val = (int)(num * Class115.float_2 * ((float)Class115.int_19 * Class115.float_2));
			return Math.Min((int)(this.rectangleF_0.Width * this.rectangleF_0.Height / (Class115.float_4 * Class115.float_4)), val);
		}

		// Token: 0x06002409 RID: 9225
		// RVA: 0x000D8E70 File Offset: 0x000D7070
		internal void method_30(VoidDelegate voidDelegate_1)
		{
			VoidDelegate voidDelegate = this.voidDelegate_0;
			VoidDelegate voidDelegate2;
			do
			{
				voidDelegate2 = voidDelegate;
				VoidDelegate value = (VoidDelegate)Delegate.Combine(voidDelegate2, voidDelegate_1);
				voidDelegate = Interlocked.CompareExchange<VoidDelegate>(ref this.voidDelegate_0, value, voidDelegate2);
			}
			while (voidDelegate != voidDelegate2);
		}

		// Token: 0x06002410 RID: 9232
		// RVA: 0x000D9E64 File Offset: 0x000D8064
		private Enum51 method_31(bool bool_15)
		{
			int num = this.class26_0.Count;
			if (num == 0)
			{
				if (!this.bool_0)
				{
					return Enum51.const_2;
				}
				return Enum51.const_0;
			}
			else
			{
				bool flag = this.bool_0;
				int num2 = base.method_9();
				bool flag2 = false;
				bool flag3 = false;
				bool? flag4 = null;
				bool? flag5 = null;
				bool? flag6 = null;
				bool flag7 = false;
				bool flag8 = false;
				bool flag9 = false;
				bool flag10 = false;
				bool flag11 = false;
				bool flag12 = false;
				bool flag13 = false;
				bool flag14 = false;
				bool flag15 = false;
				bool flag16 = false;
				bool flag17 = false;
				foreach (Class746 current in this.class26_0)
				{
					if (current.int_0 >= num2 || current.int_1 > num2)
					{
						flag2 = true;
						if (current.bool_0 && current.int_4 > 0 && !Class911.class911_0.bool_4)
						{
							flag14 = true;
						}
						if (current.int_0 > num2)
						{
							continue;
						}
					}
					if (current.int_1 <= num2)
					{
						flag3 = true;
						if (current.bool_0 && (current.int_3 == 0 || current.int_4 < current.int_3 - 1))
						{
							flag14 = true;
						}
						if (current.int_1 < num2)
						{
							continue;
						}
					}
					flag = true;
					TransformationType transformationType_ = current.transformationType_0;
					if (transformationType_ <= TransformationType.MovementX)
					{
						if (transformationType_ <= TransformationType.Colour)
						{
							switch (transformationType_)
							{
							case TransformationType.Movement:
								if (!flag10)
								{
									this.vector2_1 = Class778.smethod_15(current.vector2_0, current.vector2_1, (double)num2, (double)current.int_0, (float)current.int_1, current.enum70_0);
									if (this.bool_10)
									{
										Vector2 vector = current.vector2_1 - current.vector2_0;
										this.float_1 = (float)Math.Atan2((double)vector.Y, (double)vector.X);
										if (this.vmethod_4())
										{
											this.float_1 -= 3.14159274f;
										}
									}
									flag10 = true;
								}
								break;
							case TransformationType.Fade:
								if (!flag9)
								{
									this.float_3 = Class778.smethod_14(current.float_0, current.float_1, num2, current.int_0, current.int_1, current.enum70_0);
									flag9 = true;
								}
								break;
							case TransformationType.Movement | TransformationType.Fade:
								break;
							case TransformationType.Scale:
								if (!flag8)
								{
									this.float_2 = Class778.smethod_14(current.float_0, current.float_1, num2, current.int_0, current.int_1, current.enum70_0);
									flag8 = true;
								}
								break;
							default:
								if (transformationType_ != TransformationType.Rotation)
								{
									if (transformationType_ == TransformationType.Colour)
									{
										if (!flag13)
										{
											this.color_0 = Class778.smethod_13(current.color_0, current.color_1, num2, current.int_0, current.int_1, current.enum70_0);
											flag13 = true;
										}
									}
								}
								else if (!flag7)
								{
									this.float_1 = Class778.smethod_14(current.float_0, current.float_1, num2, current.int_0, current.int_1, current.enum70_0);
									flag7 = true;
								}
								break;
							}
						}
						else if (transformationType_ != TransformationType.ParameterFlipHorizontal)
						{
							if (transformationType_ != TransformationType.ParameterFlipVertical)
							{
								if (transformationType_ == TransformationType.MovementX)
								{
									if (!flag11)
									{
										this.vector2_1.X = Class778.smethod_14(current.float_0, current.float_1, num2, current.int_0, current.int_1, current.enum70_0);
										flag11 = true;
									}
								}
							}
							else
							{
								this.method_43(true);
								flag5 = new bool?(true);
							}
						}
						else
						{
							this.method_45(true);
							flag4 = new bool?(true);
						}
					}
					else if (transformationType_ <= TransformationType.ParameterAdditive)
					{
						if (transformationType_ != TransformationType.MovementY)
						{
							if (transformationType_ != TransformationType.VectorScale)
							{
								if (transformationType_ == TransformationType.ParameterAdditive)
								{
									this.bool_7 = true;
									flag6 = new bool?(true);
								}
							}
							else if (!flag8)
							{
								this.vector2_2 = Class778.smethod_15(current.vector2_0, current.vector2_1, (double)num2, (double)current.int_0, (float)current.int_1, current.enum70_0);
								flag8 = true;
							}
						}
						else if (!flag12)
						{
							this.vector2_1.Y = Class778.smethod_14(current.float_0, current.float_1, num2, current.int_0, current.int_1, current.enum70_0);
							flag12 = true;
						}
					}
					else if (transformationType_ != TransformationType.ClippingWidth)
					{
						if (transformationType_ != TransformationType.ClippingHeight)
						{
							if (transformationType_ == TransformationType.ClipRectangle)
							{
								if (!flag17)
								{
									base.method_5(new RectangleF?(Class778.smethod_16(current.rectangleF_0, current.rectangleF_1, (double)num2, (double)current.int_0, (float)current.int_1, current.enum70_0)));
									flag17 = true;
								}
							}
						}
						else if (!flag16)
						{
							this.int_1 = (int)Class778.smethod_14(current.float_0, current.float_1, num2, current.int_0, current.int_1, current.enum70_0);
							flag16 = true;
						}
					}
					else if (!flag15)
					{
						this.int_4 = (int)Class778.smethod_14(current.float_0, current.float_1, num2, current.int_0, current.int_1, current.enum70_0);
						flag15 = true;
					}
				}
				if (flag14 && bool_15)
				{
					bool flag18 = this.bool_0 || flag2;
					bool flag19 = false;
					bool flag20 = true;
					for (int i = num - 1; i >= 0; i--)
					{
						Class746 class = this.class26_0[i];
						if (class.bool_0 && (class.int_3 != 0 || flag18))
						{
							int num3 = 0;
							int num4 = class.method_0();
							int num5 = num4 + class.int_2;
							if (class.int_1 <= num2)
							{
								int num6 = class.int_3 - class.int_4 - 1;
								if (class.int_3 > 0 && num6 < 1)
								{
									goto IL_69E;
								}
								num3 = (num2 - class.int_0) / num5;
								if (class.int_3 > 0)
								{
									num3 = Math.Min(num3, num6);
								}
							}
							else if (!Class911.class911_0.bool_4 && class.int_0 > num2)
							{
								int num7 = class.int_4;
								if (num7 < 1)
								{
									goto IL_69E;
								}
								num3 = (num2 - class.int_1 - class.int_2) / num5;
								num3 = Math.Max(-num7, num3);
							}
							if (num3 != 0)
							{
								if (!flag19)
								{
									flag20 = Class619.smethod_1<Class746>(this.class26_0, true);
								}
								class.int_0 += num5 * num3;
								class.int_1 = class.int_0 + num4;
								class.int_4 += num3;
								if (flag20)
								{
									this.class26_0.RemoveAt(i);
									int num8 = this.class26_0.method_0(class);
									if (num8 < i)
									{
										i++;
									}
								}
								flag19 = true;
							}
						}
						IL_69E:;
					}
					if (flag19)
					{
						if (!flag20)
						{
							this.class26_0.Sort();
						}
						return this.method_31(false);
					}
				}
				if (!flag2 && !flag && (this.enum114_0 == Enum114.const_0 || Class911.class911_0.bool_4))
				{
					this.bool_3 = false;
					return Enum51.const_2;
				}
				if ((!flag2 || !flag3) && !flag)
				{
					this.bool_3 = false;
					if (this.enum114_0 == Enum114.const_2)
					{
						return Enum51.const_2;
					}
					return Enum51.const_1;
				}
				else
				{
					for (int j = num - 1; j >= 0; j--)
					{
						Class746 class2 = this.class26_0[j];
						if (class2.int_1 < num2)
						{
							flag = true;
							TransformationType transformationType_2 = class2.transformationType_0;
							if (transformationType_2 <= TransformationType.MovementX)
							{
								if (transformationType_2 <= TransformationType.Colour)
								{
									switch (transformationType_2)
									{
									case TransformationType.Movement:
										if (!flag10 && !flag11 && !flag12)
										{
											this.vector2_1 = class2.vector2_1;
											flag10 = true;
										}
										break;
									case TransformationType.Fade:
										if (!flag9)
										{
											this.float_3 = class2.float_1;
											flag9 = true;
										}
										break;
									case TransformationType.Movement | TransformationType.Fade:
										break;
									case TransformationType.Scale:
										if (!flag8)
										{
											this.float_2 = class2.float_1;
											flag8 = true;
										}
										break;
									default:
										if (transformationType_2 != TransformationType.Rotation)
										{
											if (transformationType_2 == TransformationType.Colour)
											{
												if (!flag13)
												{
													this.color_0 = class2.color_1;
													flag13 = true;
												}
											}
										}
										else if (!flag7)
										{
											this.float_1 = class2.float_1;
											flag7 = true;
										}
										break;
									}
								}
								else if (transformationType_2 != TransformationType.ParameterFlipHorizontal)
								{
									if (transformationType_2 != TransformationType.ParameterFlipVertical)
									{
										if (transformationType_2 == TransformationType.MovementX)
										{
											if (!flag11)
											{
												this.vector2_1.X = class2.float_1;
												flag11 = true;
											}
										}
									}
									else if (!flag5.HasValue)
									{
										bool flag21 = class2.method_0() == 0;
										bool value;
										this.method_43(value = flag21);
										flag5 = new bool?(value);
									}
								}
								else if (!flag4.HasValue)
								{
									bool flag22 = class2.method_0() == 0;
									bool value2;
									this.method_45(value2 = flag22);
									flag4 = new bool?(value2);
								}
							}
							else if (transformationType_2 <= TransformationType.ParameterAdditive)
							{
								if (transformationType_2 != TransformationType.MovementY)
								{
									if (transformationType_2 != TransformationType.VectorScale)
									{
										if (transformationType_2 == TransformationType.ParameterAdditive)
										{
											if (!flag6.HasValue)
											{
												bool flag23 = class2.method_0() == 0;
												flag6 = new bool?(this.bool_7 = flag23);
											}
										}
									}
									else if (!flag8)
									{
										this.vector2_2 = class2.vector2_1;
										flag8 = true;
									}
								}
								else if (!flag12)
								{
									this.vector2_1.Y = class2.float_1;
									flag12 = true;
								}
							}
							else if (transformationType_2 != TransformationType.ClippingWidth)
							{
								if (transformationType_2 != TransformationType.ClippingHeight)
								{
									if (transformationType_2 == TransformationType.ClipRectangle)
									{
										if (!flag17)
										{
											base.method_5(new RectangleF?(class2.rectangleF_1));
											flag17 = true;
										}
									}
								}
								else if (!flag16)
								{
									this.int_1 = (int)class2.float_1;
									flag16 = true;
								}
							}
							else if (!flag15)
							{
								this.int_4 = (int)class2.float_1;
								flag15 = true;
							}
							if (this.enum114_0 == Enum114.const_0 && !class2.bool_0 && this.bool_0)
							{
								this.class26_0.RemoveAt(j);
								num--;
							}
						}
					}
					if (flag2 && this.enum114_0 != Enum114.const_0)
					{
						for (int k = 0; k < num; k++)
						{
							Class746 class3 = this.class26_0[k];
							if (class3.int_0 >= num2)
							{
								TransformationType transformationType_3 = class3.transformationType_0;
								if (transformationType_3 <= TransformationType.Colour)
								{
									switch (transformationType_3)
									{
									case TransformationType.Movement:
										if (!flag10 && !flag11 && !flag12)
										{
											this.vector2_1 = class3.vector2_0;
											flag10 = true;
										}
										break;
									case TransformationType.Fade:
										if (!flag9)
										{
											this.float_3 = class3.float_0;
											flag9 = true;
										}
										break;
									case TransformationType.Movement | TransformationType.Fade:
										break;
									case TransformationType.Scale:
										if (!flag8)
										{
											this.float_2 = class3.float_0;
											flag8 = true;
										}
										break;
									default:
										if (transformationType_3 != TransformationType.Rotation)
										{
											if (transformationType_3 == TransformationType.Colour)
											{
												if (!flag13)
												{
													this.color_0 = class3.color_0;
													flag13 = true;
												}
											}
										}
										else if (!flag7)
										{
											this.float_1 = class3.float_0;
											flag7 = true;
										}
										break;
									}
								}
								else if (transformationType_3 != TransformationType.MovementX)
								{
									if (transformationType_3 != TransformationType.MovementY)
									{
										if (transformationType_3 == TransformationType.VectorScale)
										{
											if (!flag8)
											{
												this.vector2_2 = class3.vector2_0;
												flag8 = true;
											}
										}
									}
									else if (!flag12)
									{
										flag12 = true;
										this.vector2_1.Y = class3.float_0;
									}
								}
								else if (!flag11)
								{
									flag11 = true;
									this.vector2_1.X = class3.float_0;
								}
							}
						}
					}
					if (!flag)
					{
						return Enum51.const_1;
					}
					return Enum51.const_0;
				}
			}
		}

		// Token: 0x06002412 RID: 9234
		// RVA: 0x000DAC2C File Offset: 0x000D8E2C
		internal void method_32(Color color_2, int int_7)
		{
			Vector2 vector2_;
			Vector2 vector2_2;
			Vector2 vector2_3;
			Vector2 vector2_4;
			this.method_48(int_7).method_4(this.vector2_3, this.float_1, ref vector2_, ref vector2_2, ref vector2_3, ref vector2_4);
			Class115.class882_0.method_0();
			Class115.class882_0.method_1(vector2_, color_2);
			Class115.class882_0.method_1(vector2_3, color_2);
			Class115.class882_0.method_1(vector2_3, color_2);
			Class115.class882_0.method_1(vector2_4, color_2);
			Class115.class882_0.method_1(vector2_4, color_2);
			Class115.class882_0.method_1(vector2_2, color_2);
			Class115.class882_0.method_1(vector2_2, color_2);
			Class115.class882_0.method_1(vector2_, color_2);
			Class115.class882_0.method_2();
		}

		// Token: 0x06002418 RID: 9240
		// RVA: 0x000DADE0 File Offset: 0x000D8FE0
		private void method_33()
		{
			int num = Class911.smethod_0(this);
			if (this.class746_1 != null)
			{
				lock (Class911.object_0)
				{
					List<Class746> arg_42_0 = this.class26_0;
					if (Class531.predicate_14 == null)
					{
						Class531.predicate_14 = new Predicate<Class746>(Class531.smethod_14);
					}
					arg_42_0.RemoveAll(Class531.predicate_14);
				}
				Class746 class = this.class746_1.Clone();
				class.vector2_0 = this.vector2_1;
				TransformationType transformationType_ = this.class746_1.transformationType_0;
				switch (transformationType_)
				{
				case TransformationType.Fade:
					class.float_0 = this.float_3;
					break;
				case TransformationType.Movement | TransformationType.Fade:
					break;
				case TransformationType.Scale:
					class.float_0 = this.float_2;
					break;
				default:
					if (transformationType_ == TransformationType.Rotation)
					{
						class.float_0 = this.float_1;
					}
					break;
				}
				class.color_0 = this.color_0;
				int num2 = this.class746_1.method_0();
				class.int_0 = num;
				class.int_1 = num + num2;
				class.byte_0 = 1;
				this.class26_0.Add(class);
			}
			if (this.list_1 != null)
			{
				lock (Class911.object_0)
				{
					List<Class746> arg_132_0 = this.class26_0;
					if (Class531.predicate_15 == null)
					{
						Class531.predicate_15 = new Predicate<Class746>(Class531.smethod_15);
					}
					arg_132_0.RemoveAll(Class531.predicate_15);
				}
				bool flag = true;
				foreach (Class746 current in this.list_1)
				{
					Predicate<Class746> predicate = null;
					Class531.Class554 class2 = new Class531.Class554();
					class2.class746_0 = current.Clone();
					if (flag)
					{
						List<Class746> arg_199_0 = this.class26_0;
						if (predicate == null)
						{
							predicate = new Predicate<Class746>(class2.method_0);
						}
						arg_199_0.RemoveAll(predicate);
						class2.class746_0.vector2_0 = this.vector2_1;
						TransformationType transformationType_2 = class2.class746_0.transformationType_0;
						switch (transformationType_2)
						{
						case TransformationType.Fade:
							class2.class746_0.float_0 = this.float_3;
							break;
						case TransformationType.Movement | TransformationType.Fade:
							break;
						case TransformationType.Scale:
							class2.class746_0.float_0 = this.float_2;
							break;
						default:
							if (transformationType_2 == TransformationType.Rotation)
							{
								class2.class746_0.float_0 = this.float_1;
							}
							break;
						}
						class2.class746_0.color_0 = this.color_0;
						flag = false;
					}
					class2.class746_0.int_0 += num;
					class2.class746_0.int_1 += num;
					class2.class746_0.byte_0 = 1;
					this.class26_0.Add(class2.class746_0);
				}
			}
		}

		// Token: 0x06002419 RID: 9241
		// RVA: 0x000DB0C8 File Offset: 0x000D92C8
		private void method_34()
		{
			int num = Class911.smethod_0(this);
			if (this.class746_1 != null)
			{
				lock (Class911.object_0)
				{
					List<Class746> arg_42_0 = this.class26_0;
					if (Class531.predicate_16 == null)
					{
						Class531.predicate_16 = new Predicate<Class746>(Class531.smethod_16);
					}
					arg_42_0.RemoveAll(Class531.predicate_16);
				}
				Class746 class = this.class746_1.method_1();
				class.vector2_0 = this.vector2_1;
				TransformationType transformationType_ = this.class746_1.transformationType_0;
				switch (transformationType_)
				{
				case TransformationType.Fade:
					class.float_0 = this.float_3;
					break;
				case TransformationType.Movement | TransformationType.Fade:
					break;
				case TransformationType.Scale:
					class.float_0 = this.float_2;
					break;
				default:
					if (transformationType_ == TransformationType.Rotation)
					{
						class.float_0 = this.float_1;
					}
					break;
				}
				class.color_0 = this.color_0;
				int num2 = this.class746_1.method_0();
				class.int_0 = num;
				class.int_1 = num + num2;
				class.byte_0 = 1;
				this.class26_0.Add(class);
			}
			if (this.list_2 != null)
			{
				lock (Class911.object_0)
				{
					List<Class746> arg_132_0 = this.class26_0;
					if (Class531.predicate_17 == null)
					{
						Class531.predicate_17 = new Predicate<Class746>(Class531.smethod_17);
					}
					arg_132_0.RemoveAll(Class531.predicate_17);
				}
				bool flag = true;
				foreach (Class746 current in this.list_2)
				{
					Class746 class2 = current.Clone();
					if (flag)
					{
						class2.vector2_0 = this.vector2_1;
						TransformationType transformationType_2 = class2.transformationType_0;
						switch (transformationType_2)
						{
						case TransformationType.Fade:
							class2.float_0 = this.float_3;
							break;
						case TransformationType.Movement | TransformationType.Fade:
							break;
						case TransformationType.Scale:
							class2.float_0 = this.float_2;
							break;
						default:
							if (transformationType_2 == TransformationType.Rotation)
							{
								class2.float_0 = this.float_1;
							}
							break;
						}
						class2.color_0 = this.color_0;
						flag = false;
					}
					class2.int_0 += num;
					class2.int_1 += num;
					class2.byte_0 = 1;
					this.class26_0.Add(class2);
				}
			}
		}

		// Token: 0x0600241C RID: 9244
		// RVA: 0x000DB4AC File Offset: 0x000D96AC
		internal void method_35(EventHandler eventHandler_4)
		{
			EventHandler eventHandler = this.eventHandler_1;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_4);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x0600241D RID: 9245
		// RVA: 0x000DB4E4 File Offset: 0x000D96E4
		internal void method_36(EventHandler eventHandler_4)
		{
			EventHandler eventHandler = this.eventHandler_1;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_4);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x0600241E RID: 9246
		// RVA: 0x000DB51C File Offset: 0x000D971C
		internal void method_37(EventHandler eventHandler_4)
		{
			EventHandler eventHandler = this.eventHandler_2;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_4);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_2, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x0600241F RID: 9247
		// RVA: 0x000DB554 File Offset: 0x000D9754
		internal void method_38(EventHandler eventHandler_4)
		{
			EventHandler eventHandler = this.eventHandler_2;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_4);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_2, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06002420 RID: 9248
		// RVA: 0x000DB58C File Offset: 0x000D978C
		internal Class746 method_39(Color color_2, int int_7, bool bool_15, Enum70 enum70_0)
		{
			if (!bool_15 && this.color_0 == color_2 && this.class26_0.Count == 0)
			{
				return null;
			}
			lock (Class911.object_0)
			{
				List<Class746> arg_4F_0 = this.class26_0;
				if (Class531.predicate_18 == null)
				{
					Class531.predicate_18 = new Predicate<Class746>(Class531.smethod_18);
				}
				arg_4F_0.RemoveAll(Class531.predicate_18);
			}
			if (int_7 == 0)
			{
				this.color_0 = color_2;
				return null;
			}
			Class746 class = new Class746(this.color_0, color_2, Class115.smethod_21(this.enum114_0) - (int)Class115.double_9, Class115.smethod_21(this.enum114_0) + int_7)
			{
				enum70_0 = enum70_0
			};
			this.class26_0.Add(class);
			return class;
		}

		// Token: 0x06002421 RID: 9249
		// RVA: 0x000DB658 File Offset: 0x000D9858
		internal void method_40(Color color_2, int int_7)
		{
			if (this.color_0 == color_2)
			{
				return;
			}
			Color color_3 = this.color_0;
			lock (Class911.object_0)
			{
				List<Class746> arg_45_0 = this.class26_0;
				if (Class531.predicate_19 == null)
				{
					Class531.predicate_19 = new Predicate<Class746>(Class531.smethod_19);
				}
				Class746 class = arg_45_0.Find(Class531.predicate_19);
				if (class != null && class.byte_0 != 51)
				{
					return;
				}
				if (class != null)
				{
					color_3 = class.color_1;
				}
				List<Class746> arg_87_0 = this.class26_0;
				if (Class531.predicate_20 == null)
				{
					Class531.predicate_20 = new Predicate<Class746>(Class531.smethod_20);
				}
				arg_87_0.RemoveAll(Class531.predicate_20);
			}
			Class746 class2 = new Class746(color_2, color_3, Class115.smethod_21(this.enum114_0) - (int)Class115.double_9, Class115.smethod_21(this.enum114_0) + int_7);
			class2.byte_0 = 51;
			this.class26_0.Add(class2);
		}

		// Token: 0x06002424 RID: 9252
		// RVA: 0x000DB938 File Offset: 0x000D9B38
		public void method_41(EventHandler eventHandler_4)
		{
			EventHandler eventHandler = this.eventHandler_3;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_4);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_3, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06002425 RID: 9253
		// RVA: 0x0001C5BC File Offset: 0x0001A7BC
		public bool method_42()
		{
			return this.vector2_2.Y < 0f;
		}

		// Token: 0x06002426 RID: 9254
		// RVA: 0x0001C5D0 File Offset: 0x0001A7D0
		public void method_43(bool bool_15)
		{
			if (this.method_42() == bool_15)
			{
				return;
			}
			this.vector2_2.Y = -this.vector2_2.Y;
		}

		// Token: 0x06002427 RID: 9255
		// RVA: 0x0001C5F3 File Offset: 0x0001A7F3
		public bool method_44()
		{
			return this.vector2_2.X < 0f;
		}

		// Token: 0x06002428 RID: 9256
		// RVA: 0x0001C607 File Offset: 0x0001A807
		public void method_45(bool bool_15)
		{
			if (this.method_44() == bool_15)
			{
				return;
			}
			this.vector2_2.X = -this.vector2_2.X;
		}

		// Token: 0x06002429 RID: 9257
		// RVA: 0x000DB970 File Offset: 0x000D9B70
		internal void method_46(bool bool_15, bool bool_16)
		{
			float num = (float)Class115.smethod_44() / (float)this.int_5;
			float num2 = (float)Class115.smethod_43() / (float)this.int_6;
			if (num > num2 && !bool_16)
			{
				num2 = num;
			}
			if (this.enum115_0 != Enum115.const_2 && this.enum115_0 != Enum115.const_3)
			{
				num2 *= 1.6f;
				num *= 1.6f;
			}
			if ((float)this.int_6 / (float)this.int_5 > 1.34f)
			{
				this.float_2 = num2;
				return;
			}
			switch (Class341.class605_6.Value)
			{
			case ScaleMode.Letterbox:
				this.float_2 = num;
				return;
			case ScaleMode.WidescreenConservative:
				this.float_2 = (bool_15 ? num2 : num);
				return;
			case ScaleMode.WidescreenAlways:
				this.float_2 = num2;
				return;
			default:
				return;
			}
		}

		// Token: 0x0600242A RID: 9258
		// RVA: 0x000DBA20 File Offset: 0x000D9C20
		public void method_47(int int_7, int int_8, Enum70 enum70_0)
		{
			if (this.class26_0.Count == 1)
			{
				Class746 class = this.class26_0[0];
				if (class.transformationType_0 == TransformationType.ClippingWidth && class.float_1 == (float)int_7 && class.int_1 - class.int_0 == int_8)
				{
					return;
				}
			}
			lock (Class911.object_0)
			{
				List<Class746> arg_72_0 = this.class26_0;
				if (Class531.predicate_21 == null)
				{
					Class531.predicate_21 = new Predicate<Class746>(Class531.smethod_21);
				}
				arg_72_0.RemoveAll(Class531.predicate_21);
			}
			if (this.int_4 == int_7)
			{
				return;
			}
			Class746 class2 = new Class746(TransformationType.ClippingWidth, (float)this.int_4, (float)int_7, Class115.smethod_21(this.enum114_0) - (int)Class115.double_9, Class115.smethod_21(this.enum114_0) + int_8, Enum70.const_0);
			class2.enum70_0 = enum70_0;
			this.class26_0.Add(class2);
		}

		// Token: 0x0600242C RID: 9260
		// RVA: 0x000DBB3C File Offset: 0x000D9D3C
		private RectangleF method_48(int int_7)
		{
			if (int_7 == 0)
			{
				return this.rectangleF_0;
			}
			return RectangleF.smethod_1(this.rectangleF_0, Math.Max(0f, ((float)int_7 - this.rectangleF_0.Width) * 0.5f), Math.Max(0f, ((float)int_7 - this.rectangleF_0.Height) * 0.5f));
		}

		// Token: 0x0600242D RID: 9261
		// RVA: 0x00018B51 File Offset: 0x00016D51
		[CompilerGenerated]
		private static bool smethod_14(Class746 class746_2)
		{
			return class746_2.byte_0 == 1;
		}

		// Token: 0x0600242E RID: 9262
		// RVA: 0x00018B51 File Offset: 0x00016D51
		[CompilerGenerated]
		private static bool smethod_15(Class746 class746_2)
		{
			return class746_2.byte_0 == 1;
		}

		// Token: 0x0600242F RID: 9263
		// RVA: 0x00018B51 File Offset: 0x00016D51
		[CompilerGenerated]
		private static bool smethod_16(Class746 class746_2)
		{
			return class746_2.byte_0 == 1;
		}

		// Token: 0x06002430 RID: 9264
		// RVA: 0x00018B51 File Offset: 0x00016D51
		[CompilerGenerated]
		private static bool smethod_17(Class746 class746_2)
		{
			return class746_2.byte_0 == 1;
		}

		// Token: 0x06002431 RID: 9265
		// RVA: 0x00018A4E File Offset: 0x00016C4E
		[CompilerGenerated]
		private static bool smethod_18(Class746 class746_2)
		{
			return class746_2.transformationType_0 == TransformationType.Colour;
		}

		// Token: 0x06002432 RID: 9266
		// RVA: 0x00018A4E File Offset: 0x00016C4E
		[CompilerGenerated]
		private static bool smethod_19(Class746 class746_2)
		{
			return class746_2.transformationType_0 == TransformationType.Colour;
		}

		// Token: 0x06002433 RID: 9267
		// RVA: 0x00018A4E File Offset: 0x00016C4E
		[CompilerGenerated]
		private static bool smethod_20(Class746 class746_2)
		{
			return class746_2.transformationType_0 == TransformationType.Colour;
		}

		// Token: 0x06002434 RID: 9268
		// RVA: 0x0001C62A File Offset: 0x0001A82A
		[CompilerGenerated]
		private static bool smethod_21(Class746 class746_2)
		{
			return class746_2.transformationType_0 == TransformationType.ClippingWidth;
		}

		// Token: 0x06002413 RID: 9235
		// RVA: 0x000DACD4 File Offset: 0x000D8ED4
		public override string ToString()
		{
			if (this.class731_0 != null)
			{
				return string.Concat(new object[]
				{
					this.class731_0.string_0,
					" @",
					this.vector2_1.X,
					",",
					this.vector2_1.Y,
					") a:",
					Math.Round((double)this.float_3, 2),
					" depth:",
					this.float_0
				});
			}
			return base.ToString();
		}

		// Token: 0x06002405 RID: 9221
		// RVA: 0x00006D2D File Offset: 0x00004F2D
		internal override bool vmethod_0()
		{
			return true;
		}

		// Token: 0x06002416 RID: 9238
		// RVA: 0x0001C5B4 File Offset: 0x0001A7B4
		internal override bool vmethod_1()
		{
			return base.vmethod_1();
		}

		// Token: 0x0600242B RID: 9259
		// RVA: 0x000DBB10 File Offset: 0x000D9D10
		internal virtual bool vmethod_10(Vector2 vector2_9, int int_7)
		{
			return this.method_48(int_7).method_3(vector2_9, this.vector2_3, this.float_1);
		}

		// Token: 0x06002417 RID: 9239
		// RVA: 0x000DAD78 File Offset: 0x000D8F78
		internal override void vmethod_2(bool bool_15)
		{
			if (bool_15 == this.bool_4)
			{
				return;
			}
			base.vmethod_2(bool_15);
			if (this.bool_4)
			{
				this.method_33();
				if (this.eventHandler_1 != null)
				{
					this.eventHandler_1(this, null);
					return;
				}
			}
			else if (!this.bool_4)
			{
				this.method_34();
				if (this.eventHandler_2 != null)
				{
					this.eventHandler_2(this, null);
				}
			}
		}

		// Token: 0x0600240F RID: 9231
		// RVA: 0x000D8FDC File Offset: 0x000D71DC
		public override Enum51 vmethod_3()
		{
			Enum51 enum = base.vmethod_3();
			if (enum != Enum51.const_0)
			{
				return enum;
			}
			Vector2 vector = this.vector2_3;
			enum = this.method_31(true);
			if (enum != Enum51.const_0)
			{
				return enum;
			}
			Class911 class911_ = Class911.class911_0;
			bool flag;
			if ((flag = ((double)this.float_3 > 0.001 && class911_.float_0 > 0f)) && this.enum115_0 == Enum115.const_5 && !this.bool_11)
			{
				float num = class911_.vector2_0.Y - class911_.vector2_2.Y + class911_.vector2_1.Y - this.vector2_1.Y;
				float num2 = class911_.vector2_0.X - class911_.vector2_2.X + class911_.vector2_1.X - this.vector2_1.X;
				float num3 = this.vector2_1.Y - (class911_.vector2_0.Y - class911_.vector2_2.Y + class911_.vector2_1.Y + class911_.rectangleF_2.Height / class911_.float_3);
				float num4 = this.vector2_1.X - (class911_.vector2_0.X - class911_.vector2_2.X + class911_.vector2_1.X + class911_.rectangleF_2.Width / class911_.float_3);
				if ((num > 0f || num3 > 0f || num2 > 0f || num4 > 0f) && this.float_1 == 0f)
				{
					float num5 = Math.Abs((float)this.int_1 * this.vector2_2.Y * this.float_2 / 1.6f);
					float num6 = Math.Abs((float)this.int_4 * this.vector2_2.X * this.float_2 / 1.6f);
					switch (this.origins_0)
					{
					case Origins.TopLeft:
						if (num3 > 0f || num > num5 || num4 > 0f || num2 > num6)
						{
							flag = false;
						}
						break;
					case Origins.Centre:
						if (num3 > num5 / 2f || num > num5 / 2f || num4 > num6 / 2f || num2 > num6 / 2f)
						{
							flag = false;
						}
						break;
					case Origins.CentreLeft:
						if (num3 > num5 / 2f || num > num5 / 2f || num4 > 0f || num2 > num6)
						{
							flag = false;
						}
						break;
					case Origins.TopRight:
						if (num3 > 0f || num > num5 || num4 > num6 || num2 > 0f)
						{
							flag = false;
						}
						break;
					case Origins.BottomCentre:
						if (num3 > num5 || num > 0f || num4 > num6 / 2f || num2 > num6 / 2f)
						{
							flag = false;
						}
						break;
					case Origins.TopCentre:
						if (num3 > 0f || num > num5 || num4 > num6 / 2f || num2 > num6 / 2f)
						{
							flag = false;
						}
						break;
					case Origins.CentreRight:
						if (num3 > num5 / 2f || num > num5 / 2f || num4 > num6 || num2 > 0f)
						{
							flag = false;
						}
						break;
					case Origins.BottomLeft:
						if (num3 > num5 || num > 0f || num4 > 0f || num2 > num6)
						{
							flag = false;
						}
						break;
					case Origins.BottomRight:
						if (num3 > num5 || num > 0f || num4 > num6 || num2 > 0f)
						{
							flag = false;
						}
						break;
					}
				}
			}
			if (!flag && !class911_.bool_9)
			{
				this.bool_3 = false;
				return Enum51.const_1;
			}
			this.vector2_3 = this.vector2_1;
			this.vector2_6 = this.vector2_5;
			this.float_6 = Math.Max(this.float_2, 0f);
			if (class911_.bool_7 && (!this.bool_11 || this.float_5 > 0f))
			{
				Vector2 vector2 = class911_.vector2_1 - class911_.vector2_2;
				switch (this.enum115_0)
				{
				case Enum115.const_7:
				case Enum115.const_10:
				case Enum115.const_16:
					vector2 += new Vector2(-class911_.vector2_0.X, class911_.vector2_0.Y);
					goto IL_4C2;
				case Enum115.const_11:
				case Enum115.const_12:
				case Enum115.const_17:
					vector2 += new Vector2(class911_.vector2_0.X, -class911_.vector2_0.Y);
					goto IL_4C2;
				case Enum115.const_13:
					vector2 -= class911_.vector2_0;
					goto IL_4C2;
				}
				vector2 += class911_.vector2_0;
				IL_4C2:
				if (this.float_5 > 0f)
				{
					vector2.Y = Math.Max(0f, Math.Min(this.float_5, vector2.Y));
				}
				this.vector2_3 -= vector2;
			}
			bool flag2 = true;
			float num7 = class911_.bool_7 ? (class911_.rectangleF_2.Width * Class115.float_4) : ((float)Class115.int_22);
			float num8 = class911_.bool_7 ? (class911_.rectangleF_2.Height * Class115.float_4) : ((float)Class115.int_23);
			Enum115 enum2 = this.enum115_0;
			switch (enum2)
			{
			case Enum115.const_0:
			case Enum115.const_1:
				this.float_6 *= class911_.float_4;
				break;
			case Enum115.const_2:
			case Enum115.const_3:
				this.float_6 *= Class115.float_1;
				break;
			case Enum115.const_4:
				break;
			default:
				switch (enum2)
				{
				case Enum115.const_14:
					this.float_6 *= Class115.float_4 * Class115.smethod_48();
					goto IL_5EC;
				case Enum115.const_16:
				case Enum115.const_17:
					goto IL_5EC;
				}
				if (this.bool_13)
				{
					this.float_6 *= Class115.float_5;
				}
				break;
			}
			IL_5EC:
			switch (this.enum115_0)
			{
			case Enum115.const_0:
				Class115.smethod_62(ref this.vector2_3);
				flag2 = false;
				goto IL_A7C;
			case Enum115.const_1:
				Class115.smethod_63(ref this.vector2_3);
				flag2 = false;
				goto IL_A7C;
			case Enum115.const_2:
				this.vector2_3 = this.vector2_3 * Class115.float_4 * Class115.float_2;
				this.vector2_3.X = this.vector2_3.X + (num7 + (float)((!class911_.bool_8) ? (Class115.int_26 * 2) : 0)) * ((1f - Class115.float_2) * 0.5f);
				this.vector2_3.Y = this.vector2_3.Y + (num8 + (float)Class115.int_25) * ((1f - Class115.float_2) * 0.75f);
				goto IL_A7C;
			case Enum115.const_3:
				this.vector2_3 += new Vector2((float)((class911_.bool_8 ? Class115.int_20 : Class115.smethod_43()) / 2), (float)(Class115.int_19 / 2));
				this.vector2_3 = this.vector2_3 * Class115.float_4 * Class115.float_2;
				this.vector2_3.X = this.vector2_3.X + (num7 + (float)((!class911_.bool_8) ? (Class115.int_26 * 2) : 0)) * ((1f - Class115.float_2) * 0.5f);
				this.vector2_3.Y = this.vector2_3.Y + (num8 + (float)Class115.int_25) * ((1f - Class115.float_2) * 0.75f);
				goto IL_A7C;
			case Enum115.const_5:
				this.vector2_3 *= Class115.float_4;
				goto IL_A7C;
			case Enum115.const_6:
				this.vector2_3 *= Class115.float_4;
				this.vector2_3.X = this.vector2_3.X + num7 / 2f;
				goto IL_A7C;
			case Enum115.const_7:
				this.vector2_3 *= Class115.float_4;
				this.vector2_3.X = num7 - this.vector2_3.X;
				goto IL_A7C;
			case Enum115.const_8:
				this.vector2_3.X = this.vector2_3.X * Class115.float_4;
				this.vector2_3.Y = num8 / 2f + this.vector2_3.Y * Class115.float_4;
				goto IL_A7C;
			case Enum115.const_9:
				this.vector2_3.X = num7 / 2f + this.vector2_3.X * Class115.float_4;
				this.vector2_3.Y = num8 / 2f + this.vector2_3.Y * Class115.float_4;
				goto IL_A7C;
			case Enum115.const_10:
				this.vector2_3.X = num7 - this.vector2_3.X * Class115.float_4;
				this.vector2_3.Y = num8 / 2f + this.vector2_3.Y * Class115.float_4;
				goto IL_A7C;
			case Enum115.const_11:
				this.vector2_3 *= Class115.float_4;
				this.vector2_3.Y = num8 - this.vector2_3.Y;
				goto IL_A7C;
			case Enum115.const_12:
				this.vector2_3 *= Class115.float_4;
				this.vector2_3.X = num7 / 2f + this.vector2_3.X;
				this.vector2_3.Y = num8 + (float)Class115.int_25 - this.vector2_3.Y;
				goto IL_A7C;
			case Enum115.const_13:
				this.vector2_3 *= Class115.float_4;
				this.vector2_3.X = num7 - this.vector2_3.X;
				this.vector2_3.Y = num8 - this.vector2_3.Y;
				goto IL_A7C;
			case Enum115.const_14:
				this.vector2_3 = Class115.float_4 * this.vector2_3;
				goto IL_A7C;
			case Enum115.const_15:
				flag2 = false;
				goto IL_A7C;
			case Enum115.const_16:
				this.vector2_3.X = num7 - this.vector2_3.X;
				flag2 = false;
				goto IL_A7C;
			case Enum115.const_17:
				this.vector2_3.X = num7 / 2f + this.vector2_3.X;
				this.vector2_3.Y = num8 + (float)Class115.int_25 - this.vector2_3.Y;
				flag2 = false;
				goto IL_A7C;
			}
			flag2 = false;
			IL_A7C:
			byte b = (byte)(this.float_3 * class911_.float_0 * 255f);
			byte a = this.color_0.get_A();
			if (a > 0 && a < 255)
			{
				b = (byte)((float)b * ((float)a / 255f));
			}
			if (class911_.float_1 == 0f)
			{
				this.color_1 = new Color(this.color_0.get_R(), this.color_0.get_G(), this.color_0.get_B(), b);
			}
			else
			{
				this.color_1 = new Color((byte)Math.Max(0f, Math.Min(255f, 255f * class911_.float_2 * class911_.float_1 + (float)this.color_0.get_R() * (1f - class911_.float_1))), (byte)Math.Max(0f, Math.Min(255f, 255f * class911_.float_2 * class911_.float_1 + (float)this.color_0.get_G() * (1f - class911_.float_1))), (byte)Math.Max(0f, Math.Min(255f, 255f * class911_.float_2 * class911_.float_1 + (float)this.color_0.get_B() * (1f - class911_.float_1))), b);
			}
			this.vector2_7 = this.vector2_2 * this.float_6;
			if (class911_.float_3 != 1f && !this.bool_11)
			{
				if (!(this is Class533))
				{
					this.vector2_7 *= class911_.float_3;
				}
				this.vector2_3 *= class911_.float_3;
			}
			if (flag2)
			{
				this.vector2_3.X = this.vector2_3.X + class911_.rectangleF_3.X;
				this.vector2_3.Y = this.vector2_3.Y + class911_.rectangleF_3.Y;
			}
			this.bool_8 = false;
			if (this.nullable_2.HasValue)
			{
				this.bool_8 = this.nullable_2.Value;
			}
			else if (this.vector2_7.X == 1f && this.vector2_7.Y == 1f && Vector2.DistanceSquared(vector, this.vector2_3) < 1.401298E-45f)
			{
				this.bool_8 = true;
			}
			this.vector2_8 = new Vector2(this.vector2_6.X * Math.Abs(this.vector2_7.X), this.vector2_6.Y * Math.Abs(this.vector2_7.Y));
			Vector2 vector3 = this.vector2_3 - this.vector2_8;
			if (this.bool_8)
			{
				vector3.X = (float)Math.Round((double)vector3.X);
				vector3.Y = (float)Math.Round((double)vector3.Y);
			}
			this.rectangleF_0 = new RectangleF(vector3.X, vector3.Y, (float)this.int_4 * Math.Abs(this.vector2_7.X), (float)this.int_1 * Math.Abs(this.vector2_7.Y));
			if (class911_.bool_7 && this.float_1 == 0f && this.enum115_0 != Enum115.const_15 && (this.enum115_0 != Enum115.const_7 || !class911_.bool_8) && !RectangleF.smethod_2((double)this.float_1, this.rectangleF_0, class911_.rectangleF_3, this.vector2_8))
			{
				this.bool_3 = false;
				if (this.vmethod_1())
				{
					this.vmethod_2(false);
				}
				return Enum51.const_1;
			}
			this.rectangle_0 = new Rectangle(this.int_2, this.int_3, Math.Min(this.int_6, Math.Max(0, this.int_4)), Math.Min(this.int_5, Math.Max(0, this.int_1)));
			if (this.voidDelegate_0 != null)
			{
				this.voidDelegate_0();
			}
			this.bool_3 = flag;
			if (!this.bool_3)
			{
				return Enum51.const_1;
			}
			return Enum51.const_0;
		}

		// Token: 0x06002407 RID: 9223
		// RVA: 0x0001C561 File Offset: 0x0001A761
		[CompilerGenerated]
		internal virtual bool vmethod_4()
		{
			return this.bool_14;
		}

		// Token: 0x06002408 RID: 9224
		// RVA: 0x0001C569 File Offset: 0x0001A769
		[CompilerGenerated]
		internal virtual void vmethod_5(bool bool_15)
		{
			this.bool_14 = bool_15;
		}

		// Token: 0x06002414 RID: 9236
		// RVA: 0x0001C572 File Offset: 0x0001A772
		internal virtual Class731 vmethod_6()
		{
			return this.class731_0;
		}

		// Token: 0x06002415 RID: 9237
		// RVA: 0x0001C57A File Offset: 0x0001A77A
		internal virtual void vmethod_7(Class731 class731_1)
		{
			if (class731_1 == this.class731_0)
			{
				return;
			}
			if (this.class731_0 != null && this.bool_6)
			{
				this.class731_0.Dispose();
			}
			this.class731_0 = class731_1;
			this.vmethod_8();
			this.vmethod_9();
		}

		// Token: 0x0600241A RID: 9242
		// RVA: 0x000DB328 File Offset: 0x000D9528
		internal virtual void vmethod_8()
		{
			if (this.class731_0 != null)
			{
				this.int_6 = this.class731_0.method_0();
				this.int_5 = this.class731_0.method_1();
			}
			this.int_4 = this.int_6;
			this.int_1 = this.int_5;
			this.int_3 = 0;
			this.int_2 = 0;
		}

		// Token: 0x0600241B RID: 9243
		// RVA: 0x000DB388 File Offset: 0x000D9588
		internal virtual void vmethod_9()
		{
			switch (this.origins_0)
			{
			case Origins.TopLeft:
				this.vector2_5 = Vector2.get_Zero();
				return;
			case Origins.Centre:
				this.vector2_5 = new Vector2((float)(this.int_6 / 2), (float)(this.int_5 / 2));
				return;
			case Origins.CentreLeft:
				this.vector2_5 = new Vector2(0f, (float)(this.int_5 / 2));
				return;
			case Origins.TopRight:
				this.vector2_5 = new Vector2((float)this.int_6, 0f);
				break;
			case Origins.BottomCentre:
				this.vector2_5 = new Vector2((float)(this.int_6 / 2), (float)this.int_5);
				return;
			case Origins.TopCentre:
				this.vector2_5 = new Vector2((float)(this.int_6 / 2), 0f);
				return;
			case Origins.Custom:
				break;
			case Origins.CentreRight:
				this.vector2_5 = new Vector2((float)this.int_6, (float)(this.int_5 / 2));
				return;
			case Origins.BottomLeft:
				this.vector2_5 = new Vector2(0f, (float)this.int_5);
				return;
			case Origins.BottomRight:
				this.vector2_5 = new Vector2((float)this.int_6, (float)this.int_5);
				return;
			default:
				return;
			}
		}
	}
}
