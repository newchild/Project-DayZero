using Microsoft.Win32;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ns14;
using ns19;
using ns24;
using ns25;
using ns26;
using ns27;
using ns29;
using ns41;
using ns6;
using ns64;
using ns77;
using ns79;
using ns8;
using ns80;
using ns81;
using ns82;
using ns84;
using ns9;
using ns90;
using osu;
using osu.GameModes.Play.Components;
using osu.Graphics.Primitives;
using osu.Graphics.Sprites;
using osu_common;
using osu_common.Helpers;
using osu_common.Updater;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Un4seen.Bass;

namespace ns20
{
	// Token: 0x020003AB RID: 939
	internal sealed class Class80 : Class55
	{
		// Token: 0x020003AC RID: 940
		[CompilerGenerated]
		private sealed class Class403
		{
			// Token: 0x04001731 RID: 5937
			public Class296 class296_0;

			// Token: 0x06001D40 RID: 7488
			// RVA: 0x00018127 File Offset: 0x00016327
			public bool method_0(Class296 class296_1)
			{
				return class296_1.method_3() == this.class296_0.method_3() && (class296_1.submissionStatus_0 == SubmissionStatus.Ranked || class296_1.string_5 == Class341.class605_20);
			}
		}

		// Token: 0x04001720 RID: 5920
		[CompilerGenerated]
		private static Action<Class531> action_0;

		// Token: 0x04001722 RID: 5922
		[CompilerGenerated]
		private static Action<Class390> action_1;

		// Token: 0x04001729 RID: 5929
		[CompilerGenerated]
		private static Action<Class296> action_2;

		// Token: 0x0400172B RID: 5931
		[CompilerGenerated]
		private static Action<Class296> action_3;

		// Token: 0x0400172C RID: 5932
		[CompilerGenerated]
		private static Action<Class390> action_4;

		// Token: 0x04001730 RID: 5936
		[CompilerGenerated]
		private static Action<Class390> action_5;

		// Token: 0x04001707 RID: 5895
		private bool bool_2;

		// Token: 0x04001709 RID: 5897
		private bool bool_3;

		// Token: 0x0400170A RID: 5898
		private bool bool_4;

		// Token: 0x0400170C RID: 5900
		private bool bool_5 = true;

		// Token: 0x0400170D RID: 5901
		private bool bool_6;

		// Token: 0x040016F9 RID: 5881
		private Class110 class110_0;

		// Token: 0x040016FA RID: 5882
		private Class110 class110_1;

		// Token: 0x04001710 RID: 5904
		private Class392 class392_0;

		// Token: 0x04001712 RID: 5906
		private Class393 class393_0;

		// Token: 0x04001717 RID: 5911
		private Class393 class393_1;

		// Token: 0x04001711 RID: 5905
		private Class394 class394_0;

		// Token: 0x0400171D RID: 5917
		private Class394 class394_1;

		// Token: 0x0400171C RID: 5916
		private Class399 class399_0;

		// Token: 0x04001718 RID: 5912
		private Class400 class400_0;

		// Token: 0x04001719 RID: 5913
		private Class400 class400_1;

		// Token: 0x04001703 RID: 5891
		private Class526 class526_0;

		// Token: 0x04001701 RID: 5889
		private Class531 class531_0;

		// Token: 0x04001702 RID: 5890
		private Class531 class531_1;

		// Token: 0x04001714 RID: 5908
		private Class531 class531_2;

		// Token: 0x0400171A RID: 5914
		private Class531 class531_3;

		// Token: 0x04001715 RID: 5909
		private Class533 class533_0;

		// Token: 0x04001716 RID: 5910
		private Class533 class533_1;

		// Token: 0x04001713 RID: 5907
		private Class756 class756_0;

		// Token: 0x040016FD RID: 5885
		private Class911 class911_0;

		// Token: 0x040016FE RID: 5886
		private Class911 class911_1;

		// Token: 0x040016FF RID: 5887
		private Class911 class911_2;

		// Token: 0x04001700 RID: 5888
		private Class911 class911_3;

		// Token: 0x0400172D RID: 5933
		[CompilerGenerated]
		private static Comparison<Size> comparison_0;

		// Token: 0x04001708 RID: 5896
		private Delegate1 delegate1_0;

		// Token: 0x0400171F RID: 5919
		[CompilerGenerated]
		private static EventHandler eventHandler_4;

		// Token: 0x04001724 RID: 5924
		[CompilerGenerated]
		private static EventHandler eventHandler_5;

		// Token: 0x04001725 RID: 5925
		[CompilerGenerated]
		private static EventHandler eventHandler_6;

		// Token: 0x04001726 RID: 5926
		[CompilerGenerated]
		private static EventHandler eventHandler_7;

		// Token: 0x04001727 RID: 5927
		[CompilerGenerated]
		private static EventHandler eventHandler_8;

		// Token: 0x04001704 RID: 5892
		private float float_0;

		// Token: 0x04001705 RID: 5893
		private float float_1;

		// Token: 0x0400170E RID: 5902
		private float float_2 = 40f;

		// Token: 0x0400170F RID: 5903
		private float float_3;

		// Token: 0x040016FB RID: 5883
		private List<Class390> list_0 = new List<Class390>();

		// Token: 0x040016FC RID: 5884
		private List<Class390> list_1 = new List<Class390>();

		// Token: 0x0400170B RID: 5899
		private List<Class404> list_2 = new List<Class404>();

		// Token: 0x04001721 RID: 5921
		[CompilerGenerated]
		private static Predicate<Class530> predicate_0;

		// Token: 0x0400172A RID: 5930
		[CompilerGenerated]
		private static Predicate<Class296> predicate_1;

		// Token: 0x0400172E RID: 5934
		[CompilerGenerated]
		private static Predicate<Size> predicate_2;

		// Token: 0x0400172F RID: 5935
		[CompilerGenerated]
		private static Predicate<Size> predicate_3;

		// Token: 0x04001706 RID: 5894
		private Rectangle rectangle_0;

		// Token: 0x0400171B RID: 5915
		private static Size size_0 = Class787.smethod_4();

		// Token: 0x0400171E RID: 5918
		[CompilerGenerated]
		private static VoidDelegate voidDelegate_0;

		// Token: 0x04001723 RID: 5923
		[CompilerGenerated]
		private static VoidDelegate voidDelegate_1;

		// Token: 0x04001728 RID: 5928
		[CompilerGenerated]
		private static VoidDelegate voidDelegate_2;

		// Token: 0x06001CFE RID: 7422
		// RVA: 0x0009B8F0 File Offset: 0x00099AF0
		internal Class80(Class114 class114_1) : base(class114_1)
		{
			this.class911_2 = new Class911(true);
			this.class911_3 = new Class911(true);
			this.class911_1 = new Class911(true)
			{
				bool_14 = true
			};
			Class110 class = new Class110(new Rectangle(40, 0, Class115.smethod_43(), Class115.smethod_44()), Vector2.get_Zero(), true, 0f, Enum98.const_3);
			class.bool_1 = false;
			class.bool_3 = false;
			class.method_6(true);
			this.class110_0 = class;
			Class110 class2 = new Class110(new Rectangle(0, 0, 40, Class115.smethod_44()), Vector2.get_Zero(), true, 0f, Enum98.const_3);
			class2.bool_2 = true;
			class2.bool_3 = false;
			class2.method_6(true);
			this.class110_1 = class2;
			this.class911_0 = this.class110_0.class911_0;
			this.class911_0.bool_1 = false;
			this.class911_3 = this.class110_1.class911_0;
			this.class911_3.bool_1 = false;
			this.class911_2.bool_14 = true;
		}

		// Token: 0x06001D0C RID: 7436
		// RVA: 0x0009D450 File Offset: 0x0009B650
		private void Add(Class390 class390_0)
		{
			this.list_0.Add(class390_0);
			if (class390_0.vmethod_0() != null)
			{
				foreach (Class390 current in class390_0.vmethod_0())
				{
					current.method_4(new EventHandler(this.method_22));
					this.Add(current);
				}
			}
			Class392 class = class390_0 as Class392;
			if (class != null)
			{
				Class404 class2 = new Class404(class, new EventHandler(this.method_21));
				this.list_2.Add(class2);
				this.class911_3.Add<Class531>(class2.list_0);
			}
			this.class110_0.method_30(class390_0.class911_0);
		}

		// Token: 0x06001D0A RID: 7434
		// RVA: 0x0009D2EC File Offset: 0x0009B4EC
		protected override void Dispose(bool bool_7)
		{
			if (this.class526_0 != null)
			{
				this.class526_0.Dispose();
			}
			this.class110_0.Dispose();
			this.class110_1.Dispose();
			this.class911_2.Dispose();
			this.class911_3.Dispose();
			this.class911_1.Dispose();
			if (this.class756_0 != null)
			{
				this.class756_0.Dispose();
			}
			List<Class390> arg_80_0 = this.list_0;
			if (Class80.action_4 == null)
			{
				Class80.action_4 = new Action<Class390>(Class80.smethod_21);
			}
			arg_80_0.ForEach(Class80.action_4);
			Class809.smethod_7(new EventHandler(this.method_5));
			base.Dispose(bool_7);
		}

		// Token: 0x06001D11 RID: 7441
		// RVA: 0x0009D62C File Offset: 0x0009B82C
		public override void Draw()
		{
			if (!this.bool_2)
			{
				return;
			}
			if (this.class526_0 != null)
			{
				this.class526_0.Draw();
			}
			this.class911_2.Draw();
			this.class110_0.Draw();
			this.class110_1.Draw();
			this.class911_1.Draw();
			base.Draw();
		}

