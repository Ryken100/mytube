using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Microsoft.Graphics.Canvas.Geometry
{
	// Token: 0x02000070 RID: 112
	[ExclusiveTo(typeof(CanvasPathBuilder))]
	[Version(167772160U)]
	[Guid(3170206255U, 33063, 20060, 150, 184, 41, 152, 59, 145, 85, 65)]
	internal interface ICanvasPathBuilder : IClosable
	{
		// Token: 0x060003C0 RID: 960
		[DefaultOverload]
		[Overload("BeginFigureWithFigureFill")]
		void BeginFigure([In] Vector2 startPoint, [In] CanvasFigureFill figureFill);

		// Token: 0x060003C1 RID: 961
		[Overload("BeginFigure")]
		[DefaultOverload]
		void BeginFigure([In] Vector2 startPoint);

		// Token: 0x060003C2 RID: 962
		[DefaultOverload]
		[Overload("BeginFigureAtCoordsWithFigureFill")]
		void BeginFigure([In] float startX, [In] float startY, [In] CanvasFigureFill figureFill);

		// Token: 0x060003C3 RID: 963
		[Overload("BeginFigureAtCoords")]
		void BeginFigure([In] float startX, [In] float startY);

		// Token: 0x060003C4 RID: 964
		[Overload("AddArcToPoint")]
		void AddArc([In] Vector2 endPoint, [In] float radiusX, [In] float radiusY, [In] float rotationAngle, [In] CanvasSweepDirection sweepDirection, [In] CanvasArcSize arcSize);

		// Token: 0x060003C5 RID: 965
		[Overload("AddArcAroundEllipse")]
		void AddArc([In] Vector2 centerPoint, [In] float radiusX, [In] float radiusY, [In] float startAngle, [In] float sweepAngle);

		// Token: 0x060003C6 RID: 966
		void AddCubicBezier([In] Vector2 controlPoint1, [In] Vector2 controlPoint2, [In] Vector2 endPoint);

		// Token: 0x060003C7 RID: 967
		[Overload("AddLine")]
		[DefaultOverload]
		void AddLine([In] Vector2 endPoint);

		// Token: 0x060003C8 RID: 968
		[Overload("AddLineWithCoords")]
		void AddLine([In] float x, [In] float y);

		// Token: 0x060003C9 RID: 969
		void AddQuadraticBezier([In] Vector2 controlPoint, [In] Vector2 endPoint);

		// Token: 0x060003CA RID: 970
		void SetFilledRegionDetermination([In] CanvasFilledRegionDetermination filledRegionDetermination);

		// Token: 0x060003CB RID: 971
		void SetSegmentOptions([In] CanvasFigureSegmentOptions figureSegmentOptions);

		// Token: 0x060003CC RID: 972
		void EndFigure([In] CanvasFigureLoop figureLoop);

		// Token: 0x060003CD RID: 973
		void AddGeometry([In] CanvasGeometry geometry);
	}
}
