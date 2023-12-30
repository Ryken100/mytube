using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.UI.Xaml
{
	[ComImport]
	[Version(167772160u)]
	[ExclusiveTo(typeof(CanvasVirtualImageSource))]
	[Windows.Foundation.Metadata.Guid(803689889u, 12410, 17955, 146, 80, 41, 89, 4, 133, 189, 182)]
	internal interface ICanvasVirtualImageSourceFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasVirtualImageSource CreateWithSize([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Size size);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasVirtualImageSource CreateWithWidthAndHeight([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] float width, [In] float height);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasVirtualImageSource CreateWithWidthAndHeightAndDpi([In] ICanvasResourceCreator resourceCreator, [In] float width, [In] float height, [In] float dpi);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasVirtualImageSource CreateWithWidthAndHeightAndDpiAndAlphaMode([In] ICanvasResourceCreator resourceCreator, [In] float width, [In] float height, [In] float dpi, [In] CanvasAlphaMode alphaMode);
	}
}
