using System;

namespace Newtonsoft.Json
{
	// Token: 0x0200003E RID: 62
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false)]
	public abstract class JsonContainerAttribute : Attribute
	{
		// Token: 0x040000E6 RID: 230
		internal bool? _isReference;

		// Token: 0x040000E7 RID: 231
		internal bool? _itemIsReference;

		// Token: 0x040000E8 RID: 232
		internal ReferenceLoopHandling? _itemReferenceLoopHandling;

		// Token: 0x040000E9 RID: 233
		internal TypeNameHandling? _itemTypeNameHandling;

		// Token: 0x17000038 RID: 56
		public string Description
		{
			// Token: 0x060001BE RID: 446
			// RVA: 0x00006F08 File Offset: 0x00005108
			get;
			// Token: 0x060001BF RID: 447
			// RVA: 0x00006F10 File Offset: 0x00005110
			set;
		}

		// Token: 0x17000036 RID: 54
		public string Id
		{
			// Token: 0x060001BA RID: 442
			// RVA: 0x00006EE6 File Offset: 0x000050E6
			get;
			// Token: 0x060001BB RID: 443
			// RVA: 0x00006EEE File Offset: 0x000050EE
			set;
		}

		// Token: 0x1700003B RID: 59
		public bool IsReference
		{
			// Token: 0x060001C4 RID: 452
			// RVA: 0x0002C310 File Offset: 0x0002A510
			get
			{
				return this._isReference ?? false;
			}
			// Token: 0x060001C5 RID: 453
			// RVA: 0x00006F3B File Offset: 0x0000513B
			set
			{
				this._isReference = new bool?(value);
			}
		}

		// Token: 0x1700003A RID: 58
		public object[] ItemConverterParameters
		{
			// Token: 0x060001C2 RID: 450
			// RVA: 0x00006F2A File Offset: 0x0000512A
			get;
			// Token: 0x060001C3 RID: 451
			// RVA: 0x00006F32 File Offset: 0x00005132
			set;
		}

		// Token: 0x17000039 RID: 57
		public Type ItemConverterType
		{
			// Token: 0x060001C0 RID: 448
			// RVA: 0x00006F19 File Offset: 0x00005119
			get;
			// Token: 0x060001C1 RID: 449
			// RVA: 0x00006F21 File Offset: 0x00005121
			set;
		}

		// Token: 0x1700003C RID: 60
		public bool ItemIsReference
		{
			// Token: 0x060001C6 RID: 454
			// RVA: 0x0002C338 File Offset: 0x0002A538
			get
			{
				return this._itemIsReference ?? false;
			}
			// Token: 0x060001C7 RID: 455
			// RVA: 0x00006F49 File Offset: 0x00005149
			set
			{
				this._itemIsReference = new bool?(value);
			}
		}

		// Token: 0x1700003D RID: 61
		public ReferenceLoopHandling ItemReferenceLoopHandling
		{
			// Token: 0x060001C8 RID: 456
			// RVA: 0x0002C360 File Offset: 0x0002A560
			get
			{
				ReferenceLoopHandling? itemReferenceLoopHandling = this._itemReferenceLoopHandling;
				if (!itemReferenceLoopHandling.HasValue)
				{
					return ReferenceLoopHandling.Error;
				}
				return itemReferenceLoopHandling.GetValueOrDefault();
			}
			// Token: 0x060001C9 RID: 457
			// RVA: 0x00006F57 File Offset: 0x00005157
			set
			{
				this._itemReferenceLoopHandling = new ReferenceLoopHandling?(value);
			}
		}

		// Token: 0x1700003E RID: 62
		public TypeNameHandling ItemTypeNameHandling
		{
			// Token: 0x060001CA RID: 458
			// RVA: 0x0002C388 File Offset: 0x0002A588
			get
			{
				TypeNameHandling? itemTypeNameHandling = this._itemTypeNameHandling;
				if (!itemTypeNameHandling.HasValue)
				{
					return TypeNameHandling.None;
				}
				return itemTypeNameHandling.GetValueOrDefault();
			}
			// Token: 0x060001CB RID: 459
			// RVA: 0x00006F65 File Offset: 0x00005165
			set
			{
				this._itemTypeNameHandling = new TypeNameHandling?(value);
			}
		}

		// Token: 0x17000037 RID: 55
		public string Title
		{
			// Token: 0x060001BC RID: 444
			// RVA: 0x00006EF7 File Offset: 0x000050F7
			get;
			// Token: 0x060001BD RID: 445
			// RVA: 0x00006EFF File Offset: 0x000050FF
			set;
		}

		// Token: 0x060001CC RID: 460
		// RVA: 0x00006EDE File Offset: 0x000050DE
		protected JsonContainerAttribute()
		{
		}

		// Token: 0x060001CD RID: 461
		// RVA: 0x00006F73 File Offset: 0x00005173
		protected JsonContainerAttribute(string id)
		{
			this.Id = id;
		}
	}
}
