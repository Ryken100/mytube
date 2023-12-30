using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Peers;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	[ComImport]
	[MarshalingBehavior(MarshalingType.Agile)]
	[WebHostHidden]
	[Composable(typeof(IRatingControlAutomationPeerFactory), CompositionType.Public, 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Threading(ThreadingModel.Both)]
	public class RatingControlAutomationPeer : FrameworkElementAutomationPeer, IRatingControlAutomationPeer
	{
	}
}
