using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x02000013 RID: 19
	[WebHostHidden]
	[Guid(539251259U, 19008, 22902, 170, 171, 15, 5, 102, 79, 116, 148)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(ExpanderAutomationPeer))]
	internal interface IExpanderAutomationPeerFactory
	{
		// Token: 0x06000013 RID: 19
		ExpanderAutomationPeer CreateInstance([In] Expander owner, [In] object baseInterface, out object innerInterface);
	}
}
