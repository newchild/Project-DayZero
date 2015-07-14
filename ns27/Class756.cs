using Microsoft.Xna.Framework;
using ns14;
using ns79;
using ns8;
using ns80;
using ns84;
using osu.Graphics.Sprites;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns27
{
	// Token: 0x02000597 RID: 1431
	internal sealed class Class756 : Class755
	{
		// Token: 0x02000598 RID: 1432
		[CompilerGenerated]
		private sealed class Class757
		{
			// Token: 0x0400265B RID: 9819
			public Class756 class756_0;

			// Token: 0x0400265C RID: 9820
			public Enum72 enum72_0;

			// Token: 0x06002DE7 RID: 11751
			// RVA: 0x00129E80 File Offset: 0x00128080
			public void method_0(Class531 class531_0)
			{
				switch (this.enum72_0)
				{
				case Enum72.const_0:
					class531_0.enum115_0 = Enum115.const_5;
					class531_0.origins_0 = Origins.TopLeft;
					return;
				case Enum72.const_1:
					break;
				case Enum72.const_2:
					class531_0.enum115_0 = Enum115.const_6;
					class531_0.origins_0 = Origins.TopCentre;
					return;
				case Enum72.const_3:
					class531_0.enum115_0 = Enum115.const_7;
					class531_0.origins_0 = Origins.TopRight;
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x0400265A RID: 9818
		[CompilerGenerated]
		private static Action<Class531> action_0;

		// Token: 0x04002656 RID: 9814
		private Class534 class534_0;

		// Token: 0x04002659 RID: 9817
		private Enum72 enum72_0;

		// Token: 0x04002657 RID: 9815
		private float float_2;

		// Token: 0x04002658 RID: 9816
		private Vector2 vector2_0;

		// Token: 0x06002DE1 RID: 11745
		// RVA: 0x00129CCC File Offset: 0x00127ECC
		public Class756(int int_5, Vector2 vector2_1, int int_6, Enum72 enum72_1)
		{
			Action<Class531> action = null;
			Class754.Delegate37 delegate = null;
			Class756.Class757 class = new Class756.Class757();
			class.enum72_0 = enum72_1;
			base..ctor(int_5, vector2_1, 0f, true, 0.98f);
			class.class756_0 = this;
			base.method_25(true);
			this.class533_0.bool_16 = false;
			this.class533_0.bool_1 = false;
			this.int_0 = int_6;
			this.float_2 = (float)int_5;
			this.vector2_0 = vector2_1;
			this.enum72_0 = class.enum72_0;
			base.method_23(false);
			base.method_27(Class41.GetString(OsuString.SongSelection_TypeToBegin));
			this.class534_0 = new Class534(FontAwesome.search, (float)(int_5 + 2), new Vector2(vector2_1.X, vector2_1.Y + (float)int_5 * 0.1f));
			this.class534_0.float_0 = this.class533_0.float_0;
			this.list_0.Add(this.class534_0);
			if (class.enum72_0 != Enum72.const_2)
			{
				Class533 expr_EF_cp_0 = this.class533_0;
				expr_EF_cp_0.vector2_1.X = expr_EF_cp_0.vector2_1.X + (float)int_5;
			}
			List<Class531> arg_114_0 = this.list_0;
			if (action == null)
			{
				action = new Action<Class531>(class.method_0);
			}
			arg_114_0.ForEach(action);
			if (delegate == null)
			{
				delegate = new Class754.Delegate37(this.method_32);
			}
			base.method_3(delegate);
		}

		// Token: 0x06002DE0 RID: 11744
		// RVA: 0x00022A3E File Offset: 0x00020C3E
		public bool method_29()
		{
			return this.bool_1;
		}

		// Token: 0x06002DE2 RID: 11746
		// RVA: 0x00129E0C File Offset: 0x0012800C
		private void method_30()
		{
			if (this.enum72_0 == Enum72.const_2)
			{
				float x = this.class533_0.vmethod_11().X;
				this.class533_0.vector2_1.X = this.vector2_0.X + this.float_2 / 2f;
				this.class534_0.vector2_1.X = this.vector2_0.X - x / 2f;
			}
		}

		// Token: 0x06002DE3 RID: 11747
		// RVA: 0x00022A46 File Offset: 0x00020C46
		internal void method_31()
		{
			List<Class531> arg_23_0 = this.list_0;
			if (Class756.action_0 == null)
			{
				Class756.action_0 = new Action<Class531>(Class756.smethod_0);
			}
			arg_23_0.ForEach(Class756.action_0);
		}

		// Token: 0x06002DE4 RID: 11748
		// RVA: 0x00022A70 File Offset: 0x00020C70
		[CompilerGenerated]
		private void method_32(Class754 class754_0, bool bool_8)
		{
			this.method_30();
		}

		// Token: 0x06002DE5 RID: 11749
		// RVA: 0x00022A78 File Offset: 0x00020C78
		[CompilerGenerated]
		private static void smethod_0(Class531 class531_1)
		{
			class531_1.method_40(Class885.color_1, 500);
			class531_1.float_1 = Class562.smethod_6(-0.5f, 0.5f);
			class531_1.method_27(0f, 500, Enum70.const_0);
		}
	}
}
