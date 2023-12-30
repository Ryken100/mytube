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
	// Token: 0x020000C9 RID: 201
	[Guid(4127915273U, 58915, 19424, 183, 80, 87, 138, 169, 32, 177, 219)]
	[Version(167772160U)]
	[ExclusiveTo(typeof(CanvasDrawingSession))]
	internal interface ICanvasDrawingSession : IClosable, ICanvasResourceCreatorWithDpi, ICanvasResourceCreator
	{
		// Token: 0x060005F9 RID: 1529
		[Overload("Clear")]
		void Clear([In] Color color);

		// Token: 0x060005FA RID: 1530
		[DefaultOverload]
		[Overload("ClearHdr")]
		void Clear([In] Vector4 color);

		// Token: 0x060005FB RID: 1531
		void Flush();

		// Token: 0x060005FC RID: 1532
		[Overload("DrawImageAtOrigin")]
		void DrawImage([In] ICanvasImage image);

		// Token: 0x060005FD RID: 1533
		[DefaultOverload]
		[Overload("DrawImageAtOffset")]
		void DrawImage([In] ICanvasImage image, [In] Vector2 offset);

		// Token: 0x060005FE RID: 1534
		[Overload("DrawImageAtCoords")]
		void DrawImage([In] ICanvasImage image, [In] float x, [In] float y);

		// Token: 0x060005FF RID: 1535
		[Overload("DrawImageToRect")]
		void DrawImage([In] CanvasBitmap bitmap, [In] Rect destinationRectangle);

		// Token: 0x06000600 RID: 1536
		[DefaultOverload]
		[Overload("DrawImageAtOffsetWithSourceRect")]
		void DrawImage([In] ICanvasImage image, [In] Vector2 offset, [In] Rect sourceRectangle);

		// Token: 0x06000601 RID: 1537
		[Overload("DrawImageAtCoordsWithSourceRect")]
		void DrawImage([In] ICanvasImage image, [In] float x, [In] float y, [In] Rect sourceRectangle);

		// Token: 0x06000602 RID: 1538
		[Overload("DrawImageToRectWithSourceRect")]
		void DrawImage([In] ICanvasImage image, [In] Rect destinationRectangle, [In] Rect sourceRectangle);

		// Token: 0x06000603 RID: 1539
		[DefaultOverload]
		[Overload("DrawImageAtOffsetWithSourceRectAndOpacity")]
		void DrawImage([In] ICanvasImage image, [In] Vector2 offset, [In] Rect sourceRectangle, [In] float opacity);

		// Token: 0x06000604 RID: 1540
		[Overload("DrawImageAtCoordsWithSourceRectAndOpacity")]
		void DrawImage([In] ICanvasImage image, [In] float x, [In] float y, [In] Rect sourceRectangle, [In] float opacity);

		// Token: 0x06000605 RID: 1541
		[Overload("DrawImageToRectWithSourceRectAndOpacity")]
		void DrawImage([In] ICanvasImage image, [In] Rect destinationRectangle, [In] Rect sourceRectangle, [In] float opacity);

		// Token: 0x06000606 RID: 1542
		[Overload("DrawImageAtOffsetWithSourceRectAndOpacityAndInterpolation")]
		[DefaultOverload]
		void DrawImage([In] ICanvasImage image, [In] Vector2 offset, [In] Rect sourceRectangle, [In] float opacity, [In] CanvasImageInterpolation interpolation);

		// Token: 0x06000607 RID: 1543
		[Overload("DrawImageAtCoordsWithSourceRectAndOpacityAndInterpolation")]
		void DrawImage([In] ICanvasImage image, [In] float x, [In] float y, [In] Rect sourceRectangle, [In] float opacity, [In] CanvasImageInterpolation interpolation);

		// Token: 0x06000608 RID: 1544
		[Overload("DrawImageToRectWithSourceRectAndOpacityAndInterpolation")]
		void DrawImage([In] ICanvasImage image, [In] Rect destinationRectangle, [In] Rect sourceRectangle, [In] float opacity, [In] CanvasImageInterpolation interpolation);

		// Token: 0x06000609 RID: 1545
		[DefaultOverload]
		[Overload("DrawImageAtOffsetWithSourceRectAndOpacityAndInterpolationAndComposite")]
		void DrawImage([In] ICanvasImage image, [In] Vector2 offset, [In] Rect sourceRectangle, [In] float opacity, [In] CanvasImageInterpolation interpolation, [In] CanvasComposite composite);

		// Token: 0x0600060A RID: 1546
		[Overload("DrawImageAtCoordsWithSourceRectAndOpacityAndInterpolationAndComposite")]
		[DefaultOverload]
		void DrawImage([In] ICanvasImage image, [In] float x, [In] float y, [In] Rect sourceRectangle, [In] float opacity, [In] CanvasImageInterpolation interpolation, [In] CanvasComposite composite);

		// Token: 0x0600060B RID: 1547
		[Overload("DrawImageToRectWithSourceRectAndOpacityAndInterpolationAndComposite")]
		void DrawImage([In] ICanvasImage image, [In] Rect destinationRectangle, [In] Rect sourceRectangle, [In] float opacity, [In] CanvasImageInterpolation interpolation, [In] CanvasComposite composite);

		// Token: 0x0600060C RID: 1548
		[Overload("DrawImageAtOffsetWithSourceRectAndOpacityAndInterpolationAndPerspective")]
		void DrawImage([In] CanvasBitmap bitmap, [In] Vector2 offset, [In] Rect sourceRectangle, [In] float opacity, [In] CanvasImageInterpolation interpolation, [In] Matrix4x4 perspective);

		// Token: 0x0600060D RID: 1549
		[Overload("DrawImageAtCoordsWithSourceRectAndOpacityAndInterpolationAndPerspective")]
		void DrawImage([In] CanvasBitmap bitmap, [In] float x, [In] float y, [In] Rect sourceRectangle, [In] float opacity, [In] CanvasImageInterpolation interpolation, [In] Matrix4x4 perspective);

		// Token: 0x0600060E RID: 1550
		[Overload("DrawImageToRectWithSourceRectAndOpacityAndInterpolationAndPerspective")]
		void DrawImage([In] CanvasBitmap bitmap, [In] Rect destinationRectangle, [In] Rect sourceRectangle, [In] float opacity, [In] CanvasImageInterpolation interpolation, [In] Matrix4x4 perspective);

		// Token: 0x0600060F RID: 1551
		[Overload("DrawLineWithBrush")]
		[DefaultOverload]
		void DrawLine([In] Vector2 point0, [In] Vector2 point1, [In] ICanvasBrush brush);

		// Token: 0x06000610 RID: 1552
		[Overload("DrawLineAtCoordsWithBrush")]
		void DrawLine([In] float x0, [In] float y0, [In] float x1, [In] float y1, [In] ICanvasBrush brush);

		// Token: 0x06000611 RID: 1553
		[Overload("DrawLineWithColor")]
		void DrawLine([In] Vector2 point0, [In] Vector2 point1, [In] Color color);

		// Token: 0x06000612 RID: 1554
		[Overload("DrawLineAtCoordsWithColor")]
		void DrawLine([In] float x0, [In] float y0, [In] float x1, [In] float y1, [In] Color color);

		// Token: 0x06000613 RID: 1555
		[DefaultOverload]
		[Overload("DrawLineWithBrushAndStrokeWidth")]
		void DrawLine([In] Vector2 point0, [In] Vector2 point1, [In] ICanvasBrush brush, [In] float strokeWidth);

		// Token: 0x06000614 RID: 1556
		[DefaultOverload]
		[Overload("DrawLineAtCoordsWithBrushAndStrokeWidth")]
		void DrawLine([In] float x0, [In] float y0, [In] float x1, [In] float y1, [In] ICanvasBrush brush, [In] float strokeWidth);

		// Token: 0x06000615 RID: 1557
		[Overload("DrawLineWithColorAndStrokeWidth")]
		void DrawLine([In] Vector2 point0, [In] Vector2 point1, [In] Color color, [In] float strokeWidth);

		// Token: 0x06000616 RID: 1558
		[Overload("DrawLineAtCoordsWithColorAndStrokeWidth")]
		void DrawLine([In] float x0, [In] float y0, [In] float x1, [In] float y1, [In] Color color, [In] float strokeWidth);

		// Token: 0x06000617 RID: 1559
		[DefaultOverload]
		[Overload("DrawLineWithBrushAndStrokeWidthAndStrokeStyle")]
		void DrawLine([In] Vector2 point0, [In] Vector2 point1, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x06000618 RID: 1560
		[DefaultOverload]
		[Overload("DrawLineAtCoordsWithBrushAndStrokeWidthAndStrokeStyle")]
		void DrawLine([In] float x0, [In] float y0, [In] float x1, [In] float y1, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x06000619 RID: 1561
		[Overload("DrawLineWithColorAndStrokeWidthAndStrokeStyle")]
		void DrawLine([In] Vector2 point0, [In] Vector2 point1, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x0600061A RID: 1562
		[Overload("DrawLineAtCoordsWithColorAndStrokeWidthAndStrokeStyle")]
		void DrawLine([In] float x0, [In] float y0, [In] float x1, [In] float y1, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x0600061B RID: 1563
		[Overload("DrawRectangleWithBrush")]
		[DefaultOverload]
		void DrawRectangle([In] Rect rect, [In] ICanvasBrush brush);

		// Token: 0x0600061C RID: 1564
		[DefaultOverload]
		[Overload("DrawRectangleAtCoordsWithBrush")]
		void DrawRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] ICanvasBrush brush);

		// Token: 0x0600061D RID: 1565
		[Overload("DrawRectangleWithColor")]
		void DrawRectangle([In] Rect rect, [In] Color color);

		// Token: 0x0600061E RID: 1566
		[Overload("DrawRectangleAtCoordsWithColor")]
		void DrawRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] Color color);

		// Token: 0x0600061F RID: 1567
		[DefaultOverload]
		[Overload("DrawRectangleWithBrushAndStrokeWidth")]
		void DrawRectangle([In] Rect rect, [In] ICanvasBrush brush, [In] float strokeWidth);

		// Token: 0x06000620 RID: 1568
		[DefaultOverload]
		[Overload("DrawRectangleAtCoordsWithBrushAndStrokeWidth")]
		void DrawRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] ICanvasBrush brush, [In] float strokeWidth);

		// Token: 0x06000621 RID: 1569
		[Overload("DrawRectangleWithColorAndStrokeWidth")]
		void DrawRectangle([In] Rect rect, [In] Color color, [In] float strokeWidth);

		// Token: 0x06000622 RID: 1570
		[Overload("DrawRectangleAtCoordsWithColorAndStrokeWidth")]
		void DrawRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] Color color, [In] float strokeWidth);

		// Token: 0x06000623 RID: 1571
		[DefaultOverload]
		[Overload("DrawRectangleWithBrushAndStrokeWidthAndStrokeStyle")]
		void DrawRectangle([In] Rect rect, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x06000624 RID: 1572
		[DefaultOverload]
		[Overload("DrawRectangleAtCoordsWithBrushAndStrokeWidthAndStrokeStyle")]
		void DrawRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x06000625 RID: 1573
		[Overload("DrawRectangleWithColorAndStrokeWidthAndStrokeStyle")]
		void DrawRectangle([In] Rect rect, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x06000626 RID: 1574
		[Overload("DrawRectangleAtCoordsWithColorAndStrokeWidthAndStrokeStyle")]
		void DrawRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x06000627 RID: 1575
		[Overload("FillRectangleWithBrush")]
		[DefaultOverload]
		void FillRectangle([In] Rect rect, [In] ICanvasBrush brush);

		// Token: 0x06000628 RID: 1576
		[Overload("FillRectangleAtCoordsWithBrush")]
		[DefaultOverload]
		void FillRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] ICanvasBrush brush);

		// Token: 0x06000629 RID: 1577
		[Overload("FillRectangleWithColor")]
		void FillRectangle([In] Rect rect, [In] Color color);

		// Token: 0x0600062A RID: 1578
		[Overload("FillRectangleAtCoordsWithColor")]
		void FillRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] Color color);

		// Token: 0x0600062B RID: 1579
		[Overload("FillRectangleWithBrushAndOpacityBrush")]
		void FillRectangle([In] Rect rect, [In] ICanvasBrush brush, [In] ICanvasBrush opacityBrush);

		// Token: 0x0600062C RID: 1580
		[Overload("FillRectangleAtCoordsWithBrushAndOpacityBrush")]
		void FillRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] ICanvasBrush brush, [In] ICanvasBrush opacityBrush);

		// Token: 0x0600062D RID: 1581
		[DefaultOverload]
		[Overload("DrawRoundedRectangleWithBrush")]
		void DrawRoundedRectangle([In] Rect rect, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush);

		// Token: 0x0600062E RID: 1582
		[Overload("DrawRoundedRectangleAtCoordsWithBrush")]
		[DefaultOverload]
		void DrawRoundedRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush);

		// Token: 0x0600062F RID: 1583
		[Overload("DrawRoundedRectangleWithColor")]
		void DrawRoundedRectangle([In] Rect rect, [In] float radiusX, [In] float radiusY, [In] Color color);

		// Token: 0x06000630 RID: 1584
		[Overload("DrawRoundedRectangleAtCoordsWithColor")]
		void DrawRoundedRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] float radiusX, [In] float radiusY, [In] Color color);

		// Token: 0x06000631 RID: 1585
		[DefaultOverload]
		[Overload("DrawRoundedRectangleWithBrushAndStrokeWidth")]
		void DrawRoundedRectangle([In] Rect rect, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush, [In] float strokeWidth);

		// Token: 0x06000632 RID: 1586
		[DefaultOverload]
		[Overload("DrawRoundedRectangleAtCoordsWithBrushAndStrokeWidth")]
		void DrawRoundedRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush, [In] float strokeWidth);

		// Token: 0x06000633 RID: 1587
		[Overload("DrawRoundedRectangleWithColorAndStrokeWidth")]
		void DrawRoundedRectangle([In] Rect rect, [In] float radiusX, [In] float radiusY, [In] Color color, [In] float strokeWidth);

		// Token: 0x06000634 RID: 1588
		[Overload("DrawRoundedRectangleAtCoordsWithColorAndStrokeWidth")]
		void DrawRoundedRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] float radiusX, [In] float radiusY, [In] Color color, [In] float strokeWidth);

		// Token: 0x06000635 RID: 1589
		[Overload("DrawRoundedRectangleWithBrushAndStrokeWidthAndStrokeStyle")]
		[DefaultOverload]
		void DrawRoundedRectangle([In] Rect rect, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x06000636 RID: 1590
		[DefaultOverload]
		[Overload("DrawRoundedRectangleAtCoordsWithBrushAndStrokeWidthAndStrokeStyle")]
		void DrawRoundedRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x06000637 RID: 1591
		[Overload("DrawRoundedRectangleWithColorAndStrokeWidthAndStrokeStyle")]
		void DrawRoundedRectangle([In] Rect rect, [In] float radiusX, [In] float radiusY, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x06000638 RID: 1592
		[Overload("DrawRoundedRectangleAtCoordsWithColorAndStrokeWidthAndStrokeStyle")]
		void DrawRoundedRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] float radiusX, [In] float radiusY, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x06000639 RID: 1593
		[DefaultOverload]
		[Overload("FillRoundedRectangleWithBrush")]
		void FillRoundedRectangle([In] Rect rect, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush);

		// Token: 0x0600063A RID: 1594
		[DefaultOverload]
		[Overload("FillRoundedRectangleAtCoordsWithBrush")]
		void FillRoundedRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush);

		// Token: 0x0600063B RID: 1595
		[Overload("FillRoundedRectangleWithColor")]
		void FillRoundedRectangle([In] Rect rect, [In] float radiusX, [In] float radiusY, [In] Color color);

		// Token: 0x0600063C RID: 1596
		[Overload("FillRoundedRectangleAtCoordsWithColor")]
		void FillRoundedRectangle([In] float x, [In] float y, [In] float w, [In] float h, [In] float radiusX, [In] float radiusY, [In] Color color);

		// Token: 0x0600063D RID: 1597
		[Overload("DrawEllipseWithBrush")]
		[DefaultOverload]
		void DrawEllipse([In] Vector2 centerPoint, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush);

		// Token: 0x0600063E RID: 1598
		[Overload("DrawEllipseAtCoordsWithBrush")]
		void DrawEllipse([In] float x, [In] float y, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush);

		// Token: 0x0600063F RID: 1599
		[Overload("DrawEllipseWithColor")]
		void DrawEllipse([In] Vector2 centerPoint, [In] float radiusX, [In] float radiusY, [In] Color color);

		// Token: 0x06000640 RID: 1600
		[Overload("DrawEllipseAtCoordsWithColor")]
		void DrawEllipse([In] float x, [In] float y, [In] float radiusX, [In] float radiusY, [In] Color color);

		// Token: 0x06000641 RID: 1601
		[Overload("DrawEllipseWithBrushAndStrokeWidth")]
		[DefaultOverload]
		void DrawEllipse([In] Vector2 centerPoint, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush, [In] float strokeWidth);

		// Token: 0x06000642 RID: 1602
		[Overload("DrawEllipseAtCoordsWithBrushAndStrokeWidth")]
		void DrawEllipse([In] float x, [In] float y, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush, [In] float strokeWidth);

		// Token: 0x06000643 RID: 1603
		[Overload("DrawEllipseWithColorAndStrokeWidth")]
		void DrawEllipse([In] Vector2 centerPoint, [In] float radiusX, [In] float radiusY, [In] Color color, [In] float strokeWidth);

		// Token: 0x06000644 RID: 1604
		[Overload("DrawEllipseAtCoordsWithColorAndStrokeWidth")]
		void DrawEllipse([In] float x, [In] float y, [In] float radiusX, [In] float radiusY, [In] Color color, [In] float strokeWidth);

		// Token: 0x06000645 RID: 1605
		[Overload("DrawEllipseWithBrushAndStrokeWidthAndStrokeStyle")]
		[DefaultOverload]
		void DrawEllipse([In] Vector2 centerPoint, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x06000646 RID: 1606
		[Overload("DrawEllipseAtCoordsWithBrushAndStrokeWidthAndStrokeStyle")]
		[DefaultOverload]
		void DrawEllipse([In] float x, [In] float y, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x06000647 RID: 1607
		[Overload("DrawEllipseWithColorAndStrokeWidthAndStrokeStyle")]
		void DrawEllipse([In] Vector2 centerPoint, [In] float radiusX, [In] float radiusY, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x06000648 RID: 1608
		[Overload("DrawEllipseAtCoordsWithColorAndStrokeWidthAndStrokeStyle")]
		void DrawEllipse([In] float x, [In] float y, [In] float radiusX, [In] float radiusY, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x06000649 RID: 1609
		[DefaultOverload]
		[Overload("FillEllipseWithBrush")]
		void FillEllipse([In] Vector2 centerPoint, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush);

		// Token: 0x0600064A RID: 1610
		[Overload("FillEllipseAtCoordsWithBrush")]
		[DefaultOverload]
		void FillEllipse([In] float x, [In] float y, [In] float radiusX, [In] float radiusY, [In] ICanvasBrush brush);

		// Token: 0x0600064B RID: 1611
		[Overload("FillEllipseWithColor")]
		void FillEllipse([In] Vector2 centerPoint, [In] float radiusX, [In] float radiusY, [In] Color color);

		// Token: 0x0600064C RID: 1612
		[Overload("FillEllipseAtCoordsWithColor")]
		void FillEllipse([In] float x, [In] float y, [In] float radiusX, [In] float radiusY, [In] Color color);

		// Token: 0x0600064D RID: 1613
		[Overload("DrawCircleWithBrush")]
		[DefaultOverload]
		void DrawCircle([In] Vector2 centerPoint, [In] float radius, [In] ICanvasBrush brush);

		// Token: 0x0600064E RID: 1614
		[Overload("DrawCircleAtCoordsWithBrush")]
		void DrawCircle([In] float x, [In] float y, [In] float radius, [In] ICanvasBrush brush);

		// Token: 0x0600064F RID: 1615
		[Overload("DrawCircleWithColor")]
		void DrawCircle([In] Vector2 centerPoint, [In] float radius, [In] Color color);

		// Token: 0x06000650 RID: 1616
		[Overload("DrawCircleAtCoordsWithColor")]
		void DrawCircle([In] float x, [In] float y, [In] float radius, [In] Color color);

		// Token: 0x06000651 RID: 1617
		[DefaultOverload]
		[Overload("DrawCircleWithBrushAndStrokeWidth")]
		void DrawCircle([In] Vector2 centerPoint, [In] float radius, [In] ICanvasBrush brush, [In] float strokeWidth);

		// Token: 0x06000652 RID: 1618
		[Overload("DrawCircleAtCoordsWithBrushAndStrokeWidth")]
		void DrawCircle([In] float x, [In] float y, [In] float radius, [In] ICanvasBrush brush, [In] float strokeWidth);

		// Token: 0x06000653 RID: 1619
		[Overload("DrawCircleWithColorAndStrokeWidth")]
		void DrawCircle([In] Vector2 centerPoint, [In] float radius, [In] Color color, [In] float strokeWidth);

		// Token: 0x06000654 RID: 1620
		[Overload("DrawCircleAtCoordsWithColorAndStrokeWidth")]
		void DrawCircle([In] float x, [In] float y, [In] float radius, [In] Color color, [In] float strokeWidth);

		// Token: 0x06000655 RID: 1621
		[DefaultOverload]
		[Overload("DrawCircleWithBrushAndStrokeWidthAndStrokeStyle")]
		void DrawCircle([In] Vector2 centerPoint, [In] float radius, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x06000656 RID: 1622
		[DefaultOverload]
		[Overload("DrawCircleAtCoordsWithBrushAndStrokeWidthAndStrokeStyle")]
		void DrawCircle([In] float x, [In] float y, [In] float radius, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x06000657 RID: 1623
		[Overload("DrawCircleWithColorAndStrokeWidthAndStrokeStyle")]
		void DrawCircle([In] Vector2 centerPoint, [In] float radius, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x06000658 RID: 1624
		[Overload("DrawCircleAtCoordsWithColorAndStrokeWidthAndStrokeStyle")]
		void DrawCircle([In] float x, [In] float y, [In] float radius, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x06000659 RID: 1625
		[DefaultOverload]
		[Overload("FillCircleWithBrush")]
		void FillCircle([In] Vector2 centerPoint, [In] float radius, [In] ICanvasBrush brush);

		// Token: 0x0600065A RID: 1626
		[DefaultOverload]
		[Overload("FillCircleAtCoordsWithBrush")]
		void FillCircle([In] float x, [In] float y, [In] float radius, [In] ICanvasBrush brush);

		// Token: 0x0600065B RID: 1627
		[Overload("FillCircleWithColor")]
		void FillCircle([In] Vector2 centerPoint, [In] float radius, [In] Color color);

		// Token: 0x0600065C RID: 1628
		[Overload("FillCircleAtCoordsWithColor")]
		void FillCircle([In] float x, [In] float y, [In] float radius, [In] Color color);

		// Token: 0x0600065D RID: 1629
		[Overload("DrawTextAtPointWithColor")]
		void DrawText([In] string text, [In] Vector2 point, [In] Color color);

		// Token: 0x0600065E RID: 1630
		[Overload("DrawTextAtPointCoordsWithColor")]
		void DrawText([In] string text, [In] float x, [In] float y, [In] Color color);

		// Token: 0x0600065F RID: 1631
		[Overload("DrawTextAtPointWithBrushAndFormat")]
		void DrawText([In] string text, [In] Vector2 point, [In] ICanvasBrush brush, [In] CanvasTextFormat format);

		// Token: 0x06000660 RID: 1632
		[DefaultOverload]
		[Overload("DrawTextAtRectWithBrushAndFormat")]
		void DrawText([In] string text, [In] Rect rectangle, [In] ICanvasBrush brush, [In] CanvasTextFormat format);

		// Token: 0x06000661 RID: 1633
		[DefaultOverload]
		[Overload("DrawTextAtPointCoordsWithBrushAndFormat")]
		void DrawText([In] string text, [In] float x, [In] float y, [In] ICanvasBrush brush, [In] CanvasTextFormat format);

		// Token: 0x06000662 RID: 1634
		[DefaultOverload]
		[Overload("DrawTextAtRectCoordsWithBrushAndFormat")]
		void DrawText([In] string text, [In] float x, [In] float y, [In] float w, [In] float h, [In] ICanvasBrush brush, [In] CanvasTextFormat format);

		// Token: 0x06000663 RID: 1635
		[Overload("DrawTextAtPointWithColorAndFormat")]
		void DrawText([In] string text, [In] Vector2 point, [In] Color color, [In] CanvasTextFormat format);

		// Token: 0x06000664 RID: 1636
		[Overload("DrawTextAtRectWithColorAndFormat")]
		void DrawText([In] string text, [In] Rect rectangle, [In] Color color, [In] CanvasTextFormat format);

		// Token: 0x06000665 RID: 1637
		[Overload("DrawTextAtPointCoordsWithColorAndFormat")]
		void DrawText([In] string text, [In] float x, [In] float y, [In] Color color, [In] CanvasTextFormat format);

		// Token: 0x06000666 RID: 1638
		[Overload("DrawTextAtRectCoordsWithColorAndFormat")]
		void DrawText([In] string text, [In] float x, [In] float y, [In] float w, [In] float h, [In] Color color, [In] CanvasTextFormat format);

		// Token: 0x06000667 RID: 1639
		[Overload("DrawGeometryWithBrush")]
		[DefaultOverload]
		void DrawGeometry([In] CanvasGeometry geometry, [In] Vector2 offset, [In] ICanvasBrush brush);

		// Token: 0x06000668 RID: 1640
		[Overload("DrawGeometryWithColor")]
		void DrawGeometry([In] CanvasGeometry geometry, [In] Vector2 offset, [In] Color color);

		// Token: 0x06000669 RID: 1641
		[Overload("DrawGeometryAtCoordsWithBrush")]
		void DrawGeometry([In] CanvasGeometry geometry, [In] float x, [In] float y, [In] ICanvasBrush brush);

		// Token: 0x0600066A RID: 1642
		[Overload("DrawGeometryAtCoordsWithColor")]
		void DrawGeometry([In] CanvasGeometry geometry, [In] float x, [In] float y, [In] Color color);

		// Token: 0x0600066B RID: 1643
		[DefaultOverload]
		[Overload("DrawGeometryAtOriginWithBrush")]
		void DrawGeometry([In] CanvasGeometry geometry, [In] ICanvasBrush brush);

		// Token: 0x0600066C RID: 1644
		[Overload("DrawGeometryAtOriginWithColor")]
		void DrawGeometry([In] CanvasGeometry geometry, [In] Color color);

		// Token: 0x0600066D RID: 1645
		[DefaultOverload]
		[Overload("DrawGeometryWithBrushAndStrokeWidth")]
		void DrawGeometry([In] CanvasGeometry geometry, [In] Vector2 offset, [In] ICanvasBrush brush, [In] float strokeWidth);

		// Token: 0x0600066E RID: 1646
		[Overload("DrawGeometryWithColorAndStrokeWidth")]
		void DrawGeometry([In] CanvasGeometry geometry, [In] Vector2 offset, [In] Color color, [In] float strokeWidth);

		// Token: 0x0600066F RID: 1647
		[Overload("DrawGeometryAtCoordsWithBrushAndStrokeWidth")]
		void DrawGeometry([In] CanvasGeometry geometry, [In] float x, [In] float y, [In] ICanvasBrush brush, [In] float strokeWidth);

		// Token: 0x06000670 RID: 1648
		[Overload("DrawGeometryAtCoordsWithColorAndStrokeWidth")]
		void DrawGeometry([In] CanvasGeometry geometry, [In] float x, [In] float y, [In] Color color, [In] float strokeWidth);

		// Token: 0x06000671 RID: 1649
		[Overload("DrawGeometryAtOriginWithBrushAndStrokeWidth")]
		void DrawGeometry([In] CanvasGeometry geometry, [In] ICanvasBrush brush, [In] float strokeWidth);

		// Token: 0x06000672 RID: 1650
		[Overload("DrawGeometryAtOriginWithColorAndStrokeWidth")]
		void DrawGeometry([In] CanvasGeometry geometry, [In] Color color, [In] float strokeWidth);

		// Token: 0x06000673 RID: 1651
		[DefaultOverload]
		[Overload("DrawGeometryWithBrushAndStrokeWidthAndStrokeStyle")]
		void DrawGeometry([In] CanvasGeometry geometry, [In] Vector2 offset, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x06000674 RID: 1652
		[Overload("DrawGeometryWithColorAndStrokeWidthAndStrokeStyle")]
		void DrawGeometry([In] CanvasGeometry geometry, [In] Vector2 offset, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x06000675 RID: 1653
		[DefaultOverload]
		[Overload("DrawGeometryAtCoordsWithBrushAndStrokeWidthAndStrokeStyle")]
		void DrawGeometry([In] CanvasGeometry geometry, [In] float x, [In] float y, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x06000676 RID: 1654
		[Overload("DrawGeometryAtCoordsWithColorAndStrokeWidthAndStrokeStyle")]
		void DrawGeometry([In] CanvasGeometry geometry, [In] float x, [In] float y, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x06000677 RID: 1655
		[Overload("DrawGeometryAtOriginWithBrushAndStrokeWidthAndStrokeStyle")]
		void DrawGeometry([In] CanvasGeometry geometry, [In] ICanvasBrush brush, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x06000678 RID: 1656
		[Overload("DrawGeometryAtOriginWithColorAndStrokeWidthAndStrokeStyle")]
		void DrawGeometry([In] CanvasGeometry geometry, [In] Color color, [In] float strokeWidth, [In] CanvasStrokeStyle strokeStyle);

		// Token: 0x06000679 RID: 1657
		[DefaultOverload]
		[Overload("FillGeometryWithBrush")]
		void FillGeometry([In] CanvasGeometry geometry, [In] Vector2 offset, [In] ICanvasBrush brush);

		// Token: 0x0600067A RID: 1658
		[Overload("FillGeometryWithBrushAndOpacityBrush")]
		void FillGeometry([In] CanvasGeometry geometry, [In] Vector2 offset, [In] ICanvasBrush brush, [In] ICanvasBrush opacityBrush);

		// Token: 0x0600067B RID: 1659
		[Overload("FillGeometryWithColor")]
		void FillGeometry([In] CanvasGeometry geometry, [In] Vector2 offset, [In] Color color);

		// Token: 0x0600067C RID: 1660
		[Overload("FillGeometryAtCoordsWithBrush")]
		[DefaultOverload]
		void FillGeometry([In] CanvasGeometry geometry, [In] float x, [In] float y, [In] ICanvasBrush brush);

		// Token: 0x0600067D RID: 1661
		[Overload("FillGeometryAtCoordsWithBrushAndOpacityBrush")]
		void FillGeometry([In] CanvasGeometry geometry, [In] float x, [In] float y, [In] ICanvasBrush brush, [In] ICanvasBrush opacityBrush);

		// Token: 0x0600067E RID: 1662
		[Overload("FillGeometryAtCoordsWithColor")]
		void FillGeometry([In] CanvasGeometry geometry, [In] float x, [In] float y, [In] Color color);

		// Token: 0x0600067F RID: 1663
		[DefaultOverload]
		[Overload("FillGeometryAtOriginWithBrush")]
		void FillGeometry([In] CanvasGeometry geometry, [In] ICanvasBrush brush);

		// Token: 0x06000680 RID: 1664
		[Overload("FillGeometryAtOriginWithBrushAndOpacityBrush")]
		void FillGeometry([In] CanvasGeometry geometry, [In] ICanvasBrush brush, [In] ICanvasBrush opacityBrush);

		// Token: 0x06000681 RID: 1665
		[Overload("FillGeometryAtOriginWithColor")]
		void FillGeometry([In] CanvasGeometry geometry, [In] Color color);

		// Token: 0x06000682 RID: 1666
		[Overload("DrawCachedGeometryWithBrush")]
		[DefaultOverload]
		void DrawCachedGeometry([In] CanvasCachedGeometry geometry, [In] Vector2 offset, [In] ICanvasBrush brush);

		// Token: 0x06000683 RID: 1667
		[Overload("DrawCachedGeometryWithColor")]
		void DrawCachedGeometry([In] CanvasCachedGeometry geometry, [In] Vector2 offset, [In] Color color);

		// Token: 0x06000684 RID: 1668
		[DefaultOverload]
		[Overload("DrawCachedGeometryAtCoordsWithBrush")]
		void DrawCachedGeometry([In] CanvasCachedGeometry geometry, [In] float x, [In] float y, [In] ICanvasBrush brush);

		// Token: 0x06000685 RID: 1669
		[Overload("DrawCachedGeometryAtCoordsWithColor")]
		void DrawCachedGeometry([In] CanvasCachedGeometry geometry, [In] float x, [In] float y, [In] Color color);

		// Token: 0x06000686 RID: 1670
		[DefaultOverload]
		[Overload("DrawCachedGeometryAtOriginWithBrush")]
		void DrawCachedGeometry([In] CanvasCachedGeometry geometry, [In] ICanvasBrush brush);

		// Token: 0x06000687 RID: 1671
		[Overload("DrawCachedGeometryAtOriginWithColor")]
		void DrawCachedGeometry([In] CanvasCachedGeometry geometry, [In] Color color);

		// Token: 0x06000688 RID: 1672
		[DefaultOverload]
		[Overload("DrawTextLayoutWithBrush")]
		void DrawTextLayout([In] CanvasTextLayout textLayout, [In] Vector2 point, [In] ICanvasBrush brush);

		// Token: 0x06000689 RID: 1673
		[DefaultOverload]
		[Overload("DrawTextLayoutAtCoordsWithBrush")]
		void DrawTextLayout([In] CanvasTextLayout textLayout, [In] float x, [In] float y, [In] ICanvasBrush brush);

		// Token: 0x0600068A RID: 1674
		[Overload("DrawTextLayoutWithColor")]
		void DrawTextLayout([In] CanvasTextLayout textLayout, [In] Vector2 point, [In] Color color);

		// Token: 0x0600068B RID: 1675
		[Overload("DrawTextLayoutAtCoordsWithColor")]
		void DrawTextLayout([In] CanvasTextLayout textLayout, [In] float x, [In] float y, [In] Color color);

		// Token: 0x0600068C RID: 1676
		[Overload("DrawInk")]
		void DrawInk([In] IIterable<InkStroke> inkStrokes);

		// Token: 0x0600068D RID: 1677
		[Overload("DrawInkWithHighContrast")]
		[DefaultOverload]
		void DrawInk([In] IIterable<InkStroke> inkStrokes, [In] bool highContrast);

		// Token: 0x0600068E RID: 1678
		[Overload("DrawGradientMeshAtOrigin")]
		void DrawGradientMesh([In] CanvasGradientMesh gradientMesh);

		// Token: 0x0600068F RID: 1679
		[Overload("DrawGradientMesh")]
		void DrawGradientMesh([In] CanvasGradientMesh gradientMesh, [In] Vector2 point);

		// Token: 0x06000690 RID: 1680
		[Overload("DrawGradientMeshAtCoords")]
		void DrawGradientMesh([In] CanvasGradientMesh gradientMesh, [In] float x, [In] float y);

		// Token: 0x06000691 RID: 1681
		[Overload("DrawSvgAtOrigin")]
		void DrawSvg([In] CanvasSvgDocument svgDocument, [In] Size viewportSize);

		// Token: 0x06000692 RID: 1682
		[Overload("DrawSvgAtPoint")]
		void DrawSvg([In] CanvasSvgDocument svgDocument, [In] Size viewportSize, [In] Vector2 point);

		// Token: 0x06000693 RID: 1683
		[Overload("DrawSvgAtCoords")]
		void DrawSvg([In] CanvasSvgDocument svgDocument, [In] Size viewportSize, [In] float x, [In] float y);

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000694 RID: 1684
		// (set) Token: 0x06000695 RID: 1685
		CanvasAntialiasing Antialiasing
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000696 RID: 1686
		// (set) Token: 0x06000697 RID: 1687
		CanvasBlend Blend
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000698 RID: 1688
		// (set) Token: 0x06000699 RID: 1689
		CanvasTextAntialiasing TextAntialiasing
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x0600069A RID: 1690
		// (set) Token: 0x0600069B RID: 1691
		CanvasTextRenderingParameters TextRenderingParameters
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x0600069C RID: 1692
		// (set) Token: 0x0600069D RID: 1693
		Matrix3x2 Transform
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x0600069E RID: 1694
		// (set) Token: 0x0600069F RID: 1695
		CanvasUnits Units
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x060006A0 RID: 1696
		// (set) Token: 0x060006A1 RID: 1697
		IReference<CanvasBufferPrecision> EffectBufferPrecision
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x060006A2 RID: 1698
		// (set) Token: 0x060006A3 RID: 1699
		BitmapSize EffectTileSize
		{
			get; [param: In]
			set;
		}

		// Token: 0x060006A4 RID: 1700
		[Overload("CreateLayerWithOpacity")]
		CanvasActiveLayer CreateLayer([In] float opacity);

		// Token: 0x060006A5 RID: 1701
		[DefaultOverload]
		[Overload("CreateLayerWithOpacityBrush")]
		CanvasActiveLayer CreateLayer([In] ICanvasBrush opacityBrush);

		// Token: 0x060006A6 RID: 1702
		[Overload("CreateLayerWithOpacityAndClipRectangle")]
		CanvasActiveLayer CreateLayer([In] float opacity, [In] Rect clipRectangle);

		// Token: 0x060006A7 RID: 1703
		[Overload("CreateLayerWithOpacityBrushAndClipRectangle")]
		CanvasActiveLayer CreateLayer([In] ICanvasBrush opacityBrush, [In] Rect clipRectangle);

		// Token: 0x060006A8 RID: 1704
		[Overload("CreateLayerWithOpacityAndClipGeometry")]
		CanvasActiveLayer CreateLayer([In] float opacity, [In] CanvasGeometry clipGeometry);

		// Token: 0x060006A9 RID: 1705
		[DefaultOverload]
		[Overload("CreateLayerWithOpacityBrushAndClipGeometry")]
		CanvasActiveLayer CreateLayer([In] ICanvasBrush opacityBrush, [In] CanvasGeometry clipGeometry);

		// Token: 0x060006AA RID: 1706
		[Overload("CreateLayerWithOpacityAndClipGeometryAndTransform")]
		CanvasActiveLayer CreateLayer([In] float opacity, [In] CanvasGeometry clipGeometry, [In] Matrix3x2 geometryTransform);

		// Token: 0x060006AB RID: 1707
		[DefaultOverload]
		[Overload("CreateLayerWithOpacityBrushAndClipGeometryAndTransform")]
		CanvasActiveLayer CreateLayer([In] ICanvasBrush opacityBrush, [In] CanvasGeometry clipGeometry, [In] Matrix3x2 geometryTransform);

		// Token: 0x060006AC RID: 1708
		[Overload("CreateLayerWithAllOptions")]
		CanvasActiveLayer CreateLayer([In] float opacity, [In] ICanvasBrush opacityBrush, [In] Rect clipRectangle, [In] CanvasGeometry clipGeometry, [In] Matrix3x2 geometryTransform, [In] CanvasLayerOptions options);

		// Token: 0x060006AD RID: 1709
		[Overload("DrawGlyphRun")]
		void DrawGlyphRun([In] Vector2 point, [In] CanvasFontFace fontFace, [In] float fontSize, [In] CanvasGlyph[] glyphs, [In] bool isSideways, [In] uint bidiLevel, [In] ICanvasBrush brush);

		// Token: 0x060006AE RID: 1710
		[Overload("DrawGlyphRunWithMeasuringMode")]
		void DrawGlyphRun([In] Vector2 point, [In] CanvasFontFace fontFace, [In] float fontSize, [In] CanvasGlyph[] glyphs, [In] bool isSideways, [In] uint bidiLevel, [In] ICanvasBrush brush, [In] CanvasTextMeasuringMode measuringMode);

		// Token: 0x060006AF RID: 1711
		[Overload("DrawGlyphRunWithMeasuringModeAndDescription")]
		void DrawGlyphRun([In] Vector2 point, [In] CanvasFontFace fontFace, [In] float fontSize, [In] CanvasGlyph[] glyphs, [In] bool isSideways, [In] uint bidiLevel, [In] ICanvasBrush brush, [In] CanvasTextMeasuringMode measuringMode, [In] string localeName, [In] string textString, [In] int[] clusterMapIndices, [In] uint textPosition);

		// Token: 0x060006B0 RID: 1712
		[Overload("CreateSpriteBatch")]
		CanvasSpriteBatch CreateSpriteBatch();

		// Token: 0x060006B1 RID: 1713
		[Overload("CreateSpriteBatchWithSortMode")]
		CanvasSpriteBatch CreateSpriteBatch([In] CanvasSpriteSortMode sortMode);

		// Token: 0x060006B2 RID: 1714
		[Overload("CreateSpriteBatchWithSortModeAndInterpolation")]
		CanvasSpriteBatch CreateSpriteBatch([In] CanvasSpriteSortMode sortMode, [In] CanvasImageInterpolation interpolation);

		// Token: 0x060006B3 RID: 1715
		[Overload("CreateSpriteBatchWithSortModeAndInterpolationAndOptions")]
		CanvasSpriteBatch CreateSpriteBatch([In] CanvasSpriteSortMode sortMode, [In] CanvasImageInterpolation interpolation, [In] CanvasSpriteOptions options);
	}
}
