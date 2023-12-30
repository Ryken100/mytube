using System;
using System.Runtime.InteropServices;
using Microsoft.Graphics.Canvas.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.UI.Input.Inking;

namespace Microsoft.Graphics.Canvas.Geometry
{
	// Token: 0x0200008C RID: 140
	[ExclusiveTo(typeof(CanvasGeometry))]
	[Guid(3645780943U, 52569, 18162, 141, 244, 85, 6, 106, 171, 253, 86)]
	[Version(167772160U)]
	internal interface ICanvasGeometryStatics
	{
		// Token: 0x06000481 RID: 1153
		[DefaultOverload]
		[Overload("CreateRectangle")]
		CanvasGeometry CreateRectangle([In] ICanvasResourceCreator resourceCreator, [In] Rect rect);

		// Token: 0x06000482 RID: 1154
		[Overload("CreateRectangleAtCoords")]
		CanvasGeometry CreateRectangle([In] ICanvasResourceCreator resourceCreator, [In] float x, [In] float y, [In] float w, [In] float h);

		// Token: 0x06000483 RID: 1155
		[DefaultOverload]
		[Overload("CreateRoundedRectangle")]
		CanvasGeometry CreateRoundedRectangle([In] ICanvasResourceCreator resourceCreator, [In] Rect rect, [In] float radiusX, [In] float radiusY);

		// Token: 0x06000484 RID: 1156
		[Overload("CreateRoundedRectangleAtCoords")]
		CanvasGeometry CreateRoundedRectangle([In] ICanvasResourceCreator resourceCreator, [In] float x, [In] float y, [In] float w, [In] float h, [In] float radiusX, [In] float radiusY);

		// Token: 0x06000485 RID: 1157
		[Overload("CreateEllipse")]
		[DefaultOverload]
		CanvasGeometry CreateEllipse([In] ICanvasResourceCreator resourceCreator, [In] Vector2 centerPoint, [In] float radiusX, [In] float radiusY);

		// Token: 0x06000486 RID: 1158
		[Overload("CreateEllipseAtCoords")]
		CanvasGeometry CreateEllipse([In] ICanvasResourceCreator resourceCreator, [In] float x, [In] float y, [In] float radiusX, [In] float radiusY);

		// Token: 0x06000487 RID: 1159
		[Overload("CreateCircle")]
		[DefaultOverload]
		CanvasGeometry CreateCircle([In] ICanvasResourceCreator resourceCreator, [In] Vector2 centerPoint, [In] float radius);

		// Token: 0x06000488 RID: 1160
		[Overload("CreateCircleAtCoords")]
		CanvasGeometry CreateCircle([In] ICanvasResourceCreator resourceCreator, [In] float x, [In] float y, [In] float radius);

		// Token: 0x06000489 RID: 1161
		CanvasGeometry CreatePath([In] CanvasPathBuilder pathBuilder);

		// Token: 0x0600048A RID: 1162
		CanvasGeometry CreatePolygon([In] ICanvasResourceCreator resourceCreator, [In] Vector2[] points);

		// Token: 0x0600048B RID: 1163
		[Overload("CreateGroup")]
		CanvasGeometry CreateGroup([In] ICanvasResourceCreator resourceCreator, [In] CanvasGeometry[] geometries);

		// Token: 0x0600048C RID: 1164
		[DefaultOverload]
		[Overload("CreateGroupWithFilledRegionDetermination")]
		CanvasGeometry CreateGroup([In] ICanvasResourceCreator resourceCreator, [In] CanvasGeometry[] geometries, [In] CanvasFilledRegionDetermination filledRegionDetermination);

		// Token: 0x0600048D RID: 1165
		CanvasGeometry CreateText([In] CanvasTextLayout textLayout);

		// Token: 0x0600048E RID: 1166
		CanvasGeometry CreateGlyphRun([In] ICanvasResourceCreator resourceCreator, [In] Vector2 point, [In] CanvasFontFace fontFace, [In] float fontSize, [In] CanvasGlyph[] glyphs, [In] bool isSideways, [In] uint bidiLevel, [In] CanvasTextMeasuringMode measuringMode, [In] CanvasGlyphOrientation glyphOrientation);

		// Token: 0x0600048F RID: 1167
		[Overload("CreateInk")]
		CanvasGeometry CreateInk([In] ICanvasResourceCreator resourceCreator, [In] IIterable<InkStroke> inkStrokes);

		// Token: 0x06000490 RID: 1168
		[Overload("CreateInkWithTransformAndFlatteningTolerance")]
		[DefaultOverload]
		CanvasGeometry CreateInk([In] ICanvasResourceCreator resourceCreator, [In] IIterable<InkStroke> inkStrokes, [In] Matrix3x2 transform, [In] float flatteningTolerance);

		// Token: 0x06000491 RID: 1169
		[Overload("ComputeFlatteningTolerance")]
		float ComputeFlatteningTolerance([In] float dpi, [In] float maximumZoomFactor);

		// Token: 0x06000492 RID: 1170
		[DefaultOverload]
		[Overload("ComputeFlatteningToleranceWithTransform")]
		float ComputeFlatteningTolerance([In] float dpi, [In] float maximumZoomFactor, [In] Matrix3x2 expectedGeometryTransform);

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000493 RID: 1171
		float DefaultFlatteningTolerance { get; }
	}
}
