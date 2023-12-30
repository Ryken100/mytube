using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Peers;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x0200004E RID: 78
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Composable(typeof(ITeachingTipAutomationPeerFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[WebHostHidden]
	[MarshalingBehavior(2)]
	[Threading(3)]
	public class TeachingTipAutomationPeer : FrameworkElementAutomationPeer, ITeachingTipAutomationPeer
	{
		// Token: 0x0600004B RID: 75
		public extern TeachingTipAutomationPeer([In] TeachingTip owner);
	}
}
