using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Microsoft.Graphics.Canvas.Brushes
{
	[ComImport]
	[Version(167772160u)]
	[ExclusiveTo(typeof(CanvasLinearGradientBrush))]
	[Windows.Foundation.Metadata.Guid(2733171530u, 34194, 19357, 186, 28, 0, 211, 243, 195, 79, 84)]
	internal interface ICanvasLinearGradientBrushFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasLinearGradientBrush CreateSimple([In] ICanvasResourceCreator resourceCreator, [In] Color startColor, [In] Color endColor);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasLinearGradientBrush CreateWithStops([In] ICanvasResourceCreator resourceCreator, [In] CanvasGradientStop[] gradientStops);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasLinearGradientBrush CreateWithEdgeBehaviorAndAlphaMode([In] ICanvasResourceCreator resourceCreator, [In] CanvasGradientStop[] gradientStops, [In] CanvasEdgeBehavior edgeBehavior, [In] CanvasAlphaMode alphaMode);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasLinearGradientBrush CreateWithEdgeBehaviorAndInterpolationOptions([In] ICanvasResourceCreator resourceCreator, [In] CanvasGradientStop[] gradientStops, [In] CanvasEdgeBehavior edgeBehavior, [In] CanvasAlphaMode alphaMode, [In] CanvasColorSpace preInterpolationSpace, [In] CanvasColorSpace postInterpolationSpace, [In] CanvasBufferPrecision bufferPrecision);
	}
}
