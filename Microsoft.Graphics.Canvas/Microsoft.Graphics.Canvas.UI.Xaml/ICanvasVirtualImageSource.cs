using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;
using Windows.UI;
using Windows.UI.Xaml.Media.Imaging;

namespace Microsoft.Graphics.Canvas.UI.Xaml
{
	[ComImport]
	[Version(167772160u)]
	[Windows.Foundation.Metadata.Guid(3744737671u, 20454, 19405, 184, 133, 42, 211, 230, 239, 159, 206)]
	[ExclusiveTo(typeof(CanvasVirtualImageSource))]
	internal interface ICanvasVirtualImageSource : ICanvasResourceCreatorWithDpi, ICanvasResourceCreator
	{
		VirtualSurfaceImageSource Source
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasDrawingSession CreateDrawingSession([In] Color clearColor, [In] Rect updateRectangle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SuspendDrawingSession([In] CanvasDrawingSession drawingSession);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void ResumeDrawingSession([In] CanvasDrawingSession drawingSession);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("Invalidate")]
		void Invalidate();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("InvalidateRegion")]
		void Invalidate([In] Rect region);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void RaiseRegionsInvalidatedIfAny();

		event TypedEventHandler<CanvasVirtualImageSource, CanvasRegionsInvalidatedEventArgs> RegionsInvalidated;

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("ResizeWithSize")]
		void Resize([In] Size size);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("ResizeWithWidthAndHeight")]
		void Resize([In] float width, [In] float height);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("ResizeWithWidthAndHeightAndDpi")]
		void Resize([In] float width, [In] float height, [In] float dpi);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Recreate([In] ICanvasResourceCreator resourceCreator);

		Size Size
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		BitmapSize SizeInPixels
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		CanvasAlphaMode AlphaMode
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
