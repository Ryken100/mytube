using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls.Primitives;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	[ComImport]
	[ExclusiveTo(typeof(ColorPickerSliderAutomationPeer))]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(3858303295u, 24108, 20808, 181, 209, 28, 218, 78, 184, 105, 19)]
	internal interface IColorPickerSliderAutomationPeerFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		ColorPickerSliderAutomationPeer CreateInstanceWithOwner([In] ColorPickerSlider owner, [In] object baseInterface, out object innerInterface);
	}
}
