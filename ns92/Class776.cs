using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

namespace ns92
{
	// Token: 0x020005B0 RID: 1456
	internal sealed class Class776
	{
		// Token: 0x040026D6 RID: 9942
		protected byte[] byte_0;

		// Token: 0x040026D5 RID: 9941
		public List<Class775> list_0;

		// Token: 0x040026D7 RID: 9943
		private MethodBase methodBase_0;

		// Token: 0x06002E89 RID: 11913
		// RVA: 0x0012E9C4 File Offset: 0x0012CBC4
		public Class776(MethodBase methodBase_1)
		{
			this.methodBase_0 = methodBase_1;
			byte[] array = (methodBase_1.GetMethodBody() != null) ? methodBase_1.GetMethodBody().GetILAsByteArray() : null;
			if (array != null)
			{
				this.byte_0 = array;
				this.method_3(methodBase_1.Module);
			}
		}

		// Token: 0x06002E80 RID: 11904
		// RVA: 0x0012E21C File Offset: 0x0012C41C
		private ushort method_0(byte[] byte_1, ref int int_0)
		{
			return (ushort)((int)this.byte_0[int_0++] | (int)this.byte_0[int_0++] << 8);
		}

		// Token: 0x06002E84 RID: 11908
		// RVA: 0x0012E408 File Offset: 0x0012C608
		private sbyte method_1(byte[] byte_1, ref int int_0)
		{
			return (sbyte)this.byte_0[int_0++];
		}

		// Token: 0x06002E86 RID: 11910
		// RVA: 0x0012E448 File Offset: 0x0012C648
		private float method_2(byte[] byte_1, ref int int_0)
		{
			return (float)((int)this.byte_0[int_0++] | (int)this.byte_0[int_0++] << 8 | (int)this.byte_0[int_0++] << 16 | (int)this.byte_0[int_0++] << 24);
		}

		// Token: 0x06002E87 RID: 11911
		// RVA: 0x0012E4A4 File Offset: 0x0012C6A4
		private void method_3(Module module_0)
		{
			byte[] array = this.byte_0;
			int i = 0;
			this.list_0 = new List<Class775>();
			while (i < array.Length)
			{
				Class775 class = new Class775();
				OpCode opCode_ = OpCodes.Nop;
				ushort num = (ushort)array[i++];
				if (num != 254)
				{
					opCode_ = Class774.opCode_1[(int)num];
				}
				else
				{
					num = (ushort)array[i++];
					opCode_ = Class774.opCode_0[(int)num];
					num |= 65024;
				}
				class.method_0(opCode_);
				class.method_2(i - 1);
				int num2 = 0;
				switch (opCode_.OperandType)
				{
				case OperandType.InlineBrTarget:
					num2 = this.ReadInt32(array, ref i);
					num2 += i;
					class.method_1(num2);
					break;
				case OperandType.InlineField:
					num2 = this.ReadInt32(array, ref i);
					if (this.methodBase_0 is ConstructorInfo)
					{
						class.method_1(module_0.ResolveField(num2, this.methodBase_0.DeclaringType.GetGenericArguments(), null));
					}
					else
					{
						class.method_1(module_0.ResolveField(num2, this.methodBase_0.DeclaringType.GetGenericArguments(), this.methodBase_0.GetGenericArguments()));
					}
					break;
				case OperandType.InlineI:
					class.method_1(this.ReadInt32(array, ref i));
					break;
				case OperandType.InlineI8:
					class.method_1(this.ReadInt64(array, ref i));
					break;
				case OperandType.InlineMethod:
					num2 = this.ReadInt32(array, ref i);
					try
					{
						if (this.methodBase_0 is ConstructorInfo)
						{
							class.method_1(module_0.ResolveMethod(num2, this.methodBase_0.DeclaringType.GetGenericArguments(), null));
						}
						else
						{
							class.method_1(module_0.ResolveMethod(num2, this.methodBase_0.DeclaringType.GetGenericArguments(), this.methodBase_0.GetGenericArguments()));
						}
						break;
					}
					catch
					{
						if (this.methodBase_0 is ConstructorInfo)
						{
							class.method_1(module_0.ResolveMember(num2, this.methodBase_0.DeclaringType.GetGenericArguments(), null));
						}
						else
						{
							class.method_1(module_0.ResolveMember(num2, this.methodBase_0.DeclaringType.GetGenericArguments(), this.methodBase_0.GetGenericArguments()));
						}
						break;
					}
					goto IL_26C;
				case OperandType.InlineNone:
					goto IL_26C;
				case OperandType.InlinePhi:
				case (OperandType)8:
					goto IL_49B;
				case OperandType.InlineR:
					class.method_1(this.ReadDouble(array, ref i));
					break;
				case OperandType.InlineSig:
					num2 = this.ReadInt32(array, ref i);
					class.method_1(module_0.ResolveSignature(num2));
					break;
				case OperandType.InlineString:
					num2 = this.ReadInt32(array, ref i);
					class.method_1(module_0.ResolveString(num2));
					break;
				case OperandType.InlineSwitch:
				{
					int num3 = this.ReadInt32(array, ref i);
					int[] array2 = new int[num3];
					for (int j = 0; j < num3; j++)
					{
						array2[j] = this.ReadInt32(array, ref i);
					}
					int[] array3 = new int[num3];
					for (int k = 0; k < num3; k++)
					{
						array3[k] = i + array2[k];
					}
					break;
				}
				case OperandType.InlineTok:
					num2 = this.ReadInt32(array, ref i);
					try
					{
						if (this.methodBase_0 is ConstructorInfo)
						{
							class.method_1(module_0.ResolveType(num2, this.methodBase_0.DeclaringType.GetGenericArguments(), null));
						}
						else
						{
							class.method_1(module_0.ResolveType(num2, this.methodBase_0.DeclaringType.GetGenericArguments(), this.methodBase_0.GetGenericArguments()));
						}
						break;
					}
					catch
					{
						break;
					}
					goto IL_398;
				case OperandType.InlineType:
					goto IL_398;
				case OperandType.InlineVar:
					class.method_1(this.method_0(array, ref i));
					break;
				case OperandType.ShortInlineBrTarget:
					class.method_1((int)this.method_1(array, ref i) + i);
					break;
				case OperandType.ShortInlineI:
					class.method_1(this.method_1(array, ref i));
					break;
				case OperandType.ShortInlineR:
					class.method_1(this.method_2(array, ref i));
					break;
				case OperandType.ShortInlineVar:
					class.method_1(this.ReadByte(array, ref i));
					break;
				default:
					goto IL_49B;
				}
				IL_48A:
				this.list_0.Add(class);
				continue;
				IL_26C:
				class.method_1(null);
				goto IL_48A;
				IL_398:
				num2 = this.ReadInt32(array, ref i);
				if (this.methodBase_0 is MethodInfo)
				{
					class.method_1(module_0.ResolveType(num2, this.methodBase_0.DeclaringType.GetGenericArguments(), this.methodBase_0.GetGenericArguments()));
					goto IL_48A;
				}
				if (this.methodBase_0 is ConstructorInfo)
				{
					class.method_1(module_0.ResolveType(num2, this.methodBase_0.DeclaringType.GetGenericArguments(), null));
					goto IL_48A;
				}
				class.method_1(module_0.ResolveType(num2));
				goto IL_48A;
				IL_49B:
				throw new Exception("Unknown operand type.");
			}
		}

