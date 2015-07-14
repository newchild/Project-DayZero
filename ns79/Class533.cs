using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns29;
using ns77;
using ns84;
using osu.Graphics.Sprites;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;

namespace ns79
{
	// Token: 0x0200045D RID: 1117
	internal class Class533 : Class532
	{
		// Token: 0x04001C42 RID: 7234
		internal bool bool_15;

		// Token: 0x04001C45 RID: 7237
		public bool bool_16;

		// Token: 0x04001C4C RID: 7244
		internal bool bool_17;

		// Token: 0x04001C4F RID: 7247
		internal bool bool_18;

		// Token: 0x04001C51 RID: 7249
		public bool bool_19;

		// Token: 0x04001C52 RID: 7250
		private bool bool_20;

		// Token: 0x04001C49 RID: 7241
		private Color color_2;

		// Token: 0x04001C4A RID: 7242
		private Color color_3;

		// Token: 0x04001C4B RID: 7243
		private Color color_4;

		// Token: 0x04001C43 RID: 7235
		internal Enum72 enum72_0;

		// Token: 0x04001C4D RID: 7245
		internal Enum73 enum73_0;

		// Token: 0x04001C44 RID: 7236
		private EventHandler eventHandler_4;

		// Token: 0x04001C50 RID: 7248
		private float float_7;

		// Token: 0x04001C40 RID: 7232
		public int int_7;

		// Token: 0x04001C41 RID: 7233
		private int int_8;

		// Token: 0x04001C4E RID: 7246
		private string string_1;

		// Token: 0x04001C53 RID: 7251
		private string string_2;

		// Token: 0x04001C48 RID: 7240
		public Vector2 vector2_10;

		// Token: 0x04001C46 RID: 7238
		internal Vector2 vector2_9;

		// Token: 0x04001C47 RID: 7239
		public Vector4 vector4_0;

		// Token: 0x1700037C RID: 892
		internal virtual string Text
		{
			// Token: 0x06002445 RID: 9285
			// RVA: 0x0001C722 File Offset: 0x0001A922
			get
			{
				return this.string_1;
			}
			// Token: 0x06002446 RID: 9286
			// RVA: 0x0001C72A File Offset: 0x0001A92A
			set
			{
				if (this.string_1 == value)
				{
					return;
				}
				this.bool_18 = true;
				this.string_1 = value;
			}
		}

		// Token: 0x0600244E RID: 9294
		// RVA: 0x000DBDDC File Offset: 0x000D9FDC
		public Class533(string string_3, float float_8, Vector2 vector2_11, float float_9, bool bool_21, Color color_5) : this(string_3, float_8, vector2_11, Vector2.get_Zero(), float_9, bool_21, color_5, true)
		{
		}

		// Token: 0x0600244C RID: 9292
		// RVA: 0x000DBCA4 File Offset: 0x000D9EA4
		internal Class533(string string_3, float float_8, Vector2 vector2_11, Vector2 vector2_12, float float_9, bool bool_21, Color color_5, bool bool_22)
		{
			this.int_7 = 1;
			this.int_8 = Class115.int_23;
			this.bool_18 = true;
			this.string_2 = "Aller Light";
			base..ctor(null, Enum115.const_5, Origins.TopLeft, Enum114.const_0, vector2_11, float_9, bool_21, color_5);
			this.Text = string_3;
			this.bool_6 = true;
			this.method_57(Color.get_White());
			this.method_58((color_5.get_R() != 0 || color_5.get_G() != 0 || color_5.get_B() != 0) && bool_22);
			this.method_61(float_8);
			this.enum72_0 = Enum72.const_0;
			this.vector2_9 = vector2_12;
			this.bool_15 = true;
			if (float_8 * Class115.float_4 <= 15f)
			{
				this.nullable_2 = new bool?(true);
			}
			this.bool_13 = false;
			this.bool_17 = true;
		}

		// Token: 0x0600244D RID: 9293
		// RVA: 0x000DBD6C File Offset: 0x000D9F6C
		protected Class533(string string_3, Enum115 enum115_1, Origins origins_1, Enum114 enum114_1, Vector2 vector2_11, float float_8, bool bool_21, Color color_5)
		{
			this.int_7 = 1;
			this.int_8 = Class115.int_23;
			this.bool_18 = true;
			this.string_2 = "Aller Light";
			base..ctor(null, enum115_1, origins_1, enum114_1, vector2_11);
			this.float_0 = float_8;
			this.bool_0 = bool_21;
			this.color_0 = color_5;
			this.float_3 = (float)this.color_0.get_A() / 255f;
		}

