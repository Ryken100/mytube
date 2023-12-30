using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation;
using Windows.UI.Xaml.Automation.Peers;
using Windows.UI.Xaml.Automation.Provider;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x02000051 RID: 81
	[Threading(3)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Composable(typeof(ITreeViewItemDataAutomationPeerFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(2)]
	[WebHostHidden]
	public class TreeViewItemDataAutomationPeer : ItemAutomationPeer, ITreeViewItemDataAutomationPeer, IExpandCollapseProvider
	{
		// Token: 0x06000056 RID: 86
		public extern TreeViewItemDataAutomationPeer([In] object item, [In] TreeViewListAutomationPeer parent);

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000057 RID: 87
		public extern ExpandCollapseState ExpandCollapseState { get; }

		// Token: 0x06000058 RID: 88
		public extern void Collapse();

		// Token: 0x06000059 RID: 89
		public extern void Expand();
	}
}
