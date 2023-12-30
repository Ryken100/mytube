using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Markup;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200020A RID: 522
	[ContentProperty(Name = "TabItems")]
	[MarshalingBehavior(2)]
	[Composable(typeof(ITabViewFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[Static(typeof(ITabViewStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Threading(3)]
	public class TabView : Control, ITabView
	{
		// Token: 0x06000AAA RID: 2730
		public extern TabView();

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06000AAB RID: 2731
		// (set) Token: 0x06000AAC RID: 2732
		[MUXPropertyDefaultValue(value = "winrt::TabViewWidthMode::Equal")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "winrt::TabViewWidthMode::Equal")]
		public extern TabViewWidthMode TabWidthMode
		{
			[MUXPropertyDefaultValue(value = "winrt::TabViewWidthMode::Equal")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "winrt::TabViewWidthMode::Equal")]
			[param: In]
			set;
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06000AAD RID: 2733
		// (set) Token: 0x06000AAE RID: 2734
		[MUXPropertyDefaultValue(value = "winrt::TabViewCloseButtonOverlayMode::Auto")]
		[MUXPropertyDefaultValue(value = "winrt::TabViewCloseButtonOverlayMode::Auto")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		public extern TabViewCloseButtonOverlayMode CloseButtonOverlayMode
		{
			[MUXPropertyDefaultValue(value = "winrt::TabViewCloseButtonOverlayMode::Auto")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyDefaultValue(value = "winrt::TabViewCloseButtonOverlayMode::Auto")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06000AAF RID: 2735
		// (set) Token: 0x06000AB0 RID: 2736
		public extern object TabStripHeader
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06000AB1 RID: 2737
		// (set) Token: 0x06000AB2 RID: 2738
		public extern DataTemplate TabStripHeaderTemplate
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06000AB3 RID: 2739
		// (set) Token: 0x06000AB4 RID: 2740
		public extern object TabStripFooter
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06000AB5 RID: 2741
		// (set) Token: 0x06000AB6 RID: 2742
		public extern DataTemplate TabStripFooterTemplate
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06000AB7 RID: 2743
		// (set) Token: 0x06000AB8 RID: 2744
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		public extern bool IsAddTabButtonVisible
		{
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06000AB9 RID: 2745
		// (set) Token: 0x06000ABA RID: 2746
		public extern ICommand AddTabButtonCommand
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06000ABB RID: 2747
		// (set) Token: 0x06000ABC RID: 2748
		public extern object AddTabButtonCommandParameter
		{
			get; [param: In]
			set;
		}

		// Token: 0x1400005A RID: 90
		// (add) Token: 0x06000ABD RID: 2749
		// (remove) Token: 0x06000ABE RID: 2750
		public extern event TypedEventHandler<TabView, TabViewTabCloseRequestedEventArgs> TabCloseRequested;

		// Token: 0x1400005D RID: 93
		// (add) Token: 0x06000ABF RID: 2751
		// (remove) Token: 0x06000AC0 RID: 2752
		public extern event TypedEventHandler<TabView, TabViewTabDroppedOutsideEventArgs> TabDroppedOutside;

		// Token: 0x14000058 RID: 88
		// (add) Token: 0x06000AC1 RID: 2753
		// (remove) Token: 0x06000AC2 RID: 2754
		public extern event TypedEventHandler<TabView, object> AddTabButtonClick;

		// Token: 0x1400005E RID: 94
		// (add) Token: 0x06000AC3 RID: 2755
		// (remove) Token: 0x06000AC4 RID: 2756
		public extern event TypedEventHandler<TabView, IVectorChangedEventArgs> TabItemsChanged;

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06000AC5 RID: 2757
		// (set) Token: 0x06000AC6 RID: 2758
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		public extern object TabItemsSource
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06000AC7 RID: 2759
		public extern IVector<object> TabItems { get; }

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06000AC8 RID: 2760
		// (set) Token: 0x06000AC9 RID: 2761
		public extern DataTemplate TabItemTemplate
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06000ACA RID: 2762
		// (set) Token: 0x06000ACB RID: 2763
		public extern DataTemplateSelector TabItemTemplateSelector
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06000ACC RID: 2764
		// (set) Token: 0x06000ACD RID: 2765
		[MUXPropertyDefaultValue(value = "false")]
		[MUXPropertyDefaultValue(value = "false")]
		public extern bool CanDragTabs
		{
			[MUXPropertyDefaultValue(value = "false")]
			get;
			[MUXPropertyDefaultValue(value = "false")]
			[param: In]
			set;
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06000ACE RID: 2766
		// (set) Token: 0x06000ACF RID: 2767
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		public extern bool CanReorderTabs
		{
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06000AD0 RID: 2768
		// (set) Token: 0x06000AD1 RID: 2769
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		public extern bool AllowDropTabs
		{
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06000AD2 RID: 2770
		// (set) Token: 0x06000AD3 RID: 2771
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "0")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "0")]
		public extern int SelectedIndex
		{
			[MUXPropertyDefaultValue(value = "0")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyDefaultValue(value = "0")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06000AD4 RID: 2772
		// (set) Token: 0x06000AD5 RID: 2773
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		public extern object SelectedItem
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x06000AD6 RID: 2774
		public extern DependencyObject ContainerFromItem([In] object item);

		// Token: 0x06000AD7 RID: 2775
		public extern DependencyObject ContainerFromIndex([In] int index);

		// Token: 0x14000059 RID: 89
		// (add) Token: 0x06000AD8 RID: 2776
		// (remove) Token: 0x06000AD9 RID: 2777
		public extern event SelectionChangedEventHandler SelectionChanged;

		// Token: 0x1400005C RID: 92
		// (add) Token: 0x06000ADA RID: 2778
		// (remove) Token: 0x06000ADB RID: 2779
		public extern event TypedEventHandler<TabView, TabViewTabDragStartingEventArgs> TabDragStarting;

		// Token: 0x1400005B RID: 91
		// (add) Token: 0x06000ADC RID: 2780
		// (remove) Token: 0x06000ADD RID: 2781
		public extern event TypedEventHandler<TabView, TabViewTabDragCompletedEventArgs> TabDragCompleted;

		// Token: 0x1400005F RID: 95
		// (add) Token: 0x06000ADE RID: 2782
		// (remove) Token: 0x06000ADF RID: 2783
		public extern event DragEventHandler TabStripDragOver;

		// Token: 0x14000060 RID: 96
		// (add) Token: 0x06000AE0 RID: 2784
		// (remove) Token: 0x06000AE1 RID: 2785
		public extern event DragEventHandler TabStripDrop;

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06000AE2 RID: 2786
		public static extern DependencyProperty TabWidthModeProperty { get; }

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06000AE3 RID: 2787
		public static extern DependencyProperty TabStripHeaderProperty { get; }

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06000AE4 RID: 2788
		public static extern DependencyProperty TabStripHeaderTemplateProperty { get; }

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06000AE5 RID: 2789
		public static extern DependencyProperty TabStripFooterProperty { get; }

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06000AE6 RID: 2790
		public static extern DependencyProperty TabStripFooterTemplateProperty { get; }

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06000AE7 RID: 2791
		public static extern DependencyProperty IsAddTabButtonVisibleProperty { get; }

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06000AE8 RID: 2792
		public static extern DependencyProperty AddTabButtonCommandProperty { get; }

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06000AE9 RID: 2793
		public static extern DependencyProperty AddTabButtonCommandParameterProperty { get; }

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06000AEA RID: 2794
		public static extern DependencyProperty TabItemsSourceProperty { get; }

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06000AEB RID: 2795
		public static extern DependencyProperty TabItemsProperty { get; }

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06000AEC RID: 2796
		public static extern DependencyProperty TabItemTemplateProperty { get; }

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06000AED RID: 2797
		public static extern DependencyProperty TabItemTemplateSelectorProperty { get; }

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06000AEE RID: 2798
		public static extern DependencyProperty CloseButtonOverlayModeProperty { get; }

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06000AEF RID: 2799
		public static extern DependencyProperty CanDragTabsProperty { get; }

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06000AF0 RID: 2800
		public static extern DependencyProperty CanReorderTabsProperty { get; }

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06000AF1 RID: 2801
		public static extern DependencyProperty AllowDropTabsProperty { get; }

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06000AF2 RID: 2802
		public static extern DependencyProperty SelectedIndexProperty { get; }

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06000AF3 RID: 2803
		public static extern DependencyProperty SelectedItemProperty { get; }
	}
}
