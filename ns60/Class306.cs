using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns23;
using ns26;
using ns29;
using ns59;
using ns64;
using ns70;
using ns76;
using ns77;
using ns79;
using ns80;
using osu;
using osu.Audio;
using osu.GameplayElements.HitObjects;
using osu.Graphics.Sprites;
using osu_common;
using System;

namespace ns60
{
	// Token: 0x0200041F RID: 1055
	internal class Class306 : Class305
	{
		// Token: 0x04001A84 RID: 6788
		internal Class531 class531_0;

		// Token: 0x04001A85 RID: 6789
		internal Class531 class531_1;

		// Token: 0x04001A87 RID: 6791
		internal Class531 class531_2;

		// Token: 0x04001A88 RID: 6792
		internal Class531 class531_3;

		// Token: 0x04001A86 RID: 6790
		internal Class538 class538_0;

		// Token: 0x04001A89 RID: 6793
		private Class746 class746_0;

		// Token: 0x04001A83 RID: 6787
		private int int_6;

		// Token: 0x1700036E RID: 878
		public override int ComboNumber
		{
			// Token: 0x060021FC RID: 8700
			// RVA: 0x0001B4FA File Offset: 0x000196FA
			get
			{
				return this.int_6;
			}
			// Token: 0x060021FD RID: 8701
			// RVA: 0x000C92C8 File Offset: 0x000C74C8
			set
			{
				Class533 class = this.class531_2 as Class533;
				if (class != null)
				{
					class.Text = ((value > 0) ? value.ToString() : string.Empty);
				}
				this.int_6 = value;
			}
		}

		// Token: 0x1700036D RID: 877
		public override Vector2 EndPosition
		{
			// Token: 0x060021FE RID: 8702
			// RVA: 0x0001492A File Offset: 0x00012B2A
			get
			{
				return this.Position;
			}
			// Token: 0x060021FF RID: 8703
			// RVA: 0x0000653E File Offset: 0x0000473E
			set
			{
			}
		}

		// Token: 0x060021EE RID: 8686
		// RVA: 0x000C8850 File Offset: 0x000C6A50
		internal Class306(Class297 class297_1, Vector2 vector2_1, int int_7, bool bool_6) : this(class297_1, vector2_1, int_7, bool_6, false, false, false, 0)
		{
		}

		// Token: 0x060021EF RID: 8687
		// RVA: 0x000C886C File Offset: 0x000C6A6C
		internal Class306(Class297 class297_1, Vector2 vector2_1, int int_7, bool bool_6, HitObjectSoundType hitObjectSoundType_0, int int_8) : this(class297_1, vector2_1, int_7, bool_6, hitObjectSoundType_0.IsType(HitObjectSoundType.Whistle), hitObjectSoundType_0.IsType(HitObjectSoundType.Finish), hitObjectSoundType_0.IsType(HitObjectSoundType.Clap), int_8)
		{
		}

