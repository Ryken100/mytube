using System;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000211 RID: 529
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[MarshalingBehavior(2)]
	public sealed class TabViewTabDroppedOutsideEventArgs : ITabViewTabDroppedOutsideEventArgs
	{
		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06000B13 RID: 2835
		public extern object Item { get; }

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06000B14 RID: 2836
		public extern TabViewItem Tab { get; }
	}
}
