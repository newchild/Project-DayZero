using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Globalization;
using System.Resources;

namespace ns9
{
	// Token: 0x020001CA RID: 458
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0"), DebuggerNonUserCode]
	internal sealed class Class127
	{
		// Token: 0x04000C5E RID: 3166
		private static CultureInfo cultureInfo_0;

		// Token: 0x04000C5F RID: 3167
		private static ResourceManager resourceManager_0;

		// Token: 0x1700028A RID: 650
		internal static ResourceManager ResourceManager
		{
			// Token: 0x06001021 RID: 4129
			// RVA: 0x00055B48 File Offset: 0x00053D48
			get
			{
				if (object.ReferenceEquals(Class127.resourceManager_0, null))
				{
					ResourceManager resourceManager = new ResourceManager("Microsoft.Xna.Framework.Resources", typeof(Class127).Assembly);
					Class127.resourceManager_0 = resourceManager;
				}
				return Class127.resourceManager_0;
			}
		}

		// Token: 0x06001011 RID: 4113
		// RVA: 0x0000FAE4 File Offset: 0x0000DCE4
		internal static string smethod_0()
		{
			return Class127.ResourceManager.GetString("BackBufferDimMustBePositive", Class127.cultureInfo_0);
		}

		// Token: 0x06001012 RID: 4114
		// RVA: 0x0000FAFA File Offset: 0x0000DCFA
		internal static string smethod_1()
		{
			return Class127.ResourceManager.GetString("CannotAddSameComponentMultipleTimes", Class127.cultureInfo_0);
		}

		// Token: 0x0600101B RID: 4123
		// RVA: 0x0000FBC0 File Offset: 0x0000DDC0
		internal static string smethod_10()
		{
			return Class127.ResourceManager.GetString("MustCallBeginDeviceChange", Class127.cultureInfo_0);
		}

		// Token: 0x0600101C RID: 4124
		// RVA: 0x0000FBD6 File Offset: 0x0000DDD6
		internal static string smethod_11()
		{
			return Class127.ResourceManager.GetString("NoCompatibleDevices", Class127.cultureInfo_0);
		}

		// Token: 0x0600101D RID: 4125
		// RVA: 0x0000FBEC File Offset: 0x0000DDEC
		internal static string smethod_12()
		{
			return Class127.ResourceManager.GetString("NoCompatibleDevicesAfterRanking", Class127.cultureInfo_0);
		}

		// Token: 0x0600101E RID: 4126
		// RVA: 0x0000FC02 File Offset: 0x0000DE02
		internal static string smethod_13()
		{
			return Class127.ResourceManager.GetString("NoMulitpleRuns", Class127.cultureInfo_0);
		}

		// Token: 0x0600101F RID: 4127
		// RVA: 0x0000FC18 File Offset: 0x0000DE18
		internal static string smethod_14()
		{
			return Class127.ResourceManager.GetString("NoNullUseDefaultAdapter", Class127.cultureInfo_0);
		}

		// Token: 0x06001020 RID: 4128
		// RVA: 0x0000FC2E File Offset: 0x0000DE2E
		internal static string smethod_15()
		{
			return Class127.ResourceManager.GetString("NullOrEmptyScreenDeviceName", Class127.cultureInfo_0);
		}

		// Token: 0x06001022 RID: 4130
		// RVA: 0x0000FC44 File Offset: 0x0000DE44
		internal static string smethod_16()
		{
			return Class127.ResourceManager.GetString("ServiceAlreadyPresent", Class127.cultureInfo_0);
		}

		// Token: 0x06001023 RID: 4131
		// RVA: 0x0000FC5A File Offset: 0x0000DE5A
		internal static string smethod_17()
		{
			return Class127.ResourceManager.GetString("ServiceMustBeAssignable", Class127.cultureInfo_0);
		}

		// Token: 0x06001024 RID: 4132
		// RVA: 0x0000FC70 File Offset: 0x0000DE70
		internal static string smethod_18()
		{
			return Class127.ResourceManager.GetString("ServiceProviderCannotBeNull", Class127.cultureInfo_0);
		}

		// Token: 0x06001025 RID: 4133
		// RVA: 0x0000FC86 File Offset: 0x0000DE86
		internal static string smethod_19()
		{
			return Class127.ResourceManager.GetString("ServiceTypeCannotBeNull", Class127.cultureInfo_0);
		}

