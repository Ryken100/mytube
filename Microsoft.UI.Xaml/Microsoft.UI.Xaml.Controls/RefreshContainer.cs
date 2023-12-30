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
	[Threading(ThreadingModel.Both)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[MarshalingBehavior(MarshalingType.Agile)]
	[Composable(typeof(IRefreshContainerFactory), CompositionType.Public, 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[MUXPropertyChangedCallback(enable = true)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Static(typeof(IRefreshContainerStatics), 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[WebHostHidden]
	public class RefreshContainer : ContentControl, IRefreshContainer
	{
		public extern RefreshVisualizer Visualizer
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "winrt::RefreshPullDirection::TopToBottom")]
		[MUXPropertyDefaultValue(value = "winrt::RefreshPullDirection::TopToBottom")]
		public extern RefreshPullDirection PullDirection
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::RefreshPullDirection::TopToBottom")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::RefreshPullDirection::TopToBottom")]
			[param: In]
			set;
		}

		public static extern DependencyProperty PullDirectionProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty VisualizerProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[method: In]
		public extern event TypedEventHandler<RefreshContainer, RefreshRequestedEventArgs> RefreshRequested;

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void RequestRefresh();
	}
}
