using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x02000033 RID: 51
	[Guid(2195520U, 39949, 23634, 181, 120, 89, 59, 128, 144, 71, 179)]
	[ExclusiveTo(typeof(TabViewItemAutomationPeer))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	internal interface ITabViewItemAutomationPeerFactory
	{
		// Token: 0x06000023 RID: 35
		TabViewItemAutomationPeer CreateInstance([In] TabViewItem owner, [In] object baseInterface, out object innerInterface);
	}
}
