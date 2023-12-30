using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Geometry
{
	[ComImport]
	[ExclusiveTo(typeof(CanvasPathBuilder))]
	[Version(167772160u)]
	[Windows.Foundation.Metadata.Guid(3170206255u, 33063, 20060, 150, 184, 41, 152, 59, 145, 85, 65)]
	internal interface ICanvasPathBuilder : IDisposable
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("BeginFigureWithFigureFill")]
		void BeginFigure([In] Vector2 startPoint, [In] CanvasFigureFill figureFill);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("BeginFigure")]
		[DefaultOverload]
		void BeginFigure([In] Vector2 startPoint);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("BeginFigureAtCoordsWithFigureFill")]
		void BeginFigure([In] float startX, [In] float startY, [In] CanvasFigureFill figureFill);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("BeginFigureAtCoords")]
		void BeginFigure([In] float startX, [In] float startY);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("AddArcToPoint")]
		void AddArc([In] Vector2 endPoint, [In] float radiusX, [In] float radiusY, [In] float rotationAngle, [In] CanvasSweepDirection sweepDirection, [In] CanvasArcSize arcSize);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("AddArcAroundEllipse")]
		void AddArc([In] Vector2 centerPoint, [In] float radiusX, [In] float radiusY, [In] float startAngle, [In] float sweepAngle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void AddCubicBezier([In] Vector2 controlPoint1, [In] Vector2 controlPoint2, [In] Vector2 endPoint);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("AddLine")]
		[DefaultOverload]
		void AddLine([In] Vector2 endPoint);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("AddLineWithCoords")]
		void AddLine([In] float x, [In] float y);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void AddQuadraticBezier([In] Vector2 controlPoint, [In] Vector2 endPoint);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetFilledRegionDetermination([In] CanvasFilledRegionDetermination filledRegionDetermination);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetSegmentOptions([In] CanvasFigureSegmentOptions figureSegmentOptions);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void EndFigure([In] CanvasFigureLoop figureLoop);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void AddGeometry([In] CanvasGeometry geometry);
	}
}
