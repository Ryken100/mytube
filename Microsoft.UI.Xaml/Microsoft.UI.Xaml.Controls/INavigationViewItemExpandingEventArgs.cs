using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[ExclusiveTo(typeof(NavigationViewItemExpandingEventArgs))]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(1862877630u, 59793, 21240, 131, 21, 240, 131, 137, 73, 121, 118)]
	internal interface INavigationViewItemExpandingEventArgs
	{
		NavigationViewItemBase ExpandingItemContainer
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		object ExpandingItem
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
