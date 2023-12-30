using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Graphics.Canvas.Text;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics;
using Windows.UI.Input.Inking;

namespace Microsoft.Graphics.Canvas.Geometry
{
	[ComImport]
	[Threading(ThreadingModel.Both)]
	[Static(typeof(ICanvasGeometryStatics), 167772160u)]
	[Version(167772160u)]
	[MarshalingBehavior(MarshalingType.Agile)]
	public sealed class CanvasGeometry : ICanvasGeometry, IDisposable, IGeometrySource2D
	{
		public extern CanvasDevice Device
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern float DefaultFlatteningTolerance
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CombineWith")]
		public extern CanvasGeometry CombineWith([In] CanvasGeometry otherGeometry, [In] Matrix3x2 otherGeometryTransform, [In] CanvasGeometryCombine combine);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CombineWithUsingFlatteningTolerance")]
		[DefaultOverload]
		public extern CanvasGeometry CombineWith([In] CanvasGeometry otherGeometry, [In] Matrix3x2 otherGeometryTransform, [In] CanvasGeometryCombine combine, [In] float flatteningTolerance);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("Stroke")]
		public extern CanvasGeometry Stroke([In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("StrokeWithStrokeStyle")]
		public extern CanvasGeometry Stroke([In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("StrokeWithAllOptions")]
		public extern CanvasGeometry Stroke([In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle, [In] Matrix3x2 transform, [In] float flatteningTolerance);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("Outline")]
		public extern CanvasGeometry Outline();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("OutlineWithTransformAndFlatteningTolerance")]
		[DefaultOverload]
		public extern CanvasGeometry Outline([In] Matrix3x2 transform, [In] float flatteningTolerance);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("Simplify")]
		public extern CanvasGeometry Simplify([In] CanvasGeometrySimplification simplification);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("SimplifyWithTransformAndFlatteningTolerance")]
		public extern CanvasGeometry Simplify([In] CanvasGeometrySimplification simplification, [In] Matrix3x2 transform, [In] float flatteningTolerance);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern CanvasGeometry Transform([In] Matrix3x2 transform);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CompareWith")]
		public extern CanvasGeometryRelation CompareWith([In] CanvasGeometry otherGeometry);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CompareWithUsingTransformAndFlatteningTolerance")]
		[DefaultOverload]
		public extern CanvasGeometryRelation CompareWith([In] CanvasGeometry otherGeometry, [In] Matrix3x2 otherGeometryTransform, [In] float flatteningTolerance);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("ComputeArea")]
		public extern float ComputeArea();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("ComputeAreaWithTransformAndFlatteningTolerance")]
		[DefaultOverload]
		public extern float ComputeArea([In] Matrix3x2 transform, [In] float flatteningTolerance);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("ComputePathLength")]
		public extern float ComputePathLength();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("ComputePathLengthWithTransformAndFlatteningTolerance")]
		[DefaultOverload]
		public extern float ComputePathLength([In] Matrix3x2 transform, [In] float flatteningTolerance);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("ComputePointOnPath")]
		public extern Vector2 ComputePointOnPath([In] float distance);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("ComputePointOnPathWithTangent")]
		[DefaultOverload]
		public extern Vector2 ComputePointOnPath([In] float distance, out Vector2 tangent);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("ComputePointOnPathWithTransformAndFlatteningToleranceAndTangent")]
		public extern Vector2 ComputePointOnPath([In] float length, [In] Matrix3x2 transform, [In] float flatteningTolerance, out Vector2 tangent);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("FillContainsPoint")]
		public extern bool FillContainsPoint([In] Vector2 point);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("FillContainsPointWithTransformAndFlatteningTolerance")]
		[DefaultOverload]
		public extern bool FillContainsPoint([In] Vector2 point, [In] Matrix3x2 transform, [In] float flatteningTolerance);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("ComputeBounds")]
		public extern Rect ComputeBounds();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("ComputeBoundsWithTransform")]
		[DefaultOverload]
		public extern Rect ComputeBounds([In] Matrix3x2 transform);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("ComputeStrokeBounds")]
		public extern Rect ComputeStrokeBounds([In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("ComputeStrokeBoundsWithStrokeStyle")]
		public extern Rect ComputeStrokeBounds([In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("ComputeStrokeBoundsWithAllOptions")]
		public extern Rect ComputeStrokeBounds([In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle, [In] Matrix3x2 transform, [In] float flatteningTolerance);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("StrokeContainsPoint")]
		public extern bool StrokeContainsPoint([In] Vector2 point, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("StrokeContainsPointWithStrokeStyle")]
		public extern bool StrokeContainsPoint([In] Vector2 point, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("StrokeContainsPointWithAllOptions")]
		public extern bool StrokeContainsPoint([In] Vector2 point, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle, [In] Matrix3x2 transform, [In] float flatteningTolerance);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("Tessellate")]
		public extern CanvasTriangleVertices[] Tessellate();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("TessellateWithTransformAndFlatteningTolerance")]
		public extern CanvasTriangleVertices[] Tessellate([In] Matrix3x2 transform, [In] float flatteningTolerance);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void SendPathTo([In] ICanvasPathReceiver streamReader);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void Dispose();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("CreateRectangle")]
		public static extern CanvasGeometry CreateRectangle([In] ICanvasResourceCreator resourceCreator, [In] Rect rect);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateRectangleAtCoords")]
		public static extern CanvasGeometry CreateRectangle([In] ICanvasResourceCreator resourceCreator, [In] float x, [In] float y, [In] float w, [In] float h);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("CreateRoundedRectangle")]
		public static extern CanvasGeometry CreateRoundedRectangle([In] ICanvasResourceCreator resourceCreator, [In] Rect rect, [In] float radiusX, [In] float radiusY);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateRoundedRectangleAtCoords")]
		public static extern CanvasGeometry CreateRoundedRectangle([In] ICanvasResourceCreator resourceCreator, [In] float x, [In] float y, [In] float w, [In] float h, [In] float radiusX, [In] float radiusY);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("CreateEllipse")]
		public static extern CanvasGeometry CreateEllipse([In] ICanvasResourceCreator resourceCreator, [In] Vector2 centerPoint, [In] float radiusX, [In] float radiusY);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateEllipseAtCoords")]
		public static extern CanvasGeometry CreateEllipse([In] ICanvasResourceCreator resourceCreator, [In] float x, [In] float y, [In] float radiusX, [In] float radiusY);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateCircle")]
		[DefaultOverload]
		public static extern CanvasGeometry CreateCircle([In] ICanvasResourceCreator resourceCreator, [In] Vector2 centerPoint, [In] float radius);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateCircleAtCoords")]
		public static extern CanvasGeometry CreateCircle([In] ICanvasResourceCreator resourceCreator, [In] float x, [In] float y, [In] float radius);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public static extern CanvasGeometry CreatePath([In] CanvasPathBuilder pathBuilder);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public static extern CanvasGeometry CreatePolygon([In] ICanvasResourceCreator resourceCreator, [In] Vector2[] points);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateGroup")]
		public static extern CanvasGeometry CreateGroup([In] ICanvasResourceCreator resourceCreator, [In] CanvasGeometry[] geometries);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateGroupWithFilledRegionDetermination")]
		[DefaultOverload]
		public static extern CanvasGeometry CreateGroup([In] ICanvasResourceCreator resourceCreator, [In] CanvasGeometry[] geometries, [In] CanvasFilledRegionDetermination filledRegionDetermination);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public static extern CanvasGeometry CreateText([In] CanvasTextLayout textLayout);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public static extern CanvasGeometry CreateGlyphRun([In] ICanvasResourceCreator resourceCreator, [In] Vector2 point, [In] CanvasFontFace fontFace, [In] float fontSize, [In] CanvasGlyph[] glyphs, [In] bool isSideways, [In] uint bidiLevel, [In] CanvasTextMeasuringMode measuringMode, [In] CanvasGlyphOrientation glyphOrientation);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateInk")]
		public static extern CanvasGeometry CreateInk([In] ICanvasResourceCreator resourceCreator, [In] IEnumerable<InkStroke> inkStrokes);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateInkWithTransformAndFlatteningTolerance")]
		[DefaultOverload]
		public static extern CanvasGeometry CreateInk([In] ICanvasResourceCreator resourceCreator, [In] IEnumerable<InkStroke> inkStrokes, [In] Matrix3x2 transform, [In] float flatteningTolerance);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("ComputeFlatteningTolerance")]
		public static extern float ComputeFlatteningTolerance([In] float dpi, [In] float maximumZoomFactor);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("ComputeFlatteningToleranceWithTransform")]
		public static extern float ComputeFlatteningTolerance([In] float dpi, [In] float maximumZoomFactor, [In] Matrix3x2 expectedGeometryTransform);
	}
}
