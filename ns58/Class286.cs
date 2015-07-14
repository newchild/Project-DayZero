using ns12;
using ns23;
using ns24;
using ns55;
using ns8;
using osu.GameModes.Edit.AiMod;
using osu.GameModes.Edit.AiMod.Reports;
using osu.GameplayElements;
using osu.GameplayElements.HitObjects;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns58
{
	// Token: 0x020006BE RID: 1726
	internal sealed class Class286 : Class283
	{
		// Token: 0x020006BF RID: 1727
		[CompilerGenerated]
		private sealed class Class916
		{
			// Token: 0x0400320F RID: 12815
			public int[] int_0;
		}

		// Token: 0x020006C0 RID: 1728
		[CompilerGenerated]
		private sealed class Class917
		{
			// Token: 0x04003210 RID: 12816
			public Class286.Class916 class916_0;

			// Token: 0x04003211 RID: 12817
			public HitObjectBase hitObjectBase_0;

			// Token: 0x04003212 RID: 12818
			public int int_0;

			// Token: 0x060035CC RID: 13772
			// RVA: 0x00027350 File Offset: 0x00025550
			public bool method_0()
			{
				return AiModWindow.smethod_3(this.hitObjectBase_0.StartTime, false);
			}

			// Token: 0x060035CD RID: 13773
			// RVA: 0x00027363 File Offset: 0x00025563
			public bool method_1()
			{
				return AiModWindow.smethod_3(this.hitObjectBase_0.EndTime, false);
			}

			// Token: 0x060035CE RID: 13774
			// RVA: 0x00027376 File Offset: 0x00025576
			public bool method_2()
			{
				return Math.Abs(this.class916_0.int_0[this.int_0] - this.hitObjectBase_0.StartTime) > 10;
			}
		}

		// Token: 0x170003C1 RID: 961
		public override AiModType Type
		{
			// Token: 0x060035C7 RID: 13767
			// RVA: 0x00006D2D File Offset: 0x00004F2D
			get
			{
				return AiModType.Compose;
			}
		}

		// Token: 0x060035C9 RID: 13769
		// RVA: 0x0016F86C File Offset: 0x0016DA6C
		protected override void RunAllRules(HitObjectManagerBase hitObjectManager)
		{
			Class286.Class916 class = new Class286.Class916();
			List<HitObjectBase> hitObjects = hitObjectManager.GetHitObjects();
			Class297 class2 = hitObjectManager as Class297;
			int num = (int)Math.Round((double)Class466.Current.DifficultyCircleSize);
			List<Dictionary<int, int>> list = new List<Dictionary<int, int>>(num);
			int[] array = new int[num];
			class.int_0 = new int[num];
			for (int i = 0; i < num; i++)
			{
				list.Add(new Dictionary<int, int>());
			}
			for (int j = 0; j < hitObjects.Count; j++)
			{
				BeenCorrectedDelegate beenCorrectedDelegate = null;
				BeenCorrectedDelegate beenCorrectedDelegate2 = null;
				BeenCorrectedDelegate beenCorrectedDelegate3 = null;
				Class286.Class917 class3 = new Class286.Class917();
				class3.class916_0 = class;
				class3.hitObjectBase_0 = hitObjects[j];
				class3.int_0 = class2.class421_0.method_43(class3.hitObjectBase_0.Position, false);
				if (AiModWindow.smethod_3(class3.hitObjectBase_0.StartTime, false))
				{
					HitObjectBase arg_F5_0 = class3.hitObjectBase_0;
					int arg_F5_1 = class3.hitObjectBase_0.StartTime;
					if (beenCorrectedDelegate == null)
					{
						beenCorrectedDelegate = new BeenCorrectedDelegate(class3.method_0);
					}
					AiReport item = new AiReportOneObject(arg_F5_0, arg_F5_1, beenCorrectedDelegate, Severity.Warning, Class41.GetString(OsuString.AICompose_UnsnappedObject), 0);
					this.Reports.Add(item);
				}
				if (class3.hitObjectBase_0.IsType(HitObjectType.Hold))
				{
					if (class3.hitObjectBase_0.EndTime - class3.hitObjectBase_0.StartTime < 10)
					{
						this.Reports.Add(new AiReportOneObject(class3.hitObjectBase_0, class3.hitObjectBase_0.StartTime, null, Severity.Error, Class41.GetString(OsuString.AIComposeMania_HoldNoteTooShort), 0));
					}
					if (AiModWindow.smethod_3(class3.hitObjectBase_0.EndTime, false))
					{
						HitObjectBase arg_1B4_0 = class3.hitObjectBase_0;
						int arg_1B4_1 = class3.hitObjectBase_0.EndTime;
						if (beenCorrectedDelegate2 == null)
						{
							beenCorrectedDelegate2 = new BeenCorrectedDelegate(class3.method_1);
						}
						AiReport item2 = new AiReportOneObject(arg_1B4_0, arg_1B4_1, beenCorrectedDelegate2, Severity.Warning, Class41.GetString(OsuString.AICompose_UnsnappedObjectEnd), 0);
						this.Reports.Add(item2);
					}
				}
				if (class3.hitObjectBase_0.StartTime != class.int_0[class3.int_0] && class.int_0[class3.int_0] != 0 && class3.hitObjectBase_0.StartTime < class.int_0[class3.int_0] + 10)
				{
					List<AiReport> arg_255_0 = this.Reports;
					HitObjectBase arg_250_0 = class3.hitObjectBase_0;
					int arg_250_1 = class3.hitObjectBase_0.StartTime;
					if (beenCorrectedDelegate3 == null)
					{
						beenCorrectedDelegate3 = new BeenCorrectedDelegate(class3.method_2);
					}
					arg_255_0.Add(new AiReportOneObject(arg_250_0, arg_250_1, beenCorrectedDelegate3, Severity.Error, Class41.GetString(OsuString.AICompose_ObjectsTooClose), -1));
				}
				int num2 = 1;
				for (int k = 0; k < num; k++)
				{
					if (array[k] >= class3.hitObjectBase_0.StartTime)
					{
						num2++;
					}
				}
				if (class3.hitObjectBase_0.StartTime == class3.hitObjectBase_0.EndTime)
				{
					array[class3.int_0] = class3.hitObjectBase_0.StartTime;
				}
				else
				{
					array[class3.int_0] = class3.hitObjectBase_0.EndTime - 2;
				}
				if (num2 >= 7)
				{
					AiReportOneObject item3 = new AiReportOneObject(class3.hitObjectBase_0, class3.hitObjectBase_0.StartTime, null, Severity.Error, Class41.GetString(OsuString.AIComposeMania_TooManyNotes), 0);
					this.Reports.Add(item3);
				}
				if (!list[class3.int_0].ContainsKey(class3.hitObjectBase_0.StartTime) && !list[class3.int_0].ContainsKey(class3.hitObjectBase_0.EndTime))
				{
					bool flag = false;
					foreach (KeyValuePair<int, int> current in list[class3.int_0])
					{
						if (current.Key != current.Value)
						{
							if (class3.hitObjectBase_0.StartTime > current.Key || class3.hitObjectBase_0.EndTime < current.Key)
							{
								if (class3.hitObjectBase_0.StartTime > current.Value || class3.hitObjectBase_0.EndTime < current.Value)
								{
									if (class3.hitObjectBase_0.StartTime < current.Key || class3.hitObjectBase_0.EndTime > current.Value)
									{
										if (class3.hitObjectBase_0.StartTime >= current.Key || class3.hitObjectBase_0.EndTime <= current.Value)
										{
											continue;
										}
										flag = true;
									}
									else
									{
										flag = true;
									}
								}
								else
								{
									flag = true;
								}
							}
							else
							{
								flag = true;
							}
							break;
						}
					}
					if (flag)
					{
						AiReportOneObject item4 = new AiReportOneObject(class3.hitObjectBase_0, class3.hitObjectBase_0.StartTime, null, Severity.Error, Class41.GetString(OsuString.AIComposeMania_OverlappingObject), 0);
						this.Reports.Add(item4);
					}
					else
					{
						list[class3.int_0][class3.hitObjectBase_0.StartTime] = class3.hitObjectBase_0.EndTime;
						class.int_0[class3.int_0] = class3.hitObjectBase_0.StartTime;
					}
				}
				else
				{
					AiReportOneObject item5 = new AiReportOneObject(class3.hitObjectBase_0, class3.hitObjectBase_0.StartTime, null, Severity.Error, Class41.GetString(OsuString.AIComposeMania_StackedObjects), 0);
					this.Reports.Add(item5);
				}
			}
		}
	}
}