		// Token: 0x060021F1 RID: 8689
		// RVA: 0x000C88A0 File Offset: 0x000C6AA0
		internal Class306(Class297 class297_1, Vector2 vector2_1, int int_7, bool bool_6, bool bool_7, bool bool_8, bool bool_9, int int_8) : base(class297_1)
		{
			this.Position = vector2_1;
			this.vector2_0 = vector2_1;
			this.StartTime = int_7;
			this.EndTime = int_7;
			this.Type = HitObjectType.Normal;
			this.SoundType = HitObjectSoundType.None;
			this.sampleSet_0 = SampleSet.None;
			this.sampleSet_1 = SampleSet.None;
			int num = this.vmethod_22();
			if (bool_6)
			{
				this.Type |= HitObjectType.NewCombo;
				this.int_0 = int_8;
			}
			if (bool_7)
			{
				this.SoundType |= HitObjectSoundType.Whistle;
			}
			if (bool_8)
			{
				this.SoundType |= HitObjectSoundType.Finish;
			}
			if (bool_9)
			{
				this.SoundType |= HitObjectSoundType.Clap;
			}
			if (class297_1.class911_0 != null)
			{
				bool flag = Class876.smethod_6(this.class297_0.class623_0, Mods.Hidden);
				bool flag2 = this.vmethod_25() && (!flag || (class297_1.list_3.Count == 0 && Class341.class606_86));
				Color white = Color.get_White();
				Class731 class731_ = Class885.Load("approachcircle", Enum112.flag_6);
				Class731 class731_2 = Class885.Load(this.vmethod_23(), Enum112.flag_6);
				Class731[] class731_3 = Class885.smethod_27(this.vmethod_23() + "overlay", Enum112.flag_6, true);
				this.class531_0 = new Class531(class731_, Enum115.const_0, Origins.Centre, Enum114.const_1, this.Position, Class911.smethod_3((float)(this.StartTime - num)), false, white, null);
				if (flag2)
				{
					this.list_1.Add(this.class531_0);
				}
				this.class531_0.class26_0.Add(new Class746(TransformationType.Fade, 0f, 0.9f, int_7 - num, Math.Min(int_7, int_7 - num + Class297.int_2 * 2), Enum70.const_0));
				this.class531_0.class26_0.Add(new Class746(TransformationType.Scale, 4f, 1f, int_7 - num, int_7, Enum70.const_0));
				this.class531_1 = new Class531(class731_2, Enum115.const_0, Origins.Centre, Enum114.const_1, this.Position, Class911.smethod_4((float)this.StartTime), false, white, null)
				{
					int_0 = 1
				};
				this.list_1.Add(this.class531_1);
				this.list_0.Add(this.class531_1);
				this.class538_0 = new Class538(class731_3, Enum115.const_0, Origins.Centre, Enum114.const_1, this.Position, Class911.smethod_4((float)(this.StartTime - (this.class297_0.method_32() ? 2 : 1))), false, Color.get_White());
				this.class538_0.method_53(500.0);
				this.list_1.Add(this.class538_0);
				this.list_0.Add(this.class538_0);
				this.class531_2 = new Class536(null, Class885.class547_0.string_3, Class885.class547_0.int_3, Enum115.const_0, Origins.Centre, Enum114.const_1, this.Position, Class911.smethod_4((float)(this.StartTime - (this.class297_0.method_32() ? 1 : 2))), false, Color.get_White(), true);
				this.class531_2.float_2 = 0.8f;
				if (this.vmethod_24())
				{
					this.list_1.Add(this.class531_2);
				}
				Class746 class;
				if (flag)
				{
					class = new Class746(TransformationType.Fade, 0f, 1f, int_7 - num, int_7 - (int)((double)num * 0.6), Enum70.const_0);
				}
				else
				{
					class = new Class746(TransformationType.Fade, 0f, 1f, int_7 - num, int_7 - num + Class297.int_2, Enum70.const_0);
				}
				this.class531_1.class26_0.Add(class.Clone());
				this.class538_0.class26_0.Add(class.Clone());
				this.class531_2.class26_0.Add(class.Clone());
				if (Class115.osuModes_1 == OsuModes.Edit)
				{
					this.class531_3 = new Class531(Class885.Load("hitcircleselect", Enum112.flag_6), Enum115.const_0, Origins.Centre, Enum114.const_0, this.Position, Class911.smethod_4((float)(this.StartTime - 3)), true, Color.get_TransparentWhite(), null);
					this.list_1.Add(this.class531_3);
					if (Class341.class606_20)
					{
						this.vmethod_8(true);
					}
					else
					{
						class = new Class746(TransformationType.Fade, 1f, 0f, int_7, int_7 + this.class297_0.method_9(), Enum70.const_0);
						this.class531_1.class26_0.Add(class.Clone());
						this.class538_0.class26_0.Add(class.Clone());
						this.class531_2.class26_0.Add(class.Clone());
						this.class531_0.class26_0.Add(class.Clone());
					}
					this.class531_0.class26_0.Add(new Class746(TransformationType.Scale, 1f, 1.1f, int_7, int_7 + 100, Enum70.const_0));
					return;
				}
				this.vmethod_7();
			}
		}

