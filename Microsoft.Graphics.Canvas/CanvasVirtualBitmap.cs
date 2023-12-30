using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;
using Windows.Graphics.Imaging;
using Windows.Storage.Streams;

namespace Microsoft.Graphics.Canvas
{
	// Token: 0x0200004D RID: 77
	[Version(167772160U)]
	[Threading(3)]
	[MarshalingBehavior(2)]
	[Static(typeof(ICanvasVirtualBitmapStatics), 167772160U)]
	public sealed class CanvasVirtualBitmap : ICanvasVirtualBitmap, ICanvasImage, IClosable, IGraphicsEffectSource
	{
		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600021C RID: 540
		public extern CanvasDevice Device { get; }

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600021D RID: 541
		public extern bool IsCachedOnDemand { get; }

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600021E RID: 542
		public extern BitmapSize SizeInPixels { get; }

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600021F RID: 543
		public extern Size Size { get; }

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000220 RID: 544
		public extern Rect Bounds { get; }

		// Token: 0x06000221 RID: 545
		public extern void Close();

		// Token: 0x06000222 RID: 546
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000223 RID: 547
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000224 RID: 548
		[Overload("LoadAsyncFromFileName")]
		public static extern IAsyncOperation<CanvasVirtualBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] string fileName);

		// Token: 0x06000225 RID: 549
		[Overload("LoadAsyncFromFileNameWithOptions")]
		public static extern IAsyncOperation<CanvasVirtualBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] string fileName, [In] CanvasVirtualBitmapOptions options);

		// Token: 0x06000226 RID: 550
		[Overload("LoadAsyncFromFileNameWithOptionsAndAlpha")]
		public static extern IAsyncOperation<CanvasVirtualBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] string fileName, [In] CanvasVirtualBitmapOptions options, [In] CanvasAlphaMode alpha);

		// Token: 0x06000227 RID: 551
		[Overload("LoadAsyncFromUri")]
		public static extern IAsyncOperation<CanvasVirtualBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] Uri uri);

		// Token: 0x06000228 RID: 552
		[Overload("LoadAsyncFromUriWithOptions")]
		public static extern IAsyncOperation<CanvasVirtualBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] Uri uri, [In] CanvasVirtualBitmapOptions options);

		// Token: 0x06000229 RID: 553
		[Overload("LoadAsyncFromUriWithOptionsAndAlpha")]
		public static extern IAsyncOperation<CanvasVirtualBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] Uri uri, [In] CanvasVirtualBitmapOptions options, [In] CanvasAlphaMode alpha);

		// Token: 0x0600022A RID: 554
		[DefaultOverload]
		[Overload("LoadAsyncFromStream")]
		public static extern IAsyncOperation<CanvasVirtualBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] IRandomAccessStream stream);

		// Token: 0x0600022B RID: 555
		[Overload("LoadAsyncFromStreamWithOptions")]
		[DefaultOverload]
		public static extern IAsyncOperation<CanvasVirtualBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] IRandomAccessStream stream, [In] CanvasVirtualBitmapOptions options);

		// Token: 0x0600022C RID: 556
		[Overload("LoadAsyncFromStreamWithOptionsAndAlpha")]
		[DefaultOverload]
		public static extern IAsyncOperation<CanvasVirtualBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] IRandomAccessStream stream, [In] CanvasVirtualBitmapOptions options, [In] CanvasAlphaMode alpha);
	}
}
