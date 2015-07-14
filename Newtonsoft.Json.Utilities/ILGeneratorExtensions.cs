using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000131 RID: 305
	[ExtensionAttribute2]
	internal static class ILGeneratorExtensions
	{
		// Token: 0x06000C89 RID: 3209
		// RVA: 0x0000D75E File Offset: 0x0000B95E
		[ExtensionAttribute2]
		public static void BoxIfNeeded(ILGenerator generator, Type type)
		{
			if (TypeExtensions.IsValueType(type))
			{
				generator.Emit(OpCodes.Box, type);
				return;
			}
			generator.Emit(OpCodes.Castclass, type);
		}

		// Token: 0x06000C8B RID: 3211
		// RVA: 0x0000D7A4 File Offset: 0x0000B9A4
		[ExtensionAttribute2]
		public static void CallMethod(ILGenerator generator, MethodInfo methodInfo)
		{
			if (!methodInfo.IsFinal && methodInfo.IsVirtual)
			{
				generator.Emit(OpCodes.Callvirt, methodInfo);
				return;
			}
			generator.Emit(OpCodes.Call, methodInfo);
		}

		// Token: 0x06000C88 RID: 3208
		// RVA: 0x0000D739 File Offset: 0x0000B939
		[ExtensionAttribute2]
		public static void PushArrayInstance(ILGenerator generator, int argsIndex, int arrayIndex)
		{
			generator.Emit(OpCodes.Ldarg, argsIndex);
			generator.Emit(OpCodes.Ldc_I4, arrayIndex);
			generator.Emit(OpCodes.Ldelem_Ref);
		}

		// Token: 0x06000C87 RID: 3207
		// RVA: 0x0000D70B File Offset: 0x0000B90B
		[ExtensionAttribute2]
		public static void PushInstance(ILGenerator generator, Type type)
		{
			generator.Emit(OpCodes.Ldarg_0);
			if (TypeExtensions.IsValueType(type))
			{
				generator.Emit(OpCodes.Unbox, type);
				return;
			}
			generator.Emit(OpCodes.Castclass, type);
		}

		// Token: 0x06000C8C RID: 3212
		// RVA: 0x0000D7CF File Offset: 0x0000B9CF
		[ExtensionAttribute2]
		public static void Return(ILGenerator generator)
		{
			generator.Emit(OpCodes.Ret);
		}

		// Token: 0x06000C8A RID: 3210
		// RVA: 0x0000D781 File Offset: 0x0000B981
		[ExtensionAttribute2]
		public static void UnboxIfNeeded(ILGenerator generator, Type type)
		{
			if (TypeExtensions.IsValueType(type))
			{
				generator.Emit(OpCodes.Unbox_Any, type);
				return;
			}
			generator.Emit(OpCodes.Castclass, type);
		}
	}
}
