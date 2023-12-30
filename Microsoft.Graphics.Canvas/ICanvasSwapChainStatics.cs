using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX;
using Windows.UI.Core;

namespace Microsoft.Graphics.Canvas
{
	// Token: 0x020000D0 RID: 208
	[Version(167772160U)]
	[ExclusiveTo(typeof(CanvasSwapChain))]
	[Guid(87518607U, 16013, 19074, 152, 56, 105, 22, 128, 211, 42, 82)]
	internal interface ICanvasSwapChainStatics
	{
		// Token: 0x060006EE RID: 1774
		[Overload("CreateForCoreWindowWithDpi")]
		CanvasSwapChain CreateForCoreWindow([In] ICanvasResourceCreator resourceCreator, [In] CoreWindow coreWindow, [In] float dpi);

		// Token: 0x060006EF RID: 1775
		[Overload("CreateForCoreWindowWithAllOptions")]
		CanvasSwapChain CreateForCoreWindow([In] ICanvasResourceCreator resourceCreator, [In] CoreWindow coreWindow, [In] float width, [In] float height, [In] float dpi, [In] DirectXPixelFormat format, [In] int bufferCount);
	}
}
