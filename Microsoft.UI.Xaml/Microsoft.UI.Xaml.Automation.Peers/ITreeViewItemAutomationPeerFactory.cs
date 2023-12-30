using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(211369080u, 38943, 24015, 147, 211, 162, 23, 173, 154, 202, 182)]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[ExclusiveTo(typeof(TreeViewItemAutomationPeer))]
	internal interface ITreeViewItemAutomationPeerFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		TreeViewItemAutomationPeer CreateInstanceWithOwner([In] TreeViewItem owner, [In] object baseInterface, out object innerInterface);
	}
}
