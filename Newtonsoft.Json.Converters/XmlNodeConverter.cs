using Newtonsoft.Json.Utilities;
using Newtonsoft.Json.Utilities.LinqBridge;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000C9 RID: 201
	public sealed class XmlNodeConverter : JsonConverter
	{
		// Token: 0x0400033A RID: 826
		private const string CDataName = "#cdata-section";

		// Token: 0x04000339 RID: 825
		private const string CommentName = "#comment";

		// Token: 0x0400033D RID: 829
		private const string DeclarationName = "?xml";

		// Token: 0x0400033E RID: 830
		private const string JsonNamespaceUri = "http://james.newtonking.com/projects/json";

		// Token: 0x0400033C RID: 828
		private const string SignificantWhitespaceName = "#significant-whitespace";

		// Token: 0x04000338 RID: 824
		private const string TextName = "#text";

		// Token: 0x0400033B RID: 827
		private const string WhitespaceName = "#whitespace";

		// Token: 0x17000126 RID: 294
		public string DeserializeRootElementName
		{
			// Token: 0x060006D4 RID: 1748
			// RVA: 0x00009E13 File Offset: 0x00008013
			get;
			// Token: 0x060006D5 RID: 1749
			// RVA: 0x00009E1B File Offset: 0x0000801B
			set;
		}

		// Token: 0x17000128 RID: 296
		public bool OmitRootObject
		{
			// Token: 0x060006D8 RID: 1752
			// RVA: 0x00009E35 File Offset: 0x00008035
			get;
			// Token: 0x060006D9 RID: 1753
			// RVA: 0x00009E3D File Offset: 0x0000803D
			set;
		}

		// Token: 0x17000127 RID: 295
		public bool WriteArrayAttribute
		{
			// Token: 0x060006D6 RID: 1750
			// RVA: 0x00009E24 File Offset: 0x00008024
			get;
			// Token: 0x060006D7 RID: 1751
			// RVA: 0x00009E2C File Offset: 0x0000802C
			set;
		}

		// Token: 0x060006E7 RID: 1767
		// RVA: 0x00009E6B File Offset: 0x0000806B
		private void AddJsonArrayAttribute(IXmlElement element, IXmlDocument document)
		{
			element.SetAttributeNode(document.CreateAttribute("json:Array", "http://james.newtonking.com/projects/json", "true"));
		}

		// Token: 0x060006EF RID: 1775
		// RVA: 0x00009EAD File Offset: 0x000080AD
		public override bool CanConvert(Type valueType)
		{
			return typeof(XmlNode).IsAssignableFrom(valueType);
		}

		// Token: 0x060006E5 RID: 1765
		// RVA: 0x0003848C File Offset: 0x0003668C
		private string ConvertTokenToXmlValue(JsonReader reader)
		{
			if (reader.TokenType == JsonToken.String)
			{
				return reader.Value.ToString();
			}
			if (reader.TokenType == JsonToken.Integer)
			{
				return XmlConvert.ToString(Convert.ToInt64(reader.Value, CultureInfo.InvariantCulture));
			}
			if (reader.TokenType == JsonToken.Float)
			{
				if (reader.Value is decimal)
				{
					return XmlConvert.ToString((decimal)reader.Value);
				}
				if (reader.Value is float)
				{
					return XmlConvert.ToString((float)reader.Value);
				}
				return XmlConvert.ToString(Convert.ToDouble(reader.Value, CultureInfo.InvariantCulture));
			}
			else
			{
				if (reader.TokenType == JsonToken.Boolean)
				{
					return XmlConvert.ToString(Convert.ToBoolean(reader.Value, CultureInfo.InvariantCulture));
				}
				if (reader.TokenType == JsonToken.Date)
				{
					DateTime value = Convert.ToDateTime(reader.Value, CultureInfo.InvariantCulture);
					return XmlConvert.ToString(value, DateTimeUtils.ToSerializationMode(value.Kind));
				}
				if (reader.TokenType == JsonToken.Null)
				{
					return null;
				}
				throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Cannot get an XML string value from token type '{0}'.", CultureInfo.InvariantCulture, reader.TokenType));
			}
		}

		// Token: 0x060006EA RID: 1770
		// RVA: 0x00038974 File Offset: 0x00036B74
		private void CreateDocumentType(JsonReader reader, IXmlDocument document, IXmlNode currentNode)
		{
			string name = null;
			string publicId = null;
			string systemId = null;
			string internalSubset = null;
			while (reader.Read())
			{
				if (reader.TokenType == JsonToken.EndObject)
				{
					break;
				}
				string a;
				if ((a = reader.Value.ToString()) != null)
				{
					if (a == "@name")
					{
						reader.Read();
						name = reader.Value.ToString();
						continue;
					}
					if (a == "@public")
					{
						reader.Read();
						publicId = reader.Value.ToString();
						continue;
					}
					if (a == "@system")
					{
						reader.Read();
						systemId = reader.Value.ToString();
						continue;
					}
					if (a == "@internalSubset")
					{
						reader.Read();
						internalSubset = reader.Value.ToString();
						continue;
					}
				}
				throw new JsonSerializationException("Unexpected property name encountered while deserializing XmlDeclaration: " + reader.Value);
			}
			IXmlNode newChild = document.CreateXmlDocumentType(name, publicId, systemId, internalSubset);
			currentNode.AppendChild(newChild);
		}

		// Token: 0x060006EB RID: 1771
		// RVA: 0x00038A74 File Offset: 0x00036C74
		private IXmlElement CreateElement(string elementName, IXmlDocument document, string elementPrefix, XmlNamespaceManager manager)
		{
			string text = string.IsNullOrEmpty(elementPrefix) ? manager.DefaultNamespace : manager.LookupNamespace(elementPrefix);
			return (!string.IsNullOrEmpty(text)) ? document.CreateElement(elementName, text) : document.CreateElement(elementName);
		}

		// Token: 0x060006E9 RID: 1769
		// RVA: 0x00038868 File Offset: 0x00036A68
		private void CreateInstruction(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName)
		{
			if (propertyName == "?xml")
			{
				string version = null;
				string encoding = null;
				string standalone = null;
				while (reader.Read())
				{
					if (reader.TokenType == JsonToken.EndObject)
					{
						break;
					}
					string a;
					if ((a = reader.Value.ToString()) != null)
					{
						if (a == "@version")
						{
							reader.Read();
							version = reader.Value.ToString();
							continue;
						}
						if (a == "@encoding")
						{
							reader.Read();
							encoding = reader.Value.ToString();
							continue;
						}
						if (a == "@standalone")
						{
							reader.Read();
							standalone = reader.Value.ToString();
							continue;
						}
					}
					throw new JsonSerializationException("Unexpected property name encountered while deserializing XmlDeclaration: " + reader.Value);
				}
				IXmlNode newChild = document.CreateXmlDeclaration(version, encoding, standalone);
				currentNode.AppendChild(newChild);
				return;
			}
			IXmlNode newChild2 = document.CreateProcessingInstruction(propertyName.Substring(1), reader.Value.ToString());
			currentNode.AppendChild(newChild2);
		}

		// Token: 0x060006EC RID: 1772
		// RVA: 0x00038AB8 File Offset: 0x00036CB8
		private void DeserializeNode(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, IXmlNode currentNode)
		{
			JsonToken tokenType;
			while (true)
			{
				tokenType = reader.TokenType;
				switch (tokenType)
				{
				case JsonToken.StartConstructor:
				{
					string propertyName2 = reader.Value.ToString();
					while (reader.Read())
					{
						if (reader.TokenType == JsonToken.EndConstructor)
						{
							break;
						}
						this.DeserializeValue(reader, document, manager, propertyName2, currentNode);
					}
					goto IL_44;
				}
				case JsonToken.PropertyName:
				{
					if (currentNode.NodeType == XmlNodeType.Document && document.DocumentElement != null)
					{
						goto IL_17B;
					}
					string propertyName = reader.Value.ToString();
					reader.Read();
					if (reader.TokenType != JsonToken.StartArray)
					{
						this.DeserializeValue(reader, document, manager, propertyName, currentNode);
						goto IL_44;
					}
					int num = 0;
					while (reader.Read())
					{
						if (reader.TokenType == JsonToken.EndArray)
						{
							break;
						}
						this.DeserializeValue(reader, document, manager, propertyName, currentNode);
						num++;
					}
					if (num == 1 && this.WriteArrayAttribute)
					{
						IXmlElement element = Enumerable.Single<IXmlElement>(Enumerable.OfType<IXmlElement>(currentNode.ChildNodes), (IXmlElement n) => n.LocalName == propertyName);
						this.AddJsonArrayAttribute(element, document);
						goto IL_44;
					}
					goto IL_44;
				}
				case JsonToken.Comment:
					currentNode.AppendChild(document.CreateComment((string)reader.Value));
					goto IL_44;
				}
				break;
				IL_44:
				if (reader.TokenType != JsonToken.PropertyName && !reader.Read())
				{
					return;
				}
			}
			switch (tokenType)
			{
			case JsonToken.EndObject:
			case JsonToken.EndArray:
				return;
			default:
				throw new JsonSerializationException("Unexpected JsonToken when deserializing node: " + reader.TokenType);
			}
			return;
			IL_17B:
			throw new JsonSerializationException("JSON root object has multiple properties. The root object must have a single property in order to create a valid XML document. Consider specifing a DeserializeRootElementName.");
		}

		// Token: 0x060006E3 RID: 1763
		// RVA: 0x000381B4 File Offset: 0x000363B4
		private void DeserializeValue(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, string propertyName, IXmlNode currentNode)
		{
			if (propertyName != null)
			{
				if (propertyName == "#text")
				{
					currentNode.AppendChild(document.CreateTextNode(reader.Value.ToString()));
					return;
				}
				if (propertyName == "#cdata-section")
				{
					currentNode.AppendChild(document.CreateCDataSection(reader.Value.ToString()));
					return;
				}
				if (propertyName == "#whitespace")
				{
					currentNode.AppendChild(document.CreateWhitespace(reader.Value.ToString()));
					return;
				}
				if (propertyName == "#significant-whitespace")
				{
					currentNode.AppendChild(document.CreateSignificantWhitespace(reader.Value.ToString()));
					return;
				}
			}
			if (!string.IsNullOrEmpty(propertyName) && propertyName[0] == '?')
			{
				this.CreateInstruction(reader, document, currentNode, propertyName);
				return;
			}
			if (string.Equals(propertyName, "!DOCTYPE", StringComparison.OrdinalIgnoreCase))
			{
				this.CreateDocumentType(reader, document, currentNode);
				return;
			}
			if (reader.TokenType == JsonToken.StartArray)
			{
				this.ReadArrayElements(reader, document, propertyName, currentNode, manager);
				return;
			}
			this.ReadElement(reader, document, currentNode, propertyName, manager);
		}

		// Token: 0x060006DE RID: 1758
		// RVA: 0x00037984 File Offset: 0x00035B84
		private string GetPropertyName(IXmlNode node, XmlNamespaceManager manager)
		{
			switch (node.NodeType)
			{
			case XmlNodeType.Element:
				return this.ResolveFullName(node, manager);
			case XmlNodeType.Attribute:
				if (node.NamespaceUri == "http://james.newtonking.com/projects/json")
				{
					return "$" + node.LocalName;
				}
				return "@" + this.ResolveFullName(node, manager);
			case XmlNodeType.Text:
				return "#text";
			case XmlNodeType.CDATA:
				return "#cdata-section";
			case XmlNodeType.ProcessingInstruction:
				return "?" + this.ResolveFullName(node, manager);
			case XmlNodeType.Comment:
				return "#comment";
			case XmlNodeType.DocumentType:
				return "!" + this.ResolveFullName(node, manager);
			case XmlNodeType.Whitespace:
				return "#whitespace";
			case XmlNodeType.SignificantWhitespace:
				return "#significant-whitespace";
			case XmlNodeType.XmlDeclaration:
				return "?xml";
			}
			throw new JsonSerializationException("Unexpected XmlNodeType when getting node name: " + node.NodeType);
		}

		// Token: 0x060006DF RID: 1759
		// RVA: 0x00037A8C File Offset: 0x00035C8C
		private bool IsArray(IXmlNode node)
		{
			IXmlNode arg_33_0;
			if (node.Attributes == null)
			{
				arg_33_0 = null;
			}
			else
			{
				arg_33_0 = Enumerable.SingleOrDefault<IXmlNode>(node.Attributes, (IXmlNode a) => a.LocalName == "Array" && a.NamespaceUri == "http://james.newtonking.com/projects/json");
			}
			IXmlNode xmlNode = arg_33_0;
			return xmlNode != null && XmlConvert.ToBoolean(xmlNode.Value);
		}

		// Token: 0x060006ED RID: 1773
		// RVA: 0x00038C4C File Offset: 0x00036E4C
		private bool IsNamespaceAttribute(string attributeName, out string prefix)
		{
			if (attributeName.StartsWith("xmlns", StringComparison.Ordinal))
			{
				if (attributeName.Length == 5)
				{
					prefix = string.Empty;
					return true;
				}
				if (attributeName[5] == ':')
				{
					prefix = attributeName.Substring(6, attributeName.Length - 6);
					return true;
				}
			}
			prefix = null;
			return false;
		}

		// Token: 0x060006DC RID: 1756
		// RVA: 0x00037820 File Offset: 0x00035A20
		private void PushParentNamespaces(IXmlNode node, XmlNamespaceManager manager)
		{
			List<IXmlNode> list = null;
			IXmlNode xmlNode = node;
			while ((xmlNode = xmlNode.ParentNode) != null)
			{
				if (xmlNode.NodeType == XmlNodeType.Element)
				{
					if (list == null)
					{
						list = new List<IXmlNode>();
					}
					list.Add(xmlNode);
				}
			}
			if (list != null)
			{
				list.Reverse();
				foreach (IXmlNode current in list)
				{
					manager.PushScope();
					foreach (IXmlNode current2 in current.Attributes)
					{
						if (current2.NamespaceUri == "http://www.w3.org/2000/xmlns/" && current2.LocalName != "xmlns")
						{
							manager.AddNamespace(current2.LocalName, current2.Value);
						}
					}
				}
			}
		}

		// Token: 0x060006E6 RID: 1766
		// RVA: 0x000385A8 File Offset: 0x000367A8
		private void ReadArrayElements(JsonReader reader, IXmlDocument document, string propertyName, IXmlNode currentNode, XmlNamespaceManager manager)
		{
			string prefix = MiscellaneousUtils.GetPrefix(propertyName);
			IXmlElement xmlElement = this.CreateElement(propertyName, document, prefix, manager);
			currentNode.AppendChild(xmlElement);
			int num = 0;
			while (reader.Read())
			{
				if (reader.TokenType == JsonToken.EndArray)
				{
					break;
				}
				this.DeserializeValue(reader, document, manager, propertyName, xmlElement);
				num++;
			}
			if (this.WriteArrayAttribute)
			{
				this.AddJsonArrayAttribute(xmlElement, document);
			}
			if (num == 1 && this.WriteArrayAttribute)
			{
				IXmlElement element = Enumerable.Single<IXmlElement>(Enumerable.OfType<IXmlElement>(xmlElement.ChildNodes), (IXmlElement n) => n.LocalName == propertyName);
				this.AddJsonArrayAttribute(element, document);
			}
		}

		// Token: 0x060006E8 RID: 1768
		// RVA: 0x00038668 File Offset: 0x00036868
		private Dictionary<string, string> ReadAttributeElements(JsonReader reader, XmlNamespaceManager manager)
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			bool flag = false;
			bool flag2 = false;
			if (reader.TokenType != JsonToken.String && reader.TokenType != JsonToken.Null && reader.TokenType != JsonToken.Boolean && reader.TokenType != JsonToken.Integer && reader.TokenType != JsonToken.Float && reader.TokenType != JsonToken.Date && reader.TokenType != JsonToken.StartConstructor)
			{
				while (!flag && !flag2 && reader.Read())
				{
					JsonToken tokenType = reader.TokenType;
					switch (tokenType)
					{
					case JsonToken.PropertyName:
					{
						string text = reader.Value.ToString();
						if (!string.IsNullOrEmpty(text))
						{
							char c = text[0];
							char c2 = c;
							if (c2 != '$')
							{
								if (c2 == '@')
								{
									text = text.Substring(1);
									reader.Read();
									string text2 = this.ConvertTokenToXmlValue(reader);
									dictionary.Add(text, text2);
									string prefix;
									if (this.IsNamespaceAttribute(text, out prefix))
									{
										manager.AddNamespace(prefix, text2);
									}
								}
								else
								{
									flag = true;
								}
							}
							else
							{
								text = text.Substring(1);
								reader.Read();
								string text2 = reader.Value.ToString();
								string text3 = manager.LookupPrefix("http://james.newtonking.com/projects/json");
								if (text3 == null)
								{
									int? num = null;
									while (manager.LookupNamespace("json" + num) != null)
									{
										num = new int?(num.GetValueOrDefault() + 1);
									}
									text3 = "json" + num;
									dictionary.Add("xmlns:" + text3, "http://james.newtonking.com/projects/json");
									manager.AddNamespace(text3, "http://james.newtonking.com/projects/json");
								}
								dictionary.Add(text3 + ":" + text, text2);
							}
						}
						else
						{
							flag = true;
						}
						break;
					}
					case JsonToken.Comment:
						flag2 = true;
						break;
					default:
						if (tokenType != JsonToken.EndObject)
						{
							throw new JsonSerializationException("Unexpected JsonToken: " + reader.TokenType);
						}
						flag2 = true;
						break;
					}
				}
			}
			return dictionary;
		}

		// Token: 0x060006E4 RID: 1764
		// RVA: 0x000382C8 File Offset: 0x000364C8
		private void ReadElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, XmlNamespaceManager manager)
		{
			if (string.IsNullOrEmpty(propertyName))
			{
				throw new JsonSerializationException("XmlNodeConverter cannot convert JSON with an empty property name to XML.");
			}
			Dictionary<string, string> dictionary = this.ReadAttributeElements(reader, manager);
			string prefix = MiscellaneousUtils.GetPrefix(propertyName);
			if (StringUtils.StartsWith(propertyName, '@'))
			{
				string text = propertyName.Substring(1);
				string value = reader.Value.ToString();
				string prefix2 = MiscellaneousUtils.GetPrefix(text);
				IXmlNode attributeNode = (!string.IsNullOrEmpty(prefix2)) ? document.CreateAttribute(text, manager.LookupNamespace(prefix2), value) : document.CreateAttribute(text, value);
				((IXmlElement)currentNode).SetAttributeNode(attributeNode);
				return;
			}
			IXmlElement xmlElement = this.CreateElement(propertyName, document, prefix, manager);
			currentNode.AppendChild(xmlElement);
			foreach (KeyValuePair<string, string> current in dictionary)
			{
				string prefix3 = MiscellaneousUtils.GetPrefix(current.Key);
				IXmlNode attributeNode2 = (!string.IsNullOrEmpty(prefix3)) ? document.CreateAttribute(current.Key, manager.LookupNamespace(prefix3), current.Value) : document.CreateAttribute(current.Key, current.Value);
				xmlElement.SetAttributeNode(attributeNode2);
			}
			if (reader.TokenType != JsonToken.String && reader.TokenType != JsonToken.Integer && reader.TokenType != JsonToken.Float && reader.TokenType != JsonToken.Boolean)
			{
				if (reader.TokenType != JsonToken.Date)
				{
					if (reader.TokenType == JsonToken.Null)
					{
						return;
					}
					if (reader.TokenType != JsonToken.EndObject)
					{
						manager.PushScope();
						this.DeserializeNode(reader, document, manager, xmlElement);
						manager.PopScope();
					}
					manager.RemoveNamespace(string.Empty, manager.DefaultNamespace);
					return;
				}
			}
			xmlElement.AppendChild(document.CreateTextNode(this.ConvertTokenToXmlValue(reader)));
		}

		// Token: 0x060006E2 RID: 1762
		// RVA: 0x000380E8 File Offset: 0x000362E8
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			if (reader.TokenType == JsonToken.Null)
			{
				return null;
			}
			XmlNamespaceManager manager = new XmlNamespaceManager(new NameTable());
			IXmlDocument xmlDocument = null;
			IXmlNode xmlNode = null;
			if (typeof(XmlNode).IsAssignableFrom(objectType))
			{
				if (objectType != typeof(XmlDocument))
				{
					throw new JsonSerializationException("XmlNodeConverter only supports deserializing XmlDocuments");
				}
				xmlDocument = new XmlDocumentWrapper(new XmlDocument
				{
					XmlResolver = null
				});
				xmlNode = xmlDocument;
			}
			if (xmlDocument == null || xmlNode == null)
			{
				throw new JsonSerializationException("Unexpected type when converting XML: " + objectType);
			}
			if (reader.TokenType != JsonToken.StartObject)
			{
				throw new JsonSerializationException("XmlNodeConverter can only convert JSON that begins with an object.");
			}
			if (!string.IsNullOrEmpty(this.DeserializeRootElementName))
			{
				this.ReadElement(reader, xmlDocument, xmlNode, this.DeserializeRootElementName, manager);
			}
			else
			{
				reader.Read();
				this.DeserializeNode(reader, xmlDocument, manager, xmlNode);
			}
			return xmlDocument.WrappedNode;
		}

		// Token: 0x060006DD RID: 1757
		// RVA: 0x00037918 File Offset: 0x00035B18
		private string ResolveFullName(IXmlNode node, XmlNamespaceManager manager)
		{
			string text = (node.NamespaceUri == null || (node.LocalName == "xmlns" && node.NamespaceUri == "http://www.w3.org/2000/xmlns/")) ? null : manager.LookupPrefix(node.NamespaceUri);
			if (!string.IsNullOrEmpty(text))
			{
				return text + ":" + node.LocalName;
			}
			return node.LocalName;
		}

		// Token: 0x060006E0 RID: 1760
		// RVA: 0x00037AE0 File Offset: 0x00035CE0
		private void SerializeGroupedNodes(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName)
		{
			Dictionary<string, List<IXmlNode>> dictionary = new Dictionary<string, List<IXmlNode>>();
			for (int i = 0; i < node.ChildNodes.Count; i++)
			{
				IXmlNode xmlNode = node.ChildNodes[i];
				string propertyName = this.GetPropertyName(xmlNode, manager);
				List<IXmlNode> list;
				if (!dictionary.TryGetValue(propertyName, out list))
				{
					list = new List<IXmlNode>();
					dictionary.Add(propertyName, list);
				}
				list.Add(xmlNode);
			}
			foreach (KeyValuePair<string, List<IXmlNode>> current in dictionary)
			{
				List<IXmlNode> value = current.Value;
				if (value.Count == 1 && !this.IsArray(value[0]))
				{
					this.SerializeNode(writer, value[0], manager, writePropertyName);
				}
				else
				{
					string key = current.Key;
					if (writePropertyName)
					{
						writer.WritePropertyName(key);
					}
					writer.WriteStartArray();
					for (int j = 0; j < value.Count; j++)
					{
						this.SerializeNode(writer, value[j], manager, false);
					}
					writer.WriteEndArray();
				}
			}
		}

		// Token: 0x060006E1 RID: 1761
		// RVA: 0x00037C10 File Offset: 0x00035E10
		private void SerializeNode(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName)
		{
			switch (node.NodeType)
			{
			case XmlNodeType.Element:
				if (this.IsArray(node))
				{
					if (Enumerable.All<IXmlNode>(node.ChildNodes, (IXmlNode n) => n.LocalName == node.LocalName) && node.ChildNodes.Count > 0)
					{
						this.SerializeGroupedNodes(writer, node, manager, false);
						return;
					}
				}
				manager.PushScope();
				foreach (IXmlNode current in node.Attributes)
				{
					if (current.NamespaceUri == "http://www.w3.org/2000/xmlns/")
					{
						string prefix = (current.LocalName != "xmlns") ? current.LocalName : string.Empty;
						string value = current.Value;
						manager.AddNamespace(prefix, value);
					}
				}
				if (writePropertyName)
				{
					writer.WritePropertyName(this.GetPropertyName(node, manager));
				}
				if (!Enumerable.Any<IXmlNode>(this.ValueAttributes(node.Attributes)) && node.ChildNodes.Count == 1 && node.ChildNodes[0].NodeType == XmlNodeType.Text)
				{
					writer.WriteValue(node.ChildNodes[0].Value);
				}
				else if (node.ChildNodes.Count == 0 && CollectionUtils.IsNullOrEmpty<IXmlNode>(node.Attributes))
				{
					IXmlElement xmlElement = (IXmlElement)node;
					if (xmlElement.IsEmpty)
					{
						writer.WriteNull();
					}
					else
					{
						writer.WriteValue(string.Empty);
					}
				}
				else
				{
					writer.WriteStartObject();
					for (int i = 0; i < node.Attributes.Count; i++)
					{
						this.SerializeNode(writer, node.Attributes[i], manager, true);
					}
					this.SerializeGroupedNodes(writer, node, manager, true);
					writer.WriteEndObject();
				}
				manager.PopScope();
				return;
			case XmlNodeType.Attribute:
			case XmlNodeType.Text:
			case XmlNodeType.CDATA:
			case XmlNodeType.ProcessingInstruction:
			case XmlNodeType.Whitespace:
			case XmlNodeType.SignificantWhitespace:
				if (node.NamespaceUri == "http://www.w3.org/2000/xmlns/" && node.Value == "http://james.newtonking.com/projects/json")
				{
					return;
				}
				if (node.NamespaceUri == "http://james.newtonking.com/projects/json" && node.LocalName == "Array")
				{
					return;
				}
				if (writePropertyName)
				{
					writer.WritePropertyName(this.GetPropertyName(node, manager));
				}
				writer.WriteValue(node.Value);
				return;
			case XmlNodeType.Comment:
				if (writePropertyName)
				{
					writer.WriteComment(node.Value);
					return;
				}
				return;
			case XmlNodeType.Document:
			case XmlNodeType.DocumentFragment:
				this.SerializeGroupedNodes(writer, node, manager, writePropertyName);
				return;
			case XmlNodeType.DocumentType:
			{
				IXmlDocumentType xmlDocumentType = (IXmlDocumentType)node;
				writer.WritePropertyName(this.GetPropertyName(node, manager));
				writer.WriteStartObject();
				if (!string.IsNullOrEmpty(xmlDocumentType.Name))
				{
					writer.WritePropertyName("@name");
					writer.WriteValue(xmlDocumentType.Name);
				}
				if (!string.IsNullOrEmpty(xmlDocumentType.Public))
				{
					writer.WritePropertyName("@public");
					writer.WriteValue(xmlDocumentType.Public);
				}
				if (!string.IsNullOrEmpty(xmlDocumentType.System))
				{
					writer.WritePropertyName("@system");
					writer.WriteValue(xmlDocumentType.System);
				}
				if (!string.IsNullOrEmpty(xmlDocumentType.InternalSubset))
				{
					writer.WritePropertyName("@internalSubset");
					writer.WriteValue(xmlDocumentType.InternalSubset);
				}
				writer.WriteEndObject();
				return;
			}
			case XmlNodeType.XmlDeclaration:
			{
				IXmlDeclaration xmlDeclaration = (IXmlDeclaration)node;
				writer.WritePropertyName(this.GetPropertyName(node, manager));
				writer.WriteStartObject();
				if (!string.IsNullOrEmpty(xmlDeclaration.Version))
				{
					writer.WritePropertyName("@version");
					writer.WriteValue(xmlDeclaration.Version);
				}
				if (!string.IsNullOrEmpty(xmlDeclaration.Encoding))
				{
					writer.WritePropertyName("@encoding");
					writer.WriteValue(xmlDeclaration.Encoding);
				}
				if (!string.IsNullOrEmpty(xmlDeclaration.Standalone))
				{
					writer.WritePropertyName("@standalone");
					writer.WriteValue(xmlDeclaration.Standalone);
				}
				writer.WriteEndObject();
				return;
			}
			}
			throw new JsonSerializationException("Unexpected XmlNodeType when serializing nodes: " + node.NodeType);
		}

		// Token: 0x060006EE RID: 1774
		// RVA: 0x00009E88 File Offset: 0x00008088
		private IEnumerable<IXmlNode> ValueAttributes(IEnumerable<IXmlNode> c)
		{
			return Enumerable.Where<IXmlNode>(c, (IXmlNode a) => a.NamespaceUri != "http://james.newtonking.com/projects/json");
		}

		// Token: 0x060006DB RID: 1755
		// RVA: 0x00009E46 File Offset: 0x00008046
		private IXmlNode WrapXml(object value)
		{
			if (!(value is XmlNode))
			{
				throw new ArgumentException("Value must be an XML object.", "value");
			}
			return XmlNodeWrapper.WrapNode((XmlNode)value);
		}

		// Token: 0x060006DA RID: 1754
		// RVA: 0x000377C8 File Offset: 0x000359C8
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			IXmlNode node = this.WrapXml(value);
			XmlNamespaceManager manager = new XmlNamespaceManager(new NameTable());
			this.PushParentNamespaces(node, manager);
			if (!this.OmitRootObject)
			{
				writer.WriteStartObject();
			}
			this.SerializeNode(writer, node, manager, !this.OmitRootObject);
			if (!this.OmitRootObject)
			{
				writer.WriteEndObject();
			}
		}
	}
}
