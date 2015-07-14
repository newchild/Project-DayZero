using Newtonsoft.Json.Serialization;
using System;
using System.Data;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000030 RID: 48
	public sealed class DataSetConverter : JsonConverter
	{
		// Token: 0x06000191 RID: 401
		// RVA: 0x00006D89 File Offset: 0x00004F89
		public override bool CanConvert(Type valueType)
		{
			return typeof(DataSet).IsAssignableFrom(valueType);
		}

		// Token: 0x06000192 RID: 402
		// RVA: 0x00006D9B File Offset: 0x00004F9B
		private void CheckedRead(JsonReader reader)
		{
			if (!reader.Read())
			{
				throw JsonSerializationException.Create(reader, "Unexpected end when reading DataSet.");
			}
		}

		// Token: 0x06000190 RID: 400
		// RVA: 0x0002B750 File Offset: 0x00029950
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			DataSet dataSet = (objectType == typeof(DataSet)) ? new DataSet() : ((DataSet)Activator.CreateInstance(objectType));
			DataTableConverter dataTableConverter = new DataTableConverter();
			this.CheckedRead(reader);
			while (reader.TokenType == JsonToken.PropertyName)
			{
				DataTable dataTable = dataSet.Tables[(string)reader.Value];
				bool flag = dataTable != null;
				dataTable = (DataTable)dataTableConverter.ReadJson(reader, typeof(DataTable), dataTable, serializer);
				if (!flag)
				{
					dataSet.Tables.Add(dataTable);
				}
				this.CheckedRead(reader);
			}
			return dataSet;
		}

		// Token: 0x0600018F RID: 399
		// RVA: 0x0002B6A8 File Offset: 0x000298A8
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			DataSet dataSet = (DataSet)value;
			DefaultContractResolver defaultContractResolver = serializer.ContractResolver as DefaultContractResolver;
			DataTableConverter dataTableConverter = new DataTableConverter();
			writer.WriteStartObject();
			foreach (DataTable dataTable in dataSet.Tables)
			{
				writer.WritePropertyName((defaultContractResolver != null) ? defaultContractResolver.GetResolvedPropertyName(dataTable.TableName) : dataTable.TableName);
				dataTableConverter.WriteJson(writer, dataTable, serializer);
			}
			writer.WriteEndObject();
		}
	}
}
