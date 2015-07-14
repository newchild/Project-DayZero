using Newtonsoft.Json.Utilities;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200005F RID: 95
	public abstract class JsonContract
	{
		// Token: 0x04000184 RID: 388
		internal JsonContractType ContractType;

		// Token: 0x04000183 RID: 387
		internal ReadType InternalReadType;

		// Token: 0x04000180 RID: 384
		internal bool IsConvertable;

		// Token: 0x04000181 RID: 385
		internal bool IsEnum;

		// Token: 0x04000187 RID: 391
		internal bool IsInstantiable;

		// Token: 0x0400017F RID: 383
		internal bool IsNullable;

		// Token: 0x04000185 RID: 389
		internal bool IsReadOnlyOrFixedSize;

		// Token: 0x04000186 RID: 390
		internal bool IsSealed;

		// Token: 0x04000182 RID: 386
		internal Type NonNullableUnderlyingType;

		// Token: 0x0400018D RID: 397
		private Type _createdType;

		// Token: 0x04000188 RID: 392
		private List<SerializationCallback> _onDeserializedCallbacks;

		// Token: 0x04000189 RID: 393
		private IList<SerializationCallback> _onDeserializingCallbacks;

		// Token: 0x0400018C RID: 396
		private IList<SerializationErrorCallback> _onErrorCallbacks;

		// Token: 0x0400018A RID: 394
		private IList<SerializationCallback> _onSerializedCallbacks;

		// Token: 0x0400018B RID: 395
		private IList<SerializationCallback> _onSerializingCallbacks;

		// Token: 0x17000066 RID: 102
		public JsonConverter Converter
		{
			// Token: 0x0600028E RID: 654
			// RVA: 0x000076AF File Offset: 0x000058AF
			get;
			// Token: 0x0600028F RID: 655
			// RVA: 0x000076B7 File Offset: 0x000058B7
			set;
		}

		// Token: 0x17000064 RID: 100
		public Type CreatedType
		{
			// Token: 0x0600028A RID: 650
			// RVA: 0x00007658 File Offset: 0x00005858
			get
			{
				return this._createdType;
			}
			// Token: 0x0600028B RID: 651
			// RVA: 0x00007660 File Offset: 0x00005860
			set
			{
				this._createdType = value;
				this.IsSealed = TypeExtensions.IsSealed(this._createdType);
				this.IsInstantiable = (!TypeExtensions.IsInterface(this._createdType) && !TypeExtensions.IsAbstract(this._createdType));
			}
		}

		// Token: 0x17000072 RID: 114
		public Func<object> DefaultCreator
		{
			// Token: 0x060002A1 RID: 673
			// RVA: 0x0000789D File Offset: 0x00005A9D
			get;
			// Token: 0x060002A2 RID: 674
			// RVA: 0x000078A5 File Offset: 0x00005AA5
			set;
		}

		// Token: 0x17000073 RID: 115
		public bool DefaultCreatorNonPublic
		{
			// Token: 0x060002A3 RID: 675
			// RVA: 0x000078AE File Offset: 0x00005AAE
			get;
			// Token: 0x060002A4 RID: 676
			// RVA: 0x000078B6 File Offset: 0x00005AB6
			set;
		}

		// Token: 0x17000067 RID: 103
		internal JsonConverter InternalConverter
		{
			// Token: 0x06000290 RID: 656
			// RVA: 0x000076C0 File Offset: 0x000058C0
			get;
			// Token: 0x06000291 RID: 657
			// RVA: 0x000076C8 File Offset: 0x000058C8
			set;
		}

		// Token: 0x17000065 RID: 101
		public bool? IsReference
		{
			// Token: 0x0600028C RID: 652
			// RVA: 0x0000769E File Offset: 0x0000589E
			get;
			// Token: 0x0600028D RID: 653
			// RVA: 0x000076A6 File Offset: 0x000058A6
			set;
		}

		// Token: 0x1700006D RID: 109
		[Obsolete("This property is obsolete and has been replaced by the OnDeserializedCallbacks collection.")]
		public MethodInfo OnDeserialized
		{
			// Token: 0x06000297 RID: 663
			// RVA: 0x00007758 File Offset: 0x00005958
			get
			{
				if (this.OnDeserializedCallbacks.Count <= 0)
				{
					return null;
				}
				return TypeExtensions.Method(this.OnDeserializedCallbacks[0]);
			}
			// Token: 0x06000298 RID: 664
			// RVA: 0x0000777B File Offset: 0x0000597B
			set
			{
				this.OnDeserializedCallbacks.Clear();
				this.OnDeserializedCallbacks.Add(JsonContract.CreateSerializationCallback(value));
			}
		}

		// Token: 0x17000068 RID: 104
		public IList<SerializationCallback> OnDeserializedCallbacks
		{
			// Token: 0x06000292 RID: 658
			// RVA: 0x000076D1 File Offset: 0x000058D1
			get
			{
				if (this._onDeserializedCallbacks == null)
				{
					this._onDeserializedCallbacks = new List<SerializationCallback>();
				}
				return this._onDeserializedCallbacks;
			}
		}

		// Token: 0x1700006E RID: 110
		[Obsolete("This property is obsolete and has been replaced by the OnDeserializingCallbacks collection.")]
		public MethodInfo OnDeserializing
		{
			// Token: 0x06000299 RID: 665
			// RVA: 0x00007799 File Offset: 0x00005999
			get
			{
				if (this.OnDeserializingCallbacks.Count <= 0)
				{
					return null;
				}
				return TypeExtensions.Method(this.OnDeserializingCallbacks[0]);
			}
			// Token: 0x0600029A RID: 666
			// RVA: 0x000077BC File Offset: 0x000059BC
			set
			{
				this.OnDeserializingCallbacks.Clear();
				this.OnDeserializingCallbacks.Add(JsonContract.CreateSerializationCallback(value));
			}
		}

		// Token: 0x17000069 RID: 105
		public IList<SerializationCallback> OnDeserializingCallbacks
		{
			// Token: 0x06000293 RID: 659
			// RVA: 0x000076EC File Offset: 0x000058EC
			get
			{
				if (this._onDeserializingCallbacks == null)
				{
					this._onDeserializingCallbacks = new List<SerializationCallback>();
				}
				return this._onDeserializingCallbacks;
			}
		}

		// Token: 0x17000071 RID: 113
		[Obsolete("This property is obsolete and has been replaced by the OnErrorCallbacks collection.")]
		public MethodInfo OnError
		{
			// Token: 0x0600029F RID: 671
			// RVA: 0x0000785C File Offset: 0x00005A5C
			get
			{
				if (this.OnErrorCallbacks.Count <= 0)
				{
					return null;
				}
				return TypeExtensions.Method(this.OnErrorCallbacks[0]);
			}
			// Token: 0x060002A0 RID: 672
			// RVA: 0x0000787F File Offset: 0x00005A7F
			set
			{
				this.OnErrorCallbacks.Clear();
				this.OnErrorCallbacks.Add(JsonContract.CreateSerializationErrorCallback(value));
			}
		}

		// Token: 0x1700006C RID: 108
		public IList<SerializationErrorCallback> OnErrorCallbacks
		{
			// Token: 0x06000296 RID: 662
			// RVA: 0x0000773D File Offset: 0x0000593D
			get
			{
				if (this._onErrorCallbacks == null)
				{
					this._onErrorCallbacks = new List<SerializationErrorCallback>();
				}
				return this._onErrorCallbacks;
			}
		}

		// Token: 0x1700006F RID: 111
		[Obsolete("This property is obsolete and has been replaced by the OnSerializedCallbacks collection.")]
		public MethodInfo OnSerialized
		{
			// Token: 0x0600029B RID: 667
			// RVA: 0x000077DA File Offset: 0x000059DA
			get
			{
				if (this.OnSerializedCallbacks.Count <= 0)
				{
					return null;
				}
				return TypeExtensions.Method(this.OnSerializedCallbacks[0]);
			}
			// Token: 0x0600029C RID: 668
			// RVA: 0x000077FD File Offset: 0x000059FD
			set
			{
				this.OnSerializedCallbacks.Clear();
				this.OnSerializedCallbacks.Add(JsonContract.CreateSerializationCallback(value));
			}
		}

		// Token: 0x1700006A RID: 106
		public IList<SerializationCallback> OnSerializedCallbacks
		{
			// Token: 0x06000294 RID: 660
			// RVA: 0x00007707 File Offset: 0x00005907
			get
			{
				if (this._onSerializedCallbacks == null)
				{
					this._onSerializedCallbacks = new List<SerializationCallback>();
				}
				return this._onSerializedCallbacks;
			}
		}

		// Token: 0x17000070 RID: 112
		[Obsolete("This property is obsolete and has been replaced by the OnSerializingCallbacks collection.")]
		public MethodInfo OnSerializing
		{
			// Token: 0x0600029D RID: 669
			// RVA: 0x0000781B File Offset: 0x00005A1B
			get
			{
				if (this.OnSerializingCallbacks.Count <= 0)
				{
					return null;
				}
				return TypeExtensions.Method(this.OnSerializingCallbacks[0]);
			}
			// Token: 0x0600029E RID: 670
			// RVA: 0x0000783E File Offset: 0x00005A3E
			set
			{
				this.OnSerializingCallbacks.Clear();
				this.OnSerializingCallbacks.Add(JsonContract.CreateSerializationCallback(value));
			}
		}

		// Token: 0x1700006B RID: 107
		public IList<SerializationCallback> OnSerializingCallbacks
		{
			// Token: 0x06000295 RID: 661
			// RVA: 0x00007722 File Offset: 0x00005922
			get
			{
				if (this._onSerializingCallbacks == null)
				{
					this._onSerializingCallbacks = new List<SerializationCallback>();
				}
				return this._onSerializingCallbacks;
			}
		}

		// Token: 0x17000063 RID: 99
		public Type UnderlyingType
		{
			// Token: 0x06000288 RID: 648
			// RVA: 0x00007647 File Offset: 0x00005847
			get;
			// Token: 0x06000289 RID: 649
			// RVA: 0x0000764F File Offset: 0x0000584F
			private set;
		}

		// Token: 0x060002A5 RID: 677
		// RVA: 0x0002EEF0 File Offset: 0x0002D0F0
		internal JsonContract(Type underlyingType)
		{
			ValidationUtils.ArgumentNotNull(underlyingType, "underlyingType");
			this.UnderlyingType = underlyingType;
			this.IsNullable = ReflectionUtils.IsNullable(underlyingType);
			this.NonNullableUnderlyingType = ((!this.IsNullable || !ReflectionUtils.IsNullableType(underlyingType)) ? underlyingType : Nullable.GetUnderlyingType(underlyingType));
			this.CreatedType = this.NonNullableUnderlyingType;
			this.IsConvertable = ConvertUtils.IsConvertible(this.NonNullableUnderlyingType);
			this.IsEnum = TypeExtensions.IsEnum(this.NonNullableUnderlyingType);
			if (this.NonNullableUnderlyingType == typeof(byte[]))
			{
				this.InternalReadType = ReadType.ReadAsBytes;
				return;
			}
			if (this.NonNullableUnderlyingType == typeof(int))
			{
				this.InternalReadType = ReadType.ReadAsInt32;
				return;
			}
			if (this.NonNullableUnderlyingType == typeof(decimal))
			{
				this.InternalReadType = ReadType.ReadAsDecimal;
				return;
			}
			if (this.NonNullableUnderlyingType == typeof(string))
			{
				this.InternalReadType = ReadType.ReadAsString;
				return;
			}
			if (this.NonNullableUnderlyingType == typeof(DateTime))
			{
				this.InternalReadType = ReadType.ReadAsDateTime;
				return;
			}
			this.InternalReadType = ReadType.Read;
		}

		// Token: 0x060002AB RID: 683
		// RVA: 0x0002F1B8 File Offset: 0x0002D3B8
		internal static SerializationCallback CreateSerializationCallback(MethodInfo callbackMethodInfo)
		{
			return delegate(object o, StreamingContext context)
			{
				callbackMethodInfo.Invoke(o, new object[]
				{
					context
				});
			};
		}

		// Token: 0x060002AC RID: 684
		// RVA: 0x0002F1E0 File Offset: 0x0002D3E0
		internal static SerializationErrorCallback CreateSerializationErrorCallback(MethodInfo callbackMethodInfo)
		{
			return delegate(object o, StreamingContext context, ErrorContext econtext)
			{
				callbackMethodInfo.Invoke(o, new object[]
				{
					context,
					econtext
				});
			};
		}

		// Token: 0x060002A9 RID: 681
		// RVA: 0x0002F100 File Offset: 0x0002D300
		internal void InvokeOnDeserialized(object o, StreamingContext context)
		{
			if (this._onDeserializedCallbacks != null)
			{
				foreach (SerializationCallback current in this._onDeserializedCallbacks)
				{
					current(o, context);
				}
			}
		}

		// Token: 0x060002A8 RID: 680
		// RVA: 0x0002F0A8 File Offset: 0x0002D2A8
		internal void InvokeOnDeserializing(object o, StreamingContext context)
		{
			if (this._onDeserializingCallbacks != null)
			{
				foreach (SerializationCallback current in this._onDeserializingCallbacks)
				{
					current(o, context);
				}
			}
		}

		// Token: 0x060002AA RID: 682
		// RVA: 0x0002F160 File Offset: 0x0002D360
		internal void InvokeOnError(object o, StreamingContext context, ErrorContext errorContext)
		{
			if (this._onErrorCallbacks != null)
			{
				foreach (SerializationErrorCallback current in this._onErrorCallbacks)
				{
					current(o, context, errorContext);
				}
			}
		}

		// Token: 0x060002A7 RID: 679
		// RVA: 0x0002F050 File Offset: 0x0002D250
		internal void InvokeOnSerialized(object o, StreamingContext context)
		{
			if (this._onSerializedCallbacks != null)
			{
				foreach (SerializationCallback current in this._onSerializedCallbacks)
				{
					current(o, context);
				}
			}
		}

		// Token: 0x060002A6 RID: 678
		// RVA: 0x0002EFF8 File Offset: 0x0002D1F8
		internal void InvokeOnSerializing(object o, StreamingContext context)
		{
			if (this._onSerializingCallbacks != null)
			{
				foreach (SerializationCallback current in this._onSerializingCallbacks)
				{
					current(o, context);
				}
			}
		}
	}
}
