using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	// Token: 0x02000080 RID: 128
	[Version(167772160U)]
	[Activatable(typeof(ICanvasTextRenderingParametersFactory), 167772160U)]
	[Threading(3)]
	[MarshalingBehavior(2)]
	public sealed class CanvasTextRenderingParameters : ICanvasTextRenderingParameters
	{
		// Token: 0x06000427 RID: 1063
		public extern CanvasTextRenderingParameters([In] CanvasTextRenderingMode textRenderingMode, [In] CanvasTextGridFit gridFit);

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06000428 RID: 1064
		public extern CanvasTextRenderingMode RenderingMode { get; }

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06000429 RID: 1065
		public extern CanvasTextGridFit GridFit { get; }
	}
}
