using Microsoft.Xna.Framework.Graphics;
using ns29;
using ns80;
using ns91;
using osu;
using osu_gameplay;
using osu_ui;
using osudata;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;

namespace ns77
{
	// Token: 0x02000569 RID: 1385
	internal sealed class Class731 : IDisposable
	{
		// Token: 0x040024FB RID: 9467
		public bool bool_0;

		// Token: 0x040024FE RID: 9470
		public bool bool_1 = true;

		// Token: 0x04002500 RID: 9472
		internal bool bool_2;

		// Token: 0x04002503 RID: 9475
		internal bool bool_3;

		// Token: 0x04002505 RID: 9477
		public bool bool_4 = true;

		// Token: 0x04002502 RID: 9474
		internal Class748 class748_0;

		// Token: 0x04002501 RID: 9473
		public Enum112 enum112_0;

		// Token: 0x040024FC RID: 9468
		internal int int_0;

		// Token: 0x040024FD RID: 9469
		internal int int_1;

		// Token: 0x040024FF RID: 9471
		internal int int_2;

		// Token: 0x04002506 RID: 9478
		public int int_3 = 1;

		// Token: 0x04002507 RID: 9479
		private static Stack<byte[]> stack_0 = new Stack<byte[]>();

		// Token: 0x040024FA RID: 9466
		public string string_0;

		// Token: 0x04002504 RID: 9476
		internal Texture2D texture2D_0;

		// Token: 0x06002CC8 RID: 11464
		// RVA: 0x00021F07 File Offset: 0x00020107
		private Class731()
		{
		}

		// Token: 0x06002CC5 RID: 11461
		// RVA: 0x00021E91 File Offset: 0x00020091
		public Class731(Texture2D texture2D_1)
		{
			this.int_0 = texture2D_1.get_Width();
			this.int_1 = texture2D_1.get_Height();
			this.method_3(texture2D_1);
		}

		// Token: 0x06002CC7 RID: 11463
		// RVA: 0x00021ECD File Offset: 0x000200CD
		public Class731(Texture2D texture2D_1, Class748 class748_1, int int_4, int int_5)
		{
			this.method_3(texture2D_1);
			this.class748_0 = class748_1;
			this.int_0 = int_4;
			this.int_1 = int_5;
		}

		// Token: 0x06002CCD RID: 11469
		// RVA: 0x00021F50 File Offset: 0x00020150
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06002CCE RID: 11470
		// RVA: 0x00122200 File Offset: 0x00120400
		private void Dispose(bool bool_5)
		{
			if (this.bool_2)
			{
				return;
			}
			this.bool_2 = true;
			if (this.method_2() != null)
			{
				this.method_2().Dispose();
				this.method_3(null);
			}
			if (this.class748_0 != null)
			{
				this.class748_0.Dispose();
				this.class748_0 = null;
			}
		}

		// Token: 0x06002CC6 RID: 11462
		// RVA: 0x0012215C File Offset: 0x0012035C
		~Class731()
		{
			if (Class115.osuModes_1 != OsuModes.Exit)
			{
				if (Class115.osuModes_1 != OsuModes.Update)
				{
					this.Dispose(false);
				}
			}
		}

		// Token: 0x06002CC3 RID: 11459
		// RVA: 0x00021E73 File Offset: 0x00020073
		public int method_0()
		{
			return this.int_0 / this.int_3;
		}

		// Token: 0x06002CC4 RID: 11460
		// RVA: 0x00021E82 File Offset: 0x00020082
		public int method_1()
		{
			return this.int_1 / this.int_3;
		}

		// Token: 0x06002CC9 RID: 11465
		// RVA: 0x00021F24 File Offset: 0x00020124
		internal Texture2D method_2()
		{
			return this.texture2D_0;
		}

		// Token: 0x06002CCA RID: 11466
		// RVA: 0x001221A0 File Offset: 0x001203A0
		internal void method_3(Texture2D texture2D_1)
		{
			if (this.texture2D_0 != null)
			{
				this.texture2D_0.remove_Disposing(new EventHandler(this.texture2D_0_Disposing));
			}
			this.texture2D_0 = texture2D_1;
			if (this.texture2D_0 != null)
			{
				this.texture2D_0.add_Disposing(new EventHandler(this.texture2D_0_Disposing));
			}
		}

		// Token: 0x06002CCC RID: 11468
		// RVA: 0x00021F35 File Offset: 0x00020135
		public bool method_4()
		{
			if (this.bool_3)
			{
				this.int_2 = Class115.int_1;
			}
			return this.bool_2;
		}

