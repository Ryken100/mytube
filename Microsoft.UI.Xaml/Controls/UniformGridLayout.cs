using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200022E RID: 558
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[MUXPropertyChangedCallback(enable = true)]
	[MarshalingBehavior(2)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Static(typeof(IUniformGridLayoutStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[Composable(typeof(IUniformGridLayoutFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[Threading(3)]
	public class UniformGridLayout : VirtualizingLayout, IUniformGridLayout
	{
		// Token: 0x06000C09 RID: 3081
		public extern UniformGridLayout();

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06000C0A RID: 3082
		// (set) Token: 0x06000C0B RID: 3083
		[MUXPropertyDefaultValue(value = "winrt::Orientation::Horizontal")]
		[MUXPropertyDefaultValue(value = "winrt::Orientation::Horizontal")]
		public extern Orientation Orientation
		{
			[MUXPropertyDefaultValue(value = "winrt::Orientation::Horizontal")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::Orientation::Horizontal")]
			[param: In]
			set;
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x06000C0C RID: 3084
		// (set) Token: 0x06000C0D RID: 3085
		[MUXPropertyDefaultValue(value = "0.0")]
		[MUXPropertyDefaultValue(value = "0.0")]
		public extern double MinItemWidth
		{
			[MUXPropertyDefaultValue(value = "0.0")]
			get;
			[MUXPropertyDefaultValue(value = "0.0")]
			[param: In]
			set;
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06000C0E RID: 3086
		// (set) Token: 0x06000C0F RID: 3087
		[MUXPropertyDefaultValue(value = "0.0")]
		[MUXPropertyDefaultValue(value = "0.0")]
		public extern double MinItemHeight
		{
			[MUXPropertyDefaultValue(value = "0.0")]
			get;
			[MUXPropertyDefaultValue(value = "0.0")]
			[param: In]
			set;
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x06000C10 RID: 3088
		// (set) Token: 0x06000C11 RID: 3089
		[MUXPropertyDefaultValue(value = "0.0")]
		[MUXPropertyDefaultValue(value = "0.0")]
		public extern double MinRowSpacing
		{
			[MUXPropertyDefaultValue(value = "0.0")]
			get;
			[MUXPropertyDefaultValue(value = "0.0")]
			[param: In]
			set;
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06000C12 RID: 3090
		// (set) Token: 0x06000C13 RID: 3091
		[MUXPropertyDefaultValue(value = "0.0")]
		[MUXPropertyDefaultValue(value = "0.0")]
		public extern double MinColumnSpacing
		{
			[MUXPropertyDefaultValue(value = "0.0")]
			get;
			[MUXPropertyDefaultValue(value = "0.0")]
			[param: In]
			set;
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06000C14 RID: 3092
		// (set) Token: 0x06000C15 RID: 3093
		[MUXPropertyDefaultValue(value = "winrt::UniformGridLayoutItemsJustification::Start")]
		[MUXPropertyDefaultValue(value = "winrt::UniformGridLayoutItemsJustification::Start")]
		public extern UniformGridLayoutItemsJustification ItemsJustification
		{
			[MUXPropertyDefaultValue(value = "winrt::UniformGridLayoutItemsJustification::Start")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::UniformGridLayoutItemsJustification::Start")]
			[param: In]
			set;
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x06000C16 RID: 3094
		// (set) Token: 0x06000C17 RID: 3095
		[MUXPropertyDefaultValue(value = "winrt::UniformGridLayoutItemsStretch::None")]
		[MUXPropertyDefaultValue(value = "winrt::UniformGridLayoutItemsStretch::None")]
		public extern UniformGridLayoutItemsStretch ItemsStretch
		{
			[MUXPropertyDefaultValue(value = "winrt::UniformGridLayoutItemsStretch::None")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::UniformGridLayoutItemsStretch::None")]
			[param: In]
			set;
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x06000C18 RID: 3096
		// (set) Token: 0x06000C19 RID: 3097
		[MUXPropertyDefaultValue(value = "-1")]
		[MUXPropertyDefaultValue(value = "-1")]
		public extern int MaximumRowsOrColumns
		{
			[MUXPropertyDefaultValue(value = "-1")]
			get;
			[MUXPropertyDefaultValue(value = "-1")]
			[param: In]
			set;
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06000C1A RID: 3098
		public static extern DependencyProperty OrientationProperty { get; }

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x06000C1B RID: 3099
		public static extern DependencyProperty MinItemWidthProperty { get; }

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06000C1C RID: 3100
		public static extern DependencyProperty MinItemHeightProperty { get; }

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x06000C1D RID: 3101
		public static extern DependencyProperty MinRowSpacingProperty { get; }

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06000C1E RID: 3102
		public static extern DependencyProperty MinColumnSpacingProperty { get; }

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06000C1F RID: 3103
		public static extern DependencyProperty ItemsJustificationProperty { get; }

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x06000C20 RID: 3104
		public static extern DependencyProperty ItemsStretchProperty { get; }

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x06000C21 RID: 3105
		public static extern DependencyProperty MaximumRowsOrColumnsProperty { get; }
	}
}
