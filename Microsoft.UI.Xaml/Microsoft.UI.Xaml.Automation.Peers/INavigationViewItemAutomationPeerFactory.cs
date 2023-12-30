using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(2298812112u, 23138, 21131, 136, 115, 79, 113, 64, 180, 4, 137)]
	[WebHostHidden]
	[ExclusiveTo(typeof(NavigationViewItemAutomationPeer))]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface INavigationViewItemAutomationPeerFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		NavigationViewItemAutomationPeer CreateInstanceWithOwner([In] NavigationViewItem owner, [In] object baseInterface, out object innerInterface);
	}
}
