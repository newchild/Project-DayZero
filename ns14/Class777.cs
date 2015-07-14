using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace ns14
{
	// Token: 0x020005B1 RID: 1457
	internal static class Class777
	{
		// Token: 0x06002E8A RID: 11914
		// RVA: 0x0012EA14 File Offset: 0x0012CC14
		private static ImageCodecInfo smethod_0(string string_0)
		{
			ImageCodecInfo[] imageEncoders = ImageCodecInfo.GetImageEncoders();
			for (int i = 0; i < imageEncoders.Length; i++)
			{
				if (imageEncoders[i].MimeType == string_0)
				{
					return imageEncoders[i];
				}
			}
			return null;
		}

		// Token: 0x06002E8B RID: 11915
		// RVA: 0x0012EA4C File Offset: 0x0012CC4C
		internal static string smethod_1(string string_0, int int_0, int int_1)
		{
			string a = Path.GetExtension(string_0).Trim(new char[]
			{
				'.'
			}).ToLower();
			if (!(a == "jpg") && !(a == "png"))
			{
				return string_0;
			}
			ImageCodecInfo encoder = Class777.smethod_0("image/jpeg");
			EncoderParameters encoderParameters = new EncoderParameters(1);
			encoderParameters.Param[0] = new EncoderParameter(Encoder.Quality, 90L);
			string result;
			using (Image image = Image.FromFile(string_0))
			{
				if (image.Width > int_0 || image.Height > int_1)
				{
					float num = (image.Height > image.Width) ? ((float)int_0 / (float)image.Width) : ((float)int_1 / (float)image.Height);
					int width = (int)((float)image.Width * num);
					int height = (int)((float)image.Height * num);
					using (Bitmap bitmap = new Bitmap(width, height))
					{
						using (Graphics graphics = Graphics.FromImage(bitmap))
						{
							graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
							graphics.SmoothingMode = SmoothingMode.HighQuality;
							graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
							graphics.CompositingQuality = CompositingQuality.HighQuality;
							graphics.DrawImage(image, 0, 0, width, height);
							string text = string.Format("{0}/{1}.jpg", Path.GetDirectoryName(string_0), Path.GetFileNameWithoutExtension(string_0));
							image.Dispose();
							File.Delete(string_0);
							bitmap.Save(text, encoder, encoderParameters);
							result = text;
							return result;
						}
					}
				}
				result = string_0;
			}
			return result;
		}
	}
}
