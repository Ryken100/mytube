using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000204 RID: 516
	[Composable(typeof(ISwipeControlFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Static(typeof(ISwipeControlStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(2)]
	[Threading(3)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[MUXPropertyChangedCallback(enable = true)]
	public class SwipeControl : ContentControl, ISwipeControl
	{
		// Token: 0x06000A6E RID: 2670
		public extern SwipeControl();

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06000A6F RID: 2671
		// (set) Token: 0x06000A70 RID: 2672
		public extern SwipeItems LeftItems
		{
			get; [param: In]
			set;
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06000A71 RID: 2673
		// (set) Token: 0x06000A72 RID: 2674
		public extern SwipeItems RightItems
		{
			get; [param: In]
			set;
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06000A73 RID: 2675
		// (set) Token: 0x06000A74 RID: 2676
		public extern SwipeItems TopItems
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06000A75 RID: 2677
		// (set) Token: 0x06000A76 RID: 2678
		public extern SwipeItems BottomItems
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000A77 RID: 2679
		public extern void Close();

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06000A78 RID: 2680
		public static extern DependencyProperty LeftItemsProperty { get; }

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06000A79 RID: 2681
		public static extern DependencyProperty RightItemsProperty { get; }

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06000A7A RID: 2682
		public static extern DependencyProperty TopItemsProperty { get; }

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06000A7B RID: 2683
		public static extern DependencyProperty BottomItemsProperty { get; }
	}
}
