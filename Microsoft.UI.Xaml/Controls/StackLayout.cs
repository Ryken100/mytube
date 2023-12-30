using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000202 RID: 514
	[Static(typeof(IStackLayoutStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[MUXPropertyChangedCallback(enable = true)]
	[Threading(3)]
	[MarshalingBehavior(2)]
	[Composable(typeof(IStackLayoutFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	public class StackLayout : VirtualizingLayout, IStackLayout
	{
		// Token: 0x06000A67 RID: 2663
		public extern StackLayout();

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06000A68 RID: 2664
		// (set) Token: 0x06000A69 RID: 2665
		[MUXPropertyDefaultValue(value = "winrt::Orientation::Vertical")]
		[MUXPropertyDefaultValue(value = "winrt::Orientation::Vertical")]
		public extern Orientation Orientation
		{
			[MUXPropertyDefaultValue(value = "winrt::Orientation::Vertical")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::Orientation::Vertical")]
			[param: In]
			set;
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06000A6A RID: 2666
		// (set) Token: 0x06000A6B RID: 2667
		[MUXPropertyDefaultValue(value = "0.0")]
		[MUXPropertyDefaultValue(value = "0.0")]
		public extern double Spacing
		{
			[MUXPropertyDefaultValue(value = "0.0")]
			get;
			[MUXPropertyDefaultValue(value = "0.0")]
			[param: In]
			set;
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06000A6C RID: 2668
		public static extern DependencyProperty OrientationProperty { get; }

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06000A6D RID: 2669
		public static extern DependencyProperty SpacingProperty { get; }
	}
}
