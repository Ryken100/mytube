using System;
using System.Runtime.InteropServices;
using Microsoft.Graphics.Canvas.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics;
using Windows.UI.Input.Inking;

namespace Microsoft.Graphics.Canvas.Geometry
{
	// Token: 0x02000071 RID: 113
	[Threading(3)]
	[Static(typeof(ICanvasGeometryStatics), 167772160U)]
	[Version(167772160U)]
	[MarshalingBehavior(2)]
	public sealed class CanvasGeometry : ICanvasGeometry, IClosable, IGeometrySource2D
	{
		// Token: 0x060003CE RID: 974
		[Overload("CombineWith")]
		public extern CanvasGeometry CombineWith([In] CanvasGeometry otherGeometry, [In] Matrix3x2 otherGeometryTransform, [In] CanvasGeometryCombine combine);

		// Token: 0x060003CF RID: 975
		[Overload("CombineWithUsingFlatteningTolerance")]
		[DefaultOverload]
		public extern CanvasGeometry CombineWith([In] CanvasGeometry otherGeometry, [In] Matrix3x2 otherGeometryTransform, [In] CanvasGeometryCombine combine, [In] float flatteningTolerance);

		// Token: 0x060003D0 RID: 976
		[Overload("Stroke")]
		public extern CanvasGeometry Stroke([In] float strokeWidth);

