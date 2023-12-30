using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	[ComImport]
	[ExclusiveTo(typeof(NavigationViewAutomationPeer))]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(1912684206u, 45077, 21773, 186, 141, 160, 81, 18, 182, 39, 49)]
	internal interface INavigationViewAutomationPeer
	{
	}
}
