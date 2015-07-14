using Newtonsoft.Json.Utilities;
using System;
using System.Globalization;
using System.Reflection;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000103 RID: 259
	public sealed class DynamicValueProvider : IValueProvider
	{
		// Token: 0x04000441 RID: 1089
		private Func<object, object> _getter;

		// Token: 0x04000440 RID: 1088
		private readonly MemberInfo _memberInfo;

		// Token: 0x04000442 RID: 1090
		private Action<object, object> _setter;

		// Token: 0x06000A72 RID: 2674
		// RVA: 0x0000C40F File Offset: 0x0000A60F
		public DynamicValueProvider(MemberInfo memberInfo)
		{
			ValidationUtils.ArgumentNotNull(memberInfo, "memberInfo");
			this._memberInfo = memberInfo;
		}

		// Token: 0x06000A74 RID: 2676
		// RVA: 0x000411E8 File Offset: 0x0003F3E8
		public object GetValue(object target)
		{
			object result;
			try
			{
				if (this._getter == null)
				{
					this._getter = DynamicReflectionDelegateFactory.Instance.CreateGet<object>(this._memberInfo);
				}
				result = this._getter(target);
			}
			catch (Exception innerException)
			{
				throw new JsonSerializationException(StringUtils.FormatWith("Error getting value from '{0}' on '{1}'.", CultureInfo.InvariantCulture, this._memberInfo.Name, target.GetType()), innerException);
			}
			return result;
		}

		// Token: 0x06000A73 RID: 2675
		// RVA: 0x00041174 File Offset: 0x0003F374
		public void SetValue(object target, object value)
		{
			try
			{
				if (this._setter == null)
				{
					this._setter = DynamicReflectionDelegateFactory.Instance.CreateSet<object>(this._memberInfo);
				}
				this._setter(target, value);
			}
			catch (Exception innerException)
			{
				throw new JsonSerializationException(StringUtils.FormatWith("Error setting value to '{0}' on '{1}'.", CultureInfo.InvariantCulture, this._memberInfo.Name, target.GetType()), innerException);
			}
		}
	}
}