		// Token: 0x06001013 RID: 4115
		// RVA: 0x0000FB10 File Offset: 0x0000DD10
		internal static string smethod_2()
		{
			return Class127.ResourceManager.GetString("CannotSetItemsIntoGameComponentCollection", Class127.cultureInfo_0);
		}

		// Token: 0x06001026 RID: 4134
		// RVA: 0x0000FC9C File Offset: 0x0000DE9C
		internal static string smethod_20()
		{
			return Class127.ResourceManager.GetString("TitleCannotBeNull", Class127.cultureInfo_0);
		}

		// Token: 0x06001027 RID: 4135
		// RVA: 0x0000FCB2 File Offset: 0x0000DEB2
		internal static string smethod_21()
		{
			return Class127.ResourceManager.GetString("ValidateAutoDepthStencilAdapterGroup", Class127.cultureInfo_0);
		}

		// Token: 0x06001028 RID: 4136
		// RVA: 0x0000FCC8 File Offset: 0x0000DEC8
		internal static string smethod_22()
		{
			return Class127.ResourceManager.GetString("ValidateAutoDepthStencilFormatIncompatible", Class127.cultureInfo_0);
		}

		// Token: 0x06001029 RID: 4137
		// RVA: 0x0000FCDE File Offset: 0x0000DEDE
		internal static string smethod_23()
		{
			return Class127.ResourceManager.GetString("ValidateAutoDepthStencilFormatInvalid", Class127.cultureInfo_0);
		}

		// Token: 0x0600102A RID: 4138
		// RVA: 0x0000FCF4 File Offset: 0x0000DEF4
		internal static string smethod_24()
		{
			return Class127.ResourceManager.GetString("ValidateAutoDepthStencilMismatch", Class127.cultureInfo_0);
		}

		// Token: 0x0600102B RID: 4139
		// RVA: 0x0000FD0A File Offset: 0x0000DF0A
		internal static string smethod_25()
		{
			return Class127.ResourceManager.GetString("ValidateBackBufferCount", Class127.cultureInfo_0);
		}

		// Token: 0x0600102C RID: 4140
		// RVA: 0x0000FD20 File Offset: 0x0000DF20
		internal static string smethod_26()
		{
			return Class127.ResourceManager.GetString("ValidateBackBufferCountSwapCopy", Class127.cultureInfo_0);
		}

		// Token: 0x0600102D RID: 4141
		// RVA: 0x0000FD36 File Offset: 0x0000DF36
		internal static string smethod_27()
		{
			return Class127.ResourceManager.GetString("ValidateBackBufferDimsFullScreen", Class127.cultureInfo_0);
		}

		// Token: 0x0600102E RID: 4142
		// RVA: 0x0000FD4C File Offset: 0x0000DF4C
		internal static string smethod_28()
		{
			return Class127.ResourceManager.GetString("ValidateBackBufferDimsModeFullScreen", Class127.cultureInfo_0);
		}

		// Token: 0x0600102F RID: 4143
		// RVA: 0x0000FD62 File Offset: 0x0000DF62
		internal static string smethod_29()
		{
			return Class127.ResourceManager.GetString("ValidateBackBufferFormatIsInvalid", Class127.cultureInfo_0);
		}

		// Token: 0x06001014 RID: 4116
		// RVA: 0x0000FB26 File Offset: 0x0000DD26
		internal static string smethod_3()
		{
			return Class127.ResourceManager.GetString("DefaultTitleName", Class127.cultureInfo_0);
		}

		// Token: 0x06001030 RID: 4144
		// RVA: 0x0000FD78 File Offset: 0x0000DF78
		internal static string smethod_30()
		{
			return Class127.ResourceManager.GetString("ValidateBackBufferHzModeFullScreen", Class127.cultureInfo_0);
		}

		// Token: 0x06001031 RID: 4145
		// RVA: 0x0000FD8E File Offset: 0x0000DF8E
		internal static string smethod_31()
		{
			return Class127.ResourceManager.GetString("ValidateDepthStencilFormatIsInvalid", Class127.cultureInfo_0);
		}

		// Token: 0x06001032 RID: 4146
		// RVA: 0x0000FDA4 File Offset: 0x0000DFA4
		internal static string smethod_32()
		{
			return Class127.ResourceManager.GetString("ValidateDeviceType", Class127.cultureInfo_0);
		}