		// Token: 0x060021F5 RID: 8693
		// RVA: 0x000C8D38 File Offset: 0x000C6F38
		internal override Class304 Clone()
		{
			Class306 class = new Class306(this.class297_0, this.Position, this.StartTime, this.Type.IsType(HitObjectType.NewCombo), this.SoundType.IsType(HitObjectSoundType.Whistle), this.SoundType.IsType(HitObjectSoundType.Finish), this.SoundType.IsType(HitObjectSoundType.Clap), this.int_0);
			class.vector2_0 = this.vector2_0;
			class.vmethod_0(this.Colour);
			class.ComboNumber = this.ComboNumber;
			class.method_3(base.method_2());
			class.sampleSet_0 = this.sampleSet_0;
			class.sampleSet_1 = this.sampleSet_1;
			class.enum38_0 = this.enum38_0;
			class.int_3 = this.int_3;
			class.int_2 = this.int_2;
			class.string_0 = this.string_0;
			return class;
		}

		// Token: 0x060021F0 RID: 8688
		// RVA: 0x0001B4CA File Offset: 0x000196CA
		protected override void Dispose(bool bool_6)
		{
			base.Dispose(bool_6);
		}

		// Token: 0x060021F8 RID: 8696
		// RVA: 0x0001B4DA File Offset: 0x000196DA
		internal override void Select()
		{
			this.class531_3.method_14(50, Enum70.const_0);
		}

		// Token: 0x06002201 RID: 8705
		// RVA: 0x000C9304 File Offset: 0x000C7504
		internal override void vmethod_0(Color color_0)
		{
			if (this.class297_0.class911_0 != null && color_0 != this.Colour)
			{
				this.class531_1.color_0 = color_0;
				this.class531_0.color_0 = color_0;
				if (Class115.osuModes_1 == OsuModes.Edit && !Class341.class606_20)
				{
					if (this.class746_0 != null)
					{
						this.class531_1.class26_0.Remove(this.class746_0);
					}
					this.class531_1.class26_0.Add(this.class746_0 = new Class746(color_0, Color.get_White(), this.StartTime - 5, this.EndTime - 5));
				}
				this.Colour = color_0;
				base.vmethod_0(color_0);
				this.vmethod_1();
			}
		}

		// Token: 0x06002202 RID: 8706
		// RVA: 0x000060D8 File Offset: 0x000042D8
		internal override Enum61 vmethod_17(Vector2 vector2_1)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060021F4 RID: 8692
		// RVA: 0x0001B4D3 File Offset: 0x000196D3
		internal override void vmethod_19(int int_7)
		{
			throw new Exception();
		}

		// Token: 0x060021ED RID: 8685
		// RVA: 0x0001B4C3 File Offset: 0x000196C3
		internal virtual string vmethod_23()
		{
			return "hitcircle";
		}

		// Token: 0x060021F2 RID: 8690
		// RVA: 0x00006D2D File Offset: 0x00004F2D
		protected virtual bool vmethod_24()
		{
			return true;
		}

		// Token: 0x060021F3 RID: 8691
		// RVA: 0x00006D2D File Offset: 0x00004F2D
		protected virtual bool vmethod_25()
		{
			return true;
		}

		// Token: 0x06002203 RID: 8707
		// RVA: 0x0001B53C File Offset: 0x0001973C
		protected virtual float vmethod_26()
		{
			return 1f;
		}

		// Token: 0x060021F9 RID: 8697
		// RVA: 0x0001B4EA File Offset: 0x000196EA
		internal override void vmethod_3()
		{
			this.class531_3.method_16(50, Enum70.const_0);
		}

		// Token: 0x060021F7 RID: 8695
		// RVA: 0x000C8E68 File Offset: 0x000C7068
		internal override void vmethod_4(int int_7)
		{
			int int_8 = int_7 - this.StartTime;
			this.StartTime = int_7;
			this.EndTime = this.StartTime;
			this.class531_0.method_24(int_8);
			this.class531_1.method_24(int_8);
			this.class538_0.method_24(int_8);
			this.class531_2.method_24(int_8);
			this.class531_3.method_24(int_8);
		}

		// Token: 0x060021F6 RID: 8694
		// RVA: 0x000C8E0C File Offset: 0x000C700C
		internal override void vmethod_5(Vector2 vector2_1, bool bool_6)
		{
			base.vmethod_5(vector2_1, bool_6);
			foreach (Class531 current in this.list_1)
			{
				current.vector2_1 = vector2_1;
			}
		}

