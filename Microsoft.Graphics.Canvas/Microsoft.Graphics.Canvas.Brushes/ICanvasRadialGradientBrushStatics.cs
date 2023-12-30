using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Brushes
{
	[ComImport]
	[ExclusiveTo(typeof(CanvasRadialGradientBrush))]
	[Windows.Foundation.Metadata.Guid(990727598u, 15905, 18456, 153, 180, 119, 154, 202, 175, 24, 190)]
	[Version(167772160u)]
	internal interface ICanvasRadialGradientBrushStatics
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateHdrSimple")]
		CanvasRadialGradientBrush CreateHdr([In] ICanvasResourceCreator resourceCreator, [In] Vector4 startColorHdr, [In] Vector4 endColorHdr);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateHdrWithStops")]
		CanvasRadialGradientBrush CreateHdr([In] ICanvasResourceCreator resourceCreator, [In] CanvasGradientStopHdr[] gradientStops);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateHdrWithEdgeBehaviorAndAlphaMode")]
		CanvasRadialGradientBrush CreateHdr([In] ICanvasResourceCreator resourceCreator, [In] CanvasGradientStopHdr[] gradientStops, [In] CanvasEdgeBehavior edgeBehavior, [In] CanvasAlphaMode alphaMode);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateHdrWithEdgeBehaviorAndInterpolationOptions")]
		CanvasRadialGradientBrush CreateHdr([In] ICanvasResourceCreator resourceCreator, [In] CanvasGradientStopHdr[] gradientStops, [In] CanvasEdgeBehavior edgeBehavior, [In] CanvasAlphaMode alphaMode, [In] CanvasColorSpace preInterpolationSpace, [In] CanvasColorSpace postInterpolationSpace, [In] CanvasBufferPrecision bufferPrecision);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasRadialGradientBrush CreateRainbow([In] ICanvasResourceCreator resourceCreator, [In] float eldritchness);
	}
}