		// Token: 0x06001033 RID: 4147
		// RVA: 0x0000FDBA File Offset: 0x0000DFBA
		internal static string smethod_33()
		{
			return Class127.ResourceManager.GetString("ValidateMultiSampleQualityInvalid", Class127.cultureInfo_0);
		}

		// Token: 0x06001034 RID: 4148
		// RVA: 0x0000FDD0 File Offset: 0x0000DFD0
		internal static string smethod_34()
		{
			return Class127.ResourceManager.GetString("ValidateMultiSampleSwapEffect", Class127.cultureInfo_0);
		}

		// Token: 0x06001035 RID: 4149
		// RVA: 0x0000FDE6 File Offset: 0x0000DFE6
		internal static string smethod_35()
		{
			return Class127.ResourceManager.GetString("ValidateMultiSampleTypeInvalid", Class127.cultureInfo_0);
		}

		// Token: 0x06001036 RID: 4150
		// RVA: 0x0000FDFC File Offset: 0x0000DFFC
		internal static string smethod_36()
		{
			return Class127.ResourceManager.GetString("ValidatePresentationIntervalIncompatibleInFullScreen", Class127.cultureInfo_0);
		}

		// Token: 0x06001037 RID: 4151
		// RVA: 0x0000FE12 File Offset: 0x0000E012
		internal static string smethod_37()
		{
			return Class127.ResourceManager.GetString("ValidatePresentationIntervalInFullScreen", Class127.cultureInfo_0);
		}

		// Token: 0x06001038 RID: 4152
		// RVA: 0x0000FE28 File Offset: 0x0000E028
		internal static string smethod_38()
		{
			return Class127.ResourceManager.GetString("ValidatePresentationIntervalInWindow", Class127.cultureInfo_0);
		}

		// Token: 0x06001039 RID: 4153
		// RVA: 0x0000FE3E File Offset: 0x0000E03E
		internal static string smethod_39()
		{
			return Class127.ResourceManager.GetString("ValidateRefreshRateInFullScreen", Class127.cultureInfo_0);
		}

		// Token: 0x06001015 RID: 4117
		// RVA: 0x0000FB3C File Offset: 0x0000DD3C
		internal static string smethod_4()
		{
			return Class127.ResourceManager.GetString("GameCannotBeNull", Class127.cultureInfo_0);
		}

		// Token: 0x0600103A RID: 4154
		// RVA: 0x0000FE54 File Offset: 0x0000E054
		internal static string smethod_40()
		{
			return Class127.ResourceManager.GetString("ValidateRefreshRateInWindow", Class127.cultureInfo_0);
		}

		// Token: 0x0600103B RID: 4155
		// RVA: 0x0000FE6A File Offset: 0x0000E06A
		internal static string smethod_41()
		{
			return Class127.ResourceManager.GetString("ValidateSwapEffectInvalid", Class127.cultureInfo_0);
		}

		// Token: 0x06001016 RID: 4118
		// RVA: 0x0000FB52 File Offset: 0x0000DD52
		internal static string smethod_5()
		{
			return Class127.ResourceManager.GetString("GraphicsComponentNotAttachedToGame", Class127.cultureInfo_0);
		}

		// Token: 0x06001017 RID: 4119
		// RVA: 0x0000FB68 File Offset: 0x0000DD68
		internal static string smethod_6()
		{
			return Class127.ResourceManager.GetString("GraphicsDeviceManagerAlreadyPresent", Class127.cultureInfo_0);
		}

		// Token: 0x06001018 RID: 4120
		// RVA: 0x0000FB7E File Offset: 0x0000DD7E
		internal static string smethod_7()
		{
			return Class127.ResourceManager.GetString("InvalidScreenAdapter", Class127.cultureInfo_0);
		}

		// Token: 0x06001019 RID: 4121
		// RVA: 0x0000FB94 File Offset: 0x0000DD94
		internal static string smethod_8()
		{
			return Class127.ResourceManager.GetString("InvalidScreenDeviceName", Class127.cultureInfo_0);
		}

		// Token: 0x0600101A RID: 4122
		// RVA: 0x0000FBAA File Offset: 0x0000DDAA
		internal static string smethod_9()
		{
			return Class127.ResourceManager.GetString("MissingGraphicsDeviceService", Class127.cultureInfo_0);
		}
	}
}
