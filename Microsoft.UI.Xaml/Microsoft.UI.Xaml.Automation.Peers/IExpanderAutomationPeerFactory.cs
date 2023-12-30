using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	[ComImport]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(539251259u, 19008, 22902, 170, 171, 15, 5, 102, 79, 116, 148)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[ExclusiveTo(typeof(ExpanderAutomationPeer))]
	internal interface IExpanderAutomationPeerFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		ExpanderAutomationPeer CreateInstance([In] Expander owner, [In] object baseInterface, out object innerInterface);
	}
}
