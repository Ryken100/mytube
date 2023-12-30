using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Microsoft.Graphics.Canvas.Geometry
{
	// Token: 0x02000073 RID: 115
	[Threading(3)]
	[Activatable(typeof(ICanvasPathBuilderFactory), 167772160U)]
	[MarshalingBehavior(2)]
	[Version(167772160U)]
	public sealed class CanvasPathBuilder : ICanvasPathBuilder, IClosable
	{
		// Token: 0x06000404 RID: 1028
		public extern CanvasPathBuilder([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x06000405 RID: 1029
		[Overload("BeginFigureWithFigureFill")]
		[DefaultOverload]
		public extern void BeginFigure([In] Vector2 startPoint, [In] CanvasFigureFill figureFill);

		// Token: 0x06000406 RID: 1030
		[DefaultOverload]
		[Overload("BeginFigure")]
		public extern void BeginFigure([In] Vector2 startPoint);

		// Token: 0x06000407 RID: 1031
		[DefaultOverload]
		[Overload("BeginFigureAtCoordsWithFigureFill")]
		public extern void BeginFigure([In] float startX, [In] float startY, [In] CanvasFigureFill figureFill);

		// Token: 0x06000408 RID: 1032
		[Overload("BeginFigureAtCoords")]
		public extern void BeginFigure([In] float startX, [In] float startY);

		// Token: 0x06000409 RID: 1033
		[Overload("AddArcToPoint")]
		public extern void AddArc([In] Vector2 endPoint, [In] float radiusX, [In] float radiusY, [In] float rotationAngle, [In] CanvasSweepDirection sweepDirection, [In] CanvasArcSize arcSize);

		// Token: 0x0600040A RID: 1034
		[Overload("AddArcAroundEllipse")]
		public extern void AddArc([In] Vector2 centerPoint, [In] float radiusX, [In] float radiusY, [In] float startAngle, [In] float sweepAngle);

		// Token: 0x0600040B RID: 1035
		public extern void AddCubicBezier([In] Vector2 controlPoint1, [In] Vector2 controlPoint2, [In] Vector2 endPoint);

		// Token: 0x0600040C RID: 1036
		[Overload("AddLine")]
		[DefaultOverload]
		public extern void AddLine([In] Vector2 endPoint);

		// Token: 0x0600040D RID: 1037
		[Overload("AddLineWithCoords")]
		public extern void AddLine([In] float x, [In] float y);

		// Token: 0x0600040E RID: 1038
		public extern void AddQuadraticBezier([In] Vector2 controlPoint, [In] Vector2 endPoint);

		// Token: 0x0600040F RID: 1039
		public extern void SetFilledRegionDetermination([In] CanvasFilledRegionDetermination filledRegionDetermination);

		// Token: 0x06000410 RID: 1040
		public extern void SetSegmentOptions([In] CanvasFigureSegmentOptions figureSegmentOptions);

		// Token: 0x06000411 RID: 1041
		public extern void EndFigure([In] CanvasFigureLoop figureLoop);

		// Token: 0x06000412 RID: 1042
		public extern void AddGeometry([In] CanvasGeometry geometry);

		// Token: 0x06000413 RID: 1043
		public extern void Close();
	}
}
