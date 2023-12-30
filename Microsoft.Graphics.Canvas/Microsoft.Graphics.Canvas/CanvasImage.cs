using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Graphics.Canvas.Effects;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Microsoft.Graphics.Canvas
{
	[ComImport]
	[Static(typeof(ICanvasImageStatics), 167772160u)]
	[MarshalingBehavior(MarshalingType.Agile)]
	[Threading(ThreadingModel.Both)]
	[Version(167772160u)]
	public static class CanvasImage
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("SaveAsync")]
		[DefaultOverload]
		public static extern IAsyncAction SaveAsync([In] ICanvasImage image, [In] Rect sourceRectangle, [In] float dpi, [In] ICanvasResourceCreator resourceCreator, [In] IRandomAccessStream stream, [In] CanvasBitmapFileFormat fileFormat);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("SaveWithQualityAsync")]
		[DefaultOverload]
		public static extern IAsyncAction SaveAsync([In] ICanvasImage image, [In] Rect sourceRectangle, [In] float dpi, [In] ICanvasResourceCreator resourceCreator, [In] IRandomAccessStream stream, [In] CanvasBitmapFileFormat fileFormat, [In] float quality);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("SaveWithQualityAndBufferPrecisionAsync")]
		[DefaultOverload]
		public static extern IAsyncAction SaveAsync([In] ICanvasImage image, [In] Rect sourceRectangle, [In] float dpi, [In] ICanvasResourceCreator resourceCreator, [In] IRandomAccessStream stream, [In] CanvasBitmapFileFormat fileFormat, [In] float quality, [In] CanvasBufferPrecision bufferPrecision);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public static extern float[] ComputeHistogram([In] ICanvasImage image, [In] Rect sourceRectangle, [In] ICanvasResourceCreator resourceCreator, [In] EffectChannelSelect channelSelect, [In] int numberOfBins);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public static extern bool IsHistogramSupported([In] CanvasDevice device);
	}
}
