using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Geometry
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(2159677536u, 43479, 16826, 147, 114, 236, 63, 193, 116, 78, 93)]
	[ExclusiveTo(typeof(CanvasCachedGeometry))]
	[Version(167772160u)]
	internal interface ICanvasCachedGeometryStatics
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateFill")]
		CanvasCachedGeometry CreateFill([In] CanvasGeometry geometry);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateFillWithFlatteningTolerance")]
		[DefaultOverload]
		CanvasCachedGeometry CreateFill([In] CanvasGeometry geometry, [In] float flatteningTolerance);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateStroke")]
		CanvasCachedGeometry CreateStroke([In] CanvasGeometry geometry, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateStrokeWithStrokeStyle")]
		CanvasCachedGeometry CreateStroke([In] CanvasGeometry geometry, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateStrokeWithStrokeStyleAndFlatteningTolerance")]
		[DefaultOverload]
		CanvasCachedGeometry CreateStroke([In] CanvasGeometry geometry, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle, [In] float flatteningTolerance);
	}
}
