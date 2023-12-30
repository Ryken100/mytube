using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Peers;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	[ComImport]
	[Composable(typeof(IPersonPictureAutomationPeerFactory), CompositionType.Public, 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[Threading(ThreadingModel.Both)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[MarshalingBehavior(MarshalingType.Agile)]
	[WebHostHidden]
	public class PersonPictureAutomationPeer : FrameworkElementAutomationPeer, IPersonPictureAutomationPeer
	{
	}
}
