using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation;
using Windows.UI.Xaml.Automation.Peers;
using Windows.UI.Xaml.Automation.Provider;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x0200004F RID: 79
	[Threading(3)]
	[MarshalingBehavior(2)]
	[Composable(typeof(IToggleSplitButtonAutomationPeerFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	public class ToggleSplitButtonAutomationPeer : FrameworkElementAutomationPeer, IToggleSplitButtonAutomationPeer, IExpandCollapseProvider, IToggleProvider
	{
		// Token: 0x0600004C RID: 76
		public extern ToggleSplitButtonAutomationPeer([In] ToggleSplitButton owner);

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600004D RID: 77
		public extern ExpandCollapseState ExpandCollapseState { get; }

		// Token: 0x0600004E RID: 78
		public extern void Collapse();

		// Token: 0x0600004F RID: 79
		public extern void Expand();

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000050 RID: 80
		public extern ToggleState ToggleState { get; }

		// Token: 0x06000051 RID: 81
		public extern void Toggle();
	}
}
