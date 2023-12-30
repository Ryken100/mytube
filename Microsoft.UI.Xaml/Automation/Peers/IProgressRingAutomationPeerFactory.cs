using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x02000027 RID: 39
	[ExclusiveTo(typeof(ProgressRingAutomationPeer))]
	[Guid(1695496028U, 15145, 21366, 167, 247, 199, 128, 130, 184, 45, 19)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	internal interface IProgressRingAutomationPeerFactory
	{
		// Token: 0x0600001D RID: 29
		ProgressRingAutomationPeer CreateInstance([In] ProgressRing owner, [In] object baseInterface, out object innerInterface);
	}
}
