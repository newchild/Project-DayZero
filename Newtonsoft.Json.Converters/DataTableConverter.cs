using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000031 RID: 49
	public sealed class DataTableConverter : JsonConverter
	{
		// Token: 0x06000199 RID: 409
		// RVA: 0x00006DC7 File Offset: 0x00004FC7
		public override bool CanConvert(Type valueType)
		{
			return typeof(DataTable).IsAssignableFrom(valueType);
		}

		// Token: 0x06000198 RID: 408
		// RVA: 0x00006DB1 File Offset: 0x00004FB1
		private static void CheckedRead(JsonReader reader)
		{
			if (!reader.Read())
			{
				throw JsonSerializationException.Create(reader, "Unexpected end when reading DataTable.");
			}
		}

		// Token: 0x06000196 RID: 406
		// RVA: 0x0002B9B0 File Offset: 0x00029BB0
		private static void CreateRow(JsonReader reader, DataTable dt)
		{
			DataRow dataRow = dt.NewRow();
			DataTableConverter.CheckedRead(reader);
			while (reader.TokenType == JsonToken.PropertyName)
			{
				string text = (string)reader.Value;
				DataTableConverter.CheckedRead(reader);
				DataColumn dataColumn = dt.Columns[text];
				if (dataColumn == null)
				{
					Type columnDataType = DataTableConverter.GetColumnDataType(reader);
					dataColumn = new DataColumn(text, columnDataType);
					dt.Columns.Add(dataColumn);
				}
				if (dataColumn.DataType == typeof(DataTable))
				{
					if (reader.TokenType == JsonToken.StartArray)
					{
						DataTableConverter.CheckedRead(reader);
					}
					DataTable dataTable = new DataTable();
					while (reader.TokenType != JsonToken.EndArray)
					{
						DataTableConverter.CreateRow(reader, dataTable);
						DataTableConverter.CheckedRead(reader);
					}
					dataRow[text] = dataTable;
				}
				else if (dataColumn.DataType.IsArray && dataColumn.DataType != typeof(byte[]))
				{
					if (reader.TokenType == JsonToken.StartArray)
					{
						DataTableConverter.CheckedRead(reader);
					}
					List<object> list = new List<object>();
					while (reader.TokenType != JsonToken.EndArray)
					{
						list.Add(reader.Value);
						DataTableConverter.CheckedRead(reader);
					}
					Array array = Array.CreateInstance(dataColumn.DataType.GetElementType(), list.Count);
					Array.Copy(list.ToArray(), array, list.Count);
					dataRow[text] = array;
				}
				else
				{
					dataRow[text] = (reader.Value ?? DBNull.Value);
				}
				DataTableConverter.CheckedRead(reader);
			}
			dataRow.EndEdit();
			dt.Rows.Add(dataRow);
		}

		// Token: 0x06000197 RID: 407
		// RVA: 0x0002BB28 File Offset: 0x00029D28
		private static Type GetColumnDataType(JsonReader reader)
		{
			JsonToken tokenType = reader.TokenType;
			switch (tokenType)
			{
			case JsonToken.StartArray:
			{
				DataTableConverter.CheckedRead(reader);
				if (reader.TokenType == JsonToken.StartObject)
				{
					return typeof(DataTable);
				}
				Type columnDataType = DataTableConverter.GetColumnDataType(reader);
				return columnDataType.MakeArrayType();
			}
			case JsonToken.Integer:
			case JsonToken.Float:
			case JsonToken.String:
			case JsonToken.Boolean:
			case JsonToken.Date:
			case JsonToken.Bytes:
				return reader.ValueType;
			case JsonToken.Null:
			case JsonToken.Undefined:
				return typeof(string);
			}
			throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Unexpected JSON token when reading DataTable: {0}", CultureInfo.InvariantCulture, tokenType));
		}

		// Token: 0x06000195 RID: 405
		// RVA: 0x0002B90C File Offset: 0x00029B0C
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			DataTable dataTable = existingValue as DataTable;
			if (dataTable == null)
			{
				dataTable = ((objectType == typeof(DataTable)) ? new DataTable() : ((DataTable)Activator.CreateInstance(objectType)));
			}
			if (reader.TokenType == JsonToken.PropertyName)
			{
				dataTable.TableName = (string)reader.Value;
				DataTableConverter.CheckedRead(reader);
			}
			if (reader.TokenType != JsonToken.StartArray)
			{
				throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Unexpected JSON token when reading DataTable. Expected StartArray, got {0}.", CultureInfo.InvariantCulture, reader.TokenType));
			}
			DataTableConverter.CheckedRead(reader);
			while (reader.TokenType != JsonToken.EndArray)
			{
				DataTableConverter.CreateRow(reader, dataTable);
				DataTableConverter.CheckedRead(reader);
			}
			return dataTable;
		}

		// Token: 0x06000194 RID: 404
		// RVA: 0x0002B7E8 File Offset: 0x000299E8
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			DataTable dataTable = (DataTable)value;
			DefaultContractResolver defaultContractResolver = serializer.ContractResolver as DefaultContractResolver;
			writer.WriteStartArray();
			foreach (DataRow dataRow in dataTable.Rows)
			{
				writer.WriteStartObject();
				foreach (DataColumn dataColumn in dataRow.Table.Columns)
				{
					if (serializer.NullValueHandling != NullValueHandling.Ignore || (dataRow[dataColumn] != null && dataRow[dataColumn] != DBNull.Value))
					{
						writer.WritePropertyName((defaultContractResolver != null) ? defaultContractResolver.GetResolvedPropertyName(dataColumn.ColumnName) : dataColumn.ColumnName);
						serializer.Serialize(writer, dataRow[dataColumn]);
					}
				}
				writer.WriteEndObject();
			}
			writer.WriteEndArray();
		}
	}
}
