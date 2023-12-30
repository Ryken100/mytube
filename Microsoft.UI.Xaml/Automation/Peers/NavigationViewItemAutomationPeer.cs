using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation;
using Windows.UI.Xaml.Automation.Peers;
using Windows.UI.Xaml.Automation.Provider;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x02000042 RID: 66
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MarshalingBehavior(2)]
	[Composable(typeof(INavigationViewItemAutomationPeerFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[Threading(3)]
	[WebHostHidden]
	public class NavigationViewItemAutomationPeer : FrameworkElementAutomationPeer, INavigationViewItemAutomationPeer, IExpandCollapseProvider
	{
		// Token: 0x06000031 RID: 49
		public extern NavigationViewItemAutomationPeer([In] NavigationViewItem owner);

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000032 RID: 50
		public extern ExpandCollapseState ExpandCollapseState { get; }

		// Token: 0x06000033 RID: 51
		public extern void Collapse();

		// Token: 0x06000034 RID: 52
		public extern void Expand();
	}
}
