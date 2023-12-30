using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020001F4 RID: 500
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[Static(typeof(IRatingItemFontInfoStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[Composable(typeof(IRatingItemFontInfoFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(2)]
	[Threading(3)]
	public class RatingItemFontInfo : RatingItemInfo, IRatingItemFontInfo
	{
		// Token: 0x06000A11 RID: 2577
		public extern RatingItemFontInfo();

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06000A12 RID: 2578
		// (set) Token: 0x06000A13 RID: 2579
		public extern string DisabledGlyph
		{
			get; [param: In]
			set;
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06000A14 RID: 2580
		// (set) Token: 0x06000A15 RID: 2581
		public extern string Glyph
		{
			get; [param: In]
			set;
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06000A16 RID: 2582
		// (set) Token: 0x06000A17 RID: 2583
		public extern string PointerOverGlyph
		{
			get; [param: In]
			set;
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06000A18 RID: 2584
		// (set) Token: 0x06000A19 RID: 2585
		public extern string PointerOverPlaceholderGlyph
		{
			get; [param: In]
			set;
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06000A1A RID: 2586
		// (set) Token: 0x06000A1B RID: 2587
		public extern string PlaceholderGlyph
		{
			get; [param: In]
			set;
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06000A1C RID: 2588
		// (set) Token: 0x06000A1D RID: 2589
		public extern string UnsetGlyph
		{
			get; [param: In]
			set;
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06000A1E RID: 2590
		public static extern DependencyProperty DisabledGlyphProperty { get; }

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06000A1F RID: 2591
		public static extern DependencyProperty GlyphProperty { get; }

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06000A20 RID: 2592
		public static extern DependencyProperty PlaceholderGlyphProperty { get; }

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06000A21 RID: 2593
		public static extern DependencyProperty PointerOverGlyphProperty { get; }

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06000A22 RID: 2594
		public static extern DependencyProperty PointerOverPlaceholderGlyphProperty { get; }

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06000A23 RID: 2595
		public static extern DependencyProperty UnsetGlyphProperty { get; }
	}
}
