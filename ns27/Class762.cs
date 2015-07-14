using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns26;
using ns29;
using ns77;
using ns79;
using ns80;
using osu.Graphics.Sprites;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns27
{
	// Token: 0x0200059E RID: 1438
	internal sealed class Class762
	{
		// Token: 0x0200059F RID: 1439
		[CompilerGenerated]
		private sealed class Class763
		{
			// Token: 0x04002699 RID: 9881
			public bool bool_0;

			// Token: 0x06002E38 RID: 11832
			// RVA: 0x00022EAD File Offset: 0x000210AD
			public void method_0(Class531 class531_0)
			{
				class531_0.method_16(this.bool_0 ? 0 : 20, Enum70.const_0);
			}
		}

		// Token: 0x04002698 RID: 9880
		[CompilerGenerated]
		private static Action<Class531> action_0;

		// Token: 0x0400268D RID: 9869
		private bool bool_0;

		// Token: 0x04002693 RID: 9875
		private bool bool_1 = true;

		// Token: 0x04002692 RID: 9874
		internal Class531 class531_0;

		// Token: 0x04002691 RID: 9873
		internal Class533 class533_0;

		// Token: 0x0400268F RID: 9871
		private Class731 class731_0;

		// Token: 0x04002690 RID: 9872
		private Class731 class731_1;

		// Token: 0x04002696 RID: 9878
		private Delegate38 delegate38_0;

		// Token: 0x04002695 RID: 9877
		private float float_0;

		// Token: 0x0400268E RID: 9870
		internal List<Class531> list_0 = new List<Class531>();

		// Token: 0x04002697 RID: 9879
		[CompilerGenerated]
		private static Predicate<Class746> predicate_0;

		// Token: 0x04002694 RID: 9876
		private Vector2 vector2_0;

		// Token: 0x170003A3 RID: 931
		internal string Text
		{
			// Token: 0x06002E29 RID: 11817
			// RVA: 0x00022DBC File Offset: 0x00020FBC
			set
			{
				this.class533_0.Text = value;
			}
		}

		// Token: 0x06002E28 RID: 11816
		// RVA: 0x00022DA5 File Offset: 0x00020FA5
		internal Class762(string string_0, Vector2 vector2_1, float float_1, bool bool_2) : this(string_0, 1f, vector2_1, float_1, bool_2, 0f)
		{
		}

		// Token: 0x06002E2A RID: 11818
		// RVA: 0x0012B7A8 File Offset: 0x001299A8
		internal Class762(string string_0, float float_1, Vector2 vector2_1, float float_2, bool bool_2, float float_3)
		{
			this.vector2_0 = vector2_1;
			this.bool_0 = bool_2;
			this.float_0 = float_1;
			this.class731_0 = Class885.Load("circle-full", Enum112.flag_1);
			this.class731_1 = Class885.Load("circle-empty", Enum112.flag_1);
			this.class531_0 = new Class531(this.bool_0 ? this.class731_0 : this.class731_1, Enum115.const_5, Origins.Centre, Enum114.const_0, vector2_1 + new Vector2(8f, 8f), float_2, true, Class885.color_1, null);
			this.class531_0.bool_1 = true;
			this.class531_0.float_2 = float_1;
			this.class531_0.method_2(new EventHandler(this.method_5));
			this.class531_0.bool_2 = true;
			this.class533_0 = new Class533(string_0, 15f * float_1, vector2_1 + new Vector2(20f * float_1, 8f), new Vector2(Math.Max(0f, float_3 - 20f * float_1), 0f), float_2, true, Color.get_White(), true);
			this.class533_0.origins_0 = Origins.CentreLeft;
			this.class533_0.bool_2 = true;
			this.class533_0.bool_1 = true;
			this.class533_0.method_2(new EventHandler(this.method_5));
			this.list_0.Add(this.class531_0);
			this.list_0.Add(this.class533_0);
		}

		// Token: 0x06002E26 RID: 11814
		// RVA: 0x00022D9D File Offset: 0x00020F9D
		internal bool method_0()
		{
			return this.bool_1;
		}

		// Token: 0x06002E27 RID: 11815
		// RVA: 0x0012B6D0 File Offset: 0x001298D0
		internal void method_1(bool bool_2)
		{
			if (this.bool_1 == bool_2)
			{
				return;
			}
			this.bool_1 = bool_2;
			if (this.bool_1)
			{
				foreach (Class531 current in this.list_0)
				{
					current.color_0 = Color.get_White();
					current.bool_1 = true;
				}
				this.class531_0.color_0 = Class885.color_1;
				return;
			}
			foreach (Class531 current2 in this.list_0)
			{
				current2.color_0 = Color.get_Gray();
				current2.bool_1 = false;
			}
		}

		// Token: 0x06002E33 RID: 11827
		// RVA: 0x0012BA40 File Offset: 0x00129C40
		public void method_10(bool bool_2)
		{
			Class762.Class763 class = new Class762.Class763();
			class.bool_0 = bool_2;
			this.list_0.ForEach(new Action<Class531>(class.method_0));
		}

		// Token: 0x06002E34 RID: 11828
		// RVA: 0x00022E78 File Offset: 0x00021078
		public void method_11()
		{
			List<Class531> arg_23_0 = this.list_0;
			if (Class762.action_0 == null)
			{
				Class762.action_0 = new Action<Class531>(Class762.smethod_1);
			}
			arg_23_0.ForEach(Class762.action_0);
		}

		// Token: 0x06002E2B RID: 11819
		// RVA: 0x00022DCA File Offset: 0x00020FCA
		internal bool method_2()
		{
			return this.bool_0;
		}

		// Token: 0x06002E2C RID: 11820
		// RVA: 0x00022DD2 File Offset: 0x00020FD2
		internal void method_3(bool bool_2)
		{
			if (this.bool_0 != bool_2)
			{
				this.bool_0 = bool_2;
				this.method_7();
				if (this.delegate38_0 != null)
				{
					this.delegate38_0(this, this.method_2());
				}
			}
		}

		// Token: 0x06002E2D RID: 11821
		// RVA: 0x00022E04 File Offset: 0x00021004
		public void method_4(string string_0)
		{
			this.class533_0.string_0 = string_0;
			this.class531_0.string_0 = string_0;
		}

		// Token: 0x06002E2E RID: 11822
		// RVA: 0x00022E1E File Offset: 0x0002101E
		private void method_5(object sender, EventArgs e)
		{
			this.method_3(!this.method_2());
			Class331.smethod_59("check-" + (this.method_2() ? "on" : "off"), 100, Enum112.flag_5);
		}

		// Token: 0x06002E2F RID: 11823
		// RVA: 0x00022E56 File Offset: 0x00021056
		internal void method_6(bool bool_2)
		{
			if (this.bool_0 == bool_2)
			{
				return;
			}
			this.bool_0 = bool_2;
			this.method_7();
		}

		// Token: 0x06002E30 RID: 11824
		// RVA: 0x0012B930 File Offset: 0x00129B30
		private void method_7()
		{
			this.class531_0.vmethod_7(this.method_2() ? this.class731_0 : this.class731_1);
			List<Class746> arg_49_0 = this.class531_0.class26_0;
			if (Class762.predicate_0 == null)
			{
				Class762.predicate_0 = new Predicate<Class746>(Class762.smethod_0);
			}
			arg_49_0.RemoveAll(Class762.predicate_0);
			if (this.method_2())
			{
				this.class531_0.class26_0.Add(new Class746(TransformationType.Scale, this.float_0 * 1.2f, this.float_0, Class115.int_1, Class115.int_1 + 350, Enum70.const_1));
				return;
			}
			this.class531_0.class26_0.Add(new Class746(TransformationType.Scale, this.float_0 * 0.8f, this.float_0, Class115.int_1, Class115.int_1 + 350, Enum70.const_1));
		}

		// Token: 0x06002E31 RID: 11825
		// RVA: 0x0012BA08 File Offset: 0x00129C08
		internal void method_8(Delegate38 delegate38_1)
		{
			Delegate38 delegate = this.delegate38_0;
			Delegate38 delegate2;
			do
			{
				delegate2 = delegate;
				Delegate38 value = (Delegate38)Delegate.Combine(delegate2, delegate38_1);
				delegate = Interlocked.CompareExchange<Delegate38>(ref this.delegate38_0, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x06002E32 RID: 11826
		// RVA: 0x00022E6F File Offset: 0x0002106F
		public void method_9()
		{
			this.method_10(false);
		}

		// Token: 0x06002E35 RID: 11829
		// RVA: 0x00018A5A File Offset: 0x00016C5A
		[CompilerGenerated]
		private static bool smethod_0(Class746 class746_0)
		{
			return class746_0.transformationType_0 == TransformationType.Scale;
		}

		// Token: 0x06002E36 RID: 11830
		// RVA: 0x00022EA2 File Offset: 0x000210A2
		[CompilerGenerated]
		private static void smethod_1(Class531 class531_1)
		{
			class531_1.method_14(20, Enum70.const_0);
		}
	}
}
