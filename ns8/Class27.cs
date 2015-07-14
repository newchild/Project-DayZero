using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;

namespace ns8
{
	// Token: 0x0200018F RID: 399
	internal sealed class Class27
	{
		// Token: 0x02000190 RID: 400
		internal sealed class Class28 : SerializationBinder
		{
			// Token: 0x040006F4 RID: 1780
			private readonly Dictionary<string, Type> dictionary_0 = new Dictionary<string, Type>();

			// Token: 0x06000E68 RID: 3688
			// RVA: 0x0004E628 File Offset: 0x0004C828
			public override Type BindToType(string assemblyName, string typeName)
			{
				Type type;
				if (this.dictionary_0.TryGetValue(assemblyName + typeName, out type))
				{
					return type;
				}
				List<Type> list = new List<Type>();
				Type type2 = null;
				try
				{
					if (typeName.Contains("System.Collections.Generic") && typeName.Contains("[["))
					{
						string[] array = typeName.Split(new char[]
						{
							'['
						});
						string[] array2 = array;
						for (int i = 0; i < array2.Length; i++)
						{
							string text = array2[i];
							if (text.Contains("Version"))
							{
								string text2 = text.Substring(text.IndexOf(',') + 1);
								string assemblyName2 = text2.Remove(text2.IndexOf(']')).Trim();
								string typeName2 = text.Remove(text.IndexOf(','));
								list.Add(this.BindToType(assemblyName2, typeName2));
							}
							else if (text.Contains("Generic"))
							{
								type2 = this.BindToType(assemblyName, text);
							}
						}
						if (type2 != null && list.Count > 0)
						{
							return type2.MakeGenericType(list.ToArray());
						}
					}
					string b = assemblyName.Split(new char[]
					{
						','
					})[0];
					Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
					Assembly[] array3 = assemblies;
					for (int j = 0; j < array3.Length; j++)
					{
						Assembly assembly = array3[j];
						if (assembly.FullName.Split(new char[]
						{
							','
						})[0] == b)
						{
							type = assembly.GetType(typeName);
							break;
						}
					}
				}
				catch (Exception ex)
				{
					throw ex;
				}
				this.dictionary_0.Add(assemblyName + typeName, type);
				return type;
			}
		}

		// Token: 0x040006F3 RID: 1779
		private static BinaryFormatter binaryFormatter_0;

		// Token: 0x040006F2 RID: 1778
		private static Class27.Class28 class28_0;

		// Token: 0x06000E67 RID: 3687
		// RVA: 0x0000ED05 File Offset: 0x0000CF05
		public static object Deserialize(Stream stream_0)
		{
			if (Class27.binaryFormatter_0 == null)
			{
				Class27.Initialize();
			}
			return Class27.binaryFormatter_0.Deserialize(stream_0);
		}

		// Token: 0x06000E66 RID: 3686
		// RVA: 0x0000ECD5 File Offset: 0x0000CED5
		private static void Initialize()
		{
			Class27.class28_0 = new Class27.Class28();
			Class27.binaryFormatter_0 = new BinaryFormatter();
			Class27.binaryFormatter_0.AssemblyFormat = FormatterAssemblyStyle.Simple;
			Class27.binaryFormatter_0.Binder = Class27.class28_0;
		}
	}
}
