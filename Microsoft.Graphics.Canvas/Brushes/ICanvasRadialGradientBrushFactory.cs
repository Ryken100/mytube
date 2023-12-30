using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Microsoft.Graphics.Canvas.Brushes
{
	// Token: 0x0200003E RID: 62
	[Guid(2033427743U, 43280, 17736, 132, 159, 66, 221, 236, 70, 111, 65)]
	[Version(167772160U)]
	[ExclusiveTo(typeof(CanvasRadialGradientBrush))]
	internal interface ICanvasRadialGradientBrushFactory
	{
		// Token: 0x060000A7 RID: 167
		CanvasRadialGradientBrush CreateSimple([In] ICanvasResourceCreator resourceCreator, [In] Color startColor, [In] Color endColor);

		// Token: 0x060000A8 RID: 168
		CanvasRadialGradientBrush CreateWithStops([In] ICanvasResourceCreator resourceCreator, [In] CanvasGradientStop[] gradientStops);

		// Token: 0x060000A9 RID: 169
		CanvasRadialGradientBrush CreateWithEdgeBehaviorAndAlphaMode([In] ICanvasResourceCreator resourceCreator, [In] CanvasGradientStop[] gradientStops, [In] CanvasEdgeBehavior edgeBehavior, [In] CanvasAlphaMode alphaMode);

		// Token: 0x060000AA RID: 170
		CanvasRadialGradientBrush CreateWithEdgeBehaviorAndInterpolationOptions([In] ICanvasResourceCreator resourceCreator, [In] CanvasGradientStop[] gradientStops, [In] CanvasEdgeBehavior edgeBehavior, [In] CanvasAlphaMode alphaMode, [In] CanvasColorSpace preInterpolationSpace, [In] CanvasColorSpace postInterpolationSpace, [In] CanvasBufferPrecision bufferPrecision);
	}
}
