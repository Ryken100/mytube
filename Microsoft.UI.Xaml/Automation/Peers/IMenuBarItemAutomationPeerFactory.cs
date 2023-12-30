using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x02000019 RID: 25
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(MenuBarItemAutomationPeer))]
	[Guid(1614504900U, 42534, 20710, 156, 26, 100, 150, 153, 202, 122, 214)]
	internal interface IMenuBarItemAutomationPeerFactory
	{
		// Token: 0x06000016 RID: 22
		MenuBarItemAutomationPeer CreateInstance([In] MenuBarItem owner, [In] object baseInterface, out object innerInterface);
	}
}
