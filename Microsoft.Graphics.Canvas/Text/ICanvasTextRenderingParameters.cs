using System;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	// Token: 0x0200007E RID: 126
	[Guid(2987128632U, 60857, 20204, 161, 47, 182, 174, 50, 232, 172, 230)]
	[Version(167772160U)]
	[ExclusiveTo(typeof(CanvasTextRenderingParameters))]
	internal interface ICanvasTextRenderingParameters
	{
		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06000424 RID: 1060
		CanvasTextRenderingMode RenderingMode { get; }

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06000425 RID: 1061
		CanvasTextGridFit GridFit { get; }
	}
}
