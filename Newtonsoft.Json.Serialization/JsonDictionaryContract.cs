using Newtonsoft.Json.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200010C RID: 268
	public sealed class JsonDictionaryContract : JsonContainerContract
	{
		// Token: 0x04000460 RID: 1120
		private readonly Type _genericCollectionDefinitionType;

		// Token: 0x04000463 RID: 1123
		private Func<object> _genericTemporaryDictionaryCreator;

		// Token: 0x04000462 RID: 1122
		private ObjectConstructor<object> _genericWrapperCreator;

		// Token: 0x04000461 RID: 1121
		private Type _genericWrapperType;

		// Token: 0x04000464 RID: 1124
		private readonly ConstructorInfo _parametrizedConstructor;

		// Token: 0x04000465 RID: 1125
		private ObjectConstructor<object> _parametrizedCreator;

		// Token: 0x170001D8 RID: 472
		public Type DictionaryKeyType
		{
			// Token: 0x06000AA8 RID: 2728
			// RVA: 0x0000C590 File Offset: 0x0000A790
			get;
			// Token: 0x06000AA9 RID: 2729
			// RVA: 0x0000C598 File Offset: 0x0000A798
			private set;
		}

		// Token: 0x170001D9 RID: 473
		public Type DictionaryValueType
		{
			// Token: 0x06000AAA RID: 2730
			// RVA: 0x0000C5A1 File Offset: 0x0000A7A1
			get;
			// Token: 0x06000AAB RID: 2731
			// RVA: 0x0000C5A9 File Offset: 0x0000A7A9
			private set;
		}

		// Token: 0x170001DD RID: 477
		internal bool HasParametrizedCreator
		{
			// Token: 0x06000AB1 RID: 2737
			// RVA: 0x0000C5FA File Offset: 0x0000A7FA
			get
			{
				return this._parametrizedCreator != null || this._parametrizedConstructor != null;
			}
		}

		// Token: 0x170001DA RID: 474
		internal JsonContract KeyContract
		{
			// Token: 0x06000AAC RID: 2732
			// RVA: 0x0000C5B2 File Offset: 0x0000A7B2
			get;
			// Token: 0x06000AAD RID: 2733
			// RVA: 0x0000C5BA File Offset: 0x0000A7BA
			set;
		}

		// Token: 0x170001DC RID: 476
		internal ObjectConstructor<object> ParametrizedCreator
		{
			// Token: 0x06000AB0 RID: 2736
			// RVA: 0x0000C5D4 File Offset: 0x0000A7D4
			get
			{
				if (this._parametrizedCreator == null)
				{
					this._parametrizedCreator = JsonTypeReflector.ReflectionDelegateFactory.CreateParametrizedConstructor(this._parametrizedConstructor);
				}
				return this._parametrizedCreator;
			}
		}

		// Token: 0x170001D7 RID: 471
		public Func<string, string> PropertyNameResolver
		{
			// Token: 0x06000AA6 RID: 2726
			// RVA: 0x0000C57F File Offset: 0x0000A77F
			get;
			// Token: 0x06000AA7 RID: 2727
			// RVA: 0x0000C587 File Offset: 0x0000A787
			set;
		}

		// Token: 0x170001DB RID: 475
		internal bool ShouldCreateWrapper
		{
			// Token: 0x06000AAE RID: 2734
			// RVA: 0x0000C5C3 File Offset: 0x0000A7C3
			get;
			// Token: 0x06000AAF RID: 2735
			// RVA: 0x0000C5CB File Offset: 0x0000A7CB
			private set;
		}

		// Token: 0x06000AB2 RID: 2738
		// RVA: 0x000416C0 File Offset: 0x0003F8C0
		public JsonDictionaryContract(Type underlyingType) : base(underlyingType)
		{
			this.ContractType = JsonContractType.Dictionary;
			Type type;
			Type type2;
			if (ReflectionUtils.ImplementsGenericDefinition(underlyingType, typeof(IDictionary<, >), out this._genericCollectionDefinitionType))
			{
				type = this._genericCollectionDefinitionType.GetGenericArguments()[0];
				type2 = this._genericCollectionDefinitionType.GetGenericArguments()[1];
				if (ReflectionUtils.IsGenericDefinition(base.UnderlyingType, typeof(IDictionary<, >)))
				{
					base.CreatedType = typeof(Dictionary<, >).MakeGenericType(new Type[]
					{
						type,
						type2
					});
				}
			}
			else
			{
				ReflectionUtils.GetDictionaryKeyValueTypes(base.UnderlyingType, out type, out type2);
				if (base.UnderlyingType == typeof(IDictionary))
				{
					base.CreatedType = typeof(Dictionary<object, object>);
				}
			}
			if (type != null && type2 != null)
			{
				this._parametrizedConstructor = CollectionUtils.ResolveEnumerableCollectionConstructor(base.CreatedType, typeof(KeyValuePair<, >).MakeGenericType(new Type[]
				{
					type,
					type2
				}));
			}
			this.ShouldCreateWrapper = !typeof(IDictionary).IsAssignableFrom(base.CreatedType);
			this.DictionaryKeyType = type;
			this.DictionaryValueType = type2;
			Type type3;
			if (this.DictionaryValueType != null && ReflectionUtils.IsNullableType(this.DictionaryValueType) && ReflectionUtils.InheritsGenericDefinition(base.CreatedType, typeof(Dictionary<, >), out type3))
			{
				this.ShouldCreateWrapper = true;
			}
		}

		// Token: 0x06000AB4 RID: 2740
		// RVA: 0x000418AC File Offset: 0x0003FAAC
		internal IDictionary CreateTemporaryDictionary()
		{
			if (this._genericTemporaryDictionaryCreator == null)
			{
				Type type = typeof(Dictionary<, >).MakeGenericType(new Type[]
				{
					this.DictionaryKeyType,
					this.DictionaryValueType
				});
				this._genericTemporaryDictionaryCreator = JsonTypeReflector.ReflectionDelegateFactory.CreateDefaultConstructor<object>(type);
			}
			return (IDictionary)this._genericTemporaryDictionaryCreator();
		}

		// Token: 0x06000AB3 RID: 2739
		// RVA: 0x0004181C File Offset: 0x0003FA1C
		internal IWrappedDictionary CreateWrapper(object dictionary)
		{
			if (this._genericWrapperCreator == null)
			{
				this._genericWrapperType = typeof(DictionaryWrapper<, >).MakeGenericType(new Type[]
				{
					this.DictionaryKeyType,
					this.DictionaryValueType
				});
				ConstructorInfo constructor = this._genericWrapperType.GetConstructor(new Type[]
				{
					this._genericCollectionDefinitionType
				});
				this._genericWrapperCreator = JsonTypeReflector.ReflectionDelegateFactory.CreateParametrizedConstructor(constructor);
			}
			return (IWrappedDictionary)this._genericWrapperCreator(new object[]
			{
				dictionary
			});
		}
	}
}
