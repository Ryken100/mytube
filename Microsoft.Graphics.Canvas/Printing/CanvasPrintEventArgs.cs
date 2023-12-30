using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Graphics.Printing;

namespace Microsoft.Graphics.Canvas.Printing
{
	// Token: 0x020000DA RID: 218
	[MarshalingBehavior(2)]
	[Version(167772160U)]
	[Threading(3)]
	public sealed class CanvasPrintEventArgs : ICanvasPrintEventArgs
	{
		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x0600072C RID: 1836
		public extern PrintTaskOptions PrintTaskOptions { get; }

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x0600072D RID: 1837
		// (set) Token: 0x0600072E RID: 1838
		public extern float Dpi
		{
			get; [param: In]
			set;
		}

		// Token: 0x0600072F RID: 1839
		public extern CanvasPrintDeferral GetDeferral();

		// Token: 0x06000730 RID: 1840
		public extern CanvasDrawingSession CreateDrawingSession();
	}
}
