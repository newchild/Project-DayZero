using Microsoft.Xna.Framework.Graphics;
using ns26;
using ns29;
using ns30;
using ns64;
using ns80;
using ns90;
using osu.Graphics.OpenGl;
using osu_common.Helpers;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace ns77
{
	// Token: 0x02000572 RID: 1394
	internal sealed class Class737
	{
		// Token: 0x02000573 RID: 1395
		[CompilerGenerated]
		private sealed class Class738
		{
			// Token: 0x0400254F RID: 9551
			public bool bool_0;
		}

		// Token: 0x02000574 RID: 1396
		[CompilerGenerated]
		private sealed class Class739
		{
			// Token: 0x04002550 RID: 9552
			public string string_0;
		}

		// Token: 0x02000575 RID: 1397
		[CompilerGenerated]
		private sealed class Class740
		{
			// Token: 0x04002552 RID: 9554
			public Class737.Class738 class738_0;

			// Token: 0x04002551 RID: 9553
			public Class737.Class739 class739_0;

			// Token: 0x04002553 RID: 9555
			public Texture2D texture2D_0;

			// Token: 0x06002D04 RID: 11524
			// RVA: 0x00123F08 File Offset: 0x00122108
			public void method_0()
			{
				this.texture2D_0.Save(this.class739_0.string_0, Class341.class605_4);
				if (this.class738_0.bool_0)
				{
					if (Class341.class605_4 == 1)
					{
						Class737.smethod_2(this.class739_0.string_0, false);
					}
					else
					{
						string text = this.class739_0.string_0.Replace(".png", ".jpg");
						this.texture2D_0.Save(text, 1);
						Class737.smethod_2(text, true);
					}
				}
				this.texture2D_0.Dispose();
			}
		}

		// Token: 0x02000576 RID: 1398
		[CompilerGenerated]
		private sealed class Class741
		{
			// Token: 0x04002555 RID: 9557
			public bool bool_0;

			// Token: 0x04002554 RID: 9556
			public string string_0;

			// Token: 0x06002D06 RID: 11526
			// RVA: 0x00123F9C File Offset: 0x0012219C
			public void method_0()
			{
				try
				{
					if (Class737.int_0 > 0 && Class115.int_1 - Class737.int_0 < 30000)
					{
						Class723.smethod_4("You are trying to upload screenshots too fast!");
					}
					else
					{
						Class737.int_0 = Class115.int_1;
						Class723.smethod_5("Uploading screenshot...", Color.get_Yellow(), 3000, null);
						Class132 class = new Class132(string.Format("http://osu.ppy.sh/web/osu-screenshot.php?u={0}&p={1}&v=1", Class341.class605_20, Class341.class605_17), File.ReadAllBytes(this.string_0), Path.GetExtension(this.string_0).Trim(new char[]
						{
							'.'
						}), "ss");
						string text = class.method_7(false);
						if (text.Contains("http"))
						{
							Class115.smethod_90(text, null);
						}
						else
						{
							Class115.smethod_90("http://osu.ppy.sh/ss/" + text, null);
						}
						Class723.smethod_5("Screenshot has been uploaded!  Opening in browser window..." + this.string_0, Color.get_YellowGreen(), 6000, null);
					}
				}
				catch
				{
				}
				finally
				{
					try
					{
						if (this.bool_0)
						{
							File.Delete(this.string_0);
						}
					}
					catch
					{
					}
				}
			}
		}

		// Token: 0x0400254E RID: 9550
		private static int int_0;

		// Token: 0x06002CFE RID: 11518
		// RVA: 0x00123ABC File Offset: 0x00121CBC
		internal static byte[] smethod_0()
		{
			try
			{
				using (Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb))
				{
					using (Graphics graphics = Graphics.FromImage(bitmap))
					{
						graphics.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
						MemoryStream memoryStream = new MemoryStream();
						bitmap.Save(memoryStream, ImageFormat.Jpeg);
						return memoryStream.ToArray();
					}
				}
			}
			catch
			{
			}
			return null;
		}

		// Token: 0x06002CFF RID: 11519
		// RVA: 0x00123BA4 File Offset: 0x00121DA4
		internal static void smethod_1(bool bool_0)
		{
			Class737.Class738 class = new Class737.Class738();
			class.bool_0 = bool_0;
			try
			{
				Class737.Class739 class2 = new Class737.Class739();
				bool flag;
				if (flag = (Class331.enum100_0 == Enum100.const_1))
				{
					Class331.smethod_88();
				}
				Class331.smethod_59("shutter", 100, Enum112.flag_5);
				class2.string_0 = string.Empty;
				if (!Directory.Exists("Screenshots"))
				{
					Directory.CreateDirectory("Screenshots");
				}
				int num = Class341.class608_15;
				do
				{
					num++;
					class2.string_0 = string.Format("Screenshots/screenshot{0:000}", num);
				}
				while (File.Exists(class2.string_0 + ".jpg") || File.Exists(class2.string_0 + ".png"));
				Class737.Class739 expr_B5 = class2;
				expr_B5.string_0 = expr_B5.string_0 + "." + Class341.class605_4.ToString().ToLower();
				if (Class115.bool_26)
				{
					Class737.Class740 class3 = new Class737.Class740();
					class3.class739_0 = class2;
					class3.class738_0 = class;
					GraphicsDevice graphicsDevice = Class115.class125_0.GraphicsDevice;
					class3.texture2D_0 = new Texture2D(graphicsDevice, graphicsDevice.get_Viewport().get_Width(), graphicsDevice.get_Viewport().get_Height(), 1, 1, 2, 0);
					graphicsDevice.ResolveBackBuffer(class3.texture2D_0);
					Class115.smethod_87(new VoidDelegate(class3.method_0));
				}
				else
				{
					using (Bitmap bitmap = new Bitmap(Class115.int_22, Class115.int_23, PixelFormat.Format32bppArgb))
					{
						BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, bitmap.PixelFormat);
						Gl.glReadPixels(0, 0, Class115.int_22, Class115.int_23, 32993u, 5121u, bitmapData.Scan0);
						bitmap.UnlockBits(bitmapData);
						bitmap.RotateFlip(RotateFlipType.Rotate180FlipX);
						using (Bitmap bitmap2 = bitmap.Clone(new Rectangle(0, 0, bitmap.Width, bitmap.Height), PixelFormat.Format24bppRgb))
						{
							bitmap2.Save(class2.string_0, (Class341.class605_4 == 1) ? ImageFormat.Jpeg : ImageFormat.Png);
							if (class.bool_0)
							{
								if (Class341.class605_4 == 1)
								{
									Class737.smethod_2(class2.string_0, false);
								}
								else
								{
									string text = class2.string_0.Replace(".png", ".jpg");
									bitmap2.Save(text, ImageFormat.Jpeg);
									Class737.smethod_2(text, true);
								}
							}
						}
					}
				}
				if (flag)
				{
					Class331.smethod_88();
				}
				Class341.class608_15.Value = num;
				Class723.smethod_5("Saved screenshot to " + class2.string_0, Color.get_BlueViolet(), 6000, null);
			}
			catch
			{
				Class723.smethod_5("Screnshot capture failed!", Color.get_Red(), 3000, null);
			}
		}

		// Token: 0x06002D00 RID: 11520
		// RVA: 0x00123EC8 File Offset: 0x001220C8
		private static void smethod_2(string string_0, bool bool_0)
		{
			Class737.Class741 class = new Class737.Class741();
			class.string_0 = string_0;
			class.bool_0 = bool_0;
			if (class.string_0 == null)
			{
				return;
			}
			Class115.smethod_88(new VoidDelegate(class.method_0), false, ThreadPriority.Normal);
		}
	}
}
