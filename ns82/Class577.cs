using Microsoft.Xna.Framework.Input;
using osu.Input;
using System;

namespace ns82
{
	// Token: 0x02000478 RID: 1144
	internal sealed class Class577
	{
		// Token: 0x04001E98 RID: 7832
		internal int int_0;

		// Token: 0x04001E9A RID: 7834
		private Keys[] keys_0;

		// Token: 0x04001E99 RID: 7833
		internal ManiaLayoutsFor maniaLayoutsFor_0;

		// Token: 0x17000383 RID: 899
		internal Keys this[int int_1, Enum53 enum53_0]
		{
			// Token: 0x060024E8 RID: 9448
			// RVA: 0x0001CD55 File Offset: 0x0001AF55
			get
			{
				return this.keys_0[this.method_1(int_1, enum53_0)];
			}
			// Token: 0x060024E9 RID: 9449
			// RVA: 0x000DDEA0 File Offset: 0x000DC0A0
			set
			{
				for (int i = 0; i < this.keys_0.Length; i++)
				{
					if (this.keys_0[i] == value)
					{
						this.keys_0[i] = 0;
					}
				}
				this.keys_0[this.method_1(int_1, enum53_0)] = value;
			}
		}

		// Token: 0x060024EB RID: 9451
		// RVA: 0x000DDF30 File Offset: 0x000DC130
		internal Class577(int int_1, ManiaLayoutsFor maniaLayoutsFor_1, string string_0)
		{
			this.int_0 = int_1;
			this.maniaLayoutsFor_0 = maniaLayoutsFor_1;
			this.keys_0 = new Keys[this.int_0 + this.method_0()];
			string[] array = string_0.Split(null, StringSplitOptions.RemoveEmptyEntries);
			for (int i = 0; i < this.keys_0.Length; i++)
			{
				try
				{
					this[i, Enum53.const_0] = (Keys)Enum.Parse(typeof(Keys), array[i], true);
				}
				catch
				{
					this[i, Enum53.const_0] = 0;
				}
			}
		}

		// Token: 0x060024E7 RID: 9447
		// RVA: 0x0001CD47 File Offset: 0x0001AF47
		internal int method_0()
		{
			if (this.maniaLayoutsFor_0 != ManiaLayoutsFor.Split)
			{
				return 1;
			}
			return 2;
		}

		// Token: 0x060024EA RID: 9450
		// RVA: 0x000DDEE4 File Offset: 0x000DC0E4
		private int method_1(int int_1, Enum53 enum53_0)
		{
			switch (enum53_0)
			{
			case Enum53.const_0:
				return int_1;
			case Enum53.const_1:
				if (int_1 < this.int_0)
				{
					return int_1;
				}
				break;
			case Enum53.const_2:
				if (int_1 < this.method_0())
				{
					return int_1 + this.int_0;
				}
				break;
			}
			throw new IndexOutOfRangeException();
		}

		// Token: 0x060024EC RID: 9452
		// RVA: 0x000DDFC4 File Offset: 0x000DC1C4
		public override string ToString()
		{
			int num = this.int_0 - 1;
			for (int i = this.int_0; i < this.keys_0.Length; i++)
			{
				if (this[i, Enum53.const_0] != null)
				{
					num = i;
				}
			}
			string text = string.Empty;
			for (int j = 0; j <= num; j++)
			{
				text = text + this[j, Enum53.const_0].ToString() + ' ';
			}
			return text.TrimEnd(new char[0]);
		}
	}
}
