using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020001FE RID: 510
	[Threading(3)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MarshalingBehavior(2)]
	[WebHostHidden]
	[Composable(typeof(IRevealListViewItemPresenterFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	public class RevealListViewItemPresenter : ListViewItemPresenter, IRevealListViewItemPresenter
	{
		// Token: 0x06000A54 RID: 2644
		public extern RevealListViewItemPresenter();
	}
}
