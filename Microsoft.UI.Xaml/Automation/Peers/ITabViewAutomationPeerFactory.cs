using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x02000031 RID: 49
	[Guid(4174956491U, 18380, 23973, 189, 26, 226, 225, 186, 15, 210, 77)]
	[ExclusiveTo(typeof(TabViewAutomationPeer))]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface ITabViewAutomationPeerFactory
	{
		// Token: 0x06000022 RID: 34
		TabViewAutomationPeer CreateInstance([In] TabView owner, [In] object baseInterface, out object innerInterface);
	}
}
