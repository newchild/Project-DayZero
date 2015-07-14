using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns18;
using ns24;
using ns26;
using ns27;
using ns29;
using ns30;
using ns64;
using ns74;
using ns77;
using ns79;
using ns8;
using ns80;
using ns90;
using osu.Graphics.Sprites;
using osu_common.Helpers;
using osu_common.Libraries.NetLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace ns25
{
	// Token: 0x0200064F RID: 1615
	internal sealed class Class854 : IComparable<Class854>, IComparer<Class854>
	{
		// Token: 0x04002D5F RID: 11615
		private bool bool_0;

		// Token: 0x04002D52 RID: 11602
		protected Class531 class531_0;

		// Token: 0x04002D53 RID: 11603
		protected Class531 class531_1;

		// Token: 0x04002D54 RID: 11604
		protected Class531 class531_2;

		// Token: 0x04002D55 RID: 11605
		protected Class533 class533_0;

		// Token: 0x04002D56 RID: 11606
		protected Class533 class533_1;

		// Token: 0x04002D5B RID: 11611
		internal Class690 class690_0;

		// Token: 0x04002D5C RID: 11612
		internal Delegate48 delegate48_0 = delegate
		{
		};

		// Token: 0x04002D62 RID: 11618
		[CompilerGenerated]
		private static Delegate48 delegate48_1;

		// Token: 0x04002D5D RID: 11613
		internal Delegate49 delegate49_0;

		// Token: 0x04002D63 RID: 11619
		[CompilerGenerated]
		private static Delegate49 delegate49_1;

		// Token: 0x04002D5E RID: 11614
		internal Delegate50 delegate50_0;

		// Token: 0x04002D64 RID: 11620
		[CompilerGenerated]
		private static Delegate50 delegate50_1;

		// Token: 0x04002D58 RID: 11608
		internal Enum104 enum104_0;

		// Token: 0x04002D65 RID: 11621
		[CompilerGenerated]
		private static EventHandler eventHandler_0;

		// Token: 0x04002D51 RID: 11601
		protected FileNetRequest fileNetRequest_0;

		// Token: 0x04002D5A RID: 11610
		protected int int_0;

		// Token: 0x04002D57 RID: 11607
		internal List<Class531> list_0;

		// Token: 0x04002D59 RID: 11609
		protected string string_0;

		// Token: 0x04002D60 RID: 11616
		[CompilerGenerated]
		private string string_1;

		// Token: 0x04002D61 RID: 11617
		[CompilerGenerated]
		private string string_2;

		// Token: 0x060031AF RID: 12719
		// RVA: 0x00024AD6 File Offset: 0x00022CD6
		public Class854(Class690 class690_1, bool bool_1) : this(class690_1.int_0, class690_1.method_0(), class690_1.string_2, bool_1, bool_1 ? class690_1.int_3 : class690_1.int_4)
		{
			this.class690_0 = class690_1;
		}

		// Token: 0x060031B0 RID: 12720
		// RVA: 0x00145408 File Offset: 0x00143608
		public Class854(int int_1, string string_3, string string_4, bool bool_1, int int_2)
		{
			if (Class854.delegate49_1 == null)
			{
				Class854.delegate49_1 = new Delegate49(Class854.smethod_0);
			}
			this.delegate49_0 = Class854.delegate49_1;
			if (Class854.delegate50_1 == null)
			{
				Class854.delegate50_1 = new Delegate50(Class854.smethod_1);
			}
			this.delegate50_0 = Class854.delegate50_1;
			base..ctor();
			this.method_1(string_3);
			this.int_0 = int_2;
			this.method_3(string_4);
			if (!Directory.Exists("Downloads"))
			{
				Directory.CreateDirectory("Downloads");
			}
			this.string_0 = Path.GetFileName(string_3);
			string path = Path.Combine("Downloads", this.string_0);
			try
			{
				File.Delete(path);
			}
			catch
			{
				return;
			}
			this.fileNetRequest_0 = new FileNetRequest(path, string.Format("http://osu.ppy.sh/d/{0}{1}?u={2}&h={3}", new object[]
			{
				int_1,
				bool_1 ? "n" : "",
				Class341.class605_20,
				Class341.class605_17
			}));
			this.fileNetRequest_0.method_0(new Class129.Delegate5(this.method_7));
			this.fileNetRequest_0.method_2(new FileNetRequest.Delegate10(this.method_6));
			this.fileNetRequest_0.method_1(new Class129.Delegate6(this.method_5));
		}

		// Token: 0x060031B6 RID: 12726
		// RVA: 0x00145C04 File Offset: 0x00143E04
		internal virtual void Abort(bool bool_1)
		{
			EventHandler eventHandler = null;
			if (bool_1)
			{
				Class89 class = new Class89("Would you like to cancel the download?", true);
				Class89 arg_30_0 = class;
				string arg_30_1 = "Yes, cancel this download.";
				Color arg_30_2 = Color.get_OrangeRed();
				if (eventHandler == null)
				{
					eventHandler = new EventHandler(this.method_11);
				}
				arg_30_0.method_3(arg_30_1, arg_30_2, eventHandler, true, false, true);
				Class89 arg_60_0 = class;
				string arg_60_1 = "No, keep downloading.";
				Color arg_60_2 = Color.get_YellowGreen();
				if (Class854.eventHandler_0 == null)
				{
					Class854.eventHandler_0 = new EventHandler(Class854.smethod_2);
				}
				arg_60_0.method_3(arg_60_1, arg_60_2, Class854.eventHandler_0, true, false, true);
				Class115.smethod_37(class);
				return;
			}
			if (this.fileNetRequest_0 != null)
			{
				this.fileNetRequest_0.Abort();
			}
			this.enum104_0 = Enum104.const_3;
		}

		// Token: 0x060031B1 RID: 12721
		// RVA: 0x00024B09 File Offset: 0x00022D09
		public int Compare(Class854 x, Class854 y)
		{
			return x.method_0().CompareTo(y.method_0());
		}

		// Token: 0x060031B7 RID: 12727
		// RVA: 0x00024B29 File Offset: 0x00022D29
		public int CompareTo(Class854 obj)
		{
			return this.method_0().CompareTo(obj.method_0());
		}

		// Token: 0x060031AB RID: 12715
		// RVA: 0x00024AB4 File Offset: 0x00022CB4
		[CompilerGenerated]
		public string method_0()
		{
			return this.string_1;
		}

		// Token: 0x060031AC RID: 12716
		// RVA: 0x00024ABC File Offset: 0x00022CBC
		[CompilerGenerated]
		protected void method_1(string string_3)
		{
			this.string_1 = string_3;
		}

		// Token: 0x060031BD RID: 12733
		// RVA: 0x00024B45 File Offset: 0x00022D45
		[CompilerGenerated]
		private void method_10()
		{
			Class115.smethod_90("http://osu.ppy.sh/d/" + this.class690_0.int_0, null);
		}

		// Token: 0x060031BE RID: 12734
		// RVA: 0x00024B67 File Offset: 0x00022D67
		[CompilerGenerated]
		private void method_11(object sender, EventArgs e)
		{
			this.Abort(false);
		}

		// Token: 0x060031AD RID: 12717
		// RVA: 0x00024AC5 File Offset: 0x00022CC5
		[CompilerGenerated]
		public string method_2()
		{
			return this.string_2;
		}

		// Token: 0x060031AE RID: 12718
		// RVA: 0x00024ACD File Offset: 0x00022CCD
		[CompilerGenerated]
		protected void method_3(string string_3)
		{
			this.string_2 = string_3;
		}

		// Token: 0x060031B2 RID: 12722
		// RVA: 0x0014557C File Offset: 0x0014377C
		internal bool method_4(Vector2 vector2_0)
		{
			EventHandler eventHandler = null;
			if (this.list_0 == null)
			{
				this.list_0 = new List<Class531>();
				this.class531_0 = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(vector2_0.X, vector2_0.Y), 0.79f, true, new Color(40, 40, 40, 150), null);
				this.class531_0.float_2 = 1.6f;
				this.class531_0.bool_1 = true;
				this.class531_0.class746_1 = new Class746(this.class531_0.color_0, new Color(60, 60, 60, 180), 0, 10);
				Class530 arg_B6_0 = this.class531_0;
				if (eventHandler == null)
				{
					eventHandler = new EventHandler(this.method_9);
				}
				arg_B6_0.method_2(eventHandler);
				this.class531_0.vector2_2 = new Vector2(120f, 18f);
				this.class531_2 = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(vector2_0.X + 5f, vector2_0.Y + 10f), 0.8f, true, new Color(0, 0, 0, 150), null);
				this.class531_2.float_2 = 1.6f;
				this.class531_2.class746_1 = new Class746(TransformationType.Fade, 0.4f, 0.7f, 0, 600, Enum70.const_0);
				this.class531_2.vector2_2 = new Vector2(110f, 5f);
				this.class531_1 = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(vector2_0.X + 5f, vector2_0.Y + 10f), 0.81f, true, new Color(0, 78, 192, 255), null);
				this.class531_1.float_2 = 1.6f;
				this.class531_1.class746_1 = new Class746(TransformationType.Fade, 0.4f, 0.7f, 0, 600, Enum70.const_0);
				this.class531_1.vector2_2 = new Vector2(0f, 5f);
				this.class533_0 = new Class533((this.enum104_0 == Enum104.const_0) ? "waiting..." : "initialising", 9f, new Vector2(vector2_0.X + 5f, vector2_0.Y + 8f), 0.82f, true, Color.get_White());
				this.class533_1 = new Class533(this.method_2(), 9f, new Vector2(vector2_0.X + 5f, vector2_0.Y), 0.81f, true, Color.get_White());
				this.list_0.Add(this.class531_0);
				this.list_0.Add(this.class531_2);
				this.list_0.Add(this.class531_1);
				this.list_0.Add(this.class533_0);
				this.list_0.Add(this.class533_1);
				Class112.bool_2 = true;
				return true;
			}
			Vector2 vector2_ = this.list_0[0].vector2_0;
			foreach (Class531 current in this.list_0)
			{
				Vector2 vector = vector2_0 + (current.vector2_0 - vector2_);
				if (!(vector == current.vector2_1) || current.class26_0.Count != 0)
				{
					current.method_19(vector, 500, Enum70.const_1);
					current.vector2_0 = vector;
				}
			}
			return false;
		}

		// Token: 0x060031B3 RID: 12723
		// RVA: 0x00145904 File Offset: 0x00143B04
		private void method_5(object object_0, long long_0, long long_1)
		{
			if (this.enum104_0 == Enum104.const_3)
			{
				return;
			}
			if (this.enum104_0 == Enum104.const_1)
			{
				this.enum104_0 = Enum104.const_2;
			}
			long num = Math.Max((long)this.int_0, long_1);
			double num2 = (num == 0L) ? 0.0 : ((double)long_0 / (double)num);
			this.class533_0.Text = string.Format("{0:0.0%}", num2);
			if (this.list_0 != null)
			{
				this.class531_1.vector2_2.X = (float)num2 * 110f;
			}
			this.class533_0.vector2_1 = new Vector2(this.class531_1.vector2_0.X + Math.Min(this.class531_1.vector2_2.X, 88f), this.class531_1.vector2_1.Y - 2f);
			this.class533_0.vector2_0 = this.class533_0.vector2_1;
			this.delegate49_0(num2);
		}

		// Token: 0x060031B4 RID: 12724
		// RVA: 0x00145A04 File Offset: 0x00143C04
		private void method_6(string string_3, Exception exception_0)
		{
			VoidDelegate voidDelegate = null;
			try
			{
				File.Delete(Class466.smethod_17() + this.string_0);
			}
			catch
			{
				Class723.smethod_4("osu!Direct download failed because the file already exists in your songs folder and is not writeable.");
			}
			bool flag = exception_0 == null;
			try
			{
				if (flag && File.Exists(string_3))
				{
					if (!(flag &= (new FileInfo(string_3).Length > 100L)))
					{
						string text = File.ReadAllText(string_3);
						File.Delete(string_3);
						if (text.StartsWith("ERROR:"))
						{
							string a;
							if ((a = text.Replace("ERROR:", "").Trim()) != null && a == "DOWNLOAD_NOT_AVAILABLE")
							{
								string arg_C3_0 = Class41.GetString(OsuString.OsuDirect_DownloadNotAvailable);
								Color arg_C3_1 = Color.get_DarkRed();
								int arg_C3_2 = 4000;
								if (voidDelegate == null)
								{
									voidDelegate = new VoidDelegate(this.method_10);
								}
								Class723.smethod_5(arg_C3_0, arg_C3_1, arg_C3_2, voidDelegate);
							}
							return;
						}
					}
					string text2 = Path.GetExtension(this.method_0()).ToLower();
					string fullPath = Path.GetFullPath(Class466.smethod_17());
					int num = fullPath.Length + this.method_0().Length - 248;
					if (num > 0)
					{
						if (num < this.method_0().Length - (text2.Length + 1) - 1)
						{
							this.method_1(this.method_0().Substring(0, this.method_0().Length - num - (text2.Length + 1)) + text2);
						}
						else
						{
							flag = false;
						}
					}
					if (flag)
					{
						if (!Class62.bool_12 || Class341.class606_50.Value)
						{
							Class331.smethod_59("match-confirm", 100, Enum112.flag_5);
						}
						File.Move(string_3, Class466.smethod_17() + this.string_0);
					}
					else
					{
						Class723.smethod_4("osu!direct download failed. Please check your connection and try again!");
						File.Delete(string_3);
					}
				}
			}
			finally
			{
				this.enum104_0 = Enum104.const_3;
				Class112.bool_2 = true;
				this.delegate50_0(flag);
			}
		}

		// Token: 0x060031B5 RID: 12725
		// RVA: 0x00024B1C File Offset: 0x00022D1C
		private void method_7()
		{
			this.delegate48_0();
		}

		// Token: 0x060031B8 RID: 12728
		// RVA: 0x00145C98 File Offset: 0x00143E98
		internal void method_8()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			this.enum104_0 = Enum104.const_1;
			if (this.class533_0 != null)
			{
				this.class533_0.Text = "initialising";
			}
			if (this.fileNetRequest_0 != null)
			{
				Class169.smethod_0(this.fileNetRequest_0);
			}
		}

		// Token: 0x060031BC RID: 12732
		// RVA: 0x00024B3C File Offset: 0x00022D3C
		[CompilerGenerated]
		private void method_9(object sender, EventArgs e)
		{
			this.Abort(true);
		}

		// Token: 0x060031BA RID: 12730
		// RVA: 0x0000653E File Offset: 0x0000473E
		[CompilerGenerated]
		private static void smethod_0(double double_0)
		{
		}

		// Token: 0x060031BB RID: 12731
		// RVA: 0x0000653E File Offset: 0x0000473E
		[CompilerGenerated]
		private static void smethod_1(bool bool_1)
		{
		}

		// Token: 0x060031BF RID: 12735
		// RVA: 0x0000653E File Offset: 0x0000473E
		[CompilerGenerated]
		private static void smethod_2(object sender, EventArgs e)
		{
		}
	}
}
