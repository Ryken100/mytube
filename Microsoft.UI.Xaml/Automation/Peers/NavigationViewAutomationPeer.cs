using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Peers;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x02000041 RID: 65
	[MarshalingBehavior(2)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[Threading(3)]
	[Composable(typeof(INavigationViewAutomationPeerFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	public class NavigationViewAutomationPeer : FrameworkElementAutomationPeer, INavigationViewAutomationPeer
	{
		// Token: 0x06000030 RID: 48
		public extern NavigationViewAutomationPeer([In] NavigationView owner);
	}
}
