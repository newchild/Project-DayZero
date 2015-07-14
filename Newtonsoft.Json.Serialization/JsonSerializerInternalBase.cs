using Newtonsoft.Json.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200011F RID: 287
	internal abstract class JsonSerializerInternalBase
	{
		// Token: 0x02000120 RID: 288
		private sealed class ReferenceEqualsEqualityComparer : IEqualityComparer<object>
		{
			// Token: 0x06000BB2 RID: 2994
			// RVA: 0x0000B3BA File Offset: 0x000095BA
			bool IEqualityComparer<object>.Equals(object x, object y)
			{
				return object.ReferenceEquals(x, y);
			}

			// Token: 0x06000BB3 RID: 2995
			// RVA: 0x0000D108 File Offset: 0x0000B308
			int IEqualityComparer<object>.GetHashCode(object obj)
			{
				return RuntimeHelpers.GetHashCode(obj);
			}
		}

		// Token: 0x04000507 RID: 1287
		internal readonly JsonSerializer Serializer;

		// Token: 0x04000508 RID: 1288
		internal readonly ITraceWriter TraceWriter;

		// Token: 0x04000504 RID: 1284
		private ErrorContext _currentErrorContext;

		// Token: 0x04000505 RID: 1285
		private BidirectionalDictionary<string, object> _mappings;

		// Token: 0x04000506 RID: 1286
		private bool _serializing;

		// Token: 0x17000234 RID: 564
		internal BidirectionalDictionary<string, object> DefaultReferenceMappings
		{
			// Token: 0x06000BAE RID: 2990
			// RVA: 0x0000D083 File Offset: 0x0000B283
			get
			{
				if (this._mappings == null)
				{
					this._mappings = new BidirectionalDictionary<string, object>(EqualityComparer<string>.Default, new JsonSerializerInternalBase.ReferenceEqualsEqualityComparer(), "A different value already has the Id '{0}'.", "A different Id has already been assigned for value '{0}'.");
				}
				return this._mappings;
			}
		}

		// Token: 0x06000BAD RID: 2989
		// RVA: 0x0000D045 File Offset: 0x0000B245
		protected JsonSerializerInternalBase(JsonSerializer serializer)
		{
			ValidationUtils.ArgumentNotNull(serializer, "serializer");
			this.Serializer = serializer;
			this.TraceWriter = serializer.TraceWriter;
			this._serializing = (base.GetType() == typeof(JsonSerializerInternalWriter));
		}

		// Token: 0x06000BB0 RID: 2992
		// RVA: 0x0000D0EC File Offset: 0x0000B2EC
		protected void ClearErrorContext()
		{
			if (this._currentErrorContext == null)
			{
				throw new InvalidOperationException("Could not clear error context. Error context is already null.");
			}
			this._currentErrorContext = null;
		}

		// Token: 0x06000BAF RID: 2991
		// RVA: 0x0000D0B2 File Offset: 0x0000B2B2
		private ErrorContext GetErrorContext(object currentObject, object member, string path, Exception error)
		{
			if (this._currentErrorContext == null)
			{
				this._currentErrorContext = new ErrorContext(currentObject, member, path, error);
			}
			if (this._currentErrorContext.Error != error)
			{
				throw new InvalidOperationException("Current error context error is different to requested error.");
			}
			return this._currentErrorContext;
		}

		// Token: 0x06000BB1 RID: 2993
		// RVA: 0x00043494 File Offset: 0x00041694
		protected bool IsErrorHandled(object currentObject, JsonContract contract, object keyValue, IJsonLineInfo lineInfo, string path, Exception ex)
		{
			ErrorContext errorContext = this.GetErrorContext(currentObject, keyValue, path, ex);
			if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= TraceLevel.Error && !errorContext.Traced)
			{
				errorContext.Traced = true;
				string text = this._serializing ? "Error serializing" : "Error deserializing";
				if (contract != null)
				{
					text = text + " " + contract.UnderlyingType;
				}
				text = text + ". " + ex.Message;
				if (!(ex is JsonException))
				{
					text = JsonPosition.FormatMessage(lineInfo, path, text);
				}
				this.TraceWriter.Trace(TraceLevel.Error, text, ex);
			}
			if (contract != null && currentObject != null)
			{
				contract.InvokeOnError(currentObject, this.Serializer.Context, errorContext);
			}
			if (!errorContext.Handled)
			{
				this.Serializer.OnError(new ErrorEventArgs(currentObject, errorContext));
			}
			return errorContext.Handled;
		}
	}
}
