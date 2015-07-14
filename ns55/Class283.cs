using Microsoft.Xna.Framework;
using ns12;
using ns23;
using ns24;
using ns26;
using ns59;
using ns60;
using ns8;
using osu.GameModes.Edit.AiMod;
using osu.GameModes.Edit.AiMod.Reports;
using osu.GameplayElements;
using osu.GameplayElements.HitObjects;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns55
{
	// Token: 0x0200035D RID: 861
	internal class Class283 : AiModRuleset
	{
		// Token: 0x0200035E RID: 862
		[CompilerGenerated]
		private sealed class Class357
		{
			// Token: 0x04001507 RID: 5383
			public HitObjectBase hitObjectBase_0;

			// Token: 0x06001A65 RID: 6757
			// RVA: 0x0001643E File Offset: 0x0001463E
			public bool method_0()
			{
				return AiModWindow.smethod_3(this.hitObjectBase_0.StartTime, true);
			}

			// Token: 0x06001A66 RID: 6758
			// RVA: 0x00016451 File Offset: 0x00014651
			public bool method_1()
			{
				return AiModWindow.smethod_3(this.hitObjectBase_0.EndTime, true);
			}
		}

		// Token: 0x0200035F RID: 863
		[CompilerGenerated]
		private sealed class Class358
		{
			// Token: 0x04001508 RID: 5384
			public Class283.Class357 class357_0;

			// Token: 0x04001509 RID: 5385
			public HitObjectBase hitObjectBase_0;

			// Token: 0x06001A68 RID: 6760
			// RVA: 0x00016464 File Offset: 0x00014664
			public bool method_0()
			{
				return Math.Abs(this.hitObjectBase_0.StartTime - this.class357_0.hitObjectBase_0.StartTime) > 10;
			}
		}

		// Token: 0x02000360 RID: 864
		[CompilerGenerated]
		private sealed class Class359
		{
			// Token: 0x0400150A RID: 5386
			public Class283 class283_0;

			// Token: 0x0400150B RID: 5387
			public HitObjectManagerBase hitObjectManagerBase_0;
		}

		// Token: 0x02000361 RID: 865
		[CompilerGenerated]
		private sealed class Class360
		{
			// Token: 0x0400150C RID: 5388
			public Class283.Class359 class359_0;

			// Token: 0x0400150D RID: 5389
			public HitObjectBase hitObjectBase_0;

			// Token: 0x0400150E RID: 5390
			public HitObjectBase hitObjectBase_1;

			// Token: 0x06001A6B RID: 6763
			// RVA: 0x0001648B File Offset: 0x0001468B
			public bool method_0()
			{
				return this.class359_0.class283_0.method_1(this.hitObjectBase_0.Position);
			}

			// Token: 0x06001A6C RID: 6764
			// RVA: 0x000164A8 File Offset: 0x000146A8
			public bool method_1()
			{
				return this.class359_0.class283_0.method_1(this.hitObjectBase_0.EndPosition);
			}

			// Token: 0x06001A6D RID: 6765
			// RVA: 0x000164C5 File Offset: 0x000146C5
			public bool method_2()
			{
				return this.hitObjectBase_0.ComboNumber <= 24;
			}
		}

		// Token: 0x02000362 RID: 866
		[CompilerGenerated]
		private sealed class Class361
		{
			// Token: 0x04001510 RID: 5392
			public Class283.Class359 class359_0;

			// Token: 0x0400150F RID: 5391
			public Class283.Class360 class360_0;

			// Token: 0x04001511 RID: 5393
			public HitObjectBase hitObjectBase_0;

			// Token: 0x06001A6F RID: 6767
			// RVA: 0x000164D9 File Offset: 0x000146D9
			public bool method_0()
			{
				return this.hitObjectBase_0.StartTime != this.class360_0.hitObjectBase_0.StartTime;
			}
		}

		// Token: 0x02000363 RID: 867
		[CompilerGenerated]
		private sealed class Class362
		{
			// Token: 0x04001514 RID: 5396
			public Class325 class325_0;

			// Token: 0x04001513 RID: 5395
			public Class283.Class359 class359_0;

			// Token: 0x04001512 RID: 5394
			public Class283.Class360 class360_0;

			// Token: 0x06001A71 RID: 6769
			// RVA: 0x000164FB File Offset: 0x000146FB
			public bool method_0()
			{
				return this.class325_0.StartTime <= this.class360_0.hitObjectBase_0.StartTime - this.class359_0.hitObjectManagerBase_0.PreEmpt + Class297.int_2;
			}
		}

		// Token: 0x02000364 RID: 868
		[CompilerGenerated]
		private sealed class Class363
		{
			// Token: 0x04001516 RID: 5398
			public Class283.Class359 class359_0;

			// Token: 0x04001515 RID: 5397
			public Class283.Class360 class360_0;

			// Token: 0x04001517 RID: 5399
			public HitObjectBase hitObjectBase_0;

			// Token: 0x04001518 RID: 5400
			public HitObjectBase hitObjectBase_1;

			// Token: 0x06001A73 RID: 6771
			// RVA: 0x000818BC File Offset: 0x0007FABC
			public bool method_0()
			{
				return Math.Abs(Class283.smethod_0(this.class360_0.hitObjectBase_0, this.class360_0.hitObjectBase_1, this.class359_0.hitObjectManagerBase_0) - Class283.smethod_0(this.hitObjectBase_0, this.hitObjectBase_1, this.class359_0.hitObjectManagerBase_0)) < 0.05f;
			}
		}

		// Token: 0x04001505 RID: 5381
		private float float_0 = 1f;

		// Token: 0x04001506 RID: 5382
		private float float_1 = 40f;

		// Token: 0x1700035D RID: 861
		public override AiModType Type
		{
			// Token: 0x06001A5E RID: 6750
			// RVA: 0x00006D2D File Offset: 0x00004F2D
			get
			{
				return AiModType.Compose;
			}
		}

		// Token: 0x06001A5F RID: 6751
		// RVA: 0x00080F9C File Offset: 0x0007F19C
		public Class283()
		{
			if (Class466.Current.method_14() > 4.5)
			{
				this.float_0 = 2.5f;
				return;
			}
			if (Class466.Current.method_14() > 3.5)
			{
				this.float_0 = 1.5f;
				return;
			}
			if (Class466.Current.method_14() < 2.0)
			{
				this.float_0 = 0.5f;
			}
		}

		// Token: 0x06001A60 RID: 6752
		// RVA: 0x00081028 File Offset: 0x0007F228
		protected void method_0(HitObjectManagerBase hitObjectManagerBase_0)
		{
			List<HitObjectBase> hitObjects = hitObjectManagerBase_0.GetHitObjects();
			for (int i = 0; i < hitObjects.Count; i++)
			{
				BeenCorrectedDelegate beenCorrectedDelegate = null;
				BeenCorrectedDelegate beenCorrectedDelegate2 = null;
				Class283.Class357 class = new Class283.Class357();
				bool flag = i == hitObjects.Count - 1;
				class.hitObjectBase_0 = hitObjects[i];
				if (!flag)
				{
					HitObjectBase arg_41_0 = hitObjects[i + 1];
				}
				if (i > 0 && !flag && hitObjects[i].StartTime != hitObjects[i + 1].StartTime && hitObjects[i].StartTime < hitObjects[i - 1].EndTime + 10)
				{
					Class283.Class358 class2 = new Class283.Class358();
					class2.class357_0 = class;
					class2.hitObjectBase_0 = hitObjects[i - 1];
					this.Reports.Add(new AiReportTwoObjects(class2.hitObjectBase_0, class.hitObjectBase_0, new BeenCorrectedDelegate(class2.method_0), Severity.Error, Class41.GetString(OsuString.AICompose_ObjectsTooClose), -1));
				}
				if (AiModWindow.smethod_3(class.hitObjectBase_0.StartTime, true))
				{
					HitObjectBase arg_124_0 = class.hitObjectBase_0;
					int arg_124_1 = class.hitObjectBase_0.StartTime;
					if (beenCorrectedDelegate == null)
					{
						beenCorrectedDelegate = new BeenCorrectedDelegate(class.method_0);
					}
					AiReport item = new AiReportOneObject(arg_124_0, arg_124_1, beenCorrectedDelegate, Severity.Warning, Class41.GetString(OsuString.AICompose_UnsnappedObject), 0);
					this.Reports.Add(item);
				}
				if (class.hitObjectBase_0.EndTime != class.hitObjectBase_0.StartTime && AiModWindow.smethod_3(class.hitObjectBase_0.EndTime, true))
				{
					HitObjectBase arg_19A_0 = class.hitObjectBase_0;
					int arg_19A_1 = class.hitObjectBase_0.EndTime;
					if (beenCorrectedDelegate2 == null)
					{
						beenCorrectedDelegate2 = new BeenCorrectedDelegate(class.method_1);
					}
					AiReport item2 = new AiReportOneObject(arg_19A_0, arg_19A_1, beenCorrectedDelegate2, Severity.Warning, Class41.GetString(OsuString.AICompose_UnsnappedObjectEnd), 0);
					this.Reports.Add(item2);
				}
			}
		}

		// Token: 0x06001A62 RID: 6754
		// RVA: 0x00081808 File Offset: 0x0007FA08
		private bool method_1(Vector2 vector2_0)
		{
			return vector2_0.X - this.float_1 < -64f || vector2_0.X + this.float_1 > 576f || vector2_0.Y - this.float_1 < -48f || vector2_0.Y + this.float_1 > 432f;
		}

		// Token: 0x06001A61 RID: 6753
		// RVA: 0x000811F4 File Offset: 0x0007F3F4
		protected override void RunAllRules(HitObjectManagerBase hitObjectManager)
		{
			Class283.Class359 class = new Class283.Class359();
			class.hitObjectManagerBase_0 = hitObjectManager;
			class.class283_0 = this;
			this.float_1 = (float)(64.0 * (1.0 - 0.699999988079071 * class.hitObjectManagerBase_0.AdjustDifficulty((double)Class466.Current.DifficultyCircleSize)) / 2.0) - 1f;
			this.method_0(class.hitObjectManagerBase_0);
			List<HitObjectBase> hitObjects = class.hitObjectManagerBase_0.GetHitObjects();
			bool flag = false;
			double val = 0.0;
			float num = 0f;
			HitObjectBase hitObjectBase_ = null;
			HitObjectBase hitObjectBase_2 = null;
			for (int i = 0; i < hitObjects.Count; i++)
			{
				Class283.Class360 class2 = new Class283.Class360();
				class2.class359_0 = class;
				bool flag2 = i == hitObjects.Count - 1;
				class2.hitObjectBase_0 = hitObjects[i];
				class2.hitObjectBase_1 = (flag2 ? null : hitObjects[i + 1]);
				if (this.method_1(class2.hitObjectBase_0.Position))
				{
					this.Reports.Add(new AiReportOneObject(class2.hitObjectBase_0, class2.hitObjectBase_0.StartTime, new BeenCorrectedDelegate(class2.method_0), Severity.Warning, Class41.GetString(OsuString.AICompose_ObjectOffscreen), 0));
				}
				if (class2.hitObjectBase_0.EndPosition != class2.hitObjectBase_0.Position && this.method_1(class2.hitObjectBase_0.EndPosition))
				{
					this.Reports.Add(new AiReportOneObject(class2.hitObjectBase_0, class2.hitObjectBase_0.EndTime, new BeenCorrectedDelegate(class2.method_1), Severity.Warning, Class41.GetString(OsuString.AICompose_ObjectEndOffscreen), 0));
				}
				if (class2.hitObjectBase_0.ComboNumber > 24)
				{
					this.Reports.Add(new AiReportOneObject(class2.hitObjectBase_0, class2.hitObjectBase_0.EndTime, new BeenCorrectedDelegate(class2.method_2), Severity.Warning, Class41.GetString(OsuString.AICompose_LongCombo), -1));
				}
				if (i > 0 && !flag2 && hitObjects[i].StartTime == hitObjects[i + 1].StartTime)
				{
					Class283.Class361 class3 = new Class283.Class361();
					class3.class360_0 = class2;
					class3.class359_0 = class;
					class3.hitObjectBase_0 = hitObjects[i - 1];
					this.Reports.Add(new AiReportTwoObjects(class3.hitObjectBase_0, class2.hitObjectBase_0, new BeenCorrectedDelegate(class3.method_0), Severity.Error, Class41.GetString(OsuString.AICompose_SimultaneousObjects), -1));
				}
				if (flag && !(class2.hitObjectBase_0 is Class325))
				{
					Class283.Class362 class4 = new Class283.Class362();
					class4.class360_0 = class2;
					class4.class359_0 = class;
					class4.class325_0 = (Class325)hitObjects[i - 1];
					if (class4.class325_0.StartTime > class2.hitObjectBase_0.StartTime - class.hitObjectManagerBase_0.PreEmpt + Class297.int_2)
					{
						this.Reports.Add(new AiReportTwoObjects(class4.class325_0, class2.hitObjectBase_0, new BeenCorrectedDelegate(class4.method_0), Severity.Error, Class41.GetString(OsuString.AICompose_NinjaSpinner), -1));
					}
				}
				flag = (class2.hitObjectBase_0 is Class325);
				if (class2.hitObjectBase_0 is Class321)
				{
					Class321 class5 = class2.hitObjectBase_0 as Class321;
					if (class5.method_20())
					{
						this.Reports.Add(new AiReportOneObject(class2.hitObjectBase_0, class2.hitObjectBase_0.StartTime, null, Severity.Error, Class41.GetString(OsuString.AICompose_AbnormalSlider), -1));
					}
					if (class5.EndTime - 1000 > class5.StartTime)
					{
						val = Math.Max(val, Class331.smethod_22((double)class5.StartTime, true));
					}
				}
				if (class2.hitObjectBase_0.IsType(HitObjectType.Spinner))
				{
					if (!class2.hitObjectBase_0.IsType(HitObjectType.NewCombo))
					{
						this.Reports.Add(new AiReportOneObject(class2.hitObjectBase_0, class2.hitObjectBase_0.StartTime, null, Severity.Warning, Class41.GetString(OsuString.AICompose_SpinnerNoNewCombo), -1));
					}
					double num2 = 0.05 * (double)(class2.hitObjectBase_0.EndTime - class2.hitObjectBase_0.StartTime) / 3.1415926535897931;
					double num3 = (double)(class2.hitObjectBase_0.EndTime - class2.hitObjectBase_0.StartTime) / 1000.0 * class.hitObjectManagerBase_0.SpinnerRotationRatio;
					if (num2 - num3 < 5.0)
					{
						this.Reports.Add(new AiReportOneObject(class2.hitObjectBase_0, class2.hitObjectBase_0.StartTime, null, Severity.Warning, Class41.GetString(OsuString.AICompose_ShortSpinner), -1));
					}
				}
				if (AiModWindow.bool_1 && !flag2 && !class2.hitObjectBase_1.NewCombo && !(class2.hitObjectBase_1 is Class325))
				{
					float num4 = Class283.smethod_0(class2.hitObjectBase_0, class2.hitObjectBase_1, class.hitObjectManagerBase_0);
					if (!class2.hitObjectBase_0.NewCombo && num >= 0.01f)
					{
						if (num > 0.01f && num4 > 0.01f && ((double)(num4 - num) > (double)num * 0.1 * (double)this.float_0 || (double)(num - num4) > (double)num * 0.2 * (double)this.float_0))
						{
							Class283.Class363 class6 = new Class283.Class363();
							class6.class360_0 = class2;
							class6.class359_0 = class;
							class6.hitObjectBase_0 = hitObjectBase_;
							class6.hitObjectBase_1 = hitObjectBase_2;
							AiReportTwoObjects item = new AiReportTwoObjects(class2.hitObjectBase_0, class2.hitObjectBase_1, new BeenCorrectedDelegate(class6.method_0), Severity.Warning, (num4 < num) ? Class41.GetString(OsuString.AICompose_ObjectTooClose) : Class41.GetString(OsuString.AICompose_ObjectTooFar), 82809);
							this.Reports.Add(item);
						}
					}
					else
					{
						num = num4;
						hitObjectBase_ = class2.hitObjectBase_0;
						hitObjectBase_2 = class2.hitObjectBase_1;
					}
				}
			}
		}

		// Token: 0x06001A63 RID: 6755
		// RVA: 0x0008186C File Offset: 0x0007FA6C
		private static float smethod_0(HitObjectBase hitObjectBase_0, HitObjectBase hitObjectBase_1, HitObjectManagerBase hitObjectManagerBase_0)
		{
			int endTime = hitObjectBase_0.EndTime;
			int startTime = hitObjectBase_1.StartTime;
			int num = startTime - endTime;
			float num2 = (float)hitObjectManagerBase_0.SliderVelocityAt(startTime);
			return 1000f * (hitObjectBase_1.Position - hitObjectBase_0.EndPosition).Length() / (num2 * (float)num);
		}
	}
}
