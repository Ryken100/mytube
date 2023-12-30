using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX;
using Windows.UI.Core;

namespace Microsoft.Graphics.Canvas
{
	[ComImport]
	[Version(167772160u)]
	[ExclusiveTo(typeof(CanvasSwapChain))]
	[Windows.Foundation.Metadata.Guid(87518607u, 16013, 19074, 152, 56, 105, 22, 128, 211, 42, 82)]
	internal interface ICanvasSwapChainStatics
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateForCoreWindowWithDpi")]
		CanvasSwapChain CreateForCoreWindow([In] ICanvasResourceCreator resourceCreator, [In] CoreWindow coreWindow, [In] float dpi);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateForCoreWindowWithAllOptions")]
		CanvasSwapChain CreateForCoreWindow([In] ICanvasResourceCreator resourceCreator, [In] CoreWindow coreWindow, [In] float width, [In] float height, [In] float dpi, [In] DirectXPixelFormat format, [In] int bufferCount);
	}
}
