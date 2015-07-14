using Newtonsoft.Json.Serialization;
using System;
using System.Globalization;
using System.Reflection;
using System.Reflection.Emit;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200012F RID: 303
	internal sealed class DynamicReflectionDelegateFactory : ReflectionDelegateFactory
	{
		// Token: 0x04000531 RID: 1329
		public static DynamicReflectionDelegateFactory Instance = new DynamicReflectionDelegateFactory();

		// Token: 0x06000C79 RID: 3193
		// RVA: 0x000487B0 File Offset: 0x000469B0
		public override Func<T> CreateDefaultConstructor<T>(Type type)
		{
			DynamicMethod dynamicMethod = DynamicReflectionDelegateFactory.CreateDynamicMethod("Create" + type.FullName, typeof(T), ReflectionUtils.EmptyTypes, type);
			dynamicMethod.InitLocals = true;
			ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
			this.GenerateCreateDefaultConstructorIL(type, iLGenerator);
			return (Func<T>)dynamicMethod.CreateDelegate(typeof(Func<T>));
		}

		// Token: 0x06000C75 RID: 3189
		// RVA: 0x00048400 File Offset: 0x00046600
		private static DynamicMethod CreateDynamicMethod(string name, Type returnType, Type[] parameterTypes, Type owner)
		{
			return (!TypeExtensions.IsInterface(owner)) ? new DynamicMethod(name, returnType, parameterTypes, owner, true) : new DynamicMethod(name, returnType, parameterTypes, owner.Module, true);
		}

		// Token: 0x06000C7B RID: 3195
		// RVA: 0x00048884 File Offset: 0x00046A84
		public override Func<T, object> CreateGet<T>(PropertyInfo propertyInfo)
		{
			DynamicMethod dynamicMethod = DynamicReflectionDelegateFactory.CreateDynamicMethod("Get" + propertyInfo.Name, typeof(T), new Type[]
			{
				typeof(object)
			}, propertyInfo.DeclaringType);
			ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
			this.GenerateCreateGetPropertyIL(propertyInfo, iLGenerator);
			return (Func<T, object>)dynamicMethod.CreateDelegate(typeof(Func<T, object>));
		}

		// Token: 0x06000C7D RID: 3197
		// RVA: 0x00048950 File Offset: 0x00046B50
		public override Func<T, object> CreateGet<T>(FieldInfo fieldInfo)
		{
			if (fieldInfo.IsLiteral)
			{
				object constantValue = fieldInfo.GetValue(null);
				return (T o) => constantValue;
			}
			DynamicMethod dynamicMethod = DynamicReflectionDelegateFactory.CreateDynamicMethod("Get" + fieldInfo.Name, typeof(T), new Type[]
			{
				typeof(object)
			}, fieldInfo.DeclaringType);
			ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
			this.GenerateCreateGetFieldIL(fieldInfo, iLGenerator);
			return (Func<T, object>)dynamicMethod.CreateDelegate(typeof(Func<T, object>));
		}

		// Token: 0x06000C77 RID: 3191
		// RVA: 0x00048498 File Offset: 0x00046698
		public override MethodCall<T, object> CreateMethodCall<T>(MethodBase method)
		{
			DynamicMethod dynamicMethod = DynamicReflectionDelegateFactory.CreateDynamicMethod(method.ToString(), typeof(object), new Type[]
			{
				typeof(object),
				typeof(object[])
			}, method.DeclaringType);
			ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
			this.GenerateCreateMethodCallIL(method, iLGenerator, 1);
			return (MethodCall<T, object>)dynamicMethod.CreateDelegate(typeof(MethodCall<T, object>));
		}

		// Token: 0x06000C76 RID: 3190
		// RVA: 0x00048434 File Offset: 0x00046634
		public override ObjectConstructor<object> CreateParametrizedConstructor(MethodBase method)
		{
			DynamicMethod dynamicMethod = DynamicReflectionDelegateFactory.CreateDynamicMethod(method.ToString(), typeof(object), new Type[]
			{
				typeof(object[])
			}, method.DeclaringType);
			ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
			this.GenerateCreateMethodCallIL(method, iLGenerator, 0);
			return (ObjectConstructor<object>)dynamicMethod.CreateDelegate(typeof(ObjectConstructor<object>));
		}

		// Token: 0x06000C7F RID: 3199
		// RVA: 0x00048A3C File Offset: 0x00046C3C
		public override Action<T, object> CreateSet<T>(FieldInfo fieldInfo)
		{
			DynamicMethod dynamicMethod = DynamicReflectionDelegateFactory.CreateDynamicMethod("Set" + fieldInfo.Name, null, new Type[]
			{
				typeof(T),
				typeof(object)
			}, fieldInfo.DeclaringType);
			ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
			DynamicReflectionDelegateFactory.GenerateCreateSetFieldIL(fieldInfo, iLGenerator);
			return (Action<T, object>)dynamicMethod.CreateDelegate(typeof(Action<T, object>));
		}

		// Token: 0x06000C81 RID: 3201
		// RVA: 0x00048B0C File Offset: 0x00046D0C
		public override Action<T, object> CreateSet<T>(PropertyInfo propertyInfo)
		{
			DynamicMethod dynamicMethod = DynamicReflectionDelegateFactory.CreateDynamicMethod("Set" + propertyInfo.Name, null, new Type[]
			{
				typeof(T),
				typeof(object)
			}, propertyInfo.DeclaringType);
			ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
			DynamicReflectionDelegateFactory.GenerateCreateSetPropertyIL(propertyInfo, iLGenerator);
			return (Action<T, object>)dynamicMethod.CreateDelegate(typeof(Action<T, object>));
		}

		// Token: 0x06000C7A RID: 3194
		// RVA: 0x00048810 File Offset: 0x00046A10
		private void GenerateCreateDefaultConstructorIL(Type type, ILGenerator generator)
		{
			if (TypeExtensions.IsValueType(type))
			{
				generator.DeclareLocal(type);
				generator.Emit(OpCodes.Ldloc_0);
				generator.Emit(OpCodes.Box, type);
			}
			else
			{
				ConstructorInfo constructor = type.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, ReflectionUtils.EmptyTypes, null);
				if (constructor == null)
				{
					throw new ArgumentException(StringUtils.FormatWith("Could not get constructor for {0}.", CultureInfo.InvariantCulture, type));
				}
				generator.Emit(OpCodes.Newobj, constructor);
			}
			ILGeneratorExtensions.Return(generator);
		}

		// Token: 0x06000C7E RID: 3198
		// RVA: 0x000489EC File Offset: 0x00046BEC
		private void GenerateCreateGetFieldIL(FieldInfo fieldInfo, ILGenerator generator)
		{
			if (!fieldInfo.IsStatic)
			{
				ILGeneratorExtensions.PushInstance(generator, fieldInfo.DeclaringType);
				generator.Emit(OpCodes.Ldfld, fieldInfo);
			}
			else
			{
				generator.Emit(OpCodes.Ldsfld, fieldInfo);
			}
			ILGeneratorExtensions.BoxIfNeeded(generator, fieldInfo.FieldType);
			ILGeneratorExtensions.Return(generator);
		}

		// Token: 0x06000C7C RID: 3196
		// RVA: 0x000488F0 File Offset: 0x00046AF0
		private void GenerateCreateGetPropertyIL(PropertyInfo propertyInfo, ILGenerator generator)
		{
			MethodInfo getMethod = propertyInfo.GetGetMethod(true);
			if (getMethod == null)
			{
				throw new ArgumentException(StringUtils.FormatWith("Property '{0}' does not have a getter.", CultureInfo.InvariantCulture, propertyInfo.Name));
			}
			if (!getMethod.IsStatic)
			{
				ILGeneratorExtensions.PushInstance(generator, propertyInfo.DeclaringType);
			}
			ILGeneratorExtensions.CallMethod(generator, getMethod);
			ILGeneratorExtensions.BoxIfNeeded(generator, propertyInfo.PropertyType);
			ILGeneratorExtensions.Return(generator);
		}

		// Token: 0x06000C78 RID: 3192
		// RVA: 0x00048508 File Offset: 0x00046708
		private void GenerateCreateMethodCallIL(MethodBase method, ILGenerator generator, int argsIndex)
		{
			ParameterInfo[] parameters = method.GetParameters();
			Label label = generator.DefineLabel();
			generator.Emit(OpCodes.Ldarg, argsIndex);
			generator.Emit(OpCodes.Ldlen);
			generator.Emit(OpCodes.Ldc_I4, parameters.Length);
			generator.Emit(OpCodes.Beq, label);
			generator.Emit(OpCodes.Newobj, typeof(TargetParameterCountException).GetConstructor(ReflectionUtils.EmptyTypes));
			generator.Emit(OpCodes.Throw);
			generator.MarkLabel(label);
			if (!method.IsConstructor && !method.IsStatic)
			{
				ILGeneratorExtensions.PushInstance(generator, method.DeclaringType);
			}
			int num = 0;
			for (int i = 0; i < parameters.Length; i++)
			{
				ParameterInfo parameterInfo = parameters[i];
				Type type = parameterInfo.ParameterType;
				if (type.IsByRef)
				{
					type = type.GetElementType();
					LocalBuilder local = generator.DeclareLocal(type);
					if (!parameterInfo.IsOut)
					{
						ILGeneratorExtensions.PushArrayInstance(generator, argsIndex, i);
						if (TypeExtensions.IsValueType(type))
						{
							Label label2 = generator.DefineLabel();
							Label label3 = generator.DefineLabel();
							generator.Emit(OpCodes.Brtrue_S, label2);
							generator.Emit(OpCodes.Ldloca_S, local);
							generator.Emit(OpCodes.Initobj, type);
							generator.Emit(OpCodes.Br_S, label3);
							generator.MarkLabel(label2);
							ILGeneratorExtensions.PushArrayInstance(generator, argsIndex, i);
							ILGeneratorExtensions.UnboxIfNeeded(generator, type);
							generator.Emit(OpCodes.Stloc, num);
							generator.MarkLabel(label3);
						}
						else
						{
							ILGeneratorExtensions.UnboxIfNeeded(generator, type);
							generator.Emit(OpCodes.Stloc, num);
						}
					}
					generator.Emit(OpCodes.Ldloca_S, local);
					num++;
				}
				else if (TypeExtensions.IsValueType(type))
				{
					ILGeneratorExtensions.PushArrayInstance(generator, argsIndex, i);
					Label label4 = generator.DefineLabel();
					Label label5 = generator.DefineLabel();
					generator.Emit(OpCodes.Brtrue_S, label4);
					LocalBuilder local2 = generator.DeclareLocal(type);
					generator.Emit(OpCodes.Ldloca_S, local2);
					generator.Emit(OpCodes.Initobj, type);
					generator.Emit(OpCodes.Ldloc, num);
					generator.Emit(OpCodes.Br_S, label5);
					generator.MarkLabel(label4);
					ILGeneratorExtensions.PushArrayInstance(generator, argsIndex, i);
					ILGeneratorExtensions.UnboxIfNeeded(generator, type);
					generator.MarkLabel(label5);
					num++;
				}
				else
				{
					ILGeneratorExtensions.PushArrayInstance(generator, argsIndex, i);
					ILGeneratorExtensions.UnboxIfNeeded(generator, type);
				}
			}
			if (method.IsConstructor)
			{
				generator.Emit(OpCodes.Newobj, (ConstructorInfo)method);
			}
			else
			{
				ILGeneratorExtensions.CallMethod(generator, (MethodInfo)method);
			}
			Type type2 = method.IsConstructor ? method.DeclaringType : ((MethodInfo)method).ReturnType;
			if (type2 != typeof(void))
			{
				ILGeneratorExtensions.BoxIfNeeded(generator, type2);
			}
			else
			{
				generator.Emit(OpCodes.Ldnull);
			}
			ILGeneratorExtensions.Return(generator);
		}

		// Token: 0x06000C80 RID: 3200
		// RVA: 0x00048AAC File Offset: 0x00046CAC
		internal static void GenerateCreateSetFieldIL(FieldInfo fieldInfo, ILGenerator generator)
		{
			if (!fieldInfo.IsStatic)
			{
				ILGeneratorExtensions.PushInstance(generator, fieldInfo.DeclaringType);
			}
			generator.Emit(OpCodes.Ldarg_1);
			ILGeneratorExtensions.UnboxIfNeeded(generator, fieldInfo.FieldType);
			if (!fieldInfo.IsStatic)
			{
				generator.Emit(OpCodes.Stfld, fieldInfo);
			}
			else
			{
				generator.Emit(OpCodes.Stsfld, fieldInfo);
			}
			ILGeneratorExtensions.Return(generator);
		}

		// Token: 0x06000C82 RID: 3202
		// RVA: 0x00048B7C File Offset: 0x00046D7C
		internal static void GenerateCreateSetPropertyIL(PropertyInfo propertyInfo, ILGenerator generator)
		{
			MethodInfo setMethod = propertyInfo.GetSetMethod(true);
			if (!setMethod.IsStatic)
			{
				ILGeneratorExtensions.PushInstance(generator, propertyInfo.DeclaringType);
			}
			generator.Emit(OpCodes.Ldarg_1);
			ILGeneratorExtensions.UnboxIfNeeded(generator, propertyInfo.PropertyType);
			ILGeneratorExtensions.CallMethod(generator, setMethod);
			ILGeneratorExtensions.Return(generator);
		}
	}
}
