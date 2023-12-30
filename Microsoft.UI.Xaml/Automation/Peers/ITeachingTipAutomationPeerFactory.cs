using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x02000035 RID: 53
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(1906336193U, 15729, 21832, 152, 253, 98, 22, 127, 36, 96, 133)]
	[ExclusiveTo(typeof(TeachingTipAutomationPeer))]
	internal interface ITeachingTipAutomationPeerFactory
	{
		// Token: 0x06000024 RID: 36
		TeachingTipAutomationPeer CreateInstance([In] TeachingTip owner, [In] object baseInterface, out object innerInterface);
	}
}
