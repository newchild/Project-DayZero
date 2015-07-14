using Newtonsoft.Json.Utilities;
using Newtonsoft.Json.Utilities.LinqBridge;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000DF RID: 223
	public struct JEnumerable<T> : IEnumerable<T>, IEnumerable, IEquatable<JEnumerable<T>>, IJEnumerable<T> where T : JToken
	{
		// Token: 0x040003C1 RID: 961
		public static readonly JEnumerable<T> Empty = new JEnumerable<T>(Enumerable.Empty<T>());

		// Token: 0x040003C2 RID: 962
		private readonly IEnumerable<T> _enumerable;

		// Token: 0x1700017D RID: 381
		public IJEnumerable<JToken> this[object key]
		{
			// Token: 0x060008D6 RID: 2262
			// RVA: 0x0000B57F File Offset: 0x0000977F
			get
			{
				if (this._enumerable == null)
				{
					return JEnumerable<JToken>.Empty;
				}
				return new JEnumerable<JToken>(Extensions.Values<T, JToken>(this._enumerable, key));
			}
		}

		// Token: 0x060008D3 RID: 2259
		// RVA: 0x0000B563 File Offset: 0x00009763
		public JEnumerable(IEnumerable<T> enumerable)
		{
			ValidationUtils.ArgumentNotNull(enumerable, "enumerable");
			this._enumerable = enumerable;
		}

		// Token: 0x060008D7 RID: 2263
		// RVA: 0x0000B5AA File Offset: 0x000097AA
		public bool Equals(JEnumerable<T> other)
		{
			return object.Equals(this._enumerable, other._enumerable);
		}

		// Token: 0x060008D8 RID: 2264
		// RVA: 0x0000B5BE File Offset: 0x000097BE
		public override bool Equals(object obj)
		{
			return obj is JEnumerable<T> && this.Equals((JEnumerable<T>)obj);
		}

		// Token: 0x060008D4 RID: 2260
		// RVA: 0x0003D67C File Offset: 0x0003B87C
		public IEnumerator<T> GetEnumerator()
		{
			if (this._enumerable == null)
			{
				return JEnumerable<T>.Empty.GetEnumerator();
			}
			return this._enumerable.GetEnumerator();
		}

		// Token: 0x060008D9 RID: 2265
		// RVA: 0x0000B5D6 File Offset: 0x000097D6
		public override int GetHashCode()
		{
			if (this._enumerable == null)
			{
				return 0;
			}
			return this._enumerable.GetHashCode();
		}

		// Token: 0x060008D5 RID: 2261
		// RVA: 0x0000B577 File Offset: 0x00009777
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}
	}
}
