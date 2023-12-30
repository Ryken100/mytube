using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Markup;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020001AF RID: 431
	[Composable(typeof(IParallaxViewFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[ContentProperty(Name = "Child")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Threading(3)]
	[MUXPropertyChangedCallback(enable = true)]
	[WebHostHidden]
	[MarshalingBehavior(2)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Static(typeof(IParallaxViewStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	public class ParallaxView : FrameworkElement, IParallaxView
	{
		// Token: 0x06000836 RID: 2102
		public extern ParallaxView();

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06000837 RID: 2103
		// (set) Token: 0x06000838 RID: 2104
		public extern UIElement Child
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06000839 RID: 2105
		// (set) Token: 0x0600083A RID: 2106
		public extern double HorizontalShift
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x0600083B RID: 2107
		// (set) Token: 0x0600083C RID: 2108
		public extern double HorizontalSourceEndOffset
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x0600083D RID: 2109
		// (set) Token: 0x0600083E RID: 2110
		[MUXPropertyDefaultValue(value = "winrt::ParallaxSourceOffsetKind::Relative")]
		[MUXPropertyDefaultValue(value = "winrt::ParallaxSourceOffsetKind::Relative")]
		public extern ParallaxSourceOffsetKind HorizontalSourceOffsetKind
		{
			[MUXPropertyDefaultValue(value = "winrt::ParallaxSourceOffsetKind::Relative")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::ParallaxSourceOffsetKind::Relative")]
			[param: In]
			set;
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x0600083F RID: 2111
		// (set) Token: 0x06000840 RID: 2112
		public extern double HorizontalSourceStartOffset
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06000841 RID: 2113
		// (set) Token: 0x06000842 RID: 2114
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		public extern bool IsHorizontalShiftClamped
		{
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06000843 RID: 2115
		// (set) Token: 0x06000844 RID: 2116
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		public extern bool IsVerticalShiftClamped
		{
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06000845 RID: 2117
		// (set) Token: 0x06000846 RID: 2118
		[MUXPropertyDefaultValue(value = "1.0")]
		[MUXPropertyDefaultValue(value = "1.0")]
		public extern double MaxHorizontalShiftRatio
		{
			[MUXPropertyDefaultValue(value = "1.0")]
			get;
			[MUXPropertyDefaultValue(value = "1.0")]
			[param: In]
			set;
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06000847 RID: 2119
		// (set) Token: 0x06000848 RID: 2120
		[MUXPropertyDefaultValue(value = "1.0")]
		[MUXPropertyDefaultValue(value = "1.0")]
		public extern double MaxVerticalShiftRatio
		{
			[MUXPropertyDefaultValue(value = "1.0")]
			get;
			[MUXPropertyDefaultValue(value = "1.0")]
			[param: In]
			set;
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06000849 RID: 2121
		// (set) Token: 0x0600084A RID: 2122
		public extern UIElement Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x0600084B RID: 2123
		// (set) Token: 0x0600084C RID: 2124
		public extern double VerticalShift
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x0600084D RID: 2125
		// (set) Token: 0x0600084E RID: 2126
		public extern double VerticalSourceEndOffset
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x0600084F RID: 2127
		// (set) Token: 0x06000850 RID: 2128
		[MUXPropertyDefaultValue(value = "winrt::ParallaxSourceOffsetKind::Relative")]
		[MUXPropertyDefaultValue(value = "winrt::ParallaxSourceOffsetKind::Relative")]
		public extern ParallaxSourceOffsetKind VerticalSourceOffsetKind
		{
			[MUXPropertyDefaultValue(value = "winrt::ParallaxSourceOffsetKind::Relative")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::ParallaxSourceOffsetKind::Relative")]
			[param: In]
			set;
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06000851 RID: 2129
		// (set) Token: 0x06000852 RID: 2130
		public extern double VerticalSourceStartOffset
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000853 RID: 2131
		public extern void RefreshAutomaticHorizontalOffsets();

		// Token: 0x06000854 RID: 2132
		public extern void RefreshAutomaticVerticalOffsets();

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06000855 RID: 2133
		public static extern DependencyProperty ChildProperty { get; }

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06000856 RID: 2134
		public static extern DependencyProperty HorizontalSourceEndOffsetProperty { get; }

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06000857 RID: 2135
		public static extern DependencyProperty HorizontalSourceOffsetKindProperty { get; }

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06000858 RID: 2136
		public static extern DependencyProperty HorizontalSourceStartOffsetProperty { get; }

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06000859 RID: 2137
		public static extern DependencyProperty MaxHorizontalShiftRatioProperty { get; }

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x0600085A RID: 2138
		public static extern DependencyProperty HorizontalShiftProperty { get; }

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x0600085B RID: 2139
		public static extern DependencyProperty IsHorizontalShiftClampedProperty { get; }

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x0600085C RID: 2140
		public static extern DependencyProperty IsVerticalShiftClampedProperty { get; }

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x0600085D RID: 2141
		public static extern DependencyProperty SourceProperty { get; }

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x0600085E RID: 2142
		public static extern DependencyProperty VerticalSourceEndOffsetProperty { get; }

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x0600085F RID: 2143
		public static extern DependencyProperty VerticalSourceOffsetKindProperty { get; }

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06000860 RID: 2144
		public static extern DependencyProperty VerticalSourceStartOffsetProperty { get; }

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06000861 RID: 2145
		public static extern DependencyProperty MaxVerticalShiftRatioProperty { get; }

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06000862 RID: 2146
		public static extern DependencyProperty VerticalShiftProperty { get; }
	}
}
