using System;
using System.Numerics;
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
using Windows.UI.Xaml;

namespace Microsoft.Graphics.Canvas
{
	[ComImport]
	[Threading(ThreadingModel.Both)]
	[Static(typeof(ICanvasBitmapStatics), 167772160u)]
	[Composable(typeof(ICanvasBitmapFactory), CompositionType.Public, 167772160u)]
	[MarshalingBehavior(MarshalingType.Agile)]
	[Version(167772160u)]
	public class CanvasBitmap : DependencyObject, ICanvasBitmap, ICanvasResourceCreatorWithDpi, ICanvasResourceCreator, IDirect3DSurface, IDisposable, ICanvasImage, IGraphicsEffectSource
	{
		public extern CanvasAlphaMode AlphaMode
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern Rect Bounds
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern DirectXPixelFormat Format
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern Size Size
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern BitmapSize SizeInPixels
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern CanvasDevice Device
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern float Dpi
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern Direct3DSurfaceDescription Description
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("SaveToFileAsync")]
		public extern IAsyncAction SaveAsync([In] string fileName);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("SaveToFileWithBitmapFileFormatAsync")]
		[DefaultOverload]
		public extern IAsyncAction SaveAsync([In] string fileName, [In] CanvasBitmapFileFormat fileFormat);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("SaveToFileWithBitmapFileFormatAndQualityAsync")]
		public extern IAsyncAction SaveAsync([In] string fileName, [In] CanvasBitmapFileFormat fileFormat, [In] float quality);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("SaveToStreamAsync")]
		public extern IAsyncAction SaveAsync([In] IRandomAccessStream stream, [In] CanvasBitmapFileFormat fileFormat);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("SaveToStreamWithQualityAsync")]
		public extern IAsyncAction SaveAsync([In] IRandomAccessStream stream, [In] CanvasBitmapFileFormat fileFormat, [In] float quality);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetPixelBytes")]
		public extern byte[] GetPixelBytes();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetPixelBytesWithSubrectangle")]
		public extern byte[] GetPixelBytes([In] int left, [In] int top, [In] int width, [In] int height);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetPixelBytesWithBuffer")]
		public extern void GetPixelBytes([In] IBuffer buffer);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetPixelBytesWithBufferAndSubrectangle")]
		public extern void GetPixelBytes([In] IBuffer buffer, [In] int left, [In] int top, [In] int width, [In] int height);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetPixelColors")]
		public extern Color[] GetPixelColors();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetPixelColorsWithSubrectangle")]
		public extern Color[] GetPixelColors([In] int left, [In] int top, [In] int width, [In] int height);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("SetPixelBytes")]
		[DefaultOverload]
		public extern void SetPixelBytes([In] byte[] valueElements);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("SetPixelBytesWithSubrectangle")]
		public extern void SetPixelBytes([In] byte[] valueElements, [In] int left, [In] int top, [In] int width, [In] int height);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("SetPixelBytesWithBuffer")]
		public extern void SetPixelBytes([In] IBuffer buffer);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("SetPixelBytesWithBufferAndSubrectangle")]
		public extern void SetPixelBytes([In] IBuffer buffer, [In] int left, [In] int top, [In] int width, [In] int height);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("SetPixelColors")]
		public extern void SetPixelColors([In] Color[] valueElements);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("SetPixelColorsWithSubrectangle")]
		public extern void SetPixelColors([In] Color[] valueElements, [In] int left, [In] int top, [In] int width, [In] int height);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CopyPixelsFromBitmap")]
		public extern void CopyPixelsFromBitmap([In] CanvasBitmap otherBitmap);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CopyPixelsFromBitmapWithDestPoint")]
		public extern void CopyPixelsFromBitmap([In] CanvasBitmap otherBitmap, [In] int destX, [In] int destY);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CopyPixelsFromBitmapWithDestPointAndSourceRect")]
		public extern void CopyPixelsFromBitmap([In] CanvasBitmap otherBitmap, [In] int destX, [In] int destY, [In] int sourceRectLeft, [In] int sourceRectTop, [In] int sourceRectWidth, [In] int sourceRectHeight);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void Dispose();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern float ConvertPixelsToDips([In] int pixels);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern int ConvertDipsToPixels([In] float dips, [In] CanvasDpiRounding dpiRounding);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateFromDirect3D11Surface")]
		public static extern CanvasBitmap CreateFromDirect3D11Surface([In] ICanvasResourceCreator resourceCreator, [In] IDirect3DSurface surface);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateFromDirect3D11SurfaceWithDpi")]
		public static extern CanvasBitmap CreateFromDirect3D11Surface([In] ICanvasResourceCreator resourceCreator, [In] IDirect3DSurface surface, [In] float dpi);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateFromDirect3D11SurfaceWithDpiAndAlpha")]
		public static extern CanvasBitmap CreateFromDirect3D11Surface([In] ICanvasResourceCreator resourceCreator, [In] IDirect3DSurface surface, [In] float dpi, [In] CanvasAlphaMode alpha);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateFromBytes")]
		[DefaultOverload]
		public static extern CanvasBitmap CreateFromBytes([In] ICanvasResourceCreator resourceCreator, [In] byte[] bytes, [In] int widthInPixels, [In] int heightInPixels, [In] DirectXPixelFormat format);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("CreateFromBytesWithDpi")]
		public static extern CanvasBitmap CreateFromBytes([In] ICanvasResourceCreator resourceCreator, [In] byte[] bytes, [In] int widthInPixels, [In] int heightInPixels, [In] DirectXPixelFormat format, [In] float dpi);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("CreateFromBytesWithDpiAndAlpha")]
		public static extern CanvasBitmap CreateFromBytes([In] ICanvasResourceCreator resourceCreator, [In] byte[] bytes, [In] int widthInPixels, [In] int heightInPixels, [In] DirectXPixelFormat format, [In] float dpi, [In] CanvasAlphaMode alpha);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateFromBytesWithBuffer")]
		public static extern CanvasBitmap CreateFromBytes([In] ICanvasResourceCreator resourceCreator, [In] IBuffer buffer, [In] int widthInPixels, [In] int heightInPixels, [In] DirectXPixelFormat format);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateFromBytesWithBufferAndDpi")]
		public static extern CanvasBitmap CreateFromBytes([In] ICanvasResourceCreator resourceCreator, [In] IBuffer buffer, [In] int widthInPixels, [In] int heightInPixels, [In] DirectXPixelFormat format, [In] float dpi);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateFromBytesWithBufferAndDpiAndAlpha")]
		public static extern CanvasBitmap CreateFromBytes([In] ICanvasResourceCreator resourceCreator, [In] IBuffer buffer, [In] int widthInPixels, [In] int heightInPixels, [In] DirectXPixelFormat format, [In] float dpi, [In] CanvasAlphaMode alpha);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateFromColors")]
		public static extern CanvasBitmap CreateFromColors([In] ICanvasResourceCreator resourceCreator, [In] Color[] colors, [In] int widthInPixels, [In] int heightInPixels);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateFromColorsWithDpi")]
		public static extern CanvasBitmap CreateFromColors([In] ICanvasResourceCreator resourceCreator, [In] Color[] colors, [In] int widthInPixels, [In] int heightInPixels, [In] float dpi);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateFromColorsWithDpiAndAlpha")]
		public static extern CanvasBitmap CreateFromColors([In] ICanvasResourceCreator resourceCreator, [In] Color[] colors, [In] int widthInPixels, [In] int heightInPixels, [In] float dpi, [In] CanvasAlphaMode alpha);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public static extern CanvasBitmap CreateFromSoftwareBitmap([In] ICanvasResourceCreator resourceCreator, [In] SoftwareBitmap sourceBitmap);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("LoadAsyncFromHstring")]
		public static extern IAsyncOperation<CanvasBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] string fileName);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("LoadAsyncFromHstringWithDpi")]
		public static extern IAsyncOperation<CanvasBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] string fileName, [In] float dpi);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("LoadAsyncFromHstringWithDpiAndAlpha")]
		public static extern IAsyncOperation<CanvasBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] string fileName, [In] float dpi, [In] CanvasAlphaMode alpha);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("LoadAsyncFromUri")]
		public static extern IAsyncOperation<CanvasBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] Uri uri);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("LoadAsyncFromUriWithDpi")]
		public static extern IAsyncOperation<CanvasBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] Uri uri, [In] float dpi);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("LoadAsyncFromUriWithDpiAndAlpha")]
		public static extern IAsyncOperation<CanvasBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] Uri uri, [In] float dpi, [In] CanvasAlphaMode alpha);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("LoadAsyncFromStream")]
		public static extern IAsyncOperation<CanvasBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] IRandomAccessStream stream);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("LoadAsyncFromStreamWithDpi")]
		public static extern IAsyncOperation<CanvasBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] IRandomAccessStream stream, [In] float dpi);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("LoadAsyncFromStreamWithDpiAndAlpha")]
		public static extern IAsyncOperation<CanvasBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] IRandomAccessStream stream, [In] float dpi, [In] CanvasAlphaMode alpha);
	}
}
