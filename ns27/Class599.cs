using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns29;
using ns77;
using ns79;
using ns80;
using osu.Graphics.Sprites;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns27
{
	// Token: 0x02000493 RID: 1171
	internal sealed class Class599 : IDisposable
	{
		// Token: 0x02000494 RID: 1172
		[CompilerGenerated]
		private sealed class Class600
		{
			// Token: 0x04001F45 RID: 8005
			public Class599 class599_0;

			// Token: 0x04001F46 RID: 8006
			public string string_0;

			// Token: 0x060025B4 RID: 9652
			// RVA: 0x000E3408 File Offset: 0x000E1608
			public void method_0()
			{
				Class533 class = (Class533)this.class599_0.class533_0.Clone();
				class.Text = this.string_0;
				this.class599_0.class911_0.Add(class);
				using (List<Class530>.Enumerator enumerator = this.class599_0.class911_0.list_2.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Class531 class2 = (Class531)enumerator.Current;
						if (class2.vector2_1.Y < 0f)
						{
							class2.class26_0.Clear();
							class2.bool_0 = false;
						}
						else if ((double)class2.float_3 > 0.01)
						{
							class2.method_22(new Vector2(0f, -20f), 500);
							class2.method_16(10000, Enum70.const_0);
							class2.bool_0 = false;
						}
					}
				}
			}
		}

		// Token: 0x04001F43 RID: 8003
		private bool bool_0 = true;

		// Token: 0x04001F44 RID: 8004
		private Class531 class531_0;

		// Token: 0x04001F40 RID: 8000
		private Class533 class533_0;

		// Token: 0x04001F41 RID: 8001
		private Class911 class911_0 = new Class911(true);

		// Token: 0x04001F42 RID: 8002
		private Class911 class911_1 = new Class911(true);

		// Token: 0x060025AE RID: 9646
		// RVA: 0x000E32C4 File Offset: 0x000E14C4
		public Class599(string string_0)
		{
			this.class533_0 = new Class533("", 14f, new Vector2((float)(Class115.smethod_43() / 2), 240f), 1f, true, Color.get_White());
			this.class533_0.origins_0 = Origins.Centre;
			this.class911_1.Add(new Class531(Class885.Load("beatmapimport-top", Enum112.flag_1), Vector2.get_Zero(), 1f, true, Color.get_White()));
			this.class531_0 = Class599.smethod_0(new Color(255, 96, 171));
			this.class531_0.method_15(2000);
			Class531 expr_C6_cp_0 = this.class531_0;
			expr_C6_cp_0.vector2_1.Y = expr_C6_cp_0.vector2_1.Y + 70f;
			this.class911_1.Add(this.class531_0);
			this.method_0(string_0);
		}

		// Token: 0x060025AF RID: 9647
		// RVA: 0x0001D49E File Offset: 0x0001B69E
		public void Dispose()
		{
			this.Dispose(true);
		}

		// Token: 0x060025B0 RID: 9648
		// RVA: 0x0001D4A7 File Offset: 0x0001B6A7
		protected virtual void Dispose(bool bool_1)
		{
			this.class911_0.Dispose();
			this.class911_1.Dispose();
		}

		// Token: 0x060025B2 RID: 9650
		// RVA: 0x0001D4BF File Offset: 0x0001B6BF
		public void Draw()
		{
			this.class911_0.Draw();
			this.class911_1.Draw();
			this.bool_0 = true;
		}

		// Token: 0x060025B1 RID: 9649
		// RVA: 0x000E33C0 File Offset: 0x000E15C0
		public void method_0(string string_0)
		{
			Class599.Class600 class = new Class599.Class600();
			class.string_0 = string_0;
			class.class599_0 = this;
			if (!this.bool_0)
			{
				return;
			}
			this.bool_0 = false;
			Class115.class47_0.Add(new VoidDelegate(class.method_0), false);
		}

		// Token: 0x060025AD RID: 9645
		// RVA: 0x000E31CC File Offset: 0x000E13CC
		public static Class531 smethod_0(Color color_0)
		{
			return new Class531(Class885.Load("beatmapimport-spinner", Enum112.flag_1), Enum115.const_9, Origins.Centre, Enum114.const_0, Vector2.get_Zero(), 1f, true, color_0, null)
			{
				class26_0 = 
				{
					new Class746(TransformationType.Rotation, 0f, 6.28318548f, Class115.int_1, Class115.int_1 + 1500, Enum70.const_0)
					{
						bool_0 = true
					},
					new Class746(TransformationType.Scale, 0.5f, 1.3f, Class115.int_1, Class115.int_1 + 200, Enum70.const_1),
					new Class746(TransformationType.Scale, 1.3f, 0.9f, Class115.int_1 + 200, Class115.int_1 + 400, Enum70.const_2),
					new Class746(TransformationType.Scale, 0.9f, 1f, Class115.int_1 + 400, Class115.int_1 + 500, Enum70.const_1)
				}
			};
		}
	}
}
