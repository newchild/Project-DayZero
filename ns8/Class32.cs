using osu_common.Bancho;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace ns8
{
	// Token: 0x02000197 RID: 407
	internal sealed class Class32 : BinaryReader
	{
		// Token: 0x06000EA3 RID: 3747
		// RVA: 0x0000EF40 File Offset: 0x0000D140
		public Class32(Stream stream_0) : base(stream_0, Encoding.UTF8)
		{
		}

		// Token: 0x06000EA6 RID: 3750
		// RVA: 0x0004F830 File Offset: 0x0004DA30
		public char[] method_0()
		{
			int num = this.ReadInt32();
			if (num > 0)
			{
				return this.ReadChars(num);
			}
			if (num < 0)
			{
				return null;
			}
			return new char[0];
		}

		// Token: 0x06000EA7 RID: 3751
		// RVA: 0x0004F85C File Offset: 0x0004DA5C
		public DateTime method_1()
		{
			long num = this.ReadInt64();
			if (num < 0L)
			{
				throw new AbandonedMutexException("oops");
			}
			return new DateTime(num, DateTimeKind.Utc);
		}

		// Token: 0x06000EA8 RID: 3752
		// RVA: 0x0004F890 File Offset: 0x0004DA90
		public IList<T> method_2<T>() where T : bSerializable, new()
		{
			int num = this.ReadInt32();
			if (num < 0)
			{
				return null;
			}
			IList<T> list = new List<T>(num);
			Class32 class32_ = new Class32(this.BaseStream);
			for (int i = 0; i < num; i++)
			{
				T item = (default(T) == null) ? Activator.CreateInstance<T>() : default(T);
				item.ReadFromStream(class32_);
				list.Add(item);
			}
			return list;
		}

		// Token: 0x06000EA9 RID: 3753
		// RVA: 0x0004F904 File Offset: 0x0004DB04
		public IDictionary<T, U> method_3<T, U>()
		{
			int num = this.ReadInt32();
			if (num < 0)
			{
				return null;
			}
			IDictionary<T, U> dictionary = new Dictionary<T, U>();
			for (int i = 0; i < num; i++)
			{
				dictionary[(T)((object)this.method_4())] = (U)((object)this.method_4());
			}
			return dictionary;
		}

		// Token: 0x06000EAA RID: 3754
		// RVA: 0x0004F950 File Offset: 0x0004DB50
		public object method_4()
		{
			switch (this.ReadByte())
			{
			case 1:
				return this.ReadBoolean();
			case 2:
				return this.ReadByte();
			case 3:
				return this.ReadUInt16();
			case 4:
				return this.ReadUInt32();
			case 5:
				return this.ReadUInt64();
			case 6:
				return this.ReadSByte();
			case 7:
				return this.ReadInt16();
			case 8:
				return this.ReadInt32();
			case 9:
				return this.ReadInt64();
			case 10:
				return this.ReadChar();
			case 11:
				return base.ReadString();
			case 12:
				return this.ReadSingle();
			case 13:
				return this.ReadDouble();
			case 14:
				return this.ReadDecimal();
			case 15:
				return this.method_1();
			case 16:
				return this.ReadByteArray();
			case 17:
				return this.method_0();
			case 18:
				return Class27.Deserialize(this.BaseStream);
			default:
				return null;
			}
		}

		// Token: 0x06000EA5 RID: 3749
		// RVA: 0x0004F804 File Offset: 0x0004DA04
		public byte[] ReadByteArray()
		{
			int num = this.ReadInt32();
			if (num > 0)
			{
				return this.ReadBytes(num);
			}
			if (num < 0)
			{
				return null;
			}
			return new byte[0];
		}

		// Token: 0x06000EA4 RID: 3748
		// RVA: 0x0000EF4E File Offset: 0x0000D14E
		public override string ReadString()
		{
			if (this.ReadByte() == 0)
			{
				return null;
			}
			return base.ReadString();
		}
	}
}
