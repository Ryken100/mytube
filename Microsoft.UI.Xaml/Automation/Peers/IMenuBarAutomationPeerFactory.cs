using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x02000017 RID: 23
	[Guid(3554789951U, 5890, 23507, 138, 219, 230, 246, 203, 158, 117, 49)]
	[ExclusiveTo(typeof(MenuBarAutomationPeer))]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface IMenuBarAutomationPeerFactory
	{
		// Token: 0x06000015 RID: 21
		MenuBarAutomationPeer CreateInstance([In] MenuBar owner, [In] object baseInterface, out object innerInterface);
	}
}
