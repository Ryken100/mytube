using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020001F5 RID: 501
	[Threading(3)]
	[Static(typeof(IRatingItemImageInfoStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(2)]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Composable(typeof(IRatingItemImageInfoFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	public class RatingItemImageInfo : RatingItemInfo, IRatingItemImageInfo
	{
		// Token: 0x06000A24 RID: 2596
		public extern RatingItemImageInfo();

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06000A25 RID: 2597
		// (set) Token: 0x06000A26 RID: 2598
		public extern ImageSource DisabledImage
		{
			get; [param: In]
			set;
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06000A27 RID: 2599
		// (set) Token: 0x06000A28 RID: 2600
		public extern ImageSource Image
		{
			get; [param: In]
			set;
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06000A29 RID: 2601
		// (set) Token: 0x06000A2A RID: 2602
		public extern ImageSource PlaceholderImage
		{
			get; [param: In]
			set;
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06000A2B RID: 2603
		// (set) Token: 0x06000A2C RID: 2604
		public extern ImageSource PointerOverImage
		{
			get; [param: In]
			set;
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06000A2D RID: 2605
		// (set) Token: 0x06000A2E RID: 2606
		public extern ImageSource PointerOverPlaceholderImage
		{
			get; [param: In]
			set;
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06000A2F RID: 2607
		// (set) Token: 0x06000A30 RID: 2608
		public extern ImageSource UnsetImage
		{
			get; [param: In]
			set;
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06000A31 RID: 2609
		public static extern DependencyProperty DisabledImageProperty { get; }

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06000A32 RID: 2610
		public static extern DependencyProperty ImageProperty { get; }

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06000A33 RID: 2611
		public static extern DependencyProperty PlaceholderImageProperty { get; }

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06000A34 RID: 2612
		public static extern DependencyProperty PointerOverImageProperty { get; }

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06000A35 RID: 2613
		public static extern DependencyProperty PointerOverPlaceholderImageProperty { get; }

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06000A36 RID: 2614
		public static extern DependencyProperty UnsetImageProperty { get; }
	}
}
