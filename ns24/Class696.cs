using Microsoft.Xna.Framework;
using ns77;
using ns79;
using osu.Graphics.Sprites;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns24
{
	// Token: 0x0200052D RID: 1325
	internal sealed class Class696 : Class695
	{
		// Token: 0x0200052E RID: 1326
		[CompilerGenerated]
		private sealed class Class699
		{
			// Token: 0x040023BE RID: 9150
			public bool bool_0;

			// Token: 0x06002B09 RID: 11017
			// RVA: 0x00020FCD File Offset: 0x0001F1CD
			public void method_0(Class530 class530_0)
			{
				class530_0.method_16(this.bool_0 ? 0 : 200, Enum70.const_0);
			}
		}

		// Token: 0x040023B9 RID: 9145
		internal List<Class695> list_2 = new List<Class695>();

		// Token: 0x040023BC RID: 9148
		[CompilerGenerated]
		private static Predicate<Class695> predicate_0;

		// Token: 0x040023BD RID: 9149
		[CompilerGenerated]
		private static Predicate<Class695> predicate_1;

		// Token: 0x040023BA RID: 9146
		private string string_0;

		// Token: 0x040023BB RID: 9147
		private string string_1;

		// Token: 0x17000391 RID: 913
		internal override string Name
		{
			// Token: 0x06002AFE RID: 11006
			// RVA: 0x00020F77 File Offset: 0x0001F177
			get
			{
				return this.string_0;
			}
		}

		// Token: 0x06002B00 RID: 11008
		// RVA: 0x00116C94 File Offset: 0x00114E94
		public Class696(string string_2) : base(null, null, null)
		{
			this.string_0 = string_2;
			this.string_1 = string_2;
			this.list_2 = new List<Class695>();
			base.method_20(Enum63.const_1);
			base.method_5(Class695.color_1);
			this.color_12 = Class695.color_1;
		}

		// Token: 0x06002AFF RID: 11007
		// RVA: 0x00020F7F File Offset: 0x0001F17F
		internal bool method_28()
		{
			List<Class695> arg_23_0 = this.list_2;
			if (Class696.predicate_0 == null)
			{
				Class696.predicate_0 = new Predicate<Class695>(Class696.smethod_3);
			}
			return arg_23_0.Exists(Class696.predicate_0);
		}

		// Token: 0x06002B01 RID: 11009
		// RVA: 0x00116CF4 File Offset: 0x00114EF4
		internal int method_29()
		{
			if (this.list_2 != null && this.list_2.Count != 0)
			{
				List<Class695> arg_3E_0 = this.list_2;
				if (Class696.predicate_1 == null)
				{
					Class696.predicate_1 = new Predicate<Class695>(Class696.smethod_4);
				}
				int count = arg_3E_0.FindAll(Class696.predicate_1).Count;
				this.string_1 = string.Concat(new object[]
				{
					this.string_0,
					" (",
					count,
					" map",
					(count != 1) ? "s" : "",
					")"
				});
				if (this.bool_6)
				{
					this.class533_0.Text = this.string_1;
				}
				return count;
			}
			return 0;
		}

		// Token: 0x06002B02 RID: 11010
		// RVA: 0x00116DB8 File Offset: 0x00114FB8
		internal void method_30(bool bool_7)
		{
			if (!this.bool_6)
			{
				return;
			}
			if (this.enum63_0 >= Enum63.const_3)
			{
				this.class533_0.color_0 = Class695.color_9;
				base.method_5(Class695.color_0);
			}
			else
			{
				this.class533_0.color_0 = Class695.color_10;
				if (this.method_28())
				{
					base.method_5(Class695.color_2);
				}
				else
				{
					base.method_5(Class695.color_1);
				}
			}
			base.method_23(base.method_4(), bool_7 ? 0 : 300);
		}

		// Token: 0x06002B06 RID: 11014
		// RVA: 0x00020FA9 File Offset: 0x0001F1A9
		[CompilerGenerated]
		private static bool smethod_3(Class695 class695_2)
		{
			return !class695_2.bool_3 && class695_2.class296_0 == Class466.Current;
		}

		// Token: 0x06002B07 RID: 11015
		// RVA: 0x00020FC2 File Offset: 0x0001F1C2
		[CompilerGenerated]
		private static bool smethod_4(Class695 class695_2)
		{
			return !class695_2.bool_3;
		}

		// Token: 0x06002B04 RID: 11012
		// RVA: 0x00116ED8 File Offset: 0x001150D8
		protected override void vmethod_0()
		{
			if (this.list_0 == null)
			{
				this.list_0 = new List<Class530>();
			}
			this.class531_0 = new Class531(Class695.class731_0, Enum115.const_5, Origins.CentreLeft, Enum114.const_0, this.vector2_0, this.float_0, true, this.color_12, this);
			this.class531_0.bool_1 = true;
			this.list_0.Add(this.class531_0);
			this.class533_0 = new Class533(this.string_1, 24f, Vector2.get_Zero(), Vector2.get_Zero(), this.float_0 + 1E-06f, true, Class695.color_10, false);
			this.class533_0.origins_0 = Origins.CentreLeft;
			this.class533_0.object_0 = new Vector2(15f, 0f);
			this.list_1.Add(this.class533_0);
			this.list_0.Add(this.class533_0);
			this.method_29();
		}

		// Token: 0x06002B03 RID: 11011
		// RVA: 0x00116E3C File Offset: 0x0011503C
		internal override void vmethod_1(Enum63 enum63_1, bool bool_7)
		{
			Action<Class530> action = null;
			Class696.Class699 class = new Class696.Class699();
			class.bool_0 = bool_7;
			if (this.enum63_0 <= Enum63.const_0)
			{
				if (this.class531_0.float_3 != 0f)
				{
					List<Class530> arg_41_0 = this.list_0;
					if (action == null)
					{
						action = new Action<Class530>(class.method_0);
					}
					arg_41_0.ForEach(action);
				}
				return;
			}
			if (enum63_1 <= Enum63.const_0)
			{
				for (int i = 0; i < this.list_0.Count; i++)
				{
					this.list_0[i].method_14(class.bool_0 ? 0 : 200, Enum70.const_0);
				}
			}
			this.method_30(class.bool_0);
		}

		// Token: 0x06002B05 RID: 11013
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal override void vmethod_2(Enum63 enum63_1)
		{
		}
	}
}
