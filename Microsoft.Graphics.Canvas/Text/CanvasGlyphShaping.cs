using System;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	// Token: 0x020000A2 RID: 162
	[Version(167772160U)]
	public struct CanvasGlyphShaping
	{
		// Token: 0x040001F3 RID: 499
		public CanvasGlyphJustification Justification;

		// Token: 0x040001F4 RID: 500
		public bool IsClusterStart;

		// Token: 0x040001F5 RID: 501
		public bool IsDiacritic;

		// Token: 0x040001F6 RID: 502
		public bool IsZeroWidthSpace;
	}
}
