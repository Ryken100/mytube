using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000E6 RID: 230
	[Guid(568216459U, 14345, 24209, 133, 6, 104, 34, 43, 239, 130, 232)]
	[MUXPropertyChangedCallback(enable = true)]
	[WebHostHidden]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ExclusiveTo(typeof(NavigationView))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface INavigationViewStatics
	{
		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000329 RID: 809
		DependencyProperty IsPaneOpenProperty { get; }

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x0600032A RID: 810
		DependencyProperty CompactModeThresholdWidthProperty { get; }

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x0600032B RID: 811
		DependencyProperty ExpandedModeThresholdWidthProperty { get; }

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x0600032C RID: 812
		DependencyProperty FooterMenuItemsProperty { get; }

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x0600032D RID: 813
		DependencyProperty FooterMenuItemsSourceProperty { get; }

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x0600032E RID: 814
		DependencyProperty PaneFooterProperty { get; }

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x0600032F RID: 815
		DependencyProperty HeaderProperty { get; }

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000330 RID: 816
		DependencyProperty HeaderTemplateProperty { get; }

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000331 RID: 817
		DependencyProperty DisplayModeProperty { get; }

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000332 RID: 818
		DependencyProperty IsSettingsVisibleProperty { get; }

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000333 RID: 819
		DependencyProperty IsPaneToggleButtonVisibleProperty { get; }

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000334 RID: 820
		DependencyProperty AlwaysShowHeaderProperty { get; }

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000335 RID: 821
		DependencyProperty CompactPaneLengthProperty { get; }

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000336 RID: 822
		DependencyProperty OpenPaneLengthProperty { get; }

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000337 RID: 823
		DependencyProperty PaneToggleButtonStyleProperty { get; }

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000338 RID: 824
		DependencyProperty MenuItemsProperty { get; }

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000339 RID: 825
		DependencyProperty MenuItemsSourceProperty { get; }

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x0600033A RID: 826
		DependencyProperty SelectedItemProperty { get; }

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x0600033B RID: 827
		DependencyProperty SettingsItemProperty { get; }

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x0600033C RID: 828
		DependencyProperty AutoSuggestBoxProperty { get; }

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x0600033D RID: 829
		DependencyProperty MenuItemTemplateProperty { get; }

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x0600033E RID: 830
		DependencyProperty MenuItemTemplateSelectorProperty { get; }

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x0600033F RID: 831
		DependencyProperty MenuItemContainerStyleProperty { get; }

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000340 RID: 832
		DependencyProperty MenuItemContainerStyleSelectorProperty { get; }

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000341 RID: 833
		DependencyProperty IsTitleBarAutoPaddingEnabledProperty { get; }
	}
}
