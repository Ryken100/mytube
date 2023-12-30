using System;
using System.Runtime.InteropServices;
using Microsoft.Graphics.Canvas.Effects;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Microsoft.Graphics.Canvas
{
	// Token: 0x0200002E RID: 46
	[ExclusiveTo(typeof(CanvasImage))]
	[Version(167772160U)]
	[Guid(3310283285U, 23060, 18586, 143, 160, 110, 132, 84, 31, 146, 45)]
	internal interface ICanvasImageStatics
	{
		// Token: 0x0600003A RID: 58
		[DefaultOverload]
		[Overload("SaveAsync")]
		IAsyncAction SaveAsync([In] ICanvasImage image, [In] Rect sourceRectangle, [In] float dpi, [In] ICanvasResourceCreator resourceCreator, [In] IRandomAccessStream stream, [In] CanvasBitmapFileFormat fileFormat);

		// Token: 0x0600003B RID: 59
		[DefaultOverload]
		[Overload("SaveWithQualityAsync")]
		IAsyncAction SaveAsync([In] ICanvasImage image, [In] Rect sourceRectangle, [In] float dpi, [In] ICanvasResourceCreator resourceCreator, [In] IRandomAccessStream stream, [In] CanvasBitmapFileFormat fileFormat, [In] float quality);

		// Token: 0x0600003C RID: 60
		[DefaultOverload]
		[Overload("SaveWithQualityAndBufferPrecisionAsync")]
		IAsyncAction SaveAsync([In] ICanvasImage image, [In] Rect sourceRectangle, [In] float dpi, [In] ICanvasResourceCreator resourceCreator, [In] IRandomAccessStream stream, [In] CanvasBitmapFileFormat fileFormat, [In] float quality, [In] CanvasBufferPrecision bufferPrecision);

		// Token: 0x0600003D RID: 61
		float[] ComputeHistogram([In] ICanvasImage image, [In] Rect sourceRectangle, [In] ICanvasResourceCreator resourceCreator, [In] EffectChannelSelect channelSelect, [In] int numberOfBins);

		// Token: 0x0600003E RID: 62
		bool IsHistogramSupported([In] CanvasDevice device);
	}
}
