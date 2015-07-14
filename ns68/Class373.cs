using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns59;
using ns77;
using osu.GameModes.Edit;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns68
{
	// Token: 0x0200038D RID: 909
	internal sealed class Class373 : Class371
	{
		// Token: 0x0200038E RID: 910
		[CompilerGenerated]
		private sealed class Class383
		{
			// Token: 0x0400164F RID: 5711
			public List<Class305> list_0;

			// Token: 0x04001650 RID: 5712
			public List<Class320> list_1;

			// Token: 0x06001C03 RID: 7171
			// RVA: 0x00093D74 File Offset: 0x00091F74
			public void method_0(Class530 class530_0)
			{
				Class305 class = class530_0.object_0 as Class305;
				if (class != null)
				{
					this.list_0.Add(class);
					return;
				}
				Class320 item;
				if ((item = (class530_0.object_0 as Class320)) != null)
				{
					this.list_1.Add(item);
				}
			}
		}

		// Token: 0x06001BFF RID: 7167
		// RVA: 0x000172AC File Offset: 0x000154AC
		public Class373(Editor editor_1) : base(editor_1)
		{
		}

		// Token: 0x06001C00 RID: 7168
		// RVA: 0x00093C54 File Offset: 0x00091E54
		internal override void vmethod_3()
		{
			Class373.Class383 class = new Class373.Class383();
			base.vmethod_3();
			class.list_0 = new List<Class305>();
			class.list_1 = new List<Class320>();
			this.editor_0.class911_3.list_2.ForEach(new Action<Class530>(class.method_0));
			foreach (Class304 current in class.list_0)
			{
				if (!current.Whistle && !current.Clap)
				{
					current.vmethod_0(new Color(235, 69, 44));
				}
				else
				{
					current.vmethod_0(new Color(67, 142, 172));
				}
			}
			foreach (Class320 current2 in class.list_1)
			{
				current2.vmethod_0(new Color(252, 184, 6));
			}
		}

		// Token: 0x06001C01 RID: 7169
		// RVA: 0x000156CE File Offset: 0x000138CE
		protected override float vmethod_30(Vector2 vector2_7, Vector2 vector2_8)
		{
			return 0f;
		}
	}
}
