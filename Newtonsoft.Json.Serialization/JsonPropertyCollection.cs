using Newtonsoft.Json.Utilities;
using System;
using System.Collections.ObjectModel;
using System.Globalization;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000112 RID: 274
	public sealed class JsonPropertyCollection : KeyedCollection<string, JsonProperty>
	{
		// Token: 0x04000490 RID: 1168
		private readonly Type _type;

		// Token: 0x06000B0D RID: 2829
		// RVA: 0x0000C9E9 File Offset: 0x0000ABE9
		public JsonPropertyCollection(Type type) : base(StringComparer.Ordinal)
		{
			ValidationUtils.ArgumentNotNull(type, "type");
			this._type = type;
		}

		// Token: 0x06000B0F RID: 2831
		// RVA: 0x000419C0 File Offset: 0x0003FBC0
		public void AddProperty(JsonProperty property)
		{
			if (base.Contains(property.PropertyName))
			{
				if (property.Ignored)
				{
					return;
				}
				JsonProperty jsonProperty = base[property.PropertyName];
				bool flag = true;
				if (jsonProperty.Ignored)
				{
					base.Remove(jsonProperty);
					flag = false;
				}
				else if (property.DeclaringType != null && jsonProperty.DeclaringType != null)
				{
					if (property.DeclaringType.IsSubclassOf(jsonProperty.DeclaringType))
					{
						base.Remove(jsonProperty);
						flag = false;
					}
					if (jsonProperty.DeclaringType.IsSubclassOf(property.DeclaringType))
					{
						return;
					}
				}
				if (flag)
				{
					throw new JsonSerializationException(StringUtils.FormatWith("A member with the name '{0}' already exists on '{1}'. Use the JsonPropertyAttribute to specify another name.", CultureInfo.InvariantCulture, property.PropertyName, this._type));
				}
			}
			base.Add(property);
		}

		// Token: 0x06000B10 RID: 2832
		// RVA: 0x00041A78 File Offset: 0x0003FC78
		public JsonProperty GetClosestMatchProperty(string propertyName)
		{
			JsonProperty property = this.GetProperty(propertyName, StringComparison.Ordinal);
			if (property == null)
			{
				property = this.GetProperty(propertyName, StringComparison.OrdinalIgnoreCase);
			}
			return property;
		}

		// Token: 0x06000B0E RID: 2830
		// RVA: 0x0000CA08 File Offset: 0x0000AC08
		protected override string GetKeyForItem(JsonProperty item)
		{
			return item.PropertyName;
		}

		// Token: 0x06000B12 RID: 2834
		// RVA: 0x00041A9C File Offset: 0x0003FC9C
		public JsonProperty GetProperty(string propertyName, StringComparison comparisonType)
		{
			if (comparisonType != StringComparison.Ordinal)
			{
				foreach (JsonProperty current in this)
				{
					if (string.Equals(propertyName, current.PropertyName, comparisonType))
					{
						return current;
					}
				}
				return null;
			}
			JsonProperty result;
			if (this.TryGetValue(propertyName, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x06000B11 RID: 2833
		// RVA: 0x0000CA10 File Offset: 0x0000AC10
		private bool TryGetValue(string key, out JsonProperty item)
		{
			if (base.Dictionary == null)
			{
				item = null;
				return false;
			}
			return base.Dictionary.TryGetValue(key, out item);
		}
	}
}
