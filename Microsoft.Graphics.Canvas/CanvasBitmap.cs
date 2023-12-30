using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.DirectX;
using Windows.Graphics.DirectX.Direct3D11;
using Windows.Graphics.Effects;
using Windows.Graphics.Imaging;
using Windows.Storage.Streams;
using Windows.UI;
using Windows.UI.Xaml;

namespace Microsoft.Graphics.Canvas
{
	// Token: 0x02000044 RID: 68
	[Threading(3)]
	[Static(typeof(ICanvasBitmapStatics), 167772160U)]
	[Composable(typeof(ICanvasBitmapFactory), 2, 167772160U)]
	[MarshalingBehavior(2)]
	[Version(167772160U)]
	public class CanvasBitmap : DependencyObject, ICanvasBitmap, ICanvasResourceCreatorWithDpi, ICanvasResourceCreator, IDirect3DSurface, IClosable, ICanvasImage, IGraphicsEffectSource
	{
		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000F6 RID: 246
		public extern BitmapSize SizeInPixels { get; }

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000F7 RID: 247
		public extern Size Size { get; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000F8 RID: 248
		public extern Rect Bounds { get; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000F9 RID: 249
		public extern DirectXPixelFormat Format { get; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000FA RID: 250
		public extern CanvasAlphaMode AlphaMode { get; }

		// Token: 0x060000FB RID: 251
		[Overload("SaveToFileAsync")]
		public extern IAsyncAction SaveAsync([In] string fileName);

		// Token: 0x060000FC RID: 252
		[Overload("SaveToFileWithBitmapFileFormatAsync")]
		[DefaultOverload]
		public extern IAsyncAction SaveAsync([In] string fileName, [In] CanvasBitmapFileFormat fileFormat);

		// Token: 0x060000FD RID: 253
		[DefaultOverload]
		[Overload("SaveToFileWithBitmapFileFormatAndQualityAsync")]
		public extern IAsyncAction SaveAsync([In] string fileName, [In] CanvasBitmapFileFormat fileFormat, [In] float quality);

		// Token: 0x060000FE RID: 254
		[Overload("SaveToStreamAsync")]
		public extern IAsyncAction SaveAsync([In] IRandomAccessStream stream, [In] CanvasBitmapFileFormat fileFormat);

		// Token: 0x060000FF RID: 255
		[Overload("SaveToStreamWithQualityAsync")]
		public extern IAsyncAction SaveAsync([In] IRandomAccessStream stream, [In] CanvasBitmapFileFormat fileFormat, [In] float quality);

		// Token: 0x06000100 RID: 256
		[Overload("GetPixelBytes")]
		public extern byte[] GetPixelBytes();

		// Token: 0x06000101 RID: 257
		[Overload("GetPixelBytesWithSubrectangle")]
		public extern byte[] GetPixelBytes([In] int left, [In] int top, [In] int width, [In] int height);

		// Token: 0x06000102 RID: 258
		[Overload("GetPixelBytesWithBuffer")]
		public extern void GetPixelBytes([In] IBuffer buffer);

		// Token: 0x06000103 RID: 259
		[Overload("GetPixelBytesWithBufferAndSubrectangle")]
		public extern void GetPixelBytes([In] IBuffer buffer, [In] int left, [In] int top, [In] int width, [In] int height);

		// Token: 0x06000104 RID: 260
		[Overload("GetPixelColors")]
		public extern Color[] GetPixelColors();

		// Token: 0x06000105 RID: 261
		[Overload("GetPixelColorsWithSubrectangle")]
		public extern Color[] GetPixelColors([In] int left, [In] int top, [In] int width, [In] int height);

		// Token: 0x06000106 RID: 262
		[Overload("SetPixelBytes")]
		[DefaultOverload]
		public extern void SetPixelBytes([In] byte[] valueElements);

		// Token: 0x06000107 RID: 263
		[DefaultOverload]
		[Overload("SetPixelBytesWithSubrectangle")]
		public extern void SetPixelBytes([In] byte[] valueElements, [In] int left, [In] int top, [In] int width, [In] int height);

		// Token: 0x06000108 RID: 264
		[Overload("SetPixelBytesWithBuffer")]
		public extern void SetPixelBytes([In] IBuffer buffer);

		// Token: 0x06000109 RID: 265
		[Overload("SetPixelBytesWithBufferAndSubrectangle")]
		public extern void SetPixelBytes([In] IBuffer buffer, [In] int left, [In] int top, [In] int width, [In] int height);

		// Token: 0x0600010A RID: 266
		[Overload("SetPixelColors")]
		public extern void SetPixelColors([In] Color[] valueElements);

		// Token: 0x0600010B RID: 267
		[Overload("SetPixelColorsWithSubrectangle")]
		public extern void SetPixelColors([In] Color[] valueElements, [In] int left, [In] int top, [In] int width, [In] int height);

		// Token: 0x0600010C RID: 268
		[Overload("CopyPixelsFromBitmap")]
		public extern void CopyPixelsFromBitmap([In] CanvasBitmap otherBitmap);

		// Token: 0x0600010D RID: 269
		[Overload("CopyPixelsFromBitmapWithDestPoint")]
		public extern void CopyPixelsFromBitmap([In] CanvasBitmap otherBitmap, [In] int destX, [In] int destY);

		// Token: 0x0600010E RID: 270
		[Overload("CopyPixelsFromBitmapWithDestPointAndSourceRect")]
		public extern void CopyPixelsFromBitmap([In] CanvasBitmap otherBitmap, [In] int destX, [In] int destY, [In] int sourceRectLeft, [In] int sourceRectTop, [In] int sourceRectWidth, [In] int sourceRectHeight);

		// Token: 0x0600010F RID: 271
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000110 RID: 272
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		// Token: 0x06000111 RID: 273
		public extern void Close();

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000112 RID: 274
		public extern Direct3DSurfaceDescription Description { get; }

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000113 RID: 275
		public extern float Dpi { get; }

		// Token: 0x06000114 RID: 276
		public extern float ConvertPixelsToDips([In] int pixels);

		// Token: 0x06000115 RID: 277
		public extern int ConvertDipsToPixels([In] float dips, [In] CanvasDpiRounding dpiRounding);

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000116 RID: 278
		public extern CanvasDevice Device { get; }

		// Token: 0x06000117 RID: 279
		[Overload("CreateFromDirect3D11Surface")]
		public static extern CanvasBitmap CreateFromDirect3D11Surface([In] ICanvasResourceCreator resourceCreator, [In] IDirect3DSurface surface);

		// Token: 0x06000118 RID: 280
		[Overload("CreateFromDirect3D11SurfaceWithDpi")]
		public static extern CanvasBitmap CreateFromDirect3D11Surface([In] ICanvasResourceCreator resourceCreator, [In] IDirect3DSurface surface, [In] float dpi);

		// Token: 0x06000119 RID: 281
		[Overload("CreateFromDirect3D11SurfaceWithDpiAndAlpha")]
		public static extern CanvasBitmap CreateFromDirect3D11Surface([In] ICanvasResourceCreator resourceCreator, [In] IDirect3DSurface surface, [In] float dpi, [In] CanvasAlphaMode alpha);

		// Token: 0x0600011A RID: 282
		[Overload("CreateFromBytes")]
		[DefaultOverload]
		public static extern CanvasBitmap CreateFromBytes([In] ICanvasResourceCreator resourceCreator, [In] byte[] bytes, [In] int widthInPixels, [In] int heightInPixels, [In] DirectXPixelFormat format);

		// Token: 0x0600011B RID: 283
		[DefaultOverload]
		[Overload("CreateFromBytesWithDpi")]
		public static extern CanvasBitmap CreateFromBytes([In] ICanvasResourceCreator resourceCreator, [In] byte[] bytes, [In] int widthInPixels, [In] int heightInPixels, [In] DirectXPixelFormat format, [In] float dpi);

		// Token: 0x0600011C RID: 284
		[DefaultOverload]
		[Overload("CreateFromBytesWithDpiAndAlpha")]
		public static extern CanvasBitmap CreateFromBytes([In] ICanvasResourceCreator resourceCreator, [In] byte[] bytes, [In] int widthInPixels, [In] int heightInPixels, [In] DirectXPixelFormat format, [In] float dpi, [In] CanvasAlphaMode alpha);

		// Token: 0x0600011D RID: 285
		[Overload("CreateFromBytesWithBuffer")]
		public static extern CanvasBitmap CreateFromBytes([In] ICanvasResourceCreator resourceCreator, [In] IBuffer buffer, [In] int widthInPixels, [In] int heightInPixels, [In] DirectXPixelFormat format);

		// Token: 0x0600011E RID: 286
		[Overload("CreateFromBytesWithBufferAndDpi")]
		public static extern CanvasBitmap CreateFromBytes([In] ICanvasResourceCreator resourceCreator, [In] IBuffer buffer, [In] int widthInPixels, [In] int heightInPixels, [In] DirectXPixelFormat format, [In] float dpi);

		// Token: 0x0600011F RID: 287
		[Overload("CreateFromBytesWithBufferAndDpiAndAlpha")]
		public static extern CanvasBitmap CreateFromBytes([In] ICanvasResourceCreator resourceCreator, [In] IBuffer buffer, [In] int widthInPixels, [In] int heightInPixels, [In] DirectXPixelFormat format, [In] float dpi, [In] CanvasAlphaMode alpha);

		// Token: 0x06000120 RID: 288
		[Overload("CreateFromColors")]
		public static extern CanvasBitmap CreateFromColors([In] ICanvasResourceCreator resourceCreator, [In] Color[] colors, [In] int widthInPixels, [In] int heightInPixels);

		// Token: 0x06000121 RID: 289
		[Overload("CreateFromColorsWithDpi")]
		public static extern CanvasBitmap CreateFromColors([In] ICanvasResourceCreator resourceCreator, [In] Color[] colors, [In] int widthInPixels, [In] int heightInPixels, [In] float dpi);

		// Token: 0x06000122 RID: 290
		[Overload("CreateFromColorsWithDpiAndAlpha")]
		public static extern CanvasBitmap CreateFromColors([In] ICanvasResourceCreator resourceCreator, [In] Color[] colors, [In] int widthInPixels, [In] int heightInPixels, [In] float dpi, [In] CanvasAlphaMode alpha);

		// Token: 0x06000123 RID: 291
		public static extern CanvasBitmap CreateFromSoftwareBitmap([In] ICanvasResourceCreator resourceCreator, [In] SoftwareBitmap sourceBitmap);

		// Token: 0x06000124 RID: 292
		[Overload("LoadAsyncFromHstring")]
		public static extern IAsyncOperation<CanvasBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] string fileName);

		// Token: 0x06000125 RID: 293
		[Overload("LoadAsyncFromHstringWithDpi")]
		public static extern IAsyncOperation<CanvasBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] string fileName, [In] float dpi);

