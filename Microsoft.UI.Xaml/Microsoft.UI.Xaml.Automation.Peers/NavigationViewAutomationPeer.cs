using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Peers;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	[ComImport]
	[MarshalingBehavior(MarshalingType.Agile)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	[Threading(ThreadingModel.Both)]
	[Composable(typeof(INavigationViewAutomationPeerFactory), CompositionType.Public, 65536u, "Microsoft.UI.Xaml.XamlContract")]
	public class NavigationViewAutomationPeer : FrameworkElementAutomationPeer, INavigationViewAutomationPeer
	{
	}
}
