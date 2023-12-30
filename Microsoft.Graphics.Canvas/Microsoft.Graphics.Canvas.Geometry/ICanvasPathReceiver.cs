using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Geometry
{
	[ComImport]
	[Version(167772160u)]
	[Windows.Foundation.Metadata.Guid(1894142835u, 32691, 17989, 139, 109, 246, 22, 209, 185, 169, 215)]
	public interface ICanvasPathReceiver
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void BeginFigure([In] Vector2 startPoint, [In] CanvasFigureFill figureFill);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void AddArc([In] Vector2 endPoint, [In] float radiusX, [In] float radiusY, [In] float rotationAngle, [In] CanvasSweepDirection sweepDirection, [In] CanvasArcSize arcSize);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void AddCubicBezier([In] Vector2 controlPoint1, [In] Vector2 controlPoint2, [In] Vector2 endPoint);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void AddLine([In] Vector2 endPoint);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void AddQuadraticBezier([In] Vector2 controlPoint, [In] Vector2 endPoint);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetFilledRegionDetermination([In] CanvasFilledRegionDetermination filledRegionDetermination);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetSegmentOptions([In] CanvasFigureSegmentOptions figureSegmentOptions);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void EndFigure([In] CanvasFigureLoop figureLoop);
	}
}
