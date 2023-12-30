using System;
using Windows.Foundation.Metadata;
using Windows.Graphics.Printing;

namespace Microsoft.Graphics.Canvas.Printing
{
	// Token: 0x020000D9 RID: 217
	[MarshalingBehavior(2)]
	[Threading(3)]
	[Version(167772160U)]
	public sealed class CanvasPreviewEventArgs : ICanvasPreviewEventArgs
	{
		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06000728 RID: 1832
		public extern uint PageNumber { get; }

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000729 RID: 1833
		public extern PrintTaskOptions PrintTaskOptions { get; }

		// Token: 0x0600072A RID: 1834
		public extern CanvasPrintDeferral GetDeferral();

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x0600072B RID: 1835
		public extern CanvasDrawingSession DrawingSession { get; }
	}
}
