using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Threading(ThreadingModel.Both)]
	[Static(typeof(IColorPickerSliderStatics), 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[WebHostHidden]
	[MarshalingBehavior(MarshalingType.Agile)]
	[Composable(typeof(IColorPickerSliderFactory), CompositionType.Public, 65536u, "Microsoft.UI.Xaml.XamlContract")]
	public class ColorPickerSlider : Slider, IColorPickerSlider
	{
		[MUXPropertyDefaultValue(value = "winrt::ColorPickerHsvChannel::Value")]
		[MUXPropertyDefaultValue(value = "winrt::ColorPickerHsvChannel::Value")]
		public extern ColorPickerHsvChannel ColorChannel
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::ColorPickerHsvChannel::Value")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::ColorPickerHsvChannel::Value")]
			[param: In]
			set;
		}

		public static extern DependencyProperty ColorChannelProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
