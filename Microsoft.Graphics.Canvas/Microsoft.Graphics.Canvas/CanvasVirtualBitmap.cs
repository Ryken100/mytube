using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;
using Windows.Graphics.Imaging;
using Windows.Storage.Streams;

namespace Microsoft.Graphics.Canvas
{
	[ComImport]
	[Version(167772160u)]
	[Threading(ThreadingModel.Both)]
	[MarshalingBehavior(MarshalingType.Agile)]
	[Static(typeof(ICanvasVirtualBitmapStatics), 167772160u)]
	public sealed class CanvasVirtualBitmap : ICanvasVirtualBitmap, ICanvasImage, IDisposable, IGraphicsEffectSource
	{
		public extern Rect Bounds
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern CanvasDevice Device
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern bool IsCachedOnDemand
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

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void Dispose();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetBounds")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetBoundsWithTransform")]
		public extern Rect GetBounds([In] ICanvasResourceCreator resourceCreator, [In] Matrix3x2 transform);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("LoadAsyncFromFileName")]
		public static extern IAsyncOperation<CanvasVirtualBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] string fileName);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("LoadAsyncFromFileNameWithOptions")]
		public static extern IAsyncOperation<CanvasVirtualBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] string fileName, [In] CanvasVirtualBitmapOptions options);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("LoadAsyncFromFileNameWithOptionsAndAlpha")]
		public static extern IAsyncOperation<CanvasVirtualBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] string fileName, [In] CanvasVirtualBitmapOptions options, [In] CanvasAlphaMode alpha);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("LoadAsyncFromUri")]
		public static extern IAsyncOperation<CanvasVirtualBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] Uri uri);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("LoadAsyncFromUriWithOptions")]
		public static extern IAsyncOperation<CanvasVirtualBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] Uri uri, [In] CanvasVirtualBitmapOptions options);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("LoadAsyncFromUriWithOptionsAndAlpha")]
		public static extern IAsyncOperation<CanvasVirtualBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] Uri uri, [In] CanvasVirtualBitmapOptions options, [In] CanvasAlphaMode alpha);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("LoadAsyncFromStream")]
		public static extern IAsyncOperation<CanvasVirtualBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] IRandomAccessStream stream);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("LoadAsyncFromStreamWithOptions")]
		[DefaultOverload]
		public static extern IAsyncOperation<CanvasVirtualBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] IRandomAccessStream stream, [In] CanvasVirtualBitmapOptions options);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("LoadAsyncFromStreamWithOptionsAndAlpha")]
		[DefaultOverload]
		public static extern IAsyncOperation<CanvasVirtualBitmap> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] IRandomAccessStream stream, [In] CanvasVirtualBitmapOptions options, [In] CanvasAlphaMode alpha);
	}
}
