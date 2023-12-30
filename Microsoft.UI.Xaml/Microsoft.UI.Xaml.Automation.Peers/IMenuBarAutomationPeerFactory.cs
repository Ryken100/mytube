using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(3554789951u, 5890, 23507, 138, 219, 230, 246, 203, 158, 117, 49)]
	[ExclusiveTo(typeof(MenuBarAutomationPeer))]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface IMenuBarAutomationPeerFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		MenuBarAutomationPeer CreateInstance([In] MenuBar owner, [In] object baseInterface, out object innerInterface);
	}
}
