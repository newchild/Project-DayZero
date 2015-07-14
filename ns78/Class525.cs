using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns18;
using ns29;
using ns77;
using ns79;
using ns80;
using ns82;
using osu.Graphics.Sprites;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns78
{
	// Token: 0x02000636 RID: 1590
	internal sealed class Class525 : Class520
	{
		// Token: 0x02000637 RID: 1591
		[CompilerGenerated]
		private sealed class Class837
		{
			// Token: 0x04002CF1 RID: 11505
			public bool bool_0;

			// Token: 0x04002CF0 RID: 11504
			public Class525 class525_0;

			// Token: 0x06003140 RID: 12608
			// RVA: 0x001428A0 File Offset: 0x00140AA0
			public void method_0()
			{
				if (this.bool_0 == this.class525_0.bool_0)
				{
					return;
				}
				this.class525_0.bool_0 = this.bool_0;
				using (List<Class530>.Enumerator enumerator = this.class525_0.class911_0.list_2.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Class531 class = (Class531)enumerator.Current;
						if (this.class525_0.bool_0)
						{
							class.method_14(500, Enum70.const_0);
							class.method_19(class.vector2_0, 500, Enum70.const_1);
						}
						else
						{
							class.method_16(3000, Enum70.const_0);
							class.method_19(new Vector2(class.vector2_0.X, class.vector2_0.Y - 25f), 1500, Enum70.const_2);
						}
					}
				}
			}
		}

		// Token: 0x04002CEF RID: 11503
		[CompilerGenerated]
		private static Action<Class530> action_0;

		// Token: 0x04002CED RID: 11501
		private bool bool_0;

		// Token: 0x04002CEA RID: 11498
		private Class531 class531_0;

		// Token: 0x04002CEC RID: 11500
		private Class531 class531_1;

		// Token: 0x04002CEB RID: 11499
		private Class533 class533_0;

		// Token: 0x04002CEE RID: 11502
		private string string_0;

		// Token: 0x170003AB RID: 939
		internal string Text
		{
			// Token: 0x06003137 RID: 12599
			// RVA: 0x000245AB File Offset: 0x000227AB
			get
			{
				return this.string_0;
			}
			// Token: 0x06003138 RID: 12600
			// RVA: 0x000245B3 File Offset: 0x000227B3
			set
			{
				this.string_0 = value;
				Class115.class47_0.Add(new VoidDelegate(this.method_1), false);
			}
		}

		// Token: 0x06003136 RID: 12598
		// RVA: 0x001424B8 File Offset: 0x001406B8
		public Class525() : base(false)
		{
			this.class531_1 = new Class531(Class885.Load("notification", Enum112.flag_1), Enum115.const_17, Origins.Centre, Enum114.const_0, new Vector2(0f, 0f), 0.8f, true, new Color(0, 0, 0, 128), null);
			this.class911_0.Add(this.class531_1);
			this.class531_0 = new Class531(Class885.Load("loading-small", Enum112.flag_1), Enum115.const_17, Origins.Centre, Enum114.const_0, new Vector2(-100f, 11f), 1f, true, Color.get_White(), null);
			Class746 class = new Class746(TransformationType.Rotation, 0f, 6.28318548f, Class115.int_1, Class115.int_1 + 1500, Enum70.const_0);
			class.bool_0 = true;
			this.class531_0.class26_0.Add(class);
			this.class531_0.method_15(2000);
			this.class911_0.Add(this.class531_0);
			this.class533_0 = new Class533("Bancho is connecting...", 8f, new Vector2(-88f, 18f), 1f, true, Color.get_White());
			this.class533_0.bool_15 = false;
			this.class533_0.bool_17 = false;
			this.class533_0.enum115_0 = Enum115.const_17;
			this.class911_0.Add(this.class533_0);
			this.class911_0.list_2.ForEach(delegate(Class530 class530_0)
			{
				class530_0.float_3 = 0f;
				class530_0.vector2_1.Y = class530_0.vector2_1.Y - 25f;
			});
			this.class911_0.float_0 = 0f;
		}

		// Token: 0x0600313A RID: 12602
		// RVA: 0x001426E8 File Offset: 0x001408E8
		internal void method_0(bool bool_1)
		{
			Class525.Class837 class = new Class525.Class837();
			class.bool_0 = bool_1;
			class.class525_0 = this;
			if (Class115.bool_16)
			{
				return;
			}
			Class115.class47_0.Add(new VoidDelegate(class.method_0), false);
		}

		// Token: 0x0600313C RID: 12604
		// RVA: 0x00142728 File Offset: 0x00140928
		[CompilerGenerated]
		private void method_1()
		{
			this.class533_0.Text = this.string_0;
			float x = this.class533_0.vmethod_11().X;
			this.class531_1.vector2_2.X = Math.Max(1f, (x + 40f) / ((float)this.class531_1.int_6 / 1.6f));
			this.class533_0.vector2_0.X = (this.class533_0.vector2_1.X = -88f * this.class531_1.vector2_2.X - 30f * Math.Max(0f, this.class531_1.vector2_2.X - 1f));
			this.class533_0.class26_0.ForEach(new Action<Class746>(this.method_2));
			this.class531_0.vector2_0.X = (this.class531_0.vector2_1.X = -12f - 88f * this.class531_1.vector2_2.X - 30f * Math.Max(0f, this.class531_1.vector2_2.X - 1f));
			this.class531_0.class26_0.ForEach(new Action<Class746>(this.method_3));
			if (!string.IsNullOrEmpty(this.string_0))
			{
				this.method_0(true);
			}
		}

		// Token: 0x0600313D RID: 12605
		// RVA: 0x000245F7 File Offset: 0x000227F7
		[CompilerGenerated]
		private void method_2(Class746 class746_0)
		{
			class746_0.vector2_1.X = this.class533_0.vector2_1.X;
		}

		// Token: 0x0600313E RID: 12606
		// RVA: 0x00024614 File Offset: 0x00022814
		[CompilerGenerated]
		private void method_3(Class746 class746_0)
		{
			class746_0.vector2_1.X = this.class531_0.vector2_1.X;
		}

		// Token: 0x06003139 RID: 12601
		// RVA: 0x00142650 File Offset: 0x00140850
		internal override void vmethod_0()
		{
			if (!Class62.bool_12 && Class802.bool_13)
			{
				if (this.class911_0.float_0 < 1f)
				{
					this.class911_0.float_0 = Math.Min(1f, this.class911_0.float_0 + 0.01f);
				}
			}
			else if (this.class911_0.float_0 > 0f)
			{
				this.class911_0.float_0 = Math.Max(0f, this.class911_0.float_0 - 0.01f);
			}
			base.vmethod_0();
		}
	}
}
