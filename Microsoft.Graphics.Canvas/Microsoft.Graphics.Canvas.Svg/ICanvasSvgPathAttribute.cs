using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Graphics.Canvas.Geometry;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Svg
{
	[ComImport]
	[Version(167772160u)]
	[ExclusiveTo(typeof(CanvasSvgPathAttribute))]
	[Windows.Foundation.Metadata.Guid(1697089192u, 62379, 16515, 153, 29, 151, 72, 171, 134, 189, 110)]
	internal interface ICanvasSvgPathAttribute : IDisposable, ICanvasSvgAttribute
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreatePathGeometry")]
		CanvasGeometry CreatePathGeometry();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("CreatePathGeometryWithFill")]
		CanvasGeometry CreatePathGeometry([In] CanvasFilledRegionDetermination fill);

		CanvasSvgPathCommand[] Commands
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasSvgPathCommand[] GetCommands([In] int startIndex, [In] int elementCount);

		float[] SegmentData
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		float[] GetSegmentData([In] int startIndex, [In] int elementCount);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void RemoveCommandsAtEnd([In] int commandsCount);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void RemoveSegmentDataAtEnd([In] int commandsCount);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetCommands([In] int startIndex, [In] CanvasSvgPathCommand[] commands);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetSegmentData([In] int startIndex, [In] float[] segmentData);
	}
}
