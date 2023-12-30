using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(2246952325u, 5249, 21623, 187, 18, 42, 24, 163, 43, 131, 78)]
	[MUXPropertyChangedCallback(enable = true)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ExclusiveTo(typeof(TwoPaneView))]
	internal interface ITwoPaneView
	{
		UIElement Pane1
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		UIElement Pane2
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "c_pane1LengthDefault")]
		[MUXPropertyDefaultValue(value = "c_pane1LengthDefault")]
		GridLength Pane1Length
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "c_pane1LengthDefault")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "c_pane1LengthDefault")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "c_pane2LengthDefault")]
		[MUXPropertyDefaultValue(value = "c_pane2LengthDefault")]
		GridLength Pane2Length
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "c_pane2LengthDefault")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "c_pane2LengthDefault")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewPriority::Pane1")]
		[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewPriority::Pane1")]
		TwoPaneViewPriority PanePriority
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewPriority::Pane1")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewPriority::Pane1")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewMode::SinglePane")]
		[MUXPropertyChangedCallback(enable = false)]
		TwoPaneViewMode Mode
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewMode::SinglePane")]
			[MUXPropertyChangedCallback(enable = false)]
			get;
		}

		[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewWideModeConfiguration::LeftRight")]
		[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewWideModeConfiguration::LeftRight")]
		TwoPaneViewWideModeConfiguration WideModeConfiguration
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewWideModeConfiguration::LeftRight")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewWideModeConfiguration::LeftRight")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewTallModeConfiguration::TopBottom")]
		[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewTallModeConfiguration::TopBottom")]
		TwoPaneViewTallModeConfiguration TallModeConfiguration
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewTallModeConfiguration::TopBottom")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewTallModeConfiguration::TopBottom")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "c_defaultMinWideModeWidth")]
		[MUXPropertyDefaultValue(value = "c_defaultMinWideModeWidth")]
		double MinWideModeWidth
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "c_defaultMinWideModeWidth")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "c_defaultMinWideModeWidth")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "c_defaultMinTallModeHeight")]
		[MUXPropertyDefaultValue(value = "c_defaultMinTallModeHeight")]
		double MinTallModeHeight
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "c_defaultMinTallModeHeight")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "c_defaultMinTallModeHeight")]
			[param: In]
			set;
		}

		event TypedEventHandler<TwoPaneView, object> ModeChanged;
	}
}
