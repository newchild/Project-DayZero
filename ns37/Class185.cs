using System;
using System.IO;

namespace ns37
{
	// Token: 0x02000247 RID: 583
	internal sealed class Class185
	{
		// Token: 0x04000F16 RID: 3862
		private bool bool_0;

		// Token: 0x04000F10 RID: 3856
		public Delegate19 delegate19_0;

		// Token: 0x04000F11 RID: 3857
		public Delegate20 delegate20_0;

		// Token: 0x04000F12 RID: 3858
		public Delegate23 delegate23_0;

		// Token: 0x04000F13 RID: 3859
		public Delegate24 delegate24_0;

		// Token: 0x04000F14 RID: 3860
		private Interface12 interface12_0;

		// Token: 0x04000F15 RID: 3861
		private Interface12 interface12_1;

		// Token: 0x06001462 RID: 5218
		// RVA: 0x00012625 File Offset: 0x00010825
		public Class185(string string_0, string string_1)
		{
			this.interface12_0 = new Class187(string_0);
			this.interface12_1 = new Class187(string_1);
		}

		// Token: 0x06001463 RID: 5219
		// RVA: 0x0006884C File Offset: 0x00066A4C
		private void method_0(string string_0, Exception exception_0)
		{
			if (this.delegate23_0 == null)
			{
				this.bool_0 = false;
				return;
			}
			Class184 class = new Class184(string_0, exception_0);
			this.delegate23_0(this, class);
			this.bool_0 = class.method_0();
		}

		// Token: 0x06001464 RID: 5220
		// RVA: 0x0006888C File Offset: 0x00066A8C
		private void method_1(string string_0, Exception exception_0)
		{
			if (this.delegate24_0 == null)
			{
				this.bool_0 = false;
				return;
			}
			Class184 class = new Class184(string_0, exception_0);
			this.delegate24_0(this, class);
			this.bool_0 = class.method_0();
		}

		// Token: 0x06001465 RID: 5221
		// RVA: 0x000688CC File Offset: 0x00066ACC
		private void method_2(string string_0)
		{
			if (this.delegate20_0 != null)
			{
				EventArgs7 eventArgs = new EventArgs7(string_0);
				this.delegate20_0(this, eventArgs);
				this.bool_0 = eventArgs.method_0();
			}
		}

		// Token: 0x06001466 RID: 5222
		// RVA: 0x00068904 File Offset: 0x00066B04
		private void method_3(string string_0, bool bool_1)
		{
			if (this.delegate19_0 != null)
			{
				EventArgs8 eventArgs = new EventArgs8(string_0, bool_1);
				this.delegate19_0(this, eventArgs);
				this.bool_0 = eventArgs.method_0();
			}
		}

		// Token: 0x06001467 RID: 5223
		// RVA: 0x00012645 File Offset: 0x00010845
		public void method_4(string string_0, bool bool_1)
		{
			this.bool_0 = true;
			this.method_5(string_0, bool_1);
		}

		// Token: 0x06001468 RID: 5224
		// RVA: 0x0006893C File Offset: 0x00066B3C
		private void method_5(string string_0, bool bool_1)
		{
			try
			{
				string[] files = Directory.GetFiles(string_0);
				bool flag = false;
				for (int i = 0; i < files.Length; i++)
				{
					if (!this.interface12_0.IsMatch(files[i]))
					{
						files[i] = null;
					}
					else
					{
						flag = true;
					}
				}
				this.method_3(string_0, flag);
				if (this.bool_0 && flag)
				{
					string[] array = files;
					for (int j = 0; j < array.Length; j++)
					{
						string text = array[j];
						try
						{
							if (text != null)
							{
								this.method_2(text);
								if (!this.bool_0)
								{
									break;
								}
							}
						}
						catch (Exception exception_)
						{
							this.method_1(text, exception_);
						}
					}
				}
			}
			catch (Exception exception_2)
			{
				this.method_0(string_0, exception_2);
			}
			if (this.bool_0 && bool_1)
			{
				try
				{
					string[] directories = Directory.GetDirectories(string_0);
					string[] array2 = directories;
					for (int k = 0; k < array2.Length; k++)
					{
						string string_ = array2[k];
						if (this.interface12_1 == null || this.interface12_1.IsMatch(string_))
						{
							this.method_5(string_, true);
							if (!this.bool_0)
							{
								break;
							}
						}
					}
				}
				catch (Exception exception_3)
				{
					this.method_0(string_0, exception_3);
				}
			}
		}
	}
}
