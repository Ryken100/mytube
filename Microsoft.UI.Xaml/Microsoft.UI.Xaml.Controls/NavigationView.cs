using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[Composable(typeof(INavigationViewFactory), CompositionType.Public, 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[MUXPropertyChangedCallback(enable = true)]
	[Static(typeof(INavigationViewStatics2), 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Threading(ThreadingModel.Both)]
	[Static(typeof(INavigationViewStatics), 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(MarshalingType.Agile)]
	[WebHostHidden]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	public class NavigationView : ContentControl, INavigationView, INavigationView2
	{
		public extern object SelectedItem
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern Style PaneToggleButtonStyle
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern UIElement PaneFooter
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "320.0")]
		[MUXPropertyValidationCallback(value = "CoerceToGreaterThanZero")]
		[MUXPropertyValidationCallback(value = "CoerceToGreaterThanZero")]
		[MUXPropertyDefaultValue(value = "320.0")]
		public extern double OpenPaneLength
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyValidationCallback(value = "CoerceToGreaterThanZero")]
			[MUXPropertyDefaultValue(value = "320.0")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyValidationCallback(value = "CoerceToGreaterThanZero")]
			[MUXPropertyDefaultValue(value = "320.0")]
			[param: In]
			set;
		}

		public extern object MenuItemsSource
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern StyleSelector MenuItemContainerStyleSelector
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern Style MenuItemContainerStyle
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		public extern bool IsTitleBarAutoPaddingEnabled
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		public extern bool IsSettingsVisible
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		public extern bool IsPaneToggleButtonVisible
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		public extern bool IsPaneOpen
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		public extern DataTemplate HeaderTemplate
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern object Header
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern object FooterMenuItemsSource
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern DataTemplateSelector MenuItemTemplateSelector
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		[MUXPropertyValidationCallback(value = "CoerceToGreaterThanZero")]
		[MUXPropertyDefaultValue(value = "1008.0")]
		[MUXPropertyDefaultValue(value = "1008.0")]
		[MUXPropertyValidationCallback(value = "CoerceToGreaterThanZero")]
		public extern double ExpandedModeThresholdWidth
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyValidationCallback(value = "CoerceToGreaterThanZero")]
			[MUXPropertyDefaultValue(value = "1008.0")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyValidationCallback(value = "CoerceToGreaterThanZero")]
			[MUXPropertyDefaultValue(value = "1008.0")]
			[param: In]
			set;
		}

		public extern DataTemplate MenuItemTemplate
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		[MUXPropertyValidationCallback(value = "CoerceToGreaterThanZero")]
		[MUXPropertyValidationCallback(value = "CoerceToGreaterThanZero")]
		[MUXPropertyDefaultValue(value = "48.0")]
		[MUXPropertyDefaultValue(value = "48.0")]
		public extern double CompactPaneLength
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyValidationCallback(value = "CoerceToGreaterThanZero")]
			[MUXPropertyDefaultValue(value = "48.0")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "48.0")]
			[MUXPropertyValidationCallback(value = "CoerceToGreaterThanZero")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "641.0")]
		[MUXPropertyValidationCallback(value = "CoerceToGreaterThanZero")]
		[MUXPropertyDefaultValue(value = "641.0")]
		[MUXPropertyValidationCallback(value = "CoerceToGreaterThanZero")]
		public extern double CompactModeThresholdWidth
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyValidationCallback(value = "CoerceToGreaterThanZero")]
			[MUXPropertyDefaultValue(value = "641.0")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "641.0")]
			[MUXPropertyValidationCallback(value = "CoerceToGreaterThanZero")]
			[param: In]
			set;
		}

		public extern AutoSuggestBox AutoSuggestBox
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		public extern bool AlwaysShowHeader
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		public extern IList<object> MenuItems
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MUXPropertyDefaultValue(value = "winrt::NavigationViewDisplayMode::Minimal")]
		public extern NavigationViewDisplayMode DisplayMode
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::NavigationViewDisplayMode::Minimal")]
			get;
		}

		public extern IList<object> FooterMenuItems
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern object SettingsItem
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MUXPropertyDefaultValue(value = "winrt::NavigationViewShoulderNavigationEnabled::Never")]
		[MUXPropertyDefaultValue(value = "winrt::NavigationViewShoulderNavigationEnabled::Never")]
		public extern NavigationViewShoulderNavigationEnabled ShoulderNavigationEnabled
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::NavigationViewShoulderNavigationEnabled::Never")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::NavigationViewShoulderNavigationEnabled::Never")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "winrt::NavigationViewSelectionFollowsFocus::Disabled")]
		[MUXPropertyDefaultValue(value = "winrt::NavigationViewSelectionFollowsFocus::Disabled")]
		public extern NavigationViewSelectionFollowsFocus SelectionFollowsFocus
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::NavigationViewSelectionFollowsFocus::Disabled")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::NavigationViewSelectionFollowsFocus::Disabled")]
			[param: In]
			set;
		}

		public extern string PaneTitle
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		[MUXPropertyChangedCallback(enable = false)]
		[MUXPropertyChangedCallback(enable = false)]
		public extern UIElement PaneHeader
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyChangedCallback(enable = false)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyChangedCallback(enable = false)]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "winrt::NavigationViewPaneDisplayMode::Auto")]
		[MUXPropertyDefaultValue(value = "winrt::NavigationViewPaneDisplayMode::Auto")]
		public extern NavigationViewPaneDisplayMode PaneDisplayMode
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
		public extern UIElement PaneCustomContent
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyChangedCallback(enable = false)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyChangedCallback(enable = false)]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "winrt::NavigationViewOverflowLabelMode::MoreLabel")]
		[MUXPropertyDefaultValue(value = "winrt::NavigationViewOverflowLabelMode::MoreLabel")]
		public extern NavigationViewOverflowLabelMode OverflowLabelMode
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::NavigationViewOverflowLabelMode::MoreLabel")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::NavigationViewOverflowLabelMode::MoreLabel")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		public extern bool IsPaneVisible
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		public extern bool IsBackEnabled
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "winrt::NavigationViewBackButtonVisible::Auto")]
		[MUXPropertyDefaultValue(value = "winrt::NavigationViewBackButtonVisible::Auto")]
		public extern NavigationViewBackButtonVisible IsBackButtonVisible
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::NavigationViewBackButtonVisible::Auto")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::NavigationViewBackButtonVisible::Auto")]
			[param: In]
			set;
		}

		[MUXPropertyChangedCallback(enable = false)]
		[MUXPropertyChangedCallback(enable = false)]
		public extern UIElement ContentOverlay
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
		public extern NavigationViewTemplateSettings TemplateSettings
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyChangedCallback(enable = false)]
			get;
		}

		public static extern DependencyProperty FooterMenuItemsProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty IsTitleBarAutoPaddingEnabledProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty MenuItemContainerStyleProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty MenuItemContainerStyleSelectorProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty MenuItemTemplateProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty MenuItemTemplateSelectorProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty MenuItemsProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty MenuItemsSourceProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty OpenPaneLengthProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty PaneFooterProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty PaneToggleButtonStyleProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty SelectedItemProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty AlwaysShowHeaderProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty AutoSuggestBoxProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty CompactModeThresholdWidthProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty CompactPaneLengthProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty DisplayModeProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty ExpandedModeThresholdWidthProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty SettingsItemProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty FooterMenuItemsSourceProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty HeaderProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty HeaderTemplateProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty IsPaneOpenProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty IsPaneToggleButtonVisibleProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty IsSettingsVisibleProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty IsBackButtonVisibleProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty IsBackEnabledProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty IsPaneVisibleProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty OverflowLabelModeProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty PaneCustomContentProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty PaneDisplayModeProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty PaneHeaderProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty PaneTitleProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty SelectionFollowsFocusProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty ShoulderNavigationEnabledProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty TemplateSettingsProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty ContentOverlayProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[method: In]
		public extern event TypedEventHandler<NavigationView, NavigationViewDisplayModeChangedEventArgs> DisplayModeChanged;

		[method: In]
		public extern event TypedEventHandler<NavigationView, NavigationViewItemInvokedEventArgs> ItemInvoked;

		[method: In]
		public extern event TypedEventHandler<NavigationView, NavigationViewSelectionChangedEventArgs> SelectionChanged;

		[method: In]
		public extern event TypedEventHandler<NavigationView, NavigationViewBackRequestedEventArgs> BackRequested;

		[method: In]
		public extern event TypedEventHandler<NavigationView, NavigationViewItemCollapsedEventArgs> Collapsed;

		[method: In]
		public extern event TypedEventHandler<NavigationView, NavigationViewItemExpandingEventArgs> Expanding;

		[method: In]
		public extern event TypedEventHandler<NavigationView, object> PaneClosed;

		[method: In]
		public extern event TypedEventHandler<NavigationView, NavigationViewPaneClosingEventArgs> PaneClosing;

		[method: In]
		public extern event TypedEventHandler<NavigationView, object> PaneOpened;

		[method: In]
		public extern event TypedEventHandler<NavigationView, object> PaneOpening;

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern object MenuItemFromContainer([In] DependencyObject container);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern DependencyObject ContainerFromMenuItem([In] object item);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void Expand([In] NavigationViewItem item);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void Collapse([In] NavigationViewItem item);
	}
}
