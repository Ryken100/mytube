using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Peers;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x02000002 RID: 2
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MarshalingBehavior(2)]
	[Threading(3)]
	[Composable(typeof(IAnimatedVisualPlayerAutomationPeerFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[WebHostHidden]
	public class AnimatedVisualPlayerAutomationPeer : FrameworkElementAutomationPeer, IAnimatedVisualPlayerAutomationPeer
	{
		// Token: 0x06000001 RID: 1
		public extern AnimatedVisualPlayerAutomationPeer([In] AnimatedVisualPlayer owner);
	}
}
