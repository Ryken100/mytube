using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;

namespace Microsoft.Graphics.Canvas.UI.Composition
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(372108099u, 7413, 18168, 160, 175, 53, 107, 35, 21, 143, 146)]
	[ExclusiveTo(typeof(CanvasComposition))]
	[Version(167772160u)]
	internal interface ICanvasCompositionStatics
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CompositionGraphicsDevice CreateCompositionGraphicsDevice([In] Compositor compositor, [In] CanvasDevice canvasDevice);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		ICompositionSurface CreateCompositionSurfaceForSwapChain([In] Compositor compositor, [In] CanvasSwapChain swapChain);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasDevice GetCanvasDevice([In] CompositionGraphicsDevice graphicsDevice);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetCanvasDevice([In] CompositionGraphicsDevice graphicsDevice, [In] CanvasDevice canvasDevice);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateDrawingSession")]
		CanvasDrawingSession CreateDrawingSession([In] CompositionDrawingSurface drawingSurface);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateDrawingSessionWithUpdateRect")]
		CanvasDrawingSession CreateDrawingSession([In] CompositionDrawingSurface drawingSurface, [In] Rect updateRect);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateDrawingSessionWithUpdateRectAndDpi")]
		CanvasDrawingSession CreateDrawingSession([In] CompositionDrawingSurface drawingSurface, [In] Rect updateRectInPixels, [In] float dpi);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Resize([In] CompositionDrawingSurface drawingSurface, [In] Size sizeInPixels);
	}
}
