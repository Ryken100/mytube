using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(1362308486u, 50196, 24189, 181, 123, 228, 121, 152, 60, 158, 93)]
	[ExclusiveTo(typeof(TreeViewListAutomationPeer))]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface ITreeViewListAutomationPeerFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		TreeViewListAutomationPeer CreateInstanceWithOwner([In] TreeViewList owner, [In] object baseInterface, out object innerInterface);
	}
}
