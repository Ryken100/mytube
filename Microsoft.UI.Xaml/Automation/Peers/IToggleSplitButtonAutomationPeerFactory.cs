using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x02000037 RID: 55
	[WebHostHidden]
	[Guid(1640109221U, 24667, 24216, 184, 93, 227, 18, 29, 35, 237, 170)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(ToggleSplitButtonAutomationPeer))]
	internal interface IToggleSplitButtonAutomationPeerFactory
	{
		// Token: 0x06000025 RID: 37
		ToggleSplitButtonAutomationPeer CreateInstance([In] ToggleSplitButton owner, [In] object baseInterface, out object innerInterface);
	}
}
