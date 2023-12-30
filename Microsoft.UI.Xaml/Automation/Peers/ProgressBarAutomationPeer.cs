using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Peers;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x02000046 RID: 70
	[WebHostHidden]
	[MarshalingBehavior(2)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Threading(3)]
	[Composable(typeof(IProgressBarAutomationPeerFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	public class ProgressBarAutomationPeer : RangeBaseAutomationPeer, IProgressBarAutomationPeer
	{
		// Token: 0x06000038 RID: 56
		public extern ProgressBarAutomationPeer([In] ProgressBar owner);
	}
}
