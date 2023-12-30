using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(4168985782u, 59518, 22963, 138, 64, 51, 30, 167, 170, 116, 125)]
	[ExclusiveTo(typeof(RatingControlAutomationPeer))]
	internal interface IRatingControlAutomationPeerFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		RatingControlAutomationPeer CreateInstanceWithOwner([In] RatingControl owner, [In] object baseInterface, out object innerInterface);
	}
}
