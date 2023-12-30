using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation;
using Windows.UI.Xaml.Automation.Peers;
using Windows.UI.Xaml.Automation.Provider;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x0200004B RID: 75
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Threading(3)]
	[Composable(typeof(ISplitButtonAutomationPeerFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(2)]
	[WebHostHidden]
	public class SplitButtonAutomationPeer : FrameworkElementAutomationPeer, ISplitButtonAutomationPeer, IExpandCollapseProvider, IInvokeProvider
	{
		// Token: 0x06000044 RID: 68
		public extern SplitButtonAutomationPeer([In] SplitButton owner);

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000045 RID: 69
		public extern ExpandCollapseState ExpandCollapseState { get; }

		// Token: 0x06000046 RID: 70
		public extern void Collapse();

		// Token: 0x06000047 RID: 71
		public extern void Expand();

		// Token: 0x06000048 RID: 72
		public extern void Invoke();
	}
}
