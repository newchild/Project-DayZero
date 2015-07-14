using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns24;
using ns27;
using ns29;
using ns74;
using ns79;
using ns8;
using ns82;
using ns90;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns19
{
	// Token: 0x020003DF RID: 991
	internal sealed class Class92 : Class89
	{
		// Token: 0x020003E0 RID: 992
		[CompilerGenerated]
		private sealed class Class440
		{
			// Token: 0x04001916 RID: 6422
			public Class441 class441_0;

			// Token: 0x06001FD3 RID: 8147
			// RVA: 0x0001A06B File Offset: 0x0001826B
			public void method_0(Class441 class441_1)
			{
				if (class441_1 != this.class441_0)
				{
					class441_1.method_13();
				}
			}
		}

		// Token: 0x04001913 RID: 6419
		private readonly Class110 class110_0;

		// Token: 0x04001915 RID: 6421
		internal static Class441 class441_0;

		// Token: 0x04001911 RID: 6417
		private Class754 class754_0;

		// Token: 0x0400190F RID: 6415
		private static Class92 class92_0;

		// Token: 0x04001914 RID: 6420
		private EventHandler eventHandler_4;

		// Token: 0x04001910 RID: 6416
		private static int int_1 = 65;

		// Token: 0x04001912 RID: 6418
		private List<Class441> list_1;

		// Token: 0x06001FC3 RID: 8131
		// RVA: 0x000B4ACC File Offset: 0x000B2CCC
		internal Class92(EventHandler eventHandler_5) : base(Class41.GetString(OsuString.CollectionDialog_Collection), true)
		{
			this.class110_0 = new Class110(new Rectangle(0, 60, 550, 250), Vector2.get_Zero(), false, 0f, Enum98.const_5);
			Class92.class92_0 = this;
			base.method_2(eventHandler_5);
			this.eventHandler_4 = eventHandler_5;
			this.float_0 = 320f;
			base.method_3(Class41.GetString(OsuString.CollectionDialog_DeleteCollection), Color.get_Red(), new EventHandler(this.method_12), true, false, true);
			base.method_3(Class41.GetString(OsuString.General_Close), Color.get_Gray(), null, true, false, true);
			this.list_1 = new List<Class441>();
			foreach (KeyValuePair<string, List<string>> current in Class476.smethod_0())
			{
				this.list_1.Add(new Class441(current.Key));
			}
			this.method_9();
		}

		// Token: 0x06001FC5 RID: 8133
		// RVA: 0x00019FC6 File Offset: 0x000181C6
		internal override void Close(bool bool_5)
		{
			if (Class92.class92_0 == this)
			{
				Class92.class92_0 = null;
			}
			base.Close(bool_5);
		}

		// Token: 0x06001FCC RID: 8140
		// RVA: 0x0001A003 File Offset: 0x00018203
		protected override void Dispose(bool bool_5)
		{
			this.class110_0.Dispose();
			base.Dispose(bool_5);
		}

		// Token: 0x06001FCB RID: 8139
		// RVA: 0x00019FF0 File Offset: 0x000181F0
		internal override void Draw()
		{
			base.Draw();
			this.class110_0.Draw();
		}

		// Token: 0x06001FC6 RID: 8134
		// RVA: 0x00019FDD File Offset: 0x000181DD
		public override void imethod_2()
		{
			this.class110_0.imethod_2();
			base.imethod_2();
		}

		// Token: 0x06001FC8 RID: 8136
		// RVA: 0x000B4D40 File Offset: 0x000B2F40
		private void method_10(Class754 class754_1, bool bool_5)
		{
			if (this.class754_0.Text.Length <= 0 || !bool_5)
			{
				return;
			}
			string text = this.class754_0.Text;
			this.class754_0.Text = Class41.GetString(OsuString.Collection_EnterName);
			if (!Class476.smethod_4(text))
			{
				return;
			}
			this.list_1.Add(new Class441(text));
			Class115.class47_0.Add(new VoidDelegate(this.method_9), false);
		}

		// Token: 0x06001FC9 RID: 8137
		// RVA: 0x000B4DB8 File Offset: 0x000B2FB8
		private void method_11(Class754 class754_1, bool bool_5)
		{
			if (this.class754_0.Text.Length > 25 && this.class754_0.Text != Class41.GetString(OsuString.Collection_EnterName))
			{
				this.class754_0.Text = this.class754_0.Text.Substring(0, 25);
			}
		}

		// Token: 0x06001FCA RID: 8138
		// RVA: 0x000B4E14 File Offset: 0x000B3014
		private void method_12(object sender, EventArgs e)
		{
			if (Class92.class441_0 == null)
			{
				Class723.smethod_1(Class41.GetString(OsuString.CollectionDialog_SelectACollectionFirst), 1500);
				Class115.smethod_37(new Class92(this.eventHandler_4));
				return;
			}
			this.Close(false);
			Class89 class89_ = new Class101(string.Format(Class41.GetString(OsuString.CollectionDialog_ConfirmDeleteCollection), Class92.class441_0.Name), new EventHandler(this.method_14), new EventHandler(this.method_15));
			Class115.smethod_37(class89_);
		}

		// Token: 0x06001FCE RID: 8142
		// RVA: 0x0001A017 File Offset: 0x00018217
		[CompilerGenerated]
		private void method_13(Class754 class754_1, bool bool_5)
		{
			this.class754_0.Text = string.Empty;
		}

		// Token: 0x06001FCF RID: 8143
		// RVA: 0x0001A029 File Offset: 0x00018229
		[CompilerGenerated]
		private void method_14(object sender, EventArgs e)
		{
			Class476.Remove(Class92.class441_0.Name);
			Class92.class441_0 = null;
			Class115.smethod_37(new Class92(this.eventHandler_4));
		}

		// Token: 0x06001FD0 RID: 8144
		// RVA: 0x0001A050 File Offset: 0x00018250
		[CompilerGenerated]
		private void method_15(object sender, EventArgs e)
		{
			Class115.smethod_37(new Class92(this.eventHandler_4));
		}

		// Token: 0x06001FC4 RID: 8132
		// RVA: 0x000B4BD8 File Offset: 0x000B2DD8
		private void method_9()
		{
			int num = 0;
			foreach (Class441 current in this.list_1)
			{
				if (current.method_2(new Vector2((float)(Class92.int_1 + 30), (float)num)))
				{
					this.class110_0.class911_0.Add<Class531>(current.list_0);
				}
				num += 17;
			}
			this.class110_0.method_14(new Vector2(160f, (float)num));
		}

		// Token: 0x06001FCD RID: 8141
		// RVA: 0x000B4E94 File Offset: 0x000B3094
		internal static void smethod_2(Class441 class441_1)
		{
			Class92.Class440 class = new Class92.Class440();
			class.class441_0 = class441_1;
			if (Class92.class92_0 != null)
			{
				Class92.class92_0.list_1.ForEach(new Action<Class441>(class.method_0));
			}
			Class92.class441_0 = class.class441_0;
		}

		// Token: 0x06001FC7 RID: 8135
		// RVA: 0x000B4C74 File Offset: 0x000B2E74
		internal override void vmethod_3()
		{
			string text = Class41.GetString(OsuString.Collection_EnterName);
			if (text.Length > 68)
			{
				text = text.Substring(0, 68) + "...";
			}
			this.class754_0 = new Class754(text, 15, new Vector2((float)(Class92.int_1 + 30) + Class115.smethod_45(), 35f), 448f, 0.94f, false);
			this.class754_0.method_2(new Class754.Delegate37(this.method_10));
			this.class754_0.method_3(new Class754.Delegate37(this.method_11));
			this.class754_0.method_4(new Class754.Delegate37(this.method_13));
			this.class911_0.Add<Class531>(this.class754_0.list_0);
			base.vmethod_3();
		}
	}
}
