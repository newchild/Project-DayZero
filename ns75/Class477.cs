using ns14;
using ns26;
using ns79;
using ns89;
using osu.GameplayElements.Events;
using System;

namespace ns75
{
	// Token: 0x0200040B RID: 1035
	internal abstract class Class477
	{
		// Token: 0x04001A10 RID: 6672
		private TriggerGroup triggerGroup_0;

		// Token: 0x0600212C RID: 8492
		// RVA: 0x000C0508 File Offset: 0x000BE708
		internal static Class477 Create(string string_0)
		{
			TriggerGroup triggerGroup;
			if (Class558.smethod_0<TriggerGroup>(string_0, ref triggerGroup))
			{
				int length = triggerGroup.ToString().Length;
				string string_ = string_0.Substring(length, string_0.Length - length);
				switch (triggerGroup)
				{
				case TriggerGroup.HitSound:
					return new Class478(string_);
				case TriggerGroup.Passing:
					return new Class480(string_);
				case TriggerGroup.Failing:
					return new Class479(string_);
				case TriggerGroup.HitObjectHit:
					return new Class481(string_);
				}
			}
			throw new Exception(string_0 + " isn't a valid trigger name");
		}

		// Token: 0x06002125 RID: 8485
		// RVA: 0x0001AE08 File Offset: 0x00019008
		internal bool method_0()
		{
			return this.triggerGroup_0 != TriggerGroup.None;
		}

		// Token: 0x06002126 RID: 8486
		// RVA: 0x0001AE16 File Offset: 0x00019016
		internal TriggerGroup method_1()
		{
			if (this.method_0())
			{
				return this.triggerGroup_0;
			}
			return this.vmethod_0();
		}

		// Token: 0x06002129 RID: 8489
		// RVA: 0x000C0494 File Offset: 0x000BE694
		protected void method_2(Class702 class702_0, Class744 class744_0, Class531 class531_0, bool bool_0)
		{
			if (bool_0)
			{
				class702_0.method_1(this.method_1());
			}
			if (class744_0.int_2 != 0 && (Class331.int_7 < class744_0.int_3 || Class331.int_7 > class744_0.int_2))
			{
				return;
			}
			if (!bool_0)
			{
				if (this.method_0())
				{
					class702_0.method_1(this.method_1());
				}
				else
				{
					class702_0.method_2(class744_0);
				}
			}
			class744_0.int_1 = Class331.int_7;
			class531_0.method_11(class744_0);
		}

		// Token: 0x0600212A RID: 8490
		// RVA: 0x0001AE2D File Offset: 0x0001902D
		internal void method_3(TriggerGroup triggerGroup_1)
		{
			if (triggerGroup_1 > TriggerGroup.None)
			{
				throw new InvalidOperationException("Invalid trigger group");
			}
			if (this.triggerGroup_0 != TriggerGroup.None)
			{
				throw new InvalidOperationException("A trigger's group can't be changed once set");
			}
			this.triggerGroup_0 = triggerGroup_1;
		}

		// Token: 0x0600212B RID: 8491
		// RVA: 0x0001AE58 File Offset: 0x00019058
		public override string ToString()
		{
			return this.vmethod_0().ToString();
		}

		// Token: 0x06002127 RID: 8487
		internal abstract TriggerGroup vmethod_0();

		// Token: 0x06002128 RID: 8488
		internal abstract void vmethod_1(Class702 class702_0, Class744 class744_0, Class531 class531_0);
	}
}