		// Token: 0x0600244B RID: 9291
		// RVA: 0x000DBBF8 File Offset: 0x000D9DF8
		public override Class531 Clone()
		{
			Class533 class = new Class533(this.Text, this.method_60(), this.vector2_1, this.float_0, this.bool_0, this.color_0);
			class.enum72_0 = this.enum72_0;
			if (this.class731_0 != null)
			{
				class.vmethod_7(this.class731_0);
			}
			class.vector2_5 = this.vector2_5;
			class.origins_0 = this.origins_0;
			class.vector2_1 = this.vector2_1;
			class.int_2 = this.int_2;
			class.int_3 = this.int_3;
			class.int_4 = this.int_4;
			class.int_1 = this.int_1;
			return class;
		}

		// Token: 0x06002459 RID: 9305
		// RVA: 0x0001C802 File Offset: 0x0001AA02
		internal override void Dispose(bool bool_21)
		{
			if (this.bool_20)
			{
				Class742.Remove(this);
			}
			base.Dispose(bool_21);
		}

		// Token: 0x0600243C RID: 9276
		// RVA: 0x000DBBC0 File Offset: 0x000D9DC0
		internal void method_51(EventHandler eventHandler_5)
		{
			EventHandler eventHandler = this.eventHandler_4;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_5);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_4, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x0600243D RID: 9277
		// RVA: 0x0001C6BC File Offset: 0x0001A8BC
		internal Color method_52()
		{
			return this.color_2;
		}

		// Token: 0x0600243E RID: 9278
		// RVA: 0x0001C6C4 File Offset: 0x0001A8C4
		internal void method_53(Color color_5)
		{
			this.color_2 = color_5;
			this.bool_18 = true;
		}

		// Token: 0x0600243F RID: 9279
		// RVA: 0x0001C6D4 File Offset: 0x0001A8D4
		internal Color method_54()
		{
			return this.color_3;
		}

		// Token: 0x06002440 RID: 9280
		// RVA: 0x0001C6DC File Offset: 0x0001A8DC
		internal void method_55(Color color_5)
		{
			this.color_3 = color_5;
			this.bool_18 = true;
		}

		// Token: 0x06002441 RID: 9281
		// RVA: 0x0001C6EC File Offset: 0x0001A8EC
		internal Color method_56()
		{
			return this.color_4;
		}

		// Token: 0x06002442 RID: 9282
		// RVA: 0x0001C6F4 File Offset: 0x0001A8F4
		internal void method_57(Color color_5)
		{
			this.color_4 = color_5;
			this.bool_18 = true;
		}

		// Token: 0x06002443 RID: 9283
		// RVA: 0x0001C704 File Offset: 0x0001A904
		internal void method_58(bool bool_21)
		{
			this.enum73_0 = (bool_21 ? Enum73.const_1 : Enum73.const_0);
		}

		// Token: 0x06002444 RID: 9284
		// RVA: 0x0001C713 File Offset: 0x0001A913
		internal void method_59(bool bool_21)
		{
			this.enum73_0 = (bool_21 ? Enum73.const_2 : Enum73.const_0);
		}

		// Token: 0x06002447 RID: 9287
		// RVA: 0x0001C749 File Offset: 0x0001A949
		internal float method_60()
		{
			return this.float_7;
		}

		// Token: 0x06002448 RID: 9288
		// RVA: 0x0001C751 File Offset: 0x0001A951
		internal void method_61(float float_8)
		{
			if (this.float_7 == float_8)
			{
				return;
			}
			this.bool_18 = true;
			this.float_7 = float_8;
		}

		// Token: 0x06002449 RID: 9289
		// RVA: 0x0001C76B File Offset: 0x0001A96B
		internal void method_62(string string_3)
		{
			if (string_3 == this.string_2)
			{
				return;
			}
			this.string_2 = string_3;
			this.bool_18 = true;
		}

		// Token: 0x0600244A RID: 9290
		// RVA: 0x0001C78A File Offset: 0x0001A98A
		internal void method_63(bool bool_21)
		{
			this.bool_20 = bool_21;
			if (base.vmethod_6() != null)
			{
				base.vmethod_6().bool_3 = true;
				Class742.Load(this, true);
			}
		}

		// Token: 0x06002451 RID: 9297
		// RVA: 0x000DBE64 File Offset: 0x000DA064
		internal List<int> method_64(RectangleF[] rectangleF_1)
		{
			List<int> list = new List<int>();
			list.Add(0);
			if (this.Text.Length == 0)
			{
				return list;
			}
			float y = rectangleF_1[0].Y;
			for (int i = 1; i < this.Text.Length; i++)
			{
				if (rectangleF_1[i].Y > y)
				{
					list.Add(i);
					y = rectangleF_1[i].Y;
				}
			}
			return list;
		}

