using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Graphics.Canvas.Text;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Input.Inking;

namespace Microsoft.Graphics.Canvas.Geometry
{
	[ComImport]
	[ExclusiveTo(typeof(CanvasGeometry))]
	[Windows.Foundation.Metadata.Guid(3645780943u, 52569, 18162, 141, 244, 85, 6, 106, 171, 253, 86)]
	[Version(167772160u)]
	internal interface ICanvasGeometryStatics
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("CreateRectangle")]
		CanvasGeometry CreateRectangle([In] ICanvasResourceCreator resourceCreator, [In] Rect rect);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateRectangleAtCoords")]
		CanvasGeometry CreateRectangle([In] ICanvasResourceCreator resourceCreator, [In] float x, [In] float y, [In] float w, [In] float h);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("CreateRoundedRectangle")]
		CanvasGeometry CreateRoundedRectangle([In] ICanvasResourceCreator resourceCreator, [In] Rect rect, [In] float radiusX, [In] float radiusY);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateRoundedRectangleAtCoords")]
		CanvasGeometry CreateRoundedRectangle([In] ICanvasResourceCreator resourceCreator, [In] float x, [In] float y, [In] float w, [In] float h, [In] float radiusX, [In] float radiusY);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateEllipse")]
		[DefaultOverload]
		CanvasGeometry CreateEllipse([In] ICanvasResourceCreator resourceCreator, [In] Vector2 centerPoint, [In] float radiusX, [In] float radiusY);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateEllipseAtCoords")]
		CanvasGeometry CreateEllipse([In] ICanvasResourceCreator resourceCreator, [In] float x, [In] float y, [In] float radiusX, [In] float radiusY);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateCircle")]
		[DefaultOverload]
		CanvasGeometry CreateCircle([In] ICanvasResourceCreator resourceCreator, [In] Vector2 centerPoint, [In] float radius);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateCircleAtCoords")]
		CanvasGeometry CreateCircle([In] ICanvasResourceCreator resourceCreator, [In] float x, [In] float y, [In] float radius);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasGeometry CreatePath([In] CanvasPathBuilder pathBuilder);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasGeometry CreatePolygon([In] ICanvasResourceCreator resourceCreator, [In] Vector2[] points);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateGroup")]
		CanvasGeometry CreateGroup([In] ICanvasResourceCreator resourceCreator, [In] CanvasGeometry[] geometries);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("CreateGroupWithFilledRegionDetermination")]
		CanvasGeometry CreateGroup([In] ICanvasResourceCreator resourceCreator, [In] CanvasGeometry[] geometries, [In] CanvasFilledRegionDetermination filledRegionDetermination);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasGeometry CreateText([In] CanvasTextLayout textLayout);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasGeometry CreateGlyphRun([In] ICanvasResourceCreator resourceCreator, [In] Vector2 point, [In] CanvasFontFace fontFace, [In] float fontSize, [In] CanvasGlyph[] glyphs, [In] bool isSideways, [In] uint bidiLevel, [In] CanvasTextMeasuringMode measuringMode, [In] CanvasGlyphOrientation glyphOrientation);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateInk")]
		CanvasGeometry CreateInk([In] ICanvasResourceCreator resourceCreator, [In] IEnumerable<InkStroke> inkStrokes);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateInkWithTransformAndFlatteningTolerance")]
		[DefaultOverload]
		CanvasGeometry CreateInk([In] ICanvasResourceCreator resourceCreator, [In] IEnumerable<InkStroke> inkStrokes, [In] Matrix3x2 transform, [In] float flatteningTolerance);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("ComputeFlatteningTolerance")]
		float ComputeFlatteningTolerance([In] float dpi, [In] float maximumZoomFactor);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("ComputeFlatteningToleranceWithTransform")]
		float ComputeFlatteningTolerance([In] float dpi, [In] float maximumZoomFactor, [In] Matrix3x2 expectedGeometryTransform);

		float DefaultFlatteningTolerance
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
