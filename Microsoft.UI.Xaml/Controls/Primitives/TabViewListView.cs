using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	// Token: 0x020001EB RID: 491
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Composable(typeof(ITabViewListViewFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[Threading(3)]
	[MarshalingBehavior(2)]
	[WebHostHidden]
	public class TabViewListView : ListView, ITabViewListView
	{
		// Token: 0x060009A5 RID: 2469
		public extern TabViewListView();
	}
}
