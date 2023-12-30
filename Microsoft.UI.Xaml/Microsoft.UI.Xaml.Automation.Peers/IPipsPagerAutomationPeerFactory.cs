using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Windows.Foundation.Metadata.Guid(4216473839u, 59445, 22935, 188, 54, 212, 229, 219, 74, 27, 90)]
	[ExclusiveTo(typeof(PipsPagerAutomationPeer))]
	[WebHostHidden]
	internal interface IPipsPagerAutomationPeerFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		PipsPagerAutomationPeer CreateInstance([In] PipsPager owner, [In] object baseInterface, out object innerInterface);
	}
}
