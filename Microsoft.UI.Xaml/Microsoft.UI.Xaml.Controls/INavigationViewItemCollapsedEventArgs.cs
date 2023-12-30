using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(3041326753u, 50799, 24045, 181, 215, 190, 208, 162, 97, 151, 227)]
	[ExclusiveTo(typeof(NavigationViewItemCollapsedEventArgs))]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface INavigationViewItemCollapsedEventArgs
	{
		NavigationViewItemBase CollapsedItemContainer
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		object CollapsedItem
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
