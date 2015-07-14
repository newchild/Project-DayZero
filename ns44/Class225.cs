using System;
using System.Net;
using System.Text;

namespace ns44
{
	// Token: 0x020002AC RID: 684
	internal sealed class Class225 : IEquatable<Class225>, IComparable<Class225>
	{
		// Token: 0x04001109 RID: 4361
		private Class228 class228_0;

		// Token: 0x0400110A RID: 4362
		private DateTime dateTime_0;

		// Token: 0x04001107 RID: 4359
		public static readonly int int_0 = 4;

		// Token: 0x04001108 RID: 4360
		private IPEndPoint ipendPoint_0;

		// Token: 0x170002F0 RID: 752
		public Class228 Id
		{
			// Token: 0x0600160F RID: 5647
			// RVA: 0x0001396A File Offset: 0x00011B6A
			get
			{
				return this.class228_0;
			}
		}

		// Token: 0x06001610 RID: 5648
		// RVA: 0x00013972 File Offset: 0x00011B72
		public Class225(Class228 class228_1, IPEndPoint ipendPoint_1)
		{
			this.ipendPoint_0 = ipendPoint_1;
			this.class228_0 = class228_1;
		}

		// Token: 0x06001612 RID: 5650
		// RVA: 0x00013988 File Offset: 0x00011B88
		public int CompareTo(Class225 obj)
		{
			if (obj == null)
			{
				return 1;
			}
			return this.dateTime_0.CompareTo(obj.dateTime_0);
		}

		// Token: 0x06001613 RID: 5651
		// RVA: 0x000139A0 File Offset: 0x00011BA0
		public override bool Equals(object obj)
		{
			return this.Equals(obj as Class225);
		}

		// Token: 0x06001614 RID: 5652
		// RVA: 0x000139AE File Offset: 0x00011BAE
		public bool Equals(Class225 other)
		{
			return other != null && this.class228_0.Equals(other.class228_0);
		}

		// Token: 0x06001615 RID: 5653
		// RVA: 0x000139C6 File Offset: 0x00011BC6
		public override int GetHashCode()
		{
			return this.class228_0.GetHashCode();
		}

		// Token: 0x06001611 RID: 5649
		// RVA: 0x00071608 File Offset: 0x0006F808
		internal static Class225 smethod_0(byte[] byte_0, int int_1)
		{
			byte[] array = new byte[20];
			Buffer.BlockCopy(byte_0, int_1, array, 0, 20);
			IPAddress address = new IPAddress((long)((ulong)BitConverter.ToInt32(byte_0, int_1 + 20)));
			int port = (int)((ushort)IPAddress.NetworkToHostOrder((short)BitConverter.ToUInt16(byte_0, int_1 + 24)));
			return new Class225(new Class228(array), new IPEndPoint(address, port));
		}

		// Token: 0x06001616 RID: 5654
		// RVA: 0x00071660 File Offset: 0x0006F860
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder(48);
			for (int i = 0; i < this.class228_0.method_0().Length; i++)
			{
				stringBuilder.Append(this.class228_0.method_0()[i]);
				stringBuilder.Append("-");
			}
			return stringBuilder.ToString(0, stringBuilder.Length - 1);
		}
	}
}
