using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ExclusiveTo(typeof(InfoBarClosedEventArgs))]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Windows.Foundation.Metadata.Guid(1497034931u, 48621, 21466, 143, 86, 128, 237, 60, 100, 50, 44)]
	internal interface IInfoBarClosedEventArgs
	{
		InfoBarCloseReason Reason
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
