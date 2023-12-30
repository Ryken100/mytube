using System;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	// Token: 0x0200006B RID: 107
	[Version(167772160U)]
	public struct CanvasLineMetrics
	{
		// Token: 0x04000153 RID: 339
		public int CharacterCount;

		// Token: 0x04000154 RID: 340
		public int TrailingWhitespaceCount;

		// Token: 0x04000155 RID: 341
		public int TerminalNewlineCount;

		// Token: 0x04000156 RID: 342
		public float Height;

		// Token: 0x04000157 RID: 343
		public float Baseline;

		// Token: 0x04000158 RID: 344
		public bool IsTrimmed;

		// Token: 0x04000159 RID: 345
		public float LeadingWhitespaceBefore;

		// Token: 0x0400015A RID: 346
		public float LeadingWhitespaceAfter;
	}
}
