using System;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Web;

namespace Amib.Threading.Internal
{
	// Token: 0x02000316 RID: 790
	internal sealed class CallerThreadContext
	{
		// Token: 0x04001261 RID: 4705
		private static readonly MethodInfo getLogicalCallContextMethodInfo = typeof(Thread).GetMethod("GetLogicalCallContext", BindingFlags.Instance | BindingFlags.NonPublic);

		// Token: 0x04001263 RID: 4707
		private static string HttpContextSlotName = CallerThreadContext.GetHttpContextSlotName();

		// Token: 0x04001262 RID: 4706
		private static readonly MethodInfo setLogicalCallContextMethodInfo = typeof(Thread).GetMethod("SetLogicalCallContext", BindingFlags.Instance | BindingFlags.NonPublic);

		// Token: 0x04001265 RID: 4709
		private LogicalCallContext _callContext;

		// Token: 0x04001264 RID: 4708
		private HttpContext _httpContext;

		// Token: 0x17000326 RID: 806
		public bool CapturedCallContext
		{
			// Token: 0x060017A4 RID: 6052
			// RVA: 0x00014A0C File Offset: 0x00012C0C
			get
			{
				return null != this._callContext;
			}
		}

		// Token: 0x17000327 RID: 807
		public bool CapturedHttpContext
		{
			// Token: 0x060017A5 RID: 6053
			// RVA: 0x00014A1A File Offset: 0x00012C1A
			get
			{
				return null != this._httpContext;
			}
		}

		// Token: 0x060017A3 RID: 6051
		// RVA: 0x00005E0F File Offset: 0x0000400F
		private CallerThreadContext()
		{
		}

		// Token: 0x060017A7 RID: 6055
		// RVA: 0x000739A0 File Offset: 0x00071BA0
		public static void Apply(CallerThreadContext callerThreadContext_0)
		{
			if (callerThreadContext_0 == null)
			{
				throw new ArgumentNullException("callerThreadContext");
			}
			if (callerThreadContext_0._callContext != null && CallerThreadContext.setLogicalCallContextMethodInfo != null)
			{
				CallerThreadContext.setLogicalCallContextMethodInfo.Invoke(Thread.CurrentThread, new object[]
				{
					callerThreadContext_0._callContext
				});
			}
			if (callerThreadContext_0._httpContext != null)
			{
				HttpContext.Current = callerThreadContext_0._httpContext;
			}
		}

		// Token: 0x060017A6 RID: 6054
		// RVA: 0x00073934 File Offset: 0x00071B34
		public static CallerThreadContext Capture(bool bool_0, bool bool_1)
		{
			CallerThreadContext callerThreadContext = new CallerThreadContext();
			if (bool_0 && CallerThreadContext.getLogicalCallContextMethodInfo != null)
			{
				callerThreadContext._callContext = (LogicalCallContext)CallerThreadContext.getLogicalCallContextMethodInfo.Invoke(Thread.CurrentThread, null);
				if (callerThreadContext._callContext != null)
				{
					callerThreadContext._callContext = (LogicalCallContext)callerThreadContext._callContext.Clone();
				}
			}
			if (bool_1 && HttpContext.Current != null)
			{
				callerThreadContext._httpContext = HttpContext.Current;
			}
			return callerThreadContext;
		}

		// Token: 0x060017A2 RID: 6050
		// RVA: 0x000738F8 File Offset: 0x00071AF8
		private static string GetHttpContextSlotName()
		{
			FieldInfo field = typeof(HttpContext).GetField("CallContextSlotName", BindingFlags.Static | BindingFlags.NonPublic);
			if (field != null)
			{
				return (string)field.GetValue(null);
			}
			return "HttpContext";
		}
	}
}
