using Newtonsoft.Json.Utilities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Newtonsoft.Json
{
	// Token: 0x02000043 RID: 67
	internal struct JsonPosition
	{
		// Token: 0x040000FA RID: 250
		internal bool HasIndex;

		// Token: 0x040000F8 RID: 248
		internal int Position;

		// Token: 0x040000F9 RID: 249
		internal string PropertyName;

		// Token: 0x040000F6 RID: 246
		private static readonly char[] SpecialCharacters = new char[]
		{
			'.',
			' ',
			'[',
			']',
			'(',
			')'
		};

		// Token: 0x040000F7 RID: 247
		internal JsonContainerType Type;

		// Token: 0x060001DA RID: 474
		// RVA: 0x00007002 File Offset: 0x00005202
		public JsonPosition(JsonContainerType type)
		{
			this.Type = type;
			this.HasIndex = JsonPosition.TypeHasIndex(type);
			this.Position = -1;
			this.PropertyName = null;
		}

		// Token: 0x060001DD RID: 477
		// RVA: 0x0002C44C File Offset: 0x0002A64C
		internal static string BuildPath(IEnumerable<JsonPosition> positions)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (JsonPosition current in positions)
			{
				current.WriteTo(stringBuilder);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060001DE RID: 478
		// RVA: 0x0002C4A4 File Offset: 0x0002A6A4
		internal static string FormatMessage(IJsonLineInfo lineInfo, string path, string message)
		{
			if (!message.EndsWith(Environment.NewLine, StringComparison.Ordinal))
			{
				message = message.Trim();
				if (!StringUtils.EndsWith(message, '.'))
				{
					message += ".";
				}
				message += " ";
			}
			message += StringUtils.FormatWith("Path '{0}'", CultureInfo.InvariantCulture, path);
			if (lineInfo != null && lineInfo.HasLineInfo())
			{
				message += StringUtils.FormatWith(", line {0}, position {1}", CultureInfo.InvariantCulture, lineInfo.LineNumber, lineInfo.LinePosition);
			}
			message += ".";
			return message;
		}

		// Token: 0x060001DC RID: 476
		// RVA: 0x00007025 File Offset: 0x00005225
		internal static bool TypeHasIndex(JsonContainerType type)
		{
			return type == JsonContainerType.Array || type == JsonContainerType.Constructor;
		}

		// Token: 0x060001DB RID: 475
		// RVA: 0x0002C3B0 File Offset: 0x0002A5B0
		internal void WriteTo(StringBuilder sb)
		{
			switch (this.Type)
			{
			case JsonContainerType.Object:
			{
				if (sb.Length > 0)
				{
					sb.Append('.');
				}
				string propertyName = this.PropertyName;
				if (propertyName.IndexOfAny(JsonPosition.SpecialCharacters) != -1)
				{
					sb.Append("['");
					sb.Append(propertyName);
					sb.Append("']");
					return;
				}
				sb.Append(propertyName);
				return;
			}
			case JsonContainerType.Array:
			case JsonContainerType.Constructor:
				sb.Append('[');
				sb.Append(this.Position);
				sb.Append(']');
				return;
			default:
				return;
			}
		}
	}
}
