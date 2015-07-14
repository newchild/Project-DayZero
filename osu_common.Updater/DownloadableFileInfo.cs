using ns15;
using ns30;
using ns35;
using ns41;
using ns8;
using osu_common.Helpers;
using osu_common.Libraries.NetLib;
using System;
using System.IO;
using System.Threading;

namespace osu_common.Updater
{
	// Token: 0x0200028A RID: 650
	public sealed class DownloadableFileInfo : UpdaterFileInfo
	{
		// Token: 0x040010BB RID: 4283
		private int downloaded_bytes;

		// Token: 0x040010BC RID: 4284
		public Exception Error;

		// Token: 0x040010B9 RID: 4281
		internal bool isPatching;

		// Token: 0x040010BA RID: 4282
		internal bool isRunning;

		// Token: 0x040010B7 RID: 4279
		internal FileNetRequest netRequest;

		// Token: 0x040010B8 RID: 4280
		internal float progress;

		// Token: 0x040010BD RID: 4285
		private Thread thread;

		// Token: 0x060015E3 RID: 5603
		// RVA: 0x000136C0 File Offset: 0x000118C0
		internal void Abort()
		{
			if (this.thread != null)
			{
				this.thread.Abort();
				this.thread = null;
			}
		}

		// Token: 0x060015E1 RID: 5601
		// RVA: 0x00070B94 File Offset: 0x0006ED94
		internal void Perform(bool doPatching = false)
		{
			this.isRunning = true;
			this.progress = 0f;
			this.downloaded_bytes = 0;
			this.isPatching = false;
			if (doPatching && this.url_patch == null)
			{
				throw new Exception("patch not available for this file!");
			}
			string text = "_staging/" + this.filename + (doPatching ? "_patch" : ".zip");
			this.netRequest = new FileNetRequest(text, doPatching ? this.url_patch : (this.url_full + ".zip"));
			this.netRequest.method_1(delegate(object sender, long current, long total)
			{
				this.progress = (float)current / (float)total * (float)(doPatching ? 50 : 100);
				this.downloaded_bytes = (int)current;
				this.filesize = (int)total;
			});
			try
			{
				this.netRequest.Perform(true);
				if (!File.Exists(text))
				{
					throw new Exception("couldn't find downloaded file (" + text + ")");
				}
			}
			catch (ThreadAbortException)
			{
				this.isRunning = false;
				return;
			}
			if (this.netRequest.string_1.EndsWith(".zip"))
			{
				Class203 class = new Class203();
				class.method_6(this.netRequest.string_1, "_staging", ".*");
				Class34.smethod_18(this.netRequest.string_1);
			}
			if (doPatching)
			{
				string text2 = "_staging/" + this.filename;
				string text3 = "_staging/" + this.filename + "_patched";
				try
				{
					this.isPatching = true;
					Class52 class2 = new Class52();
					class2.method_0(delegate(object sender, long current, long total)
					{
						this.progress = 50f + (float)current / (float)total * 50f;
					});
					class2.method_1(text2, text3, text, Enum7.const_1);
				}
				finally
				{
					Class34.smethod_18(text);
					Class34.smethod_18(text2);
					if (File.Exists(text3))
					{
						Class34.smethod_14(text3, text2, true, true);
					}
					this.isPatching = false;
				}
				this.isRunning = false;
			}
		}

		// Token: 0x060015E2 RID: 5602
		// RVA: 0x00070D98 File Offset: 0x0006EF98
		internal void PerformThreaded(VoidDelegate onComplete = null, VoidDelegate onError = null)
		{
			this.thread = new Thread(delegate
			{
				int num = 0;
				try
				{
					IL_02:
					this.Perform(false);
					if (onComplete != null)
					{
						onComplete();
					}
				}
				catch (ThreadAbortException)
				{
					this.Abort();
				}
				catch (Exception2 error)
				{
					if (++num < 4)
					{
						if (num > 1)
						{
							string oldValue = "m" + (num - 1) + ".";
							string newValue = "m" + num + ".";
							if (!string.IsNullOrEmpty(this.url_full))
							{
								this.url_full = this.url_full.Replace(oldValue, newValue);
							}
							if (!string.IsNullOrEmpty(this.url_patch))
							{
								this.url_patch = this.url_patch.Replace(oldValue, newValue);
							}
						}
						Thread.Sleep(1500);
						goto IL_02;
					}
					Class214.string_2 = (this.url_patch ?? this.url_full);
					this.Error = error;
					if (onError != null)
					{
						onError();
					}
				}
				catch (Exception error2)
				{
					this.Error = error2;
					if (onError != null)
					{
						onError();
					}
				}
			});
			this.thread.IsBackground = true;
			this.thread.Start();
		}
	}
}
