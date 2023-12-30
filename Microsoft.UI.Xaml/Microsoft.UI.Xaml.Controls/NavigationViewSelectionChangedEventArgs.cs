using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[MarshalingBehavior(MarshalingType.Agile)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	public sealed class NavigationViewSelectionChangedEventArgs : INavigationViewSelectionChangedEventArgs, INavigationViewSelectionChangedEventArgs2
	{
		public extern bool IsSettingsSelected
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern object SelectedItem
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern NavigationTransitionInfo RecommendedNavigationTransitionInfo
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern NavigationViewItemBase SelectedItemContainer
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
