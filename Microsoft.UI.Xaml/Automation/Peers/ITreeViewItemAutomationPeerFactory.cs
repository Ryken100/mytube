using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x02000039 RID: 57
	[Guid(211369080U, 38943, 24015, 147, 211, 162, 23, 173, 154, 202, 182)]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(TreeViewItemAutomationPeer))]
	internal interface ITreeViewItemAutomationPeerFactory
	{
		// Token: 0x06000026 RID: 38
		TreeViewItemAutomationPeer CreateInstanceWithOwner([In] TreeViewItem owner, [In] object baseInterface, out object innerInterface);
	}
}
