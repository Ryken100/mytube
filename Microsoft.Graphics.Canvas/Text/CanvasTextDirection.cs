using System;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	// Token: 0x02000058 RID: 88
	[Version(167772160U)]
	public enum CanvasTextDirection
	{
		// Token: 0x040000C9 RID: 201
		LeftToRightThenTopToBottom,
		// Token: 0x040000CA RID: 202
		RightToLeftThenTopToBottom,
		// Token: 0x040000CB RID: 203
		LeftToRightThenBottomToTop,
		// Token: 0x040000CC RID: 204
		RightToLeftThenBottomToTop,
		// Token: 0x040000CD RID: 205
		TopToBottomThenLeftToRight,
		// Token: 0x040000CE RID: 206
		BottomToTopThenLeftToRight,
		// Token: 0x040000CF RID: 207
		TopToBottomThenRightToLeft,
		// Token: 0x040000D0 RID: 208
		BottomToTopThenRightToLeft
	}
}
