using System;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	// Token: 0x0200007C RID: 124
	[Version(167772160U)]
	public enum CanvasTextRenderingMode
	{
		// Token: 0x04000178 RID: 376
		Default,
		// Token: 0x04000179 RID: 377
		Aliased,
		// Token: 0x0400017A RID: 378
		GdiClassic,
		// Token: 0x0400017B RID: 379
		GdiNatural,
		// Token: 0x0400017C RID: 380
		Natural,
		// Token: 0x0400017D RID: 381
		NaturalSymmetric,
		// Token: 0x0400017E RID: 382
		Outline,
		// Token: 0x0400017F RID: 383
		NaturalSymmetricDownsampled
	}
}
