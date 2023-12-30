using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX.Direct3D11;

namespace Microsoft.Graphics.Canvas
{
	[ComImport]
	[Version(167772160u)]
	[Windows.Foundation.Metadata.Guid(3352428087u, 56663, 17879, 188, 193, 21, 98, 90, 33, 232, 213)]
	[ExclusiveTo(typeof(CanvasRenderTarget))]
	internal interface ICanvasRenderTargetStatics
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateFromDirect3D11Surface")]
		CanvasRenderTarget CreateFromDirect3D11Surface([In] ICanvasResourceCreator resourceCreator, [In] IDirect3DSurface surface);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateFromDirect3D11SurfaceWithDpi")]
		CanvasRenderTarget CreateFromDirect3D11Surface([In] ICanvasResourceCreator resourceCreator, [In] IDirect3DSurface surface, [In] float dpi);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateFromDirect3D11SurfaceWithDpiAndAlpha")]
		CanvasRenderTarget CreateFromDirect3D11Surface([In] ICanvasResourceCreator resourceCreator, [In] IDirect3DSurface surface, [In] float dpi, [In] CanvasAlphaMode alpha);
	}
}
