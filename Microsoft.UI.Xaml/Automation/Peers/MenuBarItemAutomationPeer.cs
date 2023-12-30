using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation;
using Windows.UI.Xaml.Automation.Peers;
using Windows.UI.Xaml.Automation.Provider;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x02000040 RID: 64
	[Composable(typeof(IMenuBarItemAutomationPeerFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(2)]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Threading(3)]
	public class MenuBarItemAutomationPeer : FrameworkElementAutomationPeer, IMenuBarItemAutomationPeer, IExpandCollapseProvider, IInvokeProvider
	{
		// Token: 0x0600002B RID: 43
		public extern MenuBarItemAutomationPeer([In] MenuBarItem owner);

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600002C RID: 44
		public extern ExpandCollapseState ExpandCollapseState { get; }

		// Token: 0x0600002D RID: 45
		public extern void Collapse();

		// Token: 0x0600002E RID: 46
		public extern void Expand();

		// Token: 0x0600002F RID: 47
		public extern void Invoke();
	}
}
