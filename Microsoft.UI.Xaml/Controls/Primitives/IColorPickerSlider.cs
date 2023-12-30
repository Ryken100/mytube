using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	// Token: 0x020001C5 RID: 453
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(1164063163U, 23116, 22091, 155, 61, 47, 21, 112, 97, 160, 248)]
	[ExclusiveTo(typeof(ColorPickerSlider))]
	[WebHostHidden]
	internal interface IColorPickerSlider
	{
		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x0600090F RID: 2319
		// (set) Token: 0x06000910 RID: 2320
		[MUXPropertyDefaultValue(value = "winrt::ColorPickerHsvChannel::Value")]
		[MUXPropertyDefaultValue(value = "winrt::ColorPickerHsvChannel::Value")]
		ColorPickerHsvChannel ColorChannel
		{
			[MUXPropertyDefaultValue(value = "winrt::ColorPickerHsvChannel::Value")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::ColorPickerHsvChannel::Value")]
			[param: In]
			set;
		}
	}
}
