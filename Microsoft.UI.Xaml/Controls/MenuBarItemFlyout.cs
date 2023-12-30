using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000194 RID: 404
	[WebHostHidden]
	[Threading(3)]
	[MarshalingBehavior(2)]
	[Composable(typeof(IMenuBarItemFlyoutFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	public class MenuBarItemFlyout : MenuFlyout, IMenuBarItemFlyout
	{
		// Token: 0x0600072D RID: 1837
		public extern MenuBarItemFlyout();
	}
}
