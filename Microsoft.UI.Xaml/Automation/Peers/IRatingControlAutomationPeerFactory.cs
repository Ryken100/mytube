using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x0200002B RID: 43
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[Guid(4168985782U, 59518, 22963, 138, 64, 51, 30, 167, 170, 116, 125)]
	[ExclusiveTo(typeof(RatingControlAutomationPeer))]
	internal interface IRatingControlAutomationPeerFactory
	{
		// Token: 0x0600001F RID: 31
		RatingControlAutomationPeer CreateInstanceWithOwner([In] RatingControl owner, [In] object baseInterface, out object innerInterface);
	}
}
