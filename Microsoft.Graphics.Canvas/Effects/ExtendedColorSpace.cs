using System;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000104 RID: 260
	[Version(167772160U)]
	public enum ExtendedColorSpace
	{
		// Token: 0x04000267 RID: 615
		FullG22P709,
		// Token: 0x04000268 RID: 616
		FullG10P709,
		// Token: 0x04000269 RID: 617
		StudioG22P709,
		// Token: 0x0400026A RID: 618
		StudioG22P2020,
		// Token: 0x0400026B RID: 619
		FullG2084P2020 = 12,
		// Token: 0x0400026C RID: 620
		StudioG2084P2020 = 14,
		// Token: 0x0400026D RID: 621
		FullG22P2020 = 17,
		// Token: 0x0400026E RID: 622
		Custom = -1
	}
}
