using System;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200020E RID: 526
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MarshalingBehavior(2)]
	[WebHostHidden]
	public sealed class TabViewTabCloseRequestedEventArgs : ITabViewTabCloseRequestedEventArgs
	{
		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06000B09 RID: 2825
		public extern object Item { get; }

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06000B0A RID: 2826
		public extern TabViewItem Tab { get; }
	}
}
