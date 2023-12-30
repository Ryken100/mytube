using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	[ComImport]
	[WebHostHidden]
	[ExclusiveTo(typeof(DropDownButtonAutomationPeer))]
	[Windows.Foundation.Metadata.Guid(1757724666u, 5765, 22838, 178, 25, 81, 126, 135, 253, 89, 31)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface IDropDownButtonAutomationPeerFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		DropDownButtonAutomationPeer CreateInstance([In] DropDownButton owner, [In] object baseInterface, out object innerInterface);
	}
}
