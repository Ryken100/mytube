using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000213 RID: 531
	[Static(typeof(ITeachingTipStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Composable(typeof(ITeachingTipFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[WebHostHidden]
	[Threading(3)]
	[MUXPropertyChangedCallback(enable = true)]
	[MarshalingBehavior(2)]
	public class TeachingTip : ContentControl, ITeachingTip
	{
		// Token: 0x06000B15 RID: 2837
		public extern TeachingTip();

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06000B16 RID: 2838
		// (set) Token: 0x06000B17 RID: 2839
		public extern string Title
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06000B18 RID: 2840
		// (set) Token: 0x06000B19 RID: 2841
		public extern string Subtitle
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06000B1A RID: 2842
		// (set) Token: 0x06000B1B RID: 2843
		[MUXPropertyDefaultValue(value = "false")]
		[MUXPropertyDefaultValue(value = "false")]
		public extern bool IsOpen
		{
			[MUXPropertyDefaultValue(value = "false")]
			get;
			[MUXPropertyDefaultValue(value = "false")]
			[param: In]
			set;
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06000B1C RID: 2844
		// (set) Token: 0x06000B1D RID: 2845
		public extern FrameworkElement Target
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06000B1E RID: 2846
		// (set) Token: 0x06000B1F RID: 2847
		[MUXPropertyDefaultValue(value = "winrt::TeachingTipTailVisibility::Auto")]
		[MUXPropertyDefaultValue(value = "winrt::TeachingTipTailVisibility::Auto")]
		public extern TeachingTipTailVisibility TailVisibility
		{
			[MUXPropertyDefaultValue(value = "winrt::TeachingTipTailVisibility::Auto")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::TeachingTipTailVisibility::Auto")]
			[param: In]
			set;
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06000B20 RID: 2848
		// (set) Token: 0x06000B21 RID: 2849
		public extern object ActionButtonContent
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06000B22 RID: 2850
		// (set) Token: 0x06000B23 RID: 2851
		public extern Style ActionButtonStyle
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06000B24 RID: 2852
		// (set) Token: 0x06000B25 RID: 2853
		public extern ICommand ActionButtonCommand
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06000B26 RID: 2854
		// (set) Token: 0x06000B27 RID: 2855
		public extern object ActionButtonCommandParameter
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06000B28 RID: 2856
		// (set) Token: 0x06000B29 RID: 2857
		public extern object CloseButtonContent
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06000B2A RID: 2858
		// (set) Token: 0x06000B2B RID: 2859
		public extern Style CloseButtonStyle
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06000B2C RID: 2860
		// (set) Token: 0x06000B2D RID: 2861
		public extern ICommand CloseButtonCommand
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06000B2E RID: 2862
		// (set) Token: 0x06000B2F RID: 2863
		public extern object CloseButtonCommandParameter
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06000B30 RID: 2864
		// (set) Token: 0x06000B31 RID: 2865
		public extern Thickness PlacementMargin
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06000B32 RID: 2866
		// (set) Token: 0x06000B33 RID: 2867
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		public extern bool ShouldConstrainToRootBounds
		{
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06000B34 RID: 2868
		// (set) Token: 0x06000B35 RID: 2869
		[MUXPropertyDefaultValue(value = "false")]
		[MUXPropertyDefaultValue(value = "false")]
		public extern bool IsLightDismissEnabled
		{
			[MUXPropertyDefaultValue(value = "false")]
			get;
			[MUXPropertyDefaultValue(value = "false")]
			[param: In]
			set;
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06000B36 RID: 2870
		// (set) Token: 0x06000B37 RID: 2871
		[MUXPropertyDefaultValue(value = "winrt::TeachingTipPlacementMode::Auto")]
		[MUXPropertyDefaultValue(value = "winrt::TeachingTipPlacementMode::Auto")]
		public extern TeachingTipPlacementMode PreferredPlacement
		{
			[MUXPropertyDefaultValue(value = "winrt::TeachingTipPlacementMode::Auto")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::TeachingTipPlacementMode::Auto")]
			[param: In]
			set;
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06000B38 RID: 2872
		// (set) Token: 0x06000B39 RID: 2873
		[MUXPropertyDefaultValue(value = "winrt::TeachingTipHeroContentPlacementMode::Auto")]
		[MUXPropertyDefaultValue(value = "winrt::TeachingTipHeroContentPlacementMode::Auto")]
		public extern TeachingTipHeroContentPlacementMode HeroContentPlacement
		{
			[MUXPropertyDefaultValue(value = "winrt::TeachingTipHeroContentPlacementMode::Auto")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::TeachingTipHeroContentPlacementMode::Auto")]
			[param: In]
			set;
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06000B3A RID: 2874
		// (set) Token: 0x06000B3B RID: 2875
		public extern UIElement HeroContent
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06000B3C RID: 2876
		// (set) Token: 0x06000B3D RID: 2877
		public extern IconSource IconSource
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06000B3E RID: 2878
		public extern TeachingTipTemplateSettings TemplateSettings { get; }

		// Token: 0x14000062 RID: 98
		// (add) Token: 0x06000B3F RID: 2879
		// (remove) Token: 0x06000B40 RID: 2880
		public extern event TypedEventHandler<TeachingTip, object> ActionButtonClick;

		// Token: 0x14000063 RID: 99
		// (add) Token: 0x06000B41 RID: 2881
		// (remove) Token: 0x06000B42 RID: 2882
		public extern event TypedEventHandler<TeachingTip, object> CloseButtonClick;

		// Token: 0x14000065 RID: 101
		// (add) Token: 0x06000B43 RID: 2883
		// (remove) Token: 0x06000B44 RID: 2884
		public extern event TypedEventHandler<TeachingTip, TeachingTipClosingEventArgs> Closing;

		// Token: 0x14000064 RID: 100
		// (add) Token: 0x06000B45 RID: 2885
		// (remove) Token: 0x06000B46 RID: 2886
		public extern event TypedEventHandler<TeachingTip, TeachingTipClosedEventArgs> Closed;

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06000B47 RID: 2887
		public static extern DependencyProperty IsOpenProperty { get; }

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06000B48 RID: 2888
		public static extern DependencyProperty TargetProperty { get; }

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06000B49 RID: 2889
		public static extern DependencyProperty TailVisibilityProperty { get; }

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06000B4A RID: 2890
		public static extern DependencyProperty TitleProperty { get; }

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06000B4B RID: 2891
		public static extern DependencyProperty SubtitleProperty { get; }

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06000B4C RID: 2892
		public static extern DependencyProperty ActionButtonContentProperty { get; }

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06000B4D RID: 2893
		public static extern DependencyProperty ActionButtonStyleProperty { get; }

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x06000B4E RID: 2894
		public static extern DependencyProperty ActionButtonCommandProperty { get; }

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x06000B4F RID: 2895
		public static extern DependencyProperty ActionButtonCommandParameterProperty { get; }

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06000B50 RID: 2896
		public static extern DependencyProperty CloseButtonContentProperty { get; }

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06000B51 RID: 2897
		public static extern DependencyProperty CloseButtonStyleProperty { get; }

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06000B52 RID: 2898
		public static extern DependencyProperty CloseButtonCommandProperty { get; }

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06000B53 RID: 2899
		public static extern DependencyProperty CloseButtonCommandParameterProperty { get; }

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06000B54 RID: 2900
		public static extern DependencyProperty PlacementMarginProperty { get; }

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06000B55 RID: 2901
		public static extern DependencyProperty ShouldConstrainToRootBoundsProperty { get; }

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06000B56 RID: 2902
		public static extern DependencyProperty IsLightDismissEnabledProperty { get; }

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06000B57 RID: 2903
		public static extern DependencyProperty PreferredPlacementProperty { get; }

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06000B58 RID: 2904
		public static extern DependencyProperty HeroContentPlacementProperty { get; }

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06000B59 RID: 2905
		public static extern DependencyProperty HeroContentProperty { get; }

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06000B5A RID: 2906
		public static extern DependencyProperty IconSourceProperty { get; }

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06000B5B RID: 2907
		public static extern DependencyProperty TemplateSettingsProperty { get; }
	}
}
