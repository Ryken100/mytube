using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Svg
{
	// Token: 0x020000C4 RID: 196
	[Guid(1697089192U, 62379, 16515, 153, 29, 151, 72, 170, 134, 189, 112)]
	[ExclusiveTo(typeof(CanvasSvgStrokeDashArrayAttribute))]
	[Version(167772160U)]
	internal interface ICanvasSvgStrokeDashArrayAttribute : IClosable, ICanvasSvgAttribute
	{
		// Token: 0x060005D5 RID: 1493
		[Overload("GetDashes")]
		float[] GetDashes();

		// Token: 0x060005D6 RID: 1494
		[Overload("GetDashesWithUnits")]
		[DefaultOverload]
		float[] GetDashes([In] int startIndex, [In] int elementCount, out CanvasSvgLengthUnits[] outputUnitsElements);

		// Token: 0x060005D7 RID: 1495
		void RemoveDashesAtEnd([In] int dashCount);

		// Token: 0x060005D8 RID: 1496
		[Overload("SetDashes")]
		void SetDashes([In] int startIndex, [In] float[] dashes);

		// Token: 0x060005D9 RID: 1497
		[Overload("SetDashesWithUnit")]
		void SetDashes([In] int startIndex, [In] float[] dashes, [In] CanvasSvgLengthUnits units);

		// Token: 0x060005DA RID: 1498
		[Overload("SetDashesWithUnits")]
		[DefaultOverload]
		void SetDashes([In] int startIndex, [In] float[] dashValues, [In] CanvasSvgLengthUnits[] unitValues);
	}
}
