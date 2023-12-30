using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation;
using Windows.UI.Xaml.Automation.Peers;
using Windows.UI.Xaml.Automation.Provider;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x02000006 RID: 6
	[MarshalingBehavior(2)]
	[WebHostHidden]
	[Threading(3)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Composable(typeof(IDropDownButtonAutomationPeerFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	public class DropDownButtonAutomationPeer : ButtonAutomationPeer, IDropDownButtonAutomationPeer, IExpandCollapseProvider
	{
		// Token: 0x06000006 RID: 6
		public extern DropDownButtonAutomationPeer([In] DropDownButton owner);

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000007 RID: 7
		public extern ExpandCollapseState ExpandCollapseState { get; }

		// Token: 0x06000008 RID: 8
		public extern void Collapse();

		// Token: 0x06000009 RID: 9
		public extern void Expand();
	}
}
