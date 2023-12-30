using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX;

namespace Microsoft.Graphics.Canvas
{
	// Token: 0x02000046 RID: 70
	[Version(167772160U)]
	[Guid(1645084091U, 40200, 16492, 191, 230, 217, 184, 30, 109, 248, 231)]
	[ExclusiveTo(typeof(CanvasRenderTarget))]
	internal interface ICanvasRenderTargetFactory
	{
		// Token: 0x06000143 RID: 323
		CanvasRenderTarget CreateWithSize([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Size size);

		// Token: 0x06000144 RID: 324
		CanvasRenderTarget CreateWithWidthAndHeight([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] float width, [In] float height);

		// Token: 0x06000145 RID: 325
		CanvasRenderTarget CreateWithWidthAndHeightAndDpi([In] ICanvasResourceCreator resourceCreator, [In] float width, [In] float height, [In] float dpi);

		// Token: 0x06000146 RID: 326
		CanvasRenderTarget CreateWithWidthAndHeightAndDpiAndFormatAndAlpha([In] ICanvasResourceCreator resourceCreator, [In] float width, [In] float height, [In] float dpi, [In] DirectXPixelFormat format, [In] CanvasAlphaMode alpha);
	}
}
