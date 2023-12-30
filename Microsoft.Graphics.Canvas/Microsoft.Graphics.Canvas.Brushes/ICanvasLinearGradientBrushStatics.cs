using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Brushes
{
	[ComImport]
	[Version(167772160u)]
	[Windows.Foundation.Metadata.Guid(3923653522u, 36799, 18316, 142, 106, 208, 160, 234, 117, 59, 55)]
	[ExclusiveTo(typeof(CanvasLinearGradientBrush))]
	internal interface ICanvasLinearGradientBrushStatics
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateHdrSimple")]
		CanvasLinearGradientBrush CreateHdr([In] ICanvasResourceCreator resourceCreator, [In] Vector4 startColorHdr, [In] Vector4 endColorHdr);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateHdrWithStops")]
		CanvasLinearGradientBrush CreateHdr([In] ICanvasResourceCreator resourceCreator, [In] CanvasGradientStopHdr[] gradientStopsHdr);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateHdrWithEdgeBehaviorAndAlphaMode")]
		CanvasLinearGradientBrush CreateHdr([In] ICanvasResourceCreator resourceCreator, [In] CanvasGradientStopHdr[] gradientStopsHdr, [In] CanvasEdgeBehavior edgeBehavior, [In] CanvasAlphaMode alphaMode);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateHdrWithEdgeBehaviorAndInterpolationOptions")]
		CanvasLinearGradientBrush CreateHdr([In] ICanvasResourceCreator resourceCreator, [In] CanvasGradientStopHdr[] gradientStopsHdr, [In] CanvasEdgeBehavior edgeBehavior, [In] CanvasAlphaMode alphaMode, [In] CanvasColorSpace preInterpolationSpace, [In] CanvasColorSpace postInterpolationSpace, [In] CanvasBufferPrecision bufferPrecision);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasLinearGradientBrush CreateRainbow([In] ICanvasResourceCreator resourceCreator, [In] float eldritchness);
	}
}
