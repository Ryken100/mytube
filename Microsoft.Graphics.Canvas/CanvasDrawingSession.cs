using System;
using System.Runtime.InteropServices;
using Microsoft.Graphics.Canvas.Brushes;
using Microsoft.Graphics.Canvas.Geometry;
using Microsoft.Graphics.Canvas.Svg;
using Microsoft.Graphics.Canvas.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Imaging;
using Windows.UI;
using Windows.UI.Input.Inking;

namespace Microsoft.Graphics.Canvas
{
	// Token: 0x0200004A RID: 74
	[MarshalingBehavior(2)]
	[Version(167772160U)]
	[Threading(3)]
	public sealed class CanvasDrawingSession : ICanvasDrawingSession, ICanvasResourceCreatorWithDpi, ICanvasResourceCreator, IClosable
	{
		// Token: 0x06000153 RID: 339
		[Overload("Clear")]
		public extern void Clear([In] Color color);

		// Token: 0x06000154 RID: 340
		[DefaultOverload]
		[Overload("ClearHdr")]
		public extern void Clear([In] Vector4 color);

		// Token: 0x06000155 RID: 341
		public extern void Flush();

		// Token: 0x06000156 RID: 342
		[Overload("DrawImageAtOrigin")]
		public extern void DrawImage([In] ICanvasImage image);

		// Token: 0x06000157 RID: 343
		[DefaultOverload]
		[Overload("DrawImageAtOffset")]
		public extern void DrawImage([In] ICanvasImage image, [In] Vector2 offset);

		// Token: 0x06000158 RID: 344
		[Overload("DrawImageAtCoords")]
		public extern void DrawImage([In] ICanvasImage image, [In] float x, [In] float y);

		// Token: 0x06000159 RID: 345
		[Overload("DrawImageToRect")]
		public extern void DrawImage([In] CanvasBitmap bitmap, [In] Rect destinationRectangle);

		// Token: 0x0600015A RID: 346
		[DefaultOverload]
		[Overload("DrawImageAtOffsetWithSourceRect")]
		public extern void DrawImage([In] ICanvasImage image, [In] Vector2 offset, [In] Rect sourceRectangle);

		// Token: 0x0600015B RID: 347
		[Overload("DrawImageAtCoordsWithSourceRect")]
		public extern void DrawImage([In] ICanvasImage image, [In] float x, [In] float y, [In] Rect sourceRectangle);

		// Token: 0x0600015C RID: 348
		[Overload("DrawImageToRectWithSourceRect")]
		public extern void DrawImage([In] ICanvasImage image, [In] Rect destinationRectangle, [In] Rect sourceRectangle);

		// Token: 0x0600015D RID: 349
		[Overload("DrawImageAtOffsetWithSourceRectAndOpacity")]
		[DefaultOverload]
		public extern void DrawImage([In] ICanvasImage image, [In] Vector2 offset, [In] Rect sourceRectangle, [In] float opacity);

		// Token: 0x0600015E RID: 350
		[Overload("DrawImageAtCoordsWithSourceRectAndOpacity")]
		public extern void DrawImage([In] ICanvasImage image, [In] float x, [In] float y, [In] Rect sourceRectangle, [In] float opacity);

		// Token: 0x0600015F RID: 351
		[Overload("DrawImageToRectWithSourceRectAndOpacity")]
		public extern void DrawImage([In] ICanvasImage image, [In] Rect destinationRectangle, [In] Rect sourceRectangle, [In] float opacity);

		// Token: 0x06000160 RID: 352
		[Overload("DrawImageAtOffsetWithSourceRectAndOpacityAndInterpolation")]
		[DefaultOverload]
		public extern void DrawImage([In] ICanvasImage image, [In] Vector2 offset, [In] Rect sourceRectangle, [In] float opacity, [In] CanvasImageInterpolation interpolation);

		// Token: 0x06000161 RID: 353
		[Overload("DrawImageAtCoordsWithSourceRectAndOpacityAndInterpolation")]
		public extern void DrawImage([In] ICanvasImage image, [In] float x, [In] float y, [In] Rect sourceRectangle, [In] float opacity, [In] CanvasImageInterpolation interpolation);

		// Token: 0x06000162 RID: 354
		[Overload("DrawImageToRectWithSourceRectAndOpacityAndInterpolation")]
		public extern void DrawImage([In] ICanvasImage image, [In] Rect destinationRectangle, [In] Rect sourceRectangle, [In] float opacity, [In] CanvasImageInterpolation interpolation);

		// Token: 0x06000163 RID: 355
		[DefaultOverload]
		[Overload("DrawImageAtOffsetWithSourceRectAndOpacityAndInterpolationAndComposite")]
		public extern void DrawImage([In] ICanvasImage image, [In] Vector2 offset, [In] Rect sourceRectangle, [In] float opacity, [In] CanvasImageInterpolation interpolation, [In] CanvasComposite composite);

		// Token: 0x06000164 RID: 356
		[Overload("DrawImageAtCoordsWithSourceRectAndOpacityAndInterpolationAndComposite")]
		[DefaultOverload]
		public extern void DrawImage([In] ICanvasImage image, [In] float x, [In] float y, [In] Rect sourceRectangle, [In] float opacity, [In] CanvasImageInterpolation interpolation, [In] CanvasComposite composite);

		// Token: 0x06000165 RID: 357
		[Overload("DrawImageToRectWithSourceRectAndOpacityAndInterpolationAndComposite")]
		public extern void DrawImage([In] ICanvasImage image, [In] Rect destinationRectangle, [In] Rect sourceRectangle, [In] float opacity, [In] CanvasImageInterpolation interpolation, [In] CanvasComposite composite);

