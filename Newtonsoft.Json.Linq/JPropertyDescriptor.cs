using System;
using System.ComponentModel;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000A4 RID: 164
	public sealed class JPropertyDescriptor : PropertyDescriptor
	{
		// Token: 0x170000AB RID: 171
		public override Type ComponentType
		{
			// Token: 0x060004E3 RID: 1251
			// RVA: 0x00008F0C File Offset: 0x0000710C
			get
			{
				return typeof(JObject);
			}
		}

		// Token: 0x170000AC RID: 172
		public override bool IsReadOnly
		{
			// Token: 0x060004E4 RID: 1252
			// RVA: 0x00006D86 File Offset: 0x00004F86
			get
			{
				return false;
			}
		}

		// Token: 0x170000AE RID: 174
		protected override int NameHashCode
		{
			// Token: 0x060004E6 RID: 1254
			// RVA: 0x00033178 File Offset: 0x00031378
			get
			{
				return base.NameHashCode;
			}
		}

		// Token: 0x170000AD RID: 173
		public override Type PropertyType
		{
			// Token: 0x060004E5 RID: 1253
			// RVA: 0x00008F18 File Offset: 0x00007118
			get
			{
				return typeof(object);
			}
		}

		// Token: 0x060004DC RID: 1244
		// RVA: 0x00008EFA File Offset: 0x000070FA
		public JPropertyDescriptor(string name) : base(name, null)
		{
		}

		// Token: 0x060004DE RID: 1246
		// RVA: 0x00006D86 File Offset: 0x00004F86
		public override bool CanResetValue(object component)
		{
			return false;
		}

		// Token: 0x060004DD RID: 1245
		// RVA: 0x00008F04 File Offset: 0x00007104
		private static JObject CastInstance(object instance)
		{
			return (JObject)instance;
		}

		// Token: 0x060004DF RID: 1247
		// RVA: 0x00033120 File Offset: 0x00031320
		public override object GetValue(object component)
		{
			return JPropertyDescriptor.CastInstance(component)[this.Name];
		}

		// Token: 0x060004E0 RID: 1248
		// RVA: 0x0000653E File Offset: 0x0000473E
		public override void ResetValue(object component)
		{
		}

		// Token: 0x060004E1 RID: 1249
		// RVA: 0x00033140 File Offset: 0x00031340
		public override void SetValue(object component, object value)
		{
			JToken value2 = (value is JToken) ? ((JToken)value) : new JValue(value);
			JPropertyDescriptor.CastInstance(component)[this.Name] = value2;
		}

		// Token: 0x060004E2 RID: 1250
		// RVA: 0x00006D86 File Offset: 0x00004F86
		public override bool ShouldSerializeValue(object component)
		{
			return false;
		}
	}
}
