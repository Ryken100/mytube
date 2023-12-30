using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX.Direct3D11;

namespace Microsoft.Graphics.Canvas
{
	// Token: 0x02000047 RID: 71
	[Version(167772160U)]
	[Guid(3352428087U, 56663, 17879, 188, 193, 21, 98, 90, 33, 232, 213)]
	[ExclusiveTo(typeof(CanvasRenderTarget))]
	internal interface ICanvasRenderTargetStatics
	{
		// Token: 0x06000147 RID: 327
		[Overload("CreateFromDirect3D11Surface")]
		CanvasRenderTarget CreateFromDirect3D11Surface([In] ICanvasResourceCreator resourceCreator, [In] IDirect3DSurface surface);

		// Token: 0x06000148 RID: 328
		[Overload("CreateFromDirect3D11SurfaceWithDpi")]
		CanvasRenderTarget CreateFromDirect3D11Surface([In] ICanvasResourceCreator resourceCreator, [In] IDirect3DSurface surface, [In] float dpi);

		// Token: 0x06000149 RID: 329
		[Overload("CreateFromDirect3D11SurfaceWithDpiAndAlpha")]
		CanvasRenderTarget CreateFromDirect3D11Surface([In] ICanvasResourceCreator resourceCreator, [In] IDirect3DSurface surface, [In] float dpi, [In] CanvasAlphaMode alpha);
	}
}