		// Token: 0x06002CCF RID: 11471
		// RVA: 0x00021F5F File Offset: 0x0002015F
		public void method_5(byte[] byte_0)
		{
			this.method_6(byte_0, 0, 0);
		}

		// Token: 0x06002CD0 RID: 11472
		// RVA: 0x00122258 File Offset: 0x00120458
		public void method_6(byte[] byte_0, int int_4, int int_5)
		{
			if (Class115.bool_26 && this.method_2() != null)
			{
				this.method_2().SetData<byte>(int_4, null, byte_0, 0, byte_0.Length, 12288);
			}
			if (Class115.bool_27 && this.class748_0 != null)
			{
				if (int_5 != 0)
				{
					this.class748_0.method_3(byte_0, int_4, int_5);
					return;
				}
				this.class748_0.method_3(byte_0, int_4, 32993);
			}
		}

		// Token: 0x06002CD9 RID: 11481
		// RVA: 0x001227A4 File Offset: 0x001209A4
		public void method_7(IntPtr intptr_0, int int_4, int int_5, string string_1)
		{
			this.int_0 = int_4;
			this.int_1 = int_5;
			try
			{
				if (Class115.bool_26)
				{
					int num = int_4 * int_5 * 4;
					byte[] array = null;
					lock (Class731.stack_0)
					{
						if (Class731.stack_0.Count > 0)
						{
							array = Class731.stack_0.Pop();
						}
					}
					if (array == null || array.Length < num)
					{
						array = new byte[num];
					}
					Marshal.Copy(intptr_0, array, 0, num);
					this.method_2().SetData<byte>(array, 0, num, 12288);
					lock (Class731.stack_0)
					{
						Class731.stack_0.Push(array);
					}
				}
				if (Class115.bool_27)
				{
					this.class748_0.method_4(intptr_0, 0, 0);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06002CD1 RID: 11473
		// RVA: 0x001222CC File Offset: 0x001204CC
		public static Class731 smethod_0(string string_1)
		{
			bool flag;
			if (flag = Class115.smethod_93())
			{
				string_1 += "@2x";
			}
			using (Bitmap bitmap = ResourcesStore.get_ResourceManager().GetObject(string_1) as Bitmap)
			{
				if (bitmap != null)
				{
					Class731 class = Class731.smethod_5(bitmap);
					if (flag)
					{
						class.int_3 = 2;
					}
					Class731 result = class;
					return result;
				}
			}
			using (Bitmap bitmap2 = ResourcesStore.get_ResourceManager().GetObject(string_1) as Bitmap)
			{
				if (bitmap2 != null)
				{
					Class731 class2 = Class731.smethod_5(bitmap2);
					if (flag)
					{
						class2.int_3 = 2;
					}
					Class731 result = class2;
					return result;
				}
			}
			return null;
		}

		// Token: 0x06002CD2 RID: 11474
		// RVA: 0x00122380 File Offset: 0x00120580
		public static Class731 smethod_1(string string_1)
		{
			if (Class115.bool_32)
			{
				Class731 class = Class731.smethod_0(string_1);
				if (class != null)
				{
					class.string_0 = string_1;
					class.bool_0 = true;
					return class;
				}
			}
			byte[] array = ResourcesStore.get_ResourceManager().GetObject(string_1) as byte[];
			if (array == null)
			{
				return null;
			}
			Class731 class2 = new Class731();
			class2.string_0 = string_1;
			class2.bool_0 = true;
			using (Stream stream = new MemoryStream(array))
			{
				using (Class732 class3 = new Class732(stream))
				{
					class3.ReadBytes(10);
					int num = class3.method_0();
					for (int i = 0; i < num; i++)
					{
						class3.ReadString();
						class3.ReadInt32();
					}
					class3.method_0();
					class3.method_0();
					SurfaceFormat surfaceFormat = class3.ReadInt32();
					class2.int_0 = class3.ReadInt32();
					class2.int_1 = class3.ReadInt32();
					int num2 = class3.ReadInt32();
					if (Class115.bool_26)
					{
						class2.method_3(new Texture2D(Class115.class125_0.GraphicsDevice, class2.method_0(), class2.method_1(), num2, 0, surfaceFormat, 1));
					}
					if (Class115.bool_27)
					{
						class2.class748_0 = new Class748(class2.method_0(), class2.method_1());
					}
					for (int j = 0; j < num2; j++)
					{
						int count = class3.ReadInt32();
						byte[] byte_ = class3.ReadBytes(count);
						class2.method_6(byte_, j, 0);
					}
				}
			}
			return class2;
		}

		// Token: 0x06002CD3 RID: 11475
		// RVA: 0x00122524 File Offset: 0x00120724
		public static Class731 smethod_2(string string_1)
		{
			if (!File.Exists(string_1))
			{
				return null;
			}
			Class731 result;
			try
			{
				using (Stream stream = new FileStream(string_1, FileMode.Open, FileAccess.Read, FileShare.Read))
				{
					result = Class731.smethod_3(stream, string_1);
				}
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06002CD4 RID: 11476
		// RVA: 0x00021F6A File Offset: 0x0002016A
		public static Class731 smethod_3(Stream stream_0, string string_1)
		{
			return Class731.smethod_4(stream_0, string_1, false);
		}

		// Token: 0x06002CD5 RID: 11477
		// RVA: 0x0012257C File Offset: 0x0012077C
		public static Class731 smethod_4(Stream stream_0, string string_1, bool bool_5)
		{
			if (stream_0 != null)
			{
				if (stream_0.Length != 0L)
				{
					Class731 result;
					try
					{
						using (Bitmap bitmap = (Bitmap)Image.FromStream(stream_0, false, false))
						{
							BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
							if (bool_5)
							{
								byte[] array = new byte[bitmap.Width * bitmap.Height * 4];
								Marshal.Copy(bitmapData.Scan0, array, 0, array.Length);
								File.WriteAllBytes(string_1, array);
							}
							Class731 class = Class731.smethod_7(bitmapData.Scan0, bitmap.Width, bitmap.Height, false, null);
							class.string_0 = string_1;
							bitmap.UnlockBits(bitmapData);
							result = class;
						}
					}
					catch
					{
						result = null;
					}
					return result;
				}
			}
			return null;
		}

		// Token: 0x06002CD6 RID: 11478
		// RVA: 0x00122660 File Offset: 0x00120860
		public static Class731 smethod_5(Bitmap bitmap_0)
		{
			if (bitmap_0 == null)
			{
				return null;
			}
			Class731 result;
			try
			{
				BitmapData bitmapData = bitmap_0.LockBits(new Rectangle(0, 0, bitmap_0.Width, bitmap_0.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
				Class731 class = Class731.smethod_7(bitmapData.Scan0, bitmap_0.Width, bitmap_0.Height, false, null);
				bitmap_0.UnlockBits(bitmapData);
				result = class;
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06002CD7 RID: 11479
		// RVA: 0x001226D0 File Offset: 0x001208D0
		public static Class731 smethod_6(byte[] byte_0)
		{
			Class731 result;
			using (MemoryStream memoryStream = new MemoryStream(byte_0))
			{
				result = Class731.smethod_3(memoryStream, "");
			}
			return result;
		}

		// Token: 0x06002CD8 RID: 11480
		// RVA: 0x00122710 File Offset: 0x00120910
		public static Class731 smethod_7(IntPtr intptr_0, int int_4, int int_5, bool bool_5, string string_1)
		{
			Class731 class = new Class731();
			class.int_0 = int_4;
			class.int_1 = int_5;
			try
			{
				if (Class115.bool_26)
				{
					class.method_3(new Texture2D(Class115.class125_0.GraphicsDevice, class.method_0(), class.method_1(), 1, 0, 1, bool_5 ? 0 : 1));
				}
				else if (Class115.bool_27)
				{
					class.class748_0 = new Class748(class.method_0(), class.method_1());
				}
				class.method_7(intptr_0, int_4, int_5, string_1);
			}
			catch
			{
			}
			return class;
		}

		// Token: 0x06002CDA RID: 11482
		// RVA: 0x0012288C File Offset: 0x00120A8C
		public static Class731 smethod_8(byte[] byte_0, int int_4, int int_5, bool bool_5)
		{
			Class731 class = new Class731();
			class.int_0 = int_4;
			class.int_1 = int_5;
			try
			{
				if (Class115.bool_26)
				{
					class.method_3(new Texture2D(Class115.class125_0.GraphicsDevice, class.method_0(), class.method_1(), 1, 0, 1, bool_5 ? 0 : 1));
				}
				if (Class115.bool_27)
				{
					class.class748_0 = new Class748(class.method_0(), class.method_1());
				}
				class.method_5(byte_0);
			}
			catch
			{
			}
			return class;
		}

		// Token: 0x06002CCB RID: 11467
		// RVA: 0x00021F2C File Offset: 0x0002012C
		private void texture2D_0_Disposing(object sender, EventArgs e)
		{
			this.bool_2 = true;
		}
	}
}
