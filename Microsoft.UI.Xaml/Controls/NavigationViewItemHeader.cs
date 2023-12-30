using System;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200019E RID: 414
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Composable(typeof(INavigationViewItemHeaderFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(2)]
	[Threading(3)]
	public class NavigationViewItemHeader : NavigationViewItemBase, INavigationViewItemHeader
	{
		// Token: 0x060007D0 RID: 2000
		public extern NavigationViewItemHeader();
	}
}
