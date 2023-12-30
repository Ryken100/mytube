using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	[ComImport]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(1640109221u, 24667, 24216, 184, 93, 227, 18, 29, 35, 237, 170)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[ExclusiveTo(typeof(ToggleSplitButtonAutomationPeer))]
	internal interface IToggleSplitButtonAutomationPeerFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		ToggleSplitButtonAutomationPeer CreateInstance([In] ToggleSplitButton owner, [In] object baseInterface, out object innerInterface);
	}
}
