using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x0200003B RID: 59
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(TreeViewItemDataAutomationPeer))]
	[Guid(133992025U, 21922, 22699, 137, 33, 145, 229, 125, 223, 17, 159)]
	[WebHostHidden]
	internal interface ITreeViewItemDataAutomationPeerFactory
	{
		// Token: 0x06000027 RID: 39
		TreeViewItemDataAutomationPeer CreateInstanceWithOwner([In] object item, [In] TreeViewListAutomationPeer parent, [In] object baseInterface, out object innerInterface);
	}
}
