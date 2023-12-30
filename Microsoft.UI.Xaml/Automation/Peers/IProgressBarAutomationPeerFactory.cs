using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x02000025 RID: 37
	[Guid(3466759181U, 50355, 23832, 174, 246, 149, 128, 49, 57, 88, 120)]
	[WebHostHidden]
	[ExclusiveTo(typeof(ProgressBarAutomationPeer))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface IProgressBarAutomationPeerFactory
	{
		// Token: 0x0600001C RID: 28
		ProgressBarAutomationPeer CreateInstance([In] ProgressBar owner, [In] object baseInterface, out object innerInterface);
	}
}
