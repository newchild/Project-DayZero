using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Utilities;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x020000E9 RID: 233
	[ExtensionAttribute2]
	public static class Extensions
	{
		// Token: 0x060009A0 RID: 2464
		// RVA: 0x0003E840 File Offset: 0x0003CA40
		[ExtensionAttribute2]
		public static bool IsValid(JToken source, JsonSchema schema)
		{
			bool valid = true;
			Extensions.Validate(source, schema, delegate(object sender, ValidationEventArgs e)
			{
				valid = false;
			});
			return valid;
		}

		// Token: 0x060009A1 RID: 2465
		// RVA: 0x0003E874 File Offset: 0x0003CA74
		[ExtensionAttribute2]
		public static bool IsValid(JToken source, JsonSchema schema, out IList<string> errorMessages)
		{
			IList<string> errors = new List<string>();
			Extensions.Validate(source, schema, delegate(object sender, ValidationEventArgs e)
			{
				errors.Add(e.Message);
			});
			errorMessages = errors;
			return errorMessages.Count == 0;
		}

		// Token: 0x060009A2 RID: 2466
		// RVA: 0x0000BDA1 File Offset: 0x00009FA1
		[ExtensionAttribute2]
		public static void Validate(JToken source, JsonSchema schema)
		{
			Extensions.Validate(source, schema, null);
		}

		// Token: 0x060009A3 RID: 2467
		// RVA: 0x0003E8B8 File Offset: 0x0003CAB8
		[ExtensionAttribute2]
		public static void Validate(JToken source, JsonSchema schema, ValidationEventHandler validationEventHandler)
		{
			ValidationUtils.ArgumentNotNull(source, "source");
			ValidationUtils.ArgumentNotNull(schema, "schema");
			using (JsonValidatingReader jsonValidatingReader = new JsonValidatingReader(source.CreateReader()))
			{
				jsonValidatingReader.Schema = schema;
				if (validationEventHandler != null)
				{
					jsonValidatingReader.ValidationEventHandler += validationEventHandler;
				}
				while (jsonValidatingReader.Read())
				{
				}
			}
		}
	}
}
