using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(1537404668u, 14134, 24130, 172, 86, 157, 11, 229, 82, 61, 64)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[MUXPropertyChangedCallback(enable = true)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[ExclusiveTo(typeof(NavigationView))]
	internal interface INavigationView2
	{
		[MUXPropertyDefaultValue(value = "winrt::NavigationViewBackButtonVisible::Auto")]
		[MUXPropertyDefaultValue(value = "winrt::NavigationViewBackButtonVisible::Auto")]
		NavigationViewBackButtonVisible IsBackButtonVisible
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::NavigationViewBackButtonVisible::Auto")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::NavigationViewBackButtonVisible::Auto")]
			[param: In]
			set;
		}

		bool IsBackEnabled
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		string PaneTitle
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		event TypedEventHandler<NavigationView, NavigationViewBackRequestedEventArgs> BackRequested;

		event TypedEventHandler<NavigationView, object> PaneClosed;

		event TypedEventHandler<NavigationView, NavigationViewPaneClosingEventArgs> PaneClosing;

		event TypedEventHandler<NavigationView, object> PaneOpened;

		event TypedEventHandler<NavigationView, object> PaneOpening;

		[MUXPropertyDefaultValue(value = "winrt::NavigationViewPaneDisplayMode::Auto")]
		[MUXPropertyDefaultValue(value = "winrt::NavigationViewPaneDisplayMode::Auto")]
		NavigationViewPaneDisplayMode PaneDisplayMode
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::NavigationViewPaneDisplayMode::Auto")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::NavigationViewPaneDisplayMode::Auto")]
			[param: In]
			set;
		}

		[MUXPropertyChangedCallback(enable = false)]
		[MUXPropertyChangedCallback(enable = false)]
		UIElement PaneHeader
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyChangedCallback(enable = false)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyChangedCallback(enable = false)]
			[param: In]
			set;
		}

		[MUXPropertyChangedCallback(enable = false)]
		[MUXPropertyChangedCallback(enable = false)]
		UIElement PaneCustomContent
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyChangedCallback(enable = false)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyChangedCallback(enable = false)]
			[param: In]
			set;
		}

		[MUXPropertyChangedCallback(enable = false)]
		[MUXPropertyChangedCallback(enable = false)]
		UIElement ContentOverlay
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyChangedCallback(enable = false)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyChangedCallback(enable = false)]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		bool IsPaneVisible
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "winrt::NavigationViewSelectionFollowsFocus::Disabled")]
		[MUXPropertyDefaultValue(value = "winrt::NavigationViewSelectionFollowsFocus::Disabled")]
		NavigationViewSelectionFollowsFocus SelectionFollowsFocus
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::NavigationViewSelectionFollowsFocus::Disabled")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::NavigationViewSelectionFollowsFocus::Disabled")]
			[param: In]
			set;
		}

		[MUXPropertyChangedCallback(enable = false)]
		NavigationViewTemplateSettings TemplateSettings
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyChangedCallback(enable = false)]
			get;
		}

		[MUXPropertyDefaultValue(value = "winrt::NavigationViewShoulderNavigationEnabled::Never")]
		[MUXPropertyDefaultValue(value = "winrt::NavigationViewShoulderNavigationEnabled::Never")]
		NavigationViewShoulderNavigationEnabled ShoulderNavigationEnabled
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::NavigationViewShoulderNavigationEnabled::Never")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::NavigationViewShoulderNavigationEnabled::Never")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "winrt::NavigationViewOverflowLabelMode::MoreLabel")]
		[MUXPropertyDefaultValue(value = "winrt::NavigationViewOverflowLabelMode::MoreLabel")]
		NavigationViewOverflowLabelMode OverflowLabelMode
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::NavigationViewOverflowLabelMode::MoreLabel")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::NavigationViewOverflowLabelMode::MoreLabel")]
			[param: In]
			set;
		}

		event TypedEventHandler<NavigationView, NavigationViewItemExpandingEventArgs> Expanding;

		event TypedEventHandler<NavigationView, NavigationViewItemCollapsedEventArgs> Collapsed;

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Expand([In] NavigationViewItem item);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Collapse([In] NavigationViewItem item);
	}
}
