using Microsoft.Xna.Framework;
using osu.GameModes.Edit;
using System;

namespace ns68
{
	// Token: 0x0200038C RID: 908
	internal sealed class Class372 : Class371
	{
		// Token: 0x06001BFD RID: 7165
		// RVA: 0x000172AC File Offset: 0x000154AC
		public Class372(Editor editor_1) : base(editor_1)
		{
		}

		// Token: 0x06001BFE RID: 7166
		// RVA: 0x000172B5 File Offset: 0x000154B5
		protected override float vmethod_30(Vector2 vector2_7, Vector2 vector2_8)
		{
			return Math.Abs(vector2_7.X - vector2_8.X);
		}
	}
}
