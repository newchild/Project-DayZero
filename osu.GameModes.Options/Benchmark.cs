using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ns14;
using ns17;
using ns22;
using ns29;
using ns77;
using ns79;
using ns80;
using ns81;
using ns82;
using ns84;
using osu.GameModes.Play.Components;
using osu.Graphics.Sprites;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace osu.GameModes.Options
{
	// Token: 0x0200039E RID: 926
	internal sealed class Benchmark : Class61
	{
		// Token: 0x0200039F RID: 927
		private enum Stages
		{
			// Token: 0x040016C2 RID: 5826
			Idle,
			// Token: 0x040016C3 RID: 5827
			Start,
			// Token: 0x040016C4 RID: 5828
			IdleFramerate,
			// Token: 0x040016C5 RID: 5829
			TextRendering,
			// Token: 0x040016C6 RID: 5830
			FillRate,
			// Token: 0x040016C7 RID: 5831
			TexturedFillRate,
			// Token: 0x040016C8 RID: 5832
			TextureLoading,
			// Token: 0x040016C9 RID: 5833
			Threading,
			// Token: 0x040016CA RID: 5834
			CPUPerformance,
			// Token: 0x040016CB RID: 5835
			GarbageCollection,
			// Token: 0x040016CC RID: 5836
			Finished
		}

		// Token: 0x040016BF RID: 5823
		[CompilerGenerated]
		private static Action<Class530> action_0;

		// Token: 0x040016C0 RID: 5824
		[CompilerGenerated]
		private static Action<Class530> action_1;

		// Token: 0x040016B8 RID: 5816
		private bool bool_2;

		// Token: 0x040016BD RID: 5821
		private bool bool_3;

		// Token: 0x040016BC RID: 5820
		private Class533 class533_0;

		// Token: 0x040016BE RID: 5822
		private Class658 class658_0;

		// Token: 0x040016B6 RID: 5814
		private Class911 class911_1 = new Class911(true);

		// Token: 0x040016B7 RID: 5815
		private Class911 class911_2 = new Class911(true);

		// Token: 0x040016BA RID: 5818
		private Dictionary<Benchmark.Stages, int> dictionary_0 = new Dictionary<Benchmark.Stages, int>();

		// Token: 0x040016BB RID: 5819
		private double double_0;

		// Token: 0x040016B9 RID: 5817
		private Benchmark.Stages stages_0;

		// Token: 0x06001C95 RID: 7317
		// RVA: 0x00017853 File Offset: 0x00015A53
		public Benchmark(Class115 class115_0) : base(class115_0)
		{
		}

		// Token: 0x06001C98 RID: 7320
		// RVA: 0x000178A3 File Offset: 0x00015AA3
		protected override void Dispose(bool bool_4)
		{
			this.class911_1.Dispose();
			this.class911_2.Dispose();
			this.class658_0.Dispose();
			Class570.smethod_1(new Class570.Delegate44(this.method_4));
			base.Dispose(bool_4);
		}

		// Token: 0x06001C99 RID: 7321
		// RVA: 0x000178DE File Offset: 0x00015ADE
		public override void Draw()
		{
			base.Draw();
			this.class911_2.Draw();
			this.class911_1.Draw();
		}

		// Token: 0x06001C9A RID: 7322
		// RVA: 0x000992E4 File Offset: 0x000974E4
		public override void imethod_2()
		{
			VoidDelegate voidDelegate = null;
			base.imethod_2();
			this.class658_0.vmethod_0((float)(this.double_0 / 6000.0));
			if (!this.bool_2)
			{
				return;
			}
			this.double_0 += Class115.double_9;
			if (this.double_0 > 6000.0)
			{
				this.method_2();
				return;
			}
			if (this.double_0 > 5000.0)
			{
				if (!this.bool_3)
				{
					List<Class530> arg_99_0 = this.class911_2.list_2;
					if (Benchmark.action_0 == null)
					{
						Benchmark.action_0 = new Action<Class530>(Benchmark.smethod_0);
					}
					arg_99_0.ForEach(Benchmark.action_0);
					this.bool_3 = true;
				}
				GC.Collect();
			}
			if (this.dictionary_0.ContainsKey(this.stages_0))
			{
				Dictionary<Benchmark.Stages, int> dictionary;
				Benchmark.Stages key;
				(dictionary = this.dictionary_0)[key = this.stages_0] = dictionary[key] + 1;
			}
			if (this.bool_3)
			{
				return;
			}
			switch (this.stages_0)
			{
			case Benchmark.Stages.TextRendering:
				if (this.class911_2.list_2.Count == 0)
				{
					for (int i = 0; i < 4; i++)
					{
						this.class911_2.Add(new Class533("Testing text rendering", 20f, new Vector2((float)Class562.smethod_1(0, Class115.int_22), (float)Class562.smethod_1(0, Class115.int_23)), new Vector2(400f, 0f), 1f, true, Color.get_White(), true)
						{
							enum72_0 = Enum72.const_2,
							origins_0 = Origins.Centre
						});
					}
				}
				for (int j = 0; j < 4; j++)
				{
					((Class533)this.class911_2.list_2[j]).Text = Class562.smethod_2().ToString();
				}
				return;
			case Benchmark.Stages.FillRate:
				if (this.class911_2.list_2.Count == 0)
				{
					for (int k = 0; k < 10; k++)
					{
						Class531 class = new Class531(Class115.class731_0, Enum115.const_4, Origins.TopLeft, Enum114.const_0, Vector2.get_Zero(), 0f, true, new Color((byte)Class562.smethod_1(0, 255), (byte)Class562.smethod_1(0, 255), (byte)Class562.smethod_1(0, 255), 255), null)
						{
							bool_7 = true,
							vector2_2 = new Vector2((float)Class115.int_22, (float)(Class115.int_23 + Class115.int_25))
						};
						class.method_15(Class562.smethod_1(10000, 30000));
						this.class911_2.Add(class);
					}
					return;
				}
				break;
			case Benchmark.Stages.TexturedFillRate:
				if (this.class911_2.list_2.Count == 0)
				{
					for (int l = 0; l < 10; l++)
					{
						Class531 class2 = new Class531(Class885.Load("menu-background", Enum112.flag_1), Enum115.const_4, Origins.TopLeft, Enum114.const_0, Vector2.get_Zero(), 0f, true, Color.get_White(), null);
						if ((float)(Class115.int_22 / Class115.int_23) > 1.6f)
						{
							class2.vector2_2 = new Vector2((float)Class115.int_22 / Class115.float_4 / (float)Class115.int_20, (float)Class115.int_23 / Class115.float_4 / (float)Class115.int_19);
						}
						class2.bool_7 = true;
						class2.method_15(20000);
						this.class911_2.Add(class2);
					}
				}
				break;
			case Benchmark.Stages.TextureLoading:
			{
				Class885.smethod_14(false);
				Class531 class3 = new Class531(Class885.Load("sliderb" + Class562.smethod_1(0, 10), Enum112.flag_1), Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2((float)Class562.smethod_1(0, Class115.int_22), (float)Class562.smethod_1(0, Class115.int_23)), 0f, false, Color.get_White(), null)
				{
					bool_7 = true
				};
				class3.method_17(500);
				this.class911_2.Add(class3);
				List<Class530> arg_3F2_0 = this.class911_2.list_2;
				if (Benchmark.action_1 == null)
				{
					Benchmark.action_1 = new Action<Class530>(Benchmark.smethod_1);
				}
				arg_3F2_0.ForEach(Benchmark.action_1);
				return;
			}
			case Benchmark.Stages.Threading:
				if (this.class911_2.list_2.Count == 0)
				{
					Class531 class4 = new Class531(Class115.class731_0, Enum115.const_4, Origins.TopLeft, Enum114.const_0, Vector2.get_Zero(), 0f, true, Color.get_Orange(), null)
					{
						bool_7 = true,
						vector2_2 = new Vector2((float)Class115.int_22, (float)(Class115.int_23 + Class115.int_25))
					};
					class4.method_15(5000);
					this.class911_2.Add(class4);
					for (int m = 0; m < 2; m++)
					{
						if (voidDelegate == null)
						{
							voidDelegate = new VoidDelegate(this.method_5);
						}
						Class115.smethod_88(voidDelegate, false, ThreadPriority.Normal);
					}
					return;
				}
				break;
			case Benchmark.Stages.CPUPerformance:
			case Benchmark.Stages.GarbageCollection:
			{
				Color color_ = Color.get_MediumPurple();
				if (this.stages_0 == Benchmark.Stages.CPUPerformance)
				{
					this.class911_2.Clear(true);
					color_ = Color.get_GreenYellow();
				}
				else
				{
					this.class911_2.list_2.Clear();
				}
				for (int n = 0; n < 1000; n++)
				{
					this.class911_2.Add(new Class531(Class115.class731_0, Enum115.const_4, Origins.TopLeft, Enum114.const_0, new Vector2((float)Class562.smethod_1(0, Class115.int_22), (float)Class562.smethod_1(0, Class115.int_23)), 0f, true, color_, null)
					{
						float_3 = 1f,
						bool_7 = true
					});
				}
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x06001C96 RID: 7318
		// RVA: 0x0009922C File Offset: 0x0009742C
		public override void Initialize()
		{
			this.class533_0 = new Class533("Please click to start the benchmark.\nWhile running do not move your mouse or switch windows.", 20f, new Vector2(0f, 0f), new Vector2(600f, 0f), 1f, true, Color.get_White(), true)
			{
				enum72_0 = Enum72.const_3,
				origins_0 = Origins.Centre,
				enum115_0 = Enum115.const_9
			};
			this.class911_1.Add(this.class533_0);
			base.Initialize();
			Class570.smethod_0(new Class570.Delegate44(this.method_4));
			Class802.smethod_34(Enum96.const_8, new Delegate46(this.method_3), Enum98.const_2, Enum97.const_0);
			this.class658_0 = new Class658(this.class911_1, ProgressBarTypes.Bottom, 34f);
		}

		// Token: 0x06001C97 RID: 7319
		// RVA: 0x0001787F File Offset: 0x00015A7F
		private void method_1()
		{
			if (this.bool_2)
			{
				return;
			}
			this.bool_2 = true;
			this.double_0 = (double)Class115.int_1;
			this.method_2();
		}

		// Token: 0x06001C9B RID: 7323
		// RVA: 0x0009982C File Offset: 0x00097A2C
		private void method_2()
		{
			this.class911_2.Clear(true);
			this.stages_0++;
			this.double_0 = 0.0;
			this.bool_3 = false;
			Benchmark.Stages stages = this.stages_0;
			if (stages == Benchmark.Stages.Start)
			{
				this.class533_0.Text = "Preparing...";
				return;
			}
			if (stages != Benchmark.Stages.Finished)
			{
				this.class533_0.Text = string.Format("Running stage {0} of {1}\n{2}", this.stages_0 - Benchmark.Stages.Start, 8, this.stages_0);
				this.dictionary_0[this.stages_0] = 0;
				return;
			}
			this.class533_0.enum72_0 = Enum72.const_3;
			this.class533_0.Text = "Complete!\n";
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = this.dictionary_0[Benchmark.Stages.IdleFramerate];
			foreach (KeyValuePair<Benchmark.Stages, int> current in this.dictionary_0)
			{
				Benchmark.Stages key = current.Key;
				if (key == Benchmark.Stages.IdleFramerate)
				{
					Class533 expr_EE = this.class533_0;
					expr_EE.Text += string.Format("\nIdle framerate: {0}fps\n\nIndividual tests:", current.Value / 6);
					num2 += current.Value;
				}
				else
				{
					int num5 = (int)Math.Min(100f, (float)current.Value / (float)num4 * 100f);
					num3++;
					int num6 = current.Value / 6;
					if (num6 > 120)
					{
						num5 = (int)Math.Min(100f, (float)num5 + (float)(num6 - 120) / 2f);
					}
					num += num5;
					num2 += current.Value;
					Class533 expr_18A = this.class533_0;
					expr_18A.Text += string.Format("\n{0}: {1} ({2}fps)", current.Key, num5, num6);
				}
			}
			Class533 expr_1E0 = this.class533_0;
			expr_1E0.Text = expr_1E0.Text + "\n\nOverall Smoothness: " + num / num3;
			Class533 expr_203 = this.class533_0;
			expr_203.Text = expr_203.Text + "\nRaw Score: " + num2;
			this.bool_2 = false;
			this.stages_0 = Benchmark.Stages.Idle;
		}

		// Token: 0x06001C9C RID: 7324
		// RVA: 0x000178FE File Offset: 0x00015AFE
		private bool method_3(object object_0, EventArgs eventArgs_0)
		{
			if (!this.bool_2)
			{
				this.method_1();
				return true;
			}
			return false;
		}

		// Token: 0x06001C9D RID: 7325
		// RVA: 0x00017911 File Offset: 0x00015B11
		private bool method_4(object object_0, Keys keys_0)
		{
			if (keys_0 == 27)
			{
				Class115.smethod_70(OsuModes.Menu, false);
				return true;
			}
			return false;
		}

		// Token: 0x06001CA0 RID: 7328
		// RVA: 0x0001795A File Offset: 0x00015B5A
		[CompilerGenerated]
		private void method_5()
		{
			while (this.double_0 < 5000.0)
			{
				Thread.SpinWait(1);
			}
		}

		// Token: 0x06001C9E RID: 7326
		// RVA: 0x00017922 File Offset: 0x00015B22
		[CompilerGenerated]
		private static void smethod_0(Class530 class530_0)
		{
			class530_0.method_16(300, Enum70.const_0);
		}

		// Token: 0x06001C9F RID: 7327
		// RVA: 0x00017930 File Offset: 0x00015B30
		[CompilerGenerated]
		private static void smethod_1(Class530 class530_0)
		{
			((Class531)class530_0).vmethod_7(Class885.Load("sliderb" + Class562.smethod_1(0, 10), Enum112.flag_1));
		}
	}
}
