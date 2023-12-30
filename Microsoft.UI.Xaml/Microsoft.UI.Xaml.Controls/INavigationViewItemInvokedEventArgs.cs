using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	[ExclusiveTo(typeof(NavigationViewItemInvokedEventArgs))]
	[Windows.Foundation.Metadata.Guid(122481578u, 23813, 21627, 140, 214, 209, 154, 194, 217, 187, 59)]
	internal interface INavigationViewItemInvokedEventArgs
	{
		object InvokedItem
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		bool IsSettingsInvoked
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
