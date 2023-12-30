using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Microsoft.Graphics.Canvas.Svg
{
	// Token: 0x020000C3 RID: 195
	[Threading(3)]
	[MarshalingBehavior(2)]
	[Version(167772160U)]
	public sealed class CanvasSvgPointsAttribute : ICanvasSvgPointsAttribute, ICanvasSvgAttribute, IClosable
	{
		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x060005CD RID: 1485
		public extern Vector2[] Points { get; }

		// Token: 0x060005CE RID: 1486
		public extern Vector2[] GetPoints([In] int startIndex, [In] int elementCount);

		// Token: 0x060005CF RID: 1487
		public extern void RemovePointsAtEnd([In] int pointCount);

		// Token: 0x060005D0 RID: 1488
		public extern void SetPoints([In] int startIndex, [In] Vector2[] points);

		// Token: 0x060005D1 RID: 1489
		public extern void Close();

		// Token: 0x060005D2 RID: 1490
		public extern ICanvasSvgAttribute Clone();

		// Token: 0x060005D3 RID: 1491
		public extern CanvasSvgNamedElement GetElement();

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x060005D4 RID: 1492
		public extern CanvasDevice Device { get; }
	}
}
