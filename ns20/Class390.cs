using Microsoft.Xna.Framework;
using ns77;
using ns79;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns20
{
	// Token: 0x020003A0 RID: 928
	internal class Class390 : IDisposable, IComparable<Class390>
	{
		// Token: 0x040016D3 RID: 5843
		private bool bool_0;

		// Token: 0x040016D4 RID: 5844
		public Class390 class390_0;

		// Token: 0x040016CD RID: 5837
		internal Class911 class911_0 = new Class911(true)
		{
			bool_7 = true
		};

		// Token: 0x040016D2 RID: 5842
		private EventHandler eventHandler_0;

		// Token: 0x040016CE RID: 5838
		internal float float_0;

		// Token: 0x040016D0 RID: 5840
		private float float_1;

		// Token: 0x040016D5 RID: 5845
		private IEnumerable<Class390> ienumerable_0;

		// Token: 0x040016D1 RID: 5841
		internal List<string> list_0 = new List<string>();

		// Token: 0x040016D6 RID: 5846
		[CompilerGenerated]
		private static Predicate<Class530> predicate_0;

		// Token: 0x040016CF RID: 5839
		private Vector2 vector2_0 = new Vector2(244f, 13.125f);

		// Token: 0x06001CB3 RID: 7347
		// RVA: 0x00099D1C File Offset: 0x00097F1C
		public virtual void Dispose()
		{
			this.class911_0.Dispose();
			foreach (Class390 current in this.method_11())
			{
				current.Dispose();
			}
		}

		// Token: 0x06001CAC RID: 7340
		// RVA: 0x00099BE0 File Offset: 0x00097DE0
		public bool Match(string string_0)
		{
			string_0 = string_0.ToLower();
			foreach (string current in this.list_0)
			{
				if (current.Contains(string_0))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001CA1 RID: 7329
		// RVA: 0x00017976 File Offset: 0x00015B76
		internal Vector2 method_0()
		{
			return this.vector2_0;
		}

		// Token: 0x06001CA2 RID: 7330
		// RVA: 0x00099A94 File Offset: 0x00097C94
		internal void method_1(Vector2 vector2_1)
		{
			if (vector2_1 == this.vector2_0)
			{
				return;
			}
			float y = this.vector2_0.Y;
			this.vector2_0 = vector2_1;
			if (y != this.vector2_0.Y)
			{
				this.method_5();
			}
		}

		// Token: 0x06001CAF RID: 7343
		// RVA: 0x000179D9 File Offset: 0x00015BD9
		internal void method_10()
		{
			this.class911_0.bool_0 = true;
		}

		// Token: 0x06001CB2 RID: 7346
		// RVA: 0x00099CB0 File Offset: 0x00097EB0
		public IEnumerable<Class390> method_11()
		{
			List<Class390> list = new List<Class390>();
			if (this.vmethod_0() != null)
			{
				foreach (Class390 current in this.vmethod_0())
				{
					list.Add(current);
					list.AddRange(current.method_11());
				}
			}
			return list;
		}

		// Token: 0x06001CB5 RID: 7349
		// RVA: 0x00099D74 File Offset: 0x00097F74
		public string method_12()
		{
			List<Class530> arg_28_0 = this.class911_0.list_2;
			if (Class390.predicate_0 == null)
			{
				Class390.predicate_0 = new Predicate<Class530>(Class390.smethod_0);
			}
			Class531 class = arg_28_0.FindLast(Class390.predicate_0) as Class531;
			if (class != null)
			{
				return class.string_0;
			}
			return null;
		}

		// Token: 0x06001CA3 RID: 7331
		// RVA: 0x0001797E File Offset: 0x00015B7E
		internal float method_2()
		{
			return this.float_1;
		}

		// Token: 0x06001CA4 RID: 7332
		// RVA: 0x00017986 File Offset: 0x00015B86
		internal void method_3(float float_2)
		{
			if (float_2 == this.float_1)
			{
				return;
			}
			this.float_1 = float_2;
			this.method_5();
		}

		// Token: 0x06001CA5 RID: 7333
		// RVA: 0x00099AD8 File Offset: 0x00097CD8
		internal void method_4(EventHandler eventHandler_1)
		{
			EventHandler eventHandler = this.eventHandler_0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_1);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06001CA6 RID: 7334
		// RVA: 0x0001799F File Offset: 0x00015B9F
		protected void method_5()
		{
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, null);
			}
		}

		// Token: 0x06001CA7 RID: 7335
		// RVA: 0x000179B6 File Offset: 0x00015BB6
		internal bool method_6()
		{
			return this.bool_0;
		}

		// Token: 0x06001CA8 RID: 7336
		// RVA: 0x00099B10 File Offset: 0x00097D10
		internal void method_7(bool bool_1)
		{
			this.bool_0 = bool_1;
			if (this.ienumerable_0 != null)
			{
				foreach (Class390 current in this.ienumerable_0)
				{
					current.method_7(this.bool_0);
				}
			}
		}

		// Token: 0x06001CAB RID: 7339
		// RVA: 0x000179C6 File Offset: 0x00015BC6
		protected void method_8(string string_0)
		{
			this.list_0.Add(string_0.ToLower());
		}

		// Token: 0x06001CAE RID: 7342
		// RVA: 0x00099C48 File Offset: 0x00097E48
		internal void method_9(bool bool_1)
		{
			if (bool_1 && this.vmethod_0() != null)
			{
				foreach (Class390 current in this.vmethod_0())
				{
					current.method_9(false);
				}
			}
			this.class911_0.bool_0 = false;
		}

		// Token: 0x06001CB7 RID: 7351
		// RVA: 0x00099E08 File Offset: 0x00098008
		[CompilerGenerated]
		private static bool smethod_0(Class530 class530_0)
		{
			Class531 class = class530_0 as Class531;
			return class != null && !string.IsNullOrEmpty(class.string_0);
		}

		// Token: 0x06001CAD RID: 7341
		// RVA: 0x00006D86 File Offset: 0x00004F86
		int IComparable<Class390>.CompareTo(Class390 other)
		{
			return 0;
		}

		// Token: 0x06001CA9 RID: 7337
		// RVA: 0x000179BE File Offset: 0x00015BBE
		internal virtual IEnumerable<Class390> vmethod_0()
		{
			return this.ienumerable_0;
		}

		// Token: 0x06001CAA RID: 7338
		// RVA: 0x00099B74 File Offset: 0x00097D74
		internal virtual void vmethod_1(IEnumerable<Class390> ienumerable_1)
		{
			this.ienumerable_0 = ienumerable_1;
			if (this.ienumerable_0 != null)
			{
				foreach (Class390 current in this.ienumerable_0)
				{
					current.class390_0 = this;
					if (this.method_6())
					{
						current.method_7(true);
					}
				}
			}
		}

		// Token: 0x06001CB0 RID: 7344
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal virtual void vmethod_2()
		{
		}

		// Token: 0x06001CB1 RID: 7345
		// RVA: 0x00006D86 File Offset: 0x00004F86
		internal virtual bool vmethod_3()
		{
			return false;
		}

		// Token: 0x06001CB4 RID: 7348
		// RVA: 0x00006D86 File Offset: 0x00004F86
		internal virtual int vmethod_4()
		{
			return 0;
		}
	}
}
