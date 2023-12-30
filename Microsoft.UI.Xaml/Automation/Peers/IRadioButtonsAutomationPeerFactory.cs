using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x02000029 RID: 41
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[Guid(4046791120U, 1390, 22924, 173, 35, 167, 21, 0, 73, 216, 10)]
	[ExclusiveTo(typeof(RadioButtonsAutomationPeer))]
	internal interface IRadioButtonsAutomationPeerFactory
	{
		// Token: 0x0600001E RID: 30
		RadioButtonsAutomationPeer CreateInstance([In] RadioButtons owner, [In] object baseInterface, out object innerInterface);
	}
}
