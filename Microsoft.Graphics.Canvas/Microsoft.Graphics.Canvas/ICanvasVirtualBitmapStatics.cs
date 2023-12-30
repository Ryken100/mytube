using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Microsoft.Graphics.Canvas
{
	[ComImport]
	[Version(167772160u)]
	[Windows.Foundation.Metadata.Guid(3002202345u, 1904, 19924, 149, 109, 120, 217, 17, 57, 9, 87)]
	[ExclusiveTo(typeof(CanvasVirtualBitmap))]
	internal interface ICanvasVirtualBitmapStatics
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("LoadAsyncFromFileName")]
		IAsyncOperation<CanvasVirtualBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] string fileName);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("LoadAsyncFromFileNameWithOptions")]
		IAsyncOperation<CanvasVirtualBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] string fileName, [In] CanvasVirtualBitmapOptions options);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("LoadAsyncFromFileNameWithOptionsAndAlpha")]
		IAsyncOperation<CanvasVirtualBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] string fileName, [In] CanvasVirtualBitmapOptions options, [In] CanvasAlphaMode alpha);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("LoadAsyncFromUri")]
		IAsyncOperation<CanvasVirtualBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] Uri uri);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("LoadAsyncFromUriWithOptions")]
		IAsyncOperation<CanvasVirtualBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] Uri uri, [In] CanvasVirtualBitmapOptions options);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("LoadAsyncFromUriWithOptionsAndAlpha")]
		IAsyncOperation<CanvasVirtualBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] Uri uri, [In] CanvasVirtualBitmapOptions options, [In] CanvasAlphaMode alpha);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("LoadAsyncFromStream")]
		IAsyncOperation<CanvasVirtualBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] IRandomAccessStream stream);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("LoadAsyncFromStreamWithOptions")]
		[DefaultOverload]
		IAsyncOperation<CanvasVirtualBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] IRandomAccessStream stream, [In] CanvasVirtualBitmapOptions options);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("LoadAsyncFromStreamWithOptionsAndAlpha")]
		[DefaultOverload]
		IAsyncOperation<CanvasVirtualBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] IRandomAccessStream stream, [In] CanvasVirtualBitmapOptions options, [In] CanvasAlphaMode alpha);
	}
}
