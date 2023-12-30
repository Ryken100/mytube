using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(2684399569u, 54012, 21393, 180, 33, 238, 92, 151, 90, 201, 69)]
	[ExclusiveTo(typeof(RefreshVisualizer))]
	[WebHostHidden]
	[MUXPropertyChangedCallback(enable = true)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	internal interface IRefreshVisualizer
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void RequestRefresh();

		[MUXPropertyDefaultValue(value = "winrt::RefreshVisualizerOrientation::Auto")]
		[MUXPropertyDefaultValue(value = "winrt::RefreshVisualizerOrientation::Auto")]
		RefreshVisualizerOrientation Orientation
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::RefreshVisualizerOrientation::Auto")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::RefreshVisualizerOrientation::Auto")]
			[param: In]
			set;
		}

		UIElement Content
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "winrt::RefreshVisualizerState::Idle")]
		RefreshVisualizerState State
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::RefreshVisualizerState::Idle")]
			get;
		}

		event TypedEventHandler<RefreshVisualizer, RefreshRequestedEventArgs> RefreshRequested;

		event TypedEventHandler<RefreshVisualizer, RefreshStateChangedEventArgs> RefreshStateChanged;
	}
}
