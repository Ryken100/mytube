using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	[ComImport]
	[WebHostHidden]
	[ExclusiveTo(typeof(RepeaterAutomationPeer))]
	[Windows.Foundation.Metadata.Guid(72510407u, 64062, 22014, 163, 20, 152, 110, 47, 25, 106, 47)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface IRepeaterAutomationPeerFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		RepeaterAutomationPeer CreateInstance([In] ItemsRepeater owner, [In] object baseInterface, out object innerInterface);
	}
}