		// Token: 0x06001D12 RID: 7442
		// RVA: 0x0009D68C File Offset: 0x0009B88C
		public override void imethod_2()
		{
			if (!this.bool_2)
			{
				return;
			}
			if (this.class526_0 != null)
			{
				this.class526_0.vmethod_0();
			}
			this.class531_2.float_3 = Math.Min(0.5f, this.class110_0.vector2_3.Y / this.class531_2.float_5);
			float num = (float)(this.method_23() ? (this.rectangle_0.Width + 1) : 0);
			if (Class115.double_0 < 4.0 && (this.float_0 > 0f || this.float_0 != num))
			{
				float num2 = (float)(this.method_23() ? 1 : 0);
				if (this.float_0 != num)
				{
					this.float_0 -= (this.float_0 - num) * 0.1f * (float)Class115.double_0;
					this.float_1 -= (this.float_1 - num2) * 0.1f * (float)Class115.double_0;
					if (this.float_0 < 1f)
					{
						float arg_10C_1 = 0f;
						float num3 = 0f;
						this.float_1 = arg_10C_1;
						this.float_0 = num3;
					}
					this.class110_0.method_32(this.float_1);
					this.class911_1.float_0 = this.float_1;
					this.class110_1.method_32(this.float_1);
					this.class911_2.float_0 = Math.Min(1f, this.float_1 * 4f);
					this.class911_3.float_0 = Math.Min(1f, this.bool_4 ? 0f : (this.float_1 * 4f));
				}
				osu.Graphics.Primitives.RectangleF rectangleF_ = new osu.Graphics.Primitives.RectangleF(40f, 0f, (float)((int)this.float_0), (float)Class115.smethod_44());
				this.class110_0.method_16(rectangleF_);
				osu.Graphics.Primitives.RectangleF rectangleF_2 = new osu.Graphics.Primitives.RectangleF(0f, 0f, (float)((int)this.float_0 + 40), (float)Class115.smethod_44());
				this.class911_2.method_18(rectangleF_2);
				if (Class115.smethod_91() > 30000)
				{
					this.method_24(false);
				}
				if (Class115.bool_13)
				{
					if (Class341.class606_79)
					{
						this.class393_1.method_15(string.Format(Class41.GetString(OsuString.Options_Input_RawInputPoll), (Class800.float_0 > 0.5f) ? Math.Ceiling((double)Class800.float_0) : 0.0, (Class800.int_1 > 0) ? (Class800.int_1 + "ms") : "-"));
					}
					else
					{
						this.class393_1.method_15(Class41.GetString(OsuString.Options_Input_RawInput));
					}
					this.class399_0.method_14(Class214.smethod_1(true));
				}
				bool flag = false;
				foreach (Class390 current in this.list_0)
				{
					if (!current.class911_0.bool_0)
					{
						osu.Graphics.Primitives.RectangleF rectangleF = new osu.Graphics.Primitives.RectangleF(this.float_2 * Class115.float_4, (current.class911_0.vector2_2.Y - current.class911_0.vector2_1.Y - 5f) * Class115.float_4, (274f - this.float_2) * Class115.float_4, (current.method_0().Y + 10f) * Class115.float_4 + (float)Class115.int_25);
						if (rectangleF.Contains(Class800.smethod_15()))
						{
							if (!(current is Class392) && !(current is Class395))
							{
								flag = true;
								this.class531_0.string_0 = current.method_12();
								if (this.class531_3.object_0 != current)
								{
									Class331.smethod_36(null, "click-short", 1f, false);
									this.class531_3.object_0 = current;
									this.class531_3.class26_0.Clear();
									this.class531_3.method_14(100, Enum70.const_0);
									this.class531_3.method_19(new Vector2(0f, current.class911_0.vector2_2.Y - 5f), 140, Enum70.const_30);
									this.class531_3.class26_0.Add(new Class746(TransformationType.VectorScale, this.class531_3.vector2_2, new Vector2(274f, current.method_0().Y + 10f), Class115.int_1, Class115.int_1 + 140, Enum70.const_30));
								}
							}
							break;
						}
					}
				}
				if (!flag)
				{
					this.method_26();
				}
			}
			this.class110_0.imethod_2();
			this.method_25();
			base.imethod_2();
		}

