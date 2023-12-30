using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Microsoft.Graphics.Canvas.Geometry
{
	// Token: 0x0200008B RID: 139
	[ExclusiveTo(typeof(CanvasGeometry))]
	[Version(167772160U)]
	[Guid(1961527802U, 51324, 19725, 144, 87, 39, 67, 184, 219, 103, 238)]
	internal interface ICanvasGeometry : IClosable
	{
		// Token: 0x06000460 RID: 1120
		[Overload("CombineWith")]
		CanvasGeometry CombineWith([In] CanvasGeometry otherGeometry, [In] Matrix3x2 otherGeometryTransform, [In] CanvasGeometryCombine combine);

		// Token: 0x06000461 RID: 1121
		[Overload("CombineWithUsingFlatteningTolerance")]
		[DefaultOverload]
		CanvasGeometry CombineWith([In] CanvasGeometry otherGeometry, [In] Matrix3x2 otherGeometryTransform, [In] CanvasGeometryCombine combine, [In] float flatteningTolerance);

		// Token: 0x06000462 RID: 1122
		[Overload("Stroke")]
		CanvasGeometry Stroke([In] float strokeWidth);

		// Token: 0x06000463 RID: 1123
		[Overload("StrokeWithStrokeStyle")]
		[DefaultOverload]
		CanvasGeometry Stroke([In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x06000464 RID: 1124
		[Overload("StrokeWithAllOptions")]
		[DefaultOverload]
		CanvasGeometry Stroke([In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle, [In] Matrix3x2 transform, [In] float flatteningTolerance);

		// Token: 0x06000465 RID: 1125
		[Overload("Outline")]
		CanvasGeometry Outline();

		// Token: 0x06000466 RID: 1126
		[DefaultOverload]
		[Overload("OutlineWithTransformAndFlatteningTolerance")]
		CanvasGeometry Outline([In] Matrix3x2 transform, [In] float flatteningTolerance);

		// Token: 0x06000467 RID: 1127
		[Overload("Simplify")]
		CanvasGeometry Simplify([In] CanvasGeometrySimplification simplification);

		// Token: 0x06000468 RID: 1128
		[DefaultOverload]
		[Overload("SimplifyWithTransformAndFlatteningTolerance")]
		CanvasGeometry Simplify([In] CanvasGeometrySimplification simplification, [In] Matrix3x2 transform, [In] float flatteningTolerance);

		// Token: 0x06000469 RID: 1129
		CanvasGeometry Transform([In] Matrix3x2 transform);

		// Token: 0x0600046A RID: 1130
		[Overload("CompareWith")]
		CanvasGeometryRelation CompareWith([In] CanvasGeometry otherGeometry);

		// Token: 0x0600046B RID: 1131
		[Overload("CompareWithUsingTransformAndFlatteningTolerance")]
		[DefaultOverload]
		CanvasGeometryRelation CompareWith([In] CanvasGeometry otherGeometry, [In] Matrix3x2 otherGeometryTransform, [In] float flatteningTolerance);

		// Token: 0x0600046C RID: 1132
		[Overload("ComputeArea")]
		float ComputeArea();

		// Token: 0x0600046D RID: 1133
		[DefaultOverload]
		[Overload("ComputeAreaWithTransformAndFlatteningTolerance")]
		float ComputeArea([In] Matrix3x2 transform, [In] float flatteningTolerance);

		// Token: 0x0600046E RID: 1134
		[Overload("ComputePathLength")]
		float ComputePathLength();

		// Token: 0x0600046F RID: 1135
		[DefaultOverload]
		[Overload("ComputePathLengthWithTransformAndFlatteningTolerance")]
		float ComputePathLength([In] Matrix3x2 transform, [In] float flatteningTolerance);

		// Token: 0x06000470 RID: 1136
		[Overload("ComputePointOnPath")]
		Vector2 ComputePointOnPath([In] float distance);

		// Token: 0x06000471 RID: 1137
		[DefaultOverload]
		[Overload("ComputePointOnPathWithTangent")]
		Vector2 ComputePointOnPath([In] float distance, out Vector2 tangent);

		// Token: 0x06000472 RID: 1138
		[Overload("ComputePointOnPathWithTransformAndFlatteningToleranceAndTangent")]
		[DefaultOverload]
		Vector2 ComputePointOnPath([In] float length, [In] Matrix3x2 transform, [In] float flatteningTolerance, out Vector2 tangent);

		// Token: 0x06000473 RID: 1139
		[Overload("FillContainsPoint")]
		bool FillContainsPoint([In] Vector2 point);

		// Token: 0x06000474 RID: 1140
		[DefaultOverload]
		[Overload("FillContainsPointWithTransformAndFlatteningTolerance")]
		bool FillContainsPoint([In] Vector2 point, [In] Matrix3x2 transform, [In] float flatteningTolerance);

		// Token: 0x06000475 RID: 1141
		[Overload("ComputeBounds")]
		Rect ComputeBounds();

		// Token: 0x06000476 RID: 1142
		[Overload("ComputeBoundsWithTransform")]
		[DefaultOverload]
		Rect ComputeBounds([In] Matrix3x2 transform);

		// Token: 0x06000477 RID: 1143
		[Overload("ComputeStrokeBounds")]
		Rect ComputeStrokeBounds([In] float strokeWidth);

		// Token: 0x06000478 RID: 1144
		[DefaultOverload]
		[Overload("ComputeStrokeBoundsWithStrokeStyle")]
		Rect ComputeStrokeBounds([In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x06000479 RID: 1145
		[Overload("ComputeStrokeBoundsWithAllOptions")]
		[DefaultOverload]
		Rect ComputeStrokeBounds([In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle, [In] Matrix3x2 transform, [In] float flatteningTolerance);

		// Token: 0x0600047A RID: 1146
		[Overload("StrokeContainsPoint")]
		bool StrokeContainsPoint([In] Vector2 point, [In] float strokeWidth);

		// Token: 0x0600047B RID: 1147
		[DefaultOverload]
		[Overload("StrokeContainsPointWithStrokeStyle")]
		bool StrokeContainsPoint([In] Vector2 point, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x0600047C RID: 1148
		[Overload("StrokeContainsPointWithAllOptions")]
		[DefaultOverload]
		bool StrokeContainsPoint([In] Vector2 point, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle, [In] Matrix3x2 transform, [In] float flatteningTolerance);

		// Token: 0x0600047D RID: 1149
		[Overload("Tessellate")]
		CanvasTriangleVertices[] Tessellate();

		// Token: 0x0600047E RID: 1150
		[Overload("TessellateWithTransformAndFlatteningTolerance")]
		CanvasTriangleVertices[] Tessellate([In] Matrix3x2 transform, [In] float flatteningTolerance);

		// Token: 0x0600047F RID: 1151
		void SendPathTo([In] ICanvasPathReceiver streamReader);

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000480 RID: 1152
		CanvasDevice Device { get; }
	}
}
