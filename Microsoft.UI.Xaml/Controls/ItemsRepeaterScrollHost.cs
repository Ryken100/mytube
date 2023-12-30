using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Markup;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200018E RID: 398
	[Threading(3)]
	[MarshalingBehavior(2)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[Activatable(65536U, "Microsoft.UI.Xaml.XamlContract")]
	[ContentProperty(Name = "ScrollViewer")]
	public sealed class ItemsRepeaterScrollHost : FrameworkElement, IItemsRepeaterScrollHost
	{
		// Token: 0x06000705 RID: 1797
		public extern ItemsRepeaterScrollHost();

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000706 RID: 1798
		// (set) Token: 0x06000707 RID: 1799
		public extern ScrollViewer ScrollViewer
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000708 RID: 1800
		public extern UIElement CurrentAnchor { get; }

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000709 RID: 1801
		// (set) Token: 0x0600070A RID: 1802
		public extern double HorizontalAnchorRatio
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x0600070B RID: 1803
		// (set) Token: 0x0600070C RID: 1804
		public extern double VerticalAnchorRatio
		{
			get; [param: In]
			set;
		}
	}
}
