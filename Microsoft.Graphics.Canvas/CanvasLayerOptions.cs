using System;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas
{
	// Token: 0x0200000B RID: 11
	[Version(167772160U)]
	[Flags]
	public enum CanvasLayerOptions : uint
	{
		// Token: 0x04000036 RID: 54
		None = 0U,
		// Token: 0x04000037 RID: 55
		InitializeFromBackground = 1U,
		// Token: 0x04000038 RID: 56
		IgnoreAlpha = 2U
	}
}
