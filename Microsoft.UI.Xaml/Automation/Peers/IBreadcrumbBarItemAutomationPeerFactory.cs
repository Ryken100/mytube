using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x0200000B RID: 11
	[ExclusiveTo(typeof(BreadcrumbBarItemAutomationPeer))]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(3752862022U, 16479, 21229, 168, 115, 14, 212, 148, 40, 80, 190)]
	internal interface IBreadcrumbBarItemAutomationPeerFactory
	{
		// Token: 0x0600000F RID: 15
		BreadcrumbBarItemAutomationPeer CreateInstance([In] BreadcrumbBarItem owner, [In] object baseInterface, out object innerInterface);
	}
}