		// Token: 0x06002452 RID: 9298
		// RVA: 0x000DBED4 File Offset: 0x000DA0D4
		internal RectangleF[] method_65()
		{
			float float_ = (this.bool_17 ? ((float)Class115.int_23 / 768f) : 1f) * this.method_60();
			if (this.Text.Length == 0)
			{
				return null;
			}
			Vector2 vector2_ = (this.bool_17 ? Class115.float_4 : 1f) * this.vector2_9;
			Vector2 vector;
			RectangleF[] array;
			Class747.smethod_5(this.Text, float_, vector2_, this.method_56(), this.enum73_0, this.bool_16, this.bool_19, this.enum72_0, this.bool_15, ref vector, ref array, this.method_52(), this.method_54(), this.int_7, true, true, this.string_2, Vector4.get_Zero(), Vector2.get_Zero(), this.class731_0, 0, -1);
			if (this.bool_17)
			{
				for (int i = 0; i < this.Text.Length; i++)
				{
					RectangleF[] expr_CC_cp_0 = array;
					int expr_CC_cp_1 = i;
					expr_CC_cp_0[expr_CC_cp_1].X = expr_CC_cp_0[expr_CC_cp_1].X / Class115.float_4;
					RectangleF[] expr_E5_cp_0 = array;
					int expr_E5_cp_1 = i;
					expr_E5_cp_0[expr_E5_cp_1].Y = expr_E5_cp_0[expr_E5_cp_1].Y / Class115.float_4;
					RectangleF[] expr_FE_cp_0 = array;
					int expr_FE_cp_1 = i;
					expr_FE_cp_0[expr_FE_cp_1].Width = expr_FE_cp_0[expr_FE_cp_1].Width / Class115.float_4;
					RectangleF[] expr_117_cp_0 = array;
					int expr_117_cp_1 = i;
					expr_117_cp_0[expr_117_cp_1].Height = expr_117_cp_0[expr_117_cp_1].Height / Class115.float_4;
				}
				return array;
			}
			for (int j = 0; j < this.Text.Length; j++)
			{
				RectangleF[] expr_14C_cp_0 = array;
				int expr_14C_cp_1 = j;
				expr_14C_cp_0[expr_14C_cp_1].X = expr_14C_cp_0[expr_14C_cp_1].X * 0.625f;
				RectangleF[] expr_165_cp_0 = array;
				int expr_165_cp_1 = j;
				expr_165_cp_0[expr_165_cp_1].Y = expr_165_cp_0[expr_165_cp_1].Y * 0.625f;
				RectangleF[] expr_17E_cp_0 = array;
				int expr_17E_cp_1 = j;
				expr_17E_cp_0[expr_17E_cp_1].Width = expr_17E_cp_0[expr_17E_cp_1].Width * 0.625f;
				RectangleF[] expr_197_cp_0 = array;
				int expr_197_cp_1 = j;
				expr_197_cp_0[expr_197_cp_1].Height = expr_197_cp_0[expr_197_cp_1].Height * 0.625f;
			}
			return array;
		}

		// Token: 0x06002453 RID: 9299
		// RVA: 0x0001C7C1 File Offset: 0x0001A9C1
		internal Vector2 method_66(int int_9, int int_10)
		{
			return this.method_67(int_9, int_10, Vector2.get_Zero());
		}

		// Token: 0x06002454 RID: 9300
		// RVA: 0x000DC0A0 File Offset: 0x000DA2A0
		internal Vector2 method_67(int int_9, int int_10, Vector2 vector2_11)
		{
			float float_ = (this.bool_17 ? ((float)Class115.int_23 / 768f) : 1f) * this.method_60();
			if (this.Text.Length == 0)
			{
				return Vector2.get_Zero();
			}
			if (int_10 == 0)
			{
				return Vector2.get_Zero();
			}
			Vector2 vector2_12 = (this.bool_17 ? Class115.float_4 : 1f) * vector2_11;
			Vector2 vector;
			RectangleF[] array;
			Class747.smethod_5(this.Text, float_, vector2_12, this.method_56(), this.enum73_0, this.bool_16, this.bool_19, this.enum72_0, this.bool_15, ref vector, ref array, this.method_52(), this.method_54(), this.int_7, true, false, this.string_2, Vector4.get_Zero(), Vector2.get_Zero(), this.class731_0, int_9, int_10);
			if (this.bool_17)
			{
				return vector / Class115.float_4;
			}
			return vector * 0.625f;
		}

