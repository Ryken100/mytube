using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x02000015 RID: 21
	[Guid(1607722384U, 26809, 23708, 165, 114, 11, 193, 1, 103, 206, 70)]
	[ExclusiveTo(typeof(InfoBarAutomationPeer))]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface IInfoBarAutomationPeerFactory
	{
		// Token: 0x06000014 RID: 20
		InfoBarAutomationPeer CreateInstance([In] InfoBar owner, [In] object baseInterface, out object innerInterface);
	}
}
