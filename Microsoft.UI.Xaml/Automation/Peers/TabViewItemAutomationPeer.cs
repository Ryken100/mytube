using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Peers;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x0200004D RID: 77
	[MarshalingBehavior(2)]
	[WebHostHidden]
	[Threading(3)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Composable(typeof(ITabViewItemAutomationPeerFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	public class TabViewItemAutomationPeer : ListViewItemAutomationPeer, ITabViewItemAutomationPeer
	{
		// Token: 0x0600004A RID: 74
		public extern TabViewItemAutomationPeer([In] TabViewItem owner);
	}
}
