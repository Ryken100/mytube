using System;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	// Token: 0x0200009F RID: 159
	[Version(167772160U)]
	public struct CanvasAnalyzedBreakpoint
	{
		// Token: 0x040001D6 RID: 470
		public CanvasLineBreakCondition BreakBefore;

		// Token: 0x040001D7 RID: 471
		public CanvasLineBreakCondition BreakAfter;

		// Token: 0x040001D8 RID: 472
		public bool IsWhitespace;

		// Token: 0x040001D9 RID: 473
		public bool IsSoftHyphen;
	}
}
