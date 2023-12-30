using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(953871147u, 21347, 20963, 190, 212, 101, 54, 65, 181, 99, 54)]
	[ExclusiveTo(typeof(NavigationViewSelectionChangedEventArgs))]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	internal interface INavigationViewSelectionChangedEventArgs2
	{
		NavigationViewItemBase SelectedItemContainer
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		NavigationTransitionInfo RecommendedNavigationTransitionInfo
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
