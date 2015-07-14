using System;
using System.IO;
using System.Text;

namespace ns30
{
	// Token: 0x02000229 RID: 553
	internal sealed class Stream8 : MemoryStream
	{
		// Token: 0x0600137C RID: 4988
		// RVA: 0x00012012 File Offset: 0x00010212
		public Stream8(string string_0) : this(string_0, new object[0])
		{
		}

		// Token: 0x0600137D RID: 4989
		// RVA: 0x00064414 File Offset: 0x00062614
		public Stream8(string string_0, object[] object_0)
		{
			StreamWriter streamWriter = new StreamWriter(this, Encoding.Default);
			if (object_0.Length == 0)
			{
				streamWriter.Write(string_0);
			}
			else
			{
				streamWriter.Write(string_0, object_0);
			}
			streamWriter.Flush();
			this.Seek(0L, SeekOrigin.Begin);
		}
	}
}
