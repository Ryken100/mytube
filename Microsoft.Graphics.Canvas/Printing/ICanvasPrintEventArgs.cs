using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Graphics.Printing;

namespace Microsoft.Graphics.Canvas.Printing
{
	// Token: 0x020000DE RID: 222
	[Guid(207702212U, 534, 17761, 168, 23, 52, 200, 148, 42, 172, 139)]
	[Version(167772160U)]
	[ExclusiveTo(typeof(CanvasPrintEventArgs))]
	internal interface ICanvasPrintEventArgs
	{
		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x0600073B RID: 1851
		PrintTaskOptions PrintTaskOptions { get; }

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x0600073C RID: 1852
		// (set) Token: 0x0600073D RID: 1853
		float Dpi
		{
			get; [param: In]
			set;
		}

		// Token: 0x0600073E RID: 1854
		CanvasPrintDeferral GetDeferral();

		// Token: 0x0600073F RID: 1855
		CanvasDrawingSession CreateDrawingSession();
	}
}
