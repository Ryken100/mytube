using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;

namespace Microsoft.UI.Xaml.Media
{
	[ComImport]
	[MarshalingBehavior(MarshalingType.Agile)]
	[MUXHasCustomActivationFactory]
	[Static(typeof(IAcrylicBrushStatics2), 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[Static(typeof(IAcrylicBrushStatics), 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Threading(ThreadingModel.Both)]
	[WebHostHidden]
	[Composable(typeof(IAcrylicBrushFactory), CompositionType.Public, 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[MUXPropertyChangedCallback(enable = true)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	public class AcrylicBrush : XamlCompositionBrushBase, IAcrylicBrush, IAcrylicBrush2
	{
		[MUXPropertyDefaultValue(value = "AcrylicBrush::sc_defaultTintTransitionDuration")]
		[MUXPropertyDefaultValue(value = "AcrylicBrush::sc_defaultTintTransitionDuration")]
		public extern TimeSpan TintTransitionDuration
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "AcrylicBrush::sc_defaultTintTransitionDuration")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "AcrylicBrush::sc_defaultTintTransitionDuration")]
			[param: In]
			set;
		}

		[MUXPropertyValidationCallback(value = "CoerceToZeroOneRange")]
		[MUXPropertyValidationCallback(value = "CoerceToZeroOneRange")]
		[MUXPropertyDefaultValue(value = "AcrylicBrush::sc_defaultTintOpacity")]
		[MUXPropertyDefaultValue(value = "AcrylicBrush::sc_defaultTintOpacity")]
		public extern double TintOpacity
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "AcrylicBrush::sc_defaultTintOpacity")]
			[MUXPropertyValidationCallback(value = "CoerceToZeroOneRange")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "AcrylicBrush::sc_defaultTintOpacity")]
			[MUXPropertyValidationCallback(value = "CoerceToZeroOneRange")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "AcrylicBrush::sc_defaultTintColor")]
		[MUXPropertyDefaultValue(value = "AcrylicBrush::sc_defaultTintColor")]
		public extern Color TintColor
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "AcrylicBrush::sc_defaultTintColor")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "AcrylicBrush::sc_defaultTintColor")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "winrt::AcrylicBackgroundSource::Backdrop")]
		[MUXPropertyDefaultValue(value = "winrt::AcrylicBackgroundSource::Backdrop")]
		public extern AcrylicBackgroundSource BackgroundSource
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::AcrylicBackgroundSource::Backdrop")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::AcrylicBackgroundSource::Backdrop")]
			[param: In]
			set;
		}

		public extern bool AlwaysUseFallback
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		[MUXPropertyValidationCallback(value = "CoerceToZeroOneRange_Nullable")]
		[MUXPropertyValidationCallback(value = "CoerceToZeroOneRange_Nullable")]
		public extern double? TintLuminosityOpacity
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyValidationCallback(value = "CoerceToZeroOneRange_Nullable")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyValidationCallback(value = "CoerceToZeroOneRange_Nullable")]
			[param: In]
			set;
		}

		public static extern DependencyProperty AlwaysUseFallbackProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty BackgroundSourceProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty TintColorProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty TintOpacityProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty TintTransitionDurationProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty TintLuminosityOpacityProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
