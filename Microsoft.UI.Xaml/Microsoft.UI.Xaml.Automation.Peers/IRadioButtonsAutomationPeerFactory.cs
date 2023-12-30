using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(4046791120u, 1390, 22924, 173, 35, 167, 21, 0, 73, 216, 10)]
	[ExclusiveTo(typeof(RadioButtonsAutomationPeer))]
	internal interface IRadioButtonsAutomationPeerFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		RadioButtonsAutomationPeer CreateInstance([In] RadioButtons owner, [In] object baseInterface, out object innerInterface);
	}
}
