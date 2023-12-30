using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;
using Windows.UI;
using Windows.UI.Xaml.Media.Imaging;

namespace Microsoft.Graphics.Canvas.UI.Xaml
{
	// Token: 0x020000F6 RID: 246
	[Version(167772160U)]
	[Guid(3744737671U, 20454, 19405, 184, 133, 42, 211, 230, 239, 159, 206)]
	[ExclusiveTo(typeof(CanvasVirtualImageSource))]
	internal interface ICanvasVirtualImageSource : ICanvasResourceCreatorWithDpi, ICanvasResourceCreator
	{
		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x060007EC RID: 2028
		VirtualSurfaceImageSource Source { get; }

		// Token: 0x060007ED RID: 2029
		CanvasDrawingSession CreateDrawingSession([In] Color clearColor, [In] Rect updateRectangle);

		// Token: 0x060007EE RID: 2030
		void SuspendDrawingSession([In] CanvasDrawingSession drawingSession);

		// Token: 0x060007EF RID: 2031
		void ResumeDrawingSession([In] CanvasDrawingSession drawingSession);

		// Token: 0x060007F0 RID: 2032
		[Overload("Invalidate")]
		void Invalidate();

		// Token: 0x060007F1 RID: 2033
		[Overload("InvalidateRegion")]
		void Invalidate([In] Rect region);

		// Token: 0x060007F2 RID: 2034
		void RaiseRegionsInvalidatedIfAny();

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x060007F3 RID: 2035
		// (remove) Token: 0x060007F4 RID: 2036
		event TypedEventHandler<CanvasVirtualImageSource, CanvasRegionsInvalidatedEventArgs> RegionsInvalidated;

		// Token: 0x060007F5 RID: 2037
		[Overload("ResizeWithSize")]
		void Resize([In] Size size);

		// Token: 0x060007F6 RID: 2038
		[Overload("ResizeWithWidthAndHeight")]
		void Resize([In] float width, [In] float height);

		// Token: 0x060007F7 RID: 2039
		[Overload("ResizeWithWidthAndHeightAndDpi")]
		void Resize([In] float width, [In] float height, [In] float dpi);

		// Token: 0x060007F8 RID: 2040
		void Recreate([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x060007F9 RID: 2041
		Size Size { get; }

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x060007FA RID: 2042
		BitmapSize SizeInPixels { get; }

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x060007FB RID: 2043
		CanvasAlphaMode AlphaMode { get; }
	}
}
