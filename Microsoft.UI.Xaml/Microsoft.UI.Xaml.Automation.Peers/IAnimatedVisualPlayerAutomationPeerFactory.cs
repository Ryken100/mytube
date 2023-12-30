using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	[ComImport]
	[ExclusiveTo(typeof(AnimatedVisualPlayerAutomationPeer))]
	[Windows.Foundation.Metadata.Guid(3534000536u, 32955, 20950, 180, 149, 61, 197, 170, 181, 149, 137)]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface IAnimatedVisualPlayerAutomationPeerFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		AnimatedVisualPlayerAutomationPeer CreateInstance([In] AnimatedVisualPlayer owner, [In] object baseInterface, out object innerInterface);
	}
}
