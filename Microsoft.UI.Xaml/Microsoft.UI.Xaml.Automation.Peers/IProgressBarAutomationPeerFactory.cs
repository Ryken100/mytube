using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(3466759181u, 50355, 23832, 174, 246, 149, 128, 49, 57, 88, 120)]
	[WebHostHidden]
	[ExclusiveTo(typeof(ProgressBarAutomationPeer))]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface IProgressBarAutomationPeerFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		ProgressBarAutomationPeer CreateInstance([In] ProgressBar owner, [In] object baseInterface, out object innerInterface);
	}
}
