using System;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	// Token: 0x020001C2 RID: 450
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	public enum CornerRadiusToThicknessConverterKind
	{
		// Token: 0x04000051 RID: 81
		FilterTopAndBottomFromLeft,
		// Token: 0x04000052 RID: 82
		FilterTopAndBottomFromRight,
		// Token: 0x04000053 RID: 83
		FilterLeftAndRightFromTop,
		// Token: 0x04000054 RID: 84
		FilterLeftAndRightFromBottom,
		// Token: 0x04000055 RID: 85
		FilterTopFromTopLeft,
		// Token: 0x04000056 RID: 86
		FilterTopFromTopRight,
		// Token: 0x04000057 RID: 87
		FilterRightFromTopRight,
		// Token: 0x04000058 RID: 88
		FilterRightFromBottomRight,
		// Token: 0x04000059 RID: 89
		FilterBottomFromBottomRight,
		// Token: 0x0400005A RID: 90
		FilterBottomFromBottomLeft,
		// Token: 0x0400005B RID: 91
		FilterLeftFromBottomLeft,
		// Token: 0x0400005C RID: 92
		FilterLeftFromTopLeft
	}
}
