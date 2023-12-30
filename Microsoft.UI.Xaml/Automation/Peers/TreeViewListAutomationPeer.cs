using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Peers;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x02000052 RID: 82
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Threading(3)]
	[WebHostHidden]
	[MarshalingBehavior(2)]
	[Composable(typeof(ITreeViewListAutomationPeerFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	public class TreeViewListAutomationPeer : ListViewAutomationPeer, ITreeViewListAutomationPeer
	{
		// Token: 0x0600005A RID: 90
		public extern TreeViewListAutomationPeer([In] TreeViewList owner);
	}
}
