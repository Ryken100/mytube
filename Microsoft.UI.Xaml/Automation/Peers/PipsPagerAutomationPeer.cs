using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Peers;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x02000045 RID: 69
	[Composable(typeof(IPipsPagerAutomationPeerFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(2)]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Threading(3)]
	public class PipsPagerAutomationPeer : FrameworkElementAutomationPeer, IPipsPagerAutomationPeer
	{
		// Token: 0x06000037 RID: 55
		public extern PipsPagerAutomationPeer([In] PipsPager owner);
	}
}
