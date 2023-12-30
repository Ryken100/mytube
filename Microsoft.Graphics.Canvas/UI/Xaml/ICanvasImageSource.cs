using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;
using Windows.UI;

namespace Microsoft.Graphics.Canvas.UI.Xaml
{
	// Token: 0x020000CB RID: 203
	[Guid(1010165882U, 59521, 20292, 176, 209, 85, 20, 19, 174, 198, 109)]
	[Version(167772160U)]
	[ExclusiveTo(typeof(CanvasImageSource))]
	internal interface ICanvasImageSource : ICanvasResourceCreatorWithDpi, ICanvasResourceCreator
	{
		// Token: 0x060006B8 RID: 1720
		[Overload("CreateDrawingSession")]
		CanvasDrawingSession CreateDrawingSession([In] Color clearColor);

		// Token: 0x060006B9 RID: 1721
		[Overload("CreateDrawingSessionWithUpdateRectangle")]
		CanvasDrawingSession CreateDrawingSession([In] Color clearColor, [In] Rect updateRectangle);

		// Token: 0x060006BA RID: 1722
		void Recreate([In] ICanvasResourceCreator value);

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x060006BB RID: 1723
		Size Size { get; }

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x060006BC RID: 1724
		BitmapSize SizeInPixels { get; }

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x060006BD RID: 1725
		CanvasAlphaMode AlphaMode { get; }
	}
}
