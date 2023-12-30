using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x0200002F RID: 47
	[Guid(3895319699U, 30734, 20480, 152, 30, 155, 225, 14, 237, 235, 31)]
	[ExclusiveTo(typeof(SplitButtonAutomationPeer))]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface ISplitButtonAutomationPeerFactory
	{
		// Token: 0x06000021 RID: 33
		SplitButtonAutomationPeer CreateInstance([In] SplitButton owner, [In] object baseInterface, out object innerInterface);
	}
}
