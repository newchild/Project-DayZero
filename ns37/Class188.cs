using System;
using System.IO;

namespace ns37
{
	// Token: 0x0200024C RID: 588
	internal sealed class Class188
	{
		// Token: 0x06001474 RID: 5236
		// RVA: 0x000126B4 File Offset: 0x000108B4
		public static void smethod_0(Stream stream_0, byte[] byte_0)
		{
			Class188.smethod_1(stream_0, byte_0, 0, byte_0.Length);
		}

		// Token: 0x06001475 RID: 5237
		// RVA: 0x00068C60 File Offset: 0x00066E60
		public static void smethod_1(Stream stream_0, byte[] byte_0, int int_0, int int_1)
		{
			if (stream_0 == null)
			{
				throw new ArgumentNullException("stream");
			}
			if (byte_0 == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (int_0 >= 0 && int_0 <= byte_0.Length)
			{
				if (int_1 >= 0)
				{
					if (int_0 + int_1 <= byte_0.Length)
					{
						while (int_1 > 0)
						{
							int num = stream_0.Read(byte_0, int_0, int_1);
							if (num <= 0)
							{
								throw new EndOfStreamException();
							}
							int_0 += num;
							int_1 -= num;
						}
						return;
					}
				}
				throw new ArgumentOutOfRangeException("count");
			}
			throw new ArgumentOutOfRangeException("offset");
		}

		// Token: 0x06001476 RID: 5238
		// RVA: 0x00068CDC File Offset: 0x00066EDC
		public static void smethod_2(Stream stream_0, Stream stream_1, byte[] byte_0, Delegate21 delegate21_0, TimeSpan timeSpan_0, object object_0, string string_0)
		{
			if (stream_0 == null)
			{
				throw new ArgumentNullException("source");
			}
			if (stream_1 == null)
			{
				throw new ArgumentNullException("destination");
			}
			if (byte_0 == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (byte_0.Length < 128)
			{
				throw new ArgumentException("Buffer is too small", "buffer");
			}
			if (delegate21_0 == null)
			{
				throw new ArgumentNullException("progressHandler");
			}
			bool flag = true;
			DateTime now = DateTime.Now;
			long num = 0L;
			long num2 = 0L;
			if (stream_0.CanSeek)
			{
				num2 = stream_0.Length - stream_0.Position;
			}
			EventArgs9 eventArgs = new EventArgs9(string_0, num, num2);
			delegate21_0(object_0, eventArgs);
			bool flag2 = false;
			while (flag)
			{
				int num3 = stream_0.Read(byte_0, 0, byte_0.Length);
				if (num3 > 0)
				{
					num += (long)num3;
					stream_1.Write(byte_0, 0, num3);
				}
				else
				{
					stream_1.Flush();
					flag = false;
				}
				if (DateTime.Now - now > timeSpan_0)
				{
					flag2 = (num == num2);
					now = DateTime.Now;
					eventArgs = new EventArgs9(string_0, num, num2);
					delegate21_0(object_0, eventArgs);
					flag = eventArgs.method_0();
				}
			}
			if (!flag2)
			{
				eventArgs = new EventArgs9(string_0, num, num2);
				delegate21_0(object_0, eventArgs);
			}
		}

		// Token: 0x06001477 RID: 5239
		// RVA: 0x00068E0C File Offset: 0x0006700C
		public static void smethod_3(Stream stream_0, Stream stream_1, byte[] byte_0)
		{
			if (stream_0 == null)
			{
				throw new ArgumentNullException("source");
			}
			if (stream_1 == null)
			{
				throw new ArgumentNullException("destination");
			}
			if (byte_0 == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (byte_0.Length < 128)
			{
				throw new ArgumentException("Buffer is too small", "buffer");
			}
			bool flag = true;
			while (flag)
			{
				int num = stream_0.Read(byte_0, 0, byte_0.Length);
				if (num > 0)
				{
					stream_1.Write(byte_0, 0, num);
				}
				else
				{
					stream_1.Flush();
					flag = false;
				}
			}
		}
	}
}
