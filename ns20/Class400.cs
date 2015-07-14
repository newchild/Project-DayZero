using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns14;
using ns27;
using ns79;
using ns8;
using osu_common.Helpers;
using System;
using System.Runtime.CompilerServices;

namespace ns20
{
	// Token: 0x020003AF RID: 943
	internal sealed class Class400 : Class390
	{
		// Token: 0x020003B0 RID: 944
		[CompilerGenerated]
		private sealed class Class405
		{
			// Token: 0x0400173E RID: 5950
			public Class400 class400_0;

			// Token: 0x0400173F RID: 5951
			public Class605<string> class605_0;

			// Token: 0x06001D58 RID: 7512
			// RVA: 0x000182A1 File Offset: 0x000164A1
			public void method_0(Class754 class754_0, bool bool_0)
			{
				this.class605_0.Value = this.class400_0.class754_0.Text;
			}
		}

		// Token: 0x0400173D RID: 5949
		private Class533 class533_0;

		// Token: 0x0400173C RID: 5948
		private Class605<string> class605_0;

		// Token: 0x0400173B RID: 5947
		internal Class754 class754_0;

		// Token: 0x06001D4C RID: 7500
		// RVA: 0x0009EDD4 File Offset: 0x0009CFD4
		public Class400(string string_0, bool bool_1)
		{
			this.class533_0 = new Class533(string_0, 12f, Vector2.get_Zero(), 1f, true, Color.get_White());
			this.class911_0.Add(this.class533_0);
			this.class754_0 = new Class754(string.Empty, 12, new Vector2(0f, this.class533_0.vmethod_11().Y + 5f), 239f, 1f, bool_2);
			Class754 arg_8D_0 = this.class754_0;
			Class754.Delegate37 delegate37_ = delegate(Class754 class754_1, bool bool_1)
			{
				this.method_14();
			};
			arg_8D_0.method_3(delegate37_);
			Class754 arg_A6_0 = this.class754_0;
			Class754.Delegate37 delegate37_2 = new Class754.Delegate37(this.method_17);
			arg_A6_0.method_2(delegate37_2);
			this.class911_0.Add<Class531>(this.class754_0.list_0);
			base.method_8(string_0);
			this.method_14();
		}

		// Token: 0x06001D4F RID: 7503
		// RVA: 0x00018232 File Offset: 0x00016432
		public Class400(OsuString osuString_0, bool bool_1) : this(Class41.GetString(osuString_0), bool_1)
		{
			base.method_8(osuString_0.ToString());
		}

		// Token: 0x06001D4D RID: 7501
		// RVA: 0x0009EEB0 File Offset: 0x0009D0B0
		public Class400(string string_0, Class605<string> class605_1, bool bool_1)
		{
			Class400.Class405 class = new Class400.Class405();
			class.class605_0 = class605_1;
			this..ctor(string_0, bool_1);
			class.class400_0 = this;
			this.class605_0 = class.class605_0;
			this.class605_0.imethod_2(new EventHandler(this.method_13));
			this.class754_0.Text = this.class605_0.Value;
			Class754 arg_6B_0 = this.class754_0;
			Class754.Delegate37 delegate37_ = new Class754.Delegate37(class.method_0);
			arg_6B_0.method_2(delegate37_);
		}

		// Token: 0x06001D4E RID: 7502
		// RVA: 0x00018211 File Offset: 0x00016411
		public Class400(OsuString osuString_0, Class605<string> class605_1, bool bool_1) : this(Class41.GetString(osuString_0), class605_1, bool_1)
		{
			base.method_8(osuString_0.ToString());
		}

		// Token: 0x06001D54 RID: 7508
		// RVA: 0x00018286 File Offset: 0x00016486
		public override void Dispose()
		{
			base.Dispose();
			this.class754_0.Dispose();
		}

		// Token: 0x06001D50 RID: 7504
		// RVA: 0x00018252 File Offset: 0x00016452
		private void method_13(object sender, EventArgs e)
		{
			this.class754_0.Text = this.class605_0.Value;
		}

		// Token: 0x06001D51 RID: 7505
		// RVA: 0x0009EF30 File Offset: 0x0009D130
		private void method_14()
		{
			float num = this.class754_0.class533_0.vector2_1.Y + this.class754_0.class533_0.vmethod_11().Y;
			base.method_1(new Vector2(base.method_0().X, num));
		}

		// Token: 0x06001D52 RID: 7506
		// RVA: 0x0001826A File Offset: 0x0001646A
		internal void method_15()
		{
			this.class754_0.method_19(true);
		}

		// Token: 0x06001D53 RID: 7507
		// RVA: 0x00018278 File Offset: 0x00016478
		internal void method_16()
		{
			this.class754_0.method_20(true);
		}

		// Token: 0x06001D56 RID: 7510
		// RVA: 0x00018299 File Offset: 0x00016499
		[CompilerGenerated]
		private void method_17(Class754 class754_1, bool bool_1)
		{
			this.method_14();
		}
	}
}
