using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Svg
{
	[ComImport]
	[MarshalingBehavior(MarshalingType.Agile)]
	[Version(167772160u)]
	[Threading(ThreadingModel.Both)]
	public sealed class CanvasSvgStrokeDashArrayAttribute : ICanvasSvgStrokeDashArrayAttribute, ICanvasSvgAttribute, IDisposable
	{
		public extern CanvasDevice Device
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetDashes")]
		public extern float[] GetDashes();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetDashesWithUnits")]
		[DefaultOverload]
		public extern float[] GetDashes([In] int startIndex, [In] int elementCount, out CanvasSvgLengthUnits[] outputUnitsElements);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void RemoveDashesAtEnd([In] int dashCount);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("SetDashes")]
		public extern void SetDashes([In] int startIndex, [In] float[] dashes);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("SetDashesWithUnit")]
		public extern void SetDashes([In] int startIndex, [In] float[] dashes, [In] CanvasSvgLengthUnits units);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("SetDashesWithUnits")]
		public extern void SetDashes([In] int startIndex, [In] float[] dashValues, [In] CanvasSvgLengthUnits[] unitValues);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void Dispose();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern ICanvasSvgAttribute Clone();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern CanvasSvgNamedElement GetElement();
	}
}
