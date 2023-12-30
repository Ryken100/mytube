using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	[ComImport]
	[ExclusiveTo(typeof(BreadcrumbBarItemAutomationPeer))]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Windows.Foundation.Metadata.Guid(3752862022u, 16479, 21229, 168, 115, 14, 212, 148, 40, 80, 190)]
	internal interface IBreadcrumbBarItemAutomationPeerFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		BreadcrumbBarItemAutomationPeer CreateInstance([In] BreadcrumbBarItem owner, [In] object baseInterface, out object innerInterface);
	}
}
