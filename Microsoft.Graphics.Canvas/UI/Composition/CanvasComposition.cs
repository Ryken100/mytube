using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;

namespace Microsoft.Graphics.Canvas.UI.Composition
{
	// Token: 0x020000FC RID: 252
	[Version(167772160U)]
	[Threading(3)]
	[Static(typeof(ICanvasCompositionStatics), 167772160U)]
	[MarshalingBehavior(2)]
	public static class CanvasComposition
	{
		// Token: 0x06000839 RID: 2105
		public static extern CompositionGraphicsDevice CreateCompositionGraphicsDevice([In] Compositor compositor, [In] CanvasDevice canvasDevice);

		// Token: 0x0600083A RID: 2106
		public static extern ICompositionSurface CreateCompositionSurfaceForSwapChain([In] Compositor compositor, [In] CanvasSwapChain swapChain);

		// Token: 0x0600083B RID: 2107
		public static extern CanvasDevice GetCanvasDevice([In] CompositionGraphicsDevice graphicsDevice);

		// Token: 0x0600083C RID: 2108
		public static extern void SetCanvasDevice([In] CompositionGraphicsDevice graphicsDevice, [In] CanvasDevice canvasDevice);

		// Token: 0x0600083D RID: 2109
		[Overload("CreateDrawingSession")]
		public static extern CanvasDrawingSession CreateDrawingSession([In] CompositionDrawingSurface drawingSurface);

		// Token: 0x0600083E RID: 2110
		[Overload("CreateDrawingSessionWithUpdateRect")]
		public static extern CanvasDrawingSession CreateDrawingSession([In] CompositionDrawingSurface drawingSurface, [In] Rect updateRect);

		// Token: 0x0600083F RID: 2111
		[Overload("CreateDrawingSessionWithUpdateRectAndDpi")]
		public static extern CanvasDrawingSession CreateDrawingSession([In] CompositionDrawingSurface drawingSurface, [In] Rect updateRectInPixels, [In] float dpi);

		// Token: 0x06000840 RID: 2112
		public static extern void Resize([In] CompositionDrawingSurface drawingSurface, [In] Size sizeInPixels);
	}
}
