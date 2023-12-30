using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Graphics.Canvas.Effects;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Microsoft.Graphics.Canvas
{
	[ComImport]
	[ExclusiveTo(typeof(CanvasImage))]
	[Version(167772160u)]
	[Windows.Foundation.Metadata.Guid(3310283285u, 23060, 18586, 143, 160, 110, 132, 84, 31, 146, 45)]
	internal interface ICanvasImageStatics
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("SaveAsync")]
		IAsyncAction SaveAsync([In] ICanvasImage image, [In] Rect sourceRectangle, [In] float dpi, [In] ICanvasResourceCreator resourceCreator, [In] IRandomAccessStream stream, [In] CanvasBitmapFileFormat fileFormat);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("SaveWithQualityAsync")]
		IAsyncAction SaveAsync([In] ICanvasImage image, [In] Rect sourceRectangle, [In] float dpi, [In] ICanvasResourceCreator resourceCreator, [In] IRandomAccessStream stream, [In] CanvasBitmapFileFormat fileFormat, [In] float quality);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("SaveWithQualityAndBufferPrecisionAsync")]
		IAsyncAction SaveAsync([In] ICanvasImage image, [In] Rect sourceRectangle, [In] float dpi, [In] ICanvasResourceCreator resourceCreator, [In] IRandomAccessStream stream, [In] CanvasBitmapFileFormat fileFormat, [In] float quality, [In] CanvasBufferPrecision bufferPrecision);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		float[] ComputeHistogram([In] ICanvasImage image, [In] Rect sourceRectangle, [In] ICanvasResourceCreator resourceCreator, [In] EffectChannelSelect channelSelect, [In] int numberOfBins);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool IsHistogramSupported([In] CanvasDevice device);
	}
}
