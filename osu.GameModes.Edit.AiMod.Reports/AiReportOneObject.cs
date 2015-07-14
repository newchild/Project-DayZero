using osu.GameplayElements.HitObjects;
using System;

namespace osu.GameModes.Edit.AiMod.Reports
{
	// Token: 0x02000304 RID: 772
	public class AiReportOneObject : AiReport
	{
		// Token: 0x04001216 RID: 4630
		public readonly HitObjectBase h1;

		// Token: 0x0600175C RID: 5980
		// RVA: 0x000147D2 File Offset: 0x000129D2
		public AiReportOneObject(HitObjectBase h, int time, BeenCorrectedDelegate corrected, Severity severity, string information, int weblink) : base(time, severity, information, weblink, corrected)
		{
			this.h1 = h;
			this.RelatedHitObjects.Add(h);
		}
	}
}
