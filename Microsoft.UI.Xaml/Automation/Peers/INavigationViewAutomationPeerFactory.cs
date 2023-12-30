using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x0200001B RID: 27
	[ExclusiveTo(typeof(NavigationViewAutomationPeer))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(1963416323U, 41719, 22633, 178, 60, 99, 203, 229, 172, 196, 58)]
	[WebHostHidden]
	internal interface INavigationViewAutomationPeerFactory
	{
		// Token: 0x06000017 RID: 23
		NavigationViewAutomationPeer CreateInstance([In] NavigationView owner, [In] object baseInterface, out object innerInterface);
	}
}
