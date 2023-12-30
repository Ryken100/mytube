using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(2195520u, 39949, 23634, 181, 120, 89, 59, 128, 144, 71, 179)]
	[ExclusiveTo(typeof(TabViewItemAutomationPeer))]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	internal interface ITabViewItemAutomationPeerFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		TabViewItemAutomationPeer CreateInstance([In] TabViewItem owner, [In] object baseInterface, out object innerInterface);
	}
}
