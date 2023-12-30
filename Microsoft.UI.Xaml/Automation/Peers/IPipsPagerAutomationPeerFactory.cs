using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x02000023 RID: 35
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(4216473839U, 59445, 22935, 188, 54, 212, 229, 219, 74, 27, 90)]
	[ExclusiveTo(typeof(PipsPagerAutomationPeer))]
	[WebHostHidden]
	internal interface IPipsPagerAutomationPeerFactory
	{
		// Token: 0x0600001B RID: 27
		PipsPagerAutomationPeer CreateInstance([In] PipsPager owner, [In] object baseInterface, out object innerInterface);
	}
}
