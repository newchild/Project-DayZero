using Microsoft.Xna.Framework;
using ns14;
using ns27;
using ns77;
using ns79;
using ns8;
using osu_common.Helpers;
using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns20
{
	// Token: 0x020003A3 RID: 931
	internal sealed class Class393 : Class390
	{
		// Token: 0x040016DC RID: 5852
		private Class606 class606_0;

		// Token: 0x040016DE RID: 5854
		internal Class762 class762_0;

		// Token: 0x040016DD RID: 5853
		private EventHandler eventHandler_1;

		// Token: 0x06001CBE RID: 7358
		// RVA: 0x00017A08 File Offset: 0x00015C08
		internal Class393(OsuString osuString_0, Class606 class606_1, EventHandler eventHandler_2) : this(Class41.GetString(osuString_0), Class41.GetString(osuString_0 + 1), class606_1, eventHandler_2)
		{
			base.method_8(osuString_0.ToString());
		}

		// Token: 0x06001CBF RID: 7359
		// RVA: 0x00017A31 File Offset: 0x00015C31
		internal Class393(string string_0, string string_1, Class606 class606_1, EventHandler eventHandler_2) : this(string_0, string_1, class606_1 != null && class606_1.Value, eventHandler_2)
		{
			this.class606_0 = class606_1;
			if (class606_1 != null)
			{
				class606_1.imethod_2(new EventHandler(this.method_14));
			}
		}

		// Token: 0x06001CC1 RID: 7361
		// RVA: 0x0009A034 File Offset: 0x00098234
		internal Class393(string string_0, string string_1, bool bool_1, EventHandler eventHandler_2)
		{
			Class762 class = new Class762(string_0, 0.8f, Vector2.get_Zero(), 1f, bool_1, 244f);
			class.method_4(string_1);
			this.class762_0 = class;
			this.class762_0.method_8(new Delegate38(this.method_16));
			if (eventHandler_2 != null)
			{
				this.method_13(eventHandler_2);
			}
			this.class911_0.Add<Class531>(this.class762_0.list_0);
			base.method_8(string_0);
			base.method_8(string_1);
			this.method_15(string_0);
		}

		// Token: 0x06001CC4 RID: 7364
		// RVA: 0x00017AA0 File Offset: 0x00015CA0
		public override void Dispose()
		{
			base.Dispose();
			if (this.class606_0 != null)
			{
				this.class606_0.imethod_3(new EventHandler(this.method_14));
			}
		}

		// Token: 0x06001CBD RID: 7357
		// RVA: 0x00099FFC File Offset: 0x000981FC
		private void method_13(EventHandler eventHandler_2)
		{
			EventHandler eventHandler = this.eventHandler_1;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_2);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06001CC0 RID: 7360
		// RVA: 0x00017A65 File Offset: 0x00015C65
		private void method_14(object sender, EventArgs e)
		{
			this.class762_0.method_6(this.class606_0.Value);
		}

		// Token: 0x06001CC2 RID: 7362
		// RVA: 0x0009A0C0 File Offset: 0x000982C0
		internal void method_15(string string_0)
		{
			this.class762_0.Text = string_0;
			this.class911_0.list_2.ForEach(new Action<Class530>(this.method_18));
			base.method_1(new Vector2(20f, 0f) + this.class762_0.class533_0.vmethod_11());
		}

		// Token: 0x06001CC3 RID: 7363
		// RVA: 0x00017A7D File Offset: 0x00015C7D
		private void method_16(object object_0, bool bool_1)
		{
			this.class606_0.Value = bool_1;
			if (this.eventHandler_1 != null)
			{
				this.eventHandler_1(this, null);
			}
		}

		// Token: 0x06001CC5 RID: 7365
		// RVA: 0x00017AC7 File Offset: 0x00015CC7
		internal void method_17(bool bool_1)
		{
			this.class762_0.method_1(bool_1);
		}

		// Token: 0x06001CC6 RID: 7366
		// RVA: 0x00017AD5 File Offset: 0x00015CD5
		[CompilerGenerated]
		private void method_18(Class530 class530_0)
		{
			class530_0.vector2_1 = class530_0.vector2_0 + new Vector2(0f, -8f + this.class762_0.class533_0.vmethod_11().Y / 2f);
		}
	}
}
