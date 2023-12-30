using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Microsoft.Graphics.Canvas.Svg
{
	// Token: 0x020000BE RID: 190
	[MarshalingBehavior(2)]
	[Threading(3)]
	[Version(167772160U)]
	public sealed class CanvasSvgPaintAttribute : ICanvasSvgPaintAttribute, ICanvasSvgAttribute, IClosable
	{
		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x060005A8 RID: 1448
		// (set) Token: 0x060005A7 RID: 1447
		public extern CanvasSvgPaintType PaintType
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x060005AA RID: 1450
		// (set) Token: 0x060005A9 RID: 1449
		public extern Color Color
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x060005AC RID: 1452
		// (set) Token: 0x060005AB RID: 1451
		public extern string Id
		{
			get; [param: In]
			set;
		}

		// Token: 0x060005AD RID: 1453
		public extern void Close();

		// Token: 0x060005AE RID: 1454
		public extern ICanvasSvgAttribute Clone();

		// Token: 0x060005AF RID: 1455
		public extern CanvasSvgNamedElement GetElement();

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x060005B0 RID: 1456
		public extern CanvasDevice Device { get; }
	}
}
