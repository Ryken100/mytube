using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	[ComImport]
	[ExclusiveTo(typeof(NavigationViewAutomationPeer))]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Windows.Foundation.Metadata.Guid(1963416323u, 41719, 22633, 178, 60, 99, 203, 229, 172, 196, 58)]
	[WebHostHidden]
	internal interface INavigationViewAutomationPeerFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		NavigationViewAutomationPeer CreateInstance([In] NavigationView owner, [In] object baseInterface, out object innerInterface);
	}
}
