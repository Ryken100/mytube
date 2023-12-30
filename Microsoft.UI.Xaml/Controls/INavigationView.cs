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
	// Token: 0x020000CD RID: 205
	[ExclusiveTo(typeof(NavigationView))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MUXPropertyChangedCallback(enable = true)]
	[Guid(2953753932U, 37236, 23940, 150, 120, 86, 201, 128, 22, 230, 137)]
	[WebHostHidden]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	internal interface INavigationView
	{
		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060002A0 RID: 672
		// (set) Token: 0x060002A1 RID: 673
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		bool IsPaneOpen
		{
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060002A2 RID: 674
		// (set) Token: 0x060002A3 RID: 675
		[MUXPropertyDefaultValue(value = "641.0")]
		[MUXPropertyValidationCallback(value = "CoerceToGreaterThanZero")]
		[MUXPropertyValidationCallback(value = "CoerceToGreaterThanZero")]
		[MUXPropertyDefaultValue(value = "641.0")]
		double CompactModeThresholdWidth
		{
			[MUXPropertyValidationCallback(value = "CoerceToGreaterThanZero")]
			[MUXPropertyDefaultValue(value = "641.0")]
			get;
			[MUXPropertyDefaultValue(value = "641.0")]
			[MUXPropertyValidationCallback(value = "CoerceToGreaterThanZero")]
			[param: In]
			set;
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060002A4 RID: 676
		// (set) Token: 0x060002A5 RID: 677
		[MUXPropertyDefaultValue(value = "1008.0")]
		[MUXPropertyDefaultValue(value = "1008.0")]
		[MUXPropertyValidationCallback(value = "CoerceToGreaterThanZero")]
		[MUXPropertyValidationCallback(value = "CoerceToGreaterThanZero")]
		double ExpandedModeThresholdWidth
		{
			[MUXPropertyDefaultValue(value = "1008.0")]
			[MUXPropertyValidationCallback(value = "CoerceToGreaterThanZero")]
			get;
			[MUXPropertyValidationCallback(value = "CoerceToGreaterThanZero")]
			[MUXPropertyDefaultValue(value = "1008.0")]
			[param: In]
			set;
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060002A6 RID: 678
		IVector<object> FooterMenuItems { get; }

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060002A7 RID: 679
		// (set) Token: 0x060002A8 RID: 680
		object FooterMenuItemsSource
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060002A9 RID: 681
		// (set) Token: 0x060002AA RID: 682
		UIElement PaneFooter
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060002AB RID: 683
		// (set) Token: 0x060002AC RID: 684
		object Header
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060002AD RID: 685
		// (set) Token: 0x060002AE RID: 686
		DataTemplate HeaderTemplate
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060002AF RID: 687
		[MUXPropertyDefaultValue(value = "winrt::NavigationViewDisplayMode::Minimal")]
		NavigationViewDisplayMode DisplayMode
		{
			[MUXPropertyDefaultValue(value = "winrt::NavigationViewDisplayMode::Minimal")]
			get;
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060002B0 RID: 688
		// (set) Token: 0x060002B1 RID: 689
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		bool IsSettingsVisible
		{
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060002B2 RID: 690
		// (set) Token: 0x060002B3 RID: 691
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		bool IsPaneToggleButtonVisible
		{
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060002B4 RID: 692
		// (set) Token: 0x060002B5 RID: 693
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		bool AlwaysShowHeader
		{
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060002B6 RID: 694
		// (set) Token: 0x060002B7 RID: 695
		[MUXPropertyValidationCallback(value = "CoerceToGreaterThanZero")]
		[MUXPropertyDefaultValue(value = "48.0")]
		[MUXPropertyDefaultValue(value = "48.0")]
		[MUXPropertyValidationCallback(value = "CoerceToGreaterThanZero")]
		double CompactPaneLength
		{
			[MUXPropertyDefaultValue(value = "48.0")]
			[MUXPropertyValidationCallback(value = "CoerceToGreaterThanZero")]
			get;
			[MUXPropertyDefaultValue(value = "48.0")]
			[MUXPropertyValidationCallback(value = "CoerceToGreaterThanZero")]
			[param: In]
			set;
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060002B8 RID: 696
		// (set) Token: 0x060002B9 RID: 697
		[MUXPropertyValidationCallback(value = "CoerceToGreaterThanZero")]
		[MUXPropertyDefaultValue(value = "320.0")]
		[MUXPropertyDefaultValue(value = "320.0")]
		[MUXPropertyValidationCallback(value = "CoerceToGreaterThanZero")]
		double OpenPaneLength
		{
			[MUXPropertyValidationCallback(value = "CoerceToGreaterThanZero")]
			[MUXPropertyDefaultValue(value = "320.0")]
			get;
			[MUXPropertyDefaultValue(value = "320.0")]
			[MUXPropertyValidationCallback(value = "CoerceToGreaterThanZero")]
			[param: In]
			set;
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060002BA RID: 698
		// (set) Token: 0x060002BB RID: 699
		Style PaneToggleButtonStyle
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060002BC RID: 700
		// (set) Token: 0x060002BD RID: 701
		object SelectedItem
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060002BE RID: 702
		IVector<object> MenuItems { get; }

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060002BF RID: 703
		// (set) Token: 0x060002C0 RID: 704
		object MenuItemsSource
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060002C1 RID: 705
		object SettingsItem { get; }

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060002C2 RID: 706
		// (set) Token: 0x060002C3 RID: 707
		AutoSuggestBox AutoSuggestBox
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060002C4 RID: 708
		// (set) Token: 0x060002C5 RID: 709
		DataTemplate MenuItemTemplate
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060002C6 RID: 710
		// (set) Token: 0x060002C7 RID: 711
		DataTemplateSelector MenuItemTemplateSelector
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060002C8 RID: 712
		// (set) Token: 0x060002C9 RID: 713
		Style MenuItemContainerStyle
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060002CA RID: 714
		// (set) Token: 0x060002CB RID: 715
		StyleSelector MenuItemContainerStyleSelector
		{
			get; [param: In]
			set;
		}

		// Token: 0x060002CC RID: 716
		object MenuItemFromContainer([In] DependencyObject container);

		// Token: 0x060002CD RID: 717
		DependencyObject ContainerFromMenuItem([In] object item);

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x060002CE RID: 718
		// (remove) Token: 0x060002CF RID: 719
		event TypedEventHandler<NavigationView, NavigationViewSelectionChangedEventArgs> SelectionChanged;

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x060002D0 RID: 720
		// (remove) Token: 0x060002D1 RID: 721
		event TypedEventHandler<NavigationView, NavigationViewItemInvokedEventArgs> ItemInvoked;

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x060002D2 RID: 722
		// (remove) Token: 0x060002D3 RID: 723
		event TypedEventHandler<NavigationView, NavigationViewDisplayModeChangedEventArgs> DisplayModeChanged;

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060002D4 RID: 724
		// (set) Token: 0x060002D5 RID: 725
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		bool IsTitleBarAutoPaddingEnabled
		{
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}
	}
}
