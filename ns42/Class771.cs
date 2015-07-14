using ns29;
using ns92;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace ns42
{
	// Token: 0x020005AB RID: 1451
	internal static class Class771
	{
		// Token: 0x020005AC RID: 1452
		[CompilerGenerated]
		private sealed class Class772
		{
			// Token: 0x020005AD RID: 1453
			private sealed class Class773
			{
				// Token: 0x040026CC RID: 9932
				public Class771.Class772 class772_0;

				// Token: 0x040026CD RID: 9933
				public StackFrame stackFrame_0;

				// Token: 0x06002E76 RID: 11894
				// RVA: 0x000230D8 File Offset: 0x000212D8
				public bool method_0(string string_0)
				{
					return this.stackFrame_0.GetMethod().ToString().Contains(string_0);
				}
			}

			// Token: 0x040026CB RID: 9931
			public List<string> list_0;

			// Token: 0x06002E74 RID: 11892
			// RVA: 0x0012DCD8 File Offset: 0x0012BED8
			public bool method_0(StackFrame stackFrame_0)
			{
				Class771.Class772.Class773 class = new Class771.Class772.Class773();
				class.class772_0 = this;
				class.stackFrame_0 = stackFrame_0;
				return !class.stackFrame_0.GetMethod().Module.ToString().Contains(Class905.smethod_1()) || this.list_0.Find(new Predicate<string>(class.method_0)) != null;
			}
		}

		// Token: 0x06002E70 RID: 11888
		// RVA: 0x000230C4 File Offset: 0x000212C4
		static Class771()
		{
			Class774.smethod_0();
		}

		// Token: 0x06002E71 RID: 11889
		// RVA: 0x000230CB File Offset: 0x000212CB
		internal static string smethod_0(MethodBase methodBase_0)
		{
			return new Class776(methodBase_0).method_4();
		}

		// Token: 0x06002E72 RID: 11890
		// RVA: 0x0012DC78 File Offset: 0x0012BE78
		internal static List<StackFrame> smethod_1(StackFrame[] stackFrame_0)
		{
			Class771.Class772 class = new Class771.Class772();
			List<StackFrame> list = new List<StackFrame>();
			if (stackFrame_0 == null)
			{
				return list;
			}
			list.AddRange(stackFrame_0);
			string text = "ErrorDialog~Void Update(Microsoft.Xna.Framework.GameTime)~Void Main()~Void UpdateFadeState()~Void UpdateChildren()";
			class.list_0 = new List<string>(text.Split(new char[]
			{
				'~'
			}));
			list.RemoveAll(new Predicate<StackFrame>(class.method_0));
			return list;
		}
	}
}
