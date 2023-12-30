using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020001F2 RID: 498
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[MUXPropertyChangedCallback(enable = true)]
	[Composable(typeof(IRatingControlFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[Static(typeof(IRatingControlStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MarshalingBehavior(2)]
	[WebHostHidden]
	[Threading(3)]
	public class RatingControl : Control, IRatingControl
	{
		// Token: 0x060009F5 RID: 2549
		public extern RatingControl();

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x060009F6 RID: 2550
		// (set) Token: 0x060009F7 RID: 2551
		public extern string Caption
		{
			get; [param: In]
			set;
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x060009F8 RID: 2552
		// (set) Token: 0x060009F9 RID: 2553
		[MUXPropertyDefaultValue(value = "1")]
		[MUXPropertyDefaultValue(value = "1")]
		public extern int InitialSetValue
		{
			[MUXPropertyDefaultValue(value = "1")]
			get;
			[MUXPropertyDefaultValue(value = "1")]
			[param: In]
			set;
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x060009FA RID: 2554
		// (set) Token: 0x060009FB RID: 2555
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		public extern bool IsClearEnabled
		{
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x060009FC RID: 2556
		// (set) Token: 0x060009FD RID: 2557
		public extern bool IsReadOnly
		{
			get; [param: In]
			set;
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x060009FE RID: 2558
		// (set) Token: 0x060009FF RID: 2559
		[MUXPropertyDefaultValue(value = "5")]
		[MUXPropertyDefaultValue(value = "5")]
		public extern int MaxRating
		{
			[MUXPropertyDefaultValue(value = "5")]
			get;
			[MUXPropertyDefaultValue(value = "5")]
			[param: In]
			set;
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06000A00 RID: 2560
		// (set) Token: 0x06000A01 RID: 2561
		[MUXPropertyDefaultValue(value = "-1")]
		[MUXPropertyDefaultValue(value = "-1")]
		public extern double PlaceholderValue
		{
			[MUXPropertyDefaultValue(value = "-1")]
			get;
			[MUXPropertyDefaultValue(value = "-1")]
			[param: In]
			set;
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06000A02 RID: 2562
		// (set) Token: 0x06000A03 RID: 2563
		public extern RatingItemInfo ItemInfo
		{
			get; [param: In]
			set;
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06000A04 RID: 2564
		// (set) Token: 0x06000A05 RID: 2565
		[MUXPropertyDefaultValue(value = "-1")]
		[MUXPropertyDefaultValue(value = "-1")]
		public extern double Value
		{
			[MUXPropertyDefaultValue(value = "-1")]
			get;
			[MUXPropertyDefaultValue(value = "-1")]
			[param: In]
			set;
		}

		// Token: 0x14000052 RID: 82
		// (add) Token: 0x06000A06 RID: 2566
		// (remove) Token: 0x06000A07 RID: 2567
		public extern event TypedEventHandler<RatingControl, object> ValueChanged;

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06000A08 RID: 2568
		public static extern DependencyProperty CaptionProperty { get; }

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06000A09 RID: 2569
		public static extern DependencyProperty InitialSetValueProperty { get; }

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06000A0A RID: 2570
		public static extern DependencyProperty IsClearEnabledProperty { get; }

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06000A0B RID: 2571
		public static extern DependencyProperty IsReadOnlyProperty { get; }

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06000A0C RID: 2572
		public static extern DependencyProperty MaxRatingProperty { get; }

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06000A0D RID: 2573
		public static extern DependencyProperty PlaceholderValueProperty { get; }

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06000A0E RID: 2574
		public static extern DependencyProperty ItemInfoProperty { get; }

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06000A0F RID: 2575
		public static extern DependencyProperty ValueProperty { get; }
	}
}
