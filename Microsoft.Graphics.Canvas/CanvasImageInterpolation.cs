using System;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas
{
	// Token: 0x0200000A RID: 10
	[Version(167772160U)]
	public enum CanvasImageInterpolation
	{
		// Token: 0x0400002F RID: 47
		NearestNeighbor,
		// Token: 0x04000030 RID: 48
		Linear,
		// Token: 0x04000031 RID: 49
		Cubic,
		// Token: 0x04000032 RID: 50
		MultiSampleLinear,
		// Token: 0x04000033 RID: 51
		Anisotropic,
		// Token: 0x04000034 RID: 52
		HighQualityCubic
	}
}
