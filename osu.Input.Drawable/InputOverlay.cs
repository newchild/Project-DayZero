using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns18;
using ns29;
using ns64;
using ns72;
using ns77;
using ns79;
using ns80;
using ns82;
using ns89;
using ns9;
using osu.Graphics.Sprites;
using osu_common;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace osu.Input.Drawable
{
	// Token: 0x020005D4 RID: 1492
	internal sealed class InputOverlay : Class55
	{
		// Token: 0x020005D5 RID: 1493
		private enum ButtonType
		{
			// Token: 0x04002798 RID: 10136
			K1,
			// Token: 0x04002799 RID: 10137
			K2,
			// Token: 0x0400279A RID: 10138
			M1,
			// Token: 0x0400279B RID: 10139
			M2
		}

		// Token: 0x04002791 RID: 10129
		private Class911 class911_0;

		// Token: 0x04002792 RID: 10130
		private Color color_0 = Color.get_White();

		// Token: 0x04002793 RID: 10131
		private Color color_1 = new Color(255, 222, 0);

		// Token: 0x04002794 RID: 10132
		private Color color_2 = new Color(248, 0, 158);

		// Token: 0x04002790 RID: 10128
		private Dictionary<InputOverlay.ButtonType, Class531> dictionary_0 = new Dictionary<InputOverlay.ButtonType, Class531>();

		// Token: 0x04002795 RID: 10133
		private Dictionary<InputOverlay.ButtonType, int> dictionary_1 = new Dictionary<InputOverlay.ButtonType, int>();

		// Token: 0x04002796 RID: 10134
		[CompilerGenerated]
		private static Predicate<Class746> predicate_0;

		// Token: 0x06002F1D RID: 12061
		// RVA: 0x001322EC File Offset: 0x001304EC
		public InputOverlay() : base(Class115.class114_0)
		{
			this.class911_0 = new Class911(true);
			this.Initialize();
		}

		// Token: 0x06002F1E RID: 12062
		// RVA: 0x000233DF File Offset: 0x000215DF
		protected override void Dispose(bool bool_2)
		{
			this.class911_0.Dispose();
			base.Dispose(bool_2);
		}

		// Token: 0x06002F21 RID: 12065
		// RVA: 0x000233F3 File Offset: 0x000215F3
		public override void Draw()
		{
			this.class911_0.Draw();
			base.Draw();
		}

		// Token: 0x06002F22 RID: 12066
		// RVA: 0x001325D4 File Offset: 0x001307D4
		public override void imethod_2()
		{
			bool flag = Class802.smethod_0() || !Class341.class606_43;
			switch (Class62.Mode)
			{
			case PlayModes.Osu:
				this.method_2(InputOverlay.ButtonType.M1, flag && Class802.bool_3 && !Class802.bool_5);
				this.method_2(InputOverlay.ButtonType.M2, flag && Class802.bool_18 && !Class802.bool_20);
				this.method_2(InputOverlay.ButtonType.K1, Class802.bool_3 && Class802.bool_5);
				this.method_2(InputOverlay.ButtonType.K2, Class802.bool_18 && Class802.bool_20);
				break;
			case PlayModes.CatchTheBeat:
			{
				Class431 class = Class62.class62_0.class427_0 as Class431;
				this.method_2(InputOverlay.ButtonType.K1, class.bool_5);
				this.method_2(InputOverlay.ButtonType.K2, class.bool_6);
				this.method_2(InputOverlay.ButtonType.M1, class.bool_4);
				break;
			}
			}
			foreach (Class531 current in this.dictionary_0.Values)
			{
				Class531 class2 = current.object_0 as Class531;
				if (class2 != null)
				{
					class2.float_2 = current.float_2;
				}
			}
			base.imethod_2();
		}

		// Token: 0x06002F1F RID: 12063
		// RVA: 0x00132364 File Offset: 0x00130564
		public override void Initialize()
		{
			int arg_30_0 = Class115.smethod_44() / 2;
			int arg_30_1;
			if (Class64.class10_0 != null)
			{
				if (Class64.class10_0.matchTeamType == MatchTeamTypes.TagTeamVs || Class64.class10_0.matchTeamType == MatchTeamTypes.TeamVs)
				{
					arg_30_1 = 40;
					goto IL_30;
				}
			}
			arg_30_1 = -40;
			IL_30:
			int num = arg_30_0 + arg_30_1;
			Class531 class530_ = new Class531(Class885.Load("inputoverlay-background", Enum112.flag_6), Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2((float)Class115.smethod_43(), (float)num))
			{
				float_1 = 1.5708f,
				vector2_2 = new Vector2(1.05f, 1f),
				bool_0 = true,
				float_0 = 0.9f
			};
			this.class911_0.Add(class530_);
			float num2 = 0f;
			foreach (InputOverlay.ButtonType buttonType in Enum.GetValues(typeof(InputOverlay.ButtonType)))
			{
				Vector2 vector;
				vector..ctor((float)(Class115.smethod_43() - 15), (float)num + 19f + num2);
				string text = this.method_1(buttonType);
				Class531 class = new Class531(Class885.Load("inputoverlay-key", Enum112.flag_6), Enum115.const_5, Origins.Centre, Enum114.const_0, vector)
				{
					bool_0 = true,
					float_0 = 0.98f
				};
				if (string.IsNullOrEmpty(text))
				{
					class.color_0 = Color.get_LightGray();
					class.float_3 = 0.5f;
				}
				this.dictionary_0[buttonType] = class;
				this.class911_0.Add(class);
				if (!string.IsNullOrEmpty(text))
				{
					Class530 arg_1A2_0 = class;
					Class533 class2 = new Class533(text, 14f, vector, 1f, true, Color.get_White());
					class2.origins_0 = Origins.Centre;
					class2.bool_16 = true;
					class2.method_59(true);
					class2.method_57(Color.get_White());
					arg_1A2_0.object_0 = class2;
					if (!Class115.bool_16)
					{
						this.class911_0.Add((Class531)class.object_0);
					}
				}
				num2 += 29.5f;
			}
			base.Initialize();
		}

		// Token: 0x06002F20 RID: 12064
		// RVA: 0x00132584 File Offset: 0x00130784
		private string method_1(InputOverlay.ButtonType buttonType_0)
		{
			PlayModes mode = Class62.Mode;
			if (mode != PlayModes.CatchTheBeat)
			{
				return buttonType_0.ToString();
			}
			switch (buttonType_0)
			{
			case InputOverlay.ButtonType.K1:
				return "L";
			case InputOverlay.ButtonType.K2:
				return "R";
			case InputOverlay.ButtonType.M1:
				return "D";
			default:
				return string.Empty;
			}
		}

		// Token: 0x06002F23 RID: 12067
		// RVA: 0x0013271C File Offset: 0x0013091C
		private void method_2(InputOverlay.ButtonType buttonType_0, bool bool_2)
		{
			Class531 class = this.dictionary_0[buttonType_0];
			int num = bool_2 ? 1 : 0;
			if (class.int_0 == num)
			{
				return;
			}
			class.int_0 = num;
			if (bool_2)
			{
				Class533 class2 = class.object_0 as Class533;
				if (class2 != null && !Class872.bool_1 && !Class62.bool_11 && !Class62.bool_29 && (Class64.class64_0 == null || !Class802.smethod_0()))
				{
					int num2 = 0;
					if (!this.dictionary_1.TryGetValue(buttonType_0, out num2))
					{
						this.dictionary_1[buttonType_0] = 0;
					}
					if (num2 == 1000 || num2 == 100)
					{
						Class533 expr_97 = class2;
						expr_97.method_61(expr_97.method_60() - 1f);
					}
					Dictionary<InputOverlay.ButtonType, int> dictionary;
					class2.Text = ((dictionary = this.dictionary_1)[buttonType_0] = dictionary[buttonType_0] + 1).ToString(Class115.numberFormatInfo_0);
				}
				class.method_39((buttonType_0 == InputOverlay.ButtonType.K1 || buttonType_0 == InputOverlay.ButtonType.K2) ? this.color_1 : this.color_2, 0, false, Enum70.const_0);
				List<Class746> arg_120_0 = class.class26_0;
				if (InputOverlay.predicate_0 == null)
				{
					InputOverlay.predicate_0 = new Predicate<Class746>(InputOverlay.smethod_0);
				}
				arg_120_0.RemoveAll(InputOverlay.predicate_0);
				class.class26_0.Add(new Class746(TransformationType.Scale, 1f, 0.8f, Class115.int_1, Class115.int_1 + 160, Enum70.const_1));
				return;
			}
			class.method_39(this.color_0, 100, false, Enum70.const_0);
			class.class26_0.Add(new Class746(TransformationType.Scale, class.float_2, 1f, Class115.int_1, Class115.int_1 + 160, Enum70.const_1));
		}

		// Token: 0x06002F24 RID: 12068
		// RVA: 0x00018A5A File Offset: 0x00016C5A
		[CompilerGenerated]
		private static bool smethod_0(Class746 class746_0)
		{
			return class746_0.transformationType_0 == TransformationType.Scale;
		}
	}
}