		// Token: 0x06001CFF RID: 7423
		// RVA: 0x0009BA28 File Offset: 0x00099C28
		public override void Initialize()
		{
			if (this.bool_2)
			{
				return;
			}
			this.class756_0 = new Class756(18, new Vector2(0f, 100f), 20, Enum72.const_2);
			this.class756_0.method_3(new Class754.Delegate37(this.method_31));
			this.class756_0.method_25(false);
			this.class531_2 = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_0, Vector2.get_Zero(), 0.95f, true, new Color(8, 8, 8), null);
			this.class531_2.float_3 = 0.7f;
			this.class531_2.float_2 = 1.6f;
			this.class531_2.vector2_2 = new Vector2(274f, 130f);
			this.class531_2.bool_11 = true;
			this.class756_0.list_0.Add(this.class531_2);
			List<Class531> arg_F6_0 = this.class756_0.list_0;
			if (Class80.action_0 == null)
			{
				Class80.action_0 = new Action<Class531>(Class80.smethod_9);
			}
			arg_F6_0.ForEach(Class80.action_0);
			this.class911_0.Add<Class531>(this.class756_0.list_0);
			Class809.smethod_6(new EventHandler(this.method_5));
			SystemEvents.DisplaySettingsChanged += new EventHandler(this.method_19);
			Class341.class605_8.imethod_2(new EventHandler(this.method_32));
			this.class533_0 = new Class533(string.Empty, 20f, new Vector2(0f, 40f), 1f, true, new Color(255, 255, 255, 255));
			this.class533_0.method_58(true);
			this.class533_0.bool_11 = true;
			this.class533_0.float_5 = 90f;
			this.class533_0.origins_0 = Origins.TopCentre;
			this.class533_0.enum115_0 = Enum115.const_6;
			this.class911_0.Add(this.class533_0);
			this.class533_1 = new Class533(string.Empty, 14f, new Vector2(0f, 60f), 1f, true, Class885.color_1);
			this.class533_1.bool_11 = true;
			this.class533_1.method_58(true);
			this.class533_1.float_5 = 90f;
			this.class533_1.origins_0 = Origins.TopCentre;
			this.class533_1.enum115_0 = Enum115.const_6;
			this.class911_0.Add(this.class533_1);
			this.method_11();
			this.class531_0 = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_0, Vector2.get_Zero(), 0.95f, true, new Color(8, 8, 8), null);
			this.class531_0.float_3 = 0.7f;
			this.class531_0.float_2 = 1.6f;
			this.class531_0.bool_2 = true;
			this.class531_0.vector2_2 = new Vector2(314f, (float)Class115.smethod_44());
			this.class531_0.bool_11 = true;
			this.class531_0.bool_1 = true;
			this.class531_0.method_2(new EventHandler(this.method_33));
			this.class911_2.Add(this.class531_0);
			this.class531_1 = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_0, Vector2.get_Zero(), 0.951f, true, new Color(8, 8, 8), null);
			this.class531_1.float_3 = 1f;
			this.class531_1.float_2 = 1.6f;
			this.class531_1.bool_11 = true;
			this.class531_1.vector2_2 = new Vector2(160f, (float)Class115.smethod_44());
			this.class110_1.class911_1.Add(this.class531_1);
			this.class531_3 = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_0, Vector2.get_Zero(), 0f, true, new Color(8, 8, 8), null);
			this.class531_3.float_3 = 0.7f;
			this.class531_3.float_2 = 1.6f;
			this.class531_3.vector2_2 = new Vector2(274f, 0f);
			this.class110_0.class911_1.Add(this.class531_3);
			this.class110_0.method_19();
			this.class110_0.method_16(osu.Graphics.Primitives.RectangleF.Empty);
			this.class911_2.method_18(osu.Graphics.Primitives.RectangleF.Empty);
			this.method_10();
			this.class911_1.Add<Class531>(new Class591(new EventHandler(this.method_34), false, false).list_0);
			this.class110_0.method_17(new Vector2(0f, 200f), 0f);
			Class911 arg_4D7_0 = this.class110_1.class911_1;
			Class911 arg_4D1_0 = this.class911_1;
			Class911 arg_4C5_0 = this.class911_2;
			Class911 arg_4B9_0 = this.class911_3;
			Class911 arg_4AD_0 = this.class911_0;
			float arg_4AD_1 = 0f;
			float num = 0f;
			arg_4AD_0.float_0 = arg_4AD_1;
			float arg_4B9_1 = num;
			float num2 = 0f;
			arg_4B9_0.float_0 = arg_4B9_1;
			float arg_4C5_1 = num2;
			float num3 = 0f;
			arg_4C5_0.float_0 = arg_4C5_1;
			float arg_4D1_1 = num3;
			float num4 = 0f;
			arg_4D1_0.float_0 = arg_4D1_1;
			arg_4D7_0.float_0 = num4;
			base.Initialize();
			this.bool_2 = true;
		}

		// Token: 0x06001CF5 RID: 7413
		// RVA: 0x0009B4B0 File Offset: 0x000996B0
		private Class395 method_1()
		{
			this.class400_0 = null;
			this.class400_1 = null;
			if (!Class809.smethod_4())
			{
				Class395 class = new Class395(OsuString.General_Login);
				class.vmethod_1(new Class399[]
				{
					new Class399(Class41.GetString(OsuString.Options_ClientLocked), null)
				});
				return class;
			}
			if (Class809.bool_3)
			{
				Class395 class2 = new Class395(OsuString.General_Login);
				Class390 arg_9A_0 = class2;
				Class399[] array = new Class399[1];
				Class399[] arg_97_0 = array;
				int arg_97_1 = 0;
				string arg_92_0 = string.Format(Class41.GetString(OsuString.Options_LoggedIn), Class341.class605_20);
				if (Class80.voidDelegate_0 == null)
				{
					Class80.voidDelegate_0 = new VoidDelegate(Class80.smethod_7);
				}
				arg_97_0[arg_97_1] = new Class399(arg_92_0, Class80.voidDelegate_0);
				arg_9A_0.vmethod_1(array);
				return class2;
			}
			if (Class115.smethod_33())
			{
				Class395 class3 = new Class395(OsuString.General_Login);
				class3.vmethod_1(new Class390[]
				{
					new Class398()
				});
				return class3;
			}
			Class809.bool_14 = true;
			Class395 class4 = new Class395(OsuString.General_Login);
			Class390 arg_1B5_0 = class4;
			Class390[] array2 = new Class390[6];
			array2[0] = (this.class400_0 = new Class400(OsuString.Options_Username, Class341.class605_20, false));
			array2[1] = (this.class400_1 = new Class400(OsuString.Options_Password, true));
			array2[2] = new Class393(Class41.GetString(OsuString.Options_RememberUsername), string.Empty, Class341.class606_52, null);
			array2[3] = new Class393(Class41.GetString(OsuString.Options_RememberPassword), string.Empty, Class341.class606_51, null);
			array2[4] = new Class391(OsuString.General_Login, Class885.color_3, new EventHandler(this.method_28));
			Class390[] arg_1B2_0 = array2;
			int arg_1B2_1 = 5;
			string arg_1AD_0 = Class41.GetString(OsuString.Options_CreateAnAccount);
			Color arg_1AD_1 = Class885.color_3;
			if (Class80.eventHandler_4 == null)
			{
				Class80.eventHandler_4 = new EventHandler(Class80.smethod_8);
			}
			arg_1B2_0[arg_1B2_1] = new Class391(arg_1AD_0, arg_1AD_1, Class80.eventHandler_4);
			arg_1B5_0.vmethod_1(array2);
			Class395 result = class4;
			this.class400_0.class754_0.textInputControl_0.method_11(new KeyEventHandler(this.method_2));
			this.class400_1.class754_0.textInputControl_0.method_11(new KeyEventHandler(this.method_2));
			return result;
		}

		// Token: 0x06001D00 RID: 7424
		// RVA: 0x00017E3A File Offset: 0x0001603A
		private void method_10()
		{
			Class115.class47_0.method_2(new VoidDelegate(this.method_35));
		}

		// Token: 0x06001D01 RID: 7425
		// RVA: 0x0009BF20 File Offset: 0x0009A120
		private void method_11()
		{
			this.class533_0.Text = Class41.GetString(OsuString.Options_Options);
			this.class533_1.Text = Class41.GetString(OsuString.Options_HeaderBlurb);
			this.class756_0.method_27(Class41.GetString(OsuString.SongSelection_TypeToBegin));
			if (this.bool_4)
			{
				Class392 class = new Class392(OsuString.Options_General, FontAwesome.gear);
				class.vmethod_1(new Class395[]
				{
					this.method_1()
				});
				this.Add(class);
				this.class756_0.vmethod_6(false);
				if (this.class400_0 != null)
				{
					if (this.class400_0.class754_0.Text == string.Empty)
					{
						this.class400_0.method_15();
						return;
					}
					this.class400_1.method_15();
				}
				return;
			}
			this.class756_0.vmethod_6(true);
			Class392 class2 = new Class392(OsuString.Options_General, FontAwesome.gear);
			Class390 arg_485_0 = class2;
			Class390[] array = new Class390[3];
			array[0] = this.method_1();
			Class390[] arg_3F0_0 = array;
			int arg_3F0_1 = 1;
			Class395 class3 = new Class395(OsuString.Options_Graphics_Language);
			class3.method_7(true);
			class3.vmethod_1(new Class390[]
			{
				new Class394(OsuString.Options_Graphics_SelectLanguage, new Class557[]
				{
					new Class557("English", "en"),
					new Class557("中文(简体)", "zh-CHS"),
					new Class557("中文(繁體)", "zh-CHT"),
					new Class557("日本語", "ja"),
					new Class557("한국어", "ko"),
					new Class557("Česky", "cz"),
					new Class557("Dansk", "da"),
					new Class557("Deutsch", "de"),
					new Class557("Español", "es"),
					new Class557("Français", "fr"),
					new Class557("Български", "bg"),
					new Class557("Ελληνικά", "el"),
					new Class557("Suomi", "fi"),
					new Class557("עברית", "he"),
					new Class557("Hrvatski", "hr"),
					new Class557("Bahasa Indonesia", "id"),
					new Class557("Italiano", "it"),
					new Class557("Magyar", "hu"),
					new Class557("Mongɣol kele", "mn"),
					new Class557("Bahasa Malaysia", "ms-MY"),
					new Class557("Nederlands", "nl"),
					new Class557("Norsk", "no"),
					new Class557("latviešu valoda", "lv"),
					new Class557("Polski", "pl"),
					new Class557("Português (Brasil)", "br"),
					new Class557("Português (Portugal)", "pt"),
					new Class557("Русский", "ru"),
					new Class557("Slovenčina", "sk"),
					new Class557("Slovenščina", "sl"),
					new Class557("Svenska", "sv"),
					new Class557("ภาษาไทย", "th"),
					new Class557("Türkçe", "tr"),
					new Class557("Tiếng Việt", "vi-VN"),
					new Class557("Українська", "uk-UA")
				}, Class341.class605_3, null),
				new Class393(OsuString.Option_Graphics_ShowUnicode, Class341.class606_58, null),
				new Class393(OsuString.Options_Language_Font_Override, Class341.class606_83, null)
			});
			arg_3F0_0[arg_3F0_1] = class3;
			Class390[] arg_482_0 = array;
			int arg_482_1 = 2;
			Class395 class4 = new Class395(OsuString.Options_Updates);
			Class390 arg_47B_0 = class4;
			Class390[] array2 = new Class390[3];
			array2[0] = new Class394(OsuString.Options_ReleaseStream, Class80.smethod_5(), Class341.class605_25, null);
			Class390[] arg_459_0 = array2;
			int arg_459_1 = 1;
			string arg_44A_0 = Class214.smethod_1(false);
			if (Class80.voidDelegate_1 == null)
			{
				Class80.voidDelegate_1 = new VoidDelegate(Class80.smethod_12);
			}
			arg_459_0[arg_459_1] = (this.class399_0 = new Class399(arg_44A_0, Class80.voidDelegate_1));
			array2[2] = new Class391(OsuString.Options_OpenOsuFolder, Class885.color_3, new EventHandler(this.method_13));
			arg_47B_0.vmethod_1(array2);
			arg_482_0[arg_482_1] = class4;
			arg_485_0.vmethod_1(array);
			this.Add(class2);
			Class392 class5 = new Class392(OsuString.Options_TabGraphics, FontAwesome.desktop);
			Class390 arg_767_0 = class5;
			Class395[] array3 = new Class395[5];
			Class395[] arg_54A_0 = array3;
			int arg_54A_1 = 0;
			Class395 class6 = new Class395(OsuString.Options_Graphics_Renderer);
			Class390 arg_543_0 = class6;
			Class390[] array4 = new Class390[4];
			Class390[] arg_4E6_0 = array4;
			int arg_4E6_1 = 0;
			Class393 class7 = new Class393("OpenGL", Class41.GetString(OsuString.Options_Graphics_OpenGl_Tooltip), Class341.class606_80, null);
			class7.method_7(true);
			arg_4E6_0[arg_4E6_1] = class7;
			Class390[] arg_50D_0 = array4;
			int arg_50D_1 = 1;
			Class393 class8 = new Class393("DirectX", Class41.GetString(OsuString.Options_Graphics_DirectX_Tooltip), Class341.class606_81, null);
			class8.method_7(true);
			arg_50D_0[arg_50D_1] = class8;
			Class390[] arg_52F_0 = array4;
			int arg_52F_1 = 2;
			Class394 class9 = new Class394(OsuString.Options_Graphics_FrameLimiter, Class80.smethod_6(), Class341.class605_26, null);
			class9.method_7(true);
			arg_52F_0[arg_52F_1] = class9;
			array4[3] = new Class393(OsuString.Options_Graphics_FpsCounter, Class341.class606_27, null);
			arg_543_0.vmethod_1(array4);
			arg_54A_0[arg_54A_1] = class6;
			Class395[] arg_5C5_0 = array3;
			int arg_5C5_1 = 1;
			Class395 class10 = new Class395(OsuString.Options_Graphics_ScreenResolution);
			class10.method_7(true);
			Class390 arg_5BE_0 = class10;
			Class390[] array5 = new Class390[2];
			array5[0] = (this.class394_0 = new Class394(OsuString.Options_Graphics_SelectResolution, null, null, new EventHandler(this.method_18)));
			Class390[] arg_5BB_0 = array5;
			int arg_5BB_1 = 1;
			Class393 class11 = new Class393(OsuString.Options_Graphics_Fullscreen, Class341.class606_74, null);
			class11.method_17(!Class115.bool_27);
			arg_5BB_0[arg_5BB_1] = (this.class393_0 = class11);
			arg_5BE_0.vmethod_1(array5);
			arg_5C5_0[arg_5C5_1] = class10;
			Class395[] arg_6A6_0 = array3;
			int arg_6A6_1 = 2;
			Class395 class12 = new Class395(OsuString.Options_Graphics_Detail);
			class12.vmethod_1(new Class390[]
			{
				new Class393(OsuString.Options_Graphics_Snaking, Class341.class606_61, null),
				new Class393(OsuString.Options_Graphics_Video, Class341.class606_69, null),
				new Class393(OsuString.Options_Graphics_Storyboards, Class341.class606_56, null),
				new Class393(OsuString.Options_Graphics_Combo, Class341.class606_12, null),
				new Class393(OsuString.Options_Graphics_HitLighting, Class341.class606_29, null),
				new Class393(OsuString.Options_Graphics_Shader, Class341.class606_4, null),
				new Class393(OsuString.Options_Graphics_Softening, Class341.class606_5, null),
				new Class394(OsuString.Options_Graphics_Screenshot, new Class557[]
				{
					new Class557(Class41.GetString(OsuString.Options_Graphics_Screenshot1), 3),
					new Class557(Class41.GetString(OsuString.Options_Graphics_Screenshot2), 1)
				}, Class341.class605_4, null)
			});
			arg_6A6_0[arg_6A6_1] = class12;
			Class395[] arg_72D_0 = array3;
			int arg_72D_1 = 3;
			Class395 class13 = new Class395(OsuString.Options_Graphics_Menu);
			class13.vmethod_1(new Class390[]
			{
				new Class393(OsuString.Options_Menu_Snow, Class341.class606_76, null),
				new Class393(OsuString.Options_Menu_Parallax, Class341.class606_57, null),
				new Class393(OsuString.Options_Menu_ShowTips, Class341.class606_82, null),
				new Class393(OsuString.Options_Menu_Voice, Class341.class606_85, null),
				new Class393(OsuString.Options_Menu_Music, Class341.class606_84, null)
			});
			arg_72D_0[arg_72D_1] = class13;
			Class395[] arg_764_0 = array3;
			int arg_764_1 = 4;
			Class395 class14 = new Class395(OsuString.Options_SongSelect);
			class14.vmethod_1(new Class390[]
			{
				new Class393(OsuString.Options_SongSelect_Thumbnails, Class341.class606_78, null)
			});
			arg_764_0[arg_764_1] = class14;
			arg_767_0.vmethod_1(array3);
			this.Add(class5);
			Class80.smethod_4(this.class394_0.class753_0);
			Class392 class15 = new Class392(OsuString.Options_TabGameplay, FontAwesome.circle_o);
			Class390 arg_91F_0 = class15;
			Class395[] array6 = new Class395[1];
			Class395[] arg_91C_0 = array6;
			int arg_91C_1 = 0;
			Class395 class16 = new Class395(OsuString.Options_General);
			class16.vmethod_1(new Class390[]
			{
				new Class397(OsuString.FunSpoiler_BackgroundDim, Class341.class608_1, "%", true),
				new Class394(OsuString.Options_Graphics_Progress, new Class557[]
				{
					new Class557(Class41.GetString(OsuString.Options_Graphics_Progress1), ProgressBarTypes.Pie),
					new Class557(Class41.GetString(OsuString.Options_Graphics_Progress2), ProgressBarTypes.TopRight),
					new Class557(Class41.GetString(OsuString.Options_Graphics_Progress3), ProgressBarTypes.BottomRight),
					new Class557(Class41.GetString(OsuString.Options_Graphics_Progress4), ProgressBarTypes.Bottom)
				}, Class341.class605_2, null),
				new Class394(OsuString.Options_TabSkin_ScoreMeter, new Class557[]
				{
					new Class557(Class41.GetString(OsuString.Options_Graphics_Meter0), ScoreMeterType.None),
					new Class557(Class41.GetString(OsuString.General_Colour), ScoreMeterType.Colour),
					new Class557(Class41.GetString(OsuString.Options_Graphics_Meter2), ScoreMeterType.Error)
				}, Class341.class605_7, null),
				new Class397(OsuString.Options_ScoreMeterScale, Class341.class607_4, "x", true),
				new Class393(OsuString.Options_KeyOverlay, Class341.class606_34, null),
				new Class393(OsuString.Options_Gameplay_Hidden_Approach, Class341.class606_86, null),
				new Class393(OsuString.Options_ScaleManiaSpeedWithBPM, Class341.class606_73, null),
				new Class393(OsuString.Options_UsePerBeatmapManiaSpeed, Class341.class606_72, null)
			});
			arg_91C_0[arg_91C_1] = class16;
			arg_91F_0.vmethod_1(array6);
			this.Add(class15);
			Class392 class17 = new Class392(OsuString.Options_TabAudio, FontAwesome.volume_off);
			Class390 arg_A68_0 = class17;
			Class395[] array7 = new Class395[3];
			Class395[] arg_986_0 = array7;
			int arg_986_1 = 0;
			Class395 class18 = new Class395(OsuString.Options_Audio_Device);
			class18.vmethod_1(new Class390[]
			{
				this.class394_1 = new Class394(OsuString.Options_Audio_AudioDevice, null, Class341.class605_12, null)
			});
			arg_986_0[arg_986_1] = class18;
			Class395[] arg_9F9_0 = array7;
			int arg_9F9_1 = 1;
			Class395 class19 = new Class395(OsuString.Options_Audio_Volume);
			class19.vmethod_1(new Class390[]
			{
				new Class397(OsuString.Options_Audio_Master, Class331.class608_2, "%", true),
				new Class397(OsuString.Options_Audio_Music, Class331.class608_1, "%", true),
				new Class397(OsuString.Options_Audio_Effect, Class331.class608_0, "%", true),
				new Class393(OsuString.FunSpoiler_Hitsounds, Class341.class606_31, null)
			});
			arg_9F9_0[arg_9F9_1] = class19;
			Class395[] arg_A65_0 = array7;
			int arg_A65_1 = 2;
			Class395 class20 = new Class395(OsuString.Options_Audio_Offset);
			class20.method_7(true);
			Class390 arg_A5E_0 = class20;
			array = new Class390[2];
			array[0] = new Class397(OsuString.OptionsOffsetWizard_UniversalOffset, Class341.class608_9, "ms", true);
			Class390[] arg_A5B_0 = array;
			int arg_A5B_1 = 1;
			OsuString arg_A56_0 = OsuString.Options_Audio_OffsetWizard;
			Color arg_A56_1 = Class885.color_3;
			if (Class80.eventHandler_5 == null)
			{
				Class80.eventHandler_5 = new EventHandler(Class80.smethod_13);
			}
			arg_A5B_0[arg_A5B_1] = new Class391(arg_A56_0, arg_A56_1, Class80.eventHandler_5);
			arg_A5E_0.vmethod_1(array);
			arg_A65_0[arg_A65_1] = class20;
			arg_A68_0.vmethod_1(array7);
			this.Add(class17);
			this.method_12();
			Class331.smethod_103(new VoidDelegate(this.method_36));
			List<Class557> list = new List<Class557>();
			foreach (string current in Class885.list_0)
			{
				list.Add(new Class557(current, current));
			}
			Class392 class21 = new Class392(OsuString.Options_TabSkin, FontAwesome.fa_paint_brush);
			Class390 arg_C55_0 = class21;
			Class395[] array8 = new Class395[1];
			Class395[] arg_C52_0 = array8;
			int arg_C52_1 = 0;
			Class395 class22 = new Class395(OsuString.Options_Skin);
			Class390 arg_C4B_0 = class22;
			array = new Class390[11];
			array[0] = new Class396();
			Class390[] arg_B3D_0 = array;
			int arg_B3D_1 = 1;
			OsuString arg_B38_0 = OsuString.Options_SkinSelect;
			IEnumerable<Class557> arg_B38_1 = list;
			Interface18 arg_B38_2 = Class341.class605_19;
			if (Class80.eventHandler_6 == null)
			{
				Class80.eventHandler_6 = new EventHandler(Class80.smethod_14);
			}
			arg_B3D_0[arg_B3D_1] = new Class394(arg_B38_0, arg_B38_1, arg_B38_2, Class80.eventHandler_6);
			Class390[] arg_B79_0 = array;
			int arg_B79_1 = 2;
			OsuString arg_B68_0 = OsuString.Options_OpenSkinFolder;
			Color arg_B68_1 = Class885.color_3;
			if (Class80.eventHandler_7 == null)
			{
				Class80.eventHandler_7 = new EventHandler(Class80.smethod_15);
			}
			Class391 class23 = new Class391(arg_B68_0, arg_B68_1, Class80.eventHandler_7);
			class23.method_7(true);
			arg_B79_0[arg_B79_1] = class23;
			Class390[] arg_BB5_0 = array;
			int arg_BB5_1 = 3;
			OsuString arg_BA4_0 = OsuString.OptionsSkin_ExportAsOsk;
			Color arg_BA4_1 = Class885.color_3;
			if (Class80.eventHandler_8 == null)
			{
				Class80.eventHandler_8 = new EventHandler(Class80.smethod_16);
			}
			Class391 class24 = new Class391(arg_BA4_0, arg_BA4_1, Class80.eventHandler_8);
			class24.method_7(true);
			arg_BB5_0[arg_BB5_1] = class24;
			array[4] = new Class393(OsuString.Options_TabSkin_IgnoreBeatmapSkins, Class341.class606_32, null);
			array[5] = new Class393(OsuString.Options_UseSkinSamples, Class341.class606_59, null);
			array[6] = new Class393(OsuString.Options_UseTaikoSkin, Class341.class606_66, null);
			array[7] = new Class393(OsuString.Options_UseSkinCursor, Class341.class606_65, null);
			array[8] = new Class397(OsuString.Options_CursorSize, Class341.class607_0, "x", true);
			array[9] = new Class393(OsuString.Options_AutomaticCursorSizing, Class341.class606_68, null);
			array[10] = new Class393(OsuString.Options_ComboColourSliderBall, Class341.class606_8, null);
			arg_C4B_0.vmethod_1(array);
			arg_C52_0[arg_C52_1] = class22;
			arg_C55_0.vmethod_1(array8);
			this.Add(class21);
			Class392 class25 = new Class392(OsuString.Options_TabInput, FontAwesome.gamepad);
			Class390 arg_DD5_0 = class25;
			array8 = new Class395[3];
			Class395[] arg_D1B_0 = array8;
			int arg_D1B_1 = 0;
			Class395 class26 = new Class395(OsuString.Options_Input_Mouse);
			class26.vmethod_1(new Class390[]
			{
				new Class397(OsuString.Options_Input_MouseSensitivity, Class341.class607_3, "x", false),
				this.class393_1 = new Class393(OsuString.Options_Input_RawInput, Class341.class606_79, null),
				new Class393(OsuString.Options_Input_AbsoluteToOsuWindow, Class341.class606_87, null),
				new Class393(OsuString.Options_Input_DisableWheel, Class341.class606_44, null),
				new Class393(OsuString.Options_Input_DisableButtons, Class341.class606_43, null),
				new Class393(OsuString.Options_Input_CursorRipples, Class341.class606_23, null)
			});
			arg_D1B_0[arg_D1B_1] = class26;
			Class395[] arg_D79_0 = array8;
			int arg_D79_1 = 1;
			Class395 class27 = new Class395(OsuString.Options_Input_Keyboard);
			class27.vmethod_1(new Class390[]
			{
				new Class391(OsuString.Options_Input_KeyBindings, Class885.color_3, new EventHandler(this.method_37)),
				new Class391(OsuString.Options_OsuManiaLayout, Class885.color_3, new EventHandler(this.method_38))
			});
			arg_D79_0[arg_D79_1] = class27;
			Class395[] arg_DD2_0 = array8;
			int arg_DD2_1 = 2;
			Class395 class28 = new Class395(OsuString.Options_Input_Other);
			class28.vmethod_1(new Class390[]
			{
				new Class393(OsuString.Options_Input_Tablet, Class341.class606_62, null),
				new Class393(OsuString.Options_Input_Joystick, Class341.class606_33, null),
				new Class393(OsuString.Options_Input_Wii, Class341.class606_70, null)
			});
			arg_DD2_0[arg_DD2_1] = class28;
			arg_DD5_0.vmethod_1(array8);
			this.Add(class25);
			Class392 class29 = new Class392(OsuString.Options_Editor, FontAwesome.pencil);
			Class390 arg_EAB_0 = class29;
			array8 = new Class395[1];
			Class395[] arg_EA8_0 = array8;
			int arg_EA8_1 = 0;
			Class395 class30 = new Class395(OsuString.Options_General);
			class30.vmethod_1(new Class390[]
			{
				new Class393(OsuString.Options_Editor_Video, Class341.class606_17, null),
				new Class393(OsuString.Options_Editor_DefaultSkin, Class341.class606_18, null),
				new Class393(OsuString.Options_Editor_NoUndo, Class341.class606_25, null),
				new Class393(OsuString.Options_Editor_Snaking_Sliders, Class341.class606_19, null),
				new Class393(OsuString.Options_Editor_Hit_Animations, Class341.class606_20, null),
				new Class393(OsuString.Options_Editor_Follow_Points, Class341.class606_21, null),
				new Class393(OsuString.Options_Editor_Stacking, Class341.class606_22, null)
			});
			arg_EA8_0[arg_EA8_1] = class30;
			arg_EAB_0.vmethod_1(array8);
			this.Add(class29);
			Class392 class31 = new Class392(OsuString.Options_TabOnline, FontAwesome.globe);
			Class390 arg_1080_0 = class31;
			array8 = new Class395[3];
			Class395[] arg_FA1_0 = array8;
			int arg_FA1_1 = 0;
			Class395 class32 = new Class395(OsuString.Options_Online_AlertsPrivacy);
			class32.vmethod_1(new Class390[]
			{
				new Class393(OsuString.Options_Online_ShowChatTicker, Class341.class606_63, null),
				new Class393(OsuString.Options_Online_HideChat, Class341.class606_2, null),
				new Class393(OsuString.Options_Online_ChatHighlight, Class341.class606_10, null),
				new Class393(OsuString.Options_Online_ChatAudibleHighlight, Class341.class606_7, null),
				new Class393(OsuString.Options_Online_DisplayCityLocation, Class341.class606_15, null),
				new Class393(OsuString.Options_Online_ShowSpectators, Class341.class606_55, null),
				new Class393(OsuString.Options_Online_AutoNP, Class341.class606_67, null),
				new Class393(OsuString.Options_Online_PopupDuringGameplay, Class341.class606_50, null),
				new Class393(OsuString.Options_Online_NotifyFriends, Class341.class606_47, null),
				new Class393(OsuString.Options_Online_AllowPublicInvites, Class341.class606_1, null)
			});
			arg_FA1_0[arg_FA1_1] = class32;
			Class395[] arg_FF7_0 = array8;
			int arg_FF7_1 = 1;
			Class395 class33 = new Class395(OsuString.Options_Online_Integration);
			class33.vmethod_1(new Class393[]
			{
				new Class393(OsuString.Options_Online_YahooIntegration, Class341.class606_71, null),
				new Class393(OsuString.Options_Online_MsnIntegration, Class341.class606_45, null),
				new Class393(OsuString.Options_Online_AutomaticDownload, Class341.class606_3, null)
			});
			arg_FF7_0[arg_FF7_1] = class33;
			Class395[] arg_107D_0 = array8;
			int arg_107D_1 = 2;
			Class395 class34 = new Class395(OsuString.Options_Online_InGameChat);
			class34.vmethod_1(new Class390[]
			{
				new Class393(OsuString.Options_Online_ChatFilter, Class341.class606_9, null),
				new Class393(OsuString.Options_Online_ChatRemoveForeign, Class341.class606_11, null),
				new Class393(OsuString.Options_Online_LogPrivateMessages, Class341.class606_41, null),
				new Class393(OsuString.Options_Online_BlockNonFriendPM, Class341.class606_0, null),
				new Class400(OsuString.Options_Online_ChatIgnoreList, Class341.class605_14, false),
				new Class400(OsuString.Options_Online_ChatHighlights, Class341.class605_13, false)
			});
			arg_107D_0[arg_107D_1] = class34;
			arg_1080_0.vmethod_1(array8);
			this.Add(class31);
			Class392 class35 = new Class392(OsuString.Options_TabMaintenance, FontAwesome.wrench);
			class35.method_7(true);
			Class390 arg_1145_0 = class35;
			array8 = new Class395[1];
			Class395[] arg_1142_0 = array8;
			int arg_1142_1 = 0;
			Class395 class36 = new Class395(OsuString.Options_General);
			class36.vmethod_1(new Class390[]
			{
				new Class391(OsuString.Options_DeleteAllUnrankedMaps, Class885.color_3, new EventHandler(this.method_17)),
				new Class391(OsuString.Options_ForceFolderPermissions, Class885.color_3, new EventHandler(this.method_16)),
				new Class391(OsuString.Options_MarkMapsPlayed, Class885.color_3, new EventHandler(this.method_15)),
				new Class391(OsuString.Options_RunUpdater, Class885.color_3, new EventHandler(this.method_14))
			});
			arg_1142_0[arg_1142_1] = class36;
			arg_1145_0.vmethod_1(array8);
			this.Add(class35);
			this.Add(new Class401(Class344.smethod_0()));
			for (int i = this.class110_0.list_0.Count - 1; i >= 0; i--)
			{
				this.class110_0.list_0[i].method_6();
			}
			this.class110_0.class911_0.method_6();
			this.class110_1.class911_0.method_6();
		}

		// Token: 0x06001D02 RID: 7426
		// RVA: 0x0009D0F4 File Offset: 0x0009B2F4
		private void method_12()
		{
			this.class394_1.class753_0.method_12();
			this.class394_1.class753_0.method_9(Class41.GetString(OsuString.General_Default), string.Empty);
			foreach (BASS_DEVICEINFO current in Class331.list_2)
			{
				if (current.get_IsEnabled() && current.driver != null)
				{
					this.class394_1.class753_0.method_9(current.name, current.name);
				}
			}
			if (!this.class394_1.class753_0.method_18(Class341.class605_12.Value, true))
			{
				this.class394_1.class753_0.method_18(string.Empty, true);
			}
		}

		// Token: 0x06001D03 RID: 7427
		// RVA: 0x00017E53 File Offset: 0x00016053
		private void method_13(object sender, EventArgs e)
		{
			Class115.smethod_83(Environment.CurrentDirectory);
		}

		// Token: 0x06001D04 RID: 7428
		// RVA: 0x00017E5F File Offset: 0x0001605F
		private void method_14(object sender, EventArgs e)
		{
			Class115.smethod_70(OsuModes.Update, false);
		}

		// Token: 0x06001D05 RID: 7429
		// RVA: 0x00017E68 File Offset: 0x00016068
		private void method_15(object sender, EventArgs e)
		{
			List<Class296> arg_22_0 = Class466.list_3;
			if (Class80.action_2 == null)
			{
				Class80.action_2 = new Action<Class296>(Class80.smethod_18);
			}
			arg_22_0.ForEach(Class80.action_2);
			Class723.smethod_5(Class41.GetString(OsuString.Options_MarkMapsPlayed_Success), Color.get_YellowGreen(), 4000, null);
		}

		// Token: 0x06001D06 RID: 7430
		// RVA: 0x00017EA8 File Offset: 0x000160A8
		private void method_16(object sender, EventArgs e)
		{
			Class115.smethod_31(false);
			Class723.smethod_5(Class41.GetString(OsuString.Options_ForceFolderPermissions_Successful), Color.get_YellowGreen(), 4000, null);
		}

		// Token: 0x06001D07 RID: 7431
		// RVA: 0x0009D1D4 File Offset: 0x0009B3D4
		private void method_17(object sender, EventArgs e)
		{
			List<Class296> arg_22_0 = Class466.list_3;
			if (Class80.predicate_1 == null)
			{
				Class80.predicate_1 = new Predicate<Class296>(Class80.smethod_19);
			}
			List<Class296> list = arg_22_0.FindAll(Class80.predicate_1);
			Class115.smethod_6(true);
			if (MessageBox.Show(string.Format(Class41.GetString(OsuString.Options_DeleteWarning), list.Count), "osu!", MessageBoxButtons.OKCancel) == DialogResult.OK)
			{
				List<Class296> arg_71_0 = list;
				if (Class80.action_3 == null)
				{
					Class80.action_3 = new Action<Class296>(Class80.smethod_20);
				}
				arg_71_0.ForEach(Class80.action_3);
				Class77.smethod_1(false);
			}
			Class115.smethod_6(false);
			Class466.smethod_21(null);
		}

		// Token: 0x06001D08 RID: 7432
		// RVA: 0x0009D26C File Offset: 0x0009B46C
		private void method_18(object sender, EventArgs e)
		{
			string text = sender as string;
			if (text != null && !(text == Class41.GetString(OsuString.Options_Graphics_CustomResolution)))
			{
				string[] array = text.Split(new char[]
				{
					'x'
				});
				int value = int.Parse(array[0]);
				int value2 = int.Parse(array[1]);
				Class115.smethod_20(new int?(value), new int?(value2), null, true, false);
				return;
			}
			Class80.smethod_4(this.class394_0.class753_0);
		}

		// Token: 0x06001D09 RID: 7433
		// RVA: 0x00017EC7 File Offset: 0x000160C7
		private void method_19(object sender, EventArgs e)
		{
			Class115.class47_0.Add(new VoidDelegate(this.method_41), false);
		}

		// Token: 0x06001CF6 RID: 7414
		// RVA: 0x00017DFE File Offset: 0x00015FFE
		private void method_2(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Return)
			{
				return;
			}
			this.method_3();
		}

		// Token: 0x06001D0B RID: 7435
		// RVA: 0x0009D398 File Offset: 0x0009B598
		internal bool method_20(object object_0, Keys keys_0, bool bool_7)
		{
			if (bool_7)
			{
				if (keys_0 != 9)
				{
					if (keys_0 == 27)
					{
						if (!this.class756_0.method_29())
						{
							this.class756_0.method_28();
						}
						else if (this.method_7())
						{
							this.method_8(false);
						}
						else if (this.method_23())
						{
							this.method_24(false);
						}
						return true;
					}
				}
				else
				{
					if (this.class400_0 != null && this.class400_1 != null)
					{
						if (this.class400_0.class754_0.textInputControl_0.Focused)
						{
							this.class400_0.method_16();
							this.class400_1.method_15();
						}
						else
						{
							this.class400_1.method_16();
							this.class400_0.method_15();
						}
						return true;
					}
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001D0D RID: 7437
		// RVA: 0x0009D510 File Offset: 0x0009B710
		private void method_21(object sender, EventArgs e)
		{
			Class531 class = sender as Class531;
			if (class == null)
			{
				return;
			}
			Class390 class2 = class.object_0 as Class390;
			if (class2 == null)
			{
				return;
			}
			Class331.smethod_36(null, "select-expand", 1f, false);
			this.class110_0.method_23(Class778.smethod_2(class2.float_0 - (float)(Class115.smethod_44() / 10), 0f, Math.Max(0f, this.class110_0.vector2_2.Y - this.class110_0.method_3())), -0.99f);
		}

		// Token: 0x06001D0E RID: 7438
		// RVA: 0x00017EE0 File Offset: 0x000160E0
		private void method_22(object sender, EventArgs e)
		{
			this.method_10();
		}

		// Token: 0x06001D0F RID: 7439
		// RVA: 0x00017EE8 File Offset: 0x000160E8
		public bool method_23()
		{
			return this.bool_6;
		}

		// Token: 0x06001D10 RID: 7440
		// RVA: 0x0009D5A4 File Offset: 0x0009B7A4
		public void method_24(bool bool_7)
		{
			if (bool_7 == this.bool_6)
			{
				return;
			}
			if (!this.bool_2)
			{
				this.Initialize();
			}
			this.bool_6 = bool_7;
			if (bool_7)
			{
				if (Class111.bool_2)
				{
					Class111.smethod_21(false);
				}
				this.class110_0.method_18();
				this.method_10();
				if (this.bool_5)
				{
					this.class110_0.method_23(-100f, 0.5f);
				}
				this.bool_5 = false;
			}
			else
			{
				this.method_8(false);
			}
			this.class756_0.method_25(bool_7);
		}

		// Token: 0x06001D13 RID: 7443
		// RVA: 0x0009DB60 File Offset: 0x0009BD60
		private void method_25()
		{
			float num = this.float_2;
			float num2 = (float)((Class800.smethod_17().X >= 40f || this.class110_1.class911_0.class531_1 == null) ? 40 : 160);
			if (this.float_3 > 0f)
			{
				if (num2 != num && (num2 == 40f || (!this.class110_0.vmethod_0() && Class115.smethod_91() > 200)))
				{
					this.float_3 -= (float)Class115.double_9;
				}
			}
			else
			{
				num = num2;
			}
			if (this.float_2 != num)
			{
				float num3 = this.float_2 - num;
				this.float_2 = num + num3 * (float)Math.Pow(0.9, Class115.double_0);
				if (this.float_2 < 40f)
				{
					this.float_2 = 40f;
				}
				this.class110_1.method_16(new osu.Graphics.Primitives.RectangleF(0f, 0f, this.float_2, (float)Class115.smethod_44()));
			}
			if (Math.Abs(this.float_2 - num2) < 1f)
			{
				this.float_3 = 400f;
			}
			Class392 class = null;
			foreach (Class390 current in this.list_1)
			{
				Class392 class2 = current as Class392;
				if (class2 != null)
				{
					class = class2;
				}
				if (current.float_0 - (float)(Class115.smethod_44() / 4) > this.class110_0.vector2_3.Y)
				{
					break;
				}
			}
			if (class != this.class392_0)
			{
				if (this.class392_0 != null)
				{
					this.class392_0.method_13(false);
				}
				this.class392_0 = class;
				if (this.class392_0 != null)
				{
					this.class392_0.method_13(true);
				}
			}
			foreach (Class404 current2 in this.list_2)
			{
				current2.method_5(current2.class392_0 == class);
			}
			this.class110_1.imethod_2();
		}

		// Token: 0x06001D14 RID: 7444
		// RVA: 0x00017EF0 File Offset: 0x000160F0
		private void method_26()
		{
			if (this.class531_3 != null && this.class531_3.object_0 != null)
			{
				this.class531_3.method_16(500, Enum70.const_0);
				this.class531_3.object_0 = null;
				this.class531_0.string_0 = null;
			}
		}

		// Token: 0x06001D1A RID: 7450
		// RVA: 0x0009E21C File Offset: 0x0009C41C
		internal void method_27(bool bool_7)
		{
			if (!this.bool_2)
			{
				return;
			}
			List<Class390> arg_2C_0 = this.list_0;
			if (Class80.action_5 == null)
			{
				Class80.action_5 = new Action<Class390>(Class80.smethod_25);
			}
			arg_2C_0.ForEach(Class80.action_5);
			this.list_0.Clear();
			this.list_2.Clear();
			this.class911_3.Clear(true);
			this.method_11();
			this.method_10();
		}

		// Token: 0x06001D1E RID: 7454
		// RVA: 0x00017F3D File Offset: 0x0001613D
		[CompilerGenerated]
		private void method_28(object sender, EventArgs e)
		{
			this.method_3();
		}

		// Token: 0x06001D20 RID: 7456
		// RVA: 0x00017F52 File Offset: 0x00016152
		[CompilerGenerated]
		private void method_29()
		{
			if (this.method_7())
			{
				this.method_8(false);
			}
			if (this.method_23())
			{
				this.method_24(false);
			}
		}

		// Token: 0x06001CF7 RID: 7415
		// RVA: 0x0009B6C0 File Offset: 0x000998C0
		private void method_3()
		{
			if (!string.IsNullOrEmpty(this.class400_0.class754_0.Text) && !string.IsNullOrEmpty(this.class400_1.class754_0.Text))
			{
				Class341.class605_20.Value = this.class400_0.class754_0.Text;
				Class341.class605_17.Value = Class33.smethod_2(this.class400_1.class754_0.Text);
				Class809.int_5 = 0;
				Class809.bool_14 = false;
				this.method_27(true);
				return;
			}
		}

		// Token: 0x06001D21 RID: 7457
		// RVA: 0x00017F72 File Offset: 0x00016172
		[CompilerGenerated]
		private void method_30()
		{
			this.method_27(true);
			if (this.class400_1 != null)
			{
				this.class400_1.method_15();
			}
		}

		// Token: 0x06001D22 RID: 7458
		// RVA: 0x00017F8E File Offset: 0x0001618E
		[CompilerGenerated]
		private void method_31(Class754 class754_0, bool bool_7)
		{
			if (bool_7)
			{
				this.method_10();
				this.class110_0.method_23(0f, -0.99f);
			}
		}

		// Token: 0x06001D24 RID: 7460
		// RVA: 0x00017FC2 File Offset: 0x000161C2
		[CompilerGenerated]
		private void method_32(object sender, EventArgs e)
		{
			Class80.smethod_4(this.class394_0.class753_0);
		}

		// Token: 0x06001D25 RID: 7461
		// RVA: 0x0009E370 File Offset: 0x0009C570
		[CompilerGenerated]
		private void method_33(object sender, EventArgs e)
		{
			Class390 class = this.class531_3.object_0 as Class390;
			if (class == null)
			{
				return;
			}
			List<Class530> arg_3D_0 = class.class911_0.list_2;
			if (Class80.predicate_0 == null)
			{
				Class80.predicate_0 = new Predicate<Class530>(Class80.smethod_10);
			}
			Class530 class2 = arg_3D_0.Find(Class80.predicate_0);
			if (class2 != null)
			{
				class2.method_0(true);
			}
		}

		// Token: 0x06001D26 RID: 7462
		// RVA: 0x00017FD4 File Offset: 0x000161D4
		[CompilerGenerated]
		private void method_34(object sender, EventArgs e)
		{
			Class331.smethod_60("menuback", 1f, Enum112.flag_5);
			this.method_8(false);
		}

		// Token: 0x06001D28 RID: 7464
		// RVA: 0x0009E3CC File Offset: 0x0009C5CC
		[CompilerGenerated]
		private void method_35()
		{
			this.method_26();
			this.rectangle_0 = new Rectangle(0, 0, 274, Class115.smethod_44());
			this.list_1.Clear();
			if (this.class756_0.Text.Length > 0)
			{
				using (List<Class390>.Enumerator enumerator = this.list_0.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Class390 current = enumerator.Current;
						if (current.Match(this.class756_0.Text) && !this.list_1.Contains(current))
						{
							Class390 class = current;
							int num = 0;
							while ((class = class.class390_0) != null && !this.list_1.Contains(class))
							{
								this.list_1.Insert(this.list_1.Count - num++, class);
							}
							this.list_1.Add(current);
							if (current.vmethod_3())
							{
								this.list_1.AddRange(current.method_11());
							}
						}
						else
						{
							current.method_10();
						}
					}
					goto IL_10F;
				}
			}
			this.list_1.AddRange(this.list_0);
			IL_10F:
			if (this.list_1.Count == 0 && this.class756_0.Text.Length > 0)
			{
				this.class756_0.method_31();
				this.class756_0.Text = this.class756_0.Text.Remove(this.class756_0.Text.Length - 1);
				this.method_10();
				return;
			}
			new Vector2(0f, 140f);
			int num2 = 0;
			float[] array = new float[1];
			for (int i = 0; i < 1; i++)
			{
				array[i] = 140f;
			}
			bool flag = true;
			float val = 0f;
			for (int j = 0; j < this.list_1.Count; j++)
			{
				Class390 class2 = this.list_1[j];
				class2.method_9(false);
				bool flag2 = class2.vmethod_3();
				if (class2.method_6() && !this.bool_3)
				{
					class2.class911_0.bool_6 = false;
					class2.class911_0.float_1 = 0.5f;
				}
				else
				{
					class2.class911_0.bool_6 = true;
					class2.class911_0.float_1 = 0f;
				}
				if (!flag)
				{
					if (flag2)
					{
						flag = true;
						num2 = 0;
					}
					else
					{
						num2 = (num2 + 1) % 1;
					}
				}
				if (!flag2)
				{
					flag = false;
				}
				if (class2.vmethod_4() > 0)
				{
					array[num2] += (float)class2.vmethod_4();
				}
				float num3 = 10f;
				if (!flag2)
				{
					num3 *= 2f;
				}
				class2.class911_0.vector2_2 = new Vector2(0f + num3, array[num2]);
				class2.float_0 = array[num2] - 70f;
				if (class2.method_0().Y > 0f)
				{
					array[num2] += class2.method_0().Y + 10f;
				}
				if (class2.method_2() > 0f)
				{
					val = Math.Max(val, array[num2] + class2.method_2());
				}
				if (flag2)
				{
					for (int k = 0; k < 1; k++)
					{
						array[k] = array[num2];
					}
				}
			}
			List<Class390> arg_35C_0 = this.list_1;
			if (Class80.action_1 == null)
			{
				Class80.action_1 = new Action<Class390>(Class80.smethod_11);
			}
			arg_35C_0.ForEach(Class80.action_1);
			float num4 = (float)(Class115.smethod_44() / 2 - this.list_2.Count * 40 / 2);
			foreach (Class404 current2 in this.list_2)
			{
				if (!this.list_1.Contains(current2.class392_0))
				{
					current2.method_3();
				}
				else
				{
					current2.method_4();
				}
				current2.method_2(new Vector2(0f, num4));
				num4 += 40f;
			}
			this.class110_0.method_14(new Vector2((float)this.rectangle_0.Width, Math.Max(val, array[num2] + (float)(this.method_7() ? 100 : 0))));
		}

		// Token: 0x06001D2C RID: 7468
		// RVA: 0x00018007 File Offset: 0x00016207
		[CompilerGenerated]
		private void method_36()
		{
			this.method_12();
		}

		// Token: 0x06001D30 RID: 7472
		// RVA: 0x0009E8C8 File Offset: 0x0009CAC8
		[CompilerGenerated]
		private void method_37(object sender, EventArgs e)
		{
			Class98 class = new Class98();
			class.method_2(new EventHandler(this.method_39));
			this.class756_0.vmethod_6(false);
			Class115.smethod_37(class);
		}

		// Token: 0x06001D31 RID: 7473
		// RVA: 0x0009E900 File Offset: 0x0009CB00
		[CompilerGenerated]
		private void method_38(object sender, EventArgs e)
		{
			Class91 class = new Class91();
			class.method_2(new EventHandler(this.method_40));
			this.class756_0.vmethod_6(false);
			Class115.smethod_37(class);
		}

		// Token: 0x06001D33 RID: 7475
		// RVA: 0x00018065 File Offset: 0x00016265
		[CompilerGenerated]
		private void method_39(object sender, EventArgs e)
		{
			this.class756_0.vmethod_6(true);
		}

		// Token: 0x06001CF8 RID: 7416
		// RVA: 0x0009B748 File Offset: 0x00099948
		internal void method_4()
		{
			Class809.smethod_26();
			Class341.class605_20.Value = string.Empty;
			Class341.class605_17.Value = string.Empty;
			Class115.class861_0.Name = string.Empty;
			Class115.class861_0.method_15();
			this.method_27(true);
		}

		// Token: 0x06001D34 RID: 7476
		// RVA: 0x00018065 File Offset: 0x00016265
		[CompilerGenerated]
		private void method_40(object sender, EventArgs e)
		{
			this.class756_0.vmethod_6(true);
		}

		// Token: 0x06001D38 RID: 7480
		// RVA: 0x00018085 File Offset: 0x00016285
		[CompilerGenerated]
		private void method_41()
		{
			if (Class80.size_0 != Class787.smethod_4() && Class115.screenMode_0 != ScreenMode.Fullscreen)
			{
				Class80.size_0 = Class787.smethod_4();
				Class115.size_0 = Class787.smethod_4();
				Class80.smethod_4(this.class394_0.class753_0);
			}
		}

		// Token: 0x06001CF9 RID: 7417
		// RVA: 0x0009B798 File Offset: 0x00099998
		private void method_5(object sender, EventArgs e)
		{
			VoidDelegate voidDelegate = null;
			if ((bool)sender)
			{
				Class115.class861_0.Name = Class341.class605_20;
				Class115.class861_0.method_15();
				if (this.delegate1_0 != null)
				{
					this.delegate1_0(true);
				}
				if (this.bool_4)
				{
					Class47 arg_60_0 = Class115.class47_0;
					if (voidDelegate == null)
					{
						voidDelegate = new VoidDelegate(this.method_29);
					}
					arg_60_0.method_1(voidDelegate, 500, false);
				}
			}
			Class115.class47_0.Add(new VoidDelegate(this.method_30), false);
		}

		// Token: 0x06001CFA RID: 7418
		// RVA: 0x0009B824 File Offset: 0x00099A24
		internal void method_6(Delegate1 delegate1_1)
		{
			Delegate1 delegate = this.delegate1_0;
			Delegate1 delegate2;
			do
			{
				delegate2 = delegate;
				Delegate1 value = (Delegate1)Delegate.Combine(delegate2, delegate1_1);
				delegate = Interlocked.CompareExchange<Delegate1>(ref this.delegate1_0, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x06001CFB RID: 7419
		// RVA: 0x00017E11 File Offset: 0x00016011
		internal bool method_7()
		{
			return this.bool_3;
		}

		// Token: 0x06001CFC RID: 7420
		// RVA: 0x0009B85C File Offset: 0x00099A5C
		internal void method_8(bool bool_7)
		{
			if (this.bool_3 == bool_7)
			{
				return;
			}
			if (!this.bool_2)
			{
				this.Initialize();
			}
			this.bool_3 = bool_7;
			this.method_24(bool_7);
			if (!this.bool_3)
			{
				if (!Class809.bool_3 && !Class115.smethod_33() && this.delegate1_0 != null)
				{
					this.delegate1_0(false);
				}
				this.delegate1_0 = null;
			}
			if (this.bool_3)
			{
				this.class110_0.method_33();
				this.class110_1.method_33();
				Class115.smethod_0(false, false);
				this.method_10();
			}
		}

		// Token: 0x06001CFD RID: 7421
		// RVA: 0x00017E19 File Offset: 0x00016019
		internal void method_9(bool bool_7)
		{
			if (this.bool_4 != bool_7)
			{
				this.bool_4 = bool_7;
				this.method_27(true);
				return;
			}
			this.bool_4 = bool_7;
		}

		// Token: 0x06001D15 RID: 7445
		// RVA: 0x0009DD80 File Offset: 0x0009BF80
		private static void smethod_0(Class753 class753_0, Size size_1, Size size_2)
		{
			if (size_1.Height > size_2.Height)
			{
				return;
			}
			string str = (size_1 == size_2) ? (' ' + Class41.GetString(OsuString.Options_Graphics_ResolutionNative)) : string.Empty;
			string text = Class787.ToString(size_1);
			class753_0.method_9(text + str, text);
		}

		// Token: 0x06001D16 RID: 7446
		// RVA: 0x0009DDD8 File Offset: 0x0009BFD8
		private static void smethod_1(Class753 class753_0, Size size_1, Size size_2)
		{
			string str = (size_1 == size_2) ? (" " + Class41.GetString(OsuString.Options_Graphics_ResolutionBorderless)) : string.Empty;
			if (size_1.Width <= size_2.Width && size_1.Height <= size_2.Height)
			{
				string text = Class787.ToString(size_1);
				class753_0.method_9(text + str, text);
			}
		}

		// Token: 0x06001D27 RID: 7463
		// RVA: 0x00017FEE File Offset: 0x000161EE
		[CompilerGenerated]
		private static bool smethod_10(Class530 class530_0)
		{
			return class530_0.bool_1;
		}

		// Token: 0x06001D29 RID: 7465
		// RVA: 0x00017FF6 File Offset: 0x000161F6
		[CompilerGenerated]
		private static void smethod_11(Class390 class390_0)
		{
			class390_0.vmethod_2();
		}

		// Token: 0x06001D2A RID: 7466
		// RVA: 0x00017FFE File Offset: 0x000161FE
		[CompilerGenerated]
		private static void smethod_12()
		{
			Class115.smethod_0(false, true);
		}

		// Token: 0x06001D2B RID: 7467
		// RVA: 0x0009E81C File Offset: 0x0009CA1C
		[CompilerGenerated]
		private static void smethod_13(object sender, EventArgs e)
		{
			if (Class466.Current != null && Class466.Current.list_1 != null && Class466.Current.list_1.Count != 0)
			{
				Class115.smethod_70(OsuModes.OptionsOffsetWizard, false);
				return;
			}
			Class723.smethod_1(Class41.GetString(OsuString.Options_OffsetWizard_NotTimed), 3000);
		}

		// Token: 0x06001D2D RID: 7469
		// RVA: 0x0001800F File Offset: 0x0001620F
		[CompilerGenerated]
		private static void smethod_14(object sender, EventArgs e)
		{
			if (Class80.voidDelegate_2 == null)
			{
				Class80.voidDelegate_2 = new VoidDelegate(Class80.smethod_17);
			}
			Class115.smethod_11(Class80.voidDelegate_2);
			if (Class115.smethod_97())
			{
				Class115.smethod_70(Class115.osuModes_1, true);
			}
		}

		// Token: 0x06001D2E RID: 7470
		// RVA: 0x00018045 File Offset: 0x00016245
		[CompilerGenerated]
		private static void smethod_15(object sender, EventArgs e)
		{
			Class885.smethod_36();
			Class115.smethod_83("Skins\\" + Class885.class547_0.string_2);
		}

		// Token: 0x06001D2F RID: 7471
		// RVA: 0x0009E86C File Offset: 0x0009CA6C
		[CompilerGenerated]
		private static void smethod_16(object sender, EventArgs e)
		{
			if (Class885.class547_0 == null)
			{
				return;
			}
			if (Class885.smethod_24())
			{
				Class723.smethod_4(Class41.GetString(OsuString.OptionsSkin_CannotExportDefault));
				return;
			}
			Class115.smethod_82(Class885.class547_0.string_1 + ".osk", "Skins/" + Class885.class547_0.string_2);
		}

		// Token: 0x06001D32 RID: 7474
		// RVA: 0x00016257 File Offset: 0x00014457
		[CompilerGenerated]
		private static void smethod_17()
		{
			Class885.smethod_9(null, true);
		}

		// Token: 0x06001D35 RID: 7477
		// RVA: 0x00018073 File Offset: 0x00016273
		[CompilerGenerated]
		private static void smethod_18(Class296 class296_0)
		{
			class296_0.bool_13 = false;
		}

		// Token: 0x06001D36 RID: 7478
		// RVA: 0x0009E938 File Offset: 0x0009CB38
		[CompilerGenerated]
		private static bool smethod_19(Class296 class296_0)
		{
			Class80.Class403 class = new Class80.Class403();
			class.class296_0 = class296_0;
			return (class.class296_0.submissionStatus_0 == SubmissionStatus.Pending || class.class296_0.submissionStatus_0 == SubmissionStatus.NotSubmitted) && class.class296_0.string_5 != Class341.class605_20 && Class466.list_3.FindAll(new Predicate<Class296>(class.method_0)).Count == 0;
		}

		// Token: 0x06001D17 RID: 7447
		// RVA: 0x0009DE40 File Offset: 0x0009C040
		private static void smethod_2(Class753 class753_0, List<Size> list_3, Size size_1)
		{
			foreach (Size current in list_3)
			{
				if (Class341.class605_8 == ScreenMode.Fullscreen)
				{
					Class80.smethod_0(class753_0, current, size_1);
				}
				else
				{
					Class80.smethod_1(class753_0, current, Class80.size_0);
				}
			}
		}

		// Token: 0x06001D37 RID: 7479
		// RVA: 0x0001807C File Offset: 0x0001627C
		[CompilerGenerated]
		private static void smethod_20(Class296 class296_0)
		{
			Class466.smethod_34(class296_0, true);
		}

		// Token: 0x06001D39 RID: 7481
		// RVA: 0x000180C4 File Offset: 0x000162C4
		[CompilerGenerated]
		private static void smethod_21(Class390 class390_0)
		{
			class390_0.Dispose();
		}

		// Token: 0x06001D3A RID: 7482
		// RVA: 0x0009E9AC File Offset: 0x0009CBAC
		[CompilerGenerated]
		private static int smethod_22(Size size_1, Size size_2)
		{
			if (size_1.Width != size_2.Width)
			{
				return size_1.Width.CompareTo(size_2.Width);
			}
			return size_1.Height.CompareTo(size_2.Height);
		}

		// Token: 0x06001D3B RID: 7483
		// RVA: 0x000180CC File Offset: 0x000162CC
		[CompilerGenerated]
		private static bool smethod_23(Size size_1)
		{
			return (float)size_1.Width * 3f / ((float)size_1.Height * 4f) <= 1f;
		}

		// Token: 0x06001D3C RID: 7484
		// RVA: 0x000180F5 File Offset: 0x000162F5
		[CompilerGenerated]
		private static bool smethod_24(Size size_1)
		{
			return (float)size_1.Width * 3f / ((float)size_1.Height * 4f) > 1f;
		}

		// Token: 0x06001D3D RID: 7485
		// RVA: 0x000180C4 File Offset: 0x000162C4
		[CompilerGenerated]
		private static void smethod_25(Class390 class390_0)
		{
			class390_0.Dispose();
		}

		// Token: 0x06001D18 RID: 7448
		// RVA: 0x0009DEAC File Offset: 0x0009C0AC
		private static void smethod_3(List<Size> list_3)
		{
			if (Class80.comparison_0 == null)
			{
				Class80.comparison_0 = new Comparison<Size>(Class80.smethod_22);
			}
			list_3.Sort(Class80.comparison_0);
			int i = 0;
			while (i < list_3.Count - 1)
			{
				Size sz = list_3[i];
				if (sz.Width >= 800 && sz.Height >= 600 && !(sz == list_3[i + 1]))
				{
					i++;
				}
				else
				{
					list_3.RemoveAt(i);
				}
			}
		}

		// Token: 0x06001D19 RID: 7449
		// RVA: 0x0009DF30 File Offset: 0x0009C130
		internal static void smethod_4(Class753 class753_0)
		{
			class753_0.method_12();
			List<Size> list = Class787.smethod_0();
			if (list.Count == 0)
			{
				return;
			}
			Class80.smethod_3(list);
			Size size_ = list[list.Count - 1];
			if (Class341.class605_8 != ScreenMode.Fullscreen)
			{
				list.Add(new Size(800, 600));
				list.Add(new Size(1024, 768));
				list.Add(new Size(1280, 960));
				list.Add(new Size(1600, 1200));
				list.Add(new Size(1920, 1440));
				list.Add(new Size(2560, 1920));
				list.Add(new Size(1024, 600));
				list.Add(new Size(1280, 800));
				list.Add(new Size(1366, 768));
				list.Add(new Size(1440, 900));
				list.Add(new Size(1680, 1050));
				list.Add(new Size(1920, 1080));
				list.Add(new Size(1920, 1200));
				list.Add(new Size(2560, 1440));
				list.Add(new Size(2560, 1600));
			}
			Class80.smethod_3(list);
			List<Size> arg_199_0 = list;
			if (Class80.predicate_2 == null)
			{
				Class80.predicate_2 = new Predicate<Size>(Class80.smethod_23);
			}
			List<Size> list2 = arg_199_0.FindAll(Class80.predicate_2);
			if (list2.Count > 0)
			{
				class753_0.method_10(Class41.GetString(OsuString.Options_Graphics_ResolutionStandard), null, Class885.color_3);
				Class80.smethod_2(class753_0, list2, size_);
			}
			List<Size> arg_1E2_0 = list;
			if (Class80.predicate_3 == null)
			{
				Class80.predicate_3 = new Predicate<Size>(Class80.smethod_24);
			}
			List<Size> list3 = arg_1E2_0.FindAll(Class80.predicate_3);
			if (list3.Count > 0)
			{
				class753_0.method_10(Class41.GetString(OsuString.Options_Graphics_ResolutionWidescreen), null, Class885.color_3);
				Class80.smethod_2(class753_0, list3, size_);
			}
			Size size = Size.Empty;
			switch (Class341.class605_8.Value)
			{
			case ScreenMode.Windowed:
				size = new Size(Class341.class608_11, Class341.class608_5);
				break;
			case ScreenMode.Fullscreen:
				size = new Size(Class341.class608_12, Class341.class608_6);
				break;
			case ScreenMode.BorderlessWindow:
				size = Class787.smethod_4();
				break;
			}
			string text = Class787.ToString(size);
			if (!class753_0.method_18(text, true))
			{
				if (size.Width == 9999)
				{
					class753_0.method_18(Class787.ToString(list[list.Count - 1]), true);
					return;
				}
				class753_0.method_9(text + " (" + Class41.GetString(OsuString.Options_Graphics_CustomResolution) + ")", text);
				class753_0.method_18(text, true);
			}
		}

		// Token: 0x06001D1B RID: 7451
		// RVA: 0x0009E288 File Offset: 0x0009C488
		internal static IEnumerable<Class557> smethod_5()
		{
			return new Class557[]
			{
				new Class557(Class41.GetString(OsuString.Options_ReleaseStrategy_Stable), ReleaseStream.Stable),
				new Class557(Class41.GetString(OsuString.Options_ReleaseStrategy_Beta), ReleaseStream.Beta),
				new Class557(Class41.GetString(OsuString.Options_ReleaseStrategy_CuttingEdge), ReleaseStream.CuttingEdge)
			};
		}

		// Token: 0x06001D1C RID: 7452
		// RVA: 0x0009E2E8 File Offset: 0x0009C4E8
		public static IEnumerable<Class557> smethod_6()
		{
			return new Class557[]
			{
				new Class557(Class41.GetString(OsuString.Options_Graphics_FrameLimiter_60), FrameSync.VSync),
				new Class557(Class41.GetString(OsuString.Options_Graphics_FrameLimiter_120), FrameSync.Limit120),
				new Class557(Class341.class608_0 + "fps", FrameSync.Limit240),
				new Class557(Class41.GetString(OsuString.Options_Graphics_FrameLimiter_UnlimGreen), FrameSync.Unlimited),
				new Class557(Class41.GetString(OsuString.Options_Graphics_FrameLimiter_Unlim), FrameSync.CompletelyUnlimited)
			};
		}

		// Token: 0x06001D1D RID: 7453
		// RVA: 0x00017F30 File Offset: 0x00016130
		[CompilerGenerated]
		private static void smethod_7()
		{
			Class527.smethod_0(Class115.class861_0, false);
		}

		// Token: 0x06001D1F RID: 7455
		// RVA: 0x00017F45 File Offset: 0x00016145
		[CompilerGenerated]
		private static void smethod_8(object sender, EventArgs e)
		{
			Class115.smethod_90("http://osu.ppy.sh/p/register", null);
		}

		// Token: 0x06001D23 RID: 7459
		// RVA: 0x00017FAE File Offset: 0x000161AE
		[CompilerGenerated]
		private static void smethod_9(Class531 class531_4)
		{
			class531_4.bool_11 = true;
			class531_4.float_5 = 90f;
		}
	}
}
