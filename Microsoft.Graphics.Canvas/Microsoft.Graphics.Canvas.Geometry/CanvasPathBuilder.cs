using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Geometry
{
	[ComImport]
	[Threading(ThreadingModel.Both)]
	[Activatable(typeof(ICanvasPathBuilderFactory), 167772160u)]
	[MarshalingBehavior(MarshalingType.Agile)]
	[Version(167772160u)]
	public sealed class CanvasPathBuilder : ICanvasPathBuilder, IDisposable
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("BeginFigureWithFigureFill")]
		[DefaultOverload]
		public extern void BeginFigure([In] Vector2 startPoint, [In] CanvasFigureFill figureFill);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("BeginFigure")]
		public extern void BeginFigure([In] Vector2 startPoint);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("BeginFigureAtCoordsWithFigureFill")]
		public extern void BeginFigure([In] float startX, [In] float startY, [In] CanvasFigureFill figureFill);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("BeginFigureAtCoords")]
		public extern void BeginFigure([In] float startX, [In] float startY);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("AddArcToPoint")]
		public extern void AddArc([In] Vector2 endPoint, [In] float radiusX, [In] float radiusY, [In] float rotationAngle, [In] CanvasSweepDirection sweepDirection, [In] CanvasArcSize arcSize);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("AddArcAroundEllipse")]
		public extern void AddArc([In] Vector2 centerPoint, [In] float radiusX, [In] float radiusY, [In] float startAngle, [In] float sweepAngle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void AddCubicBezier([In] Vector2 controlPoint1, [In] Vector2 controlPoint2, [In] Vector2 endPoint);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("AddLine")]
		[DefaultOverload]
		public extern void AddLine([In] Vector2 endPoint);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("AddLineWithCoords")]
		public extern void AddLine([In] float x, [In] float y);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void AddQuadraticBezier([In] Vector2 controlPoint, [In] Vector2 endPoint);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void SetFilledRegionDetermination([In] CanvasFilledRegionDetermination filledRegionDetermination);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void SetSegmentOptions([In] CanvasFigureSegmentOptions figureSegmentOptions);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void EndFigure([In] CanvasFigureLoop figureLoop);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void AddGeometry([In] CanvasGeometry geometry);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void Dispose();
	}
}
