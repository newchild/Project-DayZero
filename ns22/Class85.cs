using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns14;
using ns18;
using ns26;
using ns29;
using ns77;
using ns79;
using ns80;
using ns82;
using ns9;
using osu.Graphics.Sprites;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns22
{
	// Token: 0x020004FD RID: 1277
	internal sealed class Class85 : Class55
	{
		// Token: 0x04002227 RID: 8743
		[CompilerGenerated]
		private static Action<Class530> action_0;

		// Token: 0x04002228 RID: 8744
		[CompilerGenerated]
		private static Action<Class530> action_1;

		// Token: 0x04002229 RID: 8745
		[CompilerGenerated]
		private static Action<Class530> action_2;

		// Token: 0x0400222A RID: 8746
		[CompilerGenerated]
		private static Action<Class530> action_3;

		// Token: 0x0400222B RID: 8747
		[CompilerGenerated]
		private static Action<Class530> action_4;

		// Token: 0x04002223 RID: 8739
		private bool bool_2;

		// Token: 0x04002217 RID: 8727
		private readonly Class531 class531_0;

		// Token: 0x04002218 RID: 8728
		private readonly Class531 class531_1;

		// Token: 0x04002219 RID: 8729
		private readonly Class531 class531_2;

		// Token: 0x0400221C RID: 8732
		private Class533 class533_0;

		// Token: 0x04002224 RID: 8740
		private Class608 class608_0;

		// Token: 0x04002220 RID: 8736
		private Class82 class82_0 = new Class82();

		// Token: 0x0400221D RID: 8733
		private Class911 class911_0 = new Class911(true)
		{
			bool_14 = true
		};

		// Token: 0x0400221E RID: 8734
		private Class911 class911_1 = new Class911(true)
		{
			bool_14 = true
		};

		// Token: 0x0400221F RID: 8735
		private Class911 class911_2 = new Class911(true)
		{
			bool_14 = true
		};

		// Token: 0x0400221A RID: 8730
		private Color color_0 = new Color(102, 68, 204);

		// Token: 0x0400221B RID: 8731
		private Color color_1 = new Color(68, 17, 136);

		// Token: 0x04002225 RID: 8741
		private EventHandler eventHandler_4;

		// Token: 0x04002222 RID: 8738
		private float float_0;

		// Token: 0x04002226 RID: 8742
		private float float_1;

		// Token: 0x04002221 RID: 8737
		private int int_2;

		// Token: 0x0600290C RID: 10508
		// RVA: 0x00103058 File Offset: 0x00101258
		internal Class85(Class608 class608_1, string string_0, Vector2 vector2_0, float float_2, bool bool_3, EventHandler eventHandler_5) : base(Class115.class114_0)
		{
			this.vmethod_1(false);
			this.class608_0 = class608_1;
			this.method_3(eventHandler_5);
			this.float_1 = float_2;
			this.class531_0 = new Class531(Class885.Load("volume-circle-bg", Enum112.flag_1), Enum115.const_9, Origins.Centre, Enum114.const_0, vector2_0, 0.97f, true, this.color_1, null);
			this.class531_0.bool_1 = true;
			this.class531_0.method_35(new EventHandler(this.method_4));
			this.class911_0.Add(this.class531_0);
			this.class531_1 = new Class531(Class885.Load("volume-circle-fg", Enum112.flag_1), Enum115.const_9, Origins.Centre, Enum114.const_0, vector2_0, 0.98f, true, this.color_1, null);
			this.class911_1.Add(this.class531_1);
			this.class531_2 = new Class531(Class885.Load("volume-circle-fg2", Enum112.flag_1), Enum115.const_9, Origins.Centre, Enum114.const_0, vector2_0, 0.99f, true, Color.get_White(), null);
			this.class911_1.Add(this.class531_2);
			this.class533_0 = new Class533(string.Empty, 14f, vector2_0, 0.991f, true, Color.get_White())
			{
				enum115_0 = Enum115.const_9,
				origins_0 = Origins.Centre
			};
			this.class911_1.Add(this.class533_0);
			Class533 class530_ = new Class533(string_0, 12f, new Vector2(vector2_0.X, 220f), 0.991f, true, Color.get_White())
			{
				enum115_0 = Enum115.const_9,
				origins_0 = Origins.Centre
			};
			this.class911_2.Add(class530_);
			this.class82_0.color_0 = Color.get_White();
			this.class82_0.float_2 = 1f;
			List<Class530> arg_23E_0 = this.class911_1.list_2;
			if (Class85.action_0 == null)
			{
				Class85.action_0 = new Action<Class530>(Class85.smethod_0);
			}
			arg_23E_0.ForEach(Class85.action_0);
			this.class911_0.list_2.ForEach(delegate(Class530 class530_0)
			{
				class530_0.float_3 = 0f;
			});
			this.class911_2.list_2.ForEach(delegate(Class530 class530_0)
			{
				class530_0.float_3 = 0f;
			});
			this.method_2(bool_3);
		}

		// Token: 0x06002913 RID: 10515
		// RVA: 0x0001F950 File Offset: 0x0001DB50
		internal new void Dispose()
		{
			this.class911_0.Dispose();
			this.class911_1.Dispose();
			this.class911_2.Dispose();
		}

		// Token: 0x06002912 RID: 10514
		// RVA: 0x001034B8 File Offset: 0x001016B8
		public override void Draw()
		{
			if (this.imethod_8())
			{
				if (this.class531_1.float_3 > 0.98f)
				{
					float num = (float)this.class608_0.Value / 100f;
					if (this.class82_0.float_3 != num)
					{
						this.class82_0.float_3 = MathHelper.Clamp(this.class82_0.float_3 + (num - this.class82_0.float_3) / 100f * (float)Class115.double_9 * this.method_1(), 0f, 1f);
					}
					if (Class115.bool_13)
					{
						this.class533_0.Text = Math.Round((double)(this.class82_0.float_3 * 100f)) + "%";
					}
				}
			}
			else if (this.class533_0.float_3 == 0f)
			{
				this.class533_0.Text = string.Empty;
			}
			this.class911_0.Draw();
			this.class82_0.float_0 = (float)Math.Pow((double)this.class531_1.float_3, 8.0);
			if (this.class82_0.float_0 > 0f)
			{
				this.class82_0.vector2_0 = new Vector2((float)(Class115.smethod_43() / 2), (float)(Class115.smethod_44() / 2)) + this.class531_0.vector2_1;
				this.class82_0.float_1 = 40.2f * this.class531_0.float_2;
				this.class82_0.Draw();
			}
			this.class911_1.Draw();
			this.class911_2.Draw();
			base.Draw();
		}

		// Token: 0x06002911 RID: 10513
		// RVA: 0x00103448 File Offset: 0x00101648
		public override void imethod_2()
		{
			this.class531_0.bool_1 = !Class62.bool_12;
			float num = (float)((Class802.vector2_0.Y > (float)(Class115.int_23 / 3 * 2)) ? 1600 : 800) / this.method_1();
			if (this.imethod_8() && (float)(Class115.int_1 - this.int_2) > num)
			{
				this.vmethod_1(false);
			}
			base.imethod_2();
		}

		// Token: 0x0600290F RID: 10511
		// RVA: 0x0001F948 File Offset: 0x0001DB48
		public override bool imethod_8()
		{
			return base.imethod_8();
		}

		// Token: 0x06002909 RID: 10505
		// RVA: 0x0001F90B File Offset: 0x0001DB0B
		private float method_1()
		{
			return (float)(Class62.bool_12 ? 10 : 1);
		}

		// Token: 0x0600291B RID: 10523
		// RVA: 0x0001F9CD File Offset: 0x0001DBCD
		[CompilerGenerated]
		private void method_10(Class530 class530_0)
		{
			class530_0.method_14((int)(150f / this.method_1()), Enum70.const_0);
			class530_0.method_26(1f * this.float_0 * this.float_1, 600, Enum70.const_25);
		}

		// Token: 0x0600291D RID: 10525
		// RVA: 0x0001FA12 File Offset: 0x0001DC12
		[CompilerGenerated]
		private void method_11(Class530 class530_0)
		{
			class530_0.method_16(200, Enum70.const_0);
			class530_0.method_26(0.6f * this.float_0 * this.float_1, 1000, Enum70.const_1);
		}

		// Token: 0x0600291E RID: 10526
		// RVA: 0x0001FA40 File Offset: 0x0001DC40
		[CompilerGenerated]
		private void method_12(Class530 class530_0)
		{
			class530_0.method_16(50, Enum70.const_0);
			class530_0.method_26(0.6f * this.float_0 * this.float_1, 1000, Enum70.const_1);
		}

		// Token: 0x0600290A RID: 10506
		// RVA: 0x00102F2C File Offset: 0x0010112C
		internal void method_2(bool bool_3)
		{
			Action<Class530> action = null;
			Action<Class530> action2 = null;
			if (bool_3 == this.bool_2 && this.float_0 != 0f)
			{
				return;
			}
			this.bool_2 = bool_3;
			if (this.bool_2)
			{
				this.class531_0.method_39(this.color_0, 100, false, Enum70.const_0);
				this.class531_1.method_39(this.color_0, 100, false, Enum70.const_0);
				this.float_0 = 1f;
			}
			else
			{
				this.class531_0.method_39(this.color_1, 100, false, Enum70.const_0);
				this.class531_1.method_39(this.color_1, 100, false, Enum70.const_0);
				this.float_0 = 0.95f;
			}
			if (this.imethod_8())
			{
				List<Class530> arg_BE_0 = this.class911_0.list_2;
				if (action == null)
				{
					action = new Action<Class530>(this.method_7);
				}
				arg_BE_0.ForEach(action);
				List<Class530> arg_DF_0 = this.class911_1.list_2;
				if (action2 == null)
				{
					action2 = new Action<Class530>(this.method_8);
				}
				arg_DF_0.ForEach(action2);
			}
		}

		// Token: 0x0600290B RID: 10507
		// RVA: 0x00103020 File Offset: 0x00101220
		private void method_3(EventHandler eventHandler_5)
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

		// Token: 0x0600290D RID: 10509
		// RVA: 0x0001F91A File Offset: 0x0001DB1A
		private void method_4(object sender, EventArgs e)
		{
			if (this.eventHandler_4 != null)
			{
				this.eventHandler_4(this, null);
			}
		}

		// Token: 0x0600290E RID: 10510
		// RVA: 0x0001F931 File Offset: 0x0001DB31
		internal bool method_5()
		{
			return this.imethod_8() && this.class531_0.vmethod_1();
		}

		// Token: 0x06002914 RID: 10516
		// RVA: 0x00103664 File Offset: 0x00101864
		internal void method_6(int int_3)
		{
			this.vmethod_1(true);
			int value = this.class608_0.Value;
			this.class608_0.Value += int_3;
			Class331.smethod_36(null, "sliderbar", 1.1f - (0.5f - (float)this.class608_0.Value / 100f) * 0.15f * (float)((this.class608_0.Value != value) ? 1 : 4), false);
		}

		// Token: 0x06002915 RID: 10517
		// RVA: 0x0001F973 File Offset: 0x0001DB73
		[CompilerGenerated]
		private void method_7(Class530 class530_0)
		{
			class530_0.method_26(1f * this.float_0 * this.float_1, 600, Enum70.const_25);
		}

		// Token: 0x06002916 RID: 10518
		// RVA: 0x0001F973 File Offset: 0x0001DB73
		[CompilerGenerated]
		private void method_8(Class530 class530_0)
		{
			class530_0.method_26(1f * this.float_0 * this.float_1, 600, Enum70.const_25);
		}

		// Token: 0x0600291A RID: 10522
		// RVA: 0x0001F996 File Offset: 0x0001DB96
		[CompilerGenerated]
		private void method_9(Class530 class530_0)
		{
			class530_0.method_14((int)(80f / this.method_1()), Enum70.const_0);
			class530_0.method_26(1f * this.float_0 * this.float_1, 600, Enum70.const_25);
		}

		// Token: 0x06002917 RID: 10519
		// RVA: 0x0001C8F9 File Offset: 0x0001AAF9
		[CompilerGenerated]
		private static void smethod_0(Class530 class530_0)
		{
			class530_0.float_3 = 0f;
		}

		// Token: 0x0600291C RID: 10524
		// RVA: 0x0001FA04 File Offset: 0x0001DC04
		[CompilerGenerated]
		private static void smethod_1(Class530 class530_0)
		{
			class530_0.method_14(250, Enum70.const_0);
		}

		// Token: 0x0600291F RID: 10527
		// RVA: 0x0001FA6B File Offset: 0x0001DC6B
		[CompilerGenerated]
		private static void smethod_2(Class530 class530_0)
		{
			class530_0.method_16(250, Enum70.const_0);
		}

		// Token: 0x06002910 RID: 10512
		// RVA: 0x0010330C File Offset: 0x0010150C
		public override void vmethod_1(bool bool_3)
		{
			Action<Class530> action = null;
			Action<Class530> action2 = null;
			Action<Class530> action3 = null;
			Action<Class530> action4 = null;
			if (bool_3)
			{
				this.int_2 = Class115.int_1;
			}
			if (bool_3 == base.imethod_8())
			{
				return;
			}
			base.vmethod_1(bool_3);
			if (bool_3)
			{
				List<Class530> arg_49_0 = this.class911_0.list_2;
				if (action == null)
				{
					action = new Action<Class530>(this.method_9);
				}
				arg_49_0.ForEach(action);
				List<Class530> arg_6A_0 = this.class911_1.list_2;
				if (action2 == null)
				{
					action2 = new Action<Class530>(this.method_10);
				}
				arg_6A_0.ForEach(action2);
				List<Class530> arg_97_0 = this.class911_2.list_2;
				if (Class85.action_3 == null)
				{
					Class85.action_3 = new Action<Class530>(Class85.smethod_1);
				}
				arg_97_0.ForEach(Class85.action_3);
				this.class82_0.float_3 = 0f;
				return;
			}
			List<Class530> arg_C9_0 = this.class911_0.list_2;
			if (action3 == null)
			{
				action3 = new Action<Class530>(this.method_11);
			}
			arg_C9_0.ForEach(action3);
			List<Class530> arg_EA_0 = this.class911_1.list_2;
			if (action4 == null)
			{
				action4 = new Action<Class530>(this.method_12);
			}
			arg_EA_0.ForEach(action4);
			List<Class530> arg_117_0 = this.class911_2.list_2;
			if (Class85.action_4 == null)
			{
				Class85.action_4 = new Action<Class530>(Class85.smethod_2);
			}
			arg_117_0.ForEach(Class85.action_4);
			this.class82_0.float_3 = 0f;
		}
	}
}
