using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security;

namespace ns9
{
	// Token: 0x020001C4 RID: 452
	internal sealed class Class126
	{
		// Token: 0x020001C7 RID: 455
		internal enum Enum8 : uint
		{
			// Token: 0x04000C38 RID: 3128
			const_0 = 28u,
			// Token: 0x04000C39 RID: 3129
			const_1 = 258u,
			// Token: 0x04000C3A RID: 3130
			const_2 = 16u,
			// Token: 0x04000C3B RID: 3131
			const_3 = 2u,
			// Token: 0x04000C3C RID: 3132
			const_4 = 529u,
			// Token: 0x04000C3D RID: 3133
			const_5 = 561u,
			// Token: 0x04000C3E RID: 3134
			const_6 = 530u,
			// Token: 0x04000C3F RID: 3135
			const_7 = 562u,
			// Token: 0x04000C40 RID: 3136
			const_8 = 36u,
			// Token: 0x04000C41 RID: 3137
			const_9 = 256u,
			// Token: 0x04000C42 RID: 3138
			const_10,
			// Token: 0x04000C43 RID: 3139
			const_11 = 515u,
			// Token: 0x04000C44 RID: 3140
			const_12 = 513u,
			// Token: 0x04000C45 RID: 3141
			const_13,
			// Token: 0x04000C46 RID: 3142
			const_14 = 521u,
			// Token: 0x04000C47 RID: 3143
			const_15 = 519u,
			// Token: 0x04000C48 RID: 3144
			const_16,
			// Token: 0x04000C49 RID: 3145
			const_17 = 513u,
			// Token: 0x04000C4A RID: 3146
			const_18 = 525u,
			// Token: 0x04000C4B RID: 3147
			const_19 = 512u,
			// Token: 0x04000C4C RID: 3148
			const_20 = 522u,
			// Token: 0x04000C4D RID: 3149
			const_21 = 132u,
			// Token: 0x04000C4E RID: 3150
			const_22 = 15u,
			// Token: 0x04000C4F RID: 3151
			const_23 = 536u,
			// Token: 0x04000C50 RID: 3152
			const_24 = 18u,
			// Token: 0x04000C51 RID: 3153
			const_25 = 518u,
			// Token: 0x04000C52 RID: 3154
			const_26 = 516u,
			// Token: 0x04000C53 RID: 3155
			const_27,
			// Token: 0x04000C54 RID: 3156
			const_28 = 32u,
			// Token: 0x04000C55 RID: 3157
			const_29 = 5u,
			// Token: 0x04000C56 RID: 3158
			const_30 = 262u,
			// Token: 0x04000C57 RID: 3159
			const_31 = 274u,
			// Token: 0x04000C58 RID: 3160
			const_32 = 260u,
			// Token: 0x04000C59 RID: 3161
			const_33,
			// Token: 0x04000C5A RID: 3162
			const_34 = 525u,
			// Token: 0x04000C5B RID: 3163
			const_35 = 523u,
			// Token: 0x04000C5C RID: 3164
			const_36
		}

		// Token: 0x020001C5 RID: 453
		public struct Struct18
		{
			// Token: 0x04000C2E RID: 3118
			public Class126.Enum8 enum8_0;

			// Token: 0x04000C2D RID: 3117
			public IntPtr intptr_0;

			// Token: 0x04000C2F RID: 3119
			public IntPtr intptr_1;

			// Token: 0x04000C30 RID: 3120
			public IntPtr intptr_2;

			// Token: 0x04000C32 RID: 3122
			public Point point_0;

			// Token: 0x04000C31 RID: 3121
			public uint uint_0;
		}

		// Token: 0x020001C6 RID: 454
		public struct Struct19
		{
			// Token: 0x04000C33 RID: 3123
			public int int_0;

			// Token: 0x04000C34 RID: 3124
			public int int_1;

			// Token: 0x04000C35 RID: 3125
			public int int_2;

			// Token: 0x04000C36 RID: 3126
			public int int_3;
		}

		// Token: 0x0600100A RID: 4106
		[SuppressUnmanagedCodeSecurity]
		[DllImport("user32.dll")]
		internal static extern bool GetClientRect(IntPtr intptr_0, ref Class126.Struct19 struct19_0);

		// Token: 0x0600100B RID: 4107
		[SuppressUnmanagedCodeSecurity]
		[DllImport("user32.dll")]
		internal static extern bool GetWindowRect(IntPtr intptr_0, ref Class126.Struct19 struct19_0);

		// Token: 0x0600100C RID: 4108
		[SuppressUnmanagedCodeSecurity]
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		internal static extern bool PeekMessage(ref Class126.Struct18 struct18_0, IntPtr intptr_0, uint uint_0, uint uint_1, uint uint_2);
	}
}
