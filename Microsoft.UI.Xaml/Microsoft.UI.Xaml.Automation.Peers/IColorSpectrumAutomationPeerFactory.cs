using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls.Primitives;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	[ComImport]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(3486297726u, 65039, 23708, 157, 26, 105, 226, 14, 2, 50, 207)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[ExclusiveTo(typeof(ColorSpectrumAutomationPeer))]
	internal interface IColorSpectrumAutomationPeerFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		ColorSpectrumAutomationPeer CreateInstanceWithOwner([In] ColorSpectrum owner, [In] object baseInterface, out object innerInterface);
	}
}
