using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Peers;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x0200004A RID: 74
	[Threading(3)]
	[MarshalingBehavior(2)]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Composable(typeof(IRepeaterAutomationPeerFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	public class RepeaterAutomationPeer : FrameworkElementAutomationPeer, IRepeaterAutomationPeer
	{
		// Token: 0x06000043 RID: 67
		public extern RepeaterAutomationPeer([In] ItemsRepeater owner);
	}
}
