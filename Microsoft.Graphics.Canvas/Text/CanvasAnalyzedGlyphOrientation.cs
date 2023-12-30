using System;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	// Token: 0x020000A3 RID: 163
	[Version(167772160U)]
	public struct CanvasAnalyzedGlyphOrientation
	{
		// Token: 0x040001F7 RID: 503
		public CanvasGlyphOrientation GlyphOrientation;

		// Token: 0x040001F8 RID: 504
		public uint AdjustedBidiLevel;

		// Token: 0x040001F9 RID: 505
		public bool IsSideways;

		// Token: 0x040001FA RID: 506
		public bool IsRightToLeft;
	}
}
