using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000CE RID: 206
	[WebHostHidden]
	[Guid(1537404668U, 14134, 24130, 172, 86, 157, 11, 229, 82, 61, 64)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[MUXPropertyChangedCallback(enable = true)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(NavigationView))]
	internal interface INavigationView2
	{
		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060002D6 RID: 726
		// (set) Token: 0x060002D7 RID: 727
		[MUXPropertyDefaultValue(value = "winrt::NavigationViewBackButtonVisible::Auto")]
		[MUXPropertyDefaultValue(value = "winrt::NavigationViewBackButtonVisible::Auto")]
		NavigationViewBackButtonVisible IsBackButtonVisible
		{
			[MUXPropertyDefaultValue(value = "winrt::NavigationViewBackButtonVisible::Auto")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::NavigationViewBackButtonVisible::Auto")]
			[param: In]
			set;
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060002D8 RID: 728
		// (set) Token: 0x060002D9 RID: 729
		bool IsBackEnabled
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060002DA RID: 730
		// (set) Token: 0x060002DB RID: 731
		string PaneTitle
		{
			get; [param: In]
			set;
		}

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x060002DC RID: 732
		// (remove) Token: 0x060002DD RID: 733
		event TypedEventHandler<NavigationView, NavigationViewBackRequestedEventArgs> BackRequested;

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x060002DE RID: 734
		// (remove) Token: 0x060002DF RID: 735
		event TypedEventHandler<NavigationView, object> PaneClosed;

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x060002E0 RID: 736
		// (remove) Token: 0x060002E1 RID: 737
		event TypedEventHandler<NavigationView, NavigationViewPaneClosingEventArgs> PaneClosing;

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x060002E2 RID: 738
		// (remove) Token: 0x060002E3 RID: 739
		event TypedEventHandler<NavigationView, object> PaneOpened;

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x060002E4 RID: 740
		// (remove) Token: 0x060002E5 RID: 741
		event TypedEventHandler<NavigationView, object> PaneOpening;

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060002E6 RID: 742
		// (set) Token: 0x060002E7 RID: 743
		[MUXPropertyDefaultValue(value = "winrt::NavigationViewPaneDisplayMode::Auto")]
		[MUXPropertyDefaultValue(value = "winrt::NavigationViewPaneDisplayMode::Auto")]
		NavigationViewPaneDisplayMode PaneDisplayMode
		{
			[MUXPropertyDefaultValue(value = "winrt::NavigationViewPaneDisplayMode::Auto")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::NavigationViewPaneDisplayMode::Auto")]
			[param: In]
			set;
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060002E8 RID: 744
		// (set) Token: 0x060002E9 RID: 745
		[MUXPropertyChangedCallback(enable = false)]
		[MUXPropertyChangedCallback(enable = false)]
		UIElement PaneHeader
		{
			[MUXPropertyChangedCallback(enable = false)]
			get;
			[MUXPropertyChangedCallback(enable = false)]
			[param: In]
			set;
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060002EA RID: 746
		// (set) Token: 0x060002EB RID: 747
		[MUXPropertyChangedCallback(enable = false)]
		[MUXPropertyChangedCallback(enable = false)]
		UIElement PaneCustomContent
		{
			[MUXPropertyChangedCallback(enable = false)]
			get;
			[MUXPropertyChangedCallback(enable = false)]
			[param: In]
			set;
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060002EC RID: 748
		// (set) Token: 0x060002ED RID: 749
		[MUXPropertyChangedCallback(enable = false)]
		[MUXPropertyChangedCallback(enable = false)]
		UIElement ContentOverlay
		{
			[MUXPropertyChangedCallback(enable = false)]
			get;
			[MUXPropertyChangedCallback(enable = false)]
			[param: In]
			set;
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060002EE RID: 750
		// (set) Token: 0x060002EF RID: 751
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		bool IsPaneVisible
		{
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060002F0 RID: 752
		// (set) Token: 0x060002F1 RID: 753
		[MUXPropertyDefaultValue(value = "winrt::NavigationViewSelectionFollowsFocus::Disabled")]
		[MUXPropertyDefaultValue(value = "winrt::NavigationViewSelectionFollowsFocus::Disabled")]
		NavigationViewSelectionFollowsFocus SelectionFollowsFocus
		{
			[MUXPropertyDefaultValue(value = "winrt::NavigationViewSelectionFollowsFocus::Disabled")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::NavigationViewSelectionFollowsFocus::Disabled")]
			[param: In]
			set;
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060002F2 RID: 754
		[MUXPropertyChangedCallback(enable = false)]
		NavigationViewTemplateSettings TemplateSettings
		{
			[MUXPropertyChangedCallback(enable = false)]
			get;
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060002F3 RID: 755
		// (set) Token: 0x060002F4 RID: 756
		[MUXPropertyDefaultValue(value = "winrt::NavigationViewShoulderNavigationEnabled::Never")]
		[MUXPropertyDefaultValue(value = "winrt::NavigationViewShoulderNavigationEnabled::Never")]
		NavigationViewShoulderNavigationEnabled ShoulderNavigationEnabled
		{
			[MUXPropertyDefaultValue(value = "winrt::NavigationViewShoulderNavigationEnabled::Never")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::NavigationViewShoulderNavigationEnabled::Never")]
			[param: In]
			set;
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060002F5 RID: 757
		// (set) Token: 0x060002F6 RID: 758
		[MUXPropertyDefaultValue(value = "winrt::NavigationViewOverflowLabelMode::MoreLabel")]
		[MUXPropertyDefaultValue(value = "winrt::NavigationViewOverflowLabelMode::MoreLabel")]
		NavigationViewOverflowLabelMode OverflowLabelMode
		{
			[MUXPropertyDefaultValue(value = "winrt::NavigationViewOverflowLabelMode::MoreLabel")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::NavigationViewOverflowLabelMode::MoreLabel")]
			[param: In]
			set;
		}

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x060002F7 RID: 759
		// (remove) Token: 0x060002F8 RID: 760
		event TypedEventHandler<NavigationView, NavigationViewItemExpandingEventArgs> Expanding;

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x060002F9 RID: 761
		// (remove) Token: 0x060002FA RID: 762
		event TypedEventHandler<NavigationView, NavigationViewItemCollapsedEventArgs> Collapsed;

		// Token: 0x060002FB RID: 763
		void Expand([In] NavigationViewItem item);

		// Token: 0x060002FC RID: 764
		void Collapse([In] NavigationViewItem item);
	}
}
