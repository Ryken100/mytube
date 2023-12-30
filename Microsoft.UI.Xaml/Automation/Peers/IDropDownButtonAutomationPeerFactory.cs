using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x02000011 RID: 17
	[WebHostHidden]
	[ExclusiveTo(typeof(DropDownButtonAutomationPeer))]
	[Guid(1757724666U, 5765, 22838, 178, 25, 81, 126, 135, 253, 89, 31)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface IDropDownButtonAutomationPeerFactory
	{
		// Token: 0x06000012 RID: 18
		DropDownButtonAutomationPeer CreateInstance([In] DropDownButton owner, [In] object baseInterface, out object innerInterface);
	}
}
