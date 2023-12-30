using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	[ComImport]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[MUXPropertyChangedCallback(enable = true)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ExclusiveTo(typeof(ColorSpectrum))]
	[Windows.Foundation.Metadata.Guid(1966102806u, 34861, 22119, 191, 208, 10, 247, 45, 80, 45, 114)]
	internal interface IColorSpectrum
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

		[MUXPropertyDefaultValue(value = "{ 0, 0, 1, 1 }")]
		[MUXPropertyDefaultValue(value = "{ 0, 0, 1, 1 }")]
		Vector4 HsvColor
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "{ 0, 0, 1, 1 }")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "{ 0, 0, 1, 1 }")]
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
		ColorSpectrumShape Shape
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
		ColorSpectrumComponents Components
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::ColorSpectrumComponents::HueSaturation")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::ColorSpectrumComponents::HueSaturation")]
			[param: In]
			set;
		}

		event TypedEventHandler<ColorSpectrum, ColorChangedEventArgs> ColorChanged;
	}
}
