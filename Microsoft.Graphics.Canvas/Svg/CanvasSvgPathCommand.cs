using System;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Svg
{
	// Token: 0x020000BF RID: 191
	[Version(167772160U)]
	public enum CanvasSvgPathCommand
	{
		// Token: 0x04000235 RID: 565
		ClosePath,
		// Token: 0x04000236 RID: 566
		MoveAbsolute,
		// Token: 0x04000237 RID: 567
		MoveRelative,
		// Token: 0x04000238 RID: 568
		LineAbsolute,
		// Token: 0x04000239 RID: 569
		LineRelative,
		// Token: 0x0400023A RID: 570
		CubicAbsolute,
		// Token: 0x0400023B RID: 571
		CubicRelative,
		// Token: 0x0400023C RID: 572
		QuadraticAbsolute,
		// Token: 0x0400023D RID: 573
		QuadraticRelative,
		// Token: 0x0400023E RID: 574
		ArcAbsolute,
		// Token: 0x0400023F RID: 575
		ArcRelative,
		// Token: 0x04000240 RID: 576
		HorizontalAbsolute,
		// Token: 0x04000241 RID: 577
		HorizontalRelative,
		// Token: 0x04000242 RID: 578
		VerticalAbsolute,
		// Token: 0x04000243 RID: 579
		VerticalRelative,
		// Token: 0x04000244 RID: 580
		CubicSmoothAbsolute,
		// Token: 0x04000245 RID: 581
		CubicSmoothRelative,
		// Token: 0x04000246 RID: 582
		QuadraticSmoothAbsolute,
		// Token: 0x04000247 RID: 583
		QuadraticSmoothRelative
	}
}
