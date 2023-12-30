using System;
using System.Runtime.InteropServices;
using Microsoft.Graphics.Canvas.Geometry;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Svg
{
	// Token: 0x020000C0 RID: 192
	[Version(167772160U)]
	[ExclusiveTo(typeof(CanvasSvgPathAttribute))]
	[Guid(1697089192U, 62379, 16515, 153, 29, 151, 72, 171, 134, 189, 110)]
	internal interface ICanvasSvgPathAttribute : IClosable, ICanvasSvgAttribute
	{
		// Token: 0x060005B1 RID: 1457
		[Overload("CreatePathGeometry")]
		CanvasGeometry CreatePathGeometry();

		// Token: 0x060005B2 RID: 1458
		[DefaultOverload]
		[Overload("CreatePathGeometryWithFill")]
		CanvasGeometry CreatePathGeometry([In] CanvasFilledRegionDetermination fill);

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x060005B3 RID: 1459
		CanvasSvgPathCommand[] Commands { get; }

		// Token: 0x060005B4 RID: 1460
		CanvasSvgPathCommand[] GetCommands([In] int startIndex, [In] int elementCount);

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x060005B5 RID: 1461
		float[] SegmentData { get; }

		// Token: 0x060005B6 RID: 1462
		float[] GetSegmentData([In] int startIndex, [In] int elementCount);

		// Token: 0x060005B7 RID: 1463
		void RemoveCommandsAtEnd([In] int commandsCount);

		// Token: 0x060005B8 RID: 1464
		void RemoveSegmentDataAtEnd([In] int commandsCount);

		// Token: 0x060005B9 RID: 1465
		void SetCommands([In] int startIndex, [In] CanvasSvgPathCommand[] commands);

		// Token: 0x060005BA RID: 1466
		void SetSegmentData([In] int startIndex, [In] float[] segmentData);
	}
}
