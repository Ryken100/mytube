using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Microsoft.UI.Xaml.Media
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(646323329u, 29428, 20581, 177, 68, 233, 236, 127, 206, 134, 169)]
	[MUXPropertyChangedCallback(enable = true)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[ExclusiveTo(typeof(AcrylicBrush))]
	[WebHostHidden]
	internal interface IAcrylicBrush
	{
		[MUXPropertyDefaultValue(value = "winrt::AcrylicBackgroundSource::Backdrop")]
		[MUXPropertyDefaultValue(value = "winrt::AcrylicBackgroundSource::Backdrop")]
		AcrylicBackgroundSource BackgroundSource
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::AcrylicBackgroundSource::Backdrop")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::AcrylicBackgroundSource::Backdrop")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "AcrylicBrush::sc_defaultTintColor")]
		[MUXPropertyDefaultValue(value = "AcrylicBrush::sc_defaultTintColor")]
		Color TintColor
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "AcrylicBrush::sc_defaultTintColor")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "AcrylicBrush::sc_defaultTintColor")]
			[param: In]
			set;
		}

		[MUXPropertyValidationCallback(value = "CoerceToZeroOneRange")]
		[MUXPropertyValidationCallback(value = "CoerceToZeroOneRange")]
		[MUXPropertyDefaultValue(value = "AcrylicBrush::sc_defaultTintOpacity")]
		[MUXPropertyDefaultValue(value = "AcrylicBrush::sc_defaultTintOpacity")]
		double TintOpacity
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "AcrylicBrush::sc_defaultTintOpacity")]
			[MUXPropertyValidationCallback(value = "CoerceToZeroOneRange")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyValidationCallback(value = "CoerceToZeroOneRange")]
			[MUXPropertyDefaultValue(value = "AcrylicBrush::sc_defaultTintOpacity")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "AcrylicBrush::sc_defaultTintTransitionDuration")]
		[MUXPropertyDefaultValue(value = "AcrylicBrush::sc_defaultTintTransitionDuration")]
		TimeSpan TintTransitionDuration
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "AcrylicBrush::sc_defaultTintTransitionDuration")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "AcrylicBrush::sc_defaultTintTransitionDuration")]
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
