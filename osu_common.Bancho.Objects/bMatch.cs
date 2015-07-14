using ns40;
using ns8;
using System;

namespace osu_common.Bancho.Objects
{
	// Token: 0x02000171 RID: 369
	[Serializable]
	public class bMatch : ICloneable, bSerializable
	{
		// Token: 0x0400060B RID: 1547
		public Mods activeMods;

		// Token: 0x04000608 RID: 1544
		public string beatmapChecksum;

		// Token: 0x04000609 RID: 1545
		public int beatmapId = -1;

		// Token: 0x04000607 RID: 1543
		public string beatmapName;

		// Token: 0x04000600 RID: 1536
		public string gameName;

		// Token: 0x04000613 RID: 1555
		public string gamePassword;

		// Token: 0x0400060C RID: 1548
		public int hostId;

		// Token: 0x0400060A RID: 1546
		public bool inProgress;

		// Token: 0x04000601 RID: 1537
		public int matchId;

		// Token: 0x0400060E RID: 1550
		public MatchScoringTypes matchScoringType;

		// Token: 0x0400060F RID: 1551
		public MatchTeamTypes matchTeamType;

		// Token: 0x04000602 RID: 1538
		public MatchTypes matchType;

		// Token: 0x0400060D RID: 1549
		public PlayModes playMode;

		// Token: 0x04000612 RID: 1554
		public int Seed;

		// Token: 0x04000611 RID: 1553
		protected bool SendPassword;

		// Token: 0x04000604 RID: 1540
		public int[] slotId = new int[bMatch.smethod_0()];

		// Token: 0x04000606 RID: 1542
		public Mods[] slotMods = new Mods[bMatch.smethod_0()];

		// Token: 0x04000603 RID: 1539
		public SlotStatus[] slotStatus = new SlotStatus[bMatch.smethod_0()];

		// Token: 0x04000605 RID: 1541
		public SlotTeams[] slotTeam = new SlotTeams[bMatch.smethod_0()];

		// Token: 0x04000610 RID: 1552
		public MultiSpecialModes specialModes;

		// Token: 0x06000DFF RID: 3583
		// RVA: 0x0004D394 File Offset: 0x0004B594
		public bMatch(Class32 class32_0)
		{
			this.SendPassword = false;
			this.matchId = (int)class32_0.ReadUInt16();
			this.inProgress = class32_0.ReadBoolean();
			this.matchType = (MatchTypes)class32_0.ReadByte();
			this.activeMods = (Mods)class32_0.ReadUInt32();
			this.gameName = class32_0.ReadString();
			this.gamePassword = class32_0.ReadString();
			this.beatmapName = class32_0.ReadString();
			this.beatmapId = class32_0.ReadInt32();
			this.beatmapChecksum = class32_0.ReadString();
			for (int i = 0; i < bMatch.smethod_0(); i++)
			{
				this.slotStatus[i] = (SlotStatus)class32_0.ReadByte();
			}
			for (int j = 0; j < bMatch.smethod_0(); j++)
			{
				this.slotTeam[j] = (SlotTeams)class32_0.ReadByte();
			}
			for (int k = 0; k < bMatch.smethod_0(); k++)
			{
				this.slotId[k] = (((this.slotStatus[k] & SlotStatus.flag_7) > (SlotStatus)0) ? class32_0.ReadInt32() : -1);
			}
			this.hostId = class32_0.ReadInt32();
			this.playMode = (PlayModes)class32_0.ReadByte();
			this.matchScoringType = (MatchScoringTypes)class32_0.ReadByte();
			this.matchTeamType = (MatchTeamTypes)class32_0.ReadByte();
			this.specialModes = (MultiSpecialModes)class32_0.ReadByte();
			if (this.gameName.Length > 50)
			{
				this.gameName = this.gameName.Remove(50);
			}
			if ((this.specialModes & MultiSpecialModes.FreeMod) > MultiSpecialModes.None)
			{
				for (int l = 0; l < bMatch.smethod_0(); l++)
				{
					this.slotMods[l] = (Mods)class32_0.ReadInt32();
				}
			}
			this.Seed = class32_0.ReadInt32();
		}

