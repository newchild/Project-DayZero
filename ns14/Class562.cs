using System;

namespace ns14
{
	// Token: 0x0200046C RID: 1132
	internal static class Class562
	{
		// Token: 0x04001E72 RID: 7794
		private static Random random_0 = new Random();

		// Token: 0x06002490 RID: 9360
		// RVA: 0x0001CA4C File Offset: 0x0001AC4C
		internal static int smethod_0(int int_0)
		{
			return Class562.random_0.Next(int_0);
		}

		// Token: 0x06002491 RID: 9361
		// RVA: 0x0001CA59 File Offset: 0x0001AC59
		internal static int smethod_1(int int_0, int int_1)
		{
			return Class562.random_0.Next(int_0, int_1);
		}

		// Token: 0x06002492 RID: 9362
		// RVA: 0x0001CA67 File Offset: 0x0001AC67
		internal static double smethod_2()
		{
			return Class562.random_0.NextDouble();
		}

		// Token: 0x06002493 RID: 9363
		// RVA: 0x0001CA73 File Offset: 0x0001AC73
		internal static double smethod_3(double double_0)
		{
			if (double_0 < 0.0)
			{
				throw new ArgumentOutOfRangeException("maxValue", "The given maximum value must be greater than or equal to 0.");
			}
			return Class562.random_0.NextDouble() * double_0;
		}

		// Token: 0x06002494 RID: 9364
		// RVA: 0x0001CA9D File Offset: 0x0001AC9D
		internal static float smethod_4()
		{
			return (float)Class562.random_0.NextDouble();
		}

		// Token: 0x06002495 RID: 9365
		// RVA: 0x0001CAAA File Offset: 0x0001ACAA
		internal static float smethod_5(float float_0)
		{
			if (float_0 < 0f)
			{
				throw new ArgumentOutOfRangeException("maxValue", "The given maximum value must be greater than or equal to 0.");
			}
			return Class562.smethod_4() * float_0;
		}

		// Token: 0x06002496 RID: 9366
		// RVA: 0x0001CACB File Offset: 0x0001ACCB
		internal static float smethod_6(float float_0, float float_1)
		{
			if (float_0 > float_1)
			{
				throw new ArgumentOutOfRangeException("minValue", "The given minimum value must be less than or equal to the given maximum value.");
			}
			return float_0 + Class562.smethod_4() * (float_1 - float_0);
		}

		// Token: 0x06002497 RID: 9367
		// RVA: 0x0001CAEC File Offset: 0x0001ACEC
		internal static bool smethod_7(double double_0)
		{
			return Class562.smethod_2() < double_0;
		}
	}
}
