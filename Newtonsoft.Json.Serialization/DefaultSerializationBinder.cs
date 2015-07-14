using Newtonsoft.Json.Utilities;
using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.Serialization;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000100 RID: 256
	public sealed class DefaultSerializationBinder : SerializationBinder
	{
		// Token: 0x02000101 RID: 257
		internal struct TypeNameKey : IEquatable<DefaultSerializationBinder.TypeNameKey>
		{
			// Token: 0x0400043E RID: 1086
			internal readonly string AssemblyName;

			// Token: 0x0400043F RID: 1087
			internal readonly string TypeName;

			// Token: 0x06000A6C RID: 2668
			// RVA: 0x0000C38E File Offset: 0x0000A58E
			public TypeNameKey(string assemblyName, string typeName)
			{
				this.AssemblyName = assemblyName;
				this.TypeName = typeName;
			}

			// Token: 0x06000A6E RID: 2670
			// RVA: 0x0000C3CD File Offset: 0x0000A5CD
			public override bool Equals(object obj)
			{
				return obj is DefaultSerializationBinder.TypeNameKey && this.Equals((DefaultSerializationBinder.TypeNameKey)obj);
			}

			// Token: 0x06000A6F RID: 2671
			// RVA: 0x0000C3E5 File Offset: 0x0000A5E5
			public bool Equals(DefaultSerializationBinder.TypeNameKey other)
			{
				return this.AssemblyName == other.AssemblyName && this.TypeName == other.TypeName;
			}

			// Token: 0x06000A6D RID: 2669
			// RVA: 0x0000C39E File Offset: 0x0000A59E
			public override int GetHashCode()
			{
				return ((this.AssemblyName != null) ? this.AssemblyName.GetHashCode() : 0) ^ ((this.TypeName != null) ? this.TypeName.GetHashCode() : 0);
			}
		}

		// Token: 0x0400043C RID: 1084
		internal static readonly DefaultSerializationBinder Instance = new DefaultSerializationBinder();

		// Token: 0x0400043D RID: 1085
		private readonly ThreadSafeStore<DefaultSerializationBinder.TypeNameKey, Type> _typeCache = new ThreadSafeStore<DefaultSerializationBinder.TypeNameKey, Type>(new Func<DefaultSerializationBinder.TypeNameKey, Type>(DefaultSerializationBinder.GetTypeFromTypeNameKey));

		// Token: 0x06000A69 RID: 2665
		// RVA: 0x0000C34F File Offset: 0x0000A54F
		public override Type BindToType(string assemblyName, string typeName)
		{
			return this._typeCache.Get(new DefaultSerializationBinder.TypeNameKey(assemblyName, typeName));
		}

		// Token: 0x06000A68 RID: 2664
		// RVA: 0x000410C0 File Offset: 0x0003F2C0
		private static Type GetTypeFromTypeNameKey(DefaultSerializationBinder.TypeNameKey typeNameKey)
		{
			string assemblyName = typeNameKey.AssemblyName;
			string typeName = typeNameKey.TypeName;
			if (assemblyName == null)
			{
				return Type.GetType(typeName);
			}
			Assembly assembly = Assembly.LoadWithPartialName(assemblyName);
			if (assembly == null)
			{
				Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
				Assembly[] array = assemblies;
				for (int i = 0; i < array.Length; i++)
				{
					Assembly assembly2 = array[i];
					if (assembly2.FullName == assemblyName)
					{
						assembly = assembly2;
						break;
					}
				}
			}
			if (assembly == null)
			{
				throw new JsonSerializationException(StringUtils.FormatWith("Could not load assembly '{0}'.", CultureInfo.InvariantCulture, assemblyName));
			}
			Type type = assembly.GetType(typeName);
			if (type == null)
			{
				throw new JsonSerializationException(StringUtils.FormatWith("Could not find type '{0}' in assembly '{1}'.", CultureInfo.InvariantCulture, typeName, assembly.FullName));
			}
			return type;
		}
	}
}
