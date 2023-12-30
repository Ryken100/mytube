using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.UI.Xaml
{
	// Token: 0x020000E4 RID: 228
	[Guid(3234397612U, 3580, 19992, 166, 233, 158, 247, 220, 130, 188, 194)]
	[Version(167772160U)]
	[ExclusiveTo(typeof(CanvasAnimatedDrawEventArgs))]
	internal interface ICanvasAnimatedDrawEventArgsFactory
	{
		// Token: 0x06000745 RID: 1861
		CanvasAnimatedDrawEventArgs Create([In] CanvasDrawingSession canvasDrawingSession, [In] CanvasTimingInformation timingInformation);
	}
}
