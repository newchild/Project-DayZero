using Newtonsoft.Json.Utilities;
using System;
using System.Globalization;
using System.Reflection;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200012C RID: 300
	public sealed class ReflectionValueProvider : IValueProvider
	{
		// Token: 0x0400052A RID: 1322
		private readonly MemberInfo _memberInfo;

		// Token: 0x06000C64 RID: 3172
		// RVA: 0x0000D69E File Offset: 0x0000B89E
		public ReflectionValueProvider(MemberInfo memberInfo)
		{
			ValidationUtils.ArgumentNotNull(memberInfo, "memberInfo");
			this._memberInfo = memberInfo;
		}

		// Token: 0x06000C66 RID: 3174
		// RVA: 0x0004818C File Offset: 0x0004638C
		public object GetValue(object target)
		{
			object memberValue;
			try
			{
				memberValue = ReflectionUtils.GetMemberValue(this._memberInfo, target);
			}
			catch (Exception innerException)
			{
				throw new JsonSerializationException(StringUtils.FormatWith("Error getting value from '{0}' on '{1}'.", CultureInfo.InvariantCulture, this._memberInfo.Name, target.GetType()), innerException);
			}
			return memberValue;
		}

		// Token: 0x06000C65 RID: 3173
		// RVA: 0x00048138 File Offset: 0x00046338
		public void SetValue(object target, object value)
		{
			try
			{
				ReflectionUtils.SetMemberValue(this._memberInfo, target, value);
			}
			catch (Exception innerException)
			{
				throw new JsonSerializationException(StringUtils.FormatWith("Error setting value to '{0}' on '{1}'.", CultureInfo.InvariantCulture, this._memberInfo.Name, target.GetType()), innerException);
			}
		}
	}
}
