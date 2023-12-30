using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls.Primitives;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Peers;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x02000004 RID: 4
	[Threading(3)]
	[MarshalingBehavior(2)]
	[WebHostHidden]
	[Composable(typeof(IColorPickerSliderAutomationPeerFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	public class ColorPickerSliderAutomationPeer : SliderAutomationPeer, IColorPickerSliderAutomationPeer
	{
		// Token: 0x06000004 RID: 4
		public extern ColorPickerSliderAutomationPeer([In] ColorPickerSlider owner);
	}
}
