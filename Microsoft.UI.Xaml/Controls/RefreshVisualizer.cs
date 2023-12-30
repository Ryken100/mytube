using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020001FB RID: 507
	[MUXPropertyChangedCallback(enable = true)]
	[Composable(typeof(IRefreshVisualizerFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[Threading(3)]
	[WebHostHidden]
	[MarshalingBehavior(2)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Static(typeof(IRefreshVisualizerStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	public class RefreshVisualizer : Control, IRefreshVisualizer
	{
		// Token: 0x06000A45 RID: 2629
		public extern RefreshVisualizer();

		// Token: 0x06000A46 RID: 2630
		public extern void RequestRefresh();

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06000A47 RID: 2631
		// (set) Token: 0x06000A48 RID: 2632
		[MUXPropertyDefaultValue(value = "winrt::RefreshVisualizerOrientation::Auto")]
		[MUXPropertyDefaultValue(value = "winrt::RefreshVisualizerOrientation::Auto")]
		public extern RefreshVisualizerOrientation Orientation
		{
			[MUXPropertyDefaultValue(value = "winrt::RefreshVisualizerOrientation::Auto")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::RefreshVisualizerOrientation::Auto")]
			[param: In]
			set;
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06000A49 RID: 2633
		// (set) Token: 0x06000A4A RID: 2634
		public extern UIElement Content
		{
			get; [param: In]
			set;
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06000A4B RID: 2635
		[MUXPropertyDefaultValue(value = "winrt::RefreshVisualizerState::Idle")]
		public extern RefreshVisualizerState State
		{
			[MUXPropertyDefaultValue(value = "winrt::RefreshVisualizerState::Idle")]
			get;
		}

		// Token: 0x14000054 RID: 84
		// (add) Token: 0x06000A4C RID: 2636
		// (remove) Token: 0x06000A4D RID: 2637
		public extern event TypedEventHandler<RefreshVisualizer, RefreshRequestedEventArgs> RefreshRequested;

		// Token: 0x14000055 RID: 85
		// (add) Token: 0x06000A4E RID: 2638
		// (remove) Token: 0x06000A4F RID: 2639
		public extern event TypedEventHandler<RefreshVisualizer, RefreshStateChangedEventArgs> RefreshStateChanged;

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06000A50 RID: 2640
		[MUXPropertyType(value = "winrt::IInspectable")]
		public static extern DependencyProperty InfoProviderProperty
		{
			[MUXPropertyType(value = "winrt::IInspectable")]
			get;
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06000A51 RID: 2641
		public static extern DependencyProperty OrientationProperty { get; }

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06000A52 RID: 2642
		public static extern DependencyProperty ContentProperty { get; }

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06000A53 RID: 2643
		public static extern DependencyProperty StateProperty { get; }
	}
}
