using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(1607722384u, 26809, 23708, 165, 114, 11, 193, 1, 103, 206, 70)]
	[ExclusiveTo(typeof(InfoBarAutomationPeer))]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface IInfoBarAutomationPeerFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		InfoBarAutomationPeer CreateInstance([In] InfoBar owner, [In] object baseInterface, out object innerInterface);
	}
}
