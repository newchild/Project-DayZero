using ns29;
using ns8;
using osu;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace ns14
{
	// Token: 0x020004B3 RID: 1203
	internal sealed class Class623<T>
	{
		// Token: 0x04001F96 RID: 8086
		internal bool bool_0;

		// Token: 0x04001F91 RID: 8081
		public static Class30 class30_0 = new Class30();

		// Token: 0x04001F92 RID: 8082
		private T gparam_0;

		// Token: 0x04001F94 RID: 8084
		private Interface20<T> interface20_0;

		// Token: 0x04001F93 RID: 8083
		private int int_0;

		// Token: 0x04001F95 RID: 8085
		internal int int_1;

		// Token: 0x04001F97 RID: 8087
		[CompilerGenerated]
		private static VoidDelegate voidDelegate_0;

		// Token: 0x1700038D RID: 909
		public T Value
		{
			// Token: 0x06002641 RID: 9793
			// RVA: 0x0001DAFB File Offset: 0x0001BCFB
			get
			{
				return this.interface20_0.imethod_1(this.gparam_0, this.int_0);
			}
			// Token: 0x06002642 RID: 9794
			// RVA: 0x0001DB14 File Offset: 0x0001BD14
			set
			{
				this.int_0 = (int)Class623<T>.class30_0.method_1();
				this.gparam_0 = this.interface20_0.imethod_0(value, this.int_0);
				this.int_1++;
			}
		}

		// Token: 0x06002646 RID: 9798
		// RVA: 0x0001DB97 File Offset: 0x0001BD97
		public Class623() : this(new object[0])
		{
		}

		// Token: 0x06002645 RID: 9797
		// RVA: 0x0001DB5C File Offset: 0x0001BD5C
		public Class623(T gparam_1)
		{
			this.int_0 = Class623<T>.class30_0.method_2(-2147483648, 2147483647);
			this.interface20_0 = new Class622<T>();
			this.bool_0 = true;
			base..ctor();
			this.Value = gparam_1;
		}

		// Token: 0x06002648 RID: 9800
		// RVA: 0x000E5E3C File Offset: 0x000E403C
		public Class623(object[] object_0)
		{
			this.int_0 = Class623<T>.class30_0.method_2(-2147483648, 2147483647);
			this.interface20_0 = new Class622<T>();
			this.bool_0 = true;
			base..ctor();
			Type typeFromHandle = typeof(T);
			List<Type> list = new List<Type>();
			if (object_0.Length > 0)
			{
				for (int i = 0; i < object_0.Length; i++)
				{
					object obj = object_0[i];
					list.Add(obj.GetType());
				}
			}
			else
			{
				list = null;
			}
			ConstructorInfo constructor = typeFromHandle.GetConstructor(list.ToArray());
			T t = (T)((object)constructor.Invoke(object_0));
			this.gparam_0 = t;
		}

		// Token: 0x06002640 RID: 9792
		// RVA: 0x000E5D9C File Offset: 0x000E3F9C
		protected override void Finalize()
		{
			try
			{
				OsuModes osuModes_ = Class115.osuModes_1;
				if (osuModes_ != OsuModes.Exit)
				{
					switch (osuModes_)
					{
					}
				}
				if (!this.bool_0)
				{
					Class47 arg_4E_0 = Class115.class47_0;
					if (Class623<T>.voidDelegate_0 == null)
					{
						Class623<T>.voidDelegate_0 = new VoidDelegate(Class623<T>.smethod_0);
					}
					arg_4E_0.method_1(Class623<T>.voidDelegate_0, 1000, false);
				}
			}
			finally
			{
				base.Finalize();
			}
		}

		// Token: 0x06002643 RID: 9795
		// RVA: 0x0001DB4C File Offset: 0x0001BD4C
		public static implicit operator T(Class623<T> class623_0)
		{
			return class623_0.Value;
		}

		// Token: 0x06002644 RID: 9796
		// RVA: 0x0001DB54 File Offset: 0x0001BD54
		public static implicit operator Class623<T>(T gparam_1)
		{
			return new Class623<T>(gparam_1);
		}

		// Token: 0x06002649 RID: 9801
		// RVA: 0x000190D1 File Offset: 0x000172D1
		[CompilerGenerated]
		private static void smethod_0()
		{
			Environment.Exit(-1);
		}

		// Token: 0x06002647 RID: 9799
		// RVA: 0x000E5E18 File Offset: 0x000E4018
		public override string ToString()
		{
			T value = this.Value;
			return value.ToString();
		}
	}
}
