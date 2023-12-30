using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000062 RID: 98
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Threading(3)]
	[WebHostHidden]
	[MarshalingBehavior(2)]
	[Composable(typeof(IBreadcrumbBarItemFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	public class BreadcrumbBarItem : ContentControl, IBreadcrumbBarItem
	{
		// Token: 0x060000C7 RID: 199
		public extern BreadcrumbBarItem();
	}
}
