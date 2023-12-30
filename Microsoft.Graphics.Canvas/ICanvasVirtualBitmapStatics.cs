using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Microsoft.Graphics.Canvas
{
	// Token: 0x0200004C RID: 76
	[Version(167772160U)]
	[Guid(3002202345U, 1904, 19924, 149, 109, 120, 217, 17, 57, 9, 87)]
	[ExclusiveTo(typeof(CanvasVirtualBitmap))]
	internal interface ICanvasVirtualBitmapStatics
	{
		// Token: 0x06000213 RID: 531
		[Overload("LoadAsyncFromFileName")]
		IAsyncOperation<CanvasVirtualBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] string fileName);

		// Token: 0x06000214 RID: 532
		[Overload("LoadAsyncFromFileNameWithOptions")]
		IAsyncOperation<CanvasVirtualBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] string fileName, [In] CanvasVirtualBitmapOptions options);

		// Token: 0x06000215 RID: 533
		[Overload("LoadAsyncFromFileNameWithOptionsAndAlpha")]
		IAsyncOperation<CanvasVirtualBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] string fileName, [In] CanvasVirtualBitmapOptions options, [In] CanvasAlphaMode alpha);

		// Token: 0x06000216 RID: 534
		[Overload("LoadAsyncFromUri")]
		IAsyncOperation<CanvasVirtualBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] Uri uri);

		// Token: 0x06000217 RID: 535
		[Overload("LoadAsyncFromUriWithOptions")]
		IAsyncOperation<CanvasVirtualBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] Uri uri, [In] CanvasVirtualBitmapOptions options);

		// Token: 0x06000218 RID: 536
		[Overload("LoadAsyncFromUriWithOptionsAndAlpha")]
		IAsyncOperation<CanvasVirtualBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] Uri uri, [In] CanvasVirtualBitmapOptions options, [In] CanvasAlphaMode alpha);

		// Token: 0x06000219 RID: 537
		[DefaultOverload]
		[Overload("LoadAsyncFromStream")]
		IAsyncOperation<CanvasVirtualBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] IRandomAccessStream stream);

		// Token: 0x0600021A RID: 538
		[Overload("LoadAsyncFromStreamWithOptions")]
		[DefaultOverload]
		IAsyncOperation<CanvasVirtualBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] IRandomAccessStream stream, [In] CanvasVirtualBitmapOptions options);

		// Token: 0x0600021B RID: 539
		[Overload("LoadAsyncFromStreamWithOptionsAndAlpha")]
		[DefaultOverload]
		IAsyncOperation<CanvasVirtualBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] IRandomAccessStream stream, [In] CanvasVirtualBitmapOptions options, [In] CanvasAlphaMode alpha);
	}
}
