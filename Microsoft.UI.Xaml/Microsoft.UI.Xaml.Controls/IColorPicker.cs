using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ExclusiveTo(typeof(ColorPicker))]
	[MUXPropertyChangedCallback(enable = true)]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Windows.Foundation.Metadata.Guid(2926752331u, 63807, 23065, 140, 228, 161, 139, 115, 195, 53, 109)]
	internal interface IColorPicker
	{
		[MUXPropertyDefaultValue(value = "{ 255, 255, 255, 255 }")]
		[MUXPropertyDefaultValue(value = "{ 255, 255, 255, 255 }")]
		Color Color
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "{ 255, 255, 255, 255 }")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "{ 255, 255, 255, 255 }")]
			[param: In]
			set;
		}

		Color? PreviousColor
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		bool IsAlphaEnabled
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		bool IsColorSpectrumVisible
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		bool IsColorPreviewVisible
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		bool IsColorSliderVisible
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		bool IsAlphaSliderVisible
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		bool IsMoreButtonVisible
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		bool IsColorChannelTextInputVisible
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		bool IsAlphaTextInputVisible
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		bool IsHexInputVisible
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "0")]
		[MUXPropertyDefaultValue(value = "0")]
		int MinHue
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "0")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "0")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "359")]
		[MUXPropertyDefaultValue(value = "359")]
		int MaxHue
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "359")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "359")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "0")]
		[MUXPropertyDefaultValue(value = "0")]
		int MinSaturation
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "0")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "0")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "100")]
		[MUXPropertyDefaultValue(value = "100")]
		int MaxSaturation
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "100")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "100")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "0")]
		[MUXPropertyDefaultValue(value = "0")]
		int MinValue
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "0")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "0")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "100")]
		[MUXPropertyDefaultValue(value = "100")]
		int MaxValue
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "100")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "100")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "winrt::ColorSpectrumShape::Box")]
		[MUXPropertyDefaultValue(value = "winrt::ColorSpectrumShape::Box")]
		ColorSpectrumShape ColorSpectrumShape
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::ColorSpectrumShape::Box")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::ColorSpectrumShape::Box")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "winrt::ColorSpectrumComponents::HueSaturation")]
		[MUXPropertyDefaultValue(value = "winrt::ColorSpectrumComponents::HueSaturation")]
		ColorSpectrumComponents ColorSpectrumComponents
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::ColorSpectrumComponents::HueSaturation")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::ColorSpectrumComponents::HueSaturation")]
			[param: In]
			set;
		}

		event TypedEventHandler<ColorPicker, ColorChangedEventArgs> ColorChanged;
	}
}