		// Token: 0x06002458 RID: 9304
		// RVA: 0x000DC3F8 File Offset: 0x000DA5F8
		public override string ToString()
		{
			return string.Concat(new object[]
			{
				"Text: ",
				this.Text,
				" (",
				this.vector2_1.X,
				",",
				this.vector2_1.Y,
				") @ ",
				this.float_7,
				"pt ",
				Math.Round((double)(this.float_3 * 100f), 1),
				"%"
			});
		}

		// Token: 0x06002455 RID: 9301
		// RVA: 0x0001C7D0 File Offset: 0x0001A9D0
		internal virtual Vector2 vmethod_11()
		{
			this.vmethod_6();
			if (this.bool_17)
			{
				return this.vector2_4 / Class115.float_4;
			}
			return this.vector2_4 * 0.625f;
		}

		// Token: 0x06002457 RID: 9303
		// RVA: 0x000DC1DC File Offset: 0x000DA3DC
		protected virtual Class731 vmethod_12(Class731 class731_1)
		{
			if (this.eventHandler_4 != null)
			{
				this.eventHandler_4(this, null);
			}
			Class731 class731_2 = this.class731_0;
			this.bool_18 = false;
			if (string.IsNullOrEmpty(this.Text) && this.vector2_9.X == 0f)
			{
				this.vector2_4 = this.vector2_9;
				return null;
			}
			this.int_8 = Class115.int_23;
			float float_ = (this.bool_17 ? ((float)Class115.int_23 / 768f) : 1f) * this.method_60();
			Vector2 vector2_ = (this.bool_17 ? Class115.float_4 : 1f) * this.vector2_9;
			Vector4 vector = this.vector4_0;
			Vector2 vector2 = this.vector2_10;
			if (vector != Vector4.get_Zero() && this.bool_17)
			{
				vector *= (float)Class115.int_23 / 768f;
			}
			if (this.vector2_10 != Vector2.get_Zero())
			{
				vector2 *= (float)Class115.int_23 / 768f;
			}
			float num = (float)this.int_7;
			if (num > 0f)
			{
				num *= (float)Class115.int_23 / 768f;
			}
			RectangleF[] array;
			this.class731_0 = ((class731_1 != null) ? class731_1 : Class747.smethod_5(this.Text, float_, vector2_, this.method_56(), this.enum73_0, this.bool_16, this.bool_19, this.enum72_0, this.bool_15, ref this.vector2_4, ref array, this.method_52(), this.method_54(), (int)Math.Round((double)num), false, false, this.string_2, vector, vector2, this.class731_0, 0, -1));
			if (class731_2 != null && this.class731_0 != class731_2)
			{
				class731_2.Dispose();
			}
			if (this.bool_20)
			{
				if (this.class731_0 != null)
				{
					this.class731_0.bool_3 = true;
				}
				if (class731_2 != this.class731_0)
				{
					Class742.Load(this, true);
				}
			}
			this.int_4 = (int)Math.Round((double)this.vector2_4.X);
			this.int_1 = (int)Math.Round((double)this.vector2_4.Y);
			this.vmethod_8();
			this.vmethod_9();
			return this.class731_0;
		}

		// Token: 0x06002456 RID: 9302
		// RVA: 0x000DC188 File Offset: 0x000DA388
		public override Enum51 vmethod_3()
		{
			Enum51 enum = base.vmethod_3();
			if (enum != Enum51.const_0)
			{
				return enum;
			}
			if (string.IsNullOrEmpty(this.Text) && this.vector2_9 == Vector2.get_Zero())
			{
				return Enum51.const_1;
			}
			if (this.bool_18)
			{
				this.vmethod_12(null);
				base.vmethod_3();
			}
			return enum;
		}

		// Token: 0x0600244F RID: 9295
		// RVA: 0x000DBE00 File Offset: 0x000DA000
		internal override Class731 vmethod_6()
		{
			if (string.IsNullOrEmpty(this.string_1) && this.method_52().get_A() == 0)
			{
				return null;
			}
			if (this.class731_0 != null && !this.class731_0.method_4() && !this.bool_18 && Class115.int_23 == this.int_8)
			{
				return this.class731_0;
			}
			return this.vmethod_12(null);
		}

		// Token: 0x06002450 RID: 9296
		// RVA: 0x0001C7AE File Offset: 0x0001A9AE
		internal override void vmethod_7(Class731 class731_1)
		{
			if (this.class731_0 != null)
			{
				return;
			}
			this.vmethod_12(class731_1);
		}
	}
}
