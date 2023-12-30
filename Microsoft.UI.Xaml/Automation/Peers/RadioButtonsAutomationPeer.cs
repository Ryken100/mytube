using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Peers;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x02000048 RID: 72
	[WebHostHidden]
	[MarshalingBehavior(2)]
	[Threading(3)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Composable(typeof(IRadioButtonsAutomationPeerFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	public class RadioButtonsAutomationPeer : FrameworkElementAutomationPeer, IRadioButtonsAutomationPeer
	{
		// Token: 0x06000041 RID: 65
		public extern RadioButtonsAutomationPeer([In] RadioButtons owner);
	}
}
