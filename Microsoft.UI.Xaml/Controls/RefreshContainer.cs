using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020001F6 RID: 502
	[Threading(3)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[MarshalingBehavior(2)]
	[Composable(typeof(IRefreshContainerFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MUXPropertyChangedCallback(enable = true)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Static(typeof(IRefreshContainerStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[WebHostHidden]
	public class RefreshContainer : ContentControl, IRefreshContainer
	{
		// Token: 0x06000A37 RID: 2615
		public extern RefreshContainer();

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06000A38 RID: 2616
		// (set) Token: 0x06000A39 RID: 2617
		public extern RefreshVisualizer Visualizer
		{
			get; [param: In]
			set;
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06000A3A RID: 2618
		// (set) Token: 0x06000A3B RID: 2619
		[MUXPropertyDefaultValue(value = "winrt::RefreshPullDirection::TopToBottom")]
		[MUXPropertyDefaultValue(value = "winrt::RefreshPullDirection::TopToBottom")]
		public extern RefreshPullDirection PullDirection
		{
			[MUXPropertyDefaultValue(value = "winrt::RefreshPullDirection::TopToBottom")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::RefreshPullDirection::TopToBottom")]
			[param: In]
			set;
		}

		// Token: 0x14000053 RID: 83
		// (add) Token: 0x06000A3C RID: 2620
		// (remove) Token: 0x06000A3D RID: 2621
		public extern event TypedEventHandler<RefreshContainer, RefreshRequestedEventArgs> RefreshRequested;

		// Token: 0x06000A3E RID: 2622
		public extern void RequestRefresh();

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06000A3F RID: 2623
		public static extern DependencyProperty VisualizerProperty { get; }

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06000A40 RID: 2624
		public static extern DependencyProperty PullDirectionProperty { get; }
	}
}
