using Newtonsoft.Json.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000106 RID: 262
	public sealed class JsonArrayContract : JsonContainerContract
	{
		// Token: 0x0400044B RID: 1099
		private readonly Type _genericCollectionDefinitionType;

		// Token: 0x0400044E RID: 1102
		private Func<object> _genericTemporaryCollectionCreator;

		// Token: 0x0400044D RID: 1101
		private ObjectConstructor<object> _genericWrapperCreator;

		// Token: 0x0400044C RID: 1100
		private Type _genericWrapperType;

		// Token: 0x0400044F RID: 1103
		private readonly ConstructorInfo _parametrizedConstructor;

		// Token: 0x04000450 RID: 1104
		private ObjectConstructor<object> _parametrizedCreator;

		// Token: 0x170001D4 RID: 468
		internal bool CanDeserialize
		{
			// Token: 0x06000A8F RID: 2703
			// RVA: 0x0000C530 File Offset: 0x0000A730
			get;
			// Token: 0x06000A90 RID: 2704
			// RVA: 0x0000C538 File Offset: 0x0000A738
			private set;
		}

		// Token: 0x170001D0 RID: 464
		public Type CollectionItemType
		{
			// Token: 0x06000A87 RID: 2695
			// RVA: 0x0000C4EC File Offset: 0x0000A6EC
			get;
			// Token: 0x06000A88 RID: 2696
			// RVA: 0x0000C4F4 File Offset: 0x0000A6F4
			private set;
		}

		// Token: 0x170001D6 RID: 470
		internal bool HasParametrizedCreator
		{
			// Token: 0x06000A92 RID: 2706
			// RVA: 0x0000C567 File Offset: 0x0000A767
			get
			{
				return this._parametrizedCreator != null || this._parametrizedConstructor != null;
			}
		}

		// Token: 0x170001D2 RID: 466
		internal bool IsArray
		{
			// Token: 0x06000A8B RID: 2699
			// RVA: 0x0000C50E File Offset: 0x0000A70E
			get;
			// Token: 0x06000A8C RID: 2700
			// RVA: 0x0000C516 File Offset: 0x0000A716
			private set;
		}

		// Token: 0x170001D1 RID: 465
		public bool IsMultidimensionalArray
		{
			// Token: 0x06000A89 RID: 2697
			// RVA: 0x0000C4FD File Offset: 0x0000A6FD
			get;
			// Token: 0x06000A8A RID: 2698
			// RVA: 0x0000C505 File Offset: 0x0000A705
			private set;
		}

		// Token: 0x170001D5 RID: 469
		internal ObjectConstructor<object> ParametrizedCreator
		{
			// Token: 0x06000A91 RID: 2705
			// RVA: 0x0000C541 File Offset: 0x0000A741
			get
			{
				if (this._parametrizedCreator == null)
				{
					this._parametrizedCreator = JsonTypeReflector.ReflectionDelegateFactory.CreateParametrizedConstructor(this._parametrizedConstructor);
				}
				return this._parametrizedCreator;
			}
		}

		// Token: 0x170001D3 RID: 467
		internal bool ShouldCreateWrapper
		{
			// Token: 0x06000A8D RID: 2701
			// RVA: 0x0000C51F File Offset: 0x0000A71F
			get;
			// Token: 0x06000A8E RID: 2702
			// RVA: 0x0000C527 File Offset: 0x0000A727
			private set;
		}

		// Token: 0x06000A93 RID: 2707
		// RVA: 0x0004125C File Offset: 0x0003F45C
		public JsonArrayContract(Type underlyingType) : base(underlyingType)
		{
			this.ContractType = JsonContractType.Array;
			this.IsArray = base.CreatedType.IsArray;
			bool canDeserialize;
			Type type;
			if (this.IsArray)
			{
				this.CollectionItemType = ReflectionUtils.GetCollectionItemType(base.UnderlyingType);
				this.IsReadOnlyOrFixedSize = true;
				this._genericCollectionDefinitionType = typeof(List<>).MakeGenericType(new Type[]
				{
					this.CollectionItemType
				});
				canDeserialize = true;
				this.IsMultidimensionalArray = (this.IsArray && base.UnderlyingType.GetArrayRank() > 1);
			}
			else if (typeof(IList).IsAssignableFrom(underlyingType))
			{
				if (ReflectionUtils.ImplementsGenericDefinition(underlyingType, typeof(ICollection<>), out this._genericCollectionDefinitionType))
				{
					this.CollectionItemType = this._genericCollectionDefinitionType.GetGenericArguments()[0];
				}
				else
				{
					this.CollectionItemType = ReflectionUtils.GetCollectionItemType(underlyingType);
				}
				if (underlyingType == typeof(IList))
				{
					base.CreatedType = typeof(List<object>);
				}
				if (this.CollectionItemType != null)
				{
					this._parametrizedConstructor = CollectionUtils.ResolveEnumerableCollectionConstructor(underlyingType, this.CollectionItemType);
				}
				this.IsReadOnlyOrFixedSize = ReflectionUtils.InheritsGenericDefinition(underlyingType, typeof(ReadOnlyCollection<>));
				canDeserialize = true;
			}
			else if (ReflectionUtils.ImplementsGenericDefinition(underlyingType, typeof(ICollection<>), out this._genericCollectionDefinitionType))
			{
				this.CollectionItemType = this._genericCollectionDefinitionType.GetGenericArguments()[0];
				if (ReflectionUtils.IsGenericDefinition(underlyingType, typeof(ICollection<>)) || ReflectionUtils.IsGenericDefinition(underlyingType, typeof(IList<>)))
				{
					base.CreatedType = typeof(List<>).MakeGenericType(new Type[]
					{
						this.CollectionItemType
					});
				}
				this._parametrizedConstructor = CollectionUtils.ResolveEnumerableCollectionConstructor(underlyingType, this.CollectionItemType);
				canDeserialize = true;
				this.ShouldCreateWrapper = true;
			}
			else if (ReflectionUtils.ImplementsGenericDefinition(underlyingType, typeof(IEnumerable<>), out type))
			{
				this.CollectionItemType = type.GetGenericArguments()[0];
				if (ReflectionUtils.IsGenericDefinition(base.UnderlyingType, typeof(IEnumerable<>)))
				{
					base.CreatedType = typeof(List<>).MakeGenericType(new Type[]
					{
						this.CollectionItemType
					});
				}
				this._parametrizedConstructor = CollectionUtils.ResolveEnumerableCollectionConstructor(underlyingType, this.CollectionItemType);
				if (TypeExtensions.IsGenericType(underlyingType) && underlyingType.GetGenericTypeDefinition() == typeof(IEnumerable<>))
				{
					this._genericCollectionDefinitionType = type;
					this.IsReadOnlyOrFixedSize = false;
					this.ShouldCreateWrapper = false;
					canDeserialize = true;
				}
				else
				{
					this._genericCollectionDefinitionType = typeof(List<>).MakeGenericType(new Type[]
					{
						this.CollectionItemType
					});
					this.IsReadOnlyOrFixedSize = true;
					this.ShouldCreateWrapper = true;
					canDeserialize = this.HasParametrizedCreator;
				}
			}
			else
			{
				canDeserialize = false;
				this.ShouldCreateWrapper = true;
			}
			this.CanDeserialize = canDeserialize;
			if (this.CollectionItemType != null && ReflectionUtils.IsNullableType(this.CollectionItemType) && (ReflectionUtils.InheritsGenericDefinition(base.CreatedType, typeof(List<>), out type) || (this.IsArray && !this.IsMultidimensionalArray)))
			{
				this.ShouldCreateWrapper = true;
			}
		}

		// Token: 0x06000A95 RID: 2709
		// RVA: 0x00041650 File Offset: 0x0003F850
		internal IList CreateTemporaryCollection()
		{
			if (this._genericTemporaryCollectionCreator == null)
			{
				Type type = this.IsMultidimensionalArray ? typeof(object) : this.CollectionItemType;
				Type type2 = typeof(List<>).MakeGenericType(new Type[]
				{
					type
				});
				this._genericTemporaryCollectionCreator = JsonTypeReflector.ReflectionDelegateFactory.CreateDefaultConstructor<object>(type2);
			}
			return (IList)this._genericTemporaryCollectionCreator();
		}

		// Token: 0x06000A94 RID: 2708
		// RVA: 0x0004156C File Offset: 0x0003F76C
		internal IWrappedCollection CreateWrapper(object list)
		{
			if (this._genericWrapperCreator == null)
			{
				this._genericWrapperType = typeof(CollectionWrapper<>).MakeGenericType(new Type[]
				{
					this.CollectionItemType
				});
				Type type;
				if (!ReflectionUtils.InheritsGenericDefinition(this._genericCollectionDefinitionType, typeof(List<>)))
				{
					if (this._genericCollectionDefinitionType.GetGenericTypeDefinition() != typeof(IEnumerable<>))
					{
						type = this._genericCollectionDefinitionType;
						goto IL_8B;
					}
				}
				type = typeof(ICollection<>).MakeGenericType(new Type[]
				{
					this.CollectionItemType
				});
				IL_8B:
				ConstructorInfo constructor = this._genericWrapperType.GetConstructor(new Type[]
				{
					type
				});
				this._genericWrapperCreator = JsonTypeReflector.ReflectionDelegateFactory.CreateParametrizedConstructor(constructor);
			}
			return (IWrappedCollection)this._genericWrapperCreator(new object[]
			{
				list
			});
		}
	}
}
