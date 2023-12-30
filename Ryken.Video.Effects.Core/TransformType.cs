using System;
using Windows.Foundation.Metadata;

namespace Ryken.Video.Effects.Core
{
	// Token: 0x02000006 RID: 6
	[Flags]
	[Version(16777216U)]
	public enum TransformType : uint
	{
		// Token: 0x04000006 RID: 6
		None = 0U,
		// Token: 0x04000007 RID: 7
		ScaleWidthToTarget = 1U,
		// Token: 0x04000008 RID: 8
		ScaleHeightToTarget = 2U,
		// Token: 0x04000009 RID: 9
		ScaleWidthHeightToTarget = 3U
	}
}
