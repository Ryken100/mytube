using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000226 RID: 550
	[Composable(typeof(ITreeViewListFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[WebHostHidden]
	[MarshalingBehavior(2)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Threading(3)]
	public class TreeViewList : ListView, ITreeViewList
	{
		// Token: 0x06000BD9 RID: 3033
		public extern TreeViewList();
	}
}