		// Token: 0x06000DFE RID: 3582
		// RVA: 0x0004D28C File Offset: 0x0004B48C
		public bMatch(MatchTypes matchTypes_0, MatchScoringTypes matchScoringTypes_0, MatchTeamTypes matchTeamTypes_0, PlayModes playModes_0, string string_0, string string_1, int int_0, string string_2, string string_3, int int_1, Mods mods_0, int int_2, MultiSpecialModes multiSpecialModes_0, int int_3)
		{
			this.matchType = matchTypes_0;
			this.playMode = playModes_0;
			this.matchScoringType = matchScoringTypes_0;
			this.matchTeamType = matchTeamTypes_0;
			this.gameName = string_0;
			this.gamePassword = string_1;
			this.beatmapName = string_2;
			this.beatmapChecksum = string_3;
			this.beatmapId = int_1;
			this.activeMods = mods_0;
			this.hostId = int_2;
			this.specialModes = multiSpecialModes_0;
			this.Seed = int_3;
			this.SendPassword = true;
			for (int i = 0; i < bMatch.smethod_0(); i++)
			{
				this.slotStatus[i] = ((i < int_0) ? SlotStatus.flag_0 : SlotStatus.flag_1);
				this.slotId[i] = -1;
			}
			if (string_0.Length > 50)
			{
				string_0 = string_0.Remove(50);
			}
		}

		// Token: 0x06000E0B RID: 3595
		// RVA: 0x0004D8C0 File Offset: 0x0004BAC0
		public object Clone()
		{
			bMatch bMatch = base.MemberwiseClone() as bMatch;
			bMatch.slotStatus = (SlotStatus[])this.slotStatus.Clone();
			bMatch.slotId = (int[])this.slotId.Clone();
			bMatch.slotTeam = (SlotTeams[])this.slotTeam.Clone();
			bMatch.slotMods = (Mods[])this.slotMods.Clone();
			return bMatch;
		}

		// Token: 0x06000DFD RID: 3581
		// RVA: 0x0000E9C2 File Offset: 0x0000CBC2
		public bool method_0()
		{
			return this.gamePassword != null;
		}

