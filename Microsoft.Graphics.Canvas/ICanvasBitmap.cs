using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX;
using Windows.Graphics.DirectX.Direct3D11;
using Windows.Graphics.Effects;
using Windows.Graphics.Imaging;
using Windows.Storage.Streams;
using Windows.UI;

namespace Microsoft.Graphics.Canvas
{
	// Token: 0x02000043 RID: 67
	[ExclusiveTo(typeof(CanvasBitmap))]
	[Version(167772160U)]
	[Guid(3312792301U, 28830, 19138, 134, 190, 161, 236, 58, 127, 168, 254)]
	internal interface ICanvasBitmap : ICanvasImage, IGraphicsEffectSource, IClosable, IDirect3DSurface, ICanvasResourceCreatorWithDpi, ICanvasResourceCreator
	{
		// Token: 0x170003DE RID: 990
		// (get) Token: 0x060000DD RID: 221
		BitmapSize SizeInPixels { get; }

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x060000DE RID: 222
		Size Size { get; }

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x060000DF RID: 223
		Rect Bounds { get; }

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x060000E0 RID: 224
		DirectXPixelFormat Format { get; }

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x060000E1 RID: 225
		CanvasAlphaMode AlphaMode { get; }

		// Token: 0x060000E2 RID: 226
		[Overload("SaveToFileAsync")]
		IAsyncAction SaveAsync([In] string fileName);

		// Token: 0x060000E3 RID: 227
		[Overload("SaveToFileWithBitmapFileFormatAsync")]
		[DefaultOverload]
		IAsyncAction SaveAsync([In] string fileName, [In] CanvasBitmapFileFormat fileFormat);

		// Token: 0x060000E4 RID: 228
		[Overload("SaveToFileWithBitmapFileFormatAndQualityAsync")]
		[DefaultOverload]
		IAsyncAction SaveAsync([In] string fileName, [In] CanvasBitmapFileFormat fileFormat, [In] float quality);

		// Token: 0x060000E5 RID: 229
		[Overload("SaveToStreamAsync")]
		IAsyncAction SaveAsync([In] IRandomAccessStream stream, [In] CanvasBitmapFileFormat fileFormat);

		// Token: 0x060000E6 RID: 230
		[Overload("SaveToStreamWithQualityAsync")]
		IAsyncAction SaveAsync([In] IRandomAccessStream stream, [In] CanvasBitmapFileFormat fileFormat, [In] float quality);

		// Token: 0x060000E7 RID: 231
		[Overload("GetPixelBytes")]
		byte[] GetPixelBytes();

		// Token: 0x060000E8 RID: 232
		[Overload("GetPixelBytesWithSubrectangle")]
		byte[] GetPixelBytes([In] int left, [In] int top, [In] int width, [In] int height);

		// Token: 0x060000E9 RID: 233
		[Overload("GetPixelBytesWithBuffer")]
		void GetPixelBytes([In] IBuffer buffer);

		// Token: 0x060000EA RID: 234
		[Overload("GetPixelBytesWithBufferAndSubrectangle")]
		void GetPixelBytes([In] IBuffer buffer, [In] int left, [In] int top, [In] int width, [In] int height);

		// Token: 0x060000EB RID: 235
		[Overload("GetPixelColors")]
		Color[] GetPixelColors();

		// Token: 0x060000EC RID: 236
		[Overload("GetPixelColorsWithSubrectangle")]
		Color[] GetPixelColors([In] int left, [In] int top, [In] int width, [In] int height);

		// Token: 0x060000ED RID: 237
		[DefaultOverload]
		[Overload("SetPixelBytes")]
		void SetPixelBytes([In] byte[] valueElements);

		// Token: 0x060000EE RID: 238
		[Overload("SetPixelBytesWithSubrectangle")]
		[DefaultOverload]
		void SetPixelBytes([In] byte[] valueElements, [In] int left, [In] int top, [In] int width, [In] int height);

		// Token: 0x060000EF RID: 239
		[Overload("SetPixelBytesWithBuffer")]
		void SetPixelBytes([In] IBuffer buffer);

		// Token: 0x060000F0 RID: 240
		[Overload("SetPixelBytesWithBufferAndSubrectangle")]
		void SetPixelBytes([In] IBuffer buffer, [In] int left, [In] int top, [In] int width, [In] int height);

		// Token: 0x060000F1 RID: 241
		[Overload("SetPixelColors")]
		void SetPixelColors([In] Color[] valueElements);

		// Token: 0x060000F2 RID: 242
		[Overload("SetPixelColorsWithSubrectangle")]
		void SetPixelColors([In] Color[] valueElements, [In] int left, [In] int top, [In] int width, [In] int height);

		// Token: 0x060000F3 RID: 243
		[Overload("CopyPixelsFromBitmap")]
		void CopyPixelsFromBitmap([In] CanvasBitmap otherBitmap);

		// Token: 0x060000F4 RID: 244
		[Overload("CopyPixelsFromBitmapWithDestPoint")]
		void CopyPixelsFromBitmap([In] CanvasBitmap otherBitmap, [In] int destX, [In] int destY);

		// Token: 0x060000F5 RID: 245
		[Overload("CopyPixelsFromBitmapWithDestPointAndSourceRect")]
		void CopyPixelsFromBitmap([In] CanvasBitmap otherBitmap, [In] int destX, [In] int destY, [In] int sourceRectLeft, [In] int sourceRectTop, [In] int sourceRectWidth, [In] int sourceRectHeight);
	}
}
