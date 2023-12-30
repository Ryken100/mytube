using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Peers;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x0200004C RID: 76
	[Composable(typeof(ITabViewAutomationPeerFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(2)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[Threading(3)]
	public class TabViewAutomationPeer : FrameworkElementAutomationPeer, ITabViewAutomationPeer
	{
		// Token: 0x06000049 RID: 73
		public extern TabViewAutomationPeer([In] TabView owner);
	}
}
