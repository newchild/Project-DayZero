using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns14;
using ns24;
using ns25;
using ns26;
using ns27;
using ns29;
using ns30;
using ns40;
using ns64;
using ns77;
using ns79;
using ns8;
using ns80;
using ns90;
using osu;
using osu.Graphics.Sprites;
using osu_common;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns74
{
	// Token: 0x02000522 RID: 1314
	internal sealed class Class690
	{
		// Token: 0x02000523 RID: 1315
		[CompilerGenerated]
		private sealed class Class691
		{
			// Token: 0x04002358 RID: 9048
			public EventHandler eventHandler_0;

			// Token: 0x04002356 RID: 9046
			public LinkId linkId_0;

			// Token: 0x04002357 RID: 9047
			public string string_0;

			// Token: 0x06002AA4 RID: 10916
			// RVA: 0x00113C5C File Offset: 0x00111E5C
			public void method_0(string string_1, Exception exception_0)
			{
				if (string_1.Length > 0)
				{
					Class690 class = new Class690(string_1, this.linkId_0, this.string_0);
					if (this.linkId_0 == LinkId.Beatmap)
					{
						try
						{
							class.int_5 = int.Parse(this.string_0);
						}
						catch
						{
						}
					}
					this.eventHandler_0(class, null);
					return;
				}
				this.eventHandler_0(null, null);
			}
		}

		// Token: 0x04002354 RID: 9044
		[CompilerGenerated]
		private static Action<Class531> action_0;

		// Token: 0x04002355 RID: 9045
		[CompilerGenerated]
		private static Action<Class531> action_1;

		// Token: 0x0400233F RID: 9023
		private bool bool_0;

		// Token: 0x04002340 RID: 9024
		internal bool bool_1;

		// Token: 0x04002342 RID: 9026
		internal bool bool_2;

		// Token: 0x0400234F RID: 9039
		private bool bool_3;

		// Token: 0x0400233E RID: 9022
		private Class531 class531_0;

		// Token: 0x04002346 RID: 9030
		private Class531 class531_1;

		// Token: 0x04002347 RID: 9031
		private Class531 class531_2;

		// Token: 0x04002349 RID: 9033
		private Class531 class531_3;

		// Token: 0x0400234C RID: 9036
		private Class531 class531_4;

		// Token: 0x04002343 RID: 9027
		private Class533 class533_0;

		// Token: 0x04002344 RID: 9028
		private Class533 class533_1;

		// Token: 0x04002345 RID: 9029
		private Class533 class533_2;

		// Token: 0x0400234A RID: 9034
		private Class537 class537_0;

		// Token: 0x04002348 RID: 9032
		private Class854 class854_0;

		// Token: 0x04002337 RID: 9015
		private readonly DateTime dateTime_0;

		// Token: 0x04002352 RID: 9042
		private EventHandler eventHandler_0;

		// Token: 0x04002353 RID: 9043
		[CompilerGenerated]
		private static EventHandler eventHandler_1;

		// Token: 0x04002338 RID: 9016
		private readonly float float_0;

		// Token: 0x04002339 RID: 9017
		internal readonly int int_0;

		// Token: 0x0400233B RID: 9019
		internal readonly int int_1;

		// Token: 0x0400233C RID: 9020
		internal readonly int int_2;

		// Token: 0x0400234D RID: 9037
		internal int int_3;

		// Token: 0x0400234E RID: 9038
		internal int int_4;

		// Token: 0x04002350 RID: 9040
		internal int int_5;

		// Token: 0x0400234B RID: 9035
		internal List<Class531> list_0;

		// Token: 0x04002335 RID: 9013
		internal readonly string string_0;

		// Token: 0x04002336 RID: 9014
		internal readonly string string_1;

		// Token: 0x0400233D RID: 9021
		internal readonly string string_2;

		// Token: 0x04002341 RID: 9025
		internal string string_3;

		// Token: 0x04002351 RID: 9041
		internal string[] string_4;

		// Token: 0x0400233A RID: 9018
		private readonly SubmissionStatus submissionStatus_0;

		// Token: 0x06002A8D RID: 10893
		// RVA: 0x000209E2 File Offset: 0x0001EBE2
		internal Class690(string string_5) : this(string_5, LinkId.Set, string.Empty)
		{
		}

		// Token: 0x06002A8C RID: 10892
		// RVA: 0x00112D6C File Offset: 0x00110F6C
		internal Class690(string string_5, LinkId linkId_0, string string_6)
		{
			string[] array = string_5.Split(new char[]
			{
				'|'
			});
			int num = 0;
			string[] arg_27_0 = array;
			int arg_27_1 = 0;
			num = 1;
			this.string_3 = arg_27_0[arg_27_1];
			string[] arg_32_0 = array;
			int arg_32_1 = 1;
			num = 2;
			this.string_0 = arg_32_0[arg_32_1];
			string[] arg_3D_0 = array;
			int arg_3D_1 = 2;
			num = 3;
			this.string_2 = arg_3D_0[arg_3D_1];
			string[] arg_48_0 = array;
			int arg_48_1 = 3;
			num = 4;
			this.string_1 = arg_48_0[arg_48_1];
			string[] arg_52_0 = array;
			int arg_52_1 = 4;
			num = 5;
			string text = arg_52_0[arg_52_1];
			string a;
			if ((a = text) != null)
			{
				if (a == "1")
				{
					this.submissionStatus_0 = SubmissionStatus.Ranked;
					goto IL_8F;
				}
				if (a == "2")
				{
					this.submissionStatus_0 = SubmissionStatus.Approved;
					goto IL_8F;
				}
			}
			this.submissionStatus_0 = SubmissionStatus.Pending;
			IL_8F:
			float.TryParse(array[num++], NumberStyles.Any, Class115.numberFormatInfo_0, out this.float_0);
			try
			{
				this.dateTime_0 = Convert.ToDateTime(array[num++]);
			}
			catch
			{
				this.dateTime_0 = DateTime.Now;
			}
			this.int_0 = int.Parse(array[num++]);
			this.int_1 = int.Parse(array[num++]);
			this.bool_2 = (array[num++] == "1");
			this.bool_3 = (array[num++] == "1");
			this.int_4 = int.Parse(array[num++]);
			if (this.bool_2 && array[num].Length > 0)
			{
				this.int_3 = int.Parse(array[num++]);
			}
			num = 13;
			if (13 < array.Length)
			{
				this.string_4 = array[num++].Split(new char[]
				{
					','
				});
			}
			if (linkId_0 == LinkId.Post)
			{
				this.int_2 = int.Parse(string_6);
			}
			this.bool_1 = (Class466.smethod_33(this.int_0) != null);
			if (!this.bool_0)
			{
				Class854 class = Class112.list_0.Find((Class854 class854_1) => class854_1.method_0() == this.string_3);
				if (class != null)
				{
					this.bool_0 = true;
					this.class854_0 = class;
					Class854 expr_1EE = this.class854_0;
					expr_1EE.delegate48_0 = (Delegate48)Delegate.Combine(expr_1EE.delegate48_0, new Delegate48(this.method_8));
					Class854 expr_215 = this.class854_0;
					expr_215.delegate50_0 = (Delegate50)Delegate.Combine(expr_215.delegate50_0, new Delegate50(this.method_6));
					Class854 expr_23C = this.class854_0;
					expr_23C.delegate49_0 = (Delegate49)Delegate.Combine(expr_23C.delegate49_0, new Delegate49(this.method_5));
				}
			}
		}

		// Token: 0x06002A96 RID: 10902
		// RVA: 0x00020A15 File Offset: 0x0001EC15
		internal void Dispose()
		{
			if (this.list_0 == null)
			{
				return;
			}
			List<Class531> arg_2C_0 = this.list_0;
			if (Class690.action_0 == null)
			{
				Class690.action_0 = new Action<Class531>(Class690.smethod_3);
			}
			arg_2C_0.ForEach(Class690.action_0);
			this.class537_0.Dispose();
		}

		// Token: 0x06002A8A RID: 10890
		// RVA: 0x00112CB8 File Offset: 0x00110EB8
		internal string method_0()
		{
			if (this.string_3.Contains(".osz2"))
			{
				return Class34.smethod_1(string.Concat(new object[]
				{
					this.int_0,
					" ",
					this.string_0,
					" - ",
					this.string_2,
					".osz2"
				}));
			}
			return Class34.smethod_1(string.Concat(new object[]
			{
				this.int_0,
				" ",
				this.string_0,
				" - ",
				this.string_2,
				".osz"
			}));
		}

		// Token: 0x06002A8B RID: 10891
		// RVA: 0x000209D4 File Offset: 0x0001EBD4
		internal bool method_1()
		{
			return this.class854_0 != null;
		}

		// Token: 0x06002A99 RID: 10905
		// RVA: 0x00113B4C File Offset: 0x00111D4C
		[CompilerGenerated]
		private void method_10(object sender, EventArgs e)
		{
			this.class531_0.method_39(Class610.smethod_7(this.class531_0.color_0, 50), 100, false, Enum70.const_0);
			Class331.smethod_36(null, "click-short", 1f, false);
		}

		// Token: 0x06002A9A RID: 10906
		// RVA: 0x00020AA4 File Offset: 0x0001ECA4
		[CompilerGenerated]
		private void method_11(object sender, EventArgs e)
		{
			if (!this.bool_0)
			{
				this.class531_0.method_39(Class610.smethod_7(this.class531_0.color_0, 25), 100, false, Enum70.const_0);
			}
		}

		// Token: 0x06002A9B RID: 10907
		// RVA: 0x00113B94 File Offset: 0x00111D94
		[CompilerGenerated]
		private void method_12(object sender, EventArgs e)
		{
			Class331.smethod_36(null, "click-short-confirm", 1f, false);
			if (Class112.class690_0 == this)
			{
				this.method_3(false);
				return;
			}
			Class112.smethod_8(this);
		}

		// Token: 0x06002A9C RID: 10908
		// RVA: 0x00020AD0 File Offset: 0x0001ECD0
		[CompilerGenerated]
		private void method_13()
		{
			this.class537_0.method_15(400);
		}

		// Token: 0x06002A9D RID: 10909
		// RVA: 0x00020AE3 File Offset: 0x0001ECE3
		[CompilerGenerated]
		private void method_14(object sender, EventArgs e)
		{
			this.bool_1 = false;
			this.method_3(false);
			this.bool_1 = true;
		}

		// Token: 0x06002A9F RID: 10911
		// RVA: 0x00113BD0 File Offset: 0x00111DD0
		[CompilerGenerated]
		private void method_15(Class854 class854_1)
		{
			this.class854_0 = class854_1;
			Class854 expr_0D = this.class854_0;
			expr_0D.delegate48_0 = (Delegate48)Delegate.Combine(expr_0D.delegate48_0, new Delegate48(this.method_8));
			Class854 expr_34 = this.class854_0;
			expr_34.delegate50_0 = (Delegate50)Delegate.Combine(expr_34.delegate50_0, new Delegate50(this.method_6));
			Class854 expr_5B = this.class854_0;
			expr_5B.delegate49_0 = (Delegate49)Delegate.Combine(expr_5B.delegate49_0, new Delegate49(this.method_5));
		}

		// Token: 0x06002AA0 RID: 10912
		// RVA: 0x00020AFA File Offset: 0x0001ECFA
		[CompilerGenerated]
		private void method_16()
		{
			this.class531_0.method_39(Class610.smethod_7(this.class531_0.color_0, 25), 800, false, Enum70.const_0);
		}

		// Token: 0x06002A8F RID: 10895
		// RVA: 0x001130B4 File Offset: 0x001112B4
		internal bool method_2(Vector2 vector2_0)
		{
			EventHandler eventHandler = null;
			EventHandler eventHandler2 = null;
			EventHandler eventHandler3 = null;
			VoidDelegate voidDelegate = null;
			bool result;
			if (result = (this.list_0 == null))
			{
				this.list_0 = new List<Class531>();
				this.class531_0 = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_0, vector2_0, 0.8f, true, this.bool_1 ? new Color(134, 180, 255, 100) : new Color(255, 255, 255, 25), null);
				this.class531_0.vector2_2 = new Vector2((float)Class690.smethod_0(), 28f);
				this.class531_0.float_2 = 1.6f;
				if (!this.bool_1)
				{
					Class531 arg_C5_0 = this.class531_0;
					if (eventHandler == null)
					{
						eventHandler = new EventHandler(this.method_10);
					}
					arg_C5_0.method_35(eventHandler);
					Class531 arg_E4_0 = this.class531_0;
					if (eventHandler2 == null)
					{
						eventHandler2 = new EventHandler(this.method_11);
					}
					arg_E4_0.method_37(eventHandler2);
				}
				this.class531_0.bool_1 = true;
				this.class531_0.bool_2 = true;
				Class530 arg_11B_0 = this.class531_0;
				if (eventHandler3 == null)
				{
					eventHandler3 = new EventHandler(this.method_12);
				}
				arg_11B_0.method_2(eventHandler3);
				this.class531_3 = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_0, vector2_0, 0.801f, true, new Color(163, 236, 85, 200), null);
				this.class531_3.vector2_2 = new Vector2(0f, 28f);
				this.class531_3.float_2 = 1.6f;
				this.list_0.Add(this.class531_3);
				this.class537_0 = new Class537("http://b.ppy.sh/thumb/" + this.int_0 + ".jpg", "Data\\bt\\" + this.int_0 + ".jpg", 500, vector2_0, 0.8f);
				this.class537_0.float_2 = 0.65f;
				this.list_0.Add(this.class537_0);
				Class537 arg_211_0 = this.class537_0;
				if (voidDelegate == null)
				{
					voidDelegate = new VoidDelegate(this.method_13);
				}
				arg_211_0.method_55(voidDelegate);
				this.list_0.Add(this.class531_0);
				string str;
				switch (this.submissionStatus_0)
				{
				case SubmissionStatus.Ranked:
					str = "ranked";
					break;
				case SubmissionStatus.Approved:
					str = "approved";
					break;
				default:
					str = "question";
					break;
				}
				this.class531_4 = new Class531(Class885.Load("selection-" + str, Enum112.flag_1), Enum115.const_5, Origins.Centre, Enum114.const_0, vector2_0 + new Vector2((float)(Class690.smethod_0() - 12), 19f), 0.9f, true, Color.get_TransparentWhite(), null);
				this.class531_4.float_2 = 0.8f;
				this.list_0.Add(this.class531_4);
				this.class533_0 = new Class533((this.string_0.Length > 0) ? (this.string_0 + " - " + this.string_2) : this.string_2, 12f, vector2_0 + new Vector2(32f, 0f), 0.9f, true, Color.get_White());
				this.class533_0.bool_16 = true;
				this.list_0.Add(this.class533_0);
				this.class533_1 = new Class533(this.string_1, 12f, vector2_0 + new Vector2((float)Class690.smethod_0(), 0f), 0.9f, true, Color.get_White());
				this.class533_1.origins_0 = Origins.TopRight;
				this.class533_1.bool_16 = true;
				this.list_0.Add(this.class533_1);
				this.class533_2 = new Class533("Last Updated: " + this.dateTime_0, 10f, vector2_0 + new Vector2(32f, 11f), 0.9f, true, Color.get_White());
				this.list_0.Add(this.class533_2);
				if (this.string_4 != null && this.string_4.Length > 0)
				{
					int num = Class690.smethod_0() - 60;
					string text = "mode-taiko-small";
					string[] array = this.string_4;
					for (int i = 0; i < array.Length; i++)
					{
						string text2 = array[i];
						string[] array2 = text2.Split(new char[]
						{
							'@'
						});
						if (array2.Length > 1)
						{
							string a;
							if ((a = array2[1]) != null)
							{
								if (a == "1")
								{
									text = "mode-taiko-small";
									goto IL_49A;
								}
								if (a == "2")
								{
									text = "mode-fruits-small";
									goto IL_49A;
								}
								if (a == "3")
								{
									text = "mode-mania-small";
									goto IL_49A;
								}
							}
							text = "mode-osu-small";
						}
						IL_49A:
						Class531 class = new Class531(Class885.Load(text, Enum112.flag_1), Enum115.const_5, Origins.CentreLeft, Enum114.const_0, vector2_0 + new Vector2((float)num, 19f), 0.81f, true, Color.get_White(), null);
						class.bool_1 = true;
						class.string_0 = array2[0];
						class.float_2 = 0.78f;
						class.class746_1 = new Class746(Color.get_White(), Color.get_Orange(), 0, 200);
						this.list_0.Add(class);
						num -= 20;
						if (num < Class690.smethod_0() - 70 - 240)
						{
							break;
						}
					}
				}
				if (this.submissionStatus_0 == SubmissionStatus.Ranked || this.submissionStatus_0 == SubmissionStatus.Approved)
				{
					this.class531_1 = new Class531(Class885.Load("levelbar", Enum112.flag_1), vector2_0 + new Vector2(0f, 23f), 0.84f, true, Color.get_Black());
					this.class531_1.method_45(true);
					this.class531_1.int_4 = 180;
					this.list_0.Add(this.class531_1);
					Color color_;
					if (this.float_0 > 9f)
					{
						color_..ctor(250, 83, 38, 255);
					}
					else if (this.float_0 > 8f)
					{
						color_..ctor(250, 218, 38, 255);
					}
					else if (this.float_0 > 7f)
					{
						color_..ctor(38, 123, 250, 255);
					}
					else
					{
						color_..ctor(178, 207, 222, 255);
					}
					this.class531_2 = new Class531(Class885.Load("levelbar", Enum112.flag_1), vector2_0 + new Vector2(0f, 23f), 0.85f, true, color_);
					this.class531_2.int_4 = (int)(180f * ((this.float_0 - 4f) / 6f));
					this.class531_2.method_45(true);
					this.list_0.Add(this.class531_2);
					this.class531_2.class26_0.Add(new Class746(TransformationType.VectorScale, new Vector2(0f, 1f), new Vector2(1f, 1f), Class115.int_1, Class115.int_1 + (int)(this.float_0 * 100f), Enum70.const_1));
				}
				using (List<Class531>.Enumerator enumerator = this.list_0.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Class531 current = enumerator.Current;
						current.method_15(300);
					}
					return result;
				}
			}
			Vector2 vector2_ = this.list_0[1].vector2_0;
			foreach (Class531 current2 in this.list_0)
			{
				Vector2 vector2_2 = vector2_0 + (current2.vector2_0 - vector2_);
				current2.method_19(vector2_2, Class690.smethod_0(), Enum70.const_1);
			}
			return result;
		}

		// Token: 0x06002A90 RID: 10896
		// RVA: 0x00113888 File Offset: 0x00111A88
		internal void method_3(bool bool_4)
		{
			EventHandler eventHandler = null;
			VoidDelegate voidDelegate = null;
			if (Class115.bool_16 && this.bool_2)
			{
				bool_4 = true;
			}
			Class621.smethod_0("Downloading " + this.string_2);
			if (this.class854_0 != null)
			{
				this.class854_0.Abort(true);
				return;
			}
			if (string.IsNullOrEmpty(this.string_3))
			{
				Class723.smethod_1("Can't download this file (please report this)", 2000);
				return;
			}
			if (this.bool_1)
			{
				Class89 class = new Class89("You already have a copy of this beatmap!  Are you sure you want to download it again?", true);
				Class89 arg_90_0 = class;
				string arg_90_1 = "Yes, redownload this map!";
				Color arg_90_2 = Color.get_YellowGreen();
				if (eventHandler == null)
				{
					eventHandler = new EventHandler(this.method_14);
				}
				arg_90_0.method_3(arg_90_1, arg_90_2, eventHandler, true, false, true);
				Class89 arg_C0_0 = class;
				string arg_C0_1 = "No, forget it.";
				Color arg_C0_2 = Color.get_OrangeRed();
				if (Class690.eventHandler_1 == null)
				{
					Class690.eventHandler_1 = new EventHandler(Class690.smethod_2);
				}
				arg_C0_0.method_3(arg_C0_1, arg_C0_2, Class690.eventHandler_1, true, false, true);
				Class115.smethod_37(class);
				return;
			}
			if (!Class112.smethod_2(this, bool_4, new Delegate47(this.method_15)))
			{
				return;
			}
			this.bool_0 = true;
			if (this.list_0 != null)
			{
				this.class531_0.method_39(Color.get_YellowGreen(), Class690.smethod_0(), false, Enum70.const_0);
				Class47 arg_125_0 = Class115.class47_0;
				if (voidDelegate == null)
				{
					voidDelegate = new VoidDelegate(this.method_16);
				}
				arg_125_0.method_1(voidDelegate, Class690.smethod_0(), false);
				Class533 expr_130 = this.class533_0;
				expr_130.Text += " [Downloading]";
			}
		}

		// Token: 0x06002A91 RID: 10897
		// RVA: 0x001139DC File Offset: 0x00111BDC
		private void method_4()
		{
			if (this.list_0 != null)
			{
				this.class531_0.method_39(this.bool_1 ? new Color(134, 180, 255, 100) : new Color(255, 255, 255, 25), Class690.smethod_0(), false, Enum70.const_0);
				Class530 arg_6F_0 = this.class531_3;
				Class690.smethod_0();
				arg_6F_0.vector2_2 = new Vector2(0f, 28f);
				this.class533_0.Text = this.class533_0.Text.Replace(" [Downloading]", "");
			}
			this.bool_0 = false;
			this.class854_0 = null;
		}

		// Token: 0x06002A92 RID: 10898
		// RVA: 0x00113A90 File Offset: 0x00111C90
		private void method_5(double double_0)
		{
			float num = (float)double_0;
			if (this.list_0 != null)
			{
				this.class531_3.vector2_2 = new Vector2(num * (float)Class690.smethod_0(), 28f);
			}
		}

		// Token: 0x06002A93 RID: 10899
		// RVA: 0x00113AC8 File Offset: 0x00111CC8
		private void method_6(bool bool_4)
		{
			if (bool_4)
			{
				Class723.smethod_5("Finished downloading " + this.string_2, Color.get_White(), 3000, null);
				if (this.eventHandler_0 != null)
				{
					this.eventHandler_0(this, null);
					return;
				}
			}
			else
			{
				this.method_4();
			}
		}

		// Token: 0x06002A94 RID: 10900
		// RVA: 0x00113B14 File Offset: 0x00111D14
		internal void method_7(EventHandler eventHandler_2)
		{
			EventHandler eventHandler = this.eventHandler_0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_2);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06002A95 RID: 10901
		// RVA: 0x000209F1 File Offset: 0x0001EBF1
		private void method_8()
		{
			if (Class115.osuModes_1 != OsuModes.Play)
			{
				Class723.smethod_1("Downloading " + this.string_2, 1000);
			}
		}

		// Token: 0x06002A97 RID: 10903
		// RVA: 0x00020A53 File Offset: 0x0001EC53
		internal void method_9()
		{
			if (this.list_0 == null)
			{
				return;
			}
			this.class537_0.Dispose();
			List<Class531> arg_37_0 = this.list_0;
			if (Class690.action_1 == null)
			{
				Class690.action_1 = new Action<Class531>(Class690.smethod_4);
			}
			arg_37_0.ForEach(Class690.action_1);
		}

		// Token: 0x06002A89 RID: 10889
		// RVA: 0x000209C7 File Offset: 0x0001EBC7
		private static int smethod_0()
		{
			return Class115.smethod_43() - 120 - 30;
		}

		// Token: 0x06002A8E RID: 10894
		// RVA: 0x00112FE8 File Offset: 0x001111E8
		internal static void smethod_1(LinkId linkId_0, string string_5, EventHandler eventHandler_2)
		{
			Class690.Class691 class = new Class690.Class691();
			class.linkId_0 = linkId_0;
			class.string_0 = string_5;
			class.eventHandler_0 = eventHandler_2;
			if ((Class809.class623_0 & Enum30.flag_3) == Enum30.flag_0)
			{
				return;
			}
			if (string.IsNullOrEmpty(class.string_0))
			{
				return;
			}
			if (!Class115.bool_16)
			{
				Class723.smethod_1("Looking up beatmap...", 1000);
			}
			char c = class.linkId_0.ToString().ToLower()[0];
			Class133 class2 = new Class133(string.Format("http://osu.ppy.sh/web/osu-search-set.php?u={0}&h={1}&{2}={3}", new object[]
			{
				Class341.class605_20,
				Class341.class605_17,
				c,
				class.string_0
			}));
			class2.method_0(new Class133.Delegate17(class.method_0));
			Class169.smethod_0(class2);
		}

		// Token: 0x06002A9E RID: 10910
		// RVA: 0x0000653E File Offset: 0x0000473E
		[CompilerGenerated]
		private static void smethod_2(object sender, EventArgs e)
		{
		}

		// Token: 0x06002AA1 RID: 10913
		// RVA: 0x00020B21 File Offset: 0x0001ED21
		[CompilerGenerated]
		private static void smethod_3(Class531 class531_5)
		{
			class531_5.method_16(Class690.smethod_0(), Enum70.const_0);
			class531_5.method_22(new Vector2(50f, 0f), Class690.smethod_0());
			class531_5.bool_0 = false;
		}

		// Token: 0x06002AA2 RID: 10914
		// RVA: 0x00020B51 File Offset: 0x0001ED51
		[CompilerGenerated]
		private static void smethod_4(Class531 class531_5)
		{
			class531_5.method_16(1000, Enum70.const_0);
		}
	}
}