		// Token: 0x06000E00 RID: 3584
		// RVA: 0x0004D560 File Offset: 0x0004B760
		public int method_1()
		{
			int num = 0;
			for (int i = 0; i < bMatch.smethod_0(); i++)
			{
				if ((this.slotStatus[i] & SlotStatus.flag_7) > (SlotStatus)0)
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x06000E01 RID: 3585
		// RVA: 0x0004D594 File Offset: 0x0004B794
		public int method_2()
		{
			int num = 0;
			for (int i = 0; i < bMatch.smethod_0(); i++)
			{
				if ((this.slotStatus[i] & SlotStatus.flag_5) > (SlotStatus)0)
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x06000E02 RID: 3586
		// RVA: 0x0004D5C8 File Offset: 0x0004B7C8
		public int method_3()
		{
			int num = 0;
			for (int i = 0; i < bMatch.smethod_0(); i++)
			{
				if (this.slotStatus[i] != SlotStatus.flag_1)
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x06000E03 RID: 3587
		// RVA: 0x0004D5F8 File Offset: 0x0004B7F8
		public int method_4()
		{
			int num = 0;
			for (int i = 0; i < bMatch.smethod_0(); i++)
			{
				if (this.slotStatus[i] == SlotStatus.flag_0)
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x06000E04 RID: 3588
		// RVA: 0x0004D628 File Offset: 0x0004B828
		public int method_5()
		{
			int num = 0;
			for (int i = 0; i < bMatch.smethod_0(); i++)
			{
				if (this.slotStatus[i] == SlotStatus.flag_3)
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x06000E05 RID: 3589
		// RVA: 0x0000E9D0 File Offset: 0x0000CBD0
		public bool method_6()
		{
			return this.matchTeamType == MatchTeamTypes.TagTeamVs || this.matchTeamType == MatchTeamTypes.TeamVs;
		}

		// Token: 0x06000E06 RID: 3590
		// RVA: 0x0004D658 File Offset: 0x0004B858
		public bool method_7()
		{
			if (!this.method_6())
			{
				return true;
			}
			SlotTeams? slotTeams = null;
			for (int i = 0; i < bMatch.smethod_0(); i++)
			{
				if ((this.slotStatus[i] & SlotStatus.flag_7) > (SlotStatus)0 && (this.slotStatus[i] & SlotStatus.flag_4) == (SlotStatus)0)
				{
					if (!slotTeams.HasValue)
					{
						slotTeams = new SlotTeams?(this.slotTeam[i]);
					}
					else if (slotTeams != this.slotTeam[i])
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06000E09 RID: 3593
		// RVA: 0x0004D858 File Offset: 0x0004BA58
		public int method_8(int int_0)
		{
			int i;
			for (i = 0; i < bMatch.smethod_0(); i++)
			{
				if (this.slotId[i] == int_0)
				{
					break;
				}
			}
			if (i > bMatch.smethod_0() - 1)
			{
				return -1;
			}
			return i;
		}

		// Token: 0x06000E0A RID: 3594
		// RVA: 0x0004D890 File Offset: 0x0004BA90
		public bool method_9()
		{
			for (int i = 8; i < bMatch.smethod_0(); i++)
			{
				if (this.slotStatus[i] != SlotStatus.flag_1)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000E07 RID: 3591
		// RVA: 0x000060D8 File Offset: 0x000042D8
		public void ReadFromStream(Class32 class32_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000DFC RID: 3580
		// RVA: 0x0000E9B3 File Offset: 0x0000CBB3
		public static int smethod_0()
		{
			if (Class213.int_0 <= 18)
			{
				return 8;
			}
			return 16;
		}

		// Token: 0x06000E08 RID: 3592
		// RVA: 0x0004D6E4 File Offset: 0x0004B8E4
		public void WriteToStream(Class31 class31_0)
		{
			class31_0.Write((short)this.matchId);
			class31_0.Write(this.inProgress);
			class31_0.Write((byte)this.matchType);
			class31_0.Write((uint)this.activeMods);
			class31_0.Write(this.gameName);
			class31_0.Write((this.SendPassword || this.gamePassword == null) ? this.gamePassword : string.Empty);
			class31_0.Write(this.beatmapName);
			class31_0.Write(this.beatmapId);
			class31_0.Write(this.beatmapChecksum);
			for (int i = 0; i < bMatch.smethod_0(); i++)
			{
				class31_0.Write((byte)this.slotStatus[i]);
			}
			for (int j = 0; j < bMatch.smethod_0(); j++)
			{
				class31_0.Write((byte)this.slotTeam[j]);
			}
			for (int k = 0; k < bMatch.smethod_0(); k++)
			{
				if ((this.slotStatus[k] & SlotStatus.flag_7) > (SlotStatus)0)
				{
					class31_0.Write(this.slotId[k]);
				}
			}
			class31_0.Write(this.hostId);
			class31_0.Write((byte)this.playMode);
			class31_0.Write((byte)this.matchScoringType);
			class31_0.Write((byte)this.matchTeamType);
			class31_0.Write((byte)this.specialModes);
			if ((this.specialModes & MultiSpecialModes.FreeMod) > MultiSpecialModes.None)
			{
				for (int l = 0; l < bMatch.smethod_0(); l++)
				{
					class31_0.Write((int)this.slotMods[l]);
				}
			}
			class31_0.Write(this.Seed);
		}
	}
}
