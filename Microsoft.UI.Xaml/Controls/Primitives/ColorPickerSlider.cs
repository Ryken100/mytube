using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	// Token: 0x020001B8 RID: 440
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Threading(3)]
	[Static(typeof(IColorPickerSliderStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[WebHostHidden]
	[MarshalingBehavior(2)]
	[Composable(typeof(IColorPickerSliderFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	public class ColorPickerSlider : Slider, IColorPickerSlider
	{
		// Token: 0x060008AF RID: 2223
		public extern ColorPickerSlider();

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x060008B0 RID: 2224
		// (set) Token: 0x060008B1 RID: 2225
		[MUXPropertyDefaultValue(value = "winrt::ColorPickerHsvChannel::Value")]
		[MUXPropertyDefaultValue(value = "winrt::ColorPickerHsvChannel::Value")]
		public extern ColorPickerHsvChannel ColorChannel
		{
			[MUXPropertyDefaultValue(value = "winrt::ColorPickerHsvChannel::Value")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::ColorPickerHsvChannel::Value")]
			[param: In]
			set;
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x060008B2 RID: 2226
		public static extern DependencyProperty ColorChannelProperty { get; }
	}
}
