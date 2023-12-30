using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;

namespace Microsoft.UI.Xaml.Media
{
	// Token: 0x0200023B RID: 571
	[MarshalingBehavior(2)]
	[MUXHasCustomActivationFactory]
	[Static(typeof(IAcrylicBrushStatics2), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[Static(typeof(IAcrylicBrushStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Threading(3)]
	[WebHostHidden]
	[Composable(typeof(IAcrylicBrushFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MUXPropertyChangedCallback(enable = true)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	public class AcrylicBrush : XamlCompositionBrushBase, IAcrylicBrush, IAcrylicBrush2
	{
		// Token: 0x06000C40 RID: 3136
		public extern AcrylicBrush();

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06000C41 RID: 3137
		// (set) Token: 0x06000C42 RID: 3138
		[MUXPropertyDefaultValue(value = "winrt::AcrylicBackgroundSource::Backdrop")]
		[MUXPropertyDefaultValue(value = "winrt::AcrylicBackgroundSource::Backdrop")]
		public extern AcrylicBackgroundSource BackgroundSource
		{
			[MUXPropertyDefaultValue(value = "winrt::AcrylicBackgroundSource::Backdrop")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::AcrylicBackgroundSource::Backdrop")]
			[param: In]
			set;
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x06000C43 RID: 3139
		// (set) Token: 0x06000C44 RID: 3140
		[MUXPropertyDefaultValue(value = "AcrylicBrush::sc_defaultTintColor")]
		[MUXPropertyDefaultValue(value = "AcrylicBrush::sc_defaultTintColor")]
		public extern Color TintColor
		{
			[MUXPropertyDefaultValue(value = "AcrylicBrush::sc_defaultTintColor")]
			get;
			[MUXPropertyDefaultValue(value = "AcrylicBrush::sc_defaultTintColor")]
			[param: In]
			set;
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06000C45 RID: 3141
		// (set) Token: 0x06000C46 RID: 3142
		[MUXPropertyValidationCallback(value = "CoerceToZeroOneRange")]
		[MUXPropertyValidationCallback(value = "CoerceToZeroOneRange")]
		[MUXPropertyDefaultValue(value = "AcrylicBrush::sc_defaultTintOpacity")]
		[MUXPropertyDefaultValue(value = "AcrylicBrush::sc_defaultTintOpacity")]
		public extern double TintOpacity
		{
			[MUXPropertyDefaultValue(value = "AcrylicBrush::sc_defaultTintOpacity")]
			[MUXPropertyValidationCallback(value = "CoerceToZeroOneRange")]
			get;
			[MUXPropertyDefaultValue(value = "AcrylicBrush::sc_defaultTintOpacity")]
			[MUXPropertyValidationCallback(value = "CoerceToZeroOneRange")]
			[param: In]
			set;
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06000C47 RID: 3143
		// (set) Token: 0x06000C48 RID: 3144
		[MUXPropertyDefaultValue(value = "AcrylicBrush::sc_defaultTintTransitionDuration")]
		[MUXPropertyDefaultValue(value = "AcrylicBrush::sc_defaultTintTransitionDuration")]
		public extern TimeSpan TintTransitionDuration
		{
			[MUXPropertyDefaultValue(value = "AcrylicBrush::sc_defaultTintTransitionDuration")]
			get;
			[MUXPropertyDefaultValue(value = "AcrylicBrush::sc_defaultTintTransitionDuration")]
			[param: In]
			set;
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x06000C49 RID: 3145
		// (set) Token: 0x06000C4A RID: 3146
		public extern bool AlwaysUseFallback
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x06000C4B RID: 3147
		// (set) Token: 0x06000C4C RID: 3148
		[MUXPropertyValidationCallback(value = "CoerceToZeroOneRange_Nullable")]
		[MUXPropertyValidationCallback(value = "CoerceToZeroOneRange_Nullable")]
		public extern IReference<double> TintLuminosityOpacity
		{
			[MUXPropertyValidationCallback(value = "CoerceToZeroOneRange_Nullable")]
			get;
			[MUXPropertyValidationCallback(value = "CoerceToZeroOneRange_Nullable")]
			[param: In]
			set;
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x06000C4D RID: 3149
		public static extern DependencyProperty TintLuminosityOpacityProperty { get; }

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x06000C4E RID: 3150
		public static extern DependencyProperty BackgroundSourceProperty { get; }

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x06000C4F RID: 3151
		public static extern DependencyProperty TintColorProperty { get; }

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06000C50 RID: 3152
		public static extern DependencyProperty TintOpacityProperty { get; }

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x06000C51 RID: 3153
		public static extern DependencyProperty TintTransitionDurationProperty { get; }

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x06000C52 RID: 3154
		public static extern DependencyProperty AlwaysUseFallbackProperty { get; }
	}
}
