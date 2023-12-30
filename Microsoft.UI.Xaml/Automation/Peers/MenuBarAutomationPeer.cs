using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Peers;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x0200003F RID: 63
	[Threading(3)]
	[Composable(typeof(IMenuBarAutomationPeerFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(2)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	public class MenuBarAutomationPeer : FrameworkElementAutomationPeer, IMenuBarAutomationPeer
	{
		// Token: 0x0600002A RID: 42
		public extern MenuBarAutomationPeer([In] MenuBar owner);
	}
}
