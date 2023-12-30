using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Microsoft.Graphics.Canvas.Brushes
{
	// Token: 0x02000040 RID: 64
	[ExclusiveTo(typeof(CanvasRadialGradientBrush))]
	[Guid(990727598U, 15905, 18456, 153, 180, 119, 154, 202, 175, 24, 190)]
	[Version(167772160U)]
	internal interface ICanvasRadialGradientBrushStatics
	{
		// Token: 0x060000C9 RID: 201
		[Overload("CreateHdrSimple")]
		CanvasRadialGradientBrush CreateHdr([In] ICanvasResourceCreator resourceCreator, [In] Vector4 startColorHdr, [In] Vector4 endColorHdr);

		// Token: 0x060000CA RID: 202
		[Overload("CreateHdrWithStops")]
		CanvasRadialGradientBrush CreateHdr([In] ICanvasResourceCreator resourceCreator, [In] CanvasGradientStopHdr[] gradientStops);

		// Token: 0x060000CB RID: 203
		[Overload("CreateHdrWithEdgeBehaviorAndAlphaMode")]
		CanvasRadialGradientBrush CreateHdr([In] ICanvasResourceCreator resourceCreator, [In] CanvasGradientStopHdr[] gradientStops, [In] CanvasEdgeBehavior edgeBehavior, [In] CanvasAlphaMode alphaMode);

		// Token: 0x060000CC RID: 204
		[Overload("CreateHdrWithEdgeBehaviorAndInterpolationOptions")]
		CanvasRadialGradientBrush CreateHdr([In] ICanvasResourceCreator resourceCreator, [In] CanvasGradientStopHdr[] gradientStops, [In] CanvasEdgeBehavior edgeBehavior, [In] CanvasAlphaMode alphaMode, [In] CanvasColorSpace preInterpolationSpace, [In] CanvasColorSpace postInterpolationSpace, [In] CanvasBufferPrecision bufferPrecision);

		// Token: 0x060000CD RID: 205
		CanvasRadialGradientBrush CreateRainbow([In] ICanvasResourceCreator resourceCreator, [In] float eldritchness);
	}
}
