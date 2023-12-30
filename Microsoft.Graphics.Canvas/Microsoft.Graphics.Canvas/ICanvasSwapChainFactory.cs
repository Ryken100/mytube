using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX;

namespace Microsoft.Graphics.Canvas
{
	[ComImport]
	[Version(167772160u)]
	[ExclusiveTo(typeof(CanvasSwapChain))]
	[Windows.Foundation.Metadata.Guid(322708939u, 60732, 18731, 191, 254, 117, 9, 181, 33, 132, 43)]
	internal interface ICanvasSwapChainFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasSwapChain CreateWithSize([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Size size);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasSwapChain CreateWithWidthAndHeight([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] float width, [In] float height);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasSwapChain CreateWithWidthAndHeightAndDpi([In] ICanvasResourceCreator resourceCreator, [In] float width, [In] float height, [In] float dpi);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasSwapChain CreateWithAllOptions([In] ICanvasResourceCreator resourceCreator, [In] float width, [In] float height, [In] float dpi, [In] DirectXPixelFormat format, [In] int bufferCount, [In] CanvasAlphaMode alphaMode);
	}
}
