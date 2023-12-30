using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[Activatable(65536u, "Microsoft.UI.Xaml.XamlContract")]
	[WebHostHidden]
	[MarshalingBehavior(MarshalingType.Agile)]
	[Threading(ThreadingModel.Both)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	public sealed class NavigationViewItemInvokedEventArgs : INavigationViewItemInvokedEventArgs, INavigationViewItemInvokedEventArgs2
	{
		public extern object InvokedItem
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern bool IsSettingsInvoked
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern NavigationViewItemBase InvokedItemContainer
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern NavigationTransitionInfo RecommendedNavigationTransitionInfo
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
