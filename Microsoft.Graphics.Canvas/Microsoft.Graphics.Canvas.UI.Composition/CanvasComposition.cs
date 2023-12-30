using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;

namespace Microsoft.Graphics.Canvas.UI.Composition
{
	[ComImport]
	[Version(167772160u)]
	[Threading(ThreadingModel.Both)]
	[Static(typeof(ICanvasCompositionStatics), 167772160u)]
	[MarshalingBehavior(MarshalingType.Agile)]
	public static class CanvasComposition
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public static extern CompositionGraphicsDevice CreateCompositionGraphicsDevice([In] Compositor compositor, [In] CanvasDevice canvasDevice);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public static extern ICompositionSurface CreateCompositionSurfaceForSwapChain([In] Compositor compositor, [In] CanvasSwapChain swapChain);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public static extern CanvasDevice GetCanvasDevice([In] CompositionGraphicsDevice graphicsDevice);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public static extern void SetCanvasDevice([In] CompositionGraphicsDevice graphicsDevice, [In] CanvasDevice canvasDevice);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateDrawingSession")]
		public static extern CanvasDrawingSession CreateDrawingSession([In] CompositionDrawingSurface drawingSurface);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateDrawingSessionWithUpdateRect")]
		public static extern CanvasDrawingSession CreateDrawingSession([In] CompositionDrawingSurface drawingSurface, [In] Rect updateRect);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateDrawingSessionWithUpdateRectAndDpi")]
		public static extern CanvasDrawingSession CreateDrawingSession([In] CompositionDrawingSurface drawingSurface, [In] Rect updateRectInPixels, [In] float dpi);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public static extern void Resize([In] CompositionDrawingSurface drawingSurface, [In] Size sizeInPixels);
	}
}
