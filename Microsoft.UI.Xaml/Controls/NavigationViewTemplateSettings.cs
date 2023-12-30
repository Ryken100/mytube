using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020001A7 RID: 423
	[Composable(typeof(INavigationViewTemplateSettingsFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(2)]
	[Threading(3)]
	[WebHostHidden]
	[Static(typeof(INavigationViewTemplateSettingsStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	public class NavigationViewTemplateSettings : DependencyObject, INavigationViewTemplateSettings
	{
		// Token: 0x060007DD RID: 2013
		public extern NavigationViewTemplateSettings();

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x060007DE RID: 2014
		[MUXPropertyDefaultValue(value = "0.0")]
		public extern double TopPadding
		{
			[MUXPropertyDefaultValue(value = "0.0")]
			get;
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x060007DF RID: 2015
		[MUXPropertyDefaultValue(value = "winrt::Visibility::Collapsed")]
		public extern Visibility OverflowButtonVisibility
		{
			[MUXPropertyDefaultValue(value = "winrt::Visibility::Collapsed")]
			get;
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x060007E0 RID: 2016
		[MUXPropertyDefaultValue(value = "winrt::Visibility::Visible")]
		public extern Visibility PaneToggleButtonVisibility
		{
			[MUXPropertyDefaultValue(value = "winrt::Visibility::Visible")]
			get;
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x060007E1 RID: 2017
		[MUXPropertyDefaultValue(value = "winrt::Visibility::Collapsed")]
		public extern Visibility BackButtonVisibility
		{
			[MUXPropertyDefaultValue(value = "winrt::Visibility::Collapsed")]
			get;
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x060007E2 RID: 2018
		[MUXPropertyDefaultValue(value = "winrt::Visibility::Collapsed")]
		public extern Visibility TopPaneVisibility
		{
			[MUXPropertyDefaultValue(value = "winrt::Visibility::Collapsed")]
			get;
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x060007E3 RID: 2019
		[MUXPropertyDefaultValue(value = "winrt::Visibility::Visible")]
		public extern Visibility LeftPaneVisibility
		{
			[MUXPropertyDefaultValue(value = "winrt::Visibility::Visible")]
			get;
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x060007E4 RID: 2020
		public extern bool SingleSelectionFollowsFocus { get; }

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x060007E5 RID: 2021
		public extern double PaneToggleButtonWidth { get; }

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x060007E6 RID: 2022
		public extern double SmallerPaneToggleButtonWidth { get; }

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x060007E7 RID: 2023
		public static extern DependencyProperty TopPaddingProperty { get; }

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x060007E8 RID: 2024
		public static extern DependencyProperty OverflowButtonVisibilityProperty { get; }

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x060007E9 RID: 2025
		public static extern DependencyProperty PaneToggleButtonVisibilityProperty { get; }

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x060007EA RID: 2026
		public static extern DependencyProperty BackButtonVisibilityProperty { get; }

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x060007EB RID: 2027
		public static extern DependencyProperty TopPaneVisibilityProperty { get; }

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x060007EC RID: 2028
		public static extern DependencyProperty LeftPaneVisibilityProperty { get; }

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x060007ED RID: 2029
		public static extern DependencyProperty SingleSelectionFollowsFocusProperty { get; }

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x060007EE RID: 2030
		public static extern DependencyProperty PaneToggleButtonWidthProperty { get; }

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x060007EF RID: 2031
		public static extern DependencyProperty SmallerPaneToggleButtonWidthProperty { get; }
	}
}
