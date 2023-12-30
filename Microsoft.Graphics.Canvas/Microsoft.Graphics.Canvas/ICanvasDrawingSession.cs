using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Graphics.Canvas.Brushes;
using Microsoft.Graphics.Canvas.Geometry;
using Microsoft.Graphics.Canvas.Svg;
using Microsoft.Graphics.Canvas.Text;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;
using Windows.UI;
using Windows.UI.Input.Inking;

namespace Microsoft.Graphics.Canvas
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(4127915273u, 58915, 19424, 183, 80, 87, 138, 169, 32, 177, 219)]
	[Version(167772160u)]
	[ExclusiveTo(typeof(CanvasDrawingSession))]
	internal interface ICanvasDrawingSession : IDisposable, ICanvasResourceCreatorWithDpi, ICanvasResourceCreator
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("Clear")]
		void Clear([In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("ClearHdr")]
		void Clear([In] Vector4 color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Flush();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawImageAtOrigin")]
		void DrawImage([In] ICanvasImage image);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawImageAtOffset")]
		void DrawImage([In] ICanvasImage image, [In] Vector2 offset);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawImageAtCoords")]
		void DrawImage([In] ICanvasImage image, [In] float x, [In] float y);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawImageToRect")]
		void DrawImage([In] CanvasBitmap bitmap, [In] Rect destinationRectangle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawImageAtOffsetWithSourceRect")]
		void DrawImage([In] ICanvasImage image, [In] Vector2 offset, [In] Rect sourceRectangle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawImageAtCoordsWithSourceRect")]
		void DrawImage([In] ICanvasImage image, [In] float x, [In] float y, [In] Rect sourceRectangle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawImageToRectWithSourceRect")]
		void DrawImage([In] ICanvasImage image, [In] Rect destinationRectangle, [In] Rect sourceRectangle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawImageAtOffsetWithSourceRectAndOpacity")]
		void DrawImage([In] ICanvasImage image, [In] Vector2 offset, [In] Rect sourceRectangle, [In] float opacity);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawImageAtCoordsWithSourceRectAndOpacity")]
		void DrawImage([In] ICanvasImage image, [In] float x, [In] float y, [In] Rect sourceRectangle, [In] float opacity);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawImageToRectWithSourceRectAndOpacity")]
		void DrawImage([In] ICanvasImage image, [In] Rect destinationRectangle, [In] Rect sourceRectangle, [In] float opacity);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawImageAtOffsetWithSourceRectAndOpacityAndInterpolation")]
		[DefaultOverload]
		void DrawImage([In] ICanvasImage image, [In] Vector2 offset, [In] Rect sourceRectangle, [In] float opacity, [In] CanvasImageInterpolation interpolation);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawImageAtCoordsWithSourceRectAndOpacityAndInterpolation")]
		void DrawImage([In] ICanvasImage image, [In] float x, [In] float y, [In] Rect sourceRectangle, [In] float opacity, [In] CanvasImageInterpolation interpolation);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawImageToRectWithSourceRectAndOpacityAndInterpolation")]
		void DrawImage([In] ICanvasImage image, [In] Rect destinationRectangle, [In] Rect sourceRectangle, [In] float opacity, [In] CanvasImageInterpolation interpolation);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawImageAtOffsetWithSourceRectAndOpacityAndInterpolationAndComposite")]
		void DrawImage([In] ICanvasImage image, [In] Vector2 offset, [In] Rect sourceRectangle, [In] float opacity, [In] CanvasImageInterpolation interpolation, [In] CanvasComposite composite);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawImageAtCoordsWithSourceRectAndOpacityAndInterpolationAndComposite")]
		[DefaultOverload]
		void DrawImage([In] ICanvasImage image, [In] float x, [In] float y, [In] Rect sourceRectangle, [In] float opacity, [In] CanvasImageInterpolation interpolation, [In] CanvasComposite composite);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawImageToRectWithSourceRectAndOpacityAndInterpolationAndComposite")]
		void DrawImage([In] ICanvasImage image, [In] Rect destinationRectangle, [In] Rect sourceRectangle, [In] float opacity, [In] CanvasImageInterpolation interpolation, [In] CanvasComposite composite);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawImageAtOffsetWithSourceRectAndOpacityAndInterpolationAndPerspective")]
		void DrawImage([In] CanvasBitmap bitmap, [In] Vector2 offset, [In] Rect sourceRectangle, [In] float opacity, [In] CanvasImageInterpolation interpolation, [In] Matrix4x4 perspective);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawImageAtCoordsWithSourceRectAndOpacityAndInterpolationAndPerspective")]
		void DrawImage([In] CanvasBitmap bitmap, [In] float x, [In] float y, [In] Rect sourceRectangle, [In] float opacity, [In] CanvasImageInterpolation interpolation, [In] Matrix4x4 perspective);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawImageToRectWithSourceRectAndOpacityAndInterpolationAndPerspective")]
		void DrawImage([In] CanvasBitmap bitmap, [In] Rect destinationRectangle, [In] Rect sourceRectangle, [In] float opacity, [In] CanvasImageInterpolation interpolation, [In] Matrix4x4 perspective);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawLineWithBrush")]
		[DefaultOverload]
		void DrawLine([In] Vector2 point0, [In] Vector2 point1, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawLineAtCoordsWithBrush")]
		void DrawLine([In] float x0, [In] float y0, [In] float x1, [In] float y1, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawLineWithColor")]
		void DrawLine([In] Vector2 point0, [In] Vector2 point1, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawLineAtCoordsWithColor")]
		void DrawLine([In] float x0, [In] float y0, [In] float x1, [In] float y1, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawLineWithBrushAndStrokeWidth")]
		void DrawLine([In] Vector2 point0, [In] Vector2 point1, [In] ICanvasBrush brush, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawLineAtCoordsWithBrushAndStrokeWidth")]
		void DrawLine([In] float x0, [In] float y0, [In] float x1, [In] float y1, [In] ICanvasBrush brush, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawLineWithColorAndStrokeWidth")]
		void DrawLine([In] Vector2 point0, [In] Vector2 point1, [In] Color color, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawLineAtCoordsWithColorAndStrokeWidth")]
		void DrawLine([In] float x0, [In] float y0, [In] float x1, [In] float y1, [In] Color color, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawLineWithBrushAndStrokeWidthAndStrokeStyle")]
		void DrawLine([In] Vector2 point0, [In] Vector2 point1, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawLineAtCoordsWithBrushAndStrokeWidthAndStrokeStyle")]
		void DrawLine([In] float x0, [In] float y0, [In] float x1, [In] float y1, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawLineWithColorAndStrokeWidthAndStrokeStyle")]
		void DrawLine([In] Vector2 point0, [In] Vector2 point1, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawLineAtCoordsWithColorAndStrokeWidthAndStrokeStyle")]
		void DrawLine([In] float x0, [In] float y0, [In] float x1, [In] float y1, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawRectangleWithBrush")]
		[DefaultOverload]
		void DrawRectangle([In] Rect rect, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawRectangleAtCoordsWithBrush")]
		void DrawRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawRectangleWithColor")]
		void DrawRectangle([In] Rect rect, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawRectangleAtCoordsWithColor")]
		void DrawRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawRectangleWithBrushAndStrokeWidth")]
		void DrawRectangle([In] Rect rect, [In] ICanvasBrush brush, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawRectangleAtCoordsWithBrushAndStrokeWidth")]
		void DrawRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] ICanvasBrush brush, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawRectangleWithColorAndStrokeWidth")]
		void DrawRectangle([In] Rect rect, [In] Color color, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawRectangleAtCoordsWithColorAndStrokeWidth")]
		void DrawRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] Color color, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawRectangleWithBrushAndStrokeWidthAndStrokeStyle")]
		void DrawRectangle([In] Rect rect, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawRectangleAtCoordsWithBrushAndStrokeWidthAndStrokeStyle")]
		void DrawRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawRectangleWithColorAndStrokeWidthAndStrokeStyle")]
		void DrawRectangle([In] Rect rect, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawRectangleAtCoordsWithColorAndStrokeWidthAndStrokeStyle")]
		void DrawRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("FillRectangleWithBrush")]
		[DefaultOverload]
		void FillRectangle([In] Rect rect, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("FillRectangleAtCoordsWithBrush")]
		[DefaultOverload]
		void FillRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("FillRectangleWithColor")]
		void FillRectangle([In] Rect rect, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("FillRectangleAtCoordsWithColor")]
		void FillRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("FillRectangleWithBrushAndOpacityBrush")]
		void FillRectangle([In] Rect rect, [In] ICanvasBrush brush, [In] ICanvasBrush opacityBrush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("FillRectangleAtCoordsWithBrushAndOpacityBrush")]
		void FillRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] ICanvasBrush brush, [In] ICanvasBrush opacityBrush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawRoundedRectangleWithBrush")]
		void DrawRoundedRectangle([In] Rect rect, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawRoundedRectangleAtCoordsWithBrush")]
		[DefaultOverload]
		void DrawRoundedRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawRoundedRectangleWithColor")]
		void DrawRoundedRectangle([In] Rect rect, [In] float radiusX, [In] float radiusY, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawRoundedRectangleAtCoordsWithColor")]
		void DrawRoundedRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] float radiusX, [In] float radiusY, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawRoundedRectangleWithBrushAndStrokeWidth")]
		void DrawRoundedRectangle([In] Rect rect, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawRoundedRectangleAtCoordsWithBrushAndStrokeWidth")]
		void DrawRoundedRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawRoundedRectangleWithColorAndStrokeWidth")]
		void DrawRoundedRectangle([In] Rect rect, [In] float radiusX, [In] float radiusY, [In] Color color, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawRoundedRectangleAtCoordsWithColorAndStrokeWidth")]
		void DrawRoundedRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] float radiusX, [In] float radiusY, [In] Color color, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawRoundedRectangleWithBrushAndStrokeWidthAndStrokeStyle")]
		[DefaultOverload]
		void DrawRoundedRectangle([In] Rect rect, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawRoundedRectangleAtCoordsWithBrushAndStrokeWidthAndStrokeStyle")]
		void DrawRoundedRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawRoundedRectangleWithColorAndStrokeWidthAndStrokeStyle")]
		void DrawRoundedRectangle([In] Rect rect, [In] float radiusX, [In] float radiusY, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawRoundedRectangleAtCoordsWithColorAndStrokeWidthAndStrokeStyle")]
		void DrawRoundedRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] float radiusX, [In] float radiusY, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("FillRoundedRectangleWithBrush")]
		void FillRoundedRectangle([In] Rect rect, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("FillRoundedRectangleAtCoordsWithBrush")]
		void FillRoundedRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("FillRoundedRectangleWithColor")]
		void FillRoundedRectangle([In] Rect rect, [In] float radiusX, [In] float radiusY, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("FillRoundedRectangleAtCoordsWithColor")]
		void FillRoundedRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] float radiusX, [In] float radiusY, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawEllipseWithBrush")]
		[DefaultOverload]
		void DrawEllipse([In] Vector2 centerPoint, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawEllipseAtCoordsWithBrush")]
		void DrawEllipse([In] float x, [In] float y, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawEllipseWithColor")]
		void DrawEllipse([In] Vector2 centerPoint, [In] float radiusX, [In] float radiusY, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawEllipseAtCoordsWithColor")]
		void DrawEllipse([In] float x, [In] float y, [In] float radiusX, [In] float radiusY, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawEllipseWithBrushAndStrokeWidth")]
		[DefaultOverload]
		void DrawEllipse([In] Vector2 centerPoint, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawEllipseAtCoordsWithBrushAndStrokeWidth")]
		void DrawEllipse([In] float x, [In] float y, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawEllipseWithColorAndStrokeWidth")]
		void DrawEllipse([In] Vector2 centerPoint, [In] float radiusX, [In] float radiusY, [In] Color color, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawEllipseAtCoordsWithColorAndStrokeWidth")]
		void DrawEllipse([In] float x, [In] float y, [In] float radiusX, [In] float radiusY, [In] Color color, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawEllipseWithBrushAndStrokeWidthAndStrokeStyle")]
		[DefaultOverload]
		void DrawEllipse([In] Vector2 centerPoint, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawEllipseAtCoordsWithBrushAndStrokeWidthAndStrokeStyle")]
		[DefaultOverload]
		void DrawEllipse([In] float x, [In] float y, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawEllipseWithColorAndStrokeWidthAndStrokeStyle")]
		void DrawEllipse([In] Vector2 centerPoint, [In] float radiusX, [In] float radiusY, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawEllipseAtCoordsWithColorAndStrokeWidthAndStrokeStyle")]
		void DrawEllipse([In] float x, [In] float y, [In] float radiusX, [In] float radiusY, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("FillEllipseWithBrush")]
		void FillEllipse([In] Vector2 centerPoint, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("FillEllipseAtCoordsWithBrush")]
		[DefaultOverload]
		void FillEllipse([In] float x, [In] float y, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("FillEllipseWithColor")]
		void FillEllipse([In] Vector2 centerPoint, [In] float radiusX, [In] float radiusY, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("FillEllipseAtCoordsWithColor")]
		void FillEllipse([In] float x, [In] float y, [In] float radiusX, [In] float radiusY, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawCircleWithBrush")]
		[DefaultOverload]
		void DrawCircle([In] Vector2 centerPoint, [In] float radius, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawCircleAtCoordsWithBrush")]
		void DrawCircle([In] float x, [In] float y, [In] float radius, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawCircleWithColor")]
		void DrawCircle([In] Vector2 centerPoint, [In] float radius, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawCircleAtCoordsWithColor")]
		void DrawCircle([In] float x, [In] float y, [In] float radius, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawCircleWithBrushAndStrokeWidth")]
		void DrawCircle([In] Vector2 centerPoint, [In] float radius, [In] ICanvasBrush brush, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawCircleAtCoordsWithBrushAndStrokeWidth")]
		void DrawCircle([In] float x, [In] float y, [In] float radius, [In] ICanvasBrush brush, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawCircleWithColorAndStrokeWidth")]
		void DrawCircle([In] Vector2 centerPoint, [In] float radius, [In] Color color, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawCircleAtCoordsWithColorAndStrokeWidth")]
		void DrawCircle([In] float x, [In] float y, [In] float radius, [In] Color color, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawCircleWithBrushAndStrokeWidthAndStrokeStyle")]
		void DrawCircle([In] Vector2 centerPoint, [In] float radius, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawCircleAtCoordsWithBrushAndStrokeWidthAndStrokeStyle")]
		void DrawCircle([In] float x, [In] float y, [In] float radius, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawCircleWithColorAndStrokeWidthAndStrokeStyle")]
		void DrawCircle([In] Vector2 centerPoint, [In] float radius, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawCircleAtCoordsWithColorAndStrokeWidthAndStrokeStyle")]
		void DrawCircle([In] float x, [In] float y, [In] float radius, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("FillCircleWithBrush")]
		void FillCircle([In] Vector2 centerPoint, [In] float radius, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("FillCircleAtCoordsWithBrush")]
		void FillCircle([In] float x, [In] float y, [In] float radius, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("FillCircleWithColor")]
		void FillCircle([In] Vector2 centerPoint, [In] float radius, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("FillCircleAtCoordsWithColor")]
		void FillCircle([In] float x, [In] float y, [In] float radius, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawTextAtPointWithColor")]
		void DrawText([In] string text, [In] Vector2 point, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawTextAtPointCoordsWithColor")]
		void DrawText([In] string text, [In] float x, [In] float y, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawTextAtPointWithBrushAndFormat")]
		void DrawText([In] string text, [In] Vector2 point, [In] ICanvasBrush brush, [In] CanvasTextFormat format);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawTextAtRectWithBrushAndFormat")]
		void DrawText([In] string text, [In] Rect rectangle, [In] ICanvasBrush brush, [In] CanvasTextFormat format);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawTextAtPointCoordsWithBrushAndFormat")]
		void DrawText([In] string text, [In] float x, [In] float y, [In] ICanvasBrush brush, [In] CanvasTextFormat format);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawTextAtRectCoordsWithBrushAndFormat")]
		void DrawText([In] string text, [In] float x, [In] float y, [In] float w, [In] float h, [In] ICanvasBrush brush, [In] CanvasTextFormat format);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawTextAtPointWithColorAndFormat")]
		void DrawText([In] string text, [In] Vector2 point, [In] Color color, [In] CanvasTextFormat format);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawTextAtRectWithColorAndFormat")]
		void DrawText([In] string text, [In] Rect rectangle, [In] Color color, [In] CanvasTextFormat format);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawTextAtPointCoordsWithColorAndFormat")]
		void DrawText([In] string text, [In] float x, [In] float y, [In] Color color, [In] CanvasTextFormat format);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawTextAtRectCoordsWithColorAndFormat")]
		void DrawText([In] string text, [In] float x, [In] float y, [In] float w, [In] float h, [In] Color color, [In] CanvasTextFormat format);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawGeometryWithBrush")]
		[DefaultOverload]
		void DrawGeometry([In] CanvasGeometry geometry, [In] Vector2 offset, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawGeometryWithColor")]
		void DrawGeometry([In] CanvasGeometry geometry, [In] Vector2 offset, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawGeometryAtCoordsWithBrush")]
		void DrawGeometry([In] CanvasGeometry geometry, [In] float x, [In] float y, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawGeometryAtCoordsWithColor")]
		void DrawGeometry([In] CanvasGeometry geometry, [In] float x, [In] float y, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawGeometryAtOriginWithBrush")]
		void DrawGeometry([In] CanvasGeometry geometry, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawGeometryAtOriginWithColor")]
		void DrawGeometry([In] CanvasGeometry geometry, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawGeometryWithBrushAndStrokeWidth")]
		void DrawGeometry([In] CanvasGeometry geometry, [In] Vector2 offset, [In] ICanvasBrush brush, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawGeometryWithColorAndStrokeWidth")]
		void DrawGeometry([In] CanvasGeometry geometry, [In] Vector2 offset, [In] Color color, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawGeometryAtCoordsWithBrushAndStrokeWidth")]
		void DrawGeometry([In] CanvasGeometry geometry, [In] float x, [In] float y, [In] ICanvasBrush brush, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawGeometryAtCoordsWithColorAndStrokeWidth")]
		void DrawGeometry([In] CanvasGeometry geometry, [In] float x, [In] float y, [In] Color color, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawGeometryAtOriginWithBrushAndStrokeWidth")]
		void DrawGeometry([In] CanvasGeometry geometry, [In] ICanvasBrush brush, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawGeometryAtOriginWithColorAndStrokeWidth")]
		void DrawGeometry([In] CanvasGeometry geometry, [In] Color color, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawGeometryWithBrushAndStrokeWidthAndStrokeStyle")]
		void DrawGeometry([In] CanvasGeometry geometry, [In] Vector2 offset, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawGeometryWithColorAndStrokeWidthAndStrokeStyle")]
		void DrawGeometry([In] CanvasGeometry geometry, [In] Vector2 offset, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawGeometryAtCoordsWithBrushAndStrokeWidthAndStrokeStyle")]
		void DrawGeometry([In] CanvasGeometry geometry, [In] float x, [In] float y, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawGeometryAtCoordsWithColorAndStrokeWidthAndStrokeStyle")]
		void DrawGeometry([In] CanvasGeometry geometry, [In] float x, [In] float y, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawGeometryAtOriginWithBrushAndStrokeWidthAndStrokeStyle")]
		void DrawGeometry([In] CanvasGeometry geometry, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawGeometryAtOriginWithColorAndStrokeWidthAndStrokeStyle")]
		void DrawGeometry([In] CanvasGeometry geometry, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("FillGeometryWithBrush")]
		void FillGeometry([In] CanvasGeometry geometry, [In] Vector2 offset, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("FillGeometryWithBrushAndOpacityBrush")]
		void FillGeometry([In] CanvasGeometry geometry, [In] Vector2 offset, [In] ICanvasBrush brush, [In] ICanvasBrush opacityBrush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("FillGeometryWithColor")]
		void FillGeometry([In] CanvasGeometry geometry, [In] Vector2 offset, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("FillGeometryAtCoordsWithBrush")]
		[DefaultOverload]
		void FillGeometry([In] CanvasGeometry geometry, [In] float x, [In] float y, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("FillGeometryAtCoordsWithBrushAndOpacityBrush")]
		void FillGeometry([In] CanvasGeometry geometry, [In] float x, [In] float y, [In] ICanvasBrush brush, [In] ICanvasBrush opacityBrush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("FillGeometryAtCoordsWithColor")]
		void FillGeometry([In] CanvasGeometry geometry, [In] float x, [In] float y, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("FillGeometryAtOriginWithBrush")]
		void FillGeometry([In] CanvasGeometry geometry, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("FillGeometryAtOriginWithBrushAndOpacityBrush")]
		void FillGeometry([In] CanvasGeometry geometry, [In] ICanvasBrush brush, [In] ICanvasBrush opacityBrush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("FillGeometryAtOriginWithColor")]
		void FillGeometry([In] CanvasGeometry geometry, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawCachedGeometryWithBrush")]
		[DefaultOverload]
		void DrawCachedGeometry([In] CanvasCachedGeometry geometry, [In] Vector2 offset, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawCachedGeometryWithColor")]
		void DrawCachedGeometry([In] CanvasCachedGeometry geometry, [In] Vector2 offset, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawCachedGeometryAtCoordsWithBrush")]
		void DrawCachedGeometry([In] CanvasCachedGeometry geometry, [In] float x, [In] float y, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawCachedGeometryAtCoordsWithColor")]
		void DrawCachedGeometry([In] CanvasCachedGeometry geometry, [In] float x, [In] float y, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawCachedGeometryAtOriginWithBrush")]
		void DrawCachedGeometry([In] CanvasCachedGeometry geometry, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawCachedGeometryAtOriginWithColor")]
		void DrawCachedGeometry([In] CanvasCachedGeometry geometry, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawTextLayoutWithBrush")]
		void DrawTextLayout([In] CanvasTextLayout textLayout, [In] Vector2 point, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawTextLayoutAtCoordsWithBrush")]
		void DrawTextLayout([In] CanvasTextLayout textLayout, [In] float x, [In] float y, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawTextLayoutWithColor")]
		void DrawTextLayout([In] CanvasTextLayout textLayout, [In] Vector2 point, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawTextLayoutAtCoordsWithColor")]
		void DrawTextLayout([In] CanvasTextLayout textLayout, [In] float x, [In] float y, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawInk")]
		void DrawInk([In] IEnumerable<InkStroke> inkStrokes);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawInkWithHighContrast")]
		[DefaultOverload]
		void DrawInk([In] IEnumerable<InkStroke> inkStrokes, [In] bool highContrast);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawGradientMeshAtOrigin")]
		void DrawGradientMesh([In] CanvasGradientMesh gradientMesh);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawGradientMesh")]
		void DrawGradientMesh([In] CanvasGradientMesh gradientMesh, [In] Vector2 point);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawGradientMeshAtCoords")]
		void DrawGradientMesh([In] CanvasGradientMesh gradientMesh, [In] float x, [In] float y);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawSvgAtOrigin")]
		void DrawSvg([In] CanvasSvgDocument svgDocument, [In] Size viewportSize);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawSvgAtPoint")]
		void DrawSvg([In] CanvasSvgDocument svgDocument, [In] Size viewportSize, [In] Vector2 point);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawSvgAtCoords")]
		void DrawSvg([In] CanvasSvgDocument svgDocument, [In] Size viewportSize, [In] float x, [In] float y);

		CanvasAntialiasing Antialiasing
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		CanvasBlend Blend
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		CanvasTextAntialiasing TextAntialiasing
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		CanvasTextRenderingParameters TextRenderingParameters
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		Matrix3x2 Transform
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		CanvasUnits Units
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		CanvasBufferPrecision? EffectBufferPrecision
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		BitmapSize EffectTileSize
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateLayerWithOpacity")]
		CanvasActiveLayer CreateLayer([In] float opacity);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("CreateLayerWithOpacityBrush")]
		CanvasActiveLayer CreateLayer([In] ICanvasBrush opacityBrush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateLayerWithOpacityAndClipRectangle")]
		CanvasActiveLayer CreateLayer([In] float opacity, [In] Rect clipRectangle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateLayerWithOpacityBrushAndClipRectangle")]
		CanvasActiveLayer CreateLayer([In] ICanvasBrush opacityBrush, [In] Rect clipRectangle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateLayerWithOpacityAndClipGeometry")]
		CanvasActiveLayer CreateLayer([In] float opacity, [In] CanvasGeometry clipGeometry);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("CreateLayerWithOpacityBrushAndClipGeometry")]
		CanvasActiveLayer CreateLayer([In] ICanvasBrush opacityBrush, [In] CanvasGeometry clipGeometry);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateLayerWithOpacityAndClipGeometryAndTransform")]
		CanvasActiveLayer CreateLayer([In] float opacity, [In] CanvasGeometry clipGeometry, [In] Matrix3x2 geometryTransform);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("CreateLayerWithOpacityBrushAndClipGeometryAndTransform")]
		CanvasActiveLayer CreateLayer([In] ICanvasBrush opacityBrush, [In] CanvasGeometry clipGeometry, [In] Matrix3x2 geometryTransform);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateLayerWithAllOptions")]
		CanvasActiveLayer CreateLayer([In] float opacity, [In] ICanvasBrush opacityBrush, [In] Rect clipRectangle, [In] CanvasGeometry clipGeometry, [In] Matrix3x2 geometryTransform, [In] CanvasLayerOptions options);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawGlyphRun")]
		void DrawGlyphRun([In] Vector2 point, [In] CanvasFontFace fontFace, [In] float fontSize, [In] CanvasGlyph[] glyphs, [In] bool isSideways, [In] uint bidiLevel, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawGlyphRunWithMeasuringMode")]
		void DrawGlyphRun([In] Vector2 point, [In] CanvasFontFace fontFace, [In] float fontSize, [In] CanvasGlyph[] glyphs, [In] bool isSideways, [In] uint bidiLevel, [In] ICanvasBrush brush, [In] CanvasTextMeasuringMode measuringMode);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawGlyphRunWithMeasuringModeAndDescription")]
		void DrawGlyphRun([In] Vector2 point, [In] CanvasFontFace fontFace, [In] float fontSize, [In] CanvasGlyph[] glyphs, [In] bool isSideways, [In] uint bidiLevel, [In] ICanvasBrush brush, [In] CanvasTextMeasuringMode measuringMode, [In] string localeName, [In] string textString, [In] int[] clusterMapIndices, [In] uint textPosition);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateSpriteBatch")]
		CanvasSpriteBatch CreateSpriteBatch();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateSpriteBatchWithSortMode")]
		CanvasSpriteBatch CreateSpriteBatch([In] CanvasSpriteSortMode sortMode);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateSpriteBatchWithSortModeAndInterpolation")]
		CanvasSpriteBatch CreateSpriteBatch([In] CanvasSpriteSortMode sortMode, [In] CanvasImageInterpolation interpolation);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateSpriteBatchWithSortModeAndInterpolationAndOptions")]
		CanvasSpriteBatch CreateSpriteBatch([In] CanvasSpriteSortMode sortMode, [In] CanvasImageInterpolation interpolation, [In] CanvasSpriteOptions options);
	}
}
