using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Windows.Foundation.Metadata.Guid(2079661205u, 21410, 23053, 187, 50, 43, 75, 31, 125, 47, 32)]
	[ExclusiveTo(typeof(SwipeItemInvokedEventArgs))]
	internal interface ISwipeItemInvokedEventArgs
	{
		SwipeControl SwipeControl
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
