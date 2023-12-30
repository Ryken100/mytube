using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[ExclusiveTo(typeof(TreeViewItemDataAutomationPeer))]
	[Windows.Foundation.Metadata.Guid(133992025u, 21922, 22699, 137, 33, 145, 229, 125, 223, 17, 159)]
	[WebHostHidden]
	internal interface ITreeViewItemDataAutomationPeerFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		TreeViewItemDataAutomationPeer CreateInstanceWithOwner([In] object item, [In] TreeViewListAutomationPeer parent, [In] object baseInterface, out object innerInterface);
	}
}
