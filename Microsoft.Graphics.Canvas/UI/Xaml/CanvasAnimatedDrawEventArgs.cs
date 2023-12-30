using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.UI.Xaml
{
	// Token: 0x020000E5 RID: 229
	[Version(167772160U)]
	[Threading(3)]
	[MarshalingBehavior(2)]
	[Activatable(typeof(ICanvasAnimatedDrawEventArgsFactory), 167772160U)]
	public sealed class CanvasAnimatedDrawEventArgs : ICanvasAnimatedDrawEventArgs
	{
		// Token: 0x06000746 RID: 1862
		public extern CanvasAnimatedDrawEventArgs([In] CanvasDrawingSession canvasDrawingSession, [In] CanvasTimingInformation timingInformation);

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06000747 RID: 1863
		public extern CanvasDrawingSession DrawingSession { get; }

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06000748 RID: 1864
		public extern CanvasTimingInformation Timing { get; }
	}
}
