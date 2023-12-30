using System;
using System.Runtime.CompilerServices;
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
	[ComImport]
	[ExclusiveTo(typeof(CanvasBitmap))]
	[Version(167772160u)]
	[Windows.Foundation.Metadata.Guid(3312792301u, 28830, 19138, 134, 190, 161, 236, 58, 127, 168, 254)]
	internal interface ICanvasBitmap : ICanvasImage, IGraphicsEffectSource, IDisposable, IDirect3DSurface, ICanvasResourceCreatorWithDpi, ICanvasResourceCreator
	{
		BitmapSize SizeInPixels
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		Size Size
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		Rect Bounds
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		DirectXPixelFormat Format
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		CanvasAlphaMode AlphaMode
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("SaveToFileAsync")]
		IAsyncAction SaveAsync([In] string fileName);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("SaveToFileWithBitmapFileFormatAsync")]
		[DefaultOverload]
		IAsyncAction SaveAsync([In] string fileName, [In] CanvasBitmapFileFormat fileFormat);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("SaveToFileWithBitmapFileFormatAndQualityAsync")]
		[DefaultOverload]
		IAsyncAction SaveAsync([In] string fileName, [In] CanvasBitmapFileFormat fileFormat, [In] float quality);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("SaveToStreamAsync")]
		IAsyncAction SaveAsync([In] IRandomAccessStream stream, [In] CanvasBitmapFileFormat fileFormat);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("SaveToStreamWithQualityAsync")]
		IAsyncAction SaveAsync([In] IRandomAccessStream stream, [In] CanvasBitmapFileFormat fileFormat, [In] float quality);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetPixelBytes")]
		byte[] GetPixelBytes();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetPixelBytesWithSubrectangle")]
		byte[] GetPixelBytes([In] int left, [In] int top, [In] int width, [In] int height);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetPixelBytesWithBuffer")]
		void GetPixelBytes([In] IBuffer buffer);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetPixelBytesWithBufferAndSubrectangle")]
		void GetPixelBytes([In] IBuffer buffer, [In] int left, [In] int top, [In] int width, [In] int height);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetPixelColors")]
		Color[] GetPixelColors();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetPixelColorsWithSubrectangle")]
		Color[] GetPixelColors([In] int left, [In] int top, [In] int width, [In] int height);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("SetPixelBytes")]
		void SetPixelBytes([In] byte[] valueElements);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("SetPixelBytesWithSubrectangle")]
		[DefaultOverload]
		void SetPixelBytes([In] byte[] valueElements, [In] int left, [In] int top, [In] int width, [In] int height);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("SetPixelBytesWithBuffer")]
		void SetPixelBytes([In] IBuffer buffer);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("SetPixelBytesWithBufferAndSubrectangle")]
		void SetPixelBytes([In] IBuffer buffer, [In] int left, [In] int top, [In] int width, [In] int height);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("SetPixelColors")]
		void SetPixelColors([In] Color[] valueElements);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("SetPixelColorsWithSubrectangle")]
		void SetPixelColors([In] Color[] valueElements, [In] int left, [In] int top, [In] int width, [In] int height);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CopyPixelsFromBitmap")]
		void CopyPixelsFromBitmap([In] CanvasBitmap otherBitmap);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CopyPixelsFromBitmapWithDestPoint")]
		void CopyPixelsFromBitmap([In] CanvasBitmap otherBitmap, [In] int destX, [In] int destY);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CopyPixelsFromBitmapWithDestPointAndSourceRect")]
		void CopyPixelsFromBitmap([In] CanvasBitmap otherBitmap, [In] int destX, [In] int destY, [In] int sourceRectLeft, [In] int sourceRectTop, [In] int sourceRectWidth, [In] int sourceRectHeight);
	}
}
