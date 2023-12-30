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
	[MarshalingBehavior(MarshalingType.Agile)]
	[Version(167772160u)]
	[Threading(ThreadingModel.Both)]
	public sealed class CanvasDrawingSession : ICanvasDrawingSession, ICanvasResourceCreatorWithDpi, ICanvasResourceCreator, IDisposable
	{
		public extern CanvasUnits Units
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern Matrix3x2 Transform
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern CanvasTextRenderingParameters TextRenderingParameters
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern CanvasTextAntialiasing TextAntialiasing
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern BitmapSize EffectTileSize
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern CanvasBufferPrecision? EffectBufferPrecision
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern CanvasBlend Blend
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern CanvasAntialiasing Antialiasing
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

		public extern float Dpi
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("Clear")]
		public extern void Clear([In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("ClearHdr")]
		public extern void Clear([In] Vector4 color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void Flush();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawImageAtOrigin")]
		public extern void DrawImage([In] ICanvasImage image);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawImageAtOffset")]
		public extern void DrawImage([In] ICanvasImage image, [In] Vector2 offset);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawImageAtCoords")]
		public extern void DrawImage([In] ICanvasImage image, [In] float x, [In] float y);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawImageToRect")]
		public extern void DrawImage([In] CanvasBitmap bitmap, [In] Rect destinationRectangle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawImageAtOffsetWithSourceRect")]
		public extern void DrawImage([In] ICanvasImage image, [In] Vector2 offset, [In] Rect sourceRectangle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawImageAtCoordsWithSourceRect")]
		public extern void DrawImage([In] ICanvasImage image, [In] float x, [In] float y, [In] Rect sourceRectangle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawImageToRectWithSourceRect")]
		public extern void DrawImage([In] ICanvasImage image, [In] Rect destinationRectangle, [In] Rect sourceRectangle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawImageAtOffsetWithSourceRectAndOpacity")]
		[DefaultOverload]
		public extern void DrawImage([In] ICanvasImage image, [In] Vector2 offset, [In] Rect sourceRectangle, [In] float opacity);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawImageAtCoordsWithSourceRectAndOpacity")]
		public extern void DrawImage([In] ICanvasImage image, [In] float x, [In] float y, [In] Rect sourceRectangle, [In] float opacity);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawImageToRectWithSourceRectAndOpacity")]
		public extern void DrawImage([In] ICanvasImage image, [In] Rect destinationRectangle, [In] Rect sourceRectangle, [In] float opacity);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawImageAtOffsetWithSourceRectAndOpacityAndInterpolation")]
		[DefaultOverload]
		public extern void DrawImage([In] ICanvasImage image, [In] Vector2 offset, [In] Rect sourceRectangle, [In] float opacity, [In] CanvasImageInterpolation interpolation);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawImageAtCoordsWithSourceRectAndOpacityAndInterpolation")]
		public extern void DrawImage([In] ICanvasImage image, [In] float x, [In] float y, [In] Rect sourceRectangle, [In] float opacity, [In] CanvasImageInterpolation interpolation);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawImageToRectWithSourceRectAndOpacityAndInterpolation")]
		public extern void DrawImage([In] ICanvasImage image, [In] Rect destinationRectangle, [In] Rect sourceRectangle, [In] float opacity, [In] CanvasImageInterpolation interpolation);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawImageAtOffsetWithSourceRectAndOpacityAndInterpolationAndComposite")]
		public extern void DrawImage([In] ICanvasImage image, [In] Vector2 offset, [In] Rect sourceRectangle, [In] float opacity, [In] CanvasImageInterpolation interpolation, [In] CanvasComposite composite);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawImageAtCoordsWithSourceRectAndOpacityAndInterpolationAndComposite")]
		[DefaultOverload]
		public extern void DrawImage([In] ICanvasImage image, [In] float x, [In] float y, [In] Rect sourceRectangle, [In] float opacity, [In] CanvasImageInterpolation interpolation, [In] CanvasComposite composite);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawImageToRectWithSourceRectAndOpacityAndInterpolationAndComposite")]
		public extern void DrawImage([In] ICanvasImage image, [In] Rect destinationRectangle, [In] Rect sourceRectangle, [In] float opacity, [In] CanvasImageInterpolation interpolation, [In] CanvasComposite composite);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawImageAtOffsetWithSourceRectAndOpacityAndInterpolationAndPerspective")]
		public extern void DrawImage([In] CanvasBitmap bitmap, [In] Vector2 offset, [In] Rect sourceRectangle, [In] float opacity, [In] CanvasImageInterpolation interpolation, [In] Matrix4x4 perspective);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawImageAtCoordsWithSourceRectAndOpacityAndInterpolationAndPerspective")]
		public extern void DrawImage([In] CanvasBitmap bitmap, [In] float x, [In] float y, [In] Rect sourceRectangle, [In] float opacity, [In] CanvasImageInterpolation interpolation, [In] Matrix4x4 perspective);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawImageToRectWithSourceRectAndOpacityAndInterpolationAndPerspective")]
		public extern void DrawImage([In] CanvasBitmap bitmap, [In] Rect destinationRectangle, [In] Rect sourceRectangle, [In] float opacity, [In] CanvasImageInterpolation interpolation, [In] Matrix4x4 perspective);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawLineWithBrush")]
		[DefaultOverload]
		public extern void DrawLine([In] Vector2 point0, [In] Vector2 point1, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawLineAtCoordsWithBrush")]
		public extern void DrawLine([In] float x0, [In] float y0, [In] float x1, [In] float y1, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawLineWithColor")]
		public extern void DrawLine([In] Vector2 point0, [In] Vector2 point1, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawLineAtCoordsWithColor")]
		public extern void DrawLine([In] float x0, [In] float y0, [In] float x1, [In] float y1, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawLineWithBrushAndStrokeWidth")]
		public extern void DrawLine([In] Vector2 point0, [In] Vector2 point1, [In] ICanvasBrush brush, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawLineAtCoordsWithBrushAndStrokeWidth")]
		[DefaultOverload]
		public extern void DrawLine([In] float x0, [In] float y0, [In] float x1, [In] float y1, [In] ICanvasBrush brush, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawLineWithColorAndStrokeWidth")]
		public extern void DrawLine([In] Vector2 point0, [In] Vector2 point1, [In] Color color, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawLineAtCoordsWithColorAndStrokeWidth")]
		public extern void DrawLine([In] float x0, [In] float y0, [In] float x1, [In] float y1, [In] Color color, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawLineWithBrushAndStrokeWidthAndStrokeStyle")]
		public extern void DrawLine([In] Vector2 point0, [In] Vector2 point1, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawLineAtCoordsWithBrushAndStrokeWidthAndStrokeStyle")]
		[DefaultOverload]
		public extern void DrawLine([In] float x0, [In] float y0, [In] float x1, [In] float y1, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawLineWithColorAndStrokeWidthAndStrokeStyle")]
		public extern void DrawLine([In] Vector2 point0, [In] Vector2 point1, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawLineAtCoordsWithColorAndStrokeWidthAndStrokeStyle")]
		public extern void DrawLine([In] float x0, [In] float y0, [In] float x1, [In] float y1, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawRectangleWithBrush")]
		public extern void DrawRectangle([In] Rect rect, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawRectangleAtCoordsWithBrush")]
		public extern void DrawRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawRectangleWithColor")]
		public extern void DrawRectangle([In] Rect rect, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawRectangleAtCoordsWithColor")]
		public extern void DrawRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawRectangleWithBrushAndStrokeWidth")]
		[DefaultOverload]
		public extern void DrawRectangle([In] Rect rect, [In] ICanvasBrush brush, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawRectangleAtCoordsWithBrushAndStrokeWidth")]
		public extern void DrawRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] ICanvasBrush brush, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawRectangleWithColorAndStrokeWidth")]
		public extern void DrawRectangle([In] Rect rect, [In] Color color, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawRectangleAtCoordsWithColorAndStrokeWidth")]
		public extern void DrawRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] Color color, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawRectangleWithBrushAndStrokeWidthAndStrokeStyle")]
		[DefaultOverload]
		public extern void DrawRectangle([In] Rect rect, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawRectangleAtCoordsWithBrushAndStrokeWidthAndStrokeStyle")]
		[DefaultOverload]
		public extern void DrawRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawRectangleWithColorAndStrokeWidthAndStrokeStyle")]
		public extern void DrawRectangle([In] Rect rect, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawRectangleAtCoordsWithColorAndStrokeWidthAndStrokeStyle")]
		public extern void DrawRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("FillRectangleWithBrush")]
		[DefaultOverload]
		public extern void FillRectangle([In] Rect rect, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("FillRectangleAtCoordsWithBrush")]
		public extern void FillRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("FillRectangleWithColor")]
		public extern void FillRectangle([In] Rect rect, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("FillRectangleAtCoordsWithColor")]
		public extern void FillRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("FillRectangleWithBrushAndOpacityBrush")]
		public extern void FillRectangle([In] Rect rect, [In] ICanvasBrush brush, [In] ICanvasBrush opacityBrush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("FillRectangleAtCoordsWithBrushAndOpacityBrush")]
		public extern void FillRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] ICanvasBrush brush, [In] ICanvasBrush opacityBrush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawRoundedRectangleWithBrush")]
		public extern void DrawRoundedRectangle([In] Rect rect, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawRoundedRectangleAtCoordsWithBrush")]
		public extern void DrawRoundedRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawRoundedRectangleWithColor")]
		public extern void DrawRoundedRectangle([In] Rect rect, [In] float radiusX, [In] float radiusY, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawRoundedRectangleAtCoordsWithColor")]
		public extern void DrawRoundedRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] float radiusX, [In] float radiusY, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawRoundedRectangleWithBrushAndStrokeWidth")]
		public extern void DrawRoundedRectangle([In] Rect rect, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawRoundedRectangleAtCoordsWithBrushAndStrokeWidth")]
		public extern void DrawRoundedRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawRoundedRectangleWithColorAndStrokeWidth")]
		public extern void DrawRoundedRectangle([In] Rect rect, [In] float radiusX, [In] float radiusY, [In] Color color, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawRoundedRectangleAtCoordsWithColorAndStrokeWidth")]
		public extern void DrawRoundedRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] float radiusX, [In] float radiusY, [In] Color color, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawRoundedRectangleWithBrushAndStrokeWidthAndStrokeStyle")]
		[DefaultOverload]
		public extern void DrawRoundedRectangle([In] Rect rect, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawRoundedRectangleAtCoordsWithBrushAndStrokeWidthAndStrokeStyle")]
		public extern void DrawRoundedRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawRoundedRectangleWithColorAndStrokeWidthAndStrokeStyle")]
		public extern void DrawRoundedRectangle([In] Rect rect, [In] float radiusX, [In] float radiusY, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawRoundedRectangleAtCoordsWithColorAndStrokeWidthAndStrokeStyle")]
		public extern void DrawRoundedRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] float radiusX, [In] float radiusY, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("FillRoundedRectangleWithBrush")]
		[DefaultOverload]
		public extern void FillRoundedRectangle([In] Rect rect, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("FillRoundedRectangleAtCoordsWithBrush")]
		[DefaultOverload]
		public extern void FillRoundedRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("FillRoundedRectangleWithColor")]
		public extern void FillRoundedRectangle([In] Rect rect, [In] float radiusX, [In] float radiusY, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("FillRoundedRectangleAtCoordsWithColor")]
		public extern void FillRoundedRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] float radiusX, [In] float radiusY, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawEllipseWithBrush")]
		public extern void DrawEllipse([In] Vector2 centerPoint, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawEllipseAtCoordsWithBrush")]
		public extern void DrawEllipse([In] float x, [In] float y, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawEllipseWithColor")]
		public extern void DrawEllipse([In] Vector2 centerPoint, [In] float radiusX, [In] float radiusY, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawEllipseAtCoordsWithColor")]
		public extern void DrawEllipse([In] float x, [In] float y, [In] float radiusX, [In] float radiusY, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawEllipseWithBrushAndStrokeWidth")]
		public extern void DrawEllipse([In] Vector2 centerPoint, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawEllipseAtCoordsWithBrushAndStrokeWidth")]
		public extern void DrawEllipse([In] float x, [In] float y, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawEllipseWithColorAndStrokeWidth")]
		public extern void DrawEllipse([In] Vector2 centerPoint, [In] float radiusX, [In] float radiusY, [In] Color color, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawEllipseAtCoordsWithColorAndStrokeWidth")]
		public extern void DrawEllipse([In] float x, [In] float y, [In] float radiusX, [In] float radiusY, [In] Color color, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawEllipseWithBrushAndStrokeWidthAndStrokeStyle")]
		public extern void DrawEllipse([In] Vector2 centerPoint, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawEllipseAtCoordsWithBrushAndStrokeWidthAndStrokeStyle")]
		[DefaultOverload]
		public extern void DrawEllipse([In] float x, [In] float y, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawEllipseWithColorAndStrokeWidthAndStrokeStyle")]
		public extern void DrawEllipse([In] Vector2 centerPoint, [In] float radiusX, [In] float radiusY, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawEllipseAtCoordsWithColorAndStrokeWidthAndStrokeStyle")]
		public extern void DrawEllipse([In] float x, [In] float y, [In] float radiusX, [In] float radiusY, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("FillEllipseWithBrush")]
		[DefaultOverload]
		public extern void FillEllipse([In] Vector2 centerPoint, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("FillEllipseAtCoordsWithBrush")]
		public extern void FillEllipse([In] float x, [In] float y, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("FillEllipseWithColor")]
		public extern void FillEllipse([In] Vector2 centerPoint, [In] float radiusX, [In] float radiusY, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("FillEllipseAtCoordsWithColor")]
		public extern void FillEllipse([In] float x, [In] float y, [In] float radiusX, [In] float radiusY, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawCircleWithBrush")]
		[DefaultOverload]
		public extern void DrawCircle([In] Vector2 centerPoint, [In] float radius, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawCircleAtCoordsWithBrush")]
		public extern void DrawCircle([In] float x, [In] float y, [In] float radius, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawCircleWithColor")]
		public extern void DrawCircle([In] Vector2 centerPoint, [In] float radius, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawCircleAtCoordsWithColor")]
		public extern void DrawCircle([In] float x, [In] float y, [In] float radius, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawCircleWithBrushAndStrokeWidth")]
		public extern void DrawCircle([In] Vector2 centerPoint, [In] float radius, [In] ICanvasBrush brush, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawCircleAtCoordsWithBrushAndStrokeWidth")]
		public extern void DrawCircle([In] float x, [In] float y, [In] float radius, [In] ICanvasBrush brush, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawCircleWithColorAndStrokeWidth")]
		public extern void DrawCircle([In] Vector2 centerPoint, [In] float radius, [In] Color color, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawCircleAtCoordsWithColorAndStrokeWidth")]
		public extern void DrawCircle([In] float x, [In] float y, [In] float radius, [In] Color color, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawCircleWithBrushAndStrokeWidthAndStrokeStyle")]
		public extern void DrawCircle([In] Vector2 centerPoint, [In] float radius, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawCircleAtCoordsWithBrushAndStrokeWidthAndStrokeStyle")]
		public extern void DrawCircle([In] float x, [In] float y, [In] float radius, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawCircleWithColorAndStrokeWidthAndStrokeStyle")]
		public extern void DrawCircle([In] Vector2 centerPoint, [In] float radius, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawCircleAtCoordsWithColorAndStrokeWidthAndStrokeStyle")]
		public extern void DrawCircle([In] float x, [In] float y, [In] float radius, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("FillCircleWithBrush")]
		[DefaultOverload]
		public extern void FillCircle([In] Vector2 centerPoint, [In] float radius, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("FillCircleAtCoordsWithBrush")]
		public extern void FillCircle([In] float x, [In] float y, [In] float radius, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("FillCircleWithColor")]
		public extern void FillCircle([In] Vector2 centerPoint, [In] float radius, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("FillCircleAtCoordsWithColor")]
		public extern void FillCircle([In] float x, [In] float y, [In] float radius, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawTextAtPointWithColor")]
		public extern void DrawText([In] string text, [In] Vector2 point, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawTextAtPointCoordsWithColor")]
		public extern void DrawText([In] string text, [In] float x, [In] float y, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawTextAtPointWithBrushAndFormat")]
		public extern void DrawText([In] string text, [In] Vector2 point, [In] ICanvasBrush brush, [In] CanvasTextFormat format);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawTextAtRectWithBrushAndFormat")]
		[DefaultOverload]
		public extern void DrawText([In] string text, [In] Rect rectangle, [In] ICanvasBrush brush, [In] CanvasTextFormat format);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawTextAtPointCoordsWithBrushAndFormat")]
		public extern void DrawText([In] string text, [In] float x, [In] float y, [In] ICanvasBrush brush, [In] CanvasTextFormat format);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawTextAtRectCoordsWithBrushAndFormat")]
		[DefaultOverload]
		public extern void DrawText([In] string text, [In] float x, [In] float y, [In] float w, [In] float h, [In] ICanvasBrush brush, [In] CanvasTextFormat format);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawTextAtPointWithColorAndFormat")]
		public extern void DrawText([In] string text, [In] Vector2 point, [In] Color color, [In] CanvasTextFormat format);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawTextAtRectWithColorAndFormat")]
		public extern void DrawText([In] string text, [In] Rect rectangle, [In] Color color, [In] CanvasTextFormat format);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawTextAtPointCoordsWithColorAndFormat")]
		public extern void DrawText([In] string text, [In] float x, [In] float y, [In] Color color, [In] CanvasTextFormat format);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawTextAtRectCoordsWithColorAndFormat")]
		public extern void DrawText([In] string text, [In] float x, [In] float y, [In] float w, [In] float h, [In] Color color, [In] CanvasTextFormat format);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawGeometryWithBrush")]
		[DefaultOverload]
		public extern void DrawGeometry([In] CanvasGeometry geometry, [In] Vector2 offset, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawGeometryWithColor")]
		public extern void DrawGeometry([In] CanvasGeometry geometry, [In] Vector2 offset, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawGeometryAtCoordsWithBrush")]
		public extern void DrawGeometry([In] CanvasGeometry geometry, [In] float x, [In] float y, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawGeometryAtCoordsWithColor")]
		public extern void DrawGeometry([In] CanvasGeometry geometry, [In] float x, [In] float y, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawGeometryAtOriginWithBrush")]
		[DefaultOverload]
		public extern void DrawGeometry([In] CanvasGeometry geometry, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawGeometryAtOriginWithColor")]
		public extern void DrawGeometry([In] CanvasGeometry geometry, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawGeometryWithBrushAndStrokeWidth")]
		[DefaultOverload]
		public extern void DrawGeometry([In] CanvasGeometry geometry, [In] Vector2 offset, [In] ICanvasBrush brush, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawGeometryWithColorAndStrokeWidth")]
		public extern void DrawGeometry([In] CanvasGeometry geometry, [In] Vector2 offset, [In] Color color, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawGeometryAtCoordsWithBrushAndStrokeWidth")]
		public extern void DrawGeometry([In] CanvasGeometry geometry, [In] float x, [In] float y, [In] ICanvasBrush brush, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawGeometryAtCoordsWithColorAndStrokeWidth")]
		public extern void DrawGeometry([In] CanvasGeometry geometry, [In] float x, [In] float y, [In] Color color, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawGeometryAtOriginWithBrushAndStrokeWidth")]
		public extern void DrawGeometry([In] CanvasGeometry geometry, [In] ICanvasBrush brush, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawGeometryAtOriginWithColorAndStrokeWidth")]
		public extern void DrawGeometry([In] CanvasGeometry geometry, [In] Color color, [In] float strokeWidth);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawGeometryWithBrushAndStrokeWidthAndStrokeStyle")]
		public extern void DrawGeometry([In] CanvasGeometry geometry, [In] Vector2 offset, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawGeometryWithColorAndStrokeWidthAndStrokeStyle")]
		public extern void DrawGeometry([In] CanvasGeometry geometry, [In] Vector2 offset, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawGeometryAtCoordsWithBrushAndStrokeWidthAndStrokeStyle")]
		public extern void DrawGeometry([In] CanvasGeometry geometry, [In] float x, [In] float y, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawGeometryAtCoordsWithColorAndStrokeWidthAndStrokeStyle")]
		public extern void DrawGeometry([In] CanvasGeometry geometry, [In] float x, [In] float y, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawGeometryAtOriginWithBrushAndStrokeWidthAndStrokeStyle")]
		public extern void DrawGeometry([In] CanvasGeometry geometry, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawGeometryAtOriginWithColorAndStrokeWidthAndStrokeStyle")]
		public extern void DrawGeometry([In] CanvasGeometry geometry, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("FillGeometryWithBrush")]
		[DefaultOverload]
		public extern void FillGeometry([In] CanvasGeometry geometry, [In] Vector2 offset, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("FillGeometryWithBrushAndOpacityBrush")]
		public extern void FillGeometry([In] CanvasGeometry geometry, [In] Vector2 offset, [In] ICanvasBrush brush, [In] ICanvasBrush opacityBrush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("FillGeometryWithColor")]
		public extern void FillGeometry([In] CanvasGeometry geometry, [In] Vector2 offset, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("FillGeometryAtCoordsWithBrush")]
		public extern void FillGeometry([In] CanvasGeometry geometry, [In] float x, [In] float y, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("FillGeometryAtCoordsWithBrushAndOpacityBrush")]
		public extern void FillGeometry([In] CanvasGeometry geometry, [In] float x, [In] float y, [In] ICanvasBrush brush, [In] ICanvasBrush opacityBrush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("FillGeometryAtCoordsWithColor")]
		public extern void FillGeometry([In] CanvasGeometry geometry, [In] float x, [In] float y, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("FillGeometryAtOriginWithBrush")]
		public extern void FillGeometry([In] CanvasGeometry geometry, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("FillGeometryAtOriginWithBrushAndOpacityBrush")]
		public extern void FillGeometry([In] CanvasGeometry geometry, [In] ICanvasBrush brush, [In] ICanvasBrush opacityBrush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("FillGeometryAtOriginWithColor")]
		public extern void FillGeometry([In] CanvasGeometry geometry, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawCachedGeometryWithBrush")]
		public extern void DrawCachedGeometry([In] CanvasCachedGeometry geometry, [In] Vector2 offset, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawCachedGeometryWithColor")]
		public extern void DrawCachedGeometry([In] CanvasCachedGeometry geometry, [In] Vector2 offset, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawCachedGeometryAtCoordsWithBrush")]
		public extern void DrawCachedGeometry([In] CanvasCachedGeometry geometry, [In] float x, [In] float y, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawCachedGeometryAtCoordsWithColor")]
		public extern void DrawCachedGeometry([In] CanvasCachedGeometry geometry, [In] float x, [In] float y, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawCachedGeometryAtOriginWithBrush")]
		public extern void DrawCachedGeometry([In] CanvasCachedGeometry geometry, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawCachedGeometryAtOriginWithColor")]
		public extern void DrawCachedGeometry([In] CanvasCachedGeometry geometry, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawTextLayoutWithBrush")]
		[DefaultOverload]
		public extern void DrawTextLayout([In] CanvasTextLayout textLayout, [In] Vector2 point, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawTextLayoutAtCoordsWithBrush")]
		public extern void DrawTextLayout([In] CanvasTextLayout textLayout, [In] float x, [In] float y, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawTextLayoutWithColor")]
		public extern void DrawTextLayout([In] CanvasTextLayout textLayout, [In] Vector2 point, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawTextLayoutAtCoordsWithColor")]
		public extern void DrawTextLayout([In] CanvasTextLayout textLayout, [In] float x, [In] float y, [In] Color color);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawInk")]
		public extern void DrawInk([In] IEnumerable<InkStroke> inkStrokes);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawInkWithHighContrast")]
		[DefaultOverload]
		public extern void DrawInk([In] IEnumerable<InkStroke> inkStrokes, [In] bool highContrast);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawGradientMeshAtOrigin")]
		public extern void DrawGradientMesh([In] CanvasGradientMesh gradientMesh);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawGradientMesh")]
		public extern void DrawGradientMesh([In] CanvasGradientMesh gradientMesh, [In] Vector2 point);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawGradientMeshAtCoords")]
		public extern void DrawGradientMesh([In] CanvasGradientMesh gradientMesh, [In] float x, [In] float y);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawSvgAtOrigin")]
		public extern void DrawSvg([In] CanvasSvgDocument svgDocument, [In] Size viewportSize);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawSvgAtPoint")]
		public extern void DrawSvg([In] CanvasSvgDocument svgDocument, [In] Size viewportSize, [In] Vector2 point);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawSvgAtCoords")]
		public extern void DrawSvg([In] CanvasSvgDocument svgDocument, [In] Size viewportSize, [In] float x, [In] float y);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateLayerWithOpacity")]
		public extern CanvasActiveLayer CreateLayer([In] float opacity);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateLayerWithOpacityBrush")]
		[DefaultOverload]
		public extern CanvasActiveLayer CreateLayer([In] ICanvasBrush opacityBrush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateLayerWithOpacityAndClipRectangle")]
		public extern CanvasActiveLayer CreateLayer([In] float opacity, [In] Rect clipRectangle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateLayerWithOpacityBrushAndClipRectangle")]
		public extern CanvasActiveLayer CreateLayer([In] ICanvasBrush opacityBrush, [In] Rect clipRectangle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateLayerWithOpacityAndClipGeometry")]
		public extern CanvasActiveLayer CreateLayer([In] float opacity, [In] CanvasGeometry clipGeometry);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateLayerWithOpacityBrushAndClipGeometry")]
		[DefaultOverload]
		public extern CanvasActiveLayer CreateLayer([In] ICanvasBrush opacityBrush, [In] CanvasGeometry clipGeometry);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateLayerWithOpacityAndClipGeometryAndTransform")]
		public extern CanvasActiveLayer CreateLayer([In] float opacity, [In] CanvasGeometry clipGeometry, [In] Matrix3x2 geometryTransform);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateLayerWithOpacityBrushAndClipGeometryAndTransform")]
		[DefaultOverload]
		public extern CanvasActiveLayer CreateLayer([In] ICanvasBrush opacityBrush, [In] CanvasGeometry clipGeometry, [In] Matrix3x2 geometryTransform);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateLayerWithAllOptions")]
		public extern CanvasActiveLayer CreateLayer([In] float opacity, [In] ICanvasBrush opacityBrush, [In] Rect clipRectangle, [In] CanvasGeometry clipGeometry, [In] Matrix3x2 geometryTransform, [In] CanvasLayerOptions options);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawGlyphRun")]
		public extern void DrawGlyphRun([In] Vector2 point, [In] CanvasFontFace fontFace, [In] float fontSize, [In] CanvasGlyph[] glyphs, [In] bool isSideways, [In] uint bidiLevel, [In] ICanvasBrush brush);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawGlyphRunWithMeasuringMode")]
		public extern void DrawGlyphRun([In] Vector2 point, [In] CanvasFontFace fontFace, [In] float fontSize, [In] CanvasGlyph[] glyphs, [In] bool isSideways, [In] uint bidiLevel, [In] ICanvasBrush brush, [In] CanvasTextMeasuringMode measuringMode);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawGlyphRunWithMeasuringModeAndDescription")]
		public extern void DrawGlyphRun([In] Vector2 point, [In] CanvasFontFace fontFace, [In] float fontSize, [In] CanvasGlyph[] glyphs, [In] bool isSideways, [In] uint bidiLevel, [In] ICanvasBrush brush, [In] CanvasTextMeasuringMode measuringMode, [In] string localeName, [In] string textString, [In] int[] clusterMapIndices, [In] uint textPosition);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateSpriteBatch")]
		public extern CanvasSpriteBatch CreateSpriteBatch();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateSpriteBatchWithSortMode")]
		public extern CanvasSpriteBatch CreateSpriteBatch([In] CanvasSpriteSortMode sortMode);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateSpriteBatchWithSortModeAndInterpolation")]
		public extern CanvasSpriteBatch CreateSpriteBatch([In] CanvasSpriteSortMode sortMode, [In] CanvasImageInterpolation interpolation);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateSpriteBatchWithSortModeAndInterpolationAndOptions")]
		public extern CanvasSpriteBatch CreateSpriteBatch([In] CanvasSpriteSortMode sortMode, [In] CanvasImageInterpolation interpolation, [In] CanvasSpriteOptions options);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void Dispose();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern float ConvertPixelsToDips([In] int pixels);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern int ConvertDipsToPixels([In] float dips, [In] CanvasDpiRounding dpiRounding);
	}
}
