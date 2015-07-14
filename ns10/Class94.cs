using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns14;
using ns24;
using ns26;
using ns27;
using ns29;
using ns77;
using ns79;
using ns80;
using ns82;
using osu.Graphics.Sprites;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ns10
{
	// Token: 0x020004C7 RID: 1223
	internal sealed class Class94 : Class89
	{
		// Token: 0x020004C8 RID: 1224
		[CompilerGenerated]
		private sealed class Class634
		{
			// Token: 0x0400208E RID: 8334
			public Class531 class531_0;

			// Token: 0x04002090 RID: 8336
			public Class94 class94_0;

			// Token: 0x0400208F RID: 8335
			public int int_0;

			// Token: 0x0400208D RID: 8333
			public string string_0;

			// Token: 0x0600273D RID: 10045
			// RVA: 0x000F1D50 File Offset: 0x000EFF50
			public void method_0(object sender, EventArgs e)
			{
				this.class94_0.bool_6 = (this.class531_0 is Class538);
				this.class94_0.string_0 = this.string_0;
				if (this.class94_0.bool_6)
				{
					this.class94_0.double_0 = (double)this.int_0;
					this.class94_0.int_3 = ((Class538)this.class531_0).int_7;
				}
				this.class94_0.Close(false);
			}
		}

		// Token: 0x04002086 RID: 8326
		private bool bool_5;

		// Token: 0x04002089 RID: 8329
		internal bool bool_6;

		// Token: 0x04002081 RID: 8321
		private readonly Class110 class110_0;

		// Token: 0x0400208B RID: 8331
		public double double_0;

		// Token: 0x04002082 RID: 8322
		private float float_1;

		// Token: 0x04002083 RID: 8323
		private float float_2;

		// Token: 0x04002085 RID: 8325
		private int int_1;

		// Token: 0x04002087 RID: 8327
		private int int_2;

		// Token: 0x0400208A RID: 8330
		internal int int_3;

		// Token: 0x04002084 RID: 8324
		private List<string> list_1;

		// Token: 0x04002088 RID: 8328
		internal string string_0;

		// Token: 0x0400208C RID: 8332
		private string string_1;

		// Token: 0x06002734 RID: 10036
		// RVA: 0x000F160C File Offset: 0x000EF80C
		internal Class94()
		{
			EventHandler eventHandler = null;
			this.bool_5 = true;
			base..ctor("Sprite Library", true);
			this.class110_0 = new Class110(new Rectangle(0, 50, 640, 360), new Vector2(640f, 480f), false, 0f, Enum98.const_5);
			if (Class466.Current.bool_10)
			{
				Class466.Current.method_72(Class296.Enum64.const_2, false);
				this.string_1 = Class466.Current.method_8();
			}
			else
			{
				this.string_1 = Class466.Current.method_3();
			}
			this.list_1 = new List<string>();
			Class760 class = new Class760("Cancel", new Vector2(40f, 440f), new Vector2(240f, 30f), 1f, Color.get_Gray(), delegate(object sender, EventArgs e)
			{
				this.Close(false);
			}, true, false, null);
			this.class911_0.Add<Class531>(class.list_0);
			string arg_13F_0 = "Browse...";
			Vector2 arg_13F_1 = new Vector2(360f, 440f);
			Vector2 arg_13F_2 = new Vector2(240f, 30f);
			float arg_13F_3 = 1f;
			Color arg_13F_4 = Color.get_Orange();
			if (eventHandler == null)
			{
				eventHandler = new EventHandler(this.method_10);
			}
			class = new Class760(arg_13F_0, arg_13F_1, arg_13F_2, arg_13F_3, arg_13F_4, eventHandler, true, false, null);
			this.class911_0.Add<Class531>(class.list_0);
			string[] files = Directory.GetFiles(this.string_1, "*.png", SearchOption.AllDirectories);
			this.list_1.AddRange(files);
			string[] files2 = Directory.GetFiles(this.string_1, "*.jpg", SearchOption.AllDirectories);
			this.list_1.AddRange(files2);
		}

		// Token: 0x06002738 RID: 10040
		// RVA: 0x0001E4C7 File Offset: 0x0001C6C7
		protected override void Dispose(bool bool_7)
		{
			this.class110_0.Dispose();
			base.Dispose(bool_7);
		}

		// Token: 0x06002736 RID: 10038
		// RVA: 0x0001E4B4 File Offset: 0x0001C6B4
		internal override void Draw()
		{
			base.Draw();
			this.class110_0.Draw();
		}

		// Token: 0x06002737 RID: 10039
		// RVA: 0x000F1910 File Offset: 0x000EFB10
		public override void imethod_2()
		{
			if (this.bool_5 && Class115.int_1 - this.int_2 > 40)
			{
				if (this.list_1.Count > 0)
				{
					Class94.Class634 class = new Class94.Class634();
					class.class94_0 = this;
					this.float_1 = (float)(80 + 100 * (this.int_1 % 6));
					this.float_2 = (float)(50 + this.int_1 / 6 * 100);
					this.int_1++;
					class.string_0 = this.list_1[0].Replace(this.string_1 + Path.DirectorySeparatorChar, string.Empty);
					class.class531_0 = null;
					class.int_0 = 0;
					if (this.list_1.Count > 1 && class.string_0[class.string_0.Length - 5] == '0')
					{
						List<Class731> list = new List<Class731>();
						int num = 0;
						while (true)
						{
							string item = class.string_0.Replace("0.", num++ + ".");
							Class731 class2 = Class885.Load(item, Enum112.flag_3);
							if (class2 == null)
							{
								break;
							}
							this.list_1.Remove(item);
							list.Add(class2);
						}
						if (list.Count > 1)
						{
							Class538 class3 = new Class538(list.ToArray(), Enum115.const_14, Origins.Centre, Enum114.const_0, new Vector2(this.float_1, this.float_2), 0.98f, true, Color.get_White(), null);
							class3.float_2 = 98f / (float)Math.Max(class3.int_6, class3.int_5);
							this.class110_0.class911_0.Add(class3);
							class.class531_0 = class3;
							class.string_0 = class.string_0.Replace("0.", ".");
							class.int_0 = (int)((Class331.smethod_7() != null) ? (Class331.smethod_7().double_0 * 2.0 / (double)list.Count) : 500.0);
							class3.method_53((double)class.int_0);
						}
					}
					if (class.class531_0 == null)
					{
						class.class531_0 = new Class531(Class885.Load(class.string_0, Enum112.flag_3), Enum115.const_14, Origins.Centre, Enum114.const_0, new Vector2(this.float_1, this.float_2), 0.98f, true, Color.get_White(), null);
						class.class531_0.float_2 = 98f / (float)Math.Max(class.class531_0.int_6, class.class531_0.int_5);
						this.class110_0.class911_0.Add(class.class531_0);
					}
					Class531 class4 = new Class531(Class115.class731_0, Enum115.const_14, Origins.TopLeft, Enum114.const_0, new Vector2(this.float_1 - 39f, this.float_2 - 39f), 0.9f, true, new Color(15, 15, 15, 255), null);
					class4.class746_1 = new Class746(class4.color_0, new Color(50, 50, 50, 255), 0, 100);
					class4.object_0 = class.class531_0;
					class4.method_2(new EventHandler(class.method_0));
					class4.bool_1 = true;
					class4.vector2_2 = new Vector2(100f, 100f);
					this.class110_0.class911_0.Add(class4);
					Class533 class5 = new Class533(class.string_0, 8f, new Vector2(this.float_1 - 39f, this.float_2 - 50f), new Vector2(100f, 100f), 1f, true, Color.get_White(), true);
					class5.bool_17 = false;
					class5.bool_15 = false;
					class5.method_58(true);
					this.class110_0.class911_0.Add(class5);
					this.list_1.RemoveAt(0);
				}
				this.class110_0.method_14(new Vector2(this.float_1 + 100f, this.float_2 + 100f));
				this.int_2 = Class115.int_1;
				if (this.list_1.Count == 0)
				{
					this.bool_5 = false;
				}
			}
			this.class110_0.imethod_2();
			base.imethod_2();
		}

		// Token: 0x0600273A RID: 10042
		// RVA: 0x0001E4DB File Offset: 0x0001C6DB
		[CompilerGenerated]
		private void method_10(object sender, EventArgs e)
		{
			this.method_9();
		}

		// Token: 0x0600273B RID: 10043
		// RVA: 0x000177D1 File Offset: 0x000159D1
		[CompilerGenerated]
		private void method_11()
		{
			this.Close(false);
		}

		// Token: 0x06002735 RID: 10037
		// RVA: 0x000F17AC File Offset: 0x000EF9AC
		private void method_9()
		{
			VoidDelegate voidDelegate = null;
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Images (jpg/png)|*.jpg;*.png";
			openFileDialog.InitialDirectory = Path.GetFullPath(this.string_1);
			openFileDialog.RestoreDirectory = true;
			this.bool_6 = false;
			if (DialogResult.OK == openFileDialog.ShowDialog(Class115.form_0))
			{
				string fileName = openFileDialog.FileName;
				if (fileName.StartsWith(this.string_1))
				{
					return;
				}
				string text = Path.Combine(this.string_1, Path.GetFileName(fileName));
				if (fileName.Contains("0."))
				{
					this.int_3 = 0;
					while (true)
					{
						string text2 = fileName.Replace("0.", this.int_3 + ".");
						if (!File.Exists(text2))
						{
							break;
						}
						try
						{
							File.Delete(Path.Combine(this.string_1, Path.GetFileName(text2)));
							File.Copy(text2, Path.Combine(this.string_1, Path.GetFileName(text2)));
							goto IL_F5;
						}
						catch (Exception)
						{
							goto IL_F5;
						}
						goto IL_DE;
						IL_E5:
						this.int_3++;
						continue;
						IL_DE:
						this.bool_6 = true;
						goto IL_E5;
						IL_F5:
						if (this.int_3 > 0)
						{
							goto IL_DE;
						}
						goto IL_E5;
					}
				}
				else
				{
					try
					{
						File.Delete(text);
						File.Copy(fileName, text);
					}
					catch
					{
					}
				}
				this.string_0 = text;
				Class47 arg_133_0 = Class115.class47_0;
				if (voidDelegate == null)
				{
					voidDelegate = new VoidDelegate(this.method_11);
				}
				arg_133_0.Add(voidDelegate, false);
			}
		}
	}
}
