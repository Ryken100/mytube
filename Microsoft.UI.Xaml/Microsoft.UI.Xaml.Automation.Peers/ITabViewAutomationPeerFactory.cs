using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(4174956491u, 18380, 23973, 189, 26, 226, 225, 186, 15, 210, 77)]
	[ExclusiveTo(typeof(TabViewAutomationPeer))]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface ITabViewAutomationPeerFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		TabViewAutomationPeer CreateInstance([In] TabView owner, [In] object baseInterface, out object innerInterface);
	}
}
