using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;
using Windows.UI;
using Windows.UI.Xaml.Media.Imaging;

namespace Microsoft.Graphics.Canvas.UI.Xaml
{
	// Token: 0x020000CC RID: 204
	[Threading(3)]
	[Version(167772160U)]
	[Activatable(typeof(ICanvasImageSourceFactory), 167772160U)]
	[MarshalingBehavior(2)]
	public sealed class CanvasImageSource : SurfaceImageSource, ICanvasImageSource, ICanvasResourceCreatorWithDpi, ICanvasResourceCreator
	{
		// Token: 0x060006BE RID: 1726
		public extern CanvasImageSource([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Size size);

		// Token: 0x060006BF RID: 1727
		public extern CanvasImageSource([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] float width, [In] float height);

		// Token: 0x060006C0 RID: 1728
		public extern CanvasImageSource([In] ICanvasResourceCreator resourceCreator, [In] float width, [In] float height, [In] float dpi);

		// Token: 0x060006C1 RID: 1729
		public extern CanvasImageSource([In] ICanvasResourceCreator resourceCreator, [In] float width, [In] float height, [In] float dpi, [In] CanvasAlphaMode alphaMode);

		// Token: 0x060006C2 RID: 1730
		[Overload("CreateDrawingSession")]
		public extern CanvasDrawingSession CreateDrawingSession([In] Color clearColor);

		// Token: 0x060006C3 RID: 1731
		[Overload("CreateDrawingSessionWithUpdateRectangle")]
		public extern CanvasDrawingSession CreateDrawingSession([In] Color clearColor, [In] Rect updateRectangle);

		// Token: 0x060006C4 RID: 1732
		public extern void Recreate([In] ICanvasResourceCreator value);

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x060006C5 RID: 1733
		public extern Size Size { get; }

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x060006C6 RID: 1734
		public extern BitmapSize SizeInPixels { get; }

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x060006C7 RID: 1735
		public extern CanvasAlphaMode AlphaMode { get; }

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x060006C8 RID: 1736
		public extern float Dpi { get; }

		// Token: 0x060006C9 RID: 1737
		public extern float ConvertPixelsToDips([In] int pixels);

		// Token: 0x060006CA RID: 1738
		public extern int ConvertDipsToPixels([In] float dips, [In] CanvasDpiRounding dpiRounding);

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x060006CB RID: 1739
		public extern CanvasDevice Device { get; }
	}
}
