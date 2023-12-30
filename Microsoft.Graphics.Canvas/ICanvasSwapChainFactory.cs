using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX;

namespace Microsoft.Graphics.Canvas
{
	// Token: 0x020000CE RID: 206
	[Version(167772160U)]
	[ExclusiveTo(typeof(CanvasSwapChain))]
	[Guid(322708939U, 60732, 18731, 191, 254, 117, 9, 181, 33, 132, 43)]
	internal interface ICanvasSwapChainFactory
	{
		// Token: 0x060006CC RID: 1740
		CanvasSwapChain CreateWithSize([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Size size);

		// Token: 0x060006CD RID: 1741
		CanvasSwapChain CreateWithWidthAndHeight([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] float width, [In] float height);

		// Token: 0x060006CE RID: 1742
		CanvasSwapChain CreateWithWidthAndHeightAndDpi([In] ICanvasResourceCreator resourceCreator, [In] float width, [In] float height, [In] float dpi);

		// Token: 0x060006CF RID: 1743
		CanvasSwapChain CreateWithAllOptions([In] ICanvasResourceCreator resourceCreator, [In] float width, [In] float height, [In] float dpi, [In] DirectXPixelFormat format, [In] int bufferCount, [In] CanvasAlphaMode alphaMode);
	}
}
