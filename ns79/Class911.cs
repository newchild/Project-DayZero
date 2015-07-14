using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns26;
using ns29;
using ns77;
using ns8;
using ns81;
using ns82;
using ns84;
using ns91;
using osu.Graphics.OpenGl;
using osu.Graphics.Primitives;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns79
{
	// Token: 0x020006B5 RID: 1717
	internal sealed class Class911 : IDisposable
	{
		// Token: 0x020006B6 RID: 1718
		[CompilerGenerated]
		private sealed class Class912
		{
			// Token: 0x040031DD RID: 12765
			public object object_0;

			// Token: 0x0600359E RID: 13726
			// RVA: 0x0002725D File Offset: 0x0002545D
			public bool method_0(Class530 class530_0)
			{
				return class530_0.object_0 != null && class530_0.object_0.Equals(this.object_0);
			}
		}

		// Token: 0x020006B7 RID: 1719
		[CompilerGenerated]
		private sealed class Class913
		{
			// Token: 0x040031DE RID: 12766
			public object object_0;

			// Token: 0x060035A0 RID: 13728
			// RVA: 0x0002727A File Offset: 0x0002547A
			public bool method_0(Class530 class530_0)
			{
				return class530_0.object_0 != null && class530_0.object_0.Equals(this.object_0);
			}
		}

		// Token: 0x020006B8 RID: 1720
		[CompilerGenerated]
		private sealed class Class914
		{
			// Token: 0x040031E0 RID: 12768
			public Class911 class911_0;

			// Token: 0x040031DF RID: 12767
			public int int_0;

			// Token: 0x060035A2 RID: 13730
			// RVA: 0x00027297 File Offset: 0x00025497
			public void method_0(Class530 class530_0)
			{
				class530_0.class26_0.ForEach(new Action<Class746>(this.method_1));
			}

			// Token: 0x060035A3 RID: 13731
			// RVA: 0x0016F2B4 File Offset: 0x0016D4B4
			public void method_1(Class746 class746_0)
			{
				if (class746_0.int_0 - this.class911_0.int_0 > 5000)
				{
					return;
				}
				class746_0.int_0 += this.int_0;
				class746_0.int_1 += this.int_0;
			}
		}

		// Token: 0x040031DA RID: 12762
		[CompilerGenerated]
		private static Action<Class530> action_0;

		// Token: 0x040031DC RID: 12764
		[CompilerGenerated]
		private static Action<Class911> action_1;

		// Token: 0x040031AF RID: 12719
		internal bool bool_0;

		// Token: 0x040031B3 RID: 12723
		internal bool bool_1 = true;

		// Token: 0x040031D1 RID: 12753
		private bool bool_10;

		// Token: 0x040031D2 RID: 12754
		private bool bool_11;

		// Token: 0x040031D4 RID: 12756
		internal bool bool_12;

		// Token: 0x040031D6 RID: 12758
		private bool bool_13;

		// Token: 0x040031D7 RID: 12759
		internal bool bool_14;

		// Token: 0x040031D8 RID: 12760
		private static bool bool_15;

		// Token: 0x040031D9 RID: 12761
		private bool bool_16;

		// Token: 0x040031B4 RID: 12724
		internal bool bool_2;

		// Token: 0x040031B8 RID: 12728
		private bool bool_3;

		// Token: 0x040031B9 RID: 12729
		internal bool bool_4;

		// Token: 0x040031BA RID: 12730
		private bool bool_5;

		// Token: 0x040031BF RID: 12735
		internal bool bool_6 = true;

		// Token: 0x040031C1 RID: 12737
		internal bool bool_7;

		// Token: 0x040031C2 RID: 12738
		internal bool bool_8 = true;

		// Token: 0x040031CD RID: 12749
		internal bool bool_9;

		// Token: 0x040031AA RID: 12714
		internal static Class531 class531_0;

		// Token: 0x040031C0 RID: 12736
		internal Class531 class531_1;

		// Token: 0x040031AD RID: 12717
		private readonly Class745 class745_0 = new Class745();

		// Token: 0x040031D0 RID: 12752
		internal static Class911 class911_0;

		// Token: 0x040031AE RID: 12718
		internal float float_0 = 1f;

		// Token: 0x040031B0 RID: 12720
		internal float float_1;

		// Token: 0x040031B1 RID: 12721
		internal float float_2;

		// Token: 0x040031B6 RID: 12726
		public float float_3 = 1f;

		// Token: 0x040031B7 RID: 12727
		internal float float_4;

		// Token: 0x040031CE RID: 12750
		internal float float_5 = -1f;

		// Token: 0x040031B2 RID: 12722
		internal int int_0 = Class115.int_1;

		// Token: 0x040031BB RID: 12731
		private int int_1;

		// Token: 0x040031CF RID: 12751
		internal static int int_2;

		// Token: 0x040031D3 RID: 12755
		internal int int_3;

		// Token: 0x040031AC RID: 12716
		internal static List<Class911> list_0 = new List<Class911>();

		// Token: 0x040031BC RID: 12732
		private readonly List<Class530> list_1 = new List<Class530>();

		// Token: 0x040031C3 RID: 12739
		internal List<Class530> list_2;

		// Token: 0x040031B5 RID: 12725
		internal long long_0;

		// Token: 0x040031AB RID: 12715
		internal static object object_0 = new object();

		// Token: 0x040031DB RID: 12763
		[CompilerGenerated]
		private static Predicate<Class530> predicate_0;

		// Token: 0x040031BE RID: 12734
		private readonly Queue<Class530> queue_0 = new Queue<Class530>();

		// Token: 0x040031C6 RID: 12742
		internal static RectangleF rectangleF_0 = new RectangleF(0f, 0f, (float)Class115.int_20, (float)Class115.int_19);

		// Token: 0x040031C8 RID: 12744
		internal static RectangleF rectangleF_1 = new RectangleF(0f, 0f, (float)Class115.int_20, (float)Class115.int_19);

		// Token: 0x040031CA RID: 12746
		internal RectangleF rectangleF_2 = new RectangleF(0f, 0f, (float)Class115.int_20, (float)Class115.int_19);

		// Token: 0x040031CB RID: 12747
		internal RectangleF rectangleF_3;

		// Token: 0x040031C7 RID: 12743
		internal static Rectangle rectangle_0 = new Rectangle(0, 0, Class115.int_22, Class115.int_22);

		// Token: 0x040031CC RID: 12748
		internal Rectangle rectangle_1;

		// Token: 0x040031D5 RID: 12757
		private SpriteBlendMode spriteBlendMode_0;

		// Token: 0x040031BD RID: 12733
		private readonly Stack<Class530> stack_0 = new Stack<Class530>();

		// Token: 0x040031C4 RID: 12740
		internal Vector2 vector2_0 = Vector2.get_Zero();

		// Token: 0x040031C5 RID: 12741
		internal Vector2 vector2_1 = Vector2.get_Zero();

		// Token: 0x040031C9 RID: 12745
		internal Vector2 vector2_2 = Vector2.get_Zero();

		// Token: 0x06003572 RID: 13682
		// RVA: 0x00027131 File Offset: 0x00025331
		internal Class911() : this(false)
		{
		}

		// Token: 0x06003575 RID: 13685
		// RVA: 0x0016DF00 File Offset: 0x0016C100
		internal Class911(bool bool_17)
		{
			Class911.int_2++;
			this.list_2 = new List<Class530>();
			Class911.list_0.Add(this);
			this.method_4(bool_17, null);
			Class115.smethod_50(new Delegate1(this.method_7));
			Class115.smethod_18(new VoidDelegate(this.method_5));
		}

		// Token: 0x0600357D RID: 13693
		// RVA: 0x0016E13C File Offset: 0x0016C33C
		internal void Add(Class530 class530_0)
		{
			if (class530_0 == null)
			{
				return;
			}
			if (!this.method_0() || class530_0.class26_0.Count <= 0)
			{
				lock (Class911.object_0)
				{
					int num = this.list_2.BinarySearch(class530_0, this.class745_0);
					this.list_2.Insert((num < 0) ? (~num) : num, class530_0);
				}
				return;
			}
			int num2 = this.list_1.BinarySearch(class530_0);
			if (num2 < 0)
			{
				this.list_1.Insert(~num2, class530_0);
				return;
			}
			this.list_1.Insert(num2, class530_0);
		}

		// Token: 0x0600357F RID: 13695
		// RVA: 0x0016E224 File Offset: 0x0016C424
		internal void Add<T>(IEnumerable<T> ienumerable_0) where T : Class530
		{
			foreach (T current in ienumerable_0)
			{
				this.Add(current);
			}
		}

		// Token: 0x06003580 RID: 13696
		// RVA: 0x0016E274 File Offset: 0x0016C474
		internal void Clear(bool bool_17)
		{
			this.method_8();
			lock (Class911.object_0)
			{
				if (bool_17)
				{
					for (int i = 0; i < this.list_2.Count; i++)
					{
						this.list_2[i].Dispose();
					}
				}
				this.list_2.Clear();
				if (bool_17)
				{
					using (Queue<Class530>.Enumerator enumerator = this.queue_0.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							Class531 class = (Class531)enumerator.Current;
							class.Dispose();
						}
					}
				}
				this.queue_0.Clear();
				if (bool_17)
				{
					for (int j = 0; j < this.list_1.Count; j++)
					{
						this.list_1[j].Dispose();
					}
				}
				this.list_1.Clear();
				if (bool_17)
				{
					while (this.stack_0.Count > 0)
					{
						this.stack_0.Pop().Dispose();
					}
				}
				this.stack_0.Clear();
			}
		}

		// Token: 0x06003578 RID: 13688
		// RVA: 0x0002717D File Offset: 0x0002537D
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06003579 RID: 13689
		// RVA: 0x0016E018 File Offset: 0x0016C218
		private void Dispose(bool bool_17)
		{
			if (this.bool_11)
			{
				return;
			}
			this.bool_11 = true;
			Class911.int_2--;
			this.Clear(true);
			Class911.list_0.Remove(this);
			Class115.smethod_51(new Delegate1(this.method_7));
			Class115.smethod_19(new VoidDelegate(this.method_5));
		}

		// Token: 0x06003586 RID: 13702
		// RVA: 0x0016E6D0 File Offset: 0x0016C8D0
		internal bool Draw()
		{
			lock (Class911.object_0)
			{
				if (this.bool_1)
				{
					this.method_15();
				}
				int num = this.list_2.Count;
				this.int_3 = 0;
				if (this.bool_3)
				{
					this.rectangleF_3 = new RectangleF((float)Math.Floor((double)((float)(this.bool_8 ? Class115.int_26 : 0) + this.rectangleF_2.X * Class115.float_4)), (float)Math.Floor((double)(this.rectangleF_2.Y * Class115.float_4 + (float)Class115.int_25)), (float)Math.Ceiling((double)(this.rectangleF_2.Width * Class115.float_4)), (float)Math.Ceiling((double)(this.rectangleF_2.Height * Class115.float_4)));
				}
				else if (this.bool_8)
				{
					this.rectangleF_3 = new RectangleF((float)Class115.int_26 + Class911.rectangleF_1.X * Class115.float_4, Class911.rectangleF_1.Y * Class115.float_4 + (float)Class115.int_25, Class911.rectangleF_1.Width * Class115.float_4, Class911.rectangleF_1.Height * Class115.float_4);
				}
				else
				{
					this.rectangleF_3 = new RectangleF(Class911.rectangleF_0.X * Class115.float_4, Class911.rectangleF_0.Y * Class115.float_4 + (float)Class115.int_25, Class911.rectangleF_0.Width * Class115.float_4, Class911.rectangleF_0.Height * Class115.float_4);
				}
				this.rectangle_1 = new Rectangle((int)this.rectangleF_3.X, (int)this.rectangleF_3.Y, (int)Math.Ceiling((double)this.rectangleF_3.Width), (int)Math.Ceiling((double)this.rectangleF_3.Height));
				if (num == 0 && !this.bool_4)
				{
					bool result = false;
					return result;
				}
				if (this.float_0 < 0.01f || this.bool_0)
				{
					for (int i = 0; i < num; i++)
					{
						this.list_2[i].bool_3 = false;
					}
					bool result = false;
					return result;
				}
				this.long_0 = (long)Class115.int_1;
				if (this.float_5 >= 0f)
				{
					if (this.float_5 > this.float_1)
					{
						this.float_1 = Math.Min(this.float_5, this.float_1 + 0.018f * (float)Class115.double_0);
					}
					else if (this.float_5 < this.float_1)
					{
						this.float_1 = Math.Max(this.float_5, this.float_1 - 0.018f * (float)Class115.double_0);
					}
				}
				int num2 = Class115.int_1;
				int int_ = Class331.int_7;
				if (this.bool_4)
				{
					while (this.queue_0.Count > 0)
					{
						Class530 class = this.queue_0.Peek();
						if (class.class26_0.Count > 0 && class.class26_0[0].int_0 > ((class.enum114_0 == Enum114.const_0) ? num2 : int_))
						{
							break;
						}
						if (class.class26_0.Count == 0)
						{
							this.queue_0.Dequeue().Dispose();
						}
						else
						{
							this.Add(this.queue_0.Dequeue());
							num++;
						}
					}
					if (Class331.bool_2)
					{
						while (this.stack_0.Count > 0)
						{
							Class530 class2 = this.stack_0.Peek();
							if (class2.class26_0.Count > 0)
							{
								int num3 = class2.class26_0[class2.class26_0.Count - 1].int_1;
								if (num3 < int_ && int_ - num3 > 5000)
								{
									break;
								}
							}
							class2 = this.stack_0.Pop();
							this.Add(class2);
							num++;
						}
					}
				}
				int num4 = Math.Max(1, num / 4096);
				this.method_21(false);
				try
				{
					bool flag = true;
					Rectangle rectangle = this.bool_7 ? this.rectangle_1 : Class911.rectangle_0;
					if (Class115.bool_26)
					{
						Class115.spriteBatch_0.get_GraphicsDevice().set_ScissorRectangle(rectangle);
					}
					if (Class115.bool_27)
					{
						Gl.glScissor(rectangle.get_Left(), Class115.int_23 - rectangle.get_Bottom(), rectangle.Width, rectangle.Height);
					}
					for (int j = 0; j < num; j++)
					{
						Class530 class3 = this.list_2[j];
						if (!class3.bool_5 && (class3.bool_3 || (j + Class115.int_1) % num4 == 0))
						{
							switch (class3.vmethod_3())
							{
							case Enum51.const_0:
								if (!class3.vmethod_0())
								{
									this.method_22(false);
								}
								if (Class115.bool_26)
								{
									if (Class115.spriteBatch_0.get_GraphicsDevice().get_ScissorRectangle() != class3.method_3())
									{
										if (class3.vmethod_0() && !flag)
										{
											this.method_22(false);
											this.method_21(false);
										}
										Class115.spriteBatch_0.get_GraphicsDevice().set_ScissorRectangle(class3.method_3());
									}
								}
								else if (rectangle != class3.method_3())
								{
									rectangle = class3.method_3();
									Gl.glScissor(rectangle.get_Left(), Class115.int_23 - rectangle.get_Bottom(), rectangle.Width, rectangle.Height);
								}
								class3.Draw();
								flag = false;
								break;
							case Enum51.const_2:
								this.list_2.RemoveAt(j--);
								num--;
								if (this.bool_4 && class3.enum114_0 != Enum114.const_0 && this.bool_12)
								{
									this.stack_0.Push(class3);
								}
								else
								{
									class3.Dispose();
								}
								break;
							}
						}
					}
					if (this.bool_13)
					{
						this.method_20(false);
					}
					this.method_22(true);
					this.int_1 = 0;
				}
				catch (Exception ex)
				{
					try
					{
						this.method_22(true);
					}
					catch
					{
					}
					Class115.smethod_95();
					if (!(ex is InvalidOperationException) || ++this.int_1 > 1)
					{
						throw;
					}
				}
			}
			return true;
		}

		// Token: 0x0600356F RID: 13679
		// RVA: 0x00027104 File Offset: 0x00025304
		internal bool method_0()
		{
			return this.bool_5;
		}

		// Token: 0x06003570 RID: 13680
		// RVA: 0x0016DE54 File Offset: 0x0016C054
		internal void method_1(bool bool_17)
		{
			if (this.bool_5 && !bool_17)
			{
				int count = this.list_1.Count;
				if (count > 0)
				{
					for (int i = 0; i < count; i++)
					{
						this.queue_0.Enqueue(this.list_1[i] as Class531);
					}
					this.list_1.Clear();
				}
			}
			this.bool_5 = bool_17;
		}

		// Token: 0x0600357E RID: 13694
		// RVA: 0x0016E1E0 File Offset: 0x0016C3E0
		internal void method_10()
		{
			lock (this.list_2)
			{
				this.list_2.Sort(this.class745_0);
			}
		}

		// Token: 0x06003581 RID: 13697
		// RVA: 0x0016E39C File Offset: 0x0016C59C
		internal List<Class530> method_11(object object_1)
		{
			Predicate<Class530> predicate = null;
			Class911.Class912 class = new Class911.Class912();
			class.object_0 = object_1;
			List<Class530> result;
			lock (Class911.object_0)
			{
				List<Class530> arg_32_0 = this.list_2;
				if (predicate == null)
				{
					predicate = new Predicate<Class530>(class.method_0);
				}
				result = arg_32_0.FindAll(predicate);
			}
			return result;
		}

		// Token: 0x06003582 RID: 13698
		// RVA: 0x0016E3FC File Offset: 0x0016C5FC
		internal void method_12(object object_1)
		{
			Predicate<Class530> predicate = null;
			Class911.Class913 class = new Class911.Class913();
			class.object_0 = object_1;
			lock (Class911.object_0)
			{
				List<Class530> arg_32_0 = this.list_2;
				if (predicate == null)
				{
					predicate = new Predicate<Class530>(class.method_0);
				}
				List<Class530> list = arg_32_0.FindAll(predicate);
				List<Class530> arg_56_0 = list;
				if (Class911.action_0 == null)
				{
					Class911.action_0 = new Action<Class530>(Class911.smethod_8);
				}
				arg_56_0.ForEach(Class911.action_0);
				this.method_13<Class530>(list);
			}
		}

		// Token: 0x06003584 RID: 13700
		// RVA: 0x0016E4DC File Offset: 0x0016C6DC
		internal void method_13<T>(List<T> list_3) where T : Class530
		{
			if (list_3 == null)
			{
				return;
			}
			if (list_3.Count > 50)
			{
				int num = this.list_2.BinarySearch(list_3[0], this.class745_0);
				if (num >= 0)
				{
					int num2 = num + list_3.Count - 1;
					if (num2 < this.list_2.Count && this.list_2[num2] == list_3[list_3.Count - 1])
					{
						for (int i = num; i < num2; i++)
						{
							if (this.list_2[i].bool_6)
							{
								this.list_2[i].Dispose();
							}
						}
						this.list_2.RemoveRange(num, list_3.Count);
						return;
					}
				}
			}
			int count = list_3.Count;
			lock (Class911.object_0)
			{
				for (int j = 0; j < count; j++)
				{
					this.Remove(list_3[j]);
				}
			}
		}

		// Token: 0x06003585 RID: 13701
		// RVA: 0x0016E5EC File Offset: 0x0016C7EC
		internal bool method_14(bool bool_17, bool bool_18)
		{
			if (!this.bool_6)
			{
				return false;
			}
			if (bool_17 != this.bool_14)
			{
				return false;
			}
			if (this.float_0 >= 0.01f && !this.bool_0)
			{
				Class531 class = this.class531_1;
				this.method_8();
				lock (this.list_2)
				{
					for (int i = 0; i < this.list_2.Count; i++)
					{
						Class530 class2 = this.list_2[i];
						if (!class2.bool_5)
						{
							if (!bool_18)
							{
								this.method_16<Class530>(class2);
							}
							else
							{
								class2.vmethod_2(false);
							}
						}
					}
				}
				if (this.class531_1 != null)
				{
					this.class531_1.vmethod_2(true);
				}
				if (class != null && class != this.class531_1)
				{
					class.vmethod_2(false);
				}
				return this.class531_1 != null;
			}
			return false;
		}

		// Token: 0x06003587 RID: 13703
		// RVA: 0x0016ED0C File Offset: 0x0016CF0C
		internal void method_15()
		{
			if (!this.bool_1)
			{
				return;
			}
			if (Class115.int_1 != this.int_0)
			{
				Class911.Class914 class = new Class911.Class914();
				class.class911_0 = this;
				class.int_0 = Class115.int_1 - this.int_0;
				List<Class530> arg_58_0 = this.list_2;
				if (Class911.predicate_0 == null)
				{
					Class911.predicate_0 = new Predicate<Class530>(Class911.smethod_9);
				}
				arg_58_0.FindAll(Class911.predicate_0).ForEach(new Action<Class530>(class.method_0));
			}
			this.bool_1 = false;
		}

		// Token: 0x06003588 RID: 13704
		// RVA: 0x0016ED90 File Offset: 0x0016CF90
		internal void method_16<T>(T gparam_0) where T : Class530
		{
			if (gparam_0 == null || !gparam_0.bool_3 || gparam_0.method_7())
			{
				return;
			}
			Class531 class = gparam_0 as Class531;
			if (class == null)
			{
				return;
			}
			if (class.bool_1)
			{
				if (Class800.smethod_0() && (this.class531_1 == null || class.float_4 < this.class531_1.float_4) && class.vmethod_10(Class800.smethod_19(), 0) && (!this.bool_7 || this.rectangleF_3.Contains(Class800.smethod_15())))
				{
					if (this.class531_1 != null)
					{
						this.class531_1.vmethod_2(false);
					}
					this.class531_1 = class;
					return;
				}
				if (class.vmethod_1())
				{
					class.vmethod_2(false);
					return;
				}
			}
			else if (class.vmethod_1())
			{
				class.vmethod_2(false);
			}
		}

		// Token: 0x0600358A RID: 13706
		// RVA: 0x0016EE68 File Offset: 0x0016D068
		internal void method_17(List<Class530> list_3)
		{
			if (list_3 == null || list_3.Count == 0)
			{
				return;
			}
			if (this.list_2.Count == 0)
			{
				this.list_2.AddRange(list_3);
				return;
			}
			int num = this.list_2.BinarySearch(list_3[list_3.Count - 1], this.class745_0);
			if (num < 0)
			{
				num = ~num;
			}
			List<Class530> range = this.list_2.GetRange(num, this.list_2.Count - num);
			this.list_2.RemoveRange(num, this.list_2.Count - num);
			this.list_2.AddRange(list_3);
			this.list_2.AddRange(range);
		}

		// Token: 0x0600358B RID: 13707
		// RVA: 0x00027195 File Offset: 0x00025395
		internal void method_18(RectangleF rectangleF_4)
		{
			this.bool_3 = true;
			this.bool_7 = true;
			this.rectangleF_2 = rectangleF_4;
		}

		// Token: 0x0600358D RID: 13709
		// RVA: 0x000271AC File Offset: 0x000253AC
		internal void method_19()
		{
			Class115.class47_0.Add(new VoidDelegate(this.method_24), true);
		}

		// Token: 0x06003571 RID: 13681
		// RVA: 0x0002710C File Offset: 0x0002530C
		internal int method_2()
		{
			return this.list_2.Count + this.list_1.Count + this.queue_0.Count;
		}

		// Token: 0x06003591 RID: 13713
		// RVA: 0x0016EF14 File Offset: 0x0016D114
		internal void method_20(bool bool_17)
		{
			SpriteBlendMode spriteBlendMode = bool_17 ? 2 : 1;
			if (this.spriteBlendMode_0 != spriteBlendMode || !this.bool_13)
			{
				this.spriteBlendMode_0 = spriteBlendMode;
				this.method_21(true);
			}
		}

		// Token: 0x06003592 RID: 13714
		// RVA: 0x0016EF48 File Offset: 0x0016D148
		private void method_21(bool bool_17)
		{
			if (this.bool_13 && !bool_17)
			{
				return;
			}
			this.method_22(false);
			if (Class115.bool_26)
			{
				Class115.spriteBatch_0.Begin(this.spriteBlendMode_0, 0, 0);
				Class115.spriteBatch_0.get_GraphicsDevice().get_RenderState().set_ScissorTestEnable(true);
				Class115.spriteBatch_0.get_GraphicsDevice().get_RenderState().set_SeparateAlphaBlendEnabled(true);
				Class115.spriteBatch_0.get_GraphicsDevice().get_RenderState().set_AlphaSourceBlend(2);
				Class115.spriteBatch_0.get_GraphicsDevice().get_RenderState().set_AlphaDestinationBlend(6);
			}
			if (Class115.bool_27)
			{
				Gl.glEnable(3089u);
				if (this.spriteBlendMode_0 == 2)
				{
					BaseGLControl.smethod_5(770u, 1u);
				}
				else
				{
					BaseGLControl.smethod_5(770u, 771u);
				}
			}
			this.bool_13 = true;
			Class911.class911_0 = this;
			Class747.float_1 = this.float_3;
		}

		// Token: 0x06003593 RID: 13715
		// RVA: 0x0016F024 File Offset: 0x0016D224
		private void method_22(bool bool_17)
		{
			if (bool_17)
			{
				Class911.class911_0 = null;
			}
			if (!this.bool_13)
			{
				return;
			}
			this.bool_13 = false;
			Class747.float_1 = 1f;
			if (Class115.bool_26)
			{
				Class115.spriteBatch_0.End();
				Class115.spriteBatch_0.get_GraphicsDevice().get_RenderState().set_ScissorTestEnable(false);
			}
			if (Class115.bool_27)
			{
				Gl.glDisable(3089u);
			}
		}

		// Token: 0x06003597 RID: 13719
		// RVA: 0x0016F13C File Offset: 0x0016D33C
		private void method_23(bool bool_17)
		{
			if (this.float_0 == 0f || (double)this.long_0 < (double)Class115.int_1 - Class115.double_9 * 2.0)
			{
				this.bool_16 = true;
				return;
			}
			Class531 class = this.class531_1;
			this.method_8();
			int count = this.list_2.Count;
			if (bool_17 && this.bool_16)
			{
				return;
			}
			for (int i = 0; i < count; i++)
			{
				this.method_16<Class530>(this.list_2[i]);
			}
			this.bool_16 = true;
			if (class != null && class != this.class531_1)
			{
				class.vmethod_2(false);
			}
			if (this.class531_1 == null)
			{
				return;
			}
			if (this.bool_6 && Class911.class531_0 == null && this.class531_1.bool_1 && this.class531_1.bool_3)
			{
				if (Class800.smethod_5() != 1)
				{
					if (this.class531_1.method_0(false))
					{
						Class802.bool_29 = true;
					}
					Class911.class531_0 = this.class531_1;
					return;
				}
			}
		}

		// Token: 0x0600359A RID: 13722
		// RVA: 0x00027240 File Offset: 0x00025440
		[CompilerGenerated]
		private void method_24()
		{
			Class911.class531_0 = null;
			this.bool_16 = false;
			Class911.bool_15 = false;
		}

		// Token: 0x06003573 RID: 13683
		// RVA: 0x0002713A File Offset: 0x0002533A
		internal bool method_3()
		{
			return this.bool_10;
		}

		// Token: 0x06003574 RID: 13684
		// RVA: 0x0016DEB8 File Offset: 0x0016C0B8
		internal void method_4(bool bool_17, bool? nullable_0)
		{
			this.bool_10 = bool_17;
			this.bool_8 = (nullable_0 ?? (!bool_17));
			this.rectangleF_2 = (bool_17 ? Class911.rectangleF_0 : Class911.rectangleF_1);
		}

		// Token: 0x06003576 RID: 13686
		// RVA: 0x00027142 File Offset: 0x00025342
		private void method_5()
		{
			if (this.bool_3)
			{
				return;
			}
			this.method_4(this.bool_10, new bool?(this.bool_8));
		}

		// Token: 0x06003577 RID: 13687
		// RVA: 0x00027164 File Offset: 0x00025364
		internal void method_6()
		{
			Class911.list_0.Remove(this);
			Class911.list_0.Add(this);
		}

		// Token: 0x0600357A RID: 13690
		// RVA: 0x0016E078 File Offset: 0x0016C278
		private void method_7(bool bool_17)
		{
			this.bool_13 = false;
			if (!bool_17)
			{
				return;
			}
			int count = this.list_2.Count;
			for (int i = 0; i < count; i++)
			{
				Class530 class = this.list_2[i];
				Class533 class2 = class as Class533;
				if (class2 != null && class2.class731_0 != null)
				{
					class2.class731_0.Dispose();
					class2.class731_0 = null;
				}
			}
		}

		// Token: 0x0600357B RID: 13691
		// RVA: 0x0002718C File Offset: 0x0002538C
		private void method_8()
		{
			this.class531_1 = null;
		}

		// Token: 0x0600357C RID: 13692
		// RVA: 0x0016E0DC File Offset: 0x0016C2DC
		internal void method_9(Class531 class531_2)
		{
			if (class531_2 == null)
			{
				return;
			}
			lock (Class911.object_0)
			{
				int num = this.list_2.BinarySearch(class531_2, this.class745_0);
				this.list_2.Insert((num < 0) ? (~num) : num, class531_2);
			}
		}

		// Token: 0x06003583 RID: 13699
		// RVA: 0x0016E484 File Offset: 0x0016C684
		internal void Remove(Class530 class530_0)
		{
			if (class530_0 != null)
			{
				lock (Class911.object_0)
				{
					this.list_2.Remove(class530_0);
				}
				if (class530_0.bool_6)
				{
					class530_0.Dispose();
				}
				class530_0.bool_3 = false;
			}
		}

		// Token: 0x06003589 RID: 13705
		// RVA: 0x0001C1C8 File Offset: 0x0001A3C8
		internal static int smethod_0(Class531 class531_2)
		{
			if (class531_2.enum114_0 != Enum114.const_0)
			{
				return Class331.int_7;
			}
			return Class115.int_1;
		}

		// Token: 0x0600358C RID: 13708
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal static void smethod_1()
		{
		}

		// Token: 0x0600359B RID: 13723
		// RVA: 0x00027255 File Offset: 0x00025455
		[CompilerGenerated]
		private static void smethod_10(Class911 class911_1)
		{
			class911_1.method_19();
		}

		// Token: 0x0600358E RID: 13710
		// RVA: 0x000271C5 File Offset: 0x000253C5
		internal static float smethod_2(float float_6)
		{
			return float_6 % 1999999f / 1E+07f;
		}

		// Token: 0x0600358F RID: 13711
		// RVA: 0x000271D4 File Offset: 0x000253D4
		internal static float smethod_3(float float_6)
		{
			return 0.8f + float_6 % 6000000f / 3E+07f;
		}

		// Token: 0x06003590 RID: 13712
		// RVA: 0x000271E9 File Offset: 0x000253E9
		internal static float smethod_4(float float_6)
		{
			return 0.8f - float_6 % 6000000f / 1E+07f;
		}

		// Token: 0x06003594 RID: 13716
		// RVA: 0x0016F08C File Offset: 0x0016D28C
		internal static Class911 smethod_5()
		{
			Class911 class = null;
			for (int i = Class911.list_0.Count - 1; i >= 0; i--)
			{
				Class911 class2 = Class911.list_0[i];
				if (class2.method_14(true, class != null))
				{
					class = class2;
				}
			}
			for (int j = Class911.list_0.Count - 1; j >= 0; j--)
			{
				Class911 class3 = Class911.list_0[j];
				if (class3.method_14(false, class != null))
				{
					class = class3;
				}
			}
			return class;
		}

		// Token: 0x06003595 RID: 13717
		// RVA: 0x000271FE File Offset: 0x000253FE
		internal static void smethod_6()
		{
			List<Class911> arg_22_0 = Class911.list_0;
			if (Class911.action_1 == null)
			{
				Class911.action_1 = new Action<Class911>(Class911.smethod_10);
			}
			arg_22_0.ForEach(Class911.action_1);
			Class911.bool_15 = false;
		}

		// Token: 0x06003596 RID: 13718
		// RVA: 0x0016F10C File Offset: 0x0016D30C
		internal static void smethod_7(bool bool_17)
		{
			if (bool_17 && Class911.bool_15)
			{
				return;
			}
			Class911.bool_15 = true;
			Class911 class = Class911.smethod_5();
			if (class != null)
			{
				class.method_23(bool_17);
			}
		}

		// Token: 0x06003598 RID: 13720
		// RVA: 0x0002722D File Offset: 0x0002542D
		[CompilerGenerated]
		private static void smethod_8(Class530 class530_0)
		{
			class530_0.Dispose();
		}

		// Token: 0x06003599 RID: 13721
		// RVA: 0x00027235 File Offset: 0x00025435
		[CompilerGenerated]
		private static bool smethod_9(Class530 class530_0)
		{
			return class530_0.enum114_0 == Enum114.const_0;
		}
	}
}
