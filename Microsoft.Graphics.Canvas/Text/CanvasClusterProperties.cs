using System;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	// Token: 0x02000069 RID: 105
	[Version(167772160U)]
	[Flags]
	public enum CanvasClusterProperties : uint
	{
		// Token: 0x0400014A RID: 330
		None = 0U,
		// Token: 0x0400014B RID: 331
		CanWrapLineAfter = 1U,
		// Token: 0x0400014C RID: 332
		Whitespace = 2U,
		// Token: 0x0400014D RID: 333
		Newline = 4U,
		// Token: 0x0400014E RID: 334
		SoftHyphen = 8U,
		// Token: 0x0400014F RID: 335
		RightToLeft = 16U
	}
}
