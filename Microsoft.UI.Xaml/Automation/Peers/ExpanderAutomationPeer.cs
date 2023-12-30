using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation;
using Windows.UI.Xaml.Automation.Peers;
using Windows.UI.Xaml.Automation.Provider;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x02000007 RID: 7
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Composable(typeof(IExpanderAutomationPeerFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(2)]
	[Threading(3)]
	[WebHostHidden]
	public class ExpanderAutomationPeer : FrameworkElementAutomationPeer, IExpanderAutomationPeer, IExpandCollapseProvider
	{
		// Token: 0x0600000A RID: 10
		public extern ExpanderAutomationPeer([In] Expander owner);

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000B RID: 11
		public extern ExpandCollapseState ExpandCollapseState { get; }

		// Token: 0x0600000C RID: 12
		public extern void Collapse();

		// Token: 0x0600000D RID: 13
		public extern void Expand();
	}
}
