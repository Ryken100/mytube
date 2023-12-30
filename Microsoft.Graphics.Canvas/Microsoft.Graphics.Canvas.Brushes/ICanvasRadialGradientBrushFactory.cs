using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Microsoft.Graphics.Canvas.Brushes
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(2033427743u, 43280, 17736, 132, 159, 66, 221, 236, 70, 111, 65)]
	[Version(167772160u)]
	[ExclusiveTo(typeof(CanvasRadialGradientBrush))]
	internal interface ICanvasRadialGradientBrushFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasRadialGradientBrush CreateSimple([In] ICanvasResourceCreator resourceCreator, [In] Color startColor, [In] Color endColor);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasRadialGradientBrush CreateWithStops([In] ICanvasResourceCreator resourceCreator, [In] CanvasGradientStop[] gradientStops);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasRadialGradientBrush CreateWithEdgeBehaviorAndAlphaMode([In] ICanvasResourceCreator resourceCreator, [In] CanvasGradientStop[] gradientStops, [In] CanvasEdgeBehavior edgeBehavior, [In] CanvasAlphaMode alphaMode);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasRadialGradientBrush CreateWithEdgeBehaviorAndInterpolationOptions([In] ICanvasResourceCreator resourceCreator, [In] CanvasGradientStop[] gradientStops, [In] CanvasEdgeBehavior edgeBehavior, [In] CanvasAlphaMode alphaMode, [In] CanvasColorSpace preInterpolationSpace, [In] CanvasColorSpace postInterpolationSpace, [In] CanvasBufferPrecision bufferPrecision);
	}
}
