using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Peers;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Threading(ThreadingModel.Both)]
	[WebHostHidden]
	[MarshalingBehavior(MarshalingType.Agile)]
	[Composable(typeof(ITreeViewListAutomationPeerFactory), CompositionType.Public, 65536u, "Microsoft.UI.Xaml.XamlContract")]
	public class TreeViewListAutomationPeer : ListViewAutomationPeer, ITreeViewListAutomationPeer
	{
	}
}