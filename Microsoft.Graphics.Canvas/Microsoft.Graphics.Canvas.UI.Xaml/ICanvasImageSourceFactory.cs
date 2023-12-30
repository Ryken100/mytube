using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.UI.Xaml
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(2241248989u, 55287, 19563, 177, 173, 65, 148, 144, 53, 224, 132)]
	[Version(167772160u)]
	[ExclusiveTo(typeof(CanvasImageSource))]
	internal interface ICanvasImageSourceFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasImageSource CreateWithSize([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Size size);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasImageSource CreateWithWidthAndHeight([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] float width, [In] float height);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasImageSource CreateWithWidthAndHeightAndDpi([In] ICanvasResourceCreator resourceCreator, [In] float width, [In] float height, [In] float dpi);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasImageSource CreateWithWidthAndHeightAndDpiAndAlphaMode([In] ICanvasResourceCreator resourceCreator, [In] float width, [In] float height, [In] float dpi, [In] CanvasAlphaMode alphaMode);
	}
}
