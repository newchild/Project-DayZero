using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns14;
using ns27;
using ns29;
using ns79;
using ns8;
using osu_common.Helpers;
using System;

namespace ns20
{
	// Token: 0x020003A8 RID: 936
	internal sealed class Class397 : Class390
	{
		// Token: 0x040016EC RID: 5868
		private bool bool_1;

		// Token: 0x040016E9 RID: 5865
		private Class607 class607_0;

		// Token: 0x040016E8 RID: 5864
		internal Class883 class883_0;

		// Token: 0x040016EA RID: 5866
		private double double_0;

		// Token: 0x040016EB RID: 5867
		private string string_0;

		// Token: 0x06001CDC RID: 7388
		// RVA: 0x0009A888 File Offset: 0x00098A88
		public Class397(OsuString osuString_0, Class607 class607_1, string string_1, bool bool_2)
		{
			this.class607_0 = class607_1;
			this.double_0 = class607_1.Value;
			this.string_0 = string_1;
			this.bool_1 = bool_2;
			class607_1.imethod_2(new EventHandler(this.method_13));
			string string = Class41.GetString(osuString_0);
			Class533 class = new Class533(string, 12f, Vector2.get_Zero(), 1f, true, Color.get_White());
			this.class911_0.Add(class);
			base.method_1(class.vmethod_11());
			this.class883_0 = new Class883(this.class911_0, class607_1.double_2, class607_1.double_3, class607_1.Value, new Vector2(base.method_0().X + 5f, base.method_0().Y / 2f), (int)(244f - base.method_0().X - 5f));
			this.class883_0.method_5(new EventHandler(this.method_15));
			this.class883_0.bool_2 = true;
			this.class883_0.double_4 = ((class607_1 is Class608) ? 1.0 : 0.01);
			base.method_8(string);
			base.method_8(osuString_0.ToString());
			this.method_14();
		}

		// Token: 0x06001CE0 RID: 7392
		// RVA: 0x00017C98 File Offset: 0x00015E98
		public override void Dispose()
		{
			base.Dispose();
			this.class883_0.Dispose();
			this.class607_0.imethod_3(new EventHandler(this.method_13));
		}

		// Token: 0x06001CDD RID: 7389
		// RVA: 0x00017C2F File Offset: 0x00015E2F
		private void method_13(object sender, EventArgs e)
		{
			this.double_0 = this.class607_0.Value;
			this.class883_0.SetValue(this.class607_0.Value, false);
		}

		// Token: 0x06001CDE RID: 7390
		// RVA: 0x0009A9D4 File Offset: 0x00098BD4
		private void method_14()
		{
			if (!string.IsNullOrEmpty(this.string_0))
			{
				if (this.bool_1)
				{
					this.class883_0.method_4(this.class607_0 + this.string_0);
					return;
				}
				this.class883_0.method_4(this.double_0.ToString("0.##", Class115.numberFormatInfo_0) + this.string_0);
			}
		}

		// Token: 0x06001CDF RID: 7391
		// RVA: 0x00017C59 File Offset: 0x00015E59
		private void method_15(object sender, EventArgs e)
		{
			this.double_0 = this.class883_0.double_1;
			if (this.bool_1 || !this.class883_0.method_1())
			{
				this.class607_0.Value = this.double_0;
			}
			this.method_14();
		}
	}
}
