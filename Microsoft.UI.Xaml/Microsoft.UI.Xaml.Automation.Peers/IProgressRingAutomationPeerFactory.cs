using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	[ComImport]
	[ExclusiveTo(typeof(ProgressRingAutomationPeer))]
	[Windows.Foundation.Metadata.Guid(1695496028u, 15145, 21366, 167, 247, 199, 128, 130, 184, 45, 19)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	internal interface IProgressRingAutomationPeerFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		ProgressRingAutomationPeer CreateInstance([In] ProgressRing owner, [In] object baseInterface, out object innerInterface);
	}
}
