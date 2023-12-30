using System;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas
{
	// Token: 0x02000007 RID: 7
	[Version(167772160U)]
	public enum CanvasComposite
	{
		// Token: 0x04000018 RID: 24
		SourceOver,
		// Token: 0x04000019 RID: 25
		DestinationOver,
		// Token: 0x0400001A RID: 26
		SourceIn,
		// Token: 0x0400001B RID: 27
		DestinationIn,
		// Token: 0x0400001C RID: 28
		SourceOut,
		// Token: 0x0400001D RID: 29
		DestinationOut,
		// Token: 0x0400001E RID: 30
		SourceAtop,
		// Token: 0x0400001F RID: 31
		DestinationAtop,
		// Token: 0x04000020 RID: 32
		Xor,
		// Token: 0x04000021 RID: 33
		Add,
		// Token: 0x04000022 RID: 34
		Copy,
		// Token: 0x04000023 RID: 35
		BoundedCopy,
		// Token: 0x04000024 RID: 36
		MaskInvert
	}
}
