using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000065 RID: 101
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Composable(typeof(IColorPickerFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[Threading(3)]
	[WebHostHidden]
	[MUXPropertyChangedCallback(enable = true)]
	[Static(typeof(IColorPickerStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(2)]
	public class ColorPicker : Control, IColorPicker
	{
		// Token: 0x060000CC RID: 204
		public extern ColorPicker();

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000CD RID: 205
		// (set) Token: 0x060000CE RID: 206
		[MUXPropertyDefaultValue(value = "{ 255, 255, 255, 255 }")]
		[MUXPropertyDefaultValue(value = "{ 255, 255, 255, 255 }")]
		public extern Color Color
		{
			[MUXPropertyDefaultValue(value = "{ 255, 255, 255, 255 }")]
			get;
			[MUXPropertyDefaultValue(value = "{ 255, 255, 255, 255 }")]
			[param: In]
			set;
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000CF RID: 207
		// (set) Token: 0x060000D0 RID: 208
		public extern IReference<Color> PreviousColor
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000D1 RID: 209
		// (set) Token: 0x060000D2 RID: 210
		public extern bool IsAlphaEnabled
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000D3 RID: 211
		// (set) Token: 0x060000D4 RID: 212
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		public extern bool IsColorSpectrumVisible
		{
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000D5 RID: 213
		// (set) Token: 0x060000D6 RID: 214
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		public extern bool IsColorPreviewVisible
		{
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000D7 RID: 215
		// (set) Token: 0x060000D8 RID: 216
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		public extern bool IsColorSliderVisible
		{
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000D9 RID: 217
		// (set) Token: 0x060000DA RID: 218
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		public extern bool IsAlphaSliderVisible
		{
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000DB RID: 219
		// (set) Token: 0x060000DC RID: 220
		public extern bool IsMoreButtonVisible
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000DD RID: 221
		// (set) Token: 0x060000DE RID: 222
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		public extern bool IsColorChannelTextInputVisible
		{
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000DF RID: 223
		// (set) Token: 0x060000E0 RID: 224
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		public extern bool IsAlphaTextInputVisible
		{
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000E1 RID: 225
		// (set) Token: 0x060000E2 RID: 226
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		public extern bool IsHexInputVisible
		{
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000E3 RID: 227
		// (set) Token: 0x060000E4 RID: 228
		[MUXPropertyDefaultValue(value = "0")]
		[MUXPropertyDefaultValue(value = "0")]
		public extern int MinHue
		{
			[MUXPropertyDefaultValue(value = "0")]
			get;
			[MUXPropertyDefaultValue(value = "0")]
			[param: In]
			set;
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000E5 RID: 229
		// (set) Token: 0x060000E6 RID: 230
		[MUXPropertyDefaultValue(value = "359")]
		[MUXPropertyDefaultValue(value = "359")]
		public extern int MaxHue
		{
			[MUXPropertyDefaultValue(value = "359")]
			get;
			[MUXPropertyDefaultValue(value = "359")]
			[param: In]
			set;
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000E7 RID: 231
		// (set) Token: 0x060000E8 RID: 232
		[MUXPropertyDefaultValue(value = "0")]
		[MUXPropertyDefaultValue(value = "0")]
		public extern int MinSaturation
		{
			[MUXPropertyDefaultValue(value = "0")]
			get;
			[MUXPropertyDefaultValue(value = "0")]
			[param: In]
			set;
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000E9 RID: 233
		// (set) Token: 0x060000EA RID: 234
		[MUXPropertyDefaultValue(value = "100")]
		[MUXPropertyDefaultValue(value = "100")]
		public extern int MaxSaturation
		{
			[MUXPropertyDefaultValue(value = "100")]
			get;
			[MUXPropertyDefaultValue(value = "100")]
			[param: In]
			set;
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000EB RID: 235
		// (set) Token: 0x060000EC RID: 236
		[MUXPropertyDefaultValue(value = "0")]
		[MUXPropertyDefaultValue(value = "0")]
		public extern int MinValue
		{
			[MUXPropertyDefaultValue(value = "0")]
			get;
			[MUXPropertyDefaultValue(value = "0")]
			[param: In]
			set;
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000ED RID: 237
		// (set) Token: 0x060000EE RID: 238
		[MUXPropertyDefaultValue(value = "100")]
		[MUXPropertyDefaultValue(value = "100")]
		public extern int MaxValue
		{
			[MUXPropertyDefaultValue(value = "100")]
			get;
			[MUXPropertyDefaultValue(value = "100")]
			[param: In]
			set;
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000EF RID: 239
		// (set) Token: 0x060000F0 RID: 240
		[MUXPropertyDefaultValue(value = "winrt::ColorSpectrumShape::Box")]
		[MUXPropertyDefaultValue(value = "winrt::ColorSpectrumShape::Box")]
		public extern ColorSpectrumShape ColorSpectrumShape
		{
			[MUXPropertyDefaultValue(value = "winrt::ColorSpectrumShape::Box")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::ColorSpectrumShape::Box")]
			[param: In]
			set;
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000F1 RID: 241
		// (set) Token: 0x060000F2 RID: 242
		[MUXPropertyDefaultValue(value = "winrt::ColorSpectrumComponents::HueSaturation")]
		[MUXPropertyDefaultValue(value = "winrt::ColorSpectrumComponents::HueSaturation")]
		public extern ColorSpectrumComponents ColorSpectrumComponents
		{
			[MUXPropertyDefaultValue(value = "winrt::ColorSpectrumComponents::HueSaturation")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::ColorSpectrumComponents::HueSaturation")]
			[param: In]
			set;
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060000F3 RID: 243
		// (remove) Token: 0x060000F4 RID: 244
		public extern event TypedEventHandler<ColorPicker, ColorChangedEventArgs> ColorChanged;

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000F5 RID: 245
		public static extern DependencyProperty ColorProperty { get; }

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060000F6 RID: 246
		public static extern DependencyProperty PreviousColorProperty { get; }

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000F7 RID: 247
		public static extern DependencyProperty IsAlphaEnabledProperty { get; }

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060000F8 RID: 248
		public static extern DependencyProperty IsColorSpectrumVisibleProperty { get; }

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000F9 RID: 249
		public static extern DependencyProperty IsColorPreviewVisibleProperty { get; }

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000FA RID: 250
		public static extern DependencyProperty IsColorSliderVisibleProperty { get; }

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000FB RID: 251
		public static extern DependencyProperty IsAlphaSliderVisibleProperty { get; }

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060000FC RID: 252
		public static extern DependencyProperty IsMoreButtonVisibleProperty { get; }

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000FD RID: 253
		public static extern DependencyProperty IsColorChannelTextInputVisibleProperty { get; }

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000FE RID: 254
		public static extern DependencyProperty IsAlphaTextInputVisibleProperty { get; }

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060000FF RID: 255
		public static extern DependencyProperty IsHexInputVisibleProperty { get; }

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000100 RID: 256
		public static extern DependencyProperty MinHueProperty { get; }

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000101 RID: 257
		public static extern DependencyProperty MaxHueProperty { get; }

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000102 RID: 258
		public static extern DependencyProperty MinSaturationProperty { get; }

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000103 RID: 259
		public static extern DependencyProperty MaxSaturationProperty { get; }

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000104 RID: 260
		public static extern DependencyProperty MinValueProperty { get; }

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000105 RID: 261
		public static extern DependencyProperty MaxValueProperty { get; }

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000106 RID: 262
		public static extern DependencyProperty ColorSpectrumShapeProperty { get; }

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000107 RID: 263
		public static extern DependencyProperty ColorSpectrumComponentsProperty { get; }
	}
}
