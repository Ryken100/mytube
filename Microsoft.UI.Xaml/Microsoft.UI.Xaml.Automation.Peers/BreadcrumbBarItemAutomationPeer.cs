using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Peers;
using Windows.UI.Xaml.Automation.Provider;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	[ComImport]
	[WebHostHidden]
	[Threading(ThreadingModel.Both)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Composable(typeof(IBreadcrumbBarItemAutomationPeerFactory), CompositionType.Public, 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(MarshalingType.Agile)]
	public class BreadcrumbBarItemAutomationPeer : FrameworkElementAutomationPeer, IBreadcrumbBarItemAutomationPeer, IInvokeProvider
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void Invoke();
	}
}
