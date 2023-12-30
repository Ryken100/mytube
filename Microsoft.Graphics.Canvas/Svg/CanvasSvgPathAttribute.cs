using System;
using System.Runtime.InteropServices;
using Microsoft.Graphics.Canvas.Geometry;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Svg
{
	// Token: 0x020000C1 RID: 193
	[Version(167772160U)]
	[Threading(3)]
	[MarshalingBehavior(2)]
	public sealed class CanvasSvgPathAttribute : ICanvasSvgPathAttribute, ICanvasSvgAttribute, IClosable
	{
		// Token: 0x060005BB RID: 1467
		[Overload("CreatePathGeometry")]
		public extern CanvasGeometry CreatePathGeometry();

		// Token: 0x060005BC RID: 1468
		[Overload("CreatePathGeometryWithFill")]
		[DefaultOverload]
		public extern CanvasGeometry CreatePathGeometry([In] CanvasFilledRegionDetermination fill);

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x060005BD RID: 1469
		public extern CanvasSvgPathCommand[] Commands { get; }

		// Token: 0x060005BE RID: 1470
		public extern CanvasSvgPathCommand[] GetCommands([In] int startIndex, [In] int elementCount);

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x060005BF RID: 1471
		public extern float[] SegmentData { get; }

		// Token: 0x060005C0 RID: 1472
		public extern float[] GetSegmentData([In] int startIndex, [In] int elementCount);

		// Token: 0x060005C1 RID: 1473
		public extern void RemoveCommandsAtEnd([In] int commandsCount);

		// Token: 0x060005C2 RID: 1474
		public extern void RemoveSegmentDataAtEnd([In] int commandsCount);

		// Token: 0x060005C3 RID: 1475
		public extern void SetCommands([In] int startIndex, [In] CanvasSvgPathCommand[] commands);

		// Token: 0x060005C4 RID: 1476
		public extern void SetSegmentData([In] int startIndex, [In] float[] segmentData);

		// Token: 0x060005C5 RID: 1477
		public extern void Close();

		// Token: 0x060005C6 RID: 1478
		public extern ICanvasSvgAttribute Clone();

		// Token: 0x060005C7 RID: 1479
		public extern CanvasSvgNamedElement GetElement();

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x060005C8 RID: 1480
		public extern CanvasDevice Device { get; }
	}
}
