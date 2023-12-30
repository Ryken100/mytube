using System;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020001FD RID: 509
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	public enum RefreshVisualizerState
	{
		// Token: 0x04000076 RID: 118
		Idle,
		// Token: 0x04000077 RID: 119
		Peeking,
		// Token: 0x04000078 RID: 120
		Interacting,
		// Token: 0x04000079 RID: 121
		Pending,
		// Token: 0x0400007A RID: 122
		Refreshing
	}
}
