using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities.LinqBridge;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200013E RID: 318
	internal sealed class ReflectionObject
	{
		// Token: 0x17000257 RID: 599
		public ObjectConstructor<object> Creator
		{
			// Token: 0x06000CBA RID: 3258
			// RVA: 0x0000D914 File Offset: 0x0000BB14
			get;
			// Token: 0x06000CBB RID: 3259
			// RVA: 0x0000D91C File Offset: 0x0000BB1C
			private set;
		}

		// Token: 0x17000258 RID: 600
		public IDictionary<string, ReflectionMember> Members
		{
			// Token: 0x06000CBC RID: 3260
			// RVA: 0x0000D925 File Offset: 0x0000BB25
			get;
			// Token: 0x06000CBD RID: 3261
			// RVA: 0x0000D92D File Offset: 0x0000BB2D
			private set;
		}

		// Token: 0x06000CBE RID: 3262
		// RVA: 0x0000D936 File Offset: 0x0000BB36
		public ReflectionObject()
		{
			this.Members = new Dictionary<string, ReflectionMember>();
		}

		// Token: 0x06000CC2 RID: 3266
		// RVA: 0x0000D95C File Offset: 0x0000BB5C
		public static ReflectionObject Create(Type t, params string[] memberNames)
		{
			return ReflectionObject.Create(t, null, memberNames);
		}

		// Token: 0x06000CC3 RID: 3267
		// RVA: 0x00049058 File Offset: 0x00047258
		public static ReflectionObject Create(Type t, MethodBase creator, params string[] memberNames)
		{
			ReflectionObject reflectionObject = new ReflectionObject();
			ReflectionDelegateFactory reflectionDelegateFactory = JsonTypeReflector.ReflectionDelegateFactory;
			if (creator != null)
			{
				reflectionObject.Creator = reflectionDelegateFactory.CreateParametrizedConstructor(creator);
			}
			else if (ReflectionUtils.HasDefaultConstructor(t, false))
			{
				Func<object> ctor = reflectionDelegateFactory.CreateDefaultConstructor<object>(t);
				reflectionObject.Creator = ((object[] args) => ctor());
			}
			int i = 0;
			while (i < memberNames.Length)
			{
				string text = memberNames[i];
				MemberInfo[] member = t.GetMember(text, BindingFlags.Instance | BindingFlags.Public);
				if (member.Length != 1)
				{
					throw new ArgumentException(StringUtils.FormatWith("Expected a single member with the name '{0}'.", CultureInfo.InvariantCulture, text));
				}
				MemberInfo memberInfo = Enumerable.Single<MemberInfo>(member);
				ReflectionMember reflectionMember = new ReflectionMember();
				MemberTypes memberTypes = TypeExtensions.MemberType(memberInfo);
				if (memberTypes == MemberTypes.Field)
				{
					goto IL_151;
				}
				if (memberTypes != MemberTypes.Method)
				{
					if (memberTypes == MemberTypes.Property)
					{
						goto IL_151;
					}
					throw new ArgumentException(StringUtils.FormatWith("Unexpected member type '{0}' for member '{1}'.", CultureInfo.InvariantCulture, TypeExtensions.MemberType(memberInfo), memberInfo.Name));
				}
				else
				{
					MethodInfo methodInfo = (MethodInfo)memberInfo;
					if (methodInfo.IsPublic)
					{
						ParameterInfo[] parameters = methodInfo.GetParameters();
						if (parameters.Length == 0 && methodInfo.ReturnType != typeof(void))
						{
							MethodCall<object, object> call = reflectionDelegateFactory.CreateMethodCall<object>(methodInfo);
							reflectionMember.Getter = ((object target) => call(target, new object[0]));
						}
						else if (parameters.Length == 1 && methodInfo.ReturnType == typeof(void))
						{
							MethodCall<object, object> call = reflectionDelegateFactory.CreateMethodCall<object>(methodInfo);
							reflectionMember.Setter = delegate(object target, object arg)
							{
								call(target, new object[]
								{
									arg
								});
							};
						}
					}
				}
				IL_184:
				if (ReflectionUtils.CanReadMemberValue(memberInfo, false))
				{
					reflectionMember.Getter = reflectionDelegateFactory.CreateGet<object>(memberInfo);
				}
				if (ReflectionUtils.CanSetMemberValue(memberInfo, false, false))
				{
					reflectionMember.Setter = reflectionDelegateFactory.CreateSet<object>(memberInfo);
				}
				reflectionMember.MemberType = ReflectionUtils.GetMemberUnderlyingType(memberInfo);
				reflectionObject.Members[text] = reflectionMember;
				i++;
				continue;
				IL_151:
				if (ReflectionUtils.CanReadMemberValue(memberInfo, false))
				{
					reflectionMember.Getter = reflectionDelegateFactory.CreateGet<object>(memberInfo);
				}
				if (ReflectionUtils.CanSetMemberValue(memberInfo, false, false))
				{
					reflectionMember.Setter = reflectionDelegateFactory.CreateSet<object>(memberInfo);
					goto IL_184;
				}
				goto IL_184;
			}
			return reflectionObject;
		}

		// Token: 0x06000CC1 RID: 3265
		// RVA: 0x0000D949 File Offset: 0x0000BB49
		public Type GetType(string member)
		{
			return this.Members[member].MemberType;
		}

		// Token: 0x06000CBF RID: 3263
		// RVA: 0x00049008 File Offset: 0x00047208
		public object GetValue(object target, string member)
		{
			Func<object, object> getter = this.Members[member].Getter;
			return getter(target);
		}

		// Token: 0x06000CC0 RID: 3264
		// RVA: 0x00049030 File Offset: 0x00047230
		public void SetValue(object target, string member, object value)
		{
			Action<object, object> setter = this.Members[member].Setter;
			setter(target, value);
		}
	}
}
