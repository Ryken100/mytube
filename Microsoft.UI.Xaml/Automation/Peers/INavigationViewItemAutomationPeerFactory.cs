using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x0200001D RID: 29
	[Guid(2298812112U, 23138, 21131, 136, 115, 79, 113, 64, 180, 4, 137)]
	[WebHostHidden]
	[ExclusiveTo(typeof(NavigationViewItemAutomationPeer))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface INavigationViewItemAutomationPeerFactory
	{
		// Token: 0x06000018 RID: 24
		NavigationViewItemAutomationPeer CreateInstanceWithOwner([In] NavigationViewItem owner, [In] object baseInterface, out object innerInterface);
	}
}
