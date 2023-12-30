using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Geometry
{
	[ComImport]
	[ExclusiveTo(typeof(CanvasGeometry))]
	[Version(167772160u)]
	[Windows.Foundation.Metadata.Guid(1961527802u, 51324, 19725, 144, 87, 39, 67, 184, 219, 103, 238)]
	internal interface ICanvasGeometry : IDisposable
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CombineWith")]
		CanvasGeometry CombineWith([In] CanvasGeometry otherGeometry, [In] Matrix3x2 otherGeometryTransform, [In] CanvasGeometryCombine combine);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CombineWithUsingFlatteningTolerance")]
		[DefaultOverload]
		CanvasGeometry CombineWith([In] CanvasGeometry otherGeometry, [In] Matrix3x2 otherGeometryTransform, [In] CanvasGeometryCombine combine, [In] float flatteningTolerance);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("Stroke")]
		CanvasGeometry Stroke([In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("StrokeWithStrokeStyle")]
		[DefaultOverload]
		CanvasGeometry Stroke([In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("StrokeWithAllOptions")]
		[DefaultOverload]
		CanvasGeometry Stroke([In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle, [In] Matrix3x2 transform, [In] float flatteningTolerance);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("Outline")]
		CanvasGeometry Outline();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("OutlineWithTransformAndFlatteningTolerance")]
		CanvasGeometry Outline([In] Matrix3x2 transform, [In] float flatteningTolerance);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("Simplify")]
		CanvasGeometry Simplify([In] CanvasGeometrySimplification simplification);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("SimplifyWithTransformAndFlatteningTolerance")]
		CanvasGeometry Simplify([In] CanvasGeometrySimplification simplification, [In] Matrix3x2 transform, [In] float flatteningTolerance);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasGeometry Transform([In] Matrix3x2 transform);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CompareWith")]
		CanvasGeometryRelation CompareWith([In] CanvasGeometry otherGeometry);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CompareWithUsingTransformAndFlatteningTolerance")]
		[DefaultOverload]
		CanvasGeometryRelation CompareWith([In] CanvasGeometry otherGeometry, [In] Matrix3x2 otherGeometryTransform, [In] float flatteningTolerance);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("ComputeArea")]
		float ComputeArea();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("ComputeAreaWithTransformAndFlatteningTolerance")]
		float ComputeArea([In] Matrix3x2 transform, [In] float flatteningTolerance);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("ComputePathLength")]
		float ComputePathLength();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("ComputePathLengthWithTransformAndFlatteningTolerance")]
		float ComputePathLength([In] Matrix3x2 transform, [In] float flatteningTolerance);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("ComputePointOnPath")]
		Vector2 ComputePointOnPath([In] float distance);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("ComputePointOnPathWithTangent")]
		Vector2 ComputePointOnPath([In] float distance, out Vector2 tangent);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("ComputePointOnPathWithTransformAndFlatteningToleranceAndTangent")]
		[DefaultOverload]
		Vector2 ComputePointOnPath([In] float length, [In] Matrix3x2 transform, [In] float flatteningTolerance, out Vector2 tangent);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("FillContainsPoint")]
		bool FillContainsPoint([In] Vector2 point);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("FillContainsPointWithTransformAndFlatteningTolerance")]
		bool FillContainsPoint([In] Vector2 point, [In] Matrix3x2 transform, [In] float flatteningTolerance);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("ComputeBounds")]
		Rect ComputeBounds();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("ComputeBoundsWithTransform")]
		[DefaultOverload]
		Rect ComputeBounds([In] Matrix3x2 transform);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("ComputeStrokeBounds")]
		Rect ComputeStrokeBounds([In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("ComputeStrokeBoundsWithStrokeStyle")]
		Rect ComputeStrokeBounds([In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("ComputeStrokeBoundsWithAllOptions")]
		[DefaultOverload]
		Rect ComputeStrokeBounds([In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle, [In] Matrix3x2 transform, [In] float flatteningTolerance);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("StrokeContainsPoint")]
		bool StrokeContainsPoint([In] Vector2 point, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("StrokeContainsPointWithStrokeStyle")]
		bool StrokeContainsPoint([In] Vector2 point, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("StrokeContainsPointWithAllOptions")]
		[DefaultOverload]
		bool StrokeContainsPoint([In] Vector2 point, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle, [In] Matrix3x2 transform, [In] float flatteningTolerance);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("Tessellate")]
		CanvasTriangleVertices[] Tessellate();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("TessellateWithTransformAndFlatteningTolerance")]
		CanvasTriangleVertices[] Tessellate([In] Matrix3x2 transform, [In] float flatteningTolerance);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SendPathTo([In] ICanvasPathReceiver streamReader);

		CanvasDevice Device
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
