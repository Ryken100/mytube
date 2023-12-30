using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation;
using Windows.UI.Xaml.Automation.Peers;
using Windows.UI.Xaml.Automation.Provider;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x02000050 RID: 80
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MarshalingBehavior(2)]
	[Composable(typeof(ITreeViewItemAutomationPeerFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[Threading(3)]
	public class TreeViewItemAutomationPeer : ListViewItemAutomationPeer, ITreeViewItemAutomationPeer, IExpandCollapseProvider
	{
		// Token: 0x06000052 RID: 82
		public extern TreeViewItemAutomationPeer([In] TreeViewItem owner);

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000053 RID: 83
		public extern ExpandCollapseState ExpandCollapseState { get; }

		// Token: 0x06000054 RID: 84
		public extern void Collapse();

		// Token: 0x06000055 RID: 85
		public extern void Expand();
	}
}
