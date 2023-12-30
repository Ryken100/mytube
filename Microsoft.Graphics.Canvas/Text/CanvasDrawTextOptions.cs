using System;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	// Token: 0x0200001A RID: 26
	[Flags]
	[Version(167772160U)]
	public enum CanvasDrawTextOptions : uint
	{
		// Token: 0x04000071 RID: 113
		Default = 0U,
		// Token: 0x04000072 RID: 114
		NoPixelSnap = 1U,
		// Token: 0x04000073 RID: 115
		Clip = 2U,
		// Token: 0x04000074 RID: 116
		EnableColorFont = 4U
	}
}
