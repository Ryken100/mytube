using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Svg
{
	// Token: 0x020000B8 RID: 184
	[Guid(1697089192U, 62379, 16515, 153, 29, 151, 72, 170, 134, 189, 110)]
	[Version(167772160U)]
	public interface ICanvasSvgAttribute : IClosable
	{
		// Token: 0x06000567 RID: 1383
		ICanvasSvgAttribute Clone();

		// Token: 0x06000568 RID: 1384
		CanvasSvgNamedElement GetElement();

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06000569 RID: 1385
		CanvasDevice Device { get; }
	}
}
