using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Microsoft.Graphics.Canvas.Brushes
{
	// Token: 0x0200003C RID: 60
	[Version(167772160U)]
	[Guid(3923653522U, 36799, 18316, 142, 106, 208, 160, 234, 117, 59, 55)]
	[ExclusiveTo(typeof(CanvasLinearGradientBrush))]
	internal interface ICanvasLinearGradientBrushStatics
	{
		// Token: 0x06000097 RID: 151
		[Overload("CreateHdrSimple")]
		CanvasLinearGradientBrush CreateHdr([In] ICanvasResourceCreator resourceCreator, [In] Vector4 startColorHdr, [In] Vector4 endColorHdr);

		// Token: 0x06000098 RID: 152
		[Overload("CreateHdrWithStops")]
		CanvasLinearGradientBrush CreateHdr([In] ICanvasResourceCreator resourceCreator, [In] CanvasGradientStopHdr[] gradientStopsHdr);

		// Token: 0x06000099 RID: 153
		[Overload("CreateHdrWithEdgeBehaviorAndAlphaMode")]
		CanvasLinearGradientBrush CreateHdr([In] ICanvasResourceCreator resourceCreator, [In] CanvasGradientStopHdr[] gradientStopsHdr, [In] CanvasEdgeBehavior edgeBehavior, [In] CanvasAlphaMode alphaMode);

		// Token: 0x0600009A RID: 154
		[Overload("CreateHdrWithEdgeBehaviorAndInterpolationOptions")]
		CanvasLinearGradientBrush CreateHdr([In] ICanvasResourceCreator resourceCreator, [In] CanvasGradientStopHdr[] gradientStopsHdr, [In] CanvasEdgeBehavior edgeBehavior, [In] CanvasAlphaMode alphaMode, [In] CanvasColorSpace preInterpolationSpace, [In] CanvasColorSpace postInterpolationSpace, [In] CanvasBufferPrecision bufferPrecision);

		// Token: 0x0600009B RID: 155
		CanvasLinearGradientBrush CreateRainbow([In] ICanvasResourceCreator resourceCreator, [In] float eldritchness);
	}
}
