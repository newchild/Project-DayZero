using System;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000154 RID: 340
	internal sealed class EnumValue<T> where T : struct
	{
		// Token: 0x040005AC RID: 1452
		private readonly string _name;

		// Token: 0x040005AD RID: 1453
		private readonly T _value;

		// Token: 0x17000279 RID: 633
		public string Name
		{
			// Token: 0x06000D5F RID: 3423
			// RVA: 0x0000E3F2 File Offset: 0x0000C5F2
			get
			{
				return this._name;
			}
		}

		// Token: 0x1700027A RID: 634
		public T Value
		{
			// Token: 0x06000D60 RID: 3424
			// RVA: 0x0000E3FA File Offset: 0x0000C5FA
			get
			{
				return this._value;
			}
		}

		// Token: 0x06000D61 RID: 3425
		// RVA: 0x0000E402 File Offset: 0x0000C602
		public EnumValue(string name, T value)
		{
			this._name = name;
			this._value = value;
		}
	}
}