		// Token: 0x06000126 RID: 294
		[Overload("LoadAsyncFromHstringWithDpiAndAlpha")]
		public static extern IAsyncOperation<CanvasBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] string fileName, [In] float dpi, [In] CanvasAlphaMode alpha);

		// Token: 0x06000127 RID: 295
		[DefaultOverload]
		[Overload("LoadAsyncFromUri")]
		public static extern IAsyncOperation<CanvasBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] Uri uri);

		// Token: 0x06000128 RID: 296
		[DefaultOverload]
		[Overload("LoadAsyncFromUriWithDpi")]
		public static extern IAsyncOperation<CanvasBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] Uri uri, [In] float dpi);

		// Token: 0x06000129 RID: 297
		[DefaultOverload]
		[Overload("LoadAsyncFromUriWithDpiAndAlpha")]
		public static extern IAsyncOperation<CanvasBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] Uri uri, [In] float dpi, [In] CanvasAlphaMode alpha);

		// Token: 0x0600012A RID: 298
		[Overload("LoadAsyncFromStream")]
		public static extern IAsyncOperation<CanvasBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] IRandomAccessStream stream);

		// Token: 0x0600012B RID: 299
		[Overload("LoadAsyncFromStreamWithDpi")]
		public static extern IAsyncOperation<CanvasBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] IRandomAccessStream stream, [In] float dpi);

		// Token: 0x0600012C RID: 300
		[Overload("LoadAsyncFromStreamWithDpiAndAlpha")]
		public static extern IAsyncOperation<CanvasBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] IRandomAccessStream stream, [In] float dpi, [In] CanvasAlphaMode alpha);
	}
}
