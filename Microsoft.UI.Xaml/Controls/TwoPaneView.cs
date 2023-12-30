using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000229 RID: 553
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[MUXPropertyChangedCallback(enable = true)]
	[Threading(3)]
	[Composable(typeof(ITwoPaneViewFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[Static(typeof(ITwoPaneViewStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(2)]
	public class TwoPaneView : Control, ITwoPaneView
	{
		// Token: 0x06000BE9 RID: 3049
		public extern TwoPaneView();

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06000BEA RID: 3050
		// (set) Token: 0x06000BEB RID: 3051
		public extern UIElement Pane1
		{
			get; [param: In]
			set;
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x06000BEC RID: 3052
		// (set) Token: 0x06000BED RID: 3053
		public extern UIElement Pane2
		{
			get; [param: In]
			set;
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x06000BEE RID: 3054
		// (set) Token: 0x06000BEF RID: 3055
		[MUXPropertyDefaultValue(value = "c_pane1LengthDefault")]
		[MUXPropertyDefaultValue(value = "c_pane1LengthDefault")]
		public extern GridLength Pane1Length
		{
			[MUXPropertyDefaultValue(value = "c_pane1LengthDefault")]
			get;
			[MUXPropertyDefaultValue(value = "c_pane1LengthDefault")]
			[param: In]
			set;
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x06000BF0 RID: 3056
		// (set) Token: 0x06000BF1 RID: 3057
		[MUXPropertyDefaultValue(value = "c_pane2LengthDefault")]
		[MUXPropertyDefaultValue(value = "c_pane2LengthDefault")]
		public extern GridLength Pane2Length
		{
			[MUXPropertyDefaultValue(value = "c_pane2LengthDefault")]
			get;
			[MUXPropertyDefaultValue(value = "c_pane2LengthDefault")]
			[param: In]
			set;
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x06000BF2 RID: 3058
		// (set) Token: 0x06000BF3 RID: 3059
		[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewPriority::Pane1")]
		[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewPriority::Pane1")]
		public extern TwoPaneViewPriority PanePriority
		{
			[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewPriority::Pane1")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewPriority::Pane1")]
			[param: In]
			set;
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x06000BF4 RID: 3060
		[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewMode::SinglePane")]
		[MUXPropertyChangedCallback(enable = false)]
		public extern TwoPaneViewMode Mode
		{
			[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewMode::SinglePane")]
			[MUXPropertyChangedCallback(enable = false)]
			get;
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x06000BF5 RID: 3061
		// (set) Token: 0x06000BF6 RID: 3062
		[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewWideModeConfiguration::LeftRight")]
		[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewWideModeConfiguration::LeftRight")]
		public extern TwoPaneViewWideModeConfiguration WideModeConfiguration
		{
			[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewWideModeConfiguration::LeftRight")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewWideModeConfiguration::LeftRight")]
			[param: In]
			set;
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x06000BF7 RID: 3063
		// (set) Token: 0x06000BF8 RID: 3064
		[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewTallModeConfiguration::TopBottom")]
		[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewTallModeConfiguration::TopBottom")]
		public extern TwoPaneViewTallModeConfiguration TallModeConfiguration
		{
			[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewTallModeConfiguration::TopBottom")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewTallModeConfiguration::TopBottom")]
			[param: In]
			set;
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x06000BF9 RID: 3065
		// (set) Token: 0x06000BFA RID: 3066
		[MUXPropertyDefaultValue(value = "c_defaultMinWideModeWidth")]
		[MUXPropertyDefaultValue(value = "c_defaultMinWideModeWidth")]
		public extern double MinWideModeWidth
		{
			[MUXPropertyDefaultValue(value = "c_defaultMinWideModeWidth")]
			get;
			[MUXPropertyDefaultValue(value = "c_defaultMinWideModeWidth")]
			[param: In]
			set;
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x06000BFB RID: 3067
		// (set) Token: 0x06000BFC RID: 3068
		[MUXPropertyDefaultValue(value = "c_defaultMinTallModeHeight")]
		[MUXPropertyDefaultValue(value = "c_defaultMinTallModeHeight")]
		public extern double MinTallModeHeight
		{
			[MUXPropertyDefaultValue(value = "c_defaultMinTallModeHeight")]
			get;
			[MUXPropertyDefaultValue(value = "c_defaultMinTallModeHeight")]
			[param: In]
			set;
		}

		// Token: 0x1400006C RID: 108
		// (add) Token: 0x06000BFD RID: 3069
		// (remove) Token: 0x06000BFE RID: 3070
		public extern event TypedEventHandler<TwoPaneView, object> ModeChanged;

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x06000BFF RID: 3071
		public static extern DependencyProperty Pane1Property { get; }

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x06000C00 RID: 3072
		public static extern DependencyProperty Pane2Property { get; }

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x06000C01 RID: 3073
		public static extern DependencyProperty Pane1LengthProperty { get; }

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x06000C02 RID: 3074
		public static extern DependencyProperty Pane2LengthProperty { get; }

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x06000C03 RID: 3075
		public static extern DependencyProperty PanePriorityProperty { get; }

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x06000C04 RID: 3076
		public static extern DependencyProperty ModeProperty { get; }

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x06000C05 RID: 3077
		public static extern DependencyProperty WideModeConfigurationProperty { get; }

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x06000C06 RID: 3078
		public static extern DependencyProperty TallModeConfigurationProperty { get; }

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x06000C07 RID: 3079
		public static extern DependencyProperty MinWideModeWidthProperty { get; }

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x06000C08 RID: 3080
		public static extern DependencyProperty MinTallModeHeightProperty { get; }
	}
}
