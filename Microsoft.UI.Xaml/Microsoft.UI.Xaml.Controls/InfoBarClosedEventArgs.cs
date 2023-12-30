using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[Threading(ThreadingModel.Both)]
	[MarshalingBehavior(MarshalingType.Agile)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Composable(typeof(IInfoBarClosedEventArgsFactory), CompositionType.Public, 65536u, "Microsoft.UI.Xaml.XamlContract")]
	public class InfoBarClosedEventArgs : IInfoBarClosedEventArgs
	{
		public extern InfoBarCloseReason Reason
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
