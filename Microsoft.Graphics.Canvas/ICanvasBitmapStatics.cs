using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX;
using Windows.Graphics.DirectX.Direct3D11;
using Windows.Graphics.Imaging;
using Windows.Storage.Streams;
using Windows.UI;

namespace Microsoft.Graphics.Canvas
{
	// Token: 0x02000045 RID: 69
	[ExclusiveTo(typeof(CanvasBitmap))]
	[Guid(3365178858U, 42013, 19650, 175, 154, 253, 222, 1, 182, 6, 220)]
	[Version(167772160U)]
	internal interface ICanvasBitmapStatics
	{
		// Token: 0x0600012D RID: 301
		[Overload("CreateFromDirect3D11Surface")]
		CanvasBitmap CreateFromDirect3D11Surface([In] ICanvasResourceCreator resourceCreator, [In] IDirect3DSurface surface);

		// Token: 0x0600012E RID: 302
		[Overload("CreateFromDirect3D11SurfaceWithDpi")]
		CanvasBitmap CreateFromDirect3D11Surface([In] ICanvasResourceCreator resourceCreator, [In] IDirect3DSurface surface, [In] float dpi);

		// Token: 0x0600012F RID: 303
		[Overload("CreateFromDirect3D11SurfaceWithDpiAndAlpha")]
		CanvasBitmap CreateFromDirect3D11Surface([In] ICanvasResourceCreator resourceCreator, [In] IDirect3DSurface surface, [In] float dpi, [In] CanvasAlphaMode alpha);

		// Token: 0x06000130 RID: 304
		[Overload("CreateFromBytes")]
		[DefaultOverload]
		CanvasBitmap CreateFromBytes([In] ICanvasResourceCreator resourceCreator, [In] byte[] bytes, [In] int widthInPixels, [In] int heightInPixels, [In] DirectXPixelFormat format);

		// Token: 0x06000131 RID: 305
		[DefaultOverload]
		[Overload("CreateFromBytesWithDpi")]
		CanvasBitmap CreateFromBytes([In] ICanvasResourceCreator resourceCreator, [In] byte[] bytes, [In] int widthInPixels, [In] int heightInPixels, [In] DirectXPixelFormat format, [In] float dpi);

		// Token: 0x06000132 RID: 306
		[Overload("CreateFromBytesWithDpiAndAlpha")]
		[DefaultOverload]
		CanvasBitmap CreateFromBytes([In] ICanvasResourceCreator resourceCreator, [In] byte[] bytes, [In] int widthInPixels, [In] int heightInPixels, [In] DirectXPixelFormat format, [In] float dpi, [In] CanvasAlphaMode alpha);

		// Token: 0x06000133 RID: 307
		[Overload("CreateFromBytesWithBuffer")]
		CanvasBitmap CreateFromBytes([In] ICanvasResourceCreator resourceCreator, [In] IBuffer buffer, [In] int widthInPixels, [In] int heightInPixels, [In] DirectXPixelFormat format);

		// Token: 0x06000134 RID: 308
		[Overload("CreateFromBytesWithBufferAndDpi")]
		CanvasBitmap CreateFromBytes([In] ICanvasResourceCreator resourceCreator, [In] IBuffer buffer, [In] int widthInPixels, [In] int heightInPixels, [In] DirectXPixelFormat format, [In] float dpi);

		// Token: 0x06000135 RID: 309
		[Overload("CreateFromBytesWithBufferAndDpiAndAlpha")]
		CanvasBitmap CreateFromBytes([In] ICanvasResourceCreator resourceCreator, [In] IBuffer buffer, [In] int widthInPixels, [In] int heightInPixels, [In] DirectXPixelFormat format, [In] float dpi, [In] CanvasAlphaMode alpha);

		// Token: 0x06000136 RID: 310
		[Overload("CreateFromColors")]
		CanvasBitmap CreateFromColors([In] ICanvasResourceCreator resourceCreator, [In] Color[] colors, [In] int widthInPixels, [In] int heightInPixels);

		// Token: 0x06000137 RID: 311
		[Overload("CreateFromColorsWithDpi")]
		CanvasBitmap CreateFromColors([In] ICanvasResourceCreator resourceCreator, [In] Color[] colors, [In] int widthInPixels, [In] int heightInPixels, [In] float dpi);

		// Token: 0x06000138 RID: 312
		[Overload("CreateFromColorsWithDpiAndAlpha")]
		CanvasBitmap CreateFromColors([In] ICanvasResourceCreator resourceCreator, [In] Color[] colors, [In] int widthInPixels, [In] int heightInPixels, [In] float dpi, [In] CanvasAlphaMode alpha);

		// Token: 0x06000139 RID: 313
		CanvasBitmap CreateFromSoftwareBitmap([In] ICanvasResourceCreator resourceCreator, [In] SoftwareBitmap sourceBitmap);

		// Token: 0x0600013A RID: 314
		[Overload("LoadAsyncFromHstring")]
		IAsyncOperation<CanvasBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] string fileName);

		// Token: 0x0600013B RID: 315
		[Overload("LoadAsyncFromHstringWithDpi")]
		IAsyncOperation<CanvasBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] string fileName, [In] float dpi);

		// Token: 0x0600013C RID: 316
		[Overload("LoadAsyncFromHstringWithDpiAndAlpha")]
		IAsyncOperation<CanvasBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] string fileName, [In] float dpi, [In] CanvasAlphaMode alpha);

		// Token: 0x0600013D RID: 317
		[DefaultOverload]
		[Overload("LoadAsyncFromUri")]
		IAsyncOperation<CanvasBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] Uri uri);

		// Token: 0x0600013E RID: 318
		[DefaultOverload]
		[Overload("LoadAsyncFromUriWithDpi")]
		IAsyncOperation<CanvasBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] Uri uri, [In] float dpi);

		// Token: 0x0600013F RID: 319
		[DefaultOverload]
		[Overload("LoadAsyncFromUriWithDpiAndAlpha")]
		IAsyncOperation<CanvasBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] Uri uri, [In] float dpi, [In] CanvasAlphaMode alpha);

		// Token: 0x06000140 RID: 320
		[Overload("LoadAsyncFromStream")]
		IAsyncOperation<CanvasBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] IRandomAccessStream stream);

		// Token: 0x06000141 RID: 321
		[Overload("LoadAsyncFromStreamWithDpi")]
		IAsyncOperation<CanvasBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] IRandomAccessStream stream, [In] float dpi);

		// Token: 0x06000142 RID: 322
		[Overload("LoadAsyncFromStreamWithDpiAndAlpha")]
		IAsyncOperation<CanvasBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] IRandomAccessStream stream, [In] float dpi, [In] CanvasAlphaMode alpha);
	}
}
