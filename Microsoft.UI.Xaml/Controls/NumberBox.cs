using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Globalization.NumberFormatting;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Media;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020001AA RID: 426
	[MarshalingBehavior(2)]
	[Static(typeof(INumberBoxStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[Threading(3)]
	[WebHostHidden]
	[Composable(typeof(INumberBoxFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	public class NumberBox : Control, INumberBox
	{
		// Token: 0x060007F8 RID: 2040
		public extern NumberBox();

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x060007F9 RID: 2041
		// (set) Token: 0x060007FA RID: 2042
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "-std::numeric_limits<double>::max()")]
		[MUXPropertyDefaultValue(value = "-std::numeric_limits<double>::max()")]
		[MUXPropertyChangedCallback(enable = true)]
		public extern double Minimum
		{
			[MUXPropertyDefaultValue(value = "-std::numeric_limits<double>::max()")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyDefaultValue(value = "-std::numeric_limits<double>::max()")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x060007FB RID: 2043
		// (set) Token: 0x060007FC RID: 2044
		[MUXPropertyDefaultValue(value = "std::numeric_limits<double>::max()")]
		[MUXPropertyDefaultValue(value = "std::numeric_limits<double>::max()")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		public extern double Maximum
		{
			[MUXPropertyDefaultValue(value = "std::numeric_limits<double>::max()")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyDefaultValue(value = "std::numeric_limits<double>::max()")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x060007FD RID: 2045
		// (set) Token: 0x060007FE RID: 2046
		[MUXPropertyDefaultValue(value = "std::numeric_limits<double>::quiet_NaN()")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "std::numeric_limits<double>::quiet_NaN()")]
		[MUXPropertyChangedCallback(enable = true)]
		public extern double Value
		{
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "std::numeric_limits<double>::quiet_NaN()")]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "std::numeric_limits<double>::quiet_NaN()")]
			[param: In]
			set;
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x060007FF RID: 2047
		// (set) Token: 0x06000800 RID: 2048
		[MUXPropertyDefaultValue(value = "1")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "1")]
		public extern double SmallChange
		{
			[MUXPropertyDefaultValue(value = "1")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "1")]
			[param: In]
			set;
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06000801 RID: 2049
		// (set) Token: 0x06000802 RID: 2050
		[MUXPropertyDefaultValue(value = "10")]
		[MUXPropertyDefaultValue(value = "10")]
		public extern double LargeChange
		{
			[MUXPropertyDefaultValue(value = "10")]
			get;
			[MUXPropertyDefaultValue(value = "10")]
			[param: In]
			set;
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06000803 RID: 2051
		// (set) Token: 0x06000804 RID: 2052
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		public extern string Text
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06000805 RID: 2053
		// (set) Token: 0x06000806 RID: 2054
		public extern object Header
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06000807 RID: 2055
		// (set) Token: 0x06000808 RID: 2056
		public extern DataTemplate HeaderTemplate
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06000809 RID: 2057
		// (set) Token: 0x0600080A RID: 2058
		public extern string PlaceholderText
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x0600080B RID: 2059
		// (set) Token: 0x0600080C RID: 2060
		public extern FlyoutBase SelectionFlyout
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x0600080D RID: 2061
		// (set) Token: 0x0600080E RID: 2062
		public extern SolidColorBrush SelectionHighlightColor
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x0600080F RID: 2063
		// (set) Token: 0x06000810 RID: 2064
		public extern TextReadingOrder TextReadingOrder
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06000811 RID: 2065
		// (set) Token: 0x06000812 RID: 2066
		public extern bool PreventKeyboardDisplayOnProgrammaticFocus
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06000813 RID: 2067
		// (set) Token: 0x06000814 RID: 2068
		public extern object Description
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06000815 RID: 2069
		// (set) Token: 0x06000816 RID: 2070
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		public extern NumberBoxValidationMode ValidationMode
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06000817 RID: 2071
		// (set) Token: 0x06000818 RID: 2072
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "winrt::NumberBoxSpinButtonPlacementMode::Hidden")]
		[MUXPropertyDefaultValue(value = "winrt::NumberBoxSpinButtonPlacementMode::Hidden")]
		[MUXPropertyChangedCallback(enable = true)]
		public extern NumberBoxSpinButtonPlacementMode SpinButtonPlacementMode
		{
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "winrt::NumberBoxSpinButtonPlacementMode::Hidden")]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "winrt::NumberBoxSpinButtonPlacementMode::Hidden")]
			[param: In]
			set;
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06000819 RID: 2073
		// (set) Token: 0x0600081A RID: 2074
		[MUXPropertyDefaultValue(value = "false")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "false")]
		public extern bool IsWrapEnabled
		{
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "false")]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "false")]
			[param: In]
			set;
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x0600081B RID: 2075
		// (set) Token: 0x0600081C RID: 2076
		[MUXPropertyDefaultValue(value = "false")]
		[MUXPropertyDefaultValue(value = "false")]
		public extern bool AcceptsExpression
		{
			[MUXPropertyDefaultValue(value = "false")]
			get;
			[MUXPropertyDefaultValue(value = "false")]
			[param: In]
			set;
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x0600081D RID: 2077
		// (set) Token: 0x0600081E RID: 2078
		[MUXPropertyValidationCallback(value = "ValidateNumberFormatter")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyValidationCallback(value = "ValidateNumberFormatter")]
		public extern INumberFormatter2 NumberFormatter
		{
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyValidationCallback(value = "ValidateNumberFormatter")]
			get;
			[MUXPropertyValidationCallback(value = "ValidateNumberFormatter")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x1400004D RID: 77
		// (add) Token: 0x0600081F RID: 2079
		// (remove) Token: 0x06000820 RID: 2080
		public extern event TypedEventHandler<NumberBox, NumberBoxValueChangedEventArgs> ValueChanged;

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06000821 RID: 2081
		public static extern DependencyProperty MinimumProperty { get; }

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06000822 RID: 2082
		public static extern DependencyProperty MaximumProperty { get; }

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06000823 RID: 2083
		public static extern DependencyProperty ValueProperty { get; }

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06000824 RID: 2084
		public static extern DependencyProperty SmallChangeProperty { get; }

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06000825 RID: 2085
		public static extern DependencyProperty LargeChangeProperty { get; }

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06000826 RID: 2086
		public static extern DependencyProperty TextProperty { get; }

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06000827 RID: 2087
		[MUXPropertyChangedCallback(enable = true)]
		public static extern DependencyProperty HeaderProperty
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06000828 RID: 2088
		[MUXPropertyChangedCallback(enable = true)]
		public static extern DependencyProperty HeaderTemplateProperty
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06000829 RID: 2089
		public static extern DependencyProperty PlaceholderTextProperty { get; }

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x0600082A RID: 2090
		public static extern DependencyProperty SelectionFlyoutProperty { get; }

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x0600082B RID: 2091
		public static extern DependencyProperty SelectionHighlightColorProperty { get; }

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x0600082C RID: 2092
		public static extern DependencyProperty TextReadingOrderProperty { get; }

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x0600082D RID: 2093
		public static extern DependencyProperty PreventKeyboardDisplayOnProgrammaticFocusProperty { get; }

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x0600082E RID: 2094
		public static extern DependencyProperty DescriptionProperty { get; }

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x0600082F RID: 2095
		public static extern DependencyProperty ValidationModeProperty { get; }

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06000830 RID: 2096
		public static extern DependencyProperty SpinButtonPlacementModeProperty { get; }

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06000831 RID: 2097
		public static extern DependencyProperty IsWrapEnabledProperty { get; }

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06000832 RID: 2098
		public static extern DependencyProperty AcceptsExpressionProperty { get; }

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06000833 RID: 2099
		public static extern DependencyProperty NumberFormatterProperty { get; }
	}
}
