using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000205 RID: 517
	[WebHostHidden]
	[MarshalingBehavior(2)]
	[Threading(3)]
	[Composable(typeof(ISwipeItemFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Static(typeof(ISwipeItemStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MUXPropertyChangedCallback(enable = true)]
	public class SwipeItem : DependencyObject, ISwipeItem
	{
		// Token: 0x06000A7C RID: 2684
		public extern SwipeItem();

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06000A7D RID: 2685
		// (set) Token: 0x06000A7E RID: 2686
		public extern string Text
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06000A7F RID: 2687
		// (set) Token: 0x06000A80 RID: 2688
		public extern IconSource IconSource
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06000A81 RID: 2689
		// (set) Token: 0x06000A82 RID: 2690
		public extern Brush Background
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06000A83 RID: 2691
		// (set) Token: 0x06000A84 RID: 2692
		public extern Brush Foreground
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06000A85 RID: 2693
		// (set) Token: 0x06000A86 RID: 2694
		public extern ICommand Command
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06000A87 RID: 2695
		// (set) Token: 0x06000A88 RID: 2696
		public extern object CommandParameter
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06000A89 RID: 2697
		// (set) Token: 0x06000A8A RID: 2698
		[MUXPropertyDefaultValue(value = "winrt::SwipeBehaviorOnInvoked::Auto")]
		[MUXPropertyDefaultValue(value = "winrt::SwipeBehaviorOnInvoked::Auto")]
		public extern SwipeBehaviorOnInvoked BehaviorOnInvoked
		{
			[MUXPropertyDefaultValue(value = "winrt::SwipeBehaviorOnInvoked::Auto")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::SwipeBehaviorOnInvoked::Auto")]
			[param: In]
			set;
		}

		// Token: 0x14000057 RID: 87
		// (add) Token: 0x06000A8B RID: 2699
		// (remove) Token: 0x06000A8C RID: 2700
		public extern event TypedEventHandler<SwipeItem, SwipeItemInvokedEventArgs> Invoked;

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06000A8D RID: 2701
		public static extern DependencyProperty IconSourceProperty { get; }

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06000A8E RID: 2702
		public static extern DependencyProperty TextProperty { get; }

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06000A8F RID: 2703
		public static extern DependencyProperty BackgroundProperty { get; }

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06000A90 RID: 2704
		public static extern DependencyProperty ForegroundProperty { get; }

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06000A91 RID: 2705
		public static extern DependencyProperty CommandProperty { get; }

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06000A92 RID: 2706
		public static extern DependencyProperty CommandParameterProperty { get; }

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06000A93 RID: 2707
		public static extern DependencyProperty BehaviorOnInvokedProperty { get; }
	}
}
