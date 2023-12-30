using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	[ComImport]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[ExclusiveTo(typeof(MenuBarItemAutomationPeer))]
	[Windows.Foundation.Metadata.Guid(1614504900u, 42534, 20710, 156, 26, 100, 150, 153, 202, 122, 214)]
	internal interface IMenuBarItemAutomationPeerFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		MenuBarItemAutomationPeer CreateInstance([In] MenuBarItem owner, [In] object baseInterface, out object innerInterface);
	}
}
