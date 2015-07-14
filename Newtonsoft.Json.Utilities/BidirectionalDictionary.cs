using System;
using System.Collections.Generic;
using System.Globalization;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000145 RID: 325
	internal sealed class BidirectionalDictionary<TFirst, TSecond>
	{
		// Token: 0x0400055A RID: 1370
		private readonly string _duplicateFirstErrorMessage;

		// Token: 0x0400055B RID: 1371
		private readonly string _duplicateSecondErrorMessage;

		// Token: 0x04000558 RID: 1368
		private readonly IDictionary<TFirst, TSecond> _firstToSecond;

		// Token: 0x04000559 RID: 1369
		private readonly IDictionary<TSecond, TFirst> _secondToFirst;

		// Token: 0x06000CD2 RID: 3282
		// RVA: 0x0000DA02 File Offset: 0x0000BC02
		public BidirectionalDictionary() : this(EqualityComparer<TFirst>.Default, EqualityComparer<TSecond>.Default)
		{
		}

		// Token: 0x06000CD3 RID: 3283
		// RVA: 0x0000DA14 File Offset: 0x0000BC14
		public BidirectionalDictionary(IEqualityComparer<TFirst> firstEqualityComparer, IEqualityComparer<TSecond> secondEqualityComparer) : this(firstEqualityComparer, secondEqualityComparer, "Duplicate item already exists for '{0}'.", "Duplicate item already exists for '{0}'.")
		{
		}

		// Token: 0x06000CD4 RID: 3284
		// RVA: 0x0000DA28 File Offset: 0x0000BC28
		public BidirectionalDictionary(IEqualityComparer<TFirst> firstEqualityComparer, IEqualityComparer<TSecond> secondEqualityComparer, string duplicateFirstErrorMessage, string duplicateSecondErrorMessage)
		{
			this._firstToSecond = new Dictionary<TFirst, TSecond>(firstEqualityComparer);
			this._secondToFirst = new Dictionary<TSecond, TFirst>(secondEqualityComparer);
			this._duplicateFirstErrorMessage = duplicateFirstErrorMessage;
			this._duplicateSecondErrorMessage = duplicateSecondErrorMessage;
		}

		// Token: 0x06000CD5 RID: 3285
		// RVA: 0x00049378 File Offset: 0x00047578
		public void Set(TFirst first, TSecond second)
		{
			TSecond tSecond;
			if (this._firstToSecond.TryGetValue(first, out tSecond) && !tSecond.Equals(second))
			{
				throw new ArgumentException(StringUtils.FormatWith(this._duplicateFirstErrorMessage, CultureInfo.InvariantCulture, first));
			}
			TFirst tFirst;
			if (this._secondToFirst.TryGetValue(second, out tFirst) && !tFirst.Equals(first))
			{
				throw new ArgumentException(StringUtils.FormatWith(this._duplicateSecondErrorMessage, CultureInfo.InvariantCulture, second));
			}
			this._firstToSecond.Add(first, second);
			this._secondToFirst.Add(second, first);
		}

		// Token: 0x06000CD6 RID: 3286
		// RVA: 0x0000DA57 File Offset: 0x0000BC57
		public bool TryGetByFirst(TFirst first, out TSecond second)
		{
			return this._firstToSecond.TryGetValue(first, out second);
		}

		// Token: 0x06000CD7 RID: 3287
		// RVA: 0x0000DA66 File Offset: 0x0000BC66
		public bool TryGetBySecond(TSecond second, out TFirst first)
		{
			return this._secondToFirst.TryGetValue(second, out first);
		}
	}
}
