using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	[ComImport]
	[ExclusiveTo(typeof(PersonPictureAutomationPeer))]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(3172403685u, 6464, 22268, 181, 195, 133, 228, 87, 9, 81, 204)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface IPersonPictureAutomationPeerFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		PersonPictureAutomationPeer CreateInstanceWithOwner([In] PersonPicture owner, [In] object baseInterface, out object innerInterface);
	}
}
