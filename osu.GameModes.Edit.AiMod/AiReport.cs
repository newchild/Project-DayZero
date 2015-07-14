using osu.GameplayElements.HitObjects;
using System;
using System.Collections.Generic;

namespace osu.GameModes.Edit.AiMod
{
	// Token: 0x02000300 RID: 768
	public class AiReport : MarshalByRefObject
	{
		// Token: 0x04001211 RID: 4625
		public readonly BeenCorrectedDelegate corrected;

		// Token: 0x0400120C RID: 4620
		public readonly string Information;

		// Token: 0x04001210 RID: 4624
		public readonly List<HitObjectBase> RelatedHitObjects = new List<HitObjectBase>();

		// Token: 0x0400120D RID: 4621
		public readonly Severity Severity;

		// Token: 0x0400120E RID: 4622
		public int Time;

		// Token: 0x0400120F RID: 4623
		public readonly string WebLink;

		// Token: 0x06001753 RID: 5971
		// RVA: 0x00014794 File Offset: 0x00012994
		public AiReport(Severity severity, string information) : this(-1, severity, information, 0, null)
		{
		}

		// Token: 0x06001754 RID: 5972
		// RVA: 0x000730B8 File Offset: 0x000712B8
		public AiReport(int time, Severity severity, string information, int weblink, BeenCorrectedDelegate corrected)
		{
			this.Time = time;
			this.Severity = severity;
			this.Information = information;
			this.WebLink = "http://osu.ppy.sh/web/osu-gethelp.php?p=" + weblink;
			this.corrected = corrected;
		}

		// Token: 0x06001756 RID: 5974
		// RVA: 0x000147A1 File Offset: 0x000129A1
		public bool Check()
		{
			return this.corrected != null && this.corrected();
		}

		// Token: 0x06001755 RID: 5973
		// RVA: 0x0000653E File Offset: 0x0000473E
		public virtual void Draw()
		{
		}
	}
}
