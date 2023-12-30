using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;
using Windows.Graphics.Imaging;

namespace Microsoft.Graphics.Canvas
{
	// Token: 0x0200004E RID: 78
	[Version(167772160U)]
	[Guid(1887275952U, 1529, 18508, 158, 226, 23, 158, 6, 129, 200, 167)]
	[ExclusiveTo(typeof(CanvasVirtualBitmap))]
	internal interface ICanvasVirtualBitmap : IClosable, ICanvasImage, IGraphicsEffectSource
	{
		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x0600022D RID: 557
		CanvasDevice Device { get; }

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x0600022E RID: 558
		bool IsCachedOnDemand { get; }

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x0600022F RID: 559
		BitmapSize SizeInPixels { get; }

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06000230 RID: 560
		Size Size { get; }

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06000231 RID: 561
		Rect Bounds { get; }
	}
}
