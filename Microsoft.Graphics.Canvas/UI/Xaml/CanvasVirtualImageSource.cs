using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;
using Windows.UI;
using Windows.UI.Xaml.Media.Imaging;

namespace Microsoft.Graphics.Canvas.UI.Xaml
{
	// Token: 0x020000F5 RID: 245
	[Activatable(typeof(ICanvasVirtualImageSourceFactory), 167772160U)]
	[MarshalingBehavior(2)]
	[Version(167772160U)]
	[Threading(3)]
	public sealed class CanvasVirtualImageSource : ICanvasVirtualImageSource, ICanvasResourceCreatorWithDpi, ICanvasResourceCreator
	{
		// Token: 0x060007D4 RID: 2004
		public extern CanvasVirtualImageSource([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] Size size);

		// Token: 0x060007D5 RID: 2005
		public extern CanvasVirtualImageSource([In] ICanvasResourceCreatorWithDpi resourceCreator, [In] float width, [In] float height);

		// Token: 0x060007D6 RID: 2006
		public extern CanvasVirtualImageSource([In] ICanvasResourceCreator resourceCreator, [In] float width, [In] float height, [In] float dpi);

		// Token: 0x060007D7 RID: 2007
		public extern CanvasVirtualImageSource([In] ICanvasResourceCreator resourceCreator, [In] float width, [In] float height, [In] float dpi, [In] CanvasAlphaMode alphaMode);

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x060007D8 RID: 2008
		public extern VirtualSurfaceImageSource Source { get; }

		// Token: 0x060007D9 RID: 2009
		public extern CanvasDrawingSession CreateDrawingSession([In] Color clearColor, [In] Rect updateRectangle);

		// Token: 0x060007DA RID: 2010
		public extern void SuspendDrawingSession([In] CanvasDrawingSession drawingSession);

		// Token: 0x060007DB RID: 2011
		public extern void ResumeDrawingSession([In] CanvasDrawingSession drawingSession);

		// Token: 0x060007DC RID: 2012
		[Overload("Invalidate")]
		public extern void Invalidate();

		// Token: 0x060007DD RID: 2013
		[Overload("InvalidateRegion")]
		public extern void Invalidate([In] Rect region);

		// Token: 0x060007DE RID: 2014
		public extern void RaiseRegionsInvalidatedIfAny();

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x060007DF RID: 2015
		// (remove) Token: 0x060007E0 RID: 2016
		public extern event TypedEventHandler<CanvasVirtualImageSource, CanvasRegionsInvalidatedEventArgs> RegionsInvalidated;

		// Token: 0x060007E1 RID: 2017
		[Overload("ResizeWithSize")]
		public extern void Resize([In] Size size);

		// Token: 0x060007E2 RID: 2018
		[Overload("ResizeWithWidthAndHeight")]
		public extern void Resize([In] float width, [In] float height);

		// Token: 0x060007E3 RID: 2019
		[Overload("ResizeWithWidthAndHeightAndDpi")]
		public extern void Resize([In] float width, [In] float height, [In] float dpi);

		// Token: 0x060007E4 RID: 2020
		public extern void Recreate([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x060007E5 RID: 2021
		public extern Size Size { get; }

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x060007E6 RID: 2022
		public extern BitmapSize SizeInPixels { get; }

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x060007E7 RID: 2023
		public extern CanvasAlphaMode AlphaMode { get; }

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x060007E8 RID: 2024
		public extern float Dpi { get; }

		// Token: 0x060007E9 RID: 2025
		public extern float ConvertPixelsToDips([In] int pixels);

		// Token: 0x060007EA RID: 2026
		public extern int ConvertDipsToPixels([In] float dips, [In] CanvasDpiRounding dpiRounding);

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x060007EB RID: 2027
		public extern CanvasDevice Device { get; }
	}
}