		// Token: 0x06000166 RID: 358
		[Overload("DrawImageAtOffsetWithSourceRectAndOpacityAndInterpolationAndPerspective")]
		public extern void DrawImage([In] CanvasBitmap bitmap, [In] Vector2 offset, [In] Rect sourceRectangle, [In] float opacity, [In] CanvasImageInterpolation interpolation, [In] Matrix4x4 perspective);

		// Token: 0x06000167 RID: 359
		[Overload("DrawImageAtCoordsWithSourceRectAndOpacityAndInterpolationAndPerspective")]
		public extern void DrawImage([In] CanvasBitmap bitmap, [In] float x, [In] float y, [In] Rect sourceRectangle, [In] float opacity, [In] CanvasImageInterpolation interpolation, [In] Matrix4x4 perspective);

		// Token: 0x06000168 RID: 360
		[Overload("DrawImageToRectWithSourceRectAndOpacityAndInterpolationAndPerspective")]
		public extern void DrawImage([In] CanvasBitmap bitmap, [In] Rect destinationRectangle, [In] Rect sourceRectangle, [In] float opacity, [In] CanvasImageInterpolation interpolation, [In] Matrix4x4 perspective);

		// Token: 0x06000169 RID: 361
		[Overload("DrawLineWithBrush")]
		[DefaultOverload]
		public extern void DrawLine([In] Vector2 point0, [In] Vector2 point1, [In] ICanvasBrush brush);

		// Token: 0x0600016A RID: 362
		[Overload("DrawLineAtCoordsWithBrush")]
		public extern void DrawLine([In] float x0, [In] float y0, [In] float x1, [In] float y1, [In] ICanvasBrush brush);

		// Token: 0x0600016B RID: 363
		[Overload("DrawLineWithColor")]
		public extern void DrawLine([In] Vector2 point0, [In] Vector2 point1, [In] Color color);

		// Token: 0x0600016C RID: 364
		[Overload("DrawLineAtCoordsWithColor")]
		public extern void DrawLine([In] float x0, [In] float y0, [In] float x1, [In] float y1, [In] Color color);

		// Token: 0x0600016D RID: 365
		[DefaultOverload]
		[Overload("DrawLineWithBrushAndStrokeWidth")]
		public extern void DrawLine([In] Vector2 point0, [In] Vector2 point1, [In] ICanvasBrush brush, [In] float strokeWidth);

		// Token: 0x0600016E RID: 366
		[Overload("DrawLineAtCoordsWithBrushAndStrokeWidth")]
		[DefaultOverload]
		public extern void DrawLine([In] float x0, [In] float y0, [In] float x1, [In] float y1, [In] ICanvasBrush brush, [In] float strokeWidth);

		// Token: 0x0600016F RID: 367
		[Overload("DrawLineWithColorAndStrokeWidth")]
		public extern void DrawLine([In] Vector2 point0, [In] Vector2 point1, [In] Color color, [In] float strokeWidth);

		// Token: 0x06000170 RID: 368
		[Overload("DrawLineAtCoordsWithColorAndStrokeWidth")]
		public extern void DrawLine([In] float x0, [In] float y0, [In] float x1, [In] float y1, [In] Color color, [In] float strokeWidth);

		// Token: 0x06000171 RID: 369
		[DefaultOverload]
		[Overload("DrawLineWithBrushAndStrokeWidthAndStrokeStyle")]
		public extern void DrawLine([In] Vector2 point0, [In] Vector2 point1, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x06000172 RID: 370
		[Overload("DrawLineAtCoordsWithBrushAndStrokeWidthAndStrokeStyle")]
		[DefaultOverload]
		public extern void DrawLine([In] float x0, [In] float y0, [In] float x1, [In] float y1, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x06000173 RID: 371
		[Overload("DrawLineWithColorAndStrokeWidthAndStrokeStyle")]
		public extern void DrawLine([In] Vector2 point0, [In] Vector2 point1, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x06000174 RID: 372
		[Overload("DrawLineAtCoordsWithColorAndStrokeWidthAndStrokeStyle")]
		public extern void DrawLine([In] float x0, [In] float y0, [In] float x1, [In] float y1, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x06000175 RID: 373
		[DefaultOverload]
		[Overload("DrawRectangleWithBrush")]
		public extern void DrawRectangle([In] Rect rect, [In] ICanvasBrush brush);

		// Token: 0x06000176 RID: 374
		[DefaultOverload]
		[Overload("DrawRectangleAtCoordsWithBrush")]
		public extern void DrawRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] ICanvasBrush brush);

		// Token: 0x06000177 RID: 375
		[Overload("DrawRectangleWithColor")]
		public extern void DrawRectangle([In] Rect rect, [In] Color color);

		// Token: 0x06000178 RID: 376
		[Overload("DrawRectangleAtCoordsWithColor")]
		public extern void DrawRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] Color color);

		// Token: 0x06000179 RID: 377
		[Overload("DrawRectangleWithBrushAndStrokeWidth")]
		[DefaultOverload]
		public extern void DrawRectangle([In] Rect rect, [In] ICanvasBrush brush, [In] float strokeWidth);

