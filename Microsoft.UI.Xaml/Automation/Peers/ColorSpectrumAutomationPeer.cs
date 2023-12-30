using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls.Primitives;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Peers;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	// Token: 0x02000005 RID: 5
	[WebHostHidden]
	[Composable(typeof(IColorSpectrumAutomationPeerFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Threading(3)]
	[MarshalingBehavior(2)]
	public class ColorSpectrumAutomationPeer : FrameworkElementAutomationPeer, IColorSpectrumAutomationPeer
	{
		// Token: 0x06000005 RID: 5
		public extern ColorSpectrumAutomationPeer([In] ColorSpectrum owner);
	}
}
