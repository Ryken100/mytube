using System;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020001A0 RID: 416
	[MarshalingBehavior(2)]
	[Threading(3)]
	[WebHostHidden]
	[Composable(typeof(INavigationViewItemSeparatorFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	public class NavigationViewItemSeparator : NavigationViewItemBase, INavigationViewItemSeparator
	{
		// Token: 0x060007D6 RID: 2006
		public extern NavigationViewItemSeparator();
	}
}
