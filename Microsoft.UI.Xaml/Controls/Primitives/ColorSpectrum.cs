using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	// Token: 0x020001B9 RID: 441
	[Threading(3)]
	[Static(typeof(IColorSpectrumStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[MUXPropertyChangedCallback(enable = true)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MarshalingBehavior(2)]
	[Composable(typeof(IColorSpectrumFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[WebHostHidden]
	public class ColorSpectrum : Control, IColorSpectrum
	{
		// Token: 0x060008B3 RID: 2227
		public extern ColorSpectrum();

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x060008B4 RID: 2228
		// (set) Token: 0x060008B5 RID: 2229
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

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x060008B6 RID: 2230
		// (set) Token: 0x060008B7 RID: 2231
		[MUXPropertyDefaultValue(value = "{ 0, 0, 1, 1 }")]
		[MUXPropertyDefaultValue(value = "{ 0, 0, 1, 1 }")]
		public extern Vector4 HsvColor
		{
			[MUXPropertyDefaultValue(value = "{ 0, 0, 1, 1 }")]
			get;
			[MUXPropertyDefaultValue(value = "{ 0, 0, 1, 1 }")]
			[param: In]
			set;
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x060008B8 RID: 2232
		// (set) Token: 0x060008B9 RID: 2233
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

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x060008BA RID: 2234
		// (set) Token: 0x060008BB RID: 2235
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

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x060008BC RID: 2236
		// (set) Token: 0x060008BD RID: 2237
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

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x060008BE RID: 2238
		// (set) Token: 0x060008BF RID: 2239
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

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x060008C0 RID: 2240
		// (set) Token: 0x060008C1 RID: 2241
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

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x060008C2 RID: 2242
		// (set) Token: 0x060008C3 RID: 2243
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

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x060008C4 RID: 2244
		// (set) Token: 0x060008C5 RID: 2245
		[MUXPropertyDefaultValue(value = "winrt::ColorSpectrumShape::Box")]
		[MUXPropertyDefaultValue(value = "winrt::ColorSpectrumShape::Box")]
		public extern ColorSpectrumShape Shape
		{
			[MUXPropertyDefaultValue(value = "winrt::ColorSpectrumShape::Box")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::ColorSpectrumShape::Box")]
			[param: In]
			set;
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x060008C6 RID: 2246
		// (set) Token: 0x060008C7 RID: 2247
		[MUXPropertyDefaultValue(value = "winrt::ColorSpectrumComponents::HueSaturation")]
		[MUXPropertyDefaultValue(value = "winrt::ColorSpectrumComponents::HueSaturation")]
		public extern ColorSpectrumComponents Components
		{
			[MUXPropertyDefaultValue(value = "winrt::ColorSpectrumComponents::HueSaturation")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::ColorSpectrumComponents::HueSaturation")]
			[param: In]
			set;
		}

		// Token: 0x1400004F RID: 79
		// (add) Token: 0x060008C8 RID: 2248
		// (remove) Token: 0x060008C9 RID: 2249
		public extern event TypedEventHandler<ColorSpectrum, ColorChangedEventArgs> ColorChanged;

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x060008CA RID: 2250
		public static extern DependencyProperty ColorProperty { get; }

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x060008CB RID: 2251
		public static extern DependencyProperty HsvColorProperty { get; }

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x060008CC RID: 2252
		public static extern DependencyProperty MinHueProperty { get; }

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x060008CD RID: 2253
		public static extern DependencyProperty MaxHueProperty { get; }

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x060008CE RID: 2254
		public static extern DependencyProperty MinSaturationProperty { get; }

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x060008CF RID: 2255
		public static extern DependencyProperty MaxSaturationProperty { get; }

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x060008D0 RID: 2256
		public static extern DependencyProperty MinValueProperty { get; }

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x060008D1 RID: 2257
		public static extern DependencyProperty MaxValueProperty { get; }

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x060008D2 RID: 2258
		public static extern DependencyProperty ShapeProperty { get; }

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x060008D3 RID: 2259
		public static extern DependencyProperty ComponentsProperty { get; }
	}
}
