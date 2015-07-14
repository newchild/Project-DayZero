using Microsoft.Xna.Framework.Graphics;
using ns24;
using ns27;
using ns29;
using ns76;
using ns8;
using osu_common.Helpers;
using System;
using System.Runtime.CompilerServices;

namespace ns19
{
	// Token: 0x020003EA RID: 1002
	internal sealed class Class93 : Class89
	{
		// Token: 0x04001942 RID: 6466
		private Class512 class512_0;

		// Token: 0x06002005 RID: 8197
		// RVA: 0x000B62FC File Offset: 0x000B44FC
		internal Class93(Class512 class512_1) : base(Class41.GetString(OsuString.ScoreDialog_ScoreManagement), false)
		{
			this.class512_0 = class512_1;
			string arg_3D_1 = Class41.GetString(OsuString.ScoreDialog_DeleteScore);
			Color arg_3D_2 = Color.get_YellowGreen();
			EventHandler eventHandler_ = delegate(object sender, EventArgs e)
			{
				Class908.smethod_7(Class466.Current.string_3, this.class512_0.method_1());
				if (Class115.class61_0 is Class68)
				{
					Class68 class = (Class68)Class115.class61_0;
					class.method_56(false);
				}
			};
			base.method_3(arg_3D_1, arg_3D_2, eventHandler_, true, false, true);
			string arg_63_1 = Class41.GetString(OsuString.ScoreDialog_ExportReplay);
			Color arg_63_2 = Color.get_LightBlue();
			EventHandler eventHandler_2 = new EventHandler(this.method_9);
			base.method_3(arg_63_1, arg_63_2, eventHandler_2, true, false, true);
			base.method_3(Class41.GetString(OsuString.General_Close), Color.get_Gray(), null, true, false, true);
		}

		// Token: 0x06002007 RID: 8199
		// RVA: 0x0001A2B2 File Offset: 0x000184B2
		[CompilerGenerated]
		private void method_9(object sender, EventArgs e)
		{
			this.class512_0.method_25();
			Class908.smethod_6(this.class512_0, null);
		}
	}
}
