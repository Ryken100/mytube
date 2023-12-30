using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls.Primitives;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x0200000D RID: 13
	[ExclusiveTo(typeof(ColorPickerSliderAutomationPeer))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[Guid(3858303295U, 24108, 20808, 181, 209, 28, 218, 78, 184, 105, 19)]
	internal interface IColorPickerSliderAutomationPeerFactory
	{
		// Token: 0x06000010 RID: 16
		ColorPickerSliderAutomationPeer CreateInstanceWithOwner([In] ColorPickerSlider owner, [In] object baseInterface, out object innerInterface);
	}
}
