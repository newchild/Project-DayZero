using System;
using System.Reflection;
using System.Reflection.Emit;

namespace ns92
{
	// Token: 0x020005AF RID: 1455
	internal sealed class Class775
	{
		// Token: 0x040026D4 RID: 9940
		private int int_0;

		// Token: 0x040026D3 RID: 9939
		private object object_0;

		// Token: 0x040026D2 RID: 9938
		private OpCode opCode_0;

		// Token: 0x06002E7A RID: 11898
		// RVA: 0x00023102 File Offset: 0x00021302
		public void method_0(OpCode opCode_1)
		{
			this.opCode_0 = opCode_1;
		}

		// Token: 0x06002E7B RID: 11899
		// RVA: 0x0002310B File Offset: 0x0002130B
		public void method_1(object object_1)
		{
			this.object_0 = object_1;
		}

		// Token: 0x06002E7C RID: 11900
		// RVA: 0x00023114 File Offset: 0x00021314
		public void method_2(int int_1)
		{
			this.int_0 = int_1;
		}

		// Token: 0x06002E7D RID: 11901
		// RVA: 0x0012DE7C File Offset: 0x0012C07C
		public string method_3()
		{
			string text = "";
			object obj = text;
			text = string.Concat(new object[]
			{
				obj,
				this.method_4((long)this.int_0),
				" : ",
				this.opCode_0
			});
			if (this.object_0 != null)
			{
				switch (this.opCode_0.OperandType)
				{
				case OperandType.InlineBrTarget:
				case OperandType.ShortInlineBrTarget:
					text = text + " " + this.method_4((long)((int)this.object_0));
					return text;
				case OperandType.InlineField:
				{
					FieldInfo fieldInfo = (FieldInfo)this.object_0;
					string text2 = text;
					text = string.Concat(new string[]
					{
						text2,
						" ",
						Class774.smethod_1(fieldInfo.FieldType.ToString()),
						" ",
						Class774.smethod_1(fieldInfo.ReflectedType.ToString()),
						"::",
						fieldInfo.Name
					});
					return text;
				}
				case OperandType.InlineI:
				case OperandType.InlineI8:
				case OperandType.InlineR:
				case OperandType.ShortInlineI:
				case OperandType.ShortInlineR:
					text += this.object_0.ToString();
					return text;
				case OperandType.InlineMethod:
					try
					{
						MethodInfo methodInfo = (MethodInfo)this.object_0;
						text += " ";
						if (!methodInfo.IsStatic)
						{
							text += "instance ";
						}
						string text3 = text;
						text = string.Concat(new string[]
						{
							text3,
							Class774.smethod_1(methodInfo.ReturnType.ToString()),
							" ",
							Class774.smethod_1(methodInfo.ReflectedType.ToString()),
							"::",
							methodInfo.Name,
							"()"
						});
						return text;
					}
					catch
					{
						try
						{
							ConstructorInfo constructorInfo = (ConstructorInfo)this.object_0;
							text += " ";
							if (!constructorInfo.IsStatic)
							{
								text += "instance ";
							}
							string text4 = text;
							text = string.Concat(new string[]
							{
								text4,
								"void ",
								Class774.smethod_1(constructorInfo.ReflectedType.ToString()),
								"::",
								constructorInfo.Name,
								"()"
							});
						}
						catch
						{
						}
						return text;
					}
					break;
				case OperandType.InlineNone:
				case OperandType.InlinePhi:
				case (OperandType)8:
				case OperandType.InlineSig:
				case OperandType.InlineSwitch:
				case OperandType.InlineVar:
					goto IL_2ED;
				case OperandType.InlineString:
					break;
				case OperandType.InlineTok:
					if (this.object_0 is Type)
					{
						text += ((Type)this.object_0).FullName;
						return text;
					}
					text += "not supported";
					return text;
				case OperandType.InlineType:
					text = text + " " + Class774.smethod_1(this.object_0.ToString());
					return text;
				case OperandType.ShortInlineVar:
					text += this.object_0.ToString();
					return text;
				default:
					goto IL_2ED;
				}
				if (this.object_0.ToString() == "\r\n")
				{
					text += " \"\\r\\n\"";
					return text;
				}
				text = text + " \"" + this.object_0.ToString() + "\"";
				return text;
				IL_2ED:
				text += "not supported";
			}
			return text;
		}

		// Token: 0x06002E7E RID: 11902
		// RVA: 0x0012E1E8 File Offset: 0x0012C3E8
		private string method_4(long long_0)
		{
			string text = long_0.ToString();
			int num = 0;
			while (text.Length < 4)
			{
				text = "0" + text;
				num++;
			}
			return text;
		}
	}
}
