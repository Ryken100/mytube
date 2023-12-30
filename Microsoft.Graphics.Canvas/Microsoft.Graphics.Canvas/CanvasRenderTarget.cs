using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX.Direct3D11;

namespace Microsoft.Graphics.Canvas
{
	[ComImport]
	[Activatable(typeof(ICanvasRenderTargetFactory), 167772160u)]
	[Static(typeof(ICanvasRenderTargetStatics), 167772160u)]
	[MarshalingBehavior(MarshalingType.Agile)]
	[Version(167772160u)]
	[Threading(ThreadingModel.Both)]
	public sealed class CanvasRenderTarget : CanvasBitmap, ICanvasRenderTarget
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern CanvasDrawingSession CreateDrawingSession();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateFromDirect3D11Surface")]
		public new static extern CanvasRenderTarget CreateFromDirect3D11Surface([In] ICanvasResourceCreator resourceCreator, [In] IDirect3DSurface surface);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateFromDirect3D11SurfaceWithDpi")]
		public new static extern CanvasRenderTarget CreateFromDirect3D11Surface([In] ICanvasResourceCreator resourceCreator, [In] IDirect3DSurface surface, [In] float dpi);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateFromDirect3D11SurfaceWithDpiAndAlpha")]
		public new static extern CanvasRenderTarget CreateFromDirect3D11Surface([In] ICanvasResourceCreator resourceCreator, [In] IDirect3DSurface surface, [In] float dpi, [In] CanvasAlphaMode alpha);
	}
}
