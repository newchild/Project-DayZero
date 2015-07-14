using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using osu.Graphics.Primitives;
using osu.Graphics.Sprites;
using System;
using System.Runtime.InteropServices;

namespace ns79
{
	// Token: 0x02000586 RID: 1414
	[StructLayout(LayoutKind.Explicit)]
	internal sealed class Class746 : IComparable<Class746>
	{
		// Token: 0x040025F2 RID: 9714
		[FieldOffset(61)]
		internal bool bool_0;

		// Token: 0x040025F3 RID: 9715
		[FieldOffset(62)]
		internal bool bool_1;

		// Token: 0x040025F1 RID: 9713
		[FieldOffset(60)]
		internal byte byte_0;

		// Token: 0x040025E4 RID: 9700
		[FieldOffset(12)]
		internal Color color_0;

		// Token: 0x040025E8 RID: 9704
		[FieldOffset(28)]
		internal Color color_1;

		// Token: 0x040025F0 RID: 9712
		[FieldOffset(56)]
		internal Enum70 enum70_0;

		// Token: 0x040025E2 RID: 9698
		[FieldOffset(0)]
		internal float float_0;

		// Token: 0x040025E6 RID: 9702
		[FieldOffset(16)]
		internal float float_1;

		// Token: 0x040025EA RID: 9706
		[FieldOffset(32)]
		internal int int_0;

		// Token: 0x040025EB RID: 9707
		[FieldOffset(36)]
		internal int int_1;

		// Token: 0x040025EC RID: 9708
		[FieldOffset(40)]
		internal int int_2;

		// Token: 0x040025ED RID: 9709
		[FieldOffset(44)]
		internal int int_3;

		// Token: 0x040025EE RID: 9710
		[FieldOffset(48)]
		internal int int_4;

		// Token: 0x040025E5 RID: 9701
		[FieldOffset(0)]
		internal RectangleF rectangleF_0;

		// Token: 0x040025E9 RID: 9705
		[FieldOffset(16)]
		internal RectangleF rectangleF_1;

		// Token: 0x040025EF RID: 9711
		[FieldOffset(52)]
		internal TransformationType transformationType_0;

		// Token: 0x040025E3 RID: 9699
		[FieldOffset(4)]
		internal Vector2 vector2_0;

		// Token: 0x040025E7 RID: 9703
		[FieldOffset(20)]
		internal Vector2 vector2_1;

		// Token: 0x06002D48 RID: 11592
		// RVA: 0x00005E0F File Offset: 0x0000400F
		internal Class746()
		{
		}

		// Token: 0x06002D4C RID: 11596
		// RVA: 0x00022430 File Offset: 0x00020630
		internal Class746(Color color_2, Color color_3, int int_5, int int_6)
		{
			this.transformationType_0 = TransformationType.Colour;
			this.color_0 = color_2;
			this.color_1 = color_3;
			this.int_0 = int_5;
			this.int_1 = int_6;
		}

		// Token: 0x06002D4A RID: 11594
		// RVA: 0x000223C7 File Offset: 0x000205C7
		internal Class746(Vector2 vector2_2, Vector2 vector2_3, int int_5, int int_6, Enum70 enum70_1)
		{
			this.transformationType_0 = TransformationType.Movement;
			this.vector2_0 = vector2_2;
			this.vector2_1 = vector2_3;
			this.enum70_0 = enum70_1;
			this.int_0 = int_5;
			this.int_1 = int_6;
		}

		// Token: 0x06002D4D RID: 11597
		// RVA: 0x0002245D File Offset: 0x0002065D
		internal Class746(RectangleF rectangleF_2, RectangleF rectangleF_3, int int_5, int int_6, Enum70 enum70_1)
		{
			this.transformationType_0 = TransformationType.ClipRectangle;
			this.rectangleF_0 = rectangleF_2;
			this.rectangleF_1 = rectangleF_3;
			this.int_0 = int_5;
			this.int_1 = int_6;
			this.enum70_0 = enum70_1;
		}