		// Token: 0x060021FA RID: 8698
		// RVA: 0x000C8ED0 File Offset: 0x000C70D0
		internal override void vmethod_7()
		{
			base.vmethod_7();
			bool flag = Class876.smethod_6(this.class297_0.class623_0, Mods.Hidden);
			bool flag2 = this.vmethod_25() && (!flag || this.class297_0.list_3.Count == 0);
			Class746 class = flag ? new Class746(TransformationType.Fade, 1f, 0f, this.StartTime - (int)((double)this.vmethod_22() * 0.6), this.StartTime - (int)((double)this.vmethod_22() * 0.3), Enum70.const_0)
			{
				byte_0 = 148
			} : new Class746(TransformationType.Fade, 1f, 0f, this.StartTime + this.class297_0.HitWindow100, this.StartTime + this.class297_0.HitWindow50, Enum70.const_0)
			{
				byte_0 = 148
			};
			this.class531_1.class26_0.Add(class.Clone());
			this.class538_0.class26_0.Add(class.Clone());
			this.class531_2.class26_0.Add(class.Clone());
			if (flag2 && flag)
			{
				this.class531_0.class26_0.Add(class.Clone());
			}
			this.class531_1.float_2 = 1f;
			this.class538_0.float_2 = 1f;
			this.class531_2.float_2 = 0.8f;
		}

		// Token: 0x060021FB RID: 8699
		// RVA: 0x000C9048 File Offset: 0x000C7248
		internal override void vmethod_8(bool bool_6)
		{
			base.vmethod_8(bool_6);
			int num = (Class115.osuModes_1 != OsuModes.Edit) ? Class331.int_7 : this.StartTime;
			if (!bool_6)
			{
				bool flag = Class876.smethod_6(this.class297_0.class623_0, Mods.Hidden);
				Class746 class = new Class746(TransformationType.Fade, (!flag) ? this.class531_1.float_3 : 0f, 0f, num, num + 60, Enum70.const_0)
				{
					byte_0 = 148
				};
				this.class531_1.class26_0.Add(class.Clone());
				this.class538_0.class26_0.Add(class.Clone());
				this.class531_2.class26_0.Add(class.Clone());
				this.class531_0.class26_0.Add(class.Clone());
				this.class531_1.float_2 = this.vmethod_26();
				this.class538_0.float_2 = this.vmethod_26();
				this.class531_2.float_2 = 0.8f;
				return;
			}
			Class746 class2 = new Class746(TransformationType.Scale, 1f, 1.4f, num, num + Class297.int_3, Enum70.const_1)
			{
				byte_0 = 148
			};
			Class746 item = new Class746(TransformationType.Scale, 0.8f, 1.12f, num, num + Class297.int_3, Enum70.const_1)
			{
				byte_0 = 148
			};
			Class746 class3 = new Class746(TransformationType.Fade, this.class531_1.float_3, 0f, num, num + Class297.int_3, Enum70.const_0)
			{
				byte_0 = 148
			};
			this.class531_1.class26_0.Add(class2);
			this.class531_1.class26_0.Add(class3);
			this.class538_0.class26_0.Add(class2.Clone());
			this.class538_0.class26_0.Add(class3.Clone());
			this.class531_0.class26_0.Add(new Class746(TransformationType.Fade, this.class531_0.float_3, 0f, num, num, Enum70.const_0)
			{
				byte_0 = 148
			});
			if (Class885.smethod_25())
			{
				this.class531_2.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, num, num + 60, Enum70.const_0)
				{
					byte_0 = 148
				});
				return;
			}
			this.class531_2.class26_0.Add(item);
			this.class531_2.class26_0.Add(class3.Clone());
		}

		// Token: 0x06002200 RID: 8704
		// RVA: 0x0001B502 File Offset: 0x00019702
		internal override bool vmethod_9()
		{
			return Class331.int_7 >= this.StartTime - this.vmethod_22() && Class331.int_7 <= this.EndTime + Class297.int_3 + this.class297_0.method_9();
		}
	}
}
