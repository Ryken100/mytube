using System;
using System.Runtime.InteropServices;
using Microsoft.Graphics.Canvas.Effects;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Microsoft.Graphics.Canvas
{
	// Token: 0x0200002F RID: 47
	[Static(typeof(ICanvasImageStatics), 167772160U)]
	[MarshalingBehavior(2)]
	[Threading(3)]
	[Version(167772160U)]
	public static class CanvasImage
	{
		// Token: 0x0600003F RID: 63
		[Overload("SaveAsync")]
		[DefaultOverload]
		public static extern IAsyncAction SaveAsync([In] ICanvasImage image, [In] Rect sourceRectangle, [In] float dpi, [In] ICanvasResourceCreator resourceCreator, [In] IRandomAccessStream stream, [In] CanvasBitmapFileFormat fileFormat);

		// Token: 0x06000040 RID: 64
		[Overload("SaveWithQualityAsync")]
		[DefaultOverload]
		public static extern IAsyncAction SaveAsync([In] ICanvasImage image, [In] Rect sourceRectangle, [In] float dpi, [In] ICanvasResourceCreator resourceCreator, [In] IRandomAccessStream stream, [In] CanvasBitmapFileFormat fileFormat, [In] float quality);

		// Token: 0x06000041 RID: 65
		[Overload("SaveWithQualityAndBufferPrecisionAsync")]
		[DefaultOverload]
		public static extern IAsyncAction SaveAsync([In] ICanvasImage image, [In] Rect sourceRectangle, [In] float dpi, [In] ICanvasResourceCreator resourceCreator, [In] IRandomAccessStream stream, [In] CanvasBitmapFileFormat fileFormat, [In] float quality, [In] CanvasBufferPrecision bufferPrecision);

		// Token: 0x06000042 RID: 66
		public static extern float[] ComputeHistogram([In] ICanvasImage image, [In] Rect sourceRectangle, [In] ICanvasResourceCreator resourceCreator, [In] EffectChannelSelect channelSelect, [In] int numberOfBins);

		// Token: 0x06000043 RID: 67
		public static extern bool IsHistogramSupported([In] CanvasDevice device);
	}
}
