using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000124 RID: 292
	[Guid(2684399569U, 54012, 21393, 180, 33, 238, 92, 151, 90, 201, 69)]
	[ExclusiveTo(typeof(RefreshVisualizer))]
	[WebHostHidden]
	[MUXPropertyChangedCallback(enable = true)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	internal interface IRefreshVisualizer
	{
		// Token: 0x060004BC RID: 1212
		void RequestRefresh();

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x060004BD RID: 1213
		// (set) Token: 0x060004BE RID: 1214
		[MUXPropertyDefaultValue(value = "winrt::RefreshVisualizerOrientation::Auto")]
		[MUXPropertyDefaultValue(value = "winrt::RefreshVisualizerOrientation::Auto")]
		RefreshVisualizerOrientation Orientation
		{
			[MUXPropertyDefaultValue(value = "winrt::RefreshVisualizerOrientation::Auto")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::RefreshVisualizerOrientation::Auto")]
			[param: In]
			set;
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x060004BF RID: 1215
		// (set) Token: 0x060004C0 RID: 1216
		UIElement Content
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x060004C1 RID: 1217
		[MUXPropertyDefaultValue(value = "winrt::RefreshVisualizerState::Idle")]
		RefreshVisualizerState State
		{
			[MUXPropertyDefaultValue(value = "winrt::RefreshVisualizerState::Idle")]
			get;
		}

		// Token: 0x14000021 RID: 33
		// (add) Token: 0x060004C2 RID: 1218
		// (remove) Token: 0x060004C3 RID: 1219
		event TypedEventHandler<RefreshVisualizer, RefreshRequestedEventArgs> RefreshRequested;

		// Token: 0x14000022 RID: 34
		// (add) Token: 0x060004C4 RID: 1220
		// (remove) Token: 0x060004C5 RID: 1221
		event TypedEventHandler<RefreshVisualizer, RefreshStateChangedEventArgs> RefreshStateChanged;
	}
}
