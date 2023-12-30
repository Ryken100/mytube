using System;
using Windows.Foundation.Metadata;
using Windows.Graphics.Printing;

namespace Microsoft.Graphics.Canvas.Printing
{
	// Token: 0x020000DD RID: 221
	[Guid(174751904U, 45181, 19890, 189, 235, 3, 104, 187, 24, 192, 248)]
	[Version(167772160U)]
	[ExclusiveTo(typeof(CanvasPreviewEventArgs))]
	internal interface ICanvasPreviewEventArgs
	{
		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000737 RID: 1847
		uint PageNumber { get; }

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06000738 RID: 1848
		PrintTaskOptions PrintTaskOptions { get; }

		// Token: 0x06000739 RID: 1849
		CanvasPrintDeferral GetDeferral();

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x0600073A RID: 1850
		CanvasDrawingSession DrawingSession { get; }
	}
}
