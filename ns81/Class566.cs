using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using ns14;
using ns18;
using ns29;
using ns82;
using ns9;
using osu;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace ns81
{
	// Token: 0x02000471 RID: 1137
	internal sealed class Class566 : Class565, Interface15
	{
		// Token: 0x04001E82 RID: 7810
		private bool bool_0;

		// Token: 0x04001E88 RID: 7816
		private bool bool_1 = true;

		// Token: 0x04001E86 RID: 7814
		private ButtonState buttonState_0;

		// Token: 0x04001E87 RID: 7815
		private ButtonState buttonState_1;

		// Token: 0x04001E7F RID: 7807
		internal Dictionary<int, Vector2> dictionary_0 = new Dictionary<int, Vector2>();

		// Token: 0x04001E81 RID: 7809
		private int int_1 = -1;

		// Token: 0x04001E80 RID: 7808
		private List<int> list_0 = new List<int>();

		// Token: 0x04001E84 RID: 7812
		private List<Vector2> list_1 = new List<Vector2>();

		// Token: 0x04001E85 RID: 7813
		private List<Vector2> list_2 = new List<Vector2>();

		// Token: 0x04001E83 RID: 7811
		private Point point_0;

		// Token: 0x17000381 RID: 897
		public Vector2 Position
		{
			// Token: 0x060024C7 RID: 9415
			// RVA: 0x0001CBD7 File Offset: 0x0001ADD7
			get
			{
				return new Vector2((float)this.point_0.X, (float)this.point_0.Y);
			}
		}

		// Token: 0x060024C1 RID: 9409
		// RVA: 0x0001CB78 File Offset: 0x0001AD78
		internal override void Dispose()
		{
			Class565.smethod_1(new Delegate41(this.method_3));
			base.Dispose();
		}

		// Token: 0x060024C6 RID: 9414
		// RVA: 0x0000653E File Offset: 0x0000473E
		public void imethod_0(Vector2 vector2_0)
		{
		}

		// Token: 0x060024C8 RID: 9416
		// RVA: 0x0001CBF6 File Offset: 0x0001ADF6
		public ButtonState? imethod_1()
		{
			return new ButtonState?(this.buttonState_0);
		}

		// Token: 0x060024C9 RID: 9417
		// RVA: 0x0001CC03 File Offset: 0x0001AE03
		public ButtonState? imethod_2()
		{
			return new ButtonState?(this.buttonState_1);
		}

		// Token: 0x060024CA RID: 9418
		// RVA: 0x000DD488 File Offset: 0x000DB688
		public ButtonState? imethod_3()
		{
			return null;
		}

		// Token: 0x060024CB RID: 9419
		// RVA: 0x000DD488 File Offset: 0x000DB688
		public ButtonState? imethod_4()
		{
			return null;
		}

		// Token: 0x060024CC RID: 9420
		// RVA: 0x000DD488 File Offset: 0x000DB688
		public ButtonState? imethod_5()
		{
			return null;
		}

		// Token: 0x060024CD RID: 9421
		// RVA: 0x0001CC10 File Offset: 0x0001AE10
		public List<Vector2> imethod_6()
		{
			return this.list_1;
		}

		// Token: 0x060024C0 RID: 9408
		// RVA: 0x000DD7D8 File Offset: 0x000DB9D8
		internal override bool Initialize()
		{
			if (!base.Initialize())
			{
				return false;
			}
			try
			{
				ushort num = Class559.GlobalAddAtom("MicrosoftTabletPenServiceProperty");
				if (num != 0)
				{
					Class559.SetProp(Class565.intptr_0, "MicrosoftTabletPenServiceProperty", 18415641);
				}
				Class559.GlobalDeleteAtom(num);
				Class559.RegisterTouchWindow(Class565.intptr_0, 2);
			}
			catch
			{
			}
			Class565.smethod_0(new Delegate41(this.method_3));
			return true;
		}

		// Token: 0x060024C3 RID: 9411
		// RVA: 0x0001CBBA File Offset: 0x0001ADBA
		private bool method_1()
		{
			return Class62.bool_11 || Class802.smethod_0() || Class115.osuModes_1 != OsuModes.Play;
		}

		// Token: 0x060024C4 RID: 9412
		// RVA: 0x000DD84C File Offset: 0x000DBA4C
		private void method_2(ButtonState buttonState_2)
		{
			if (buttonState_2 == 1)
			{
				this.bool_1 |= this.method_1();
			}
			if (this.bool_1)
			{
				this.buttonState_0 = buttonState_2;
			}
			else
			{
				this.buttonState_1 = buttonState_2;
			}
			if (buttonState_2 == 1)
			{
				this.bool_1 = !this.bool_1;
			}
		}

		// Token: 0x060024C5 RID: 9413
		// RVA: 0x000DD89C File Offset: 0x000DBA9C
		private void method_3(Struct57 struct57_0)
		{
			Point point = Class115.form_0.PointToClient(struct57_0.point_2);
			Vector2 vector;
			vector..ctor((float)point.X, (float)point.Y);
			if ((struct57_0.enum80_0 & Enum80.flag_12) > Enum80.flag_0 && !this.list_0.Contains(struct57_0.int_0))
			{
				if (this.list_0.Count < 2)
				{
					this.method_2(1);
				}
				this.int_1 = struct57_0.int_0;
				this.list_0.Add(struct57_0.int_0);
				this.dictionary_0.Add(struct57_0.int_0, vector / Class115.float_4);
			}
			if (this.int_1 == struct57_0.int_0)
			{
				this.point_0 = point;
				this.list_2.Add(vector);
			}
			if ((struct57_0.enum80_0 & Enum80.flag_14) > Enum80.flag_0 || (struct57_0.enum80_0 & Enum80.flag_17) > Enum80.flag_0)
			{
				if (this.list_0.Contains(struct57_0.int_0))
				{
					if (this.list_0.Count <= 2)
					{
						if (this.list_0.Count == 1)
						{
							this.buttonState_0 = 0;
							this.buttonState_1 = 0;
							this.bool_1 = true;
						}
						else
						{
							this.method_2(0);
						}
					}
					this.list_0.Remove(struct57_0.int_0);
					this.dictionary_0.Remove(struct57_0.int_0);
				}
				this.int_1 = ((this.list_0.Count == 0) ? -1 : this.list_0[this.list_0.Count - 1]);
			}
		}

		// Token: 0x060024C2 RID: 9410
		// RVA: 0x0001CB91 File Offset: 0x0001AD91
		internal override void vmethod_1(bool bool_2)
		{
			this.list_1.Clear();
			this.list_1.AddRange(this.list_2);
			this.list_2.Clear();
		}

		// Token: 0x060024CE RID: 9422
		// RVA: 0x000DDA30 File Offset: 0x000DBC30
		internal override bool vmethod_2()
		{
			bool flag;
			if (!(flag = (this.int_1 != -1)) && this.bool_0)
			{
				flag = true;
				this.bool_0 = false;
			}
			else if (flag)
			{
				this.bool_0 = true;
			}
			return flag && Class114.bool_0 && !Class800.bool_5;
		}

		// Token: 0x060024CF RID: 9423
		// RVA: 0x0000B7FB File Offset: 0x000099FB
		internal override int vmethod_3()
		{
			return 2;
		}
	}
}
