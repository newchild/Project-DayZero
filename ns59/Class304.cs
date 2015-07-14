using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns23;
using ns26;
using ns29;
using ns70;
using ns79;
using osu;
using osu.Audio;
using osu.GameplayElements.HitObjects;
using osu.Graphics.Sprites;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns59
{
	// Token: 0x0200041D RID: 1053
	internal abstract class Class304 : HitObjectBase, IDisposable, IComparable<Class304>, IComparable<int>
	{
		// Token: 0x04001A7E RID: 6782
		[CompilerGenerated]
		private static Action<Class531> action_0;

		// Token: 0x04001A80 RID: 6784
		[CompilerGenerated]
		private static Action<Class531> action_1;

		// Token: 0x04001A68 RID: 6760
		internal bool bool_0;

		// Token: 0x04001A69 RID: 6761
		private bool bool_1;

		// Token: 0x04001A6B RID: 6763
		internal bool bool_2;

		// Token: 0x04001A72 RID: 6770
		internal bool bool_3;

		// Token: 0x04001A79 RID: 6777
		internal bool bool_4;

		// Token: 0x04001A7A RID: 6778
		public bool bool_5 = true;

		// Token: 0x04001A6F RID: 6767
		internal Class297 class297_0;

		// Token: 0x04001A6A RID: 6762
		internal double double_0;

		// Token: 0x04001A78 RID: 6776
		internal Enum38 enum38_0;

		// Token: 0x04001A6C RID: 6764
		internal int int_0;

		// Token: 0x04001A6D RID: 6765
		internal int int_1;

		// Token: 0x04001A73 RID: 6771
		internal int int_2 = -1;

		// Token: 0x04001A75 RID: 6773
		internal int int_3;

		// Token: 0x04001A7B RID: 6779
		public int int_4;

		// Token: 0x04001A7C RID: 6780
		public int int_5;

		// Token: 0x04001A70 RID: 6768
		protected internal List<Class531> list_0 = new List<Class531>();

		// Token: 0x04001A71 RID: 6769
		internal List<Class531> list_1 = new List<Class531>();

		// Token: 0x04001A7D RID: 6781
		[CompilerGenerated]
		private static Predicate<Class746> predicate_0;

		// Token: 0x04001A7F RID: 6783
		[CompilerGenerated]
		private static Predicate<Class746> predicate_1;

		// Token: 0x04001A81 RID: 6785
		[CompilerGenerated]
		private static Predicate<Class746> predicate_2;

		// Token: 0x04001A76 RID: 6774
		internal SampleSet sampleSet_0;

		// Token: 0x04001A77 RID: 6775
		internal SampleSet sampleSet_1;

		// Token: 0x04001A74 RID: 6772
		internal string string_0;

		// Token: 0x04001A6E RID: 6766
		public Vector2 vector2_0;

		// Token: 0x060021C0 RID: 8640
		// RVA: 0x0001B2B9 File Offset: 0x000194B9
		protected Class304(Class297 class297_1)
		{
			this.class297_0 = class297_1;
		}

		// Token: 0x060021C9 RID: 8649
		internal abstract Class304 Clone();

		// Token: 0x060021DD RID: 8669
		// RVA: 0x000C8458 File Offset: 0x000C6658
		public int CompareTo(Class304 obj)
		{
			if (this is Class330 || obj is Class330)
			{
				return this.EndTime.CompareTo(obj.EndTime);
			}
			if (this.StartTime == obj.StartTime)
			{
				return obj.NewCombo.CompareTo(this.NewCombo);
			}
			return this.StartTime.CompareTo(obj.StartTime);
		}

		// Token: 0x060021E1 RID: 8673
		// RVA: 0x0001B408 File Offset: 0x00019608
		public int CompareTo(int obj)
		{
			return this.EndTime.CompareTo(obj);
		}

		// Token: 0x060021C7 RID: 8647
		// RVA: 0x0001B31B File Offset: 0x0001951B
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060021C8 RID: 8648
		// RVA: 0x0000653E File Offset: 0x0000473E
		protected virtual void Dispose(bool bool_6)
		{
		}

		// Token: 0x060021D2 RID: 8658
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal virtual void Draw()
		{
		}

		// Token: 0x060021C1 RID: 8641
		// RVA: 0x000C8144 File Offset: 0x000C6344
		~Class304()
		{
			this.Dispose(false);
		}

		// Token: 0x060021BE RID: 8638
		// RVA: 0x0001B27D File Offset: 0x0001947D
		public Vector2 method_0()
		{
			return this.EndPosition - (this.Position - this.vector2_0);
		}

		// Token: 0x060021BF RID: 8639
		// RVA: 0x0001B29B File Offset: 0x0001949B
		internal Vector2 method_1()
		{
			return this.vmethod_10() - (this.Position - this.vector2_0);
		}

		// Token: 0x060021C2 RID: 8642
		// RVA: 0x0001B2EC File Offset: 0x000194EC
		internal bool method_2()
		{
			return this.bool_1;
		}

		// Token: 0x060021C3 RID: 8643
		// RVA: 0x0001B2F4 File Offset: 0x000194F4
		internal void method_3(bool bool_6)
		{
			if (this.bool_1 != bool_6)
			{
				this.bool_1 = bool_6;
				if (this.bool_1)
				{
					this.Select();
					return;
				}
				this.vmethod_3();
			}
		}

		// Token: 0x060021CE RID: 8654
		// RVA: 0x0001B344 File Offset: 0x00019544
		internal void method_4()
		{
			this.vmethod_5(this.vector2_0, true);
			this.StackCount = 0;
		}

		// Token: 0x060021D6 RID: 8662
		// RVA: 0x000C82D8 File Offset: 0x000C64D8
		internal void method_5(string string_1)
		{
			if (this.class297_0.class911_0 != null && !string.IsNullOrEmpty(string_1) && !Class331.bool_3)
			{
				this.string_0 = string_1;
				bool bool_ = false;
				if (base.IsType(HitObjectType.Slider) && string_1.IndexOf("slider") > 0 && string_1.IndexOf("tick") == -1)
				{
					bool_ = true;
				}
				this.int_2 = Class331.smethod_38(string_1, bool_, false, false);
				return;
			}
			this.int_2 = -1;
		}

		// Token: 0x060021D7 RID: 8663
		// RVA: 0x000C8348 File Offset: 0x000C6548
		internal void method_6(Class340 class340_0, HitObjectSoundType hitObjectSoundType_0, SampleSet sampleSet_2, SampleSet sampleSet_3)
		{
			SampleSet sampleSet = (sampleSet_2 == SampleSet.None) ? class340_0.sampleSet_0 : sampleSet_2;
			Enum38 enum38_ = (this.enum38_0 == Enum38.const_0) ? class340_0.enum38_0 : this.enum38_0;
			int int_ = (this.int_3 != 0) ? this.int_3 : class340_0.int_0;
			Struct69 struct69_ = Struct69.smethod_0(hitObjectSoundType_0, sampleSet, enum38_, int_, (sampleSet == SampleSet.None) ? sampleSet : sampleSet_3);
			Class297.smethod_5(struct69_);
			if (this.int_2 != -1)
			{
				Class331.smethod_61(this.int_2, int_, this.vmethod_14(), true, 1f);
				return;
			}
			Class331.smethod_62(struct69_, this.vmethod_14(), true);
		}

		// Token: 0x060021EA RID: 8682
		// RVA: 0x0001B4A3 File Offset: 0x000196A3
		[CompilerGenerated]
		private bool method_7(Class746 class746_0)
		{
			return class746_0.transformationType_0 == TransformationType.Movement && this.int_4 == 123;
		}

		// Token: 0x060021CA RID: 8650
		internal abstract void Select();

		// Token: 0x060021E5 RID: 8677
		// RVA: 0x0001B423 File Offset: 0x00019623
		[CompilerGenerated]
		private static bool smethod_0(Class746 class746_0)
		{
			return class746_0.transformationType_0 == TransformationType.Colour && class746_0.byte_0 == 147;
		}

		// Token: 0x060021E6 RID: 8678
		// RVA: 0x0001B43E File Offset: 0x0001963E
		[CompilerGenerated]
		private static void smethod_1(Class531 class531_0)
		{
			List<Class746> arg_23_0 = class531_0.class26_0;
			if (Class304.predicate_1 == null)
			{
				Class304.predicate_1 = new Predicate<Class746>(Class304.smethod_2);
			}
			arg_23_0.RemoveAll(Class304.predicate_1);
		}

		// Token: 0x060021E7 RID: 8679
		// RVA: 0x0001B469 File Offset: 0x00019669
		[CompilerGenerated]
		private static bool smethod_2(Class746 class746_0)
		{
			return class746_0.byte_0 == 148;
		}

		// Token: 0x060021E8 RID: 8680
		// RVA: 0x0001B478 File Offset: 0x00019678
		[CompilerGenerated]
		private static void smethod_3(Class531 class531_0)
		{
			List<Class746> arg_23_0 = class531_0.class26_0;
			if (Class304.predicate_2 == null)
			{
				Class304.predicate_2 = new Predicate<Class746>(Class304.smethod_4);
			}
			arg_23_0.RemoveAll(Class304.predicate_2);
		}

		// Token: 0x060021E9 RID: 8681
		// RVA: 0x0001B469 File Offset: 0x00019669
		[CompilerGenerated]
		private static bool smethod_4(Class746 class746_0)
		{
			return class746_0.byte_0 == 148;
		}

		// Token: 0x060021C4 RID: 8644
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal virtual void vmethod_0(Color color_0)
		{
		}

		// Token: 0x060021C5 RID: 8645
		// RVA: 0x000C8174 File Offset: 0x000C6374
		internal virtual void vmethod_1()
		{
			if (Class115.osuModes_1 == OsuModes.Edit)
			{
				return;
			}
			Color color;
			color..ctor((byte)Math.Max(0f, (float)this.Colour.get_R() * 0.75f), (byte)Math.Max(0f, (float)this.Colour.get_G() * 0.75f), (byte)Math.Max(0f, (float)this.Colour.get_B() * 0.75f), 255);
			Color color2;
			color2..ctor(195, 195, 195, 255);
			Color white = Color.get_White();
			foreach (Class531 current in this.list_0)
			{
				List<Class746> arg_CB_0 = current.class26_0;
				if (Class304.predicate_0 == null)
				{
					Class304.predicate_0 = new Predicate<Class746>(Class304.smethod_0);
				}
				arg_CB_0.RemoveAll(Class304.predicate_0);
				Class746 class = new Class746((current.int_0 == 0) ? color2 : color, (current.int_0 == 0) ? white : this.Colour, this.StartTime - 400, this.StartTime - 300);
				if (class != null)
				{
					class.byte_0 = 147;
				}
				current.class26_0.Add(class);
			}
		}

		// Token: 0x060021D4 RID: 8660
		// RVA: 0x0001492A File Offset: 0x00012B2A
		internal virtual Vector2 vmethod_10()
		{
			return this.Position;
		}

		// Token: 0x060021D5 RID: 8661
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal virtual void vmethod_11(Vector2 vector2_1)
		{
		}

		// Token: 0x060021D8 RID: 8664
		// RVA: 0x000C83D8 File Offset: 0x000C65D8
		internal virtual void vmethod_12()
		{
			Class340 class = this.class297_0.class296_0.method_39((double)(this.StartTime + 5));
			if (class == null)
			{
				return;
			}
			this.method_6(class, this.SoundType, this.sampleSet_0, this.sampleSet_1);
		}

		// Token: 0x060021D9 RID: 8665
		// RVA: 0x000C841C File Offset: 0x000C661C
		internal virtual List<Class531> vmethod_13()
		{
			if (this.list_0.Count <= 0)
			{
				return new List<Class531>();
			}
			return new List<Class531>
			{
				this.list_0[0]
			};
		}

		// Token: 0x060021DA RID: 8666
		// RVA: 0x0001B3D9 File Offset: 0x000195D9
		protected virtual float vmethod_14()
		{
			return (this.Position.X / 512f - 0.5f) * 0.8f;
		}

		// Token: 0x060021DB RID: 8667
		// RVA: 0x0001B3F8 File Offset: 0x000195F8
		internal virtual int vmethod_15()
		{
			return this.EndTime;
		}

		// Token: 0x060021DC RID: 8668
		// RVA: 0x0001B400 File Offset: 0x00019600
		internal virtual int vmethod_16()
		{
			return this.StartTime;
		}

		// Token: 0x060021DE RID: 8670
		internal abstract Enum61 vmethod_17(Vector2 vector2_1);

		// Token: 0x060021DF RID: 8671
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal virtual void vmethod_18()
		{
		}

		// Token: 0x060021E0 RID: 8672
		internal abstract void vmethod_19(int int_6);

		// Token: 0x060021C6 RID: 8646
		internal abstract Enum61 vmethod_2();

		// Token: 0x060021E2 RID: 8674
		// RVA: 0x000C84BC File Offset: 0x000C66BC
		internal virtual bool vmethod_20(Vector2 vector2_1, bool bool_6, float float_0)
		{
			return ((!bool_6 && this.vmethod_9()) || (this.StartTime - this.class297_0.PreEmpt <= Class331.int_7 && this.StartTime + this.class297_0.HitWindow50 >= Class331.int_7 && !this.bool_0)) && (Vector2.DistanceSquared(vector2_1, this.Position) <= float_0 * float_0 || (!bool_6 && Vector2.DistanceSquared(vector2_1, this.vmethod_10()) <= float_0 * float_0));
		}

		// Token: 0x060021E3 RID: 8675
		// RVA: 0x000C853C File Offset: 0x000C673C
		internal virtual void vmethod_21()
		{
			Predicate<Class746> predicate = null;
			foreach (Class531 current in this.list_1)
			{
				List<Class746> arg_38_0 = current.class26_0;
				if (predicate == null)
				{
					predicate = new Predicate<Class746>(this.method_7);
				}
				arg_38_0.RemoveAll(predicate);
				Vector2 vector = this.vmethod_10();
				current.class26_0.Add(new Class746(vector, vector + new Vector2(8f, 0f), Class331.int_7, Class331.int_7 + 20, Enum70.const_0)
				{
					byte_0 = 123
				});
				current.class26_0.Add(new Class746(vector + new Vector2(8f, 0f), vector - new Vector2(8f, 0f), Class331.int_7 + 20, Class331.int_7 + 40, Enum70.const_0)
				{
					byte_0 = 123
				});
				current.class26_0.Add(new Class746(vector - new Vector2(8f, 0f), vector + new Vector2(8f, 0f), Class331.int_7 + 40, Class331.int_7 + 60, Enum70.const_0)
				{
					byte_0 = 123
				});
				current.class26_0.Add(new Class746(vector + new Vector2(8f, 0f), vector - new Vector2(8f, 0f), Class331.int_7 + 60, Class331.int_7 + 80, Enum70.const_0)
				{
					byte_0 = 123
				});
				current.class26_0.Add(new Class746(vector + new Vector2(8f, 0f), vector - new Vector2(8f, 0f), Class331.int_7 + 80, Class331.int_7 + 100, Enum70.const_0)
				{
					byte_0 = 123
				});
				current.class26_0.Add(new Class746(vector + new Vector2(8f, 0f), vector, Class331.int_7 + 100, Class331.int_7 + 120, Enum70.const_0)
				{
					byte_0 = 123
				});
			}
		}

		// Token: 0x060021E4 RID: 8676
		// RVA: 0x0001B416 File Offset: 0x00019616
		protected virtual int vmethod_22()
		{
			return this.class297_0.PreEmpt;
		}

		// Token: 0x060021CB RID: 8651
		internal abstract void vmethod_3();

		// Token: 0x060021CC RID: 8652
		internal abstract void vmethod_4(int int_6);

		// Token: 0x060021CD RID: 8653
		// RVA: 0x0001B32A File Offset: 0x0001952A
		internal virtual void vmethod_5(Vector2 vector2_1, bool bool_6)
		{
			this.Position = vector2_1;
			if (!bool_6)
			{
				this.vector2_0 = vector2_1;
				this.StackCount = 0;
			}
		}

		// Token: 0x060021CF RID: 8655
		// RVA: 0x0001B35A File Offset: 0x0001955A
		internal virtual void vmethod_6()
		{
			if (Class331.smethod_71() && this.bool_0 && Class331.int_7 < this.StartTime)
			{
				this.vmethod_7();
			}
		}

		// Token: 0x060021D0 RID: 8656
		// RVA: 0x0001B37E File Offset: 0x0001957E
		internal virtual void vmethod_7()
		{
			List<Class531> arg_23_0 = this.list_1;
			if (Class304.action_0 == null)
			{
				Class304.action_0 = new Action<Class531>(Class304.smethod_1);
			}
			arg_23_0.ForEach(Class304.action_0);
			this.bool_0 = false;
		}

		// Token: 0x060021D1 RID: 8657
		// RVA: 0x0001B3AF File Offset: 0x000195AF
		internal virtual void vmethod_8(bool bool_6)
		{
			List<Class531> arg_23_0 = this.list_1;
			if (Class304.action_1 == null)
			{
				Class304.action_1 = new Action<Class531>(Class304.smethod_3);
			}
			arg_23_0.ForEach(Class304.action_1);
		}

		// Token: 0x060021D3 RID: 8659
		internal abstract bool vmethod_9();
	}
}
