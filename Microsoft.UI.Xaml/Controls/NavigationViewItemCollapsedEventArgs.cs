using System;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200019C RID: 412
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MarshalingBehavior(2)]
	[WebHostHidden]
	public sealed class NavigationViewItemCollapsedEventArgs : INavigationViewItemCollapsedEventArgs
	{
		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x060007CC RID: 1996
		public extern NavigationViewItemBase CollapsedItemContainer { get; }

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x060007CD RID: 1997
		public extern object CollapsedItem { get; }
	}
}
