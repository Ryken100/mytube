using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x0200002D RID: 45
	[WebHostHidden]
	[ExclusiveTo(typeof(RepeaterAutomationPeer))]
	[Guid(72510407U, 64062, 22014, 163, 20, 152, 110, 47, 25, 106, 47)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface IRepeaterAutomationPeerFactory
	{
		// Token: 0x06000020 RID: 32
		RepeaterAutomationPeer CreateInstance([In] ItemsRepeater owner, [In] object baseInterface, out object innerInterface);
	}
}
