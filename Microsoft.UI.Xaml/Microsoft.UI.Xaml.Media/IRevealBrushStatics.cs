using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Media
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(184477236u, 13555, 20725, 165, 9, 33, 206, 242, 102, 118, 126)]
	[ExclusiveTo(typeof(RevealBrush))]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[MUXPropertyChangedCallback(enable = true)]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface IRevealBrushStatics
	{
		DependencyProperty ColorProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		DependencyProperty TargetThemeProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		DependencyProperty AlwaysUseFallbackProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MUXPropertyChangedCallbackMethodName(value = "OnStatePropertyChanged")]
		[MUXPropertyDefaultValue(value = "winrt::RevealBrushState::Normal")]
		DependencyProperty StateProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyChangedCallbackMethodName(value = "OnStatePropertyChanged")]
			[MUXPropertyDefaultValue(value = "winrt::RevealBrushState::Normal")]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetState([In] UIElement element, [In] RevealBrushState value);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		RevealBrushState GetState([In] UIElement element);
	}
}
