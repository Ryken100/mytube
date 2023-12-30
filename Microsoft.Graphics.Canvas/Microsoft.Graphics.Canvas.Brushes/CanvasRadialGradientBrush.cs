using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Brushes
{
	[ComImport]
	[Version(167772160u)]
	[Static(typeof(ICanvasRadialGradientBrushStatics), 167772160u)]
	[Activatable(typeof(ICanvasRadialGradientBrushFactory), 167772160u)]
	[Threading(ThreadingModel.Both)]
	[MarshalingBehavior(MarshalingType.Agile)]
	public sealed class CanvasRadialGradientBrush : ICanvasRadialGradientBrush, ICanvasBrush, IDisposable
	{
		public extern Matrix3x2 Transform
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern float Opacity
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern CanvasDevice Device
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern float RadiusY
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern float RadiusX
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern Vector2 OriginOffset
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern Vector2 Center
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern CanvasAlphaMode AlphaMode
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern CanvasBufferPrecision BufferPrecision
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern CanvasEdgeBehavior EdgeBehavior
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern CanvasColorSpace PostInterpolationSpace
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern CanvasColorSpace PreInterpolationSpace
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern CanvasGradientStop[] Stops
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern CanvasGradientStopHdr[] StopsHdr
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void Dispose();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateHdrSimple")]
		public static extern CanvasRadialGradientBrush CreateHdr([In] ICanvasResourceCreator resourceCreator, [In] Vector4 startColorHdr, [In] Vector4 endColorHdr);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateHdrWithStops")]
		public static extern CanvasRadialGradientBrush CreateHdr([In] ICanvasResourceCreator resourceCreator, [In] CanvasGradientStopHdr[] gradientStops);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateHdrWithEdgeBehaviorAndAlphaMode")]
		public static extern CanvasRadialGradientBrush CreateHdr([In] ICanvasResourceCreator resourceCreator, [In] CanvasGradientStopHdr[] gradientStops, [In] CanvasEdgeBehavior edgeBehavior, [In] CanvasAlphaMode alphaMode);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateHdrWithEdgeBehaviorAndInterpolationOptions")]
		public static extern CanvasRadialGradientBrush CreateHdr([In] ICanvasResourceCreator resourceCreator, [In] CanvasGradientStopHdr[] gradientStops, [In] CanvasEdgeBehavior edgeBehavior, [In] CanvasAlphaMode alphaMode, [In] CanvasColorSpace preInterpolationSpace, [In] CanvasColorSpace postInterpolationSpace, [In] CanvasBufferPrecision bufferPrecision);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public static extern CanvasRadialGradientBrush CreateRainbow([In] ICanvasResourceCreator resourceCreator, [In] float eldritchness);
	}
}