		// Token: 0x060003D1 RID: 977
		[DefaultOverload]
		[Overload("StrokeWithStrokeStyle")]
		public extern CanvasGeometry Stroke([In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x060003D2 RID: 978
		[DefaultOverload]
		[Overload("StrokeWithAllOptions")]
		public extern CanvasGeometry Stroke([In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle, [In] Matrix3x2 transform, [In] float flatteningTolerance);

		// Token: 0x060003D3 RID: 979
		[Overload("Outline")]
		public extern CanvasGeometry Outline();

		// Token: 0x060003D4 RID: 980
		[Overload("OutlineWithTransformAndFlatteningTolerance")]
		[DefaultOverload]
		public extern CanvasGeometry Outline([In] Matrix3x2 transform, [In] float flatteningTolerance);

		// Token: 0x060003D5 RID: 981
		[Overload("Simplify")]
		public extern CanvasGeometry Simplify([In] CanvasGeometrySimplification simplification);

		// Token: 0x060003D6 RID: 982
		[DefaultOverload]
		[Overload("SimplifyWithTransformAndFlatteningTolerance")]
		public extern CanvasGeometry Simplify([In] CanvasGeometrySimplification simplification, [In] Matrix3x2 transform, [In] float flatteningTolerance);

		// Token: 0x060003D7 RID: 983
		public extern CanvasGeometry Transform([In] Matrix3x2 transform);

		// Token: 0x060003D8 RID: 984
		[Overload("CompareWith")]
		public extern CanvasGeometryRelation CompareWith([In] CanvasGeometry otherGeometry);

		// Token: 0x060003D9 RID: 985
		[Overload("CompareWithUsingTransformAndFlatteningTolerance")]
		[DefaultOverload]
		public extern CanvasGeometryRelation CompareWith([In] CanvasGeometry otherGeometry, [In] Matrix3x2 otherGeometryTransform, [In] float flatteningTolerance);

		// Token: 0x060003DA RID: 986
		[Overload("ComputeArea")]
		public extern float ComputeArea();

		// Token: 0x060003DB RID: 987
		[Overload("ComputeAreaWithTransformAndFlatteningTolerance")]
		[DefaultOverload]
		public extern float ComputeArea([In] Matrix3x2 transform, [In] float flatteningTolerance);

		// Token: 0x060003DC RID: 988
		[Overload("ComputePathLength")]
		public extern float ComputePathLength();

		// Token: 0x060003DD RID: 989
		[Overload("ComputePathLengthWithTransformAndFlatteningTolerance")]
		[DefaultOverload]
		public extern float ComputePathLength([In] Matrix3x2 transform, [In] float flatteningTolerance);

		// Token: 0x060003DE RID: 990
		[Overload("ComputePointOnPath")]
		public extern Vector2 ComputePointOnPath([In] float distance);

		// Token: 0x060003DF RID: 991
		[Overload("ComputePointOnPathWithTangent")]
		[DefaultOverload]
		public extern Vector2 ComputePointOnPath([In] float distance, out Vector2 tangent);

		// Token: 0x060003E0 RID: 992
		[DefaultOverload]
		[Overload("ComputePointOnPathWithTransformAndFlatteningToleranceAndTangent")]
		public extern Vector2 ComputePointOnPath([In] float length, [In] Matrix3x2 transform, [In] float flatteningTolerance, out Vector2 tangent);

		// Token: 0x060003E1 RID: 993
		[Overload("FillContainsPoint")]
		public extern bool FillContainsPoint([In] Vector2 point);

		// Token: 0x060003E2 RID: 994
		[Overload("FillContainsPointWithTransformAndFlatteningTolerance")]
		[DefaultOverload]
		public extern bool FillContainsPoint([In] Vector2 point, [In] Matrix3x2 transform, [In] float flatteningTolerance);

		// Token: 0x060003E3 RID: 995
		[Overload("ComputeBounds")]
		public extern Rect ComputeBounds();

		// Token: 0x060003E4 RID: 996
		[Overload("ComputeBoundsWithTransform")]
		[DefaultOverload]
		public extern Rect ComputeBounds([In] Matrix3x2 transform);

		// Token: 0x060003E5 RID: 997
		[Overload("ComputeStrokeBounds")]
		public extern Rect ComputeStrokeBounds([In] float strokeWidth);

		// Token: 0x060003E6 RID: 998
		[DefaultOverload]
		[Overload("ComputeStrokeBoundsWithStrokeStyle")]
		public extern Rect ComputeStrokeBounds([In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x060003E7 RID: 999
		[DefaultOverload]
		[Overload("ComputeStrokeBoundsWithAllOptions")]
		public extern Rect ComputeStrokeBounds([In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle, [In] Matrix3x2 transform, [In] float flatteningTolerance);

		// Token: 0x060003E8 RID: 1000
		[Overload("StrokeContainsPoint")]
		public extern bool StrokeContainsPoint([In] Vector2 point, [In] float strokeWidth);

		// Token: 0x060003E9 RID: 1001
		[DefaultOverload]
		[Overload("StrokeContainsPointWithStrokeStyle")]
		public extern bool StrokeContainsPoint([In] Vector2 point, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x060003EA RID: 1002
		[DefaultOverload]
		[Overload("StrokeContainsPointWithAllOptions")]
		public extern bool StrokeContainsPoint([In] Vector2 point, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle, [In] Matrix3x2 transform, [In] float flatteningTolerance);

		// Token: 0x060003EB RID: 1003
		[Overload("Tessellate")]
		public extern CanvasTriangleVertices[] Tessellate();

		// Token: 0x060003EC RID: 1004
		[Overload("TessellateWithTransformAndFlatteningTolerance")]
		public extern CanvasTriangleVertices[] Tessellate([In] Matrix3x2 transform, [In] float flatteningTolerance);

		// Token: 0x060003ED RID: 1005
		public extern void SendPathTo([In] ICanvasPathReceiver streamReader);

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x060003EE RID: 1006
		public extern CanvasDevice Device { get; }

		// Token: 0x060003EF RID: 1007
		public extern void Close();

		// Token: 0x060003F0 RID: 1008
		[DefaultOverload]
		[Overload("CreateRectangle")]
		public static extern CanvasGeometry CreateRectangle([In] ICanvasResourceCreator resourceCreator, [In] Rect rect);

		// Token: 0x060003F1 RID: 1009
		[Overload("CreateRectangleAtCoords")]
		public static extern CanvasGeometry CreateRectangle([In] ICanvasResourceCreator resourceCreator, [In] float x, [In] float y, [In] float w, [In] float h);

		// Token: 0x060003F2 RID: 1010
		[DefaultOverload]
		[Overload("CreateRoundedRectangle")]
		public static extern CanvasGeometry CreateRoundedRectangle([In] ICanvasResourceCreator resourceCreator, [In] Rect rect, [In] float radiusX, [In] float radiusY);

		// Token: 0x060003F3 RID: 1011
		[Overload("CreateRoundedRectangleAtCoords")]
		public static extern CanvasGeometry CreateRoundedRectangle([In] ICanvasResourceCreator resourceCreator, [In] float x, [In] float y, [In] float w, [In] float h, [In] float radiusX, [In] float radiusY);

		// Token: 0x060003F4 RID: 1012
		[DefaultOverload]
		[Overload("CreateEllipse")]
		public static extern CanvasGeometry CreateEllipse([In] ICanvasResourceCreator resourceCreator, [In] Vector2 centerPoint, [In] float radiusX, [In] float radiusY);

		// Token: 0x060003F5 RID: 1013
		[Overload("CreateEllipseAtCoords")]
		public static extern CanvasGeometry CreateEllipse([In] ICanvasResourceCreator resourceCreator, [In] float x, [In] float y, [In] float radiusX, [In] float radiusY);

		// Token: 0x060003F6 RID: 1014
		[Overload("CreateCircle")]
		[DefaultOverload]
		public static extern CanvasGeometry CreateCircle([In] ICanvasResourceCreator resourceCreator, [In] Vector2 centerPoint, [In] float radius);

		// Token: 0x060003F7 RID: 1015
		[Overload("CreateCircleAtCoords")]
		public static extern CanvasGeometry CreateCircle([In] ICanvasResourceCreator resourceCreator, [In] float x, [In] float y, [In] float radius);

		// Token: 0x060003F8 RID: 1016
		public static extern CanvasGeometry CreatePath([In] CanvasPathBuilder pathBuilder);

		// Token: 0x060003F9 RID: 1017
		public static extern CanvasGeometry CreatePolygon([In] ICanvasResourceCreator resourceCreator, [In] Vector2[] points);

		// Token: 0x060003FA RID: 1018
		[Overload("CreateGroup")]
		public static extern CanvasGeometry CreateGroup([In] ICanvasResourceCreator resourceCreator, [In] CanvasGeometry[] geometries);

		// Token: 0x060003FB RID: 1019
		[Overload("CreateGroupWithFilledRegionDetermination")]
		[DefaultOverload]
		public static extern CanvasGeometry CreateGroup([In] ICanvasResourceCreator resourceCreator, [In] CanvasGeometry[] geometries, [In] CanvasFilledRegionDetermination filledRegionDetermination);

		// Token: 0x060003FC RID: 1020
		public static extern CanvasGeometry CreateText([In] CanvasTextLayout textLayout);

		// Token: 0x060003FD RID: 1021
		public static extern CanvasGeometry CreateGlyphRun([In] ICanvasResourceCreator resourceCreator, [In] Vector2 point, [In] CanvasFontFace fontFace, [In] float fontSize, [In] CanvasGlyph[] glyphs, [In] bool isSideways, [In] uint bidiLevel, [In] CanvasTextMeasuringMode measuringMode, [In] CanvasGlyphOrientation glyphOrientation);

		// Token: 0x060003FE RID: 1022
		[Overload("CreateInk")]
		public static extern CanvasGeometry CreateInk([In] ICanvasResourceCreator resourceCreator, [In] IIterable<InkStroke> inkStrokes);

		// Token: 0x060003FF RID: 1023
		[Overload("CreateInkWithTransformAndFlatteningTolerance")]
		[DefaultOverload]
		public static extern CanvasGeometry CreateInk([In] ICanvasResourceCreator resourceCreator, [In] IIterable<InkStroke> inkStrokes, [In] Matrix3x2 transform, [In] float flatteningTolerance);

		// Token: 0x06000400 RID: 1024
		[Overload("ComputeFlatteningTolerance")]
		public static extern float ComputeFlatteningTolerance([In] float dpi, [In] float maximumZoomFactor);

		// Token: 0x06000401 RID: 1025
		[DefaultOverload]
		[Overload("ComputeFlatteningToleranceWithTransform")]
		public static extern float ComputeFlatteningTolerance([In] float dpi, [In] float maximumZoomFactor, [In] Matrix3x2 expectedGeometryTransform);

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000402 RID: 1026
		public static extern float DefaultFlatteningTolerance { get; }
	}
}
