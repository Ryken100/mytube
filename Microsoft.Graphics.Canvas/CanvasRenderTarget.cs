using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX;
using Windows.Graphics.DirectX.Direct3D11;

namespace Microsoft.Graphics.Canvas
{
	// Token: 0x02000049 RID: 73
	[Activatable(typeof(ICanvasRenderTargetFactory), 167772160U)]
	[Static(typeof(ICanvasRenderTargetStatics), 167772160U)]
	[MarshalingBehavior(2)]
	[Version(167772160U)]
	[Threading(3)]
	public sealed class CanvasRenderTarget : CanvasBitmap, ICanvasRenderTarget
	{
		// Token: 0x0600014B RID: 331
		public extern CanvasRenderTarget([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Size size);

		// Token: 0x0600014C RID: 332
		public extern CanvasRenderTarget([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] float width, [In] float height);

		// Token: 0x0600014D RID: 333
		public extern CanvasRenderTarget([In] ICanvasResourceCreator resourceCreator, [In] float width, [In] float height, [In] float dpi);

		// Token: 0x0600014E RID: 334
		public extern CanvasRenderTarget([In] ICanvasResourceCreator resourceCreator, [In] float width, [In] float height, [In] float dpi, [In] DirectXPixelFormat format, [In] CanvasAlphaMode alpha);

		// Token: 0x0600014F RID: 335
		public extern CanvasDrawingSession CreateDrawingSession();

		// Token: 0x06000150 RID: 336
		[Overload("CreateFromDirect3D11Surface")]
		public new static extern CanvasRenderTarget CreateFromDirect3D11Surface([In] ICanvasResourceCreator resourceCreator, [In] IDirect3DSurface surface);

		// Token: 0x06000151 RID: 337
		[Overload("CreateFromDirect3D11SurfaceWithDpi")]
		public new static extern CanvasRenderTarget CreateFromDirect3D11Surface([In] ICanvasResourceCreator resourceCreator, [In] IDirect3DSurface surface, [In] float dpi);

		// Token: 0x06000152 RID: 338
		[Overload("CreateFromDirect3D11SurfaceWithDpiAndAlpha")]
		public new static extern CanvasRenderTarget CreateFromDirect3D11Surface([In] ICanvasResourceCreator resourceCreator, [In] IDirect3DSurface surface, [In] float dpi, [In] CanvasAlphaMode alpha);
	}
}
