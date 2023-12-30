using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Svg
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(1697089192u, 62379, 16515, 153, 29, 151, 72, 170, 134, 189, 112)]
	[ExclusiveTo(typeof(CanvasSvgStrokeDashArrayAttribute))]
	[Version(167772160u)]
	internal interface ICanvasSvgStrokeDashArrayAttribute : IDisposable, ICanvasSvgAttribute
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetDashes")]
		float[] GetDashes();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetDashesWithUnits")]
		[DefaultOverload]
		float[] GetDashes([In] int startIndex, [In] int elementCount, out CanvasSvgLengthUnits[] outputUnitsElements);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void RemoveDashesAtEnd([In] int dashCount);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("SetDashes")]
		void SetDashes([In] int startIndex, [In] float[] dashes);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("SetDashesWithUnit")]
		void SetDashes([In] int startIndex, [In] float[] dashes, [In] CanvasSvgLengthUnits units);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("SetDashesWithUnits")]
		[DefaultOverload]
		void SetDashes([In] int startIndex, [In] float[] dashValues, [In] CanvasSvgLengthUnits[] unitValues);
	}
}