		// Token: 0x0600017A RID: 378
		[DefaultOverload]
		[Overload("DrawRectangleAtCoordsWithBrushAndStrokeWidth")]
		public extern void DrawRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] ICanvasBrush brush, [In] float strokeWidth);

		// Token: 0x0600017B RID: 379
		[Overload("DrawRectangleWithColorAndStrokeWidth")]
		public extern void DrawRectangle([In] Rect rect, [In] Color color, [In] float strokeWidth);

		// Token: 0x0600017C RID: 380
		[Overload("DrawRectangleAtCoordsWithColorAndStrokeWidth")]
		public extern void DrawRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] Color color, [In] float strokeWidth);

		// Token: 0x0600017D RID: 381
		[Overload("DrawRectangleWithBrushAndStrokeWidthAndStrokeStyle")]
		[DefaultOverload]
		public extern void DrawRectangle([In] Rect rect, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x0600017E RID: 382
		[Overload("DrawRectangleAtCoordsWithBrushAndStrokeWidthAndStrokeStyle")]
		[DefaultOverload]
		public extern void DrawRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x0600017F RID: 383
		[Overload("DrawRectangleWithColorAndStrokeWidthAndStrokeStyle")]
		public extern void DrawRectangle([In] Rect rect, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x06000180 RID: 384
		[Overload("DrawRectangleAtCoordsWithColorAndStrokeWidthAndStrokeStyle")]
		public extern void DrawRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x06000181 RID: 385
		[Overload("FillRectangleWithBrush")]
		[DefaultOverload]
		public extern void FillRectangle([In] Rect rect, [In] ICanvasBrush brush);

		// Token: 0x06000182 RID: 386
		[DefaultOverload]
		[Overload("FillRectangleAtCoordsWithBrush")]
		public extern void FillRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] ICanvasBrush brush);

		// Token: 0x06000183 RID: 387
		[Overload("FillRectangleWithColor")]
		public extern void FillRectangle([In] Rect rect, [In] Color color);

		// Token: 0x06000184 RID: 388
		[Overload("FillRectangleAtCoordsWithColor")]
		public extern void FillRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] Color color);

		// Token: 0x06000185 RID: 389
		[Overload("FillRectangleWithBrushAndOpacityBrush")]
		public extern void FillRectangle([In] Rect rect, [In] ICanvasBrush brush, [In] ICanvasBrush opacityBrush);

		// Token: 0x06000186 RID: 390
		[Overload("FillRectangleAtCoordsWithBrushAndOpacityBrush")]
		public extern void FillRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] ICanvasBrush brush, [In] ICanvasBrush opacityBrush);

		// Token: 0x06000187 RID: 391
		[DefaultOverload]
		[Overload("DrawRoundedRectangleWithBrush")]
		public extern void DrawRoundedRectangle([In] Rect rect, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush);

		// Token: 0x06000188 RID: 392
		[DefaultOverload]
		[Overload("DrawRoundedRectangleAtCoordsWithBrush")]
		public extern void DrawRoundedRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush);

		// Token: 0x06000189 RID: 393
		[Overload("DrawRoundedRectangleWithColor")]
		public extern void DrawRoundedRectangle([In] Rect rect, [In] float radiusX, [In] float radiusY, [In] Color color);

		// Token: 0x0600018A RID: 394
		[Overload("DrawRoundedRectangleAtCoordsWithColor")]
		public extern void DrawRoundedRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] float radiusX, [In] float radiusY, [In] Color color);

		// Token: 0x0600018B RID: 395
		[DefaultOverload]
		[Overload("DrawRoundedRectangleWithBrushAndStrokeWidth")]
		public extern void DrawRoundedRectangle([In] Rect rect, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush, [In] float strokeWidth);

		// Token: 0x0600018C RID: 396
		[DefaultOverload]
		[Overload("DrawRoundedRectangleAtCoordsWithBrushAndStrokeWidth")]
		public extern void DrawRoundedRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush, [In] float strokeWidth);

		// Token: 0x0600018D RID: 397
		[Overload("DrawRoundedRectangleWithColorAndStrokeWidth")]
		public extern void DrawRoundedRectangle([In] Rect rect, [In] float radiusX, [In] float radiusY, [In] Color color, [In] float strokeWidth);

		// Token: 0x0600018E RID: 398
		[Overload("DrawRoundedRectangleAtCoordsWithColorAndStrokeWidth")]
		public extern void DrawRoundedRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] float radiusX, [In] float radiusY, [In] Color color, [In] float strokeWidth);

		// Token: 0x0600018F RID: 399
		[Overload("DrawRoundedRectangleWithBrushAndStrokeWidthAndStrokeStyle")]
		[DefaultOverload]
		public extern void DrawRoundedRectangle([In] Rect rect, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x06000190 RID: 400
		[DefaultOverload]
		[Overload("DrawRoundedRectangleAtCoordsWithBrushAndStrokeWidthAndStrokeStyle")]
		public extern void DrawRoundedRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x06000191 RID: 401
		[Overload("DrawRoundedRectangleWithColorAndStrokeWidthAndStrokeStyle")]
		public extern void DrawRoundedRectangle([In] Rect rect, [In] float radiusX, [In] float radiusY, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x06000192 RID: 402
		[Overload("DrawRoundedRectangleAtCoordsWithColorAndStrokeWidthAndStrokeStyle")]
		public extern void DrawRoundedRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] float radiusX, [In] float radiusY, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x06000193 RID: 403
		[Overload("FillRoundedRectangleWithBrush")]
		[DefaultOverload]
		public extern void FillRoundedRectangle([In] Rect rect, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush);

		// Token: 0x06000194 RID: 404
		[Overload("FillRoundedRectangleAtCoordsWithBrush")]
		[DefaultOverload]
		public extern void FillRoundedRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush);

		// Token: 0x06000195 RID: 405
		[Overload("FillRoundedRectangleWithColor")]
		public extern void FillRoundedRectangle([In] Rect rect, [In] float radiusX, [In] float radiusY, [In] Color color);

		// Token: 0x06000196 RID: 406
		[Overload("FillRoundedRectangleAtCoordsWithColor")]
		public extern void FillRoundedRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] float radiusX, [In] float radiusY, [In] Color color);

		// Token: 0x06000197 RID: 407
		[DefaultOverload]
		[Overload("DrawEllipseWithBrush")]
		public extern void DrawEllipse([In] Vector2 centerPoint, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush);

		// Token: 0x06000198 RID: 408
		[Overload("DrawEllipseAtCoordsWithBrush")]
		public extern void DrawEllipse([In] float x, [In] float y, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush);

		// Token: 0x06000199 RID: 409
		[Overload("DrawEllipseWithColor")]
		public extern void DrawEllipse([In] Vector2 centerPoint, [In] float radiusX, [In] float radiusY, [In] Color color);

		// Token: 0x0600019A RID: 410
		[Overload("DrawEllipseAtCoordsWithColor")]
		public extern void DrawEllipse([In] float x, [In] float y, [In] float radiusX, [In] float radiusY, [In] Color color);

		// Token: 0x0600019B RID: 411
		[DefaultOverload]
		[Overload("DrawEllipseWithBrushAndStrokeWidth")]
		public extern void DrawEllipse([In] Vector2 centerPoint, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush, [In] float strokeWidth);

		// Token: 0x0600019C RID: 412
		[Overload("DrawEllipseAtCoordsWithBrushAndStrokeWidth")]
		public extern void DrawEllipse([In] float x, [In] float y, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush, [In] float strokeWidth);

		// Token: 0x0600019D RID: 413
		[Overload("DrawEllipseWithColorAndStrokeWidth")]
		public extern void DrawEllipse([In] Vector2 centerPoint, [In] float radiusX, [In] float radiusY, [In] Color color, [In] float strokeWidth);

		// Token: 0x0600019E RID: 414
		[Overload("DrawEllipseAtCoordsWithColorAndStrokeWidth")]
		public extern void DrawEllipse([In] float x, [In] float y, [In] float radiusX, [In] float radiusY, [In] Color color, [In] float strokeWidth);

		// Token: 0x0600019F RID: 415
		[DefaultOverload]
		[Overload("DrawEllipseWithBrushAndStrokeWidthAndStrokeStyle")]
		public extern void DrawEllipse([In] Vector2 centerPoint, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x060001A0 RID: 416
		[Overload("DrawEllipseAtCoordsWithBrushAndStrokeWidthAndStrokeStyle")]
		[DefaultOverload]
		public extern void DrawEllipse([In] float x, [In] float y, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x060001A1 RID: 417
		[Overload("DrawEllipseWithColorAndStrokeWidthAndStrokeStyle")]
		public extern void DrawEllipse([In] Vector2 centerPoint, [In] float radiusX, [In] float radiusY, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x060001A2 RID: 418
		[Overload("DrawEllipseAtCoordsWithColorAndStrokeWidthAndStrokeStyle")]
		public extern void DrawEllipse([In] float x, [In] float y, [In] float radiusX, [In] float radiusY, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x060001A3 RID: 419
		[Overload("FillEllipseWithBrush")]
		[DefaultOverload]
		public extern void FillEllipse([In] Vector2 centerPoint, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush);

		// Token: 0x060001A4 RID: 420
		[DefaultOverload]
		[Overload("FillEllipseAtCoordsWithBrush")]
		public extern void FillEllipse([In] float x, [In] float y, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush);

		// Token: 0x060001A5 RID: 421
		[Overload("FillEllipseWithColor")]
		public extern void FillEllipse([In] Vector2 centerPoint, [In] float radiusX, [In] float radiusY, [In] Color color);

		// Token: 0x060001A6 RID: 422
		[Overload("FillEllipseAtCoordsWithColor")]
		public extern void FillEllipse([In] float x, [In] float y, [In] float radiusX, [In] float radiusY, [In] Color color);

		// Token: 0x060001A7 RID: 423
		[Overload("DrawCircleWithBrush")]
		[DefaultOverload]
		public extern void DrawCircle([In] Vector2 centerPoint, [In] float radius, [In] ICanvasBrush brush);

		// Token: 0x060001A8 RID: 424
		[Overload("DrawCircleAtCoordsWithBrush")]
		public extern void DrawCircle([In] float x, [In] float y, [In] float radius, [In] ICanvasBrush brush);

		// Token: 0x060001A9 RID: 425
		[Overload("DrawCircleWithColor")]
		public extern void DrawCircle([In] Vector2 centerPoint, [In] float radius, [In] Color color);

		// Token: 0x060001AA RID: 426
		[Overload("DrawCircleAtCoordsWithColor")]
		public extern void DrawCircle([In] float x, [In] float y, [In] float radius, [In] Color color);

		// Token: 0x060001AB RID: 427
		[DefaultOverload]
		[Overload("DrawCircleWithBrushAndStrokeWidth")]
		public extern void DrawCircle([In] Vector2 centerPoint, [In] float radius, [In] ICanvasBrush brush, [In] float strokeWidth);

		// Token: 0x060001AC RID: 428
		[Overload("DrawCircleAtCoordsWithBrushAndStrokeWidth")]
		public extern void DrawCircle([In] float x, [In] float y, [In] float radius, [In] ICanvasBrush brush, [In] float strokeWidth);

		// Token: 0x060001AD RID: 429
		[Overload("DrawCircleWithColorAndStrokeWidth")]
		public extern void DrawCircle([In] Vector2 centerPoint, [In] float radius, [In] Color color, [In] float strokeWidth);

		// Token: 0x060001AE RID: 430
		[Overload("DrawCircleAtCoordsWithColorAndStrokeWidth")]
		public extern void DrawCircle([In] float x, [In] float y, [In] float radius, [In] Color color, [In] float strokeWidth);

		// Token: 0x060001AF RID: 431
		[DefaultOverload]
		[Overload("DrawCircleWithBrushAndStrokeWidthAndStrokeStyle")]
		public extern void DrawCircle([In] Vector2 centerPoint, [In] float radius, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x060001B0 RID: 432
		[DefaultOverload]
		[Overload("DrawCircleAtCoordsWithBrushAndStrokeWidthAndStrokeStyle")]
		public extern void DrawCircle([In] float x, [In] float y, [In] float radius, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x060001B1 RID: 433
		[Overload("DrawCircleWithColorAndStrokeWidthAndStrokeStyle")]
		public extern void DrawCircle([In] Vector2 centerPoint, [In] float radius, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x060001B2 RID: 434
		[Overload("DrawCircleAtCoordsWithColorAndStrokeWidthAndStrokeStyle")]
		public extern void DrawCircle([In] float x, [In] float y, [In] float radius, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x060001B3 RID: 435
		[Overload("FillCircleWithBrush")]
		[DefaultOverload]
		public extern void FillCircle([In] Vector2 centerPoint, [In] float radius, [In] ICanvasBrush brush);

		// Token: 0x060001B4 RID: 436
		[DefaultOverload]
		[Overload("FillCircleAtCoordsWithBrush")]
		public extern void FillCircle([In] float x, [In] float y, [In] float radius, [In] ICanvasBrush brush);

		// Token: 0x060001B5 RID: 437
		[Overload("FillCircleWithColor")]
		public extern void FillCircle([In] Vector2 centerPoint, [In] float radius, [In] Color color);

		// Token: 0x060001B6 RID: 438
		[Overload("FillCircleAtCoordsWithColor")]
		public extern void FillCircle([In] float x, [In] float y, [In] float radius, [In] Color color);

		// Token: 0x060001B7 RID: 439
		[Overload("DrawTextAtPointWithColor")]
		public extern void DrawText([In] string text, [In] Vector2 point, [In] Color color);

		// Token: 0x060001B8 RID: 440
		[Overload("DrawTextAtPointCoordsWithColor")]
		public extern void DrawText([In] string text, [In] float x, [In] float y, [In] Color color);

		// Token: 0x060001B9 RID: 441
		[Overload("DrawTextAtPointWithBrushAndFormat")]
		public extern void DrawText([In] string text, [In] Vector2 point, [In] ICanvasBrush brush, [In] CanvasTextFormat format);

		// Token: 0x060001BA RID: 442
		[Overload("DrawTextAtRectWithBrushAndFormat")]
		[DefaultOverload]
		public extern void DrawText([In] string text, [In] Rect rectangle, [In] ICanvasBrush brush, [In] CanvasTextFormat format);

		// Token: 0x060001BB RID: 443
		[DefaultOverload]
		[Overload("DrawTextAtPointCoordsWithBrushAndFormat")]
		public extern void DrawText([In] string text, [In] float x, [In] float y, [In] ICanvasBrush brush, [In] CanvasTextFormat format);

		// Token: 0x060001BC RID: 444
		[Overload("DrawTextAtRectCoordsWithBrushAndFormat")]
		[DefaultOverload]
		public extern void DrawText([In] string text, [In] float x, [In] float y, [In] float w, [In] float h, [In] ICanvasBrush brush, [In] CanvasTextFormat format);

		// Token: 0x060001BD RID: 445
		[Overload("DrawTextAtPointWithColorAndFormat")]
		public extern void DrawText([In] string text, [In] Vector2 point, [In] Color color, [In] CanvasTextFormat format);

		// Token: 0x060001BE RID: 446
		[Overload("DrawTextAtRectWithColorAndFormat")]
		public extern void DrawText([In] string text, [In] Rect rectangle, [In] Color color, [In] CanvasTextFormat format);

		// Token: 0x060001BF RID: 447
		[Overload("DrawTextAtPointCoordsWithColorAndFormat")]
		public extern void DrawText([In] string text, [In] float x, [In] float y, [In] Color color, [In] CanvasTextFormat format);

		// Token: 0x060001C0 RID: 448
		[Overload("DrawTextAtRectCoordsWithColorAndFormat")]
		public extern void DrawText([In] string text, [In] float x, [In] float y, [In] float w, [In] float h, [In] Color color, [In] CanvasTextFormat format);

		// Token: 0x060001C1 RID: 449
		[Overload("DrawGeometryWithBrush")]
		[DefaultOverload]
		public extern void DrawGeometry([In] CanvasGeometry geometry, [In] Vector2 offset, [In] ICanvasBrush brush);

		// Token: 0x060001C2 RID: 450
		[Overload("DrawGeometryWithColor")]
		public extern void DrawGeometry([In] CanvasGeometry geometry, [In] Vector2 offset, [In] Color color);

		// Token: 0x060001C3 RID: 451
		[Overload("DrawGeometryAtCoordsWithBrush")]
		public extern void DrawGeometry([In] CanvasGeometry geometry, [In] float x, [In] float y, [In] ICanvasBrush brush);

		// Token: 0x060001C4 RID: 452
		[Overload("DrawGeometryAtCoordsWithColor")]
		public extern void DrawGeometry([In] CanvasGeometry geometry, [In] float x, [In] float y, [In] Color color);

		// Token: 0x060001C5 RID: 453
		[Overload("DrawGeometryAtOriginWithBrush")]
		[DefaultOverload]
		public extern void DrawGeometry([In] CanvasGeometry geometry, [In] ICanvasBrush brush);

		// Token: 0x060001C6 RID: 454
		[Overload("DrawGeometryAtOriginWithColor")]
		public extern void DrawGeometry([In] CanvasGeometry geometry, [In] Color color);

		// Token: 0x060001C7 RID: 455
		[Overload("DrawGeometryWithBrushAndStrokeWidth")]
		[DefaultOverload]
		public extern void DrawGeometry([In] CanvasGeometry geometry, [In] Vector2 offset, [In] ICanvasBrush brush, [In] float strokeWidth);

		// Token: 0x060001C8 RID: 456
		[Overload("DrawGeometryWithColorAndStrokeWidth")]
		public extern void DrawGeometry([In] CanvasGeometry geometry, [In] Vector2 offset, [In] Color color, [In] float strokeWidth);

		// Token: 0x060001C9 RID: 457
		[Overload("DrawGeometryAtCoordsWithBrushAndStrokeWidth")]
		public extern void DrawGeometry([In] CanvasGeometry geometry, [In] float x, [In] float y, [In] ICanvasBrush brush, [In] float strokeWidth);

		// Token: 0x060001CA RID: 458
		[Overload("DrawGeometryAtCoordsWithColorAndStrokeWidth")]
		public extern void DrawGeometry([In] CanvasGeometry geometry, [In] float x, [In] float y, [In] Color color, [In] float strokeWidth);

		// Token: 0x060001CB RID: 459
		[Overload("DrawGeometryAtOriginWithBrushAndStrokeWidth")]
		public extern void DrawGeometry([In] CanvasGeometry geometry, [In] ICanvasBrush brush, [In] float strokeWidth);

		// Token: 0x060001CC RID: 460
		[Overload("DrawGeometryAtOriginWithColorAndStrokeWidth")]
		public extern void DrawGeometry([In] CanvasGeometry geometry, [In] Color color, [In] float strokeWidth);

		// Token: 0x060001CD RID: 461
		[DefaultOverload]
		[Overload("DrawGeometryWithBrushAndStrokeWidthAndStrokeStyle")]
		public extern void DrawGeometry([In] CanvasGeometry geometry, [In] Vector2 offset, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x060001CE RID: 462
		[Overload("DrawGeometryWithColorAndStrokeWidthAndStrokeStyle")]
		public extern void DrawGeometry([In] CanvasGeometry geometry, [In] Vector2 offset, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x060001CF RID: 463
		[DefaultOverload]
		[Overload("DrawGeometryAtCoordsWithBrushAndStrokeWidthAndStrokeStyle")]
		public extern void DrawGeometry([In] CanvasGeometry geometry, [In] float x, [In] float y, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x060001D0 RID: 464
		[Overload("DrawGeometryAtCoordsWithColorAndStrokeWidthAndStrokeStyle")]
		public extern void DrawGeometry([In] CanvasGeometry geometry, [In] float x, [In] float y, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x060001D1 RID: 465
		[Overload("DrawGeometryAtOriginWithBrushAndStrokeWidthAndStrokeStyle")]
		public extern void DrawGeometry([In] CanvasGeometry geometry, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x060001D2 RID: 466
		[Overload("DrawGeometryAtOriginWithColorAndStrokeWidthAndStrokeStyle")]
		public extern void DrawGeometry([In] CanvasGeometry geometry, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x060001D3 RID: 467
		[Overload("FillGeometryWithBrush")]
		[DefaultOverload]
		public extern void FillGeometry([In] CanvasGeometry geometry, [In] Vector2 offset, [In] ICanvasBrush brush);

		// Token: 0x060001D4 RID: 468
		[Overload("FillGeometryWithBrushAndOpacityBrush")]
		public extern void FillGeometry([In] CanvasGeometry geometry, [In] Vector2 offset, [In] ICanvasBrush brush, [In] ICanvasBrush opacityBrush);

		// Token: 0x060001D5 RID: 469
		[Overload("FillGeometryWithColor")]
		public extern void FillGeometry([In] CanvasGeometry geometry, [In] Vector2 offset, [In] Color color);

		// Token: 0x060001D6 RID: 470
		[DefaultOverload]
		[Overload("FillGeometryAtCoordsWithBrush")]
		public extern void FillGeometry([In] CanvasGeometry geometry, [In] float x, [In] float y, [In] ICanvasBrush brush);

		// Token: 0x060001D7 RID: 471
		[Overload("FillGeometryAtCoordsWithBrushAndOpacityBrush")]
		public extern void FillGeometry([In] CanvasGeometry geometry, [In] float x, [In] float y, [In] ICanvasBrush brush, [In] ICanvasBrush opacityBrush);

		// Token: 0x060001D8 RID: 472
		[Overload("FillGeometryAtCoordsWithColor")]
		public extern void FillGeometry([In] CanvasGeometry geometry, [In] float x, [In] float y, [In] Color color);

		// Token: 0x060001D9 RID: 473
		[DefaultOverload]
		[Overload("FillGeometryAtOriginWithBrush")]
		public extern void FillGeometry([In] CanvasGeometry geometry, [In] ICanvasBrush brush);

		// Token: 0x060001DA RID: 474
		[Overload("FillGeometryAtOriginWithBrushAndOpacityBrush")]
		public extern void FillGeometry([In] CanvasGeometry geometry, [In] ICanvasBrush brush, [In] ICanvasBrush opacityBrush);

		// Token: 0x060001DB RID: 475
		[Overload("FillGeometryAtOriginWithColor")]
		public extern void FillGeometry([In] CanvasGeometry geometry, [In] Color color);

		// Token: 0x060001DC RID: 476
		[DefaultOverload]
		[Overload("DrawCachedGeometryWithBrush")]
		public extern void DrawCachedGeometry([In] CanvasCachedGeometry geometry, [In] Vector2 offset, [In] ICanvasBrush brush);

		// Token: 0x060001DD RID: 477
		[Overload("DrawCachedGeometryWithColor")]
		public extern void DrawCachedGeometry([In] CanvasCachedGeometry geometry, [In] Vector2 offset, [In] Color color);

		// Token: 0x060001DE RID: 478
		[DefaultOverload]
		[Overload("DrawCachedGeometryAtCoordsWithBrush")]
		public extern void DrawCachedGeometry([In] CanvasCachedGeometry geometry, [In] float x, [In] float y, [In] ICanvasBrush brush);

		// Token: 0x060001DF RID: 479
		[Overload("DrawCachedGeometryAtCoordsWithColor")]
		public extern void DrawCachedGeometry([In] CanvasCachedGeometry geometry, [In] float x, [In] float y, [In] Color color);

		// Token: 0x060001E0 RID: 480
		[DefaultOverload]
		[Overload("DrawCachedGeometryAtOriginWithBrush")]
		public extern void DrawCachedGeometry([In] CanvasCachedGeometry geometry, [In] ICanvasBrush brush);

		// Token: 0x060001E1 RID: 481
		[Overload("DrawCachedGeometryAtOriginWithColor")]
		public extern void DrawCachedGeometry([In] CanvasCachedGeometry geometry, [In] Color color);

		// Token: 0x060001E2 RID: 482
		[Overload("DrawTextLayoutWithBrush")]
		[DefaultOverload]
		public extern void DrawTextLayout([In] CanvasTextLayout textLayout, [In] Vector2 point, [In] ICanvasBrush brush);

		// Token: 0x060001E3 RID: 483
		[DefaultOverload]
		[Overload("DrawTextLayoutAtCoordsWithBrush")]
		public extern void DrawTextLayout([In] CanvasTextLayout textLayout, [In] float x, [In] float y, [In] ICanvasBrush brush);

		// Token: 0x060001E4 RID: 484
		[Overload("DrawTextLayoutWithColor")]
		public extern void DrawTextLayout([In] CanvasTextLayout textLayout, [In] Vector2 point, [In] Color color);

		// Token: 0x060001E5 RID: 485
		[Overload("DrawTextLayoutAtCoordsWithColor")]
		public extern void DrawTextLayout([In] CanvasTextLayout textLayout, [In] float x, [In] float y, [In] Color color);

		// Token: 0x060001E6 RID: 486
		[Overload("DrawInk")]
		public extern void DrawInk([In] IIterable<InkStroke> inkStrokes);

		// Token: 0x060001E7 RID: 487
		[Overload("DrawInkWithHighContrast")]
		[DefaultOverload]
		public extern void DrawInk([In] IIterable<InkStroke> inkStrokes, [In] bool highContrast);

		// Token: 0x060001E8 RID: 488
		[Overload("DrawGradientMeshAtOrigin")]
		public extern void DrawGradientMesh([In] CanvasGradientMesh gradientMesh);

		// Token: 0x060001E9 RID: 489
		[Overload("DrawGradientMesh")]
		public extern void DrawGradientMesh([In] CanvasGradientMesh gradientMesh, [In] Vector2 point);

		// Token: 0x060001EA RID: 490
		[Overload("DrawGradientMeshAtCoords")]
		public extern void DrawGradientMesh([In] CanvasGradientMesh gradientMesh, [In] float x, [In] float y);

		// Token: 0x060001EB RID: 491
		[Overload("DrawSvgAtOrigin")]
		public extern void DrawSvg([In] CanvasSvgDocument svgDocument, [In] Size viewportSize);

		// Token: 0x060001EC RID: 492
		[Overload("DrawSvgAtPoint")]
		public extern void DrawSvg([In] CanvasSvgDocument svgDocument, [In] Size viewportSize, [In] Vector2 point);

		// Token: 0x060001ED RID: 493
		[Overload("DrawSvgAtCoords")]
		public extern void DrawSvg([In] CanvasSvgDocument svgDocument, [In] Size viewportSize, [In] float x, [In] float y);

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060001EE RID: 494
		// (set) Token: 0x060001EF RID: 495
		public extern CanvasAntialiasing Antialiasing
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060001F0 RID: 496
		// (set) Token: 0x060001F1 RID: 497
		public extern CanvasBlend Blend
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060001F2 RID: 498
		// (set) Token: 0x060001F3 RID: 499
		public extern CanvasTextAntialiasing TextAntialiasing
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060001F4 RID: 500
		// (set) Token: 0x060001F5 RID: 501
		public extern CanvasTextRenderingParameters TextRenderingParameters
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060001F6 RID: 502
		// (set) Token: 0x060001F7 RID: 503
		public extern Matrix3x2 Transform
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060001F8 RID: 504
		// (set) Token: 0x060001F9 RID: 505
		public extern CanvasUnits Units
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060001FA RID: 506
		// (set) Token: 0x060001FB RID: 507
		public extern IReference<CanvasBufferPrecision> EffectBufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060001FC RID: 508
		// (set) Token: 0x060001FD RID: 509
		public extern BitmapSize EffectTileSize
		{
			get; [param: In]
			set;
		}

		// Token: 0x060001FE RID: 510
		[Overload("CreateLayerWithOpacity")]
		public extern CanvasActiveLayer CreateLayer([In] float opacity);

		// Token: 0x060001FF RID: 511
		[Overload("CreateLayerWithOpacityBrush")]
		[DefaultOverload]
		public extern CanvasActiveLayer CreateLayer([In] ICanvasBrush opacityBrush);

		// Token: 0x06000200 RID: 512
		[Overload("CreateLayerWithOpacityAndClipRectangle")]
		public extern CanvasActiveLayer CreateLayer([In] float opacity, [In] Rect clipRectangle);

		// Token: 0x06000201 RID: 513
		[Overload("CreateLayerWithOpacityBrushAndClipRectangle")]
		public extern CanvasActiveLayer CreateLayer([In] ICanvasBrush opacityBrush, [In] Rect clipRectangle);

		// Token: 0x06000202 RID: 514
		[Overload("CreateLayerWithOpacityAndClipGeometry")]
		public extern CanvasActiveLayer CreateLayer([In] float opacity, [In] CanvasGeometry clipGeometry);

		// Token: 0x06000203 RID: 515
		[Overload("CreateLayerWithOpacityBrushAndClipGeometry")]
		[DefaultOverload]
		public extern CanvasActiveLayer CreateLayer([In] ICanvasBrush opacityBrush, [In] CanvasGeometry clipGeometry);

		// Token: 0x06000204 RID: 516
		[Overload("CreateLayerWithOpacityAndClipGeometryAndTransform")]
		public extern CanvasActiveLayer CreateLayer([In] float opacity, [In] CanvasGeometry clipGeometry, [In] Matrix3x2 geometryTransform);

		// Token: 0x06000205 RID: 517
		[Overload("CreateLayerWithOpacityBrushAndClipGeometryAndTransform")]
		[DefaultOverload]
		public extern CanvasActiveLayer CreateLayer([In] ICanvasBrush opacityBrush, [In] CanvasGeometry clipGeometry, [In] Matrix3x2 geometryTransform);

		// Token: 0x06000206 RID: 518
		[Overload("CreateLayerWithAllOptions")]
		public extern CanvasActiveLayer CreateLayer([In] float opacity, [In] ICanvasBrush opacityBrush, [In] Rect clipRectangle, [In] CanvasGeometry clipGeometry, [In] Matrix3x2 geometryTransform, [In] CanvasLayerOptions options);

		// Token: 0x06000207 RID: 519
		[Overload("DrawGlyphRun")]
		public extern void DrawGlyphRun([In] Vector2 point, [In] CanvasFontFace fontFace, [In] float fontSize, [In] CanvasGlyph[] glyphs, [In] bool isSideways, [In] uint bidiLevel, [In] ICanvasBrush brush);

		// Token: 0x06000208 RID: 520
		[Overload("DrawGlyphRunWithMeasuringMode")]
		public extern void DrawGlyphRun([In] Vector2 point, [In] CanvasFontFace fontFace, [In] float fontSize, [In] CanvasGlyph[] glyphs, [In] bool isSideways, [In] uint bidiLevel, [In] ICanvasBrush brush, [In] CanvasTextMeasuringMode measuringMode);

		// Token: 0x06000209 RID: 521
		[Overload("DrawGlyphRunWithMeasuringModeAndDescription")]
		public extern void DrawGlyphRun([In] Vector2 point, [In] CanvasFontFace fontFace, [In] float fontSize, [In] CanvasGlyph[] glyphs, [In] bool isSideways, [In] uint bidiLevel, [In] ICanvasBrush brush, [In] CanvasTextMeasuringMode measuringMode, [In] string localeName, [In] string textString, [In] int[] clusterMapIndices, [In] uint textPosition);

		// Token: 0x0600020A RID: 522
		[Overload("CreateSpriteBatch")]
		public extern CanvasSpriteBatch CreateSpriteBatch();

		// Token: 0x0600020B RID: 523
		[Overload("CreateSpriteBatchWithSortMode")]
		public extern CanvasSpriteBatch CreateSpriteBatch([In] CanvasSpriteSortMode sortMode);

		// Token: 0x0600020C RID: 524
		[Overload("CreateSpriteBatchWithSortModeAndInterpolation")]
		public extern CanvasSpriteBatch CreateSpriteBatch([In] CanvasSpriteSortMode sortMode, [In] CanvasImageInterpolation interpolation);

		// Token: 0x0600020D RID: 525
		[Overload("CreateSpriteBatchWithSortModeAndInterpolationAndOptions")]
		public extern CanvasSpriteBatch CreateSpriteBatch([In] CanvasSpriteSortMode sortMode, [In] CanvasImageInterpolation interpolation, [In] CanvasSpriteOptions options);

		// Token: 0x0600020E RID: 526
		public extern void Close();

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600020F RID: 527
		public extern float Dpi { get; }

		// Token: 0x06000210 RID: 528
		public extern float ConvertPixelsToDips([In] int pixels);

		// Token: 0x06000211 RID: 529
		public extern int ConvertDipsToPixels([In] float dips, [In] CanvasDpiRounding dpiRounding);

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000212 RID: 530
		public extern CanvasDevice Device { get; }
	}
}
