using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Peers;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x02000043 RID: 67
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Threading(3)]
	[MarshalingBehavior(2)]
	[Composable(typeof(INumberBoxAutomationPeerFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	public class NumberBoxAutomationPeer : FrameworkElementAutomationPeer, INumberBoxAutomationPeer
	{
		// Token: 0x06000035 RID: 53
		public extern NumberBoxAutomationPeer([In] NumberBox owner);
	}
}
