using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	[ComImport]
	[ExclusiveTo(typeof(NumberBoxAutomationPeer))]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Windows.Foundation.Metadata.Guid(1704401324u, 17413, 22772, 189, 226, 239, 97, 223, 230, 76, 33)]
	[WebHostHidden]
	internal interface INumberBoxAutomationPeerFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		NumberBoxAutomationPeer CreateInstance([In] NumberBox owner, [In] object baseInterface, out object innerInterface);
	}
}
