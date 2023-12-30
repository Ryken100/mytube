using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Geometry
{
	[ComImport]
	[MarshalingBehavior(MarshalingType.Agile)]
	[Threading(ThreadingModel.Both)]
	[Static(typeof(ICanvasCachedGeometryStatics), 167772160u)]
	[Version(167772160u)]
	public sealed class CanvasCachedGeometry : ICanvasCachedGeometry, IDisposable
	{
		public extern CanvasDevice Device
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void Dispose();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateFill")]
		public static extern CanvasCachedGeometry CreateFill([In] CanvasGeometry geometry);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateFillWithFlatteningTolerance")]
		[DefaultOverload]
		public static extern CanvasCachedGeometry CreateFill([In] CanvasGeometry geometry, [In] float flatteningTolerance);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateStroke")]
		public static extern CanvasCachedGeometry CreateStroke([In] CanvasGeometry geometry, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateStrokeWithStrokeStyle")]
		public static extern CanvasCachedGeometry CreateStroke([In] CanvasGeometry geometry, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateStrokeWithStrokeStyleAndFlatteningTolerance")]
		[DefaultOverload]
		public static extern CanvasCachedGeometry CreateStroke([In] CanvasGeometry geometry, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle, [In] float flatteningTolerance);
	}
}
