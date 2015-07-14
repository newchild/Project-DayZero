using ns12;
using ns24;
using ns26;
using ns8;
using osu.GameModes.Edit.AiMod;
using osu.GameplayElements;
using osu.GameplayElements.HitObjects;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using Un4seen.Bass.AddOn.Tags;

namespace ns55
{
	// Token: 0x02000368 RID: 872
	internal class Class291 : AiModRuleset
	{
		// Token: 0x17000361 RID: 865
		public override AiModType Type
		{
			// Token: 0x06001A80 RID: 6784
			// RVA: 0x00006369 File Offset: 0x00004569
			get
			{
				return AiModType.Timing;
			}
		}

		// Token: 0x06001A82 RID: 6786
		// RVA: 0x00081A60 File Offset: 0x0007FC60
		protected override void RunAllRules(HitObjectManagerBase hitObjectManager)
		{
			List<HitObjectBase> hitObjects = hitObjectManager.GetHitObjects();
			int num = 0;
			int num2 = 0;
			if (hitObjects.Count > 0)
			{
				num = hitObjects[hitObjects.Count - 1].EndTime;
				num2 = num - hitObjects[0].StartTime;
				if (num2 > 360000)
				{
					this.Reports.Add(new AiReport(-1, Severity.Warning, Class41.GetString(OsuString.AITiming_BeatmapTooLong), -1, null));
				}
				else if (num2 < 45000)
				{
					this.Reports.Add(new AiReport(-1, Severity.Warning, Class41.GetString(OsuString.AITiming_BeatmapTooShort), -1, null));
				}
				if ((double)num2 * 1.0 / (double)(Class331.smethod_31() - hitObjects[0].StartTime) < 0.8)
				{
					this.Reports.Add(new AiReport(-1, Severity.Warning, Class41.GetString(OsuString.AITiming_Mp3LongerThanMap), -1, null));
				}
			}
			List<Class340> list = Class331.smethod_14();
			int num3 = 0;
			int num4 = 0;
			new List<float>();
			bool flag = false;
			double num5 = 0.0;
			int num6 = 0;
			int num7 = 0;
			for (int i = 0; i < list.Count; i++)
			{
				Class340 class = list[i];
				int num8 = (i == list.Count - 1) ? num : ((int)list[i + 1].double_1);
				int num9 = (int)class.double_1;
				if (num8 - num9 > 0 && class.method_2())
				{
					num4 += num8 - num9;
					if (i > 0 && !list[i - 1].method_2())
					{
						num3++;
					}
				}
				if (i > 0 && class.double_1 == list[i - 1].double_1)
				{
					num7++;
					for (int j = 0; j < num7; j++)
					{
						if (list[i - j].method_0() && list[i].method_0())
						{
							this.Reports.Add(new AiReport((int)class.double_1, Severity.Warning, Class41.GetString(OsuString.AITiming_OverlappingTimingPoints), 0, null));
							break;
						}
					}
				}
				else
				{
					num7 = 0;
				}
				if (class.method_2() && !flag)
				{
					flag = true;
					if (AiModWindow.smethod_3((int)class.double_1, false))
					{
						this.Reports.Add(new AiReport((int)class.double_1, Severity.Warning, Class41.GetString(OsuString.AITiming_UnsnappedKiai), 0, null));
					}
					if (class.double_1 - num5 < 15000.0 && class.double_1 - num5 > 10.0)
					{
						this.Reports.Add(new AiReport((int)class.double_1, Severity.Warning, Class41.GetString(OsuString.AITiming_KiaiTooShort), -1, null));
					}
				}
				else if (!class.method_2() && flag)
				{
					flag = false;
					if (AiModWindow.smethod_3((int)class.double_1, false))
					{
						this.Reports.Add(new AiReport((int)class.double_1, Severity.Warning, Class41.GetString(OsuString.AITiming_UnsnappedKiaiEnd), 0, null));
					}
					num5 = class.double_1;
				}
				if (class.int_0 < 5)
				{
					num6++;
				}
			}
			if (num6 == list.Count)
			{
				this.Reports.Add(new AiReport(Severity.Error, Class41.GetString(OsuString.AITiming_AllTimingSectionsQuiet)));
			}
			else if (num6 > 0)
			{
				this.Reports.Add(new AiReport(Severity.Warning, string.Format(Class41.GetString(OsuString.AITiming_SomeTimingSectionsQuiet), num6, list.Count)));
			}
			if (num2 > 180000 && num4 > num2 / 3)
			{
				this.Reports.Add(new AiReport(-1, Severity.Warning, Class41.GetString(OsuString.AITiming_TooMuchKiai), -1, null));
			}
			else if (num2 < 90000 && num4 > num2 / 2)
			{
				this.Reports.Add(new AiReport(-1, Severity.Warning, Class41.GetString(OsuString.AITiming_TooMuchKiaiTvSize), -1, null));
			}
			if (Class466.Current.int_14 < 0)
			{
				this.Reports.Add(new AiReport(-1, Severity.Warning, Class41.GetString(OsuString.AITiming_NoPreviewPoint), -1, null));
			}
			if (flag)
			{
				this.Reports.Add(new AiReport(-1, Severity.Warning, Class41.GetString(OsuString.AITiming_NoKiaiEnd), -1, null));
			}
			TAG_INFO tAG_INFO = Class331.smethod_85();
			if (tAG_INFO != null)
			{
				if (tAG_INFO.bitrate < 128)
				{
					this.Reports.Add(new AiReport(Severity.Warning, Class41.GetString(OsuString.AITiming_LowAudioBitrate)));
					return;
				}
				if (tAG_INFO.bitrate > 192)
				{
					this.Reports.Add(new AiReport(Severity.Warning, Class41.GetString(OsuString.AITiming_HighAudioBitrate)));
				}
			}
		}
	}
}
