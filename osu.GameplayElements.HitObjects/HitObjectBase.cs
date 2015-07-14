using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace osu.GameplayElements.HitObjects
{
	// Token: 0x0200030C RID: 780
	public abstract class HitObjectBase : MarshalByRefObject
	{
		// Token: 0x04001234 RID: 4660
		public Color Colour;

		// Token: 0x04001233 RID: 4659
		public int ComboColourIndex;

		// Token: 0x04001232 RID: 4658
		public int ComboColourOffset;

		// Token: 0x0400122D RID: 4653
		public int EndTime;

		// Token: 0x04001237 RID: 4663
		public bool LastInCombo;

		// Token: 0x04001235 RID: 4661
		public Vector2 Position;

		// Token: 0x04001230 RID: 4656
		public int SegmentCount = 1;

		// Token: 0x0400122F RID: 4655
		public HitObjectSoundType SoundType;

		// Token: 0x04001231 RID: 4657
		public double SpatialLength;

		// Token: 0x04001236 RID: 4662
		public int StackCount;

		// Token: 0x0400122C RID: 4652
		public int StartTime;

		// Token: 0x0400122E RID: 4654
		public HitObjectType Type;

		// Token: 0x1700031A RID: 794
		public bool Clap
		{
			// Token: 0x06001770 RID: 6000
			// RVA: 0x000148BE File Offset: 0x00012ABE
			get
			{
				return this.SoundType.IsType(HitObjectSoundType.Clap);
			}
			// Token: 0x06001771 RID: 6001
			// RVA: 0x000148CC File Offset: 0x00012ACC
			set
			{
				if (value)
				{
					this.SoundType |= HitObjectSoundType.Clap;
					return;
				}
				this.SoundType &= ~HitObjectSoundType.Clap;
			}
		}

		// Token: 0x1700031E RID: 798
		public abstract int ComboNumber
		{
			// Token: 0x06001777 RID: 6007
			get;
			// Token: 0x06001778 RID: 6008
			set;
		}

		// Token: 0x1700031D RID: 797
		public abstract Vector2 EndPosition
		{
			// Token: 0x06001775 RID: 6005
			get;
			// Token: 0x06001776 RID: 6006
			set;
		}

		// Token: 0x17000319 RID: 793
		public bool Finish
		{
			// Token: 0x0600176E RID: 5998
			// RVA: 0x0001488D File Offset: 0x00012A8D
			get
			{
				return this.SoundType.IsType(HitObjectSoundType.Finish);
			}
			// Token: 0x0600176F RID: 5999
			// RVA: 0x0001489B File Offset: 0x00012A9B
			set
			{
				if (value)
				{
					this.SoundType |= HitObjectSoundType.Finish;
					return;
				}
				this.SoundType &= ~HitObjectSoundType.Finish;
			}
		}

		// Token: 0x17000317 RID: 791
		public int Length
		{
			// Token: 0x0600176A RID: 5994
			// RVA: 0x0001483F File Offset: 0x00012A3F
			get
			{
				return this.EndTime - this.StartTime;
			}
		}

		// Token: 0x1700031C RID: 796
		public virtual bool NewCombo
		{
			// Token: 0x06001773 RID: 6003
			// RVA: 0x000148FE File Offset: 0x00012AFE
			get
			{
				return this.IsType(HitObjectType.NewCombo);
			}
			// Token: 0x06001774 RID: 6004
			// RVA: 0x00014907 File Offset: 0x00012B07
			set
			{
				if (value)
				{
					this.Type |= HitObjectType.NewCombo;
					return;
				}
				this.Type &= ~HitObjectType.NewCombo;
			}
		}

		// Token: 0x1700031B RID: 795
		public int SegmentLength
		{
			// Token: 0x06001772 RID: 6002
			// RVA: 0x000148EF File Offset: 0x00012AEF
			get
			{
				return this.Length / this.SegmentCount;
			}
		}

		// Token: 0x17000318 RID: 792
		public bool Whistle
		{
			// Token: 0x0600176C RID: 5996
			// RVA: 0x0001485C File Offset: 0x00012A5C
			get
			{
				return this.SoundType.IsType(HitObjectSoundType.Whistle);
			}
			// Token: 0x0600176D RID: 5997
			// RVA: 0x0001486A File Offset: 0x00012A6A
			set
			{
				if (value)
				{
					this.SoundType |= HitObjectSoundType.Whistle;
					return;
				}
				this.SoundType &= ~HitObjectSoundType.Whistle;
			}
		}

		// Token: 0x0600176B RID: 5995
		// RVA: 0x0001484E File Offset: 0x00012A4E
		public bool IsType(HitObjectType type)
		{
			return this.Type.IsType(type);
		}

		// Token: 0x0600177A RID: 6010
		// RVA: 0x0001492A File Offset: 0x00012B2A
		public virtual Vector2 PositionAtTime(int time)
		{
			return this.Position;
		}

		// Token: 0x06001779 RID: 6009
		// RVA: 0x000731E4 File Offset: 0x000713E4
		public override string ToString()
		{
			return string.Concat(new object[]
			{
				this.Type,
				": ",
				this.StartTime,
				"-",
				this.EndTime,
				" stack:",
				this.StackCount
			});
		}
	}
}
