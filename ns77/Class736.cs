using ns42;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ns77
{
	// Token: 0x02000571 RID: 1393
	internal static class Class736
	{
		// Token: 0x06002CFD RID: 11517
		// RVA: 0x001239CC File Offset: 0x00121BCC
		public static void smethod_0(int int_0, int int_1)
		{
			Struct51 struct = default(Struct51);
			struct.string_0 = new string(new char[32]);
			struct.string_1 = new string(new char[32]);
			struct.short_2 = (short)Marshal.SizeOf(struct);
			if (Class735.EnumDisplaySettings(null, -1, ref struct) != 0)
			{
				if (struct.int_1 == int_0 && struct.int_2 == int_1)
				{
					return;
				}
				struct.int_1 = int_0;
				struct.int_2 = int_1;
				int num = Class735.ChangeDisplaySettings(ref struct, 2);
				if (num == -1)
				{
					MessageBox.Show("Unable to process your request");
					MessageBox.Show("Description: Unable To Process Your Request. Sorry For This Inconvenience.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				switch (Class735.ChangeDisplaySettings(ref struct, 4))
				{
				case 0:
					break;
				case 1:
					MessageBox.Show("Description: You Need To Reboot For The Change To Happen.\n If You Feel Any Problem After Rebooting Your Machine\nThen Try To Change Resolution In Safe Mode.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				default:
					MessageBox.Show("Description: Failed To Change The Resolution.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					break;
				}
			}
		}
	}
}
