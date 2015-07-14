using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns25;
using ns29;
using ns40;
using ns79;
using ns80;
using osu.Graphics.Sprites;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns16
{
	// Token: 0x02000394 RID: 916
	internal sealed class Class58 : Class57
	{
		// Token: 0x02000395 RID: 917
		[CompilerGenerated]
		private sealed class Class386
		{
			// Token: 0x04001687 RID: 5767
			public bool bool_0;

			// Token: 0x04001686 RID: 5766
			public Color color_0;

			// Token: 0x06001C5E RID: 7262
			// RVA: 0x00017611 File Offset: 0x00015811
			public void method_0(Class531 class531_0)
			{
				class531_0.method_39(this.color_0, this.bool_0 ? 0 : 1000, false, Enum70.const_0);
			}
		}

		// Token: 0x0400167D RID: 5757
		private Class911 class911_0 = new Class911(true)
		{
			bool_6 = false
		};

		// Token: 0x04001684 RID: 5764
		private static Color color_0 = new Color(0, 78, 155);

		// Token: 0x0400167F RID: 5759
		private float float_3;

		// Token: 0x04001681 RID: 5761
		internal float float_4 = 1f;

		// Token: 0x04001682 RID: 5762
		internal float float_5 = 0.4f;

		// Token: 0x04001683 RID: 5763
		internal float float_6 = 8f;

		// Token: 0x04001685 RID: 5765
		private float float_7 = 1f;

		// Token: 0x0400167E RID: 5758
		private List<Class531> list_0 = new List<Class531>();

		// Token: 0x04001680 RID: 5760
		internal Vector2 vector2_0;

		// Token: 0x06001C56 RID: 7254
		// RVA: 0x000175D5 File Offset: 0x000157D5
		protected override void Dispose(bool bool_2)
		{
			this.class911_0.Dispose();
			base.Dispose(bool_2);
		}

		// Token: 0x06001C57 RID: 7255
		// RVA: 0x000175E9 File Offset: 0x000157E9
		public override void Draw()
		{
			this.class911_0.Draw();
			base.Draw();
		}

		// Token: 0x06001C58 RID: 7256
		// RVA: 0x00097C78 File Offset: 0x00095E78
		public override void imethod_2()
		{
			base.imethod_2();
			if (Class115.bool_16)
			{
				this.float_7 = 0.5f;
			}
			else
			{
				this.float_7 = this.float_7 * 0.97f + 0.03f * (float)Math.Max(0.0, 1.0 - Math.Max(0.0, Math.Pow(Class115.double_9 / 16.666666666666668, 4.0) - 1.0));
			}
			for (int i = 0; i < 1024; i++)
			{
				Class531 class = this.list_0[i];
				class.float_3 = Math.Max(0f, this.float_4 * this.float_5 * Math.Min(1f, (class.vector2_2.X - 0.1f) / 0.2f));
				this.method_4(class, this.float_1[i] * this.float_7);
			}
		}

		// Token: 0x06001C55 RID: 7253
		// RVA: 0x00097BD0 File Offset: 0x00095DD0
		public override void Initialize()
		{
			base.Initialize();
			for (int i = 0; i < 1024; i++)
			{
				Vector2 vector2_;
				vector2_..ctor(0f, 1f * (float)i);
				Class531 class = new Class531(Class885.Load("menu-vis", Enum112.flag_1), Enum115.const_5, Origins.CentreLeft, Enum114.const_0, vector2_)
				{
					float_3 = 0.2f,
					bool_7 = true,
					vector2_2 = new Vector2(0f, 1f),
					bool_0 = true,
					color_0 = Class58.color_0
				};
				this.class911_0.Add(class);
				this.list_0.Add(class);
			}
		}

		// Token: 0x06001C53 RID: 7251
		// RVA: 0x000175CD File Offset: 0x000157CD
		internal float method_1()
		{
			return this.float_3;
		}

		// Token: 0x06001C54 RID: 7252
		// RVA: 0x00097B38 File Offset: 0x00095D38
		internal void method_2(float float_8)
		{
			if (float_8 == this.float_3)
			{
				return;
			}
			this.float_3 = float_8;
			for (int i = 0; i < 1024; i++)
			{
				float num = 6.28318f * (0.4f + (float)i / 1024f * (this.float_6 * 1f));
				Class531 class = this.list_0[i];
				class.vector2_1 = this.vector2_0 + new Vector2(this.method_1() * (float)Math.Cos((double)num), this.method_1() * (float)Math.Sin((double)num));
				class.float_1 = num;
			}
		}

		// Token: 0x06001C59 RID: 7257
		// RVA: 0x00097D78 File Offset: 0x00095F78
		internal void method_3(Color color_1, bool bool_2)
		{
			Class58.Class386 class = new Class58.Class386();
			class.color_0 = color_1;
			class.bool_0 = bool_2;
			if ((Class809.class623_0 & Enum30.flag_3) == Enum30.flag_0)
			{
				class.color_0 = Class58.color_0;
			}
			this.list_0.ForEach(new Action<Class531>(class.method_0));
		}

		// Token: 0x06001C5A RID: 7258
		// RVA: 0x00097DCC File Offset: 0x00095FCC
		private void method_4(Class531 class531_0, float float_8)
		{
			float num = float_8 * 4f;
			if (num > class531_0.vector2_2.X)
			{
				class531_0.vector2_2.X = float_8 * 4f;
				return;
			}
			class531_0.vector2_2.X = class531_0.vector2_2.X * (float)Math.Pow(0.949999988079071, Class115.double_0);
		}
	}
}
