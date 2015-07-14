using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace ns9
{
	// Token: 0x020001C1 RID: 449
	internal sealed class Class124 : IComparer<Class123>
	{
		// Token: 0x04000C0D RID: 3085
		private Class125 class125_0;

		// Token: 0x06000FC7 RID: 4039
		// RVA: 0x0000F874 File Offset: 0x0000DA74
		public Class124(Class125 class125_1)
		{
			this.class125_0 = class125_1;
		}

		// Token: 0x06000FC8 RID: 4040
		// RVA: 0x00054270 File Offset: 0x00052470
		public int Compare(Class123 x, Class123 y)
		{
			if (x.method_4() != y.method_4())
			{
				if (x.method_4() >= y.method_4())
				{
					return 1;
				}
				return -1;
			}
			else
			{
				CreateOptions createOptions = x.method_2() & 224;
				CreateOptions createOptions2 = y.method_2() & 224;
				if (createOptions != createOptions2)
				{
					if (createOptions == 64)
					{
						return -1;
					}
					if (createOptions2 != 64)
					{
						if (createOptions == 128)
						{
							return -1;
						}
						if (createOptions2 == 128)
						{
							return 1;
						}
						if (createOptions != null)
						{
							return -1;
						}
					}
					return 1;
				}
				else
				{
					PresentationParameters presentationParameters = x.method_6();
					PresentationParameters presentationParameters2 = y.method_6();
					if (presentationParameters.get_IsFullScreen() != presentationParameters2.get_IsFullScreen())
					{
						if (this.class125_0.method_0() != presentationParameters.get_IsFullScreen())
						{
							return 1;
						}
						return -1;
					}
					else
					{
						int num = this.method_0(presentationParameters.get_BackBufferFormat());
						int num2 = this.method_0(presentationParameters2.get_BackBufferFormat());
						if (num != num2)
						{
							if (num >= num2)
							{
								return 1;
							}
							return -1;
						}
						else if (presentationParameters.get_MultiSampleType() != presentationParameters2.get_MultiSampleType())
						{
							int num3 = (presentationParameters.get_MultiSampleType() == 1) ? 17 : presentationParameters.get_MultiSampleType();
							int num4 = (presentationParameters2.get_MultiSampleType() == 1) ? 17 : presentationParameters2.get_MultiSampleType();
							if (num3 <= num4)
							{
								return 1;
							}
							return -1;
						}
						else if (presentationParameters.get_MultiSampleQuality() != presentationParameters2.get_MultiSampleQuality())
						{
							if (presentationParameters.get_MultiSampleQuality() <= presentationParameters2.get_MultiSampleQuality())
							{
								return 1;
							}
							return -1;
						}
						else
						{
							float num5;
							if (this.class125_0.method_10() != 0 && this.class125_0.method_8() != 0)
							{
								num5 = (float)this.class125_0.method_10() / (float)this.class125_0.method_8();
							}
							else
							{
								num5 = (float)Class125.int_1 / (float)Class125.int_0;
							}
							float num6 = (float)presentationParameters.get_BackBufferWidth() / (float)presentationParameters.get_BackBufferHeight();
							float num7 = (float)presentationParameters2.get_BackBufferWidth() / (float)presentationParameters2.get_BackBufferHeight();
							float num8 = Math.Abs(num6 - num5);
							float num9 = Math.Abs(num7 - num5);
							if (Math.Abs(num8 - num9) > 0.2f)
							{
								if (num8 >= num9)
								{
									return 1;
								}
								return -1;
							}
							else
							{
								int num11;
								int num10;
								if (this.class125_0.method_0())
								{
									if (this.class125_0.method_10() != 0 && this.class125_0.method_8() != 0)
									{
										num10 = (num11 = this.class125_0.method_10() * this.class125_0.method_8());
									}
									else
									{
										GraphicsAdapter graphicsAdapter = x.method_0();
										num11 = graphicsAdapter.get_CurrentDisplayMode().get_Width() * graphicsAdapter.get_CurrentDisplayMode().get_Height();
										GraphicsAdapter graphicsAdapter2 = y.method_0();
										num10 = graphicsAdapter2.get_CurrentDisplayMode().get_Width() * graphicsAdapter2.get_CurrentDisplayMode().get_Height();
									}
								}
								else if (this.class125_0.method_10() != 0 && this.class125_0.method_8() != 0)
								{
									num10 = (num11 = this.class125_0.method_10() * this.class125_0.method_8());
								}
								else
								{
									num10 = (num11 = Class125.int_1 * Class125.int_0);
								}
								int num12 = Math.Abs(presentationParameters.get_BackBufferWidth() * presentationParameters.get_BackBufferHeight() - num11);
								int num13 = Math.Abs(presentationParameters2.get_BackBufferWidth() * presentationParameters2.get_BackBufferHeight() - num10);
								if (num12 != num13)
								{
									if (num12 >= num13)
									{
										return 1;
									}
									return -1;
								}
								else
								{
									if (!this.class125_0.method_0() || presentationParameters.get_FullScreenRefreshRateInHz() == presentationParameters2.get_FullScreenRefreshRateInHz())
									{
										if (x.method_0() != y.method_0())
										{
											if (x.method_0().get_IsDefaultAdapter())
											{
												return -1;
											}
											if (y.method_0().get_IsDefaultAdapter())
											{
												return 1;
											}
										}
										return 0;
									}
									int num14 = Math.Abs(x.method_0().get_CurrentDisplayMode().get_RefreshRate() - presentationParameters.get_FullScreenRefreshRateInHz());
									int num15 = Math.Abs(y.method_0().get_CurrentDisplayMode().get_RefreshRate() - presentationParameters2.get_FullScreenRefreshRateInHz());
									if (num14 > num15)
									{
										return 1;
									}
									return -1;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000FC9 RID: 4041
		// RVA: 0x0005460C File Offset: 0x0005280C
		private int method_0(SurfaceFormat surfaceFormat_0)
		{
			int num = Array.IndexOf<SurfaceFormat>(Class125.surfaceFormat_1, surfaceFormat_0);
			if (num != -1)
			{
				int num2 = Array.IndexOf<SurfaceFormat>(Class125.surfaceFormat_1, this.class125_0.method_6());
				if (num2 == -1)
				{
					return Class125.surfaceFormat_1.Length - num;
				}
				if (num >= num2)
				{
					return num - num2;
				}
			}
			return 2147483647;
		}
	}
}
