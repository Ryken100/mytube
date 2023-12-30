using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Microsoft.Graphics.Canvas.Geometry
{
	// Token: 0x0200008A RID: 138
	[Version(167772160U)]
	[Guid(1894142835U, 32691, 17989, 139, 109, 246, 22, 209, 185, 169, 215)]
	public interface ICanvasPathReceiver
	{
		// Token: 0x06000458 RID: 1112
		void BeginFigure([In] Vector2 startPoint, [In] CanvasFigureFill figureFill);

		// Token: 0x06000459 RID: 1113
		void AddArc([In] Vector2 endPoint, [In] float radiusX, [In] float radiusY, [In] float rotationAngle, [In] CanvasSweepDirection sweepDirection, [In] CanvasArcSize arcSize);

		// Token: 0x0600045A RID: 1114
		void AddCubicBezier([In] Vector2 controlPoint1, [In] Vector2 controlPoint2, [In] Vector2 endPoint);

		// Token: 0x0600045B RID: 1115
		void AddLine([In] Vector2 endPoint);

		// Token: 0x0600045C RID: 1116
		void AddQuadraticBezier([In] Vector2 controlPoint, [In] Vector2 endPoint);

		// Token: 0x0600045D RID: 1117
		void SetFilledRegionDetermination([In] CanvasFilledRegionDetermination filledRegionDetermination);

		// Token: 0x0600045E RID: 1118
		void SetSegmentOptions([In] CanvasFigureSegmentOptions figureSegmentOptions);

		// Token: 0x0600045F RID: 1119
		void EndFigure([In] CanvasFigureLoop figureLoop);
	}
}
