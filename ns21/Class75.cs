using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns18;
using ns22;
using ns24;
using ns25;
using ns27;
using ns29;
using ns76;
using ns79;
using ns80;
using ns82;
using ns9;
using osu.Graphics.Primitives;
using osu.Graphics.Sprites;
using osu_common;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns21
{
	// Token: 0x02000510 RID: 1296
	internal sealed class Class75 : Class74
	{
		// Token: 0x0400229F RID: 8863
		private Class512 class512_1;

		// Token: 0x040022A2 RID: 8866
		private Class512 class512_2;

		// Token: 0x0400229E RID: 8862
		private Class543 class543_1;

		// Token: 0x040022A1 RID: 8865
		private Class543 class543_2;

		// Token: 0x040022A0 RID: 8864
		private Class592 class592_0;

		// Token: 0x040022A3 RID: 8867
		private Class592 class592_1;

		// Token: 0x0400229A RID: 8858
		private readonly List<Class531> list_3 = new List<Class531>();

		// Token: 0x0400229B RID: 8859
		private readonly List<Class531> list_4 = new List<Class531>();

		// Token: 0x0400229C RID: 8860
		private readonly List<Class531> list_5 = new List<Class531>();

		// Token: 0x0400229D RID: 8861
		private PlayModes playModes_0;

		// Token: 0x060029C9 RID: 10697
		// RVA: 0x00020191 File Offset: 0x0001E391
		internal Class75(Class114 class114_1) : base(class114_1)
		{
		}

		// Token: 0x060029D5 RID: 10709
		// RVA: 0x000201E5 File Offset: 0x0001E3E5
		protected override void Dispose(bool bool_5)
		{
			if (Class62.class664_0 != null)
			{
				Class62.class664_0.Dispose();
			}
			Class64.smethod_28();
			base.Dispose(bool_5);
		}

		// Token: 0x060029D3 RID: 10707
		// RVA: 0x000201CB File Offset: 0x0001E3CB
		public override void Draw()
		{
			base.Draw();
			Class62.class664_0.Draw();
		}

		// Token: 0x060029D4 RID: 10708
		// RVA: 0x000201DD File Offset: 0x0001E3DD
		public override void imethod_2()
		{
			base.imethod_2();
		}

		// Token: 0x060029CA RID: 10698
		// RVA: 0x0010A238 File Offset: 0x00108438
		public override void Initialize()
		{
			base.Initialize();
			Class62.class664_0.class911_0.bool_8 = true;
			Class62.class664_0.class911_0.float_0 = 1f;
			lock (Class858.object_0)
			{
				Class802.smethod_1(false);
				Class802.bool_16 = false;
				Class802.int_2 = 0;
			}
			Class533 class = null;
			SlotTeams slotTeams = Class64.class657_0.method_0();
			if (Class64.smethod_34(SlotTeams.Blue))
			{
				class = new Class533("Blue team failed!", 20f, new Vector2((float)(Class115.smethod_43() / 2), 85f), Vector2.get_Zero(), 1f, true, Color.get_Blue(), false);
			}
			else if (Class64.smethod_34(SlotTeams.Red))
			{
				class = new Class533("Red team failed!", 20f, new Vector2((float)(Class115.smethod_43() / 2), 85f), Vector2.get_Zero(), 1f, true, Color.get_Red(), false);
			}
			else
			{
				switch (slotTeams)
				{
				case SlotTeams.Blue:
					class = new Class533("Blue team wins!", 20f, new Vector2((float)(Class115.smethod_43() / 2), 85f), Vector2.get_Zero(), 1f, true, Color.get_Blue(), false);
					break;
				case SlotTeams.Red:
					class = new Class533("Red team wins!", 20f, new Vector2((float)(Class115.smethod_43() / 2), 85f), Vector2.get_Zero(), 1f, true, Color.get_Red(), false);
					break;
				}
			}
			class.bool_16 = true;
			class.origins_0 = Origins.Centre;
			this.class911_2.Add(class);
			this.class592_0 = new Class592(this.class911_2, 3, new Vector2(56f, 113f), 0.8f, true, Color.get_BlueViolet(), 40, false);
			this.class592_1 = new Class592(this.class911_2, 3, new Vector2((float)(Class115.smethod_43() - 224), 113f), 0.8f, true, Color.get_BlueViolet(), 40, false);
			this.class592_0.Add("Total", 0, false);
			this.class592_1.Add("Total", 0, false);
			this.class592_0.method_2(0);
			this.class592_1.method_2(0);
			this.class592_0.method_0(new EventHandler(this.method_20));
			this.class592_1.method_0(new EventHandler(this.method_21));
			int count = Class64.list_6.Count;
			for (int i = 0; i < count; i++)
			{
				Class660 class2 = Class64.list_6[i];
				if (class2 != null)
				{
					((class2.method_0() == SlotTeams.Blue) ? this.class592_0 : this.class592_1).Add(class2.string_0, i + 1, false);
				}
			}
			Class531 class3 = new Class531(Class885.Load("ranking-panel", Enum112.flag_6), Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(1f, (float)(Class885.smethod_25() ? 107 : 97)), 0.79f, true, Color.get_White(), null);
			class3.float_3 = 1f;
			class3.vector2_2 = new Vector2(0.715f, 0.77f);
			Class531 class4 = new Class531(Class885.Load("ranking-panel", Enum112.flag_6), Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2((float)(Class115.smethod_43() - 279), (float)(Class885.smethod_25() ? 107 : 97)), 0.79f, true, Color.get_White(), null);
			class4.float_3 = 1f;
			class4.vector2_2 = new Vector2(0.715f, 0.77f);
			this.class911_2.Add(class3);
			this.class911_2.Add(class4);
			this.method_19();
			this.class512_1 = this.method_17(SlotTeams.Blue);
			this.class512_2 = this.method_17(SlotTeams.Red);
			this.method_18(SlotTeams.Blue, 0, true);
			this.method_18(SlotTeams.Red, 0, true);
			this.playModes_0 = Class62.Mode;
		}

		// Token: 0x060029D0 RID: 10704
		// RVA: 0x0010A620 File Offset: 0x00108820
		private Class512 method_17(SlotTeams slotTeams_0)
		{
			Class512 class = Class721.Create(this.playModes_0, Class466.Current);
			int num = 0;
			class.list_0 = new List<Vector2>();
			SortedDictionary<float, float> sortedDictionary = new SortedDictionary<float, float>();
			for (int i = 0; i < Class64.list_6.Count; i++)
			{
				Class660 class2 = Class64.list_6[i];
				if (class2 != null)
				{
					Class512 class512_ = class2.class512_0;
					if (class512_ != null && class2.method_0() == slotTeams_0)
					{
						class.int_0 += class512_.int_0;
						class.int_3 += class512_.int_3;
						Class512 expr_85 = class;
						expr_85.ushort_1 += class512_.ushort_1;
						Class512 expr_9A = class;
						expr_9A.ushort_3 += class512_.ushort_3;
						Class512 expr_AF = class;
						expr_AF.ushort_0 += class512_.ushort_0;
						Class512 expr_C4 = class;
						expr_C4.ushort_4 += class512_.ushort_4;
						Class512 expr_D9 = class;
						expr_D9.ushort_2 += class512_.ushort_2;
						Class512 expr_EE = class;
						expr_EE.ushort_5 += class512_.ushort_5;
						if (class512_.list_0 != null)
						{
							if (Class64.class10_0.matchTeamType == MatchTeamTypes.TeamVs)
							{
								if (num == 0)
								{
									class.list_0.AddRange(class512_.list_0);
								}
								else
								{
									for (int j = Math.Min(class.list_0.Count, class512_.list_0.Count) - 1; j >= 0; j--)
									{
										class.list_0[j] = new Vector2(class.list_0[j].X, (class.list_0[j].Y * (float)num + class512_.list_0[j].Y) / (float)(num + 1));
									}
								}
							}
							else
							{
								foreach (Vector2 current in class512_.list_0)
								{
									if (!sortedDictionary.ContainsKey(current.X))
									{
										sortedDictionary.Add(current.X, current.Y);
									}
								}
							}
						}
						num++;
					}
				}
			}
			if (Class64.class10_0.matchTeamType == MatchTeamTypes.TagTeamVs)
			{
				foreach (KeyValuePair<float, float> current2 in sortedDictionary)
				{
					class.list_0.Add(new Vector2(current2.Key, current2.Value));
				}
			}
			return class;
		}

		// Token: 0x060029D1 RID: 10705
		// RVA: 0x0010A8CC File Offset: 0x00108ACC
		private void method_18(SlotTeams slotTeams_0, int int_3, bool bool_5)
		{
			bool flag = this.playModes_0 == PlayModes.CatchTheBeat;
			int int_4 = Class115.int_1;
			Class512 class = (int_3 != 0) ? Class64.list_6[int_3 - 1].class512_0 : ((slotTeams_0 == SlotTeams.Blue) ? this.class512_1 : this.class512_2);
			List<Class531> list = (slotTeams_0 == SlotTeams.Blue) ? this.list_3 : this.list_4;
			this.class911_2.method_13<Class531>(list);
			list.Clear();
			int num = Class885.smethod_25() ? -16 : -25;
			new Vector2(0f, 20f);
			int num2 = bool_5 ? 1300 : 0;
			int num3 = bool_5 ? 400 : 20;
			Class531 class2 = new Class536(string.Format("{0}x", class.ushort_1), Class885.class547_0.string_4, Class885.class547_0.int_1, Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(80f, (float)(160 + num)), 0.8f, true, Color.get_TransparentWhite(), true);
			class2.float_2 = 1.12f;
			Class746 class3 = new Class746(TransformationType.Fade, 0f, 1f, int_4 + num2, int_4 + num2 + num3, Enum70.const_0);
			num2 += num3;
			class3.enum70_0 = Enum70.const_1;
			class2.class26_0.Add(class3);
			list.Add(class2);
			class2 = new Class536(string.Format("{0}x", class.ushort_0), Class885.class547_0.string_4, Class885.class547_0.int_1, Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(80f, (float)(220 + num)), 0.8f, true, Color.get_TransparentWhite(), true);
			class2.float_2 = 1.12f;
			class3 = new Class746(TransformationType.Fade, 0f, 1f, int_4 + num2, int_4 + num2 + num3, Enum70.const_0);
			num2 += num3;
			class3.enum70_0 = Enum70.const_1;
			class2.class26_0.Add(class3);
			list.Add(class2);
			class2 = new Class536(string.Format("{0}x", class.ushort_2), Class885.class547_0.string_4, Class885.class547_0.int_1, Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(80f, (float)(280 + num)), 0.8f, true, Color.get_TransparentWhite(), true);
			class2.float_2 = 1.12f;
			class3 = new Class746(TransformationType.Fade, 0f, 1f, int_4 + num2, int_4 + num2 + num3, Enum70.const_0);
			num2 += num3;
			class3.enum70_0 = Enum70.const_1;
			class2.class26_0.Add(class3);
			list.Add(class2);
			if (!flag)
			{
				class2 = new Class536(string.Format("{0}x", class.ushort_3), Class885.class547_0.string_4, Class885.class547_0.int_1, Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(280f, (float)(160 + num)), 0.8f, true, Color.get_TransparentWhite(), true);
				class2.float_2 = 1.12f;
				class3 = new Class746(TransformationType.Fade, 0f, 1f, int_4 + num2, int_4 + num2 + num3, Enum70.const_0);
				num2 += num3;
				class3.enum70_0 = Enum70.const_1;
				class2.class26_0.Add(class3);
				list.Add(class2);
				class2 = new Class536(string.Format("{0}x", class.ushort_4), Class885.class547_0.string_4, Class885.class547_0.int_1, Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(280f, (float)(220 + num)), 0.8f, true, Color.get_TransparentWhite(), true);
				class2.float_2 = 1.12f;
				class3 = new Class746(TransformationType.Fade, 0f, 1f, int_4 + num2, int_4 + num2 + num3, Enum70.const_0);
				num2 += num3;
				class3.enum70_0 = Enum70.const_1;
				class2.class26_0.Add(class3);
				list.Add(class2);
			}
			class2 = new Class536(string.Format("{0}x", class.ushort_5), Class885.class547_0.string_4, Class885.class547_0.int_1, Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(280f, (float)((flag ? 160 : 280) + num)), 0.8f, true, Color.get_TransparentWhite(), true);
			class2.float_2 = 1.12f;
			class3 = new Class746(TransformationType.Fade, 0f, 1f, int_4 + num2, int_4 + num2 + num3, Enum70.const_0);
			num2 += num3;
			class3.enum70_0 = Enum70.const_1;
			class2.class26_0.Add(class3);
			list.Add(class2);
			class2 = new Class536((int_3 == 0) ? "xxxx" : string.Format("{0}x", class.int_0), Class885.class547_0.string_4, Class885.class547_0.int_1, Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(15f, 330f), 0.8f, true, Color.get_TransparentWhite(), true);
			class2.float_2 = 1.12f;
			class3 = new Class746(TransformationType.Fade, 0f, 1f, int_4 + num2, int_4 + num2 + num3, Enum70.const_0);
			num2 += num3;
			class3.enum70_0 = Enum70.const_1;
			class2.class26_0.Add(class3);
			list.Add(class2);
			class2 = new Class536(string.Format("{0:0.00}%", class.vmethod_1() * 100f), Class885.class547_0.string_4, Class885.class547_0.int_1, Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(194f, 330f), 0.8f, true, Color.get_TransparentWhite(), true);
			class2.float_2 = 1.12f;
			class3 = new Class746(TransformationType.Fade, 0f, 1f, int_4 + num2, int_4 + num2 + num3, Enum70.const_0);
			class3.enum70_0 = Enum70.const_1;
			class2.class26_0.Add(class3);
			list.Add(class2);
			num2 += num3;
			string string_ = string.Format("{0:00000000}", class.int_3);
			Class536 class4 = new Class536(string_, Class885.class547_0.string_4, Class885.class547_0.int_1, Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2(180f, 94f), 0.8f, true, Color.get_White(), true);
			class4.float_2 = (Class885.smethod_25() ? 1.3f : 1.2f);
			if (Class885.smethod_25())
			{
				class4.int_9 = -2;
			}
			class4.float_3 = 0f;
			class3 = new Class746(TransformationType.Fade, 0f, 1f, int_4 + num2, int_4 + num2 + num3 * 2, Enum70.const_0);
			class3.enum70_0 = Enum70.const_1;
			class4.class26_0.Add(class3);
			list.Add(class4);
			int num4 = 0;
			switch (slotTeams_0)
			{
			case SlotTeams.Red:
				num4 = Class115.smethod_43() - 278;
				break;
			}
			float num5 = 0.66f;
			for (int i = 0; i < list.Count; i++)
			{
				Class531 class5 = list[i];
				class5.float_2 *= num5;
				class5.vector2_1.X = 40f + (class5.vector2_1.X - 40f) * num5 + (float)num4;
				class5.vector2_1.Y = 160f + (class5.vector2_1.Y - 160f) * num5 + 18f;
				this.class911_2.Add(class5);
			}
			Class543 class530_ = new Class543(int_4, bool_5 ? 2000 : 4000, class, new RectangleF((float)(60 + num4), (float)(Class885.smethod_25() ? 346 : 331), 150f, 68f));
			if (slotTeams_0 == SlotTeams.Blue)
			{
				this.class543_1 = class530_;
			}
			else
			{
				this.class543_2 = class530_;
			}
			this.class911_2.Add(class530_);
		}

		// Token: 0x060029D2 RID: 10706
		// RVA: 0x0010B084 File Offset: 0x00109284
		private void method_19()
		{
			float num = 0.65f;
			new Vector2(40f, 0f);
			int int_ = Class115.int_1;
			bool flag = this.playModes_0 == PlayModes.CatchTheBeat;
			int num2 = 0;
			int num3 = 0;
			for (int i = 0; i < 2; i++)
			{
				int num4 = 1000;
				Class531 class;
				Class746 class2;
				if (flag)
				{
					class = new Class531(Class885.Load("fruit-orange", Enum112.flag_6), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2(40f, 160f), 0.9f, true, Color.get_Orange(), null);
					class.float_3 = 0f;
					class2 = new Class746(TransformationType.Scale, 1.2f * num, 0.65f * num, int_ + num4, int_ + num4 + 400, Enum70.const_0);
					class2.enum70_0 = Enum70.const_2;
					class.class26_0.Add(class2);
					class2 = new Class746(TransformationType.Fade, 0f, 1f, int_ + num4, int_ + num4 + 400, Enum70.const_0);
					class2.enum70_0 = Enum70.const_2;
					class.class26_0.Add(class2);
					this.list_5.Add(class);
					class = new Class531(Class885.Load("fruit-orange-overlay", Enum112.flag_6), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2(40f, 160f), 0.91f, true, Color.get_TransparentWhite(), null);
					class2 = new Class746(TransformationType.Scale, 1.2f * num, 0.65f * num, int_ + num4, int_ + num4 + 400, Enum70.const_0);
					class2.enum70_0 = Enum70.const_2;
					class.class26_0.Add(class2);
					class2 = new Class746(TransformationType.Fade, 0f, 1f, int_ + num4, int_ + num4 + 400, Enum70.const_0);
					num4 += 400;
					class2.enum70_0 = Enum70.const_2;
					class.class26_0.Add(class2);
					this.list_5.Add(class);
					class = new Class531(Class885.Load("fruit-drop", Enum112.flag_6), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2(40f, 220f), 0.9f, true, Color.get_YellowGreen(), null);
					class.float_3 = 0f;
					class2 = new Class746(TransformationType.Scale, 1.2f * num, 0.77f * num, int_ + num4, int_ + num4 + 400, Enum70.const_0);
					class2.enum70_0 = Enum70.const_2;
					class.class26_0.Add(class2);
					class2 = new Class746(TransformationType.Fade, 0f, 1f, int_ + num4, int_ + num4 + 400, Enum70.const_0);
					num4 += 400;
					class2.enum70_0 = Enum70.const_2;
					class.class26_0.Add(class2);
					this.list_5.Add(class);
					class = new Class531(Class885.Load("fruit-drop", Enum112.flag_6), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2(40f, 280f), 0.9f, true, Color.get_LightBlue(), null);
					class.float_3 = 0f;
					class.float_1 = 4f;
					class2 = new Class746(TransformationType.Scale, 1.15f * num, 0.57f * num, int_ + num4, int_ + num4 + 400, Enum70.const_0);
					class2.enum70_0 = Enum70.const_2;
					class.class26_0.Add(class2);
					class2 = new Class746(TransformationType.Fade, 0f, 1f, int_ + num4, int_ + num4 + 400, Enum70.const_0);
					num4 += 400;
					class2.enum70_0 = Enum70.const_2;
					class.class26_0.Add(class2);
					this.list_5.Add(class);
					class = new Class531(Class885.Load("fruit-orange", Enum112.flag_6), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2(240f, 160f), 0.9f, true, Color.get_LightGray(), null);
					class.float_3 = 0f;
					class.float_1 = 0.8f;
					class2 = new Class746(TransformationType.Scale, 1.15f * num, 0.57f * num, int_ + num4, int_ + num4 + 400, Enum70.const_0);
					class2.enum70_0 = Enum70.const_2;
					class.class26_0.Add(class2);
					class2 = new Class746(TransformationType.Fade, 0f, 1f, int_ + num4, int_ + num4 + 400, Enum70.const_0);
					class2.enum70_0 = Enum70.const_2;
					class.class26_0.Add(class2);
					this.list_5.Add(class);
					class = new Class531(Class885.Load("fruit-orange-overlay", Enum112.flag_6), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2(240f, 160f), 0.91f, true, Color.get_TransparentWhite(), null);
					class.float_1 = 0.8f;
					class2 = new Class746(TransformationType.Scale, 1.15f * num, 0.57f * num, int_ + num4, int_ + num4 + 400, Enum70.const_0);
					class2.enum70_0 = Enum70.const_2;
					class.class26_0.Add(class2);
					class2 = new Class746(TransformationType.Fade, 0f, 1f, int_ + num4, int_ + num4 + 400, Enum70.const_0);
					class2.enum70_0 = Enum70.const_2;
					class.class26_0.Add(class2);
					this.list_5.Add(class);
					class = new Class531(Class885.Load("hit0", Enum112.flag_6), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2(240f, 160f) - new Vector2(20f, 20f), 0.9f, true, Color.get_TransparentWhite(), null);
					class2 = new Class746(TransformationType.Scale, 0.9f * num, 0.35f * num, int_ + num4, int_ + num4 + 400, Enum70.const_0);
					class2.enum70_0 = Enum70.const_2;
					class.class26_0.Add(class2);
					class2 = new Class746(TransformationType.Fade, 0f, 1f, int_ + num4, int_ + num4 + 400, Enum70.const_0);
					num4 += 400;
					class2.enum70_0 = Enum70.const_2;
					class.class26_0.Add(class2);
					this.list_5.Add(class);
				}
				else
				{
					class = new Class531(Class885.Load("hit300", Enum112.flag_6), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2(40f, 160f), 0.9f, true, Color.get_TransparentWhite(), null);
					class2 = new Class746(TransformationType.Scale, 1f * num, 0.5f * num, int_ + num4, int_ + num4 + 400, Enum70.const_0);
					class2.enum70_0 = Enum70.const_2;
					class.class26_0.Add(class2);
					class2 = new Class746(TransformationType.Fade, 0f, 1f, int_ + num4, int_ + num4 + 400, Enum70.const_0);
					num4 += 400;
					class2.enum70_0 = Enum70.const_2;
					class.class26_0.Add(class2);
					this.list_5.Add(class);
					class = new Class531(Class885.Load("hit100", Enum112.flag_6), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2(40f, 220f), 0.9f, true, Color.get_TransparentWhite(), null);
					class2 = new Class746(TransformationType.Scale, 1f * num, 0.5f * num, int_ + num4, int_ + num4 + 400, Enum70.const_0);
					class2.enum70_0 = Enum70.const_2;
					class.class26_0.Add(class2);
					class2 = new Class746(TransformationType.Fade, 0f, 1f, int_ + num4, int_ + num4 + 400, Enum70.const_0);
					num4 += 400;
					class2.enum70_0 = Enum70.const_2;
					class.class26_0.Add(class2);
					this.list_5.Add(class);
					class = new Class531(Class885.Load("hit50", Enum112.flag_6), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2(40f, 280f), 0.9f, true, Color.get_TransparentWhite(), null);
					class2 = new Class746(TransformationType.Scale, 1f * num, 0.5f * num, int_ + num4, int_ + num4 + 400, Enum70.const_0);
					class2.enum70_0 = Enum70.const_2;
					class.class26_0.Add(class2);
					class2 = new Class746(TransformationType.Fade, 0f, 1f, int_ + num4, int_ + num4 + 400, Enum70.const_0);
					num4 += 400;
					class2.enum70_0 = Enum70.const_2;
					class.class26_0.Add(class2);
					this.list_5.Add(class);
					class = new Class531(Class885.Load("hit300g", Enum112.flag_6), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2(240f, 160f), 0.9f, true, Color.get_TransparentWhite(), null);
					class2 = new Class746(TransformationType.Scale, 1f * num, 0.5f * num, int_ + num4, int_ + num4 + 400, Enum70.const_0);
					class2.enum70_0 = Enum70.const_2;
					class.class26_0.Add(class2);
					class2 = new Class746(TransformationType.Fade, 0f, 1f, int_ + num4, int_ + num4 + 400, Enum70.const_0);
					num4 += 400;
					class2.enum70_0 = Enum70.const_2;
					class.class26_0.Add(class2);
					this.list_5.Add(class);
					class = new Class531(Class885.Load("hit100k", Enum112.flag_6), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2(240f, 220f), 0.9f, true, Color.get_TransparentWhite(), null);
					class2 = new Class746(TransformationType.Scale, 1f * num, 0.5f * num, int_ + num4, int_ + num4 + 400, Enum70.const_0);
					class2.enum70_0 = Enum70.const_2;
					class.class26_0.Add(class2);
					class2 = new Class746(TransformationType.Fade, 0f, 1f, int_ + num4, int_ + num4 + 400, Enum70.const_0);
					num4 += 400;
					class2.enum70_0 = Enum70.const_2;
					class.class26_0.Add(class2);
					this.list_5.Add(class);
					class = new Class531(Class885.Load("hit0", Enum112.flag_6), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2(240f, 280f), 0.9f, true, Color.get_TransparentWhite(), null);
					class2 = new Class746(TransformationType.Scale, 1f * num, 0.5f * num, int_ + num4, int_ + num4 + 400, Enum70.const_0);
					class2.enum70_0 = Enum70.const_2;
					class.class26_0.Add(class2);
					class2 = new Class746(TransformationType.Fade, 0f, 1f, int_ + num4, int_ + num4 + 400, Enum70.const_0);
					num4 += 400;
					class2.enum70_0 = Enum70.const_2;
					class.class26_0.Add(class2);
					this.list_5.Add(class);
				}
				class = new Class531(Class885.Load("ranking-maxcombo", Enum112.flag_6), Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(5f, (float)(320 - (Class885.smethod_25() ? 20 : 8))), 0.81f, true, Color.get_TransparentWhite(), null);
				class2 = new Class746(TransformationType.Fade, 0f, 1f, int_ + num4, int_ + num4 + 400, Enum70.const_0);
				num4 += 400;
				class2.enum70_0 = Enum70.const_2;
				class.class26_0.Add(class2);
				this.list_5.Add(class);
				class = new Class531(Class885.Load("ranking-accuracy", Enum112.flag_6), Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(182f, (float)(320 - (Class885.smethod_25() ? 20 : 8))), 0.81f, true, Color.get_TransparentWhite(), null);
				class2 = new Class746(TransformationType.Fade, 0f, 1f, int_ + num4, int_ + num4 + 400, Enum70.const_0);
				num4 += 400;
				class2.enum70_0 = Enum70.const_2;
				class.class26_0.Add(class2);
				this.list_5.Add(class);
				class = new Class531(Class885.Load("ranking-graph", Enum112.flag_6), Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(56f, (float)(Class885.smethod_25() ? 415 : 375)), 0.8f, true, Color.get_White(), null);
				class.float_2 = 1.22f;
				this.list_5.Add(class);
				float num5 = 0.66f;
				int j;
				for (j = num3; j < this.list_5.Count; j++)
				{
					Class531 class3 = this.list_5[j];
					class3.float_2 *= num5;
					class3.vector2_1.X = 40f + (class3.vector2_1.X - 40f) * num5 + (float)num2;
					class3.vector2_1.Y = 160f + (class3.vector2_1.Y - 160f) * num5 + 18f;
					this.class911_2.Add(class3);
				}
				num3 = j;
				num2 = Class115.smethod_43() - 279;
			}
		}

		// Token: 0x060029D6 RID: 10710
		// RVA: 0x00020204 File Offset: 0x0001E404
		[CompilerGenerated]
		private void method_20(object sender, EventArgs e)
		{
			this.method_18(SlotTeams.Blue, (int)sender, false);
		}

		// Token: 0x060029D7 RID: 10711
		// RVA: 0x00020214 File Offset: 0x0001E414
		[CompilerGenerated]
		private void method_21(object sender, EventArgs e)
		{
			this.method_18(SlotTeams.Red, (int)sender, false);
		}

		// Token: 0x060029CC RID: 10700
		// RVA: 0x000201BB File Offset: 0x0001E3BB
		protected override void vmethod_10()
		{
			base.vmethod_10();
		}

		// Token: 0x060029CD RID: 10701
		// RVA: 0x000201C3 File Offset: 0x0001E3C3
		protected override void vmethod_11()
		{
			base.vmethod_11();
		}

		// Token: 0x060029CF RID: 10703
		// RVA: 0x0000653E File Offset: 0x0000473E
		protected override void vmethod_6(Class512 class512_3)
		{
		}

		// Token: 0x060029CE RID: 10702
		// RVA: 0x0000653E File Offset: 0x0000473E
		protected override void vmethod_8(int int_3)
		{
		}

		// Token: 0x060029CB RID: 10699
		// RVA: 0x0000653E File Offset: 0x0000473E
		protected override void vmethod_9()
		{
		}
	}
}
