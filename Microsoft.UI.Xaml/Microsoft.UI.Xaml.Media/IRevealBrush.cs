using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Media
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(2635979654u, 44538, 23470, 191, 154, 62, 221, 3, 30, 97, 194)]
	[WebHostHidden]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[ExclusiveTo(typeof(RevealBrush))]
	[MUXPropertyChangedCallback(enable = true)]
	internal interface IRevealBrush
	{
		[MUXPropertyDefaultValue(value = "RevealBrush::sc_defaultColor")]
		[MUXPropertyDefaultValue(value = "RevealBrush::sc_defaultColor")]
		Color Color
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "RevealBrush::sc_defaultColor")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "RevealBrush::sc_defaultColor")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "winrt::ApplicationTheme::Light")]
		[MUXPropertyDefaultValue(value = "winrt::ApplicationTheme::Light")]
		ApplicationTheme TargetTheme
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::ApplicationTheme::Light")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::ApplicationTheme::Light")]
			[param: In]
			set;
		}

		bool AlwaysUseFallback
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}
	}
}
