using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX;

namespace Microsoft.Graphics.Canvas
{
	[ComImport]
	[Version(167772160u)]
	[Windows.Foundation.Metadata.Guid(1645084091u, 40200, 16492, 191, 230, 217, 184, 30, 109, 248, 231)]
	[ExclusiveTo(typeof(CanvasRenderTarget))]
	internal interface ICanvasRenderTargetFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasRenderTarget CreateWithSize([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Size size);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasRenderTarget CreateWithWidthAndHeight([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] float width, [In] float height);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasRenderTarget CreateWithWidthAndHeightAndDpi([In] ICanvasResourceCreator resourceCreator, [In] float width, [In] float height, [In] float dpi);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasRenderTarget CreateWithWidthAndHeightAndDpiAndFormatAndAlpha([In] ICanvasResourceCreator resourceCreator, [In] float width, [In] float height, [In] float dpi, [In] DirectXPixelFormat format, [In] CanvasAlphaMode alpha);
	}
}
