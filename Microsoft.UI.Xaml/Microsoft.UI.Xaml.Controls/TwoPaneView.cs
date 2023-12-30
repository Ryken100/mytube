using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[MUXPropertyChangedCallback(enable = true)]
	[Threading(ThreadingModel.Both)]
	[Composable(typeof(ITwoPaneViewFactory), CompositionType.Public, 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[Static(typeof(ITwoPaneViewStatics), 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(MarshalingType.Agile)]
	public class TwoPaneView : Control, ITwoPaneView
	{
		[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewWideModeConfiguration::LeftRight")]
		[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewWideModeConfiguration::LeftRight")]
		public extern TwoPaneViewWideModeConfiguration WideModeConfiguration
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
		public extern TwoPaneViewTallModeConfiguration TallModeConfiguration
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewTallModeConfiguration::TopBottom")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewTallModeConfiguration::TopBottom")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewPriority::Pane1")]
		[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewPriority::Pane1")]
		public extern TwoPaneViewPriority PanePriority
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewPriority::Pane1")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewPriority::Pane1")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "c_pane2LengthDefault")]
		[MUXPropertyDefaultValue(value = "c_pane2LengthDefault")]
		public extern GridLength Pane2Length
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "c_pane2LengthDefault")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "c_pane2LengthDefault")]
			[param: In]
			set;
		}

		public extern UIElement Pane2
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "c_pane1LengthDefault")]
		[MUXPropertyDefaultValue(value = "c_pane1LengthDefault")]
		public extern GridLength Pane1Length
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "c_pane1LengthDefault")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "c_pane1LengthDefault")]
			[param: In]
			set;
		}

		public extern UIElement Pane1
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "c_defaultMinWideModeWidth")]
		[MUXPropertyDefaultValue(value = "c_defaultMinWideModeWidth")]
		public extern double MinWideModeWidth
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
		public extern double MinTallModeHeight
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "c_defaultMinTallModeHeight")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "c_defaultMinTallModeHeight")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewMode::SinglePane")]
		[MUXPropertyChangedCallback(enable = false)]
		public extern TwoPaneViewMode Mode
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::TwoPaneViewMode::SinglePane")]
			[MUXPropertyChangedCallback(enable = false)]
			get;
		}

		public static extern DependencyProperty MinTallModeHeightProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty MinWideModeWidthProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty ModeProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty Pane1LengthProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty Pane1Property
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty Pane2LengthProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty Pane2Property
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty PanePriorityProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty TallModeConfigurationProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty WideModeConfigurationProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[method: In]
		public extern event TypedEventHandler<TwoPaneView, object> ModeChanged;
	}
}