		// Token: 0x06002E88 RID: 11912
		// RVA: 0x0012E974 File Offset: 0x0012CB74
		public string method_4()
		{
			string text = "";
			if (this.list_0 != null)
			{
				for (int i = 0; i < this.list_0.Count; i++)
				{
					text = text + this.list_0[i].method_3() + "\n";
				}
			}
			return text;
		}

		// Token: 0x06002E85 RID: 11909
		// RVA: 0x0012E428 File Offset: 0x0012C628
		private byte ReadByte(byte[] byte_1, ref int int_0)
		{
			return this.byte_0[int_0++];
		}

		// Token: 0x06002E83 RID: 11907
		// RVA: 0x0012E358 File Offset: 0x0012C558
		private double ReadDouble(byte[] byte_1, ref int int_0)
		{
			return (double)((int)this.byte_0[int_0++] | (int)this.byte_0[int_0++] << 8 | (int)this.byte_0[int_0++] << 16 | (int)this.byte_0[int_0++] << 24 | (int)this.byte_0[int_0++] | (int)this.byte_0[int_0++] << 8 | (int)this.byte_0[int_0++] << 16 | (int)this.byte_0[int_0++] << 24);
		}

		// Token: 0x06002E81 RID: 11905
		// RVA: 0x0012E250 File Offset: 0x0012C450
		private int ReadInt32(byte[] byte_1, ref int int_0)
		{
			return (int)this.byte_0[int_0++] | (int)this.byte_0[int_0++] << 8 | (int)this.byte_0[int_0++] << 16 | (int)this.byte_0[int_0++] << 24;
		}

		// Token: 0x06002E82 RID: 11906
		// RVA: 0x0012E2A8 File Offset: 0x0012C4A8
		private ulong ReadInt64(byte[] byte_1, ref int int_0)
		{
			return (ulong)((long)((int)this.byte_0[int_0++] | (int)this.byte_0[int_0++] << 8 | (int)this.byte_0[int_0++] << 16 | (int)this.byte_0[int_0++] << 24 | (int)this.byte_0[int_0++] | (int)this.byte_0[int_0++] << 8 | (int)this.byte_0[int_0++] << 16 | (int)this.byte_0[int_0++] << 24));
		}
	}
}
