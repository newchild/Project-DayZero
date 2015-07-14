using osu.GameplayElements.HitObjects;
using System;

namespace osu.GameModes.Edit.AiMod.Reports
{
	// Token: 0x02000306 RID: 774
	public class AiReportTwoObjects : AiReport
	{
		// Token: 0x04001217 RID: 4631
		public readonly HitObjectBase h1;

		// Token: 0x04001218 RID: 4632
		public readonly HitObjectBase h2;

		// Token: 0x0600175E RID: 5982
		// RVA: 0x0007310C File Offset: 0x0007130C
		public AiReportTwoObjects(HitObjectBase h1, HitObjectBase h2, BeenCorrectedDelegate corrected, Severity severity, string information, int weblink) : base((h1.EndTime - h2.StartTime) / 2 + h2.StartTime, severity, information, weblink, corrected)
		{
			this.h1 = h1;
			this.h2 = h2;
			this.RelatedHitObjects.Add(h1);
			this.RelatedHitObjects.Add(h2);
		}
	}
}
