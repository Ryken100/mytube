using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000E8 RID: 232
	[Guid(2922882909U, 19535, 20557, 131, 220, 168, 148, 244, 8, 248, 124)]
	[WebHostHidden]
	[ExclusiveTo(typeof(NavigationViewTemplateSettings))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface INavigationViewTemplateSettings
	{
		// Token: 0x170001BF RID: 447
		// (get) Token: 0x0600034E RID: 846
		[MUXPropertyDefaultValue(value = "0.0")]
		double TopPadding
		{
			[MUXPropertyDefaultValue(value = "0.0")]
			get;
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x0600034F RID: 847
		[MUXPropertyDefaultValue(value = "winrt::Visibility::Collapsed")]
		Visibility OverflowButtonVisibility
		{
			[MUXPropertyDefaultValue(value = "winrt::Visibility::Collapsed")]
			get;
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000350 RID: 848
		[MUXPropertyDefaultValue(value = "winrt::Visibility::Visible")]
		Visibility PaneToggleButtonVisibility
		{
			[MUXPropertyDefaultValue(value = "winrt::Visibility::Visible")]
			get;
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000351 RID: 849
		[MUXPropertyDefaultValue(value = "winrt::Visibility::Collapsed")]
		Visibility BackButtonVisibility
		{
			[MUXPropertyDefaultValue(value = "winrt::Visibility::Collapsed")]
			get;
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000352 RID: 850
		[MUXPropertyDefaultValue(value = "winrt::Visibility::Collapsed")]
		Visibility TopPaneVisibility
		{
			[MUXPropertyDefaultValue(value = "winrt::Visibility::Collapsed")]
			get;
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000353 RID: 851
		[MUXPropertyDefaultValue(value = "winrt::Visibility::Visible")]
		Visibility LeftPaneVisibility
		{
			[MUXPropertyDefaultValue(value = "winrt::Visibility::Visible")]
			get;
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000354 RID: 852
		bool SingleSelectionFollowsFocus { get; }

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000355 RID: 853
		double PaneToggleButtonWidth { get; }

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000356 RID: 854
		double SmallerPaneToggleButtonWidth { get; }
	}
}
