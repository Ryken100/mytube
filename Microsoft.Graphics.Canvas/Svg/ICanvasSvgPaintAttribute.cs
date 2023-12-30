using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Microsoft.Graphics.Canvas.Svg
{
	// Token: 0x020000BD RID: 189
	[Guid(1698137768U, 62379, 16515, 153, 29, 151, 72, 170, 134, 189, 110)]
	[Version(167772160U)]
	[ExclusiveTo(typeof(CanvasSvgPaintAttribute))]
	internal interface ICanvasSvgPaintAttribute : IClosable, ICanvasSvgAttribute
	{
		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x060005A2 RID: 1442
		// (set) Token: 0x060005A1 RID: 1441
		CanvasSvgPaintType PaintType
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x060005A4 RID: 1444
		// (set) Token: 0x060005A3 RID: 1443
		Color Color
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x060005A6 RID: 1446
		// (set) Token: 0x060005A5 RID: 1445
		string Id
		{
			get; [param: In]
			set;
		}
	}
}
