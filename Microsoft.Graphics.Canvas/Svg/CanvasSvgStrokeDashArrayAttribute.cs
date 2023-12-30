using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Svg
{
	// Token: 0x020000C5 RID: 197
	[MarshalingBehavior(2)]
	[Version(167772160U)]
	[Threading(3)]
	public sealed class CanvasSvgStrokeDashArrayAttribute : ICanvasSvgStrokeDashArrayAttribute, ICanvasSvgAttribute, IClosable
	{
		// Token: 0x060005DB RID: 1499
		[Overload("GetDashes")]
		public extern float[] GetDashes();

		// Token: 0x060005DC RID: 1500
		[Overload("GetDashesWithUnits")]
		[DefaultOverload]
		public extern float[] GetDashes([In] int startIndex, [In] int elementCount, out CanvasSvgLengthUnits[] outputUnitsElements);

		// Token: 0x060005DD RID: 1501
		public extern void RemoveDashesAtEnd([In] int dashCount);

		// Token: 0x060005DE RID: 1502
		[Overload("SetDashes")]
		public extern void SetDashes([In] int startIndex, [In] float[] dashes);

		// Token: 0x060005DF RID: 1503
		[Overload("SetDashesWithUnit")]
		public extern void SetDashes([In] int startIndex, [In] float[] dashes, [In] CanvasSvgLengthUnits units);

		// Token: 0x060005E0 RID: 1504
		[DefaultOverload]
		[Overload("SetDashesWithUnits")]
		public extern void SetDashes([In] int startIndex, [In] float[] dashValues, [In] CanvasSvgLengthUnits[] unitValues);

		// Token: 0x060005E1 RID: 1505
		public extern void Close();

		// Token: 0x060005E2 RID: 1506
		public extern ICanvasSvgAttribute Clone();

		// Token: 0x060005E3 RID: 1507
		public extern CanvasSvgNamedElement GetElement();

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x060005E4 RID: 1508
		public extern CanvasDevice Device { get; }
	}
}
