using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	// Token: 0x02000085 RID: 133
	[Version(167772160U)]
	public struct CanvasGlyphMetrics
	{
		// Token: 0x040001AA RID: 426
		public float LeftSideBearing;

		// Token: 0x040001AB RID: 427
		public float AdvanceWidth;

		// Token: 0x040001AC RID: 428
		public float RightSideBearing;

		// Token: 0x040001AD RID: 429
		public float TopSideBearing;

		// Token: 0x040001AE RID: 430
		public float AdvanceHeight;

		// Token: 0x040001AF RID: 431
		public float BottomSideBearing;

		// Token: 0x040001B0 RID: 432
		public float VerticalOrigin;

		// Token: 0x040001B1 RID: 433
		public Rect DrawBounds;
	}
}
