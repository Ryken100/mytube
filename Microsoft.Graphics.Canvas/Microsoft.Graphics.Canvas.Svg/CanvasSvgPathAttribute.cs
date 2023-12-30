using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Graphics.Canvas.Geometry;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Svg
{
	[ComImport]
	[Version(167772160u)]
	[Threading(ThreadingModel.Both)]
	[MarshalingBehavior(MarshalingType.Agile)]
	public sealed class CanvasSvgPathAttribute : ICanvasSvgPathAttribute, ICanvasSvgAttribute, IDisposable
	{
		public extern CanvasDevice Device
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern CanvasSvgPathCommand[] Commands
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern float[] SegmentData
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreatePathGeometry")]
		public extern CanvasGeometry CreatePathGeometry();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreatePathGeometryWithFill")]
		[DefaultOverload]
		public extern CanvasGeometry CreatePathGeometry([In] CanvasFilledRegionDetermination fill);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern CanvasSvgPathCommand[] GetCommands([In] int startIndex, [In] int elementCount);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern float[] GetSegmentData([In] int startIndex, [In] int elementCount);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void RemoveCommandsAtEnd([In] int commandsCount);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void RemoveSegmentDataAtEnd([In] int commandsCount);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void SetCommands([In] int startIndex, [In] CanvasSvgPathCommand[] commands);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void SetSegmentData([In] int startIndex, [In] float[] segmentData);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void Dispose();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern ICanvasSvgAttribute Clone();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern CanvasSvgNamedElement GetElement();
	}
}
