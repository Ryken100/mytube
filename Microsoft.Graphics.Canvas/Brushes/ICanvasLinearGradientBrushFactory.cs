using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Microsoft.Graphics.Canvas.Brushes
{
	// Token: 0x0200003A RID: 58
	[Version(167772160U)]
	[ExclusiveTo(typeof(CanvasLinearGradientBrush))]
	[Guid(2733171530U, 34194, 19357, 186, 28, 0, 211, 243, 195, 79, 84)]
	internal interface ICanvasLinearGradientBrushFactory
	{
		// Token: 0x06000079 RID: 121
		CanvasLinearGradientBrush CreateSimple([In] ICanvasResourceCreator resourceCreator, [In] Color startColor, [In] Color endColor);

		// Token: 0x0600007A RID: 122
		CanvasLinearGradientBrush CreateWithStops([In] ICanvasResourceCreator resourceCreator, [In] CanvasGradientStop[] gradientStops);

		// Token: 0x0600007B RID: 123
		CanvasLinearGradientBrush CreateWithEdgeBehaviorAndAlphaMode([In] ICanvasResourceCreator resourceCreator, [In] CanvasGradientStop[] gradientStops, [In] CanvasEdgeBehavior edgeBehavior, [In] CanvasAlphaMode alphaMode);

		// Token: 0x0600007C RID: 124
		CanvasLinearGradientBrush CreateWithEdgeBehaviorAndInterpolationOptions([In] ICanvasResourceCreator resourceCreator, [In] CanvasGradientStop[] gradientStops, [In] CanvasEdgeBehavior edgeBehavior, [In] CanvasAlphaMode alphaMode, [In] CanvasColorSpace preInterpolationSpace, [In] CanvasColorSpace postInterpolationSpace, [In] CanvasBufferPrecision bufferPrecision);
	}
}
