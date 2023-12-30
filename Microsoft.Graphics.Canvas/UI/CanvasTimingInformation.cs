using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.UI
{
	// Token: 0x020000E0 RID: 224
	[Version(167772160U)]
	public struct CanvasTimingInformation
	{
		// Token: 0x0400024D RID: 589
		public long UpdateCount;

		// Token: 0x0400024E RID: 590
		public TimeSpan TotalTime;

		// Token: 0x0400024F RID: 591
		public TimeSpan ElapsedTime;

		// Token: 0x04000250 RID: 592
		public bool IsRunningSlowly;
	}
}
