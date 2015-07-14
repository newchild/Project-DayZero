using Microsoft.StylusInput;
using Microsoft.StylusInput.PluginData;
using System;

namespace ns82
{
	// Token: 0x02000603 RID: 1539
	internal sealed class Class801 : IStylusAsyncPlugin
	{
		// Token: 0x04002B5C RID: 11100
		private Class571 class571_0;

		// Token: 0x170003A7 RID: 935
		public DataInterestMask DataInterest
		{
			// Token: 0x06002FC9 RID: 12233
			// RVA: 0x00023844 File Offset: 0x00021A44
			get
			{
				return (DataInterestMask)2688;
			}
		}

		// Token: 0x06002FC8 RID: 12232
		// RVA: 0x00023835 File Offset: 0x00021A35
		internal Class801(Class571 class571_1)
		{
			this.class571_0 = class571_1;
		}

		// Token: 0x06002FCD RID: 12237
		// RVA: 0x0000653E File Offset: 0x0000473E
		public void CustomStylusDataAdded(RealTimeStylus sender, CustomStylusData data)
		{
		}

		// Token: 0x06002FD4 RID: 12244
		// RVA: 0x0000653E File Offset: 0x0000473E
		public void Error(RealTimeStylus sender, ErrorData data)
		{
		}

		// Token: 0x06002FD5 RID: 12245
		// RVA: 0x0000653E File Offset: 0x0000473E
		public void InAirPackets(RealTimeStylus sender, InAirPacketsData data)
		{
		}

		// Token: 0x06002FD6 RID: 12246
		// RVA: 0x0000653E File Offset: 0x0000473E
		public void Packets(RealTimeStylus sender, PacketsData data)
		{
		}

		// Token: 0x06002FCE RID: 12238
		// RVA: 0x0000653E File Offset: 0x0000473E
		public void RealTimeStylusDisabled(RealTimeStylus sender, RealTimeStylusDisabledData data)
		{
		}

		// Token: 0x06002FD2 RID: 12242
		// RVA: 0x0000653E File Offset: 0x0000473E
		public void RealTimeStylusEnabled(RealTimeStylus sender, RealTimeStylusEnabledData data)
		{
		}

		// Token: 0x06002FD8 RID: 12248
		// RVA: 0x0000653E File Offset: 0x0000473E
		public void StylusButtonDown(RealTimeStylus sender, StylusButtonDownData data)
		{
		}

		// Token: 0x06002FD0 RID: 12240
		// RVA: 0x0000653E File Offset: 0x0000473E
		public void StylusButtonUp(RealTimeStylus sender, StylusButtonUpData data)
		{
		}

		// Token: 0x06002FCA RID: 12234
		// RVA: 0x0002384B File Offset: 0x00021A4B
		public void StylusDown(RealTimeStylus sender, StylusDownData data)
		{
			this.class571_0.bool_1 = true;
			this.class571_0.buttonState_0 = 1;
		}

		// Token: 0x06002FD1 RID: 12241
		// RVA: 0x0000653E File Offset: 0x0000473E
		public void StylusInRange(RealTimeStylus sender, StylusInRangeData data)
		{
		}

		// Token: 0x06002FCF RID: 12239
		// RVA: 0x0000653E File Offset: 0x0000473E
		public void StylusOutOfRange(RealTimeStylus sender, StylusOutOfRangeData data)
		{
		}

		// Token: 0x06002FCB RID: 12235
		// RVA: 0x00023865 File Offset: 0x00021A65
		public void StylusUp(RealTimeStylus sender, StylusUpData data)
		{
			this.class571_0.buttonState_0 = 0;
		}

		// Token: 0x06002FD7 RID: 12247
		// RVA: 0x000060D8 File Offset: 0x000042D8
		public void SystemGesture(RealTimeStylus sender, SystemGestureData data)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06002FD3 RID: 12243
		// RVA: 0x0000653E File Offset: 0x0000473E
		public void TabletAdded(RealTimeStylus sender, TabletAddedData data)
		{
		}

		// Token: 0x06002FCC RID: 12236
		// RVA: 0x0000653E File Offset: 0x0000473E
		public void TabletRemoved(RealTimeStylus sender, TabletRemovedData data)
		{
		}
	}
}
