using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Windows.Foundation.Metadata.Guid(479688936u, 42023, 24454, 157, 94, 2, 219, 155, 44, 64, 147)]
	[MUXPropertyChangedCallback(enable = true)]
	[ExclusiveTo(typeof(RefreshContainer))]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	internal interface IRefreshContainer
	{
		RefreshVisualizer Visualizer
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "winrt::RefreshPullDirection::TopToBottom")]
		[MUXPropertyDefaultValue(value = "winrt::RefreshPullDirection::TopToBottom")]
		RefreshPullDirection PullDirection
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::RefreshPullDirection::TopToBottom")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::RefreshPullDirection::TopToBottom")]
			[param: In]
			set;
		}

		event TypedEventHandler<RefreshContainer, RefreshRequestedEventArgs> RefreshRequested;

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void RequestRefresh();
	}
}
