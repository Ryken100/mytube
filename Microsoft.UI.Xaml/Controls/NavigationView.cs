using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000195 RID: 405
	[Composable(typeof(INavigationViewFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MUXPropertyChangedCallback(enable = true)]
	[Static(typeof(INavigationViewStatics2), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Threading(3)]
	[Static(typeof(INavigationViewStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(2)]
	[WebHostHidden]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	public class NavigationView : ContentControl, INavigationView, INavigationView2
	{
		// Token: 0x0600072E RID: 1838
		public extern NavigationView();

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x0600072F RID: 1839
		// (set) Token: 0x06000730 RID: 1840
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		public extern bool IsPaneOpen
		{
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06000731 RID: 1841
		// (set) Token: 0x06000732 RID: 1842
		[MUXPropertyDefaultValue(value = "641.0")]
		[MUXPropertyValidationCallback(value = "CoerceToGreaterThanZero")]
		[MUXPropertyDefaultValue(value = "641.0")]
		[MUXPropertyValidationCallback(value = "CoerceToGreaterThanZero")]
		public extern double CompactModeThresholdWidth
		{
			[MUXPropertyValidationCallback(value = "CoerceToGreaterThanZero")]
			[MUXPropertyDefaultValue(value = "641.0")]
			get;
			[MUXPropertyDefaultValue(value = "641.0")]
			[MUXPropertyValidationCallback(value = "CoerceToGreaterThanZero")]
			[param: In]
			set;
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000733 RID: 1843
		// (set) Token: 0x06000734 RID: 1844
		[MUXPropertyValidationCallback(value = "CoerceToGreaterThanZero")]
		[MUXPropertyDefaultValue(value = "1008.0")]
		[MUXPropertyDefaultValue(value = "1008.0")]
		[MUXPropertyValidationCallback(value = "CoerceToGreaterThanZero")]
		public extern double ExpandedModeThresholdWidth
		{
			[MUXPropertyValidationCallback(value = "CoerceToGreaterThanZero")]
			[MUXPropertyDefaultValue(value = "1008.0")]
			get;
			[MUXPropertyValidationCallback(value = "CoerceToGreaterThanZero")]
			[MUXPropertyDefaultValue(value = "1008.0")]
			[param: In]
			set;
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06000735 RID: 1845
		public extern IVector<object> FooterMenuItems { get; }

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000736 RID: 1846
		// (set) Token: 0x06000737 RID: 1847
		public extern object FooterMenuItemsSource
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000738 RID: 1848
		// (set) Token: 0x06000739 RID: 1849
		public extern UIElement PaneFooter
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x0600073A RID: 1850
		// (set) Token: 0x0600073B RID: 1851
		public extern object Header
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x0600073C RID: 1852
		// (set) Token: 0x0600073D RID: 1853
		public extern DataTemplate HeaderTemplate
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x0600073E RID: 1854
		[MUXPropertyDefaultValue(value = "winrt::NavigationViewDisplayMode::Minimal")]
		public extern NavigationViewDisplayMode DisplayMode
		{
			[MUXPropertyDefaultValue(value = "winrt::NavigationViewDisplayMode::Minimal")]
			get;
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x0600073F RID: 1855
		// (set) Token: 0x06000740 RID: 1856
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		public extern bool IsSettingsVisible
		{
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000741 RID: 1857
		// (set) Token: 0x06000742 RID: 1858
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		public extern bool IsPaneToggleButtonVisible
		{
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06000743 RID: 1859
		// (set) Token: 0x06000744 RID: 1860
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		public extern bool AlwaysShowHeader
		{
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000745 RID: 1861
		// (set) Token: 0x06000746 RID: 1862
		[MUXPropertyValidationCallback(value = "CoerceToGreaterThanZero")]
		[MUXPropertyValidationCallback(value = "CoerceToGreaterThanZero")]
		[MUXPropertyDefaultValue(value = "48.0")]
		[MUXPropertyDefaultValue(value = "48.0")]
		public extern double CompactPaneLength
		{
			[MUXPropertyValidationCallback(value = "CoerceToGreaterThanZero")]
			[MUXPropertyDefaultValue(value = "48.0")]
			get;
			[MUXPropertyDefaultValue(value = "48.0")]
			[MUXPropertyValidationCallback(value = "CoerceToGreaterThanZero")]
			[param: In]
			set;
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000747 RID: 1863
		// (set) Token: 0x06000748 RID: 1864
		[MUXPropertyDefaultValue(value = "320.0")]
		[MUXPropertyValidationCallback(value = "CoerceToGreaterThanZero")]
		[MUXPropertyValidationCallback(value = "CoerceToGreaterThanZero")]
		[MUXPropertyDefaultValue(value = "320.0")]
		public extern double OpenPaneLength
		{
			[MUXPropertyValidationCallback(value = "CoerceToGreaterThanZero")]
			[MUXPropertyDefaultValue(value = "320.0")]
			get;
			[MUXPropertyValidationCallback(value = "CoerceToGreaterThanZero")]
			[MUXPropertyDefaultValue(value = "320.0")]
			[param: In]
			set;
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06000749 RID: 1865
		// (set) Token: 0x0600074A RID: 1866
		public extern Style PaneToggleButtonStyle
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x0600074B RID: 1867
		// (set) Token: 0x0600074C RID: 1868
		public extern object SelectedItem
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x0600074D RID: 1869
		public extern IVector<object> MenuItems { get; }

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x0600074E RID: 1870
		// (set) Token: 0x0600074F RID: 1871
		public extern object MenuItemsSource
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06000750 RID: 1872
		public extern object SettingsItem { get; }

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000751 RID: 1873
		// (set) Token: 0x06000752 RID: 1874
		public extern AutoSuggestBox AutoSuggestBox
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000753 RID: 1875
		// (set) Token: 0x06000754 RID: 1876
		public extern DataTemplate MenuItemTemplate
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000755 RID: 1877
		// (set) Token: 0x06000756 RID: 1878
		public extern DataTemplateSelector MenuItemTemplateSelector
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06000757 RID: 1879
		// (set) Token: 0x06000758 RID: 1880
		public extern Style MenuItemContainerStyle
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06000759 RID: 1881
		// (set) Token: 0x0600075A RID: 1882
		public extern StyleSelector MenuItemContainerStyleSelector
		{
			get; [param: In]
			set;
		}

		// Token: 0x0600075B RID: 1883
		public extern object MenuItemFromContainer([In] DependencyObject container);

		// Token: 0x0600075C RID: 1884
		public extern DependencyObject ContainerFromMenuItem([In] object item);

		// Token: 0x14000045 RID: 69
		// (add) Token: 0x0600075D RID: 1885
		// (remove) Token: 0x0600075E RID: 1886
		public extern event TypedEventHandler<NavigationView, NavigationViewSelectionChangedEventArgs> SelectionChanged;

		// Token: 0x14000044 RID: 68
		// (add) Token: 0x0600075F RID: 1887
		// (remove) Token: 0x06000760 RID: 1888
		public extern event TypedEventHandler<NavigationView, NavigationViewItemInvokedEventArgs> ItemInvoked;

		// Token: 0x14000043 RID: 67
		// (add) Token: 0x06000761 RID: 1889
		// (remove) Token: 0x06000762 RID: 1890
		public extern event TypedEventHandler<NavigationView, NavigationViewDisplayModeChangedEventArgs> DisplayModeChanged;

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000763 RID: 1891
		// (set) Token: 0x06000764 RID: 1892
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		public extern bool IsTitleBarAutoPaddingEnabled
		{
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06000765 RID: 1893
		// (set) Token: 0x06000766 RID: 1894
		[MUXPropertyDefaultValue(value = "winrt::NavigationViewBackButtonVisible::Auto")]
		[MUXPropertyDefaultValue(value = "winrt::NavigationViewBackButtonVisible::Auto")]
		public extern NavigationViewBackButtonVisible IsBackButtonVisible
		{
			[MUXPropertyDefaultValue(value = "winrt::NavigationViewBackButtonVisible::Auto")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::NavigationViewBackButtonVisible::Auto")]
			[param: In]
			set;
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06000767 RID: 1895
		// (set) Token: 0x06000768 RID: 1896
		public extern bool IsBackEnabled
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06000769 RID: 1897
		// (set) Token: 0x0600076A RID: 1898
		public extern string PaneTitle
		{
			get; [param: In]
			set;
		}

		// Token: 0x14000046 RID: 70
		// (add) Token: 0x0600076B RID: 1899
		// (remove) Token: 0x0600076C RID: 1900
		public extern event TypedEventHandler<NavigationView, NavigationViewBackRequestedEventArgs> BackRequested;

		// Token: 0x14000049 RID: 73
		// (add) Token: 0x0600076D RID: 1901
		// (remove) Token: 0x0600076E RID: 1902
		public extern event TypedEventHandler<NavigationView, object> PaneClosed;

		// Token: 0x1400004A RID: 74
		// (add) Token: 0x0600076F RID: 1903
		// (remove) Token: 0x06000770 RID: 1904
		public extern event TypedEventHandler<NavigationView, NavigationViewPaneClosingEventArgs> PaneClosing;

		// Token: 0x1400004B RID: 75
		// (add) Token: 0x06000771 RID: 1905
		// (remove) Token: 0x06000772 RID: 1906
		public extern event TypedEventHandler<NavigationView, object> PaneOpened;

		// Token: 0x1400004C RID: 76
		// (add) Token: 0x06000773 RID: 1907
		// (remove) Token: 0x06000774 RID: 1908
		public extern event TypedEventHandler<NavigationView, object> PaneOpening;

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06000775 RID: 1909
		// (set) Token: 0x06000776 RID: 1910
		[MUXPropertyDefaultValue(value = "winrt::NavigationViewPaneDisplayMode::Auto")]
		[MUXPropertyDefaultValue(value = "winrt::NavigationViewPaneDisplayMode::Auto")]
		public extern NavigationViewPaneDisplayMode PaneDisplayMode
		{
			[MUXPropertyDefaultValue(value = "winrt::NavigationViewPaneDisplayMode::Auto")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::NavigationViewPaneDisplayMode::Auto")]
			[param: In]
			set;
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06000777 RID: 1911
		// (set) Token: 0x06000778 RID: 1912
		[MUXPropertyChangedCallback(enable = false)]
		[MUXPropertyChangedCallback(enable = false)]
		public extern UIElement PaneHeader
		{
			[MUXPropertyChangedCallback(enable = false)]
			get;
			[MUXPropertyChangedCallback(enable = false)]
			[param: In]
			set;
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06000779 RID: 1913
		// (set) Token: 0x0600077A RID: 1914
		[MUXPropertyChangedCallback(enable = false)]
		[MUXPropertyChangedCallback(enable = false)]
		public extern UIElement PaneCustomContent
		{
			[MUXPropertyChangedCallback(enable = false)]
			get;
			[MUXPropertyChangedCallback(enable = false)]
			[param: In]
			set;
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x0600077B RID: 1915
		// (set) Token: 0x0600077C RID: 1916
		[MUXPropertyChangedCallback(enable = false)]
		[MUXPropertyChangedCallback(enable = false)]
		public extern UIElement ContentOverlay
		{
			[MUXPropertyChangedCallback(enable = false)]
			get;
			[MUXPropertyChangedCallback(enable = false)]
			[param: In]
			set;
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x0600077D RID: 1917
		// (set) Token: 0x0600077E RID: 1918
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		public extern bool IsPaneVisible
		{
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x0600077F RID: 1919
		// (set) Token: 0x06000780 RID: 1920
		[MUXPropertyDefaultValue(value = "winrt::NavigationViewSelectionFollowsFocus::Disabled")]
		[MUXPropertyDefaultValue(value = "winrt::NavigationViewSelectionFollowsFocus::Disabled")]
		public extern NavigationViewSelectionFollowsFocus SelectionFollowsFocus
		{
			[MUXPropertyDefaultValue(value = "winrt::NavigationViewSelectionFollowsFocus::Disabled")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::NavigationViewSelectionFollowsFocus::Disabled")]
			[param: In]
			set;
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06000781 RID: 1921
		[MUXPropertyChangedCallback(enable = false)]
		public extern NavigationViewTemplateSettings TemplateSettings
		{
			[MUXPropertyChangedCallback(enable = false)]
			get;
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000782 RID: 1922
		// (set) Token: 0x06000783 RID: 1923
		[MUXPropertyDefaultValue(value = "winrt::NavigationViewShoulderNavigationEnabled::Never")]
		[MUXPropertyDefaultValue(value = "winrt::NavigationViewShoulderNavigationEnabled::Never")]
		public extern NavigationViewShoulderNavigationEnabled ShoulderNavigationEnabled
		{
			[MUXPropertyDefaultValue(value = "winrt::NavigationViewShoulderNavigationEnabled::Never")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::NavigationViewShoulderNavigationEnabled::Never")]
			[param: In]
			set;
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06000784 RID: 1924
		// (set) Token: 0x06000785 RID: 1925
		[MUXPropertyDefaultValue(value = "winrt::NavigationViewOverflowLabelMode::MoreLabel")]
		[MUXPropertyDefaultValue(value = "winrt::NavigationViewOverflowLabelMode::MoreLabel")]
		public extern NavigationViewOverflowLabelMode OverflowLabelMode
		{
			[MUXPropertyDefaultValue(value = "winrt::NavigationViewOverflowLabelMode::MoreLabel")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::NavigationViewOverflowLabelMode::MoreLabel")]
			[param: In]
			set;
		}

		// Token: 0x14000048 RID: 72
		// (add) Token: 0x06000786 RID: 1926
		// (remove) Token: 0x06000787 RID: 1927
		public extern event TypedEventHandler<NavigationView, NavigationViewItemExpandingEventArgs> Expanding;

		// Token: 0x14000047 RID: 71
		// (add) Token: 0x06000788 RID: 1928
		// (remove) Token: 0x06000789 RID: 1929
		public extern event TypedEventHandler<NavigationView, NavigationViewItemCollapsedEventArgs> Collapsed;

		// Token: 0x0600078A RID: 1930
		public extern void Expand([In] NavigationViewItem item);

		// Token: 0x0600078B RID: 1931
		public extern void Collapse([In] NavigationViewItem item);

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x0600078C RID: 1932
		public static extern DependencyProperty IsBackButtonVisibleProperty { get; }

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x0600078D RID: 1933
		public static extern DependencyProperty IsBackEnabledProperty { get; }

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x0600078E RID: 1934
		public static extern DependencyProperty PaneTitleProperty { get; }

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x0600078F RID: 1935
		public static extern DependencyProperty PaneDisplayModeProperty { get; }

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06000790 RID: 1936
		public static extern DependencyProperty PaneHeaderProperty { get; }

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06000791 RID: 1937
		public static extern DependencyProperty PaneCustomContentProperty { get; }

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06000792 RID: 1938
		public static extern DependencyProperty ContentOverlayProperty { get; }

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06000793 RID: 1939
		public static extern DependencyProperty IsPaneVisibleProperty { get; }

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06000794 RID: 1940
		public static extern DependencyProperty SelectionFollowsFocusProperty { get; }

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06000795 RID: 1941
		public static extern DependencyProperty TemplateSettingsProperty { get; }

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06000796 RID: 1942
		public static extern DependencyProperty ShoulderNavigationEnabledProperty { get; }

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06000797 RID: 1943
		public static extern DependencyProperty OverflowLabelModeProperty { get; }

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06000798 RID: 1944
		public static extern DependencyProperty IsPaneOpenProperty { get; }

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06000799 RID: 1945
		public static extern DependencyProperty CompactModeThresholdWidthProperty { get; }

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x0600079A RID: 1946
		public static extern DependencyProperty ExpandedModeThresholdWidthProperty { get; }

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x0600079B RID: 1947
		public static extern DependencyProperty FooterMenuItemsProperty { get; }

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x0600079C RID: 1948
		public static extern DependencyProperty FooterMenuItemsSourceProperty { get; }

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x0600079D RID: 1949
		public static extern DependencyProperty PaneFooterProperty { get; }

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x0600079E RID: 1950
		public static extern DependencyProperty HeaderProperty { get; }

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x0600079F RID: 1951
		public static extern DependencyProperty HeaderTemplateProperty { get; }

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x060007A0 RID: 1952
		public static extern DependencyProperty DisplayModeProperty { get; }

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x060007A1 RID: 1953
		public static extern DependencyProperty IsSettingsVisibleProperty { get; }

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x060007A2 RID: 1954
		public static extern DependencyProperty IsPaneToggleButtonVisibleProperty { get; }

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x060007A3 RID: 1955
		public static extern DependencyProperty AlwaysShowHeaderProperty { get; }

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x060007A4 RID: 1956
		public static extern DependencyProperty CompactPaneLengthProperty { get; }

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x060007A5 RID: 1957
		public static extern DependencyProperty OpenPaneLengthProperty { get; }

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x060007A6 RID: 1958
		public static extern DependencyProperty PaneToggleButtonStyleProperty { get; }

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x060007A7 RID: 1959
		public static extern DependencyProperty MenuItemsProperty { get; }

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x060007A8 RID: 1960
		public static extern DependencyProperty MenuItemsSourceProperty { get; }

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x060007A9 RID: 1961
		public static extern DependencyProperty SelectedItemProperty { get; }

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x060007AA RID: 1962
		public static extern DependencyProperty SettingsItemProperty { get; }

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x060007AB RID: 1963
		public static extern DependencyProperty AutoSuggestBoxProperty { get; }

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x060007AC RID: 1964
		public static extern DependencyProperty MenuItemTemplateProperty { get; }

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x060007AD RID: 1965
		public static extern DependencyProperty MenuItemTemplateSelectorProperty { get; }

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x060007AE RID: 1966
		public static extern DependencyProperty MenuItemContainerStyleProperty { get; }

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x060007AF RID: 1967
		public static extern DependencyProperty MenuItemContainerStyleSelectorProperty { get; }

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x060007B0 RID: 1968
		public static extern DependencyProperty IsTitleBarAutoPaddingEnabledProperty { get; }
	}
}
