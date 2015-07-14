using Microsoft.Xna.Framework;
using ns14;
using ns29;
using ns64;
using ns9;
using System;
using System.Threading;
using System.Windows.Forms;

namespace ns81
{
	// Token: 0x02000470 RID: 1136
	internal abstract class Class565 : Class563
	{
		// Token: 0x04001E78 RID: 7800
		private static Class559.Class560.Class561 class561_0;

		// Token: 0x04001E7C RID: 7804
		private static Delegate40 delegate40_0;

		// Token: 0x04001E7D RID: 7805
		private static Delegate40 delegate40_1;

		// Token: 0x04001E7E RID: 7806
		private static Delegate40 delegate40_2;

		// Token: 0x04001E7B RID: 7803
		private static Delegate41 delegate41_0;

		// Token: 0x04001E79 RID: 7801
		protected static IntPtr intptr_0 = IntPtr.Zero;

		// Token: 0x04001E7A RID: 7802
		private static int int_0 = 0;

		// Token: 0x04001E77 RID: 7799
		private static Mutex mutex_0 = new Mutex();

		// Token: 0x04001E76 RID: 7798
		protected static Rectangle rectangle_0;

		// Token: 0x060024B7 RID: 9399
		// RVA: 0x000DD550 File Offset: 0x000DB750
		internal override void Dispose()
		{
			lock (Class565.mutex_0)
			{
				Class565.int_0--;
				if (Class565.int_0 == 0)
				{
					Class565.class561_0.Dispose();
					Class565.intptr_0 = IntPtr.Zero;
				}
			}
		}

		// Token: 0x060024B6 RID: 9398
		// RVA: 0x000DD4A0 File Offset: 0x000DB6A0
		internal override bool Initialize()
		{
			if (Class565.intptr_0 == IntPtr.Zero)
			{
				if (Class115.bool_27)
				{
					Class565.intptr_0 = Class115.baseGLControl_0.Handle;
				}
				else
				{
					Class565.intptr_0 = Class115.form_0.Handle;
				}
			}
			lock (Class565.mutex_0)
			{
				if (Class565.int_0 == 0)
				{
					Class565.class561_0 = new Class559.Class560.Class561(Class565.intptr_0);
					Class565.class561_0.method_0(new Delegate42(this.method_0));
					Class565.rectangle_0 = Class559.Class560.smethod_0();
				}
				Class565.int_0++;
			}
			return true;
		}

		// Token: 0x060024B9 RID: 9401
		// RVA: 0x000DD5AC File Offset: 0x000DB7AC
		private void method_0(ref Message message_0)
		{
			int msg = message_0.Msg;
			if (msg != 255)
			{
				switch (msg)
				{
				case 576:
				case 577:
				case 578:
				case 579:
				case 580:
				case 584:
				case 587:
				case 589:
					break;
				case 581:
				case 582:
				case 583:
				case 585:
				case 586:
				case 588:
				case 590:
				case 591:
				{
					int num = message_0.WParam.ToInt32() & 65535;
					Struct57 struct57_;
					if (!Class341.class606_62.Value && Class559.GetPointerInfo(num, ref struct57_) && struct57_.enum78_0 == Enum78.const_1)
					{
						if (Class565.delegate41_0 != null)
						{
							Class565.delegate41_0(struct57_);
						}
						if (Class114.bool_0 && !Class800.bool_5)
						{
							message_0.Result = new IntPtr(-1);
						}
					}
					break;
				}
				default:
					return;
				}
			}
			else
			{
				int num2 = 40;
				Struct58 struct58_;
				Class559.GetRawInputData(message_0.LParam, Enum84.const_0, ref struct58_, ref num2, sizeof(Struct62));
				switch (struct58_.struct62_0.enum85_0)
				{
				case Enum85.const_0:
					if (Class565.delegate40_1 != null)
					{
						Class565.delegate40_1(struct58_);
						return;
					}
					break;
				case Enum85.const_1:
					if (Class565.delegate40_0 != null)
					{
						Class565.delegate40_0(struct58_);
						return;
					}
					break;
				case Enum85.const_2:
					if (Class565.delegate40_2 != null)
					{
						Class565.delegate40_2(struct58_);
						return;
					}
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x060024BA RID: 9402
		// RVA: 0x000DD708 File Offset: 0x000DB908
		protected static void smethod_0(Delegate41 delegate41_1)
		{
			Delegate41 delegate = Class565.delegate41_0;
			Delegate41 delegate2;
			do
			{
				delegate2 = delegate;
				Delegate41 value = (Delegate41)Delegate.Combine(delegate2, delegate41_1);
				delegate = Interlocked.CompareExchange<Delegate41>(ref Class565.delegate41_0, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x060024BB RID: 9403
		// RVA: 0x000DD73C File Offset: 0x000DB93C
		protected static void smethod_1(Delegate41 delegate41_1)
		{
			Delegate41 delegate = Class565.delegate41_0;
			Delegate41 delegate2;
			do
			{
				delegate2 = delegate;
				Delegate41 value = (Delegate41)Delegate.Remove(delegate2, delegate41_1);
				delegate = Interlocked.CompareExchange<Delegate41>(ref Class565.delegate41_0, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x060024BC RID: 9404
		// RVA: 0x000DD770 File Offset: 0x000DB970
		protected static void smethod_2(Delegate40 delegate40_3)
		{
			Delegate40 delegate = Class565.delegate40_1;
			Delegate40 delegate2;
			do
			{
				delegate2 = delegate;
				Delegate40 value = (Delegate40)Delegate.Combine(delegate2, delegate40_3);
				delegate = Interlocked.CompareExchange<Delegate40>(ref Class565.delegate40_1, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x060024BD RID: 9405
		// RVA: 0x000DD7A4 File Offset: 0x000DB9A4
		protected static void smethod_3(Delegate40 delegate40_3)
		{
			Delegate40 delegate = Class565.delegate40_1;
			Delegate40 delegate2;
			do
			{
				delegate2 = delegate;
				Delegate40 value = (Delegate40)Delegate.Remove(delegate2, delegate40_3);
				delegate = Interlocked.CompareExchange<Delegate40>(ref Class565.delegate40_1, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x060024B8 RID: 9400
		// RVA: 0x0001CB42 File Offset: 0x0001AD42
		internal override void vmethod_0()
		{
			Class565.rectangle_0 = Class559.Class560.smethod_0();
			base.vmethod_0();
		}
	}
}
