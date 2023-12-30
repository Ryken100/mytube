using System;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Svg
{
	// Token: 0x020000BC RID: 188
	[Version(167772160U)]
	public enum CanvasSvgPaintType
	{
		// Token: 0x0400022D RID: 557
		None,
		// Token: 0x0400022E RID: 558
		Color,
		// Token: 0x0400022F RID: 559
		CurrentColor,
		// Token: 0x04000230 RID: 560
		Uri,
		// Token: 0x04000231 RID: 561
		UriThenNone,
		// Token: 0x04000232 RID: 562
		UriThenColor,
		// Token: 0x04000233 RID: 563
		UriThenCurrentColor
	}
}