		// Token: 0x06002D49 RID: 11593
		// RVA: 0x00022392 File Offset: 0x00020592
		internal Class746(TransformationType transformationType_1, float float_2, float float_3, int int_5, int int_6, Enum70 enum70_1)
		{
			this.transformationType_0 = transformationType_1;
			this.float_0 = float_2;
			this.float_1 = float_3;
			this.int_0 = int_5;
			this.int_1 = int_6;
			this.enum70_0 = enum70_1;
		}

		// Token: 0x06002D4B RID: 11595
		// RVA: 0x000223FB File Offset: 0x000205FB
		internal Class746(TransformationType transformationType_1, Vector2 vector2_2, Vector2 vector2_3, int int_5, int int_6, Enum70 enum70_1)
		{
			this.transformationType_0 = transformationType_1;
			this.vector2_0 = vector2_2;
			this.vector2_1 = vector2_3;
			this.int_0 = int_5;
			this.int_1 = int_6;
			this.enum70_0 = enum70_1;
		}

		// Token: 0x06002D50 RID: 11600
		// RVA: 0x000224A4 File Offset: 0x000206A4
		internal Class746 Clone()
		{
			return (Class746)base.MemberwiseClone();
		}

		// Token: 0x06002D4F RID: 11599
		// RVA: 0x00125FC4 File Offset: 0x001241C4
		public int CompareTo(Class746 obj)
		{
			int num = this.int_0.CompareTo(obj.int_0);
			if (num != 0)
			{
				return num;
			}
			num = this.int_1.CompareTo(obj.int_1);
			if (num != 0)
			{
				return num;
			}
			return this.transformationType_0.CompareTo(obj.transformationType_0);
		}

		// Token: 0x06002D4E RID: 11598
		// RVA: 0x00022495 File Offset: 0x00020695
		internal int method_0()
		{
			return this.int_1 - this.int_0;
		}

		// Token: 0x06002D51 RID: 11601
		// RVA: 0x0012601C File Offset: 0x0012421C
		internal Class746 method_1()
		{
			Class746 class = this.Clone();
			class.float_0 = this.float_1;
			class.color_0 = this.color_1;
			class.vector2_0 = this.vector2_1;
			class.rectangleF_0 = class.rectangleF_1;
			class.float_1 = this.float_0;
			class.color_1 = this.color_0;
			class.vector2_1 = this.vector2_0;
			class.rectangleF_1 = this.rectangleF_0;
			switch (this.enum70_0)
			{
			case Enum70.const_1:
				class.enum70_0 = Enum70.const_2;
				break;
			case Enum70.const_2:
				class.enum70_0 = Enum70.const_1;
				break;
			default:
				class.enum70_0 = Enum70.const_0;
				break;
			}
			return class;
		}

		// Token: 0x06002D52 RID: 11602
		// RVA: 0x001260C4 File Offset: 0x001242C4
		public override string ToString()
		{
			TransformationType transformationType = this.transformationType_0;
			if (transformationType == TransformationType.Movement)
			{
				return string.Format("{2} {0}-{1} {3}->{4}", new object[]
				{
					this.int_0,
					this.int_1,
					this.transformationType_0,
					this.vector2_0,
					this.vector2_1
				});
			}
			if (transformationType == TransformationType.Colour)
			{
				return string.Format("{2} {0}-{1} {3}->{4}", new object[]
				{
					this.int_0,
					this.int_1,
					this.transformationType_0,
					this.color_0,
					this.color_1
				});
			}
			if (transformationType != TransformationType.ClipRectangle)
			{
				return string.Format("{2} {0}-{1} {3}->{4}", new object[]
				{
					this.int_0,
					this.int_1,
					this.transformationType_0,
					this.float_0,
					this.float_1
				});
			}
			return string.Format("{2} {0}-{1} {3}->{4}", new object[]
			{
				this.int_0,
				this.int_1,
				this.transformationType_0,
				this.rectangleF_0,
				this.rectangleF_1
			});
		}
	}
}
