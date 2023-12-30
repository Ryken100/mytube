using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x0200003D RID: 61
	[Guid(1362308486U, 50196, 24189, 181, 123, 228, 121, 152, 60, 158, 93)]
	[ExclusiveTo(typeof(TreeViewListAutomationPeer))]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface ITreeViewListAutomationPeerFactory
	{
		// Token: 0x06000028 RID: 40
		TreeViewListAutomationPeer CreateInstanceWithOwner([In] TreeViewList owner, [In] object baseInterface, out object innerInterface);
	}
}
