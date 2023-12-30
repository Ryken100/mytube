using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(3895319699u, 30734, 20480, 152, 30, 155, 225, 14, 237, 235, 31)]
	[ExclusiveTo(typeof(SplitButtonAutomationPeer))]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface ISplitButtonAutomationPeerFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		SplitButtonAutomationPeer CreateInstance([In] SplitButton owner, [In] object baseInterface, out object innerInterface);
	}
}
