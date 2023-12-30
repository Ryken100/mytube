using System;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	// Token: 0x0200009C RID: 156
	[MarshalingBehavior(2)]
	[Version(167772160U)]
	[Threading(3)]
	public sealed class CanvasScaledFont : ICanvasScaledFont
	{
		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x060004C1 RID: 1217
		public extern CanvasFontFace FontFace { get; }

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x060004C2 RID: 1218
		public extern float ScaleFactor { get; }
	}
}
