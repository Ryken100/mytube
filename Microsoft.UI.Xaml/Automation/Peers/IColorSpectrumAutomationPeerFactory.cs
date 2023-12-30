using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls.Primitives;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x0200000F RID: 15
	[WebHostHidden]
	[Guid(3486297726U, 65039, 23708, 157, 26, 105, 226, 14, 2, 50, 207)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(ColorSpectrumAutomationPeer))]
	internal interface IColorSpectrumAutomationPeerFactory
	{
		// Token: 0x06000011 RID: 17
		ColorSpectrumAutomationPeer CreateInstanceWithOwner([In] ColorSpectrum owner, [In] object baseInterface, out object innerInterface);
	}
}
