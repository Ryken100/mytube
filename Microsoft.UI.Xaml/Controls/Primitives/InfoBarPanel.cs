using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	// Token: 0x020001E6 RID: 486
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MarshalingBehavior(2)]
	[Static(typeof(IInfoBarPanelStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[Threading(3)]
	[WebHostHidden]
	[Composable(typeof(IInfoBarPanelFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	public class InfoBarPanel : Panel, IInfoBarPanel
	{
		// Token: 0x06000986 RID: 2438
		public extern InfoBarPanel();

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06000987 RID: 2439
		// (set) Token: 0x06000988 RID: 2440
		public extern Thickness HorizontalOrientationPadding
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06000989 RID: 2441
		// (set) Token: 0x0600098A RID: 2442
		public extern Thickness VerticalOrientationPadding
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x0600098B RID: 2443
		public static extern DependencyProperty HorizontalOrientationPaddingProperty { get; }

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x0600098C RID: 2444
		public static extern DependencyProperty VerticalOrientationPaddingProperty { get; }

		// Token: 0x0600098D RID: 2445
		public static extern void SetHorizontalOrientationMargin([In] DependencyObject @object, [In] Thickness value);

		// Token: 0x0600098E RID: 2446
		public static extern Thickness GetHorizontalOrientationMargin([In] DependencyObject @object);

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x0600098F RID: 2447
		public static extern DependencyProperty HorizontalOrientationMarginProperty { get; }

		// Token: 0x06000990 RID: 2448
		public static extern void SetVerticalOrientationMargin([In] DependencyObject @object, [In] Thickness value);

		// Token: 0x06000991 RID: 2449
		public static extern Thickness GetVerticalOrientationMargin([In] DependencyObject @object);

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06000992 RID: 2450
		public static extern DependencyProperty VerticalOrientationMarginProperty { get; }
	}
}
