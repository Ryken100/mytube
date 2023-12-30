using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	[ComImport]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Windows.Foundation.Metadata.Guid(1906336193u, 15729, 21832, 152, 253, 98, 22, 127, 36, 96, 133)]
	[ExclusiveTo(typeof(TeachingTipAutomationPeer))]
	internal interface ITeachingTipAutomationPeerFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		TeachingTipAutomationPeer CreateInstance([In] TeachingTip owner, [In] object baseInterface, out object innerInterface);
	}
}
