using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

namespace ns92
{
	// Token: 0x020005AE RID: 1454
	internal static class Class774
	{
		// Token: 0x040026CE RID: 9934
		public static Dictionary<int, object> dictionary_0 = new Dictionary<int, object>();

		// Token: 0x040026D1 RID: 9937
		public static Module[] module_0 = null;

		// Token: 0x040026CF RID: 9935
		public static OpCode[] opCode_0;

		// Token: 0x040026D0 RID: 9936
		public static OpCode[] opCode_1;

		// Token: 0x06002E77 RID: 11895
		// RVA: 0x0012DD3C File Offset: 0x0012BF3C
		public static void smethod_0()
		{
			Class774.opCode_1 = new OpCode[256];
			Class774.opCode_0 = new OpCode[256];
			FieldInfo[] fields = typeof(OpCodes).GetFields();
			for (int i = 0; i < fields.Length; i++)
			{
				FieldInfo fieldInfo = fields[i];
				if (fieldInfo.FieldType == typeof(OpCode))
				{
					OpCode opCode = (OpCode)fieldInfo.GetValue(null);
					ushort num = (ushort)opCode.Value;
					if (num < 256)
					{
						Class774.opCode_1[(int)num] = opCode;
					}
					else
					{
						if ((num & 65280) != 65024)
						{
							throw new Exception("Invalid OpCode.");
						}
						Class774.opCode_0[(int)(num & 255)] = opCode;
					}
				}
			}
		}

		// Token: 0x06002E78 RID: 11896
		// RVA: 0x0012DE08 File Offset: 0x0012C008
		public static string smethod_1(string string_0)
		{
			string result = string_0;
			if (string_0 != null)
			{
				if (!(string_0 == "System.string") && !(string_0 == "System.String") && !(string_0 == "String"))
				{
					if (string_0 == "System.Int32" || string_0 == "Int" || string_0 == "Int32")
					{
						result = "int";
					}
				}
				else
				{
					result = "string";
				}
			}
			return result;
		}
	}
}
