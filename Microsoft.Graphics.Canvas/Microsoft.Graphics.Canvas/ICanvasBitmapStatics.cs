using System;
using System.Runtime.CompilerServices;
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
	[ComImport]
	[ExclusiveTo(typeof(CanvasBitmap))]
	[Windows.Foundation.Metadata.Guid(3365178858u, 42013, 19650, 175, 154, 253, 222, 1, 182, 6, 220)]
	[Version(167772160u)]
	internal interface ICanvasBitmapStatics
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateFromDirect3D11Surface")]
		CanvasBitmap CreateFromDirect3D11Surface([In] ICanvasResourceCreator resourceCreator, [In] IDirect3DSurface surface);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateFromDirect3D11SurfaceWithDpi")]
		CanvasBitmap CreateFromDirect3D11Surface([In] ICanvasResourceCreator resourceCreator, [In] IDirect3DSurface surface, [In] float dpi);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateFromDirect3D11SurfaceWithDpiAndAlpha")]
		CanvasBitmap CreateFromDirect3D11Surface([In] ICanvasResourceCreator resourceCreator, [In] IDirect3DSurface surface, [In] float dpi, [In] CanvasAlphaMode alpha);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateFromBytes")]
		[DefaultOverload]
		CanvasBitmap CreateFromBytes([In] ICanvasResourceCreator resourceCreator, [In] byte[] bytes, [In] int widthInPixels, [In] int heightInPixels, [In] DirectXPixelFormat format);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("CreateFromBytesWithDpi")]
		CanvasBitmap CreateFromBytes([In] ICanvasResourceCreator resourceCreator, [In] byte[] bytes, [In] int widthInPixels, [In] int heightInPixels, [In] DirectXPixelFormat format, [In] float dpi);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateFromBytesWithDpiAndAlpha")]
		[DefaultOverload]
		CanvasBitmap CreateFromBytes([In] ICanvasResourceCreator resourceCreator, [In] byte[] bytes, [In] int widthInPixels, [In] int heightInPixels, [In] DirectXPixelFormat format, [In] float dpi, [In] CanvasAlphaMode alpha);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateFromBytesWithBuffer")]
		CanvasBitmap CreateFromBytes([In] ICanvasResourceCreator resourceCreator, [In] IBuffer buffer, [In] int widthInPixels, [In] int heightInPixels, [In] DirectXPixelFormat format);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateFromBytesWithBufferAndDpi")]
		CanvasBitmap CreateFromBytes([In] ICanvasResourceCreator resourceCreator, [In] IBuffer buffer, [In] int widthInPixels, [In] int heightInPixels, [In] DirectXPixelFormat format, [In] float dpi);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateFromBytesWithBufferAndDpiAndAlpha")]
		CanvasBitmap CreateFromBytes([In] ICanvasResourceCreator resourceCreator, [In] IBuffer buffer, [In] int widthInPixels, [In] int heightInPixels, [In] DirectXPixelFormat format, [In] float dpi, [In] CanvasAlphaMode alpha);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateFromColors")]
		CanvasBitmap CreateFromColors([In] ICanvasResourceCreator resourceCreator, [In] Color[] colors, [In] int widthInPixels, [In] int heightInPixels);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateFromColorsWithDpi")]
		CanvasBitmap CreateFromColors([In] ICanvasResourceCreator resourceCreator, [In] Color[] colors, [In] int widthInPixels, [In] int heightInPixels, [In] float dpi);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateFromColorsWithDpiAndAlpha")]
		CanvasBitmap CreateFromColors([In] ICanvasResourceCreator resourceCreator, [In] Color[] colors, [In] int widthInPixels, [In] int heightInPixels, [In] float dpi, [In] CanvasAlphaMode alpha);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasBitmap CreateFromSoftwareBitmap([In] ICanvasResourceCreator resourceCreator, [In] SoftwareBitmap sourceBitmap);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("LoadAsyncFromHstring")]
		IAsyncOperation<CanvasBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] string fileName);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("LoadAsyncFromHstringWithDpi")]
		IAsyncOperation<CanvasBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] string fileName, [In] float dpi);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("LoadAsyncFromHstringWithDpiAndAlpha")]
		IAsyncOperation<CanvasBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] string fileName, [In] float dpi, [In] CanvasAlphaMode alpha);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("LoadAsyncFromUri")]
		IAsyncOperation<CanvasBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] Uri uri);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("LoadAsyncFromUriWithDpi")]
		IAsyncOperation<CanvasBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] Uri uri, [In] float dpi);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("LoadAsyncFromUriWithDpiAndAlpha")]
		IAsyncOperation<CanvasBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] Uri uri, [In] float dpi, [In] CanvasAlphaMode alpha);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("LoadAsyncFromStream")]
		IAsyncOperation<CanvasBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] IRandomAccessStream stream);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("LoadAsyncFromStreamWithDpi")]
		IAsyncOperation<CanvasBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] IRandomAccessStream stream, [In] float dpi);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("LoadAsyncFromStreamWithDpiAndAlpha")]
		IAsyncOperation<CanvasBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] IRandomAccessStream stream, [In] float dpi, [In] CanvasAlphaMode alpha);
	}
}
