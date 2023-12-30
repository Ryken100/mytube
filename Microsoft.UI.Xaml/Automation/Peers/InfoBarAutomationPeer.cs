using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Peers;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x0200003E RID: 62
	[WebHostHidden]
	[Composable(typeof(IInfoBarAutomationPeerFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[Threading(3)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MarshalingBehavior(2)]
	public class InfoBarAutomationPeer : FrameworkElementAutomationPeer, IInfoBarAutomationPeer
	{
		// Token: 0x06000029 RID: 41
		public extern InfoBarAutomationPeer([In] InfoBar owner);
	}
}
