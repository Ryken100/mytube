using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;

namespace Microsoft.Graphics.Canvas.UI.Composition
{
	// Token: 0x020000FB RID: 251
	[Guid(372108099U, 7413, 18168, 160, 175, 53, 107, 35, 21, 143, 146)]
	[ExclusiveTo(typeof(CanvasComposition))]
	[Version(167772160U)]
	internal interface ICanvasCompositionStatics
	{
		// Token: 0x06000831 RID: 2097
		CompositionGraphicsDevice CreateCompositionGraphicsDevice([In] Compositor compositor, [In] CanvasDevice canvasDevice);

		// Token: 0x06000832 RID: 2098
		ICompositionSurface CreateCompositionSurfaceForSwapChain([In] Compositor compositor, [In] CanvasSwapChain swapChain);

		// Token: 0x06000833 RID: 2099
		CanvasDevice GetCanvasDevice([In] CompositionGraphicsDevice graphicsDevice);

		// Token: 0x06000834 RID: 2100
		void SetCanvasDevice([In] CompositionGraphicsDevice graphicsDevice, [In] CanvasDevice canvasDevice);

		// Token: 0x06000835 RID: 2101
		[Overload("CreateDrawingSession")]
		CanvasDrawingSession CreateDrawingSession([In] CompositionDrawingSurface drawingSurface);

		// Token: 0x06000836 RID: 2102
		[Overload("CreateDrawingSessionWithUpdateRect")]
		CanvasDrawingSession CreateDrawingSession([In] CompositionDrawingSurface drawingSurface, [In] Rect updateRect);

		// Token: 0x06000837 RID: 2103
		[Overload("CreateDrawingSessionWithUpdateRectAndDpi")]
		CanvasDrawingSession CreateDrawingSession([In] CompositionDrawingSurface drawingSurface, [In] Rect updateRectInPixels, [In] float dpi);

		// Token: 0x06000838 RID: 2104
		void Resize([In] CompositionDrawingSurface drawingSurface, [In] Size sizeInPixels);
	}
}
