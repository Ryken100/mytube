using System;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200019D RID: 413
	[WebHostHidden]
	[MarshalingBehavior(2)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	public sealed class NavigationViewItemExpandingEventArgs : INavigationViewItemExpandingEventArgs
	{
		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x060007CE RID: 1998
		public extern NavigationViewItemBase ExpandingItemContainer { get; }

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x060007CF RID: 1999
		public extern object ExpandingItem { get; }
	}
}
