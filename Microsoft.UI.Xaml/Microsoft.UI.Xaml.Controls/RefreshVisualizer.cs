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
	[MUXPropertyChangedCallback(enable = true)]
	[Composable(typeof(IRefreshVisualizerFactory), CompositionType.Public, 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[Threading(ThreadingModel.Both)]
	[WebHostHidden]
	[MarshalingBehavior(MarshalingType.Agile)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Static(typeof(IRefreshVisualizerStatics), 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[ContractVersion(typeof(XamlContract), 65536u)]
	public class RefreshVisualizer : Control, IRefreshVisualizer
	{
		[MUXPropertyDefaultValue(value = "winrt::RefreshVisualizerOrientation::Auto")]
		[MUXPropertyDefaultValue(value = "winrt::RefreshVisualizerOrientation::Auto")]
		public extern RefreshVisualizerOrientation Orientation
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::RefreshVisualizerOrientation::Auto")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::RefreshVisualizerOrientation::Auto")]
			[param: In]
			set;
		}

		public extern UIElement Content
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "winrt::RefreshVisualizerState::Idle")]
		public extern RefreshVisualizerState State
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::RefreshVisualizerState::Idle")]
			get;
		}

		public static extern DependencyProperty ContentProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MUXPropertyType(value = "winrt::IInspectable")]
		public static extern DependencyProperty InfoProviderProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyType(value = "winrt::IInspectable")]
			get;
		}

		public static extern DependencyProperty OrientationProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty StateProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[method: In]
		public extern event TypedEventHandler<RefreshVisualizer, RefreshRequestedEventArgs> RefreshRequested;

		[method: In]
		public extern event TypedEventHandler<RefreshVisualizer, RefreshStateChangedEventArgs> RefreshStateChanged;

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void RequestRefresh();
	}
}
