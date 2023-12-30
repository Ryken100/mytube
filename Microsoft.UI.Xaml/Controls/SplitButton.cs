using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Input;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020001FF RID: 511
	[MarshalingBehavior(2)]
	[Composable(typeof(ISplitButtonFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[MUXPropertyChangedCallback(enable = true)]
	[WebHostHidden]
	[Static(typeof(ISplitButtonStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[Threading(3)]
	public class SplitButton : ContentControl, ISplitButton
	{
		// Token: 0x06000A55 RID: 2645
		public extern SplitButton();

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06000A56 RID: 2646
		// (set) Token: 0x06000A57 RID: 2647
		public extern FlyoutBase Flyout
		{
			get; [param: In]
			set;
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06000A58 RID: 2648
		// (set) Token: 0x06000A59 RID: 2649
		public extern ICommand Command
		{
			get; [param: In]
			set;
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06000A5A RID: 2650
		// (set) Token: 0x06000A5B RID: 2651
		public extern object CommandParameter
		{
			get; [param: In]
			set;
		}

		// Token: 0x14000056 RID: 86
		// (add) Token: 0x06000A5C RID: 2652
		// (remove) Token: 0x06000A5D RID: 2653
		public extern event TypedEventHandler<SplitButton, SplitButtonClickEventArgs> Click;

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06000A5E RID: 2654
		public static extern DependencyProperty FlyoutProperty { get; }

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06000A5F RID: 2655
		public static extern DependencyProperty CommandProperty { get; }

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06000A60 RID: 2656
		public static extern DependencyProperty CommandParameterProperty { get; }
	}
}
