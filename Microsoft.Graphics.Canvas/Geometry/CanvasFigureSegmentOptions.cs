using System;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Geometry
{
	// Token: 0x02000012 RID: 18
	[Version(167772160U)]
	[Flags]
	public enum CanvasFigureSegmentOptions : uint
	{
		// Token: 0x04000051 RID: 81
		None = 0U,
		// Token: 0x04000052 RID: 82
		ForceUnstroked = 1U,
		// Token: 0x04000053 RID: 83
		ForceRoundLineJoin = 2U
	}
}
