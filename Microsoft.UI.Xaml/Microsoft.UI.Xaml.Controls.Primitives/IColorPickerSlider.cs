using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Windows.Foundation.Metadata.Guid(1164063163u, 23116, 22091, 155, 61, 47, 21, 112, 97, 160, 248)]
	[ExclusiveTo(typeof(ColorPickerSlider))]
	[WebHostHidden]
	internal interface IColorPickerSlider
	{
		[MUXPropertyDefaultValue(value = "winrt::ColorPickerHsvChannel::Value")]
		[MUXPropertyDefaultValue(value = "winrt::ColorPickerHsvChannel::Value")]
		ColorPickerHsvChannel ColorChannel
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::ColorPickerHsvChannel::Value")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::ColorPickerHsvChannel::Value")]
			[param: In]
			set;
		}
	}
}
