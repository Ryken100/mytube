using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Peers;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x02000049 RID: 73
	[MarshalingBehavior(2)]
	[WebHostHidden]
	[Composable(typeof(IRatingControlAutomationPeerFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Threading(3)]
	public class RatingControlAutomationPeer : FrameworkElementAutomationPeer, IRatingControlAutomationPeer
	{
		// Token: 0x06000042 RID: 66
		public extern RatingControlAutomationPeer([In] RatingControl owner);
	}
}
