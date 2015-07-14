using osu_common.Bancho;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace ns8
{
	// Token: 0x02000196 RID: 406
	internal sealed class Class31 : BinaryWriter
	{
		// Token: 0x06000E98 RID: 3736
		// RVA: 0x0000EEFA File Offset: 0x0000D0FA
		public Class31(Stream stream_0) : base(stream_0, Encoding.UTF8)
		{
		}

		// Token: 0x06000E9F RID: 3743
		// RVA: 0x0004F500 File Offset: 0x0004D700
		public void method_0(object object_0)
		{
			if (object_0 == null)
			{
				this.Write(0);
				return;
			}
			string name;
			switch (name = object_0.GetType().Name)
			{
			case "Boolean":
				this.Write(1);
				this.Write((bool)object_0);
				return;
			case "Byte":
				this.Write(2);
				this.Write((byte)object_0);
				return;
			case "UInt16":
				this.Write(3);
				this.Write((ushort)object_0);
				return;
			case "UInt32":
				this.Write(4);
				this.Write((uint)object_0);
				return;
			case "UInt64":
				this.Write(5);
				this.Write((ulong)object_0);
				return;
			case "SByte":
				this.Write(6);
				this.Write((sbyte)object_0);
				return;
			case "Int16":
				this.Write(7);
				this.Write((short)object_0);
				return;
			case "Int32":
				this.Write(8);
				this.Write((int)object_0);
				return;
			case "Int64":
				this.Write(9);
				this.Write((long)object_0);
				return;
			case "Char":
				this.Write(10);
				base.Write((char)object_0);
				return;
			case "String":
				this.Write(11);
				base.Write((string)object_0);
				return;
			case "Single":
				this.Write(12);
				this.Write((float)object_0);
				return;
			case "Double":
				this.Write(13);
				this.Write((double)object_0);
				return;
			case "Decimal":
				this.Write(14);
				this.Write((decimal)object_0);
				return;
			case "DateTime":
				this.Write(15);
				this.Write((DateTime)object_0);
				return;
			case "Byte[]":
				this.Write(16);
				base.Write((byte[])object_0);
				return;
			case "Char[]":
				this.Write(17);
				base.Write((char[])object_0);
				return;
			}
			this.Write(18);
			new BinaryFormatter
			{
				AssemblyFormat = FormatterAssemblyStyle.Simple,
				TypeFormat = FormatterTypeStyle.TypesWhenNeeded
			}.Serialize(this.BaseStream, object_0);
		}

		// Token: 0x06000EA0 RID: 3744
		// RVA: 0x0000EF24 File Offset: 0x0000D124
		public void method_1(byte[] byte_0)
		{
			base.Write(byte_0);
		}

		// Token: 0x06000EA1 RID: 3745
		// RVA: 0x0004F3B4 File Offset: 0x0004D5B4
		public void method_2(byte[] byte_0)
		{
			if (byte_0 == null)
			{
				this.Write(-1);
				return;
			}
			int num = byte_0.Length;
			this.Write(num);
			if (num > 0)
			{
				base.Write(byte_0);
			}
		}

		// Token: 0x06000EA2 RID: 3746
		// RVA: 0x0000EF2D File Offset: 0x0000D12D
		internal void method_3(string string_0)
		{
			this.method_1(Encoding.UTF8.GetBytes(string_0));
		}

		// Token: 0x06000E99 RID: 3737
		// RVA: 0x0000EF08 File Offset: 0x0000D108
		public override void Write(string value)
		{
			if (value == null)
			{
				this.Write(0);
				return;
			}
			this.Write(11);
			base.Write(value);
		}

		// Token: 0x06000E9A RID: 3738
		// RVA: 0x0004F3B4 File Offset: 0x0004D5B4
		public override void Write(byte[] buffer)
		{
			if (buffer == null)
			{
				this.Write(-1);
				return;
			}
			int num = buffer.Length;
			this.Write(num);
			if (num > 0)
			{
				base.Write(buffer);
			}
		}

		// Token: 0x06000E9B RID: 3739
		// RVA: 0x0004F3E4 File Offset: 0x0004D5E4
		public override void Write(char[] chars)
		{
			if (chars == null)
			{
				this.Write(-1);
				return;
			}
			int num = chars.Length;
			this.Write(num);
			if (num > 0)
			{
				base.Write(chars);
			}
		}

		// Token: 0x06000E9C RID: 3740
		// RVA: 0x0004F414 File Offset: 0x0004D614
		public void Write(DateTime dateTime_0)
		{
			this.Write(dateTime_0.ToUniversalTime().Ticks);
		}

		// Token: 0x06000E9D RID: 3741
		// RVA: 0x0004F438 File Offset: 0x0004D638
		public void Write<T>(List<T> list_0) where T : bSerializable
		{
			if (list_0 == null)
			{
				this.Write(-1);
				return;
			}
			int count = list_0.Count;
			this.Write(count);
			for (int i = 0; i < count; i++)
			{
				T t = list_0[i];
				t.WriteToStream(this);
			}
		}

		// Token: 0x06000E9E RID: 3742
		// RVA: 0x0004F480 File Offset: 0x0004D680
		public void Write<T, U>(IDictionary<T, U> idictionary_0)
		{
			if (idictionary_0 == null)
			{
				this.Write(-1);
				return;
			}
			this.Write(idictionary_0.Count);
			foreach (KeyValuePair<T, U> current in idictionary_0)
			{
				this.method_0(current.Key);
				this.method_0(current.Value);
			}
		}
	}
}
