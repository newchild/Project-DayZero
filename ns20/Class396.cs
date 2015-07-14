using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns77;
using ns79;
using ns80;
using osu.Graphics.Sprites;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns20
{
	// Token: 0x020003A6 RID: 934
	internal sealed class Class396 : Class390
	{
		// Token: 0x020003A7 RID: 935
		[CompilerGenerated]
		private sealed class Class402
		{
			// Token: 0x040016E7 RID: 5863
			public float float_0;

			// Token: 0x06001CDB RID: 7387
			// RVA: 0x00017C21 File Offset: 0x00015E21
			public void method_0(Class531 class531_0)
			{
				class531_0.float_2 = this.float_0;
			}
		}

		// Token: 0x040016E3 RID: 5859
		private float float_2 = 80f;

		// Token: 0x040016E5 RID: 5861
		private int int_0;

		// Token: 0x040016E4 RID: 5860
		private List<Class531> list_1 = new List<Class531>();

		// Token: 0x040016E6 RID: 5862
		private string[][] string_0 = new string[][]
		{
			new string[]
			{
				"hitcircle(0,78,155)|hitcircleoverlay|{default}-1",
				"hit50",
				"hit100",
				"hit300"
			},
			new string[]
			{
				"hit0",
				"hit100k",
				"hit300g"
			},
			new string[]
			{
				"{default}-0",
				"{default}-1",
				"{default}-2",
				"{default}-3",
				"{default}-4",
				"{default}-5"
			},
			new string[]
			{
				"{score}-0",
				"{score}-1",
				"{score}-2",
				"{score}-3",
				"{score}-4",
				"{score}-5"
			}
		};

		// Token: 0x06001CD5 RID: 7381
		// RVA: 0x0009A494 File Offset: 0x00098694
		public Class396()
		{
			Class531 class = new Class531(null, Vector2.get_Zero(), Enum112.flag_6, Origins.Centre, Enum115.const_5);
			class.bool_1 = true;
			Class530 arg_12A_0 = class;
			EventHandler eventHandler_ = delegate(object sender, EventArgs e)
			{
				this.method_14();
			};
			arg_12A_0.method_2(eventHandler_);
			this.class911_0.Add(class);
			this.method_15();
			base.method_1(new Vector2(244f, this.float_2));
			Class885.smethod_0(new VoidDelegate(this.method_13));
		}

		// Token: 0x06001CD4 RID: 7380
		// RVA: 0x00017BD9 File Offset: 0x00015DD9
		public override void Dispose()
		{
			Class885.smethod_1(new VoidDelegate(this.method_13));
			base.Dispose();
		}

		// Token: 0x06001CD6 RID: 7382
		// RVA: 0x00017BF2 File Offset: 0x00015DF2
		private void method_13()
		{
			this.method_15();
		}

		// Token: 0x06001CD7 RID: 7383
		// RVA: 0x00017BFA File Offset: 0x00015DFA
		private void method_14()
		{
			this.int_0 = (this.int_0 + 1) % this.string_0.Length;
			this.method_15();
		}

		// Token: 0x06001CD8 RID: 7384
		// RVA: 0x0009A60C File Offset: 0x0009880C
		private void method_15()
		{
			foreach (Class531 current in this.list_1)
			{
				current.method_16(100, Enum70.const_0);
				current.bool_0 = false;
			}
			this.list_1.Clear();
			int num = this.string_0[this.int_0].Length;
			for (int i = 0; i < num; i++)
			{
				Class396.Class402 class = new Class396.Class402();
				class.float_0 = 1f;
				List<Class531> list = new List<Class531>();
				float num2 = 0f;
				string[] array = this.string_0[this.int_0][i].Split(new char[]
				{
					'|'
				});
				for (int j = 0; j < array.Length; j++)
				{
					string text = array[j];
					Color white = Color.get_White();
					string text2 = text;
					if (text2.IndexOf('(') > 0)
					{
						int num3 = text2.IndexOf('(');
						text2 = text2.Remove(num3);
						string[] array2 = text.Substring(num3 + 1).TrimEnd(new char[]
						{
							')'
						}).Split(new char[]
						{
							','
						});
						white..ctor(byte.Parse(array2[0]), byte.Parse(array2[1]), byte.Parse(array2[2]));
					}
					text2 = text2.Replace("{default}", Class885.class547_0.string_3);
					text2 = text2.Replace("{score}", Class885.class547_0.string_4);
					Class531 class2 = new Class531(text2, new Vector2((float)((i + 1) * 244 / (num + 1)), this.float_2 / 2f), Enum112.flag_5, Origins.Centre, Enum115.const_5);
					Class530 arg_1AC_0 = class2;
					float expr_19D = num2;
					num2 = expr_19D + 1f;
					arg_1AC_0.float_0 = expr_19D / 100f;
					class2.color_0 = white;
					Class531 class3 = class2;
					class.float_0 = Math.Min(class.float_0, Math.Min((float)(244 / (num + 1)) / ((float)class3.int_4 / 1.6f), this.float_2 / ((float)class3.int_1 / 1.6f)));
					list.Add(class3);
					class3.method_15(50);
				}
				list.ForEach(new Action<Class531>(class.method_0));
				this.list_1.AddRange(list);
				this.class911_0.Add<Class531>(list);
			}
		}
	}
}
