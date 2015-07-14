using Microsoft.Xna.Framework.Input;
using ns23;
using ns79;
using osu.GameModes.Edit;
using System;

namespace ns68
{
	// Token: 0x02000383 RID: 899
	internal abstract class Class370
	{
		// Token: 0x040015E0 RID: 5600
		internal bool bool_0;

		// Token: 0x040015E1 RID: 5601
		private bool bool_1 = true;

		// Token: 0x040015E3 RID: 5603
		internal Class297 class297_0;

		// Token: 0x040015E4 RID: 5604
		internal Class911 class911_0;

		// Token: 0x040015E2 RID: 5602
		internal Editor editor_0;

		// Token: 0x06001B49 RID: 6985
		// RVA: 0x00016DAD File Offset: 0x00014FAD
		internal Class370(Editor editor_1)
		{
			this.editor_0 = editor_1;
			this.class297_0 = editor_1.class297_0;
			this.class911_0 = new Class911(true);
		}

		// Token: 0x06001B58 RID: 7000
		// RVA: 0x00016E34 File Offset: 0x00015034
		internal virtual void Dispose()
		{
			this.class911_0.Dispose();
		}

		// Token: 0x06001B4C RID: 6988
		// RVA: 0x00016DF4 File Offset: 0x00014FF4
		internal virtual void Draw()
		{
			this.class911_0.Draw();
		}

		// Token: 0x06001B4A RID: 6986
		// RVA: 0x00016DDB File Offset: 0x00014FDB
		internal virtual void Initialize()
		{
			this.vmethod_2();
			this.vmethod_21();
			this.class911_0.method_15();
		}

		// Token: 0x06001B54 RID: 6996
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal virtual void Reset()
		{
		}

		// Token: 0x06001B47 RID: 6983
		// RVA: 0x00016D90 File Offset: 0x00014F90
		internal virtual bool vmethod_0()
		{
			return this.bool_1;
		}

		// Token: 0x06001B48 RID: 6984
		// RVA: 0x00016D98 File Offset: 0x00014F98
		internal virtual void vmethod_1(bool bool_2)
		{
			this.bool_1 = bool_2;
			this.class911_0.bool_6 = bool_2;
		}

		// Token: 0x06001B55 RID: 6997
		// RVA: 0x00006D86 File Offset: 0x00004F86
		internal virtual bool vmethod_10(Keys keys_0, bool bool_2)
		{
			return false;
		}

		// Token: 0x06001B56 RID: 6998
		// RVA: 0x00016E02 File Offset: 0x00015002
		internal virtual void vmethod_11()
		{
			this.bool_0 = true;
			this.class911_0.float_0 = 1f;
		}

		// Token: 0x06001B57 RID: 6999
		// RVA: 0x00016E1B File Offset: 0x0001501B
		internal virtual void vmethod_12()
		{
			this.bool_0 = false;
			this.class911_0.float_0 = 0f;
		}

		// Token: 0x06001B59 RID: 7001
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal virtual void vmethod_13()
		{
		}

		// Token: 0x06001B5A RID: 7002
		// RVA: 0x00006D86 File Offset: 0x00004F86
		internal virtual bool vmethod_14()
		{
			return false;
		}

		// Token: 0x06001B5B RID: 7003
		// RVA: 0x00006D2D File Offset: 0x00004F2D
		internal virtual bool vmethod_15()
		{
			return true;
		}

		// Token: 0x06001B5C RID: 7004
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal virtual void vmethod_16()
		{
		}

		// Token: 0x06001B5D RID: 7005
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal virtual void vmethod_17()
		{
		}

		// Token: 0x06001B5E RID: 7006
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal virtual void vmethod_18()
		{
		}

		// Token: 0x06001B5F RID: 7007
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal virtual void vmethod_19()
		{
		}

		// Token: 0x06001B4B RID: 6987
		// RVA: 0x0000653E File Offset: 0x0000473E
		protected virtual void vmethod_2()
		{
		}

		// Token: 0x06001B60 RID: 7008
		// RVA: 0x00006D86 File Offset: 0x00004F86
		internal virtual bool vmethod_20()
		{
			return false;
		}

		// Token: 0x06001B61 RID: 7009
		protected abstract void vmethod_21();

		// Token: 0x06001B62 RID: 7010
		// RVA: 0x00006D86 File Offset: 0x00004F86
		internal virtual bool vmethod_22()
		{
			return false;
		}

		// Token: 0x06001B63 RID: 7011
		// RVA: 0x00006D86 File Offset: 0x00004F86
		internal virtual bool vmethod_23()
		{
			return false;
		}

		// Token: 0x06001B64 RID: 7012
		// RVA: 0x00006D86 File Offset: 0x00004F86
		internal virtual bool vmethod_24()
		{
			return false;
		}

		// Token: 0x06001B65 RID: 7013
		// RVA: 0x00006D86 File Offset: 0x00004F86
		internal virtual bool vmethod_25()
		{
			return false;
		}

		// Token: 0x06001B4D RID: 6989
		internal abstract void vmethod_3();

		// Token: 0x06001B4E RID: 6990
		internal abstract void vmethod_4();

		// Token: 0x06001B4F RID: 6991
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal virtual void vmethod_5()
		{
		}

		// Token: 0x06001B50 RID: 6992
		// RVA: 0x00006D86 File Offset: 0x00004F86
		internal virtual bool vmethod_6()
		{
			return false;
		}

		// Token: 0x06001B51 RID: 6993
		// RVA: 0x00006D86 File Offset: 0x00004F86
		internal virtual bool vmethod_7()
		{
			return false;
		}

		// Token: 0x06001B52 RID: 6994
		// RVA: 0x00006D86 File Offset: 0x00004F86
		internal virtual bool vmethod_8()
		{
			return false;
		}

		// Token: 0x06001B53 RID: 6995
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal virtual void vmethod_9()
		{
		}
	}
}
