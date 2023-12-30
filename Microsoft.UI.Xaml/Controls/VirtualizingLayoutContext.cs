using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000231 RID: 561
	[MarshalingBehavior(2)]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Threading(3)]
	[Composable(typeof(IVirtualizingLayoutContextFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	public class VirtualizingLayoutContext : LayoutContext, IVirtualizingLayoutContext, IVirtualizingLayoutContextOverrides
	{
		// Token: 0x06000C22 RID: 3106
		public extern VirtualizingLayoutContext();

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x06000C23 RID: 3107
		public extern int ItemCount { get; }

		// Token: 0x06000C24 RID: 3108
		public extern object GetItemAt([In] int index);

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x06000C25 RID: 3109
		public extern Rect RealizationRect { get; }

		// Token: 0x06000C26 RID: 3110
		[Overload("GetOrCreateElementAt")]
		public extern UIElement GetOrCreateElementAt([In] int index);

		// Token: 0x06000C27 RID: 3111
		[Overload("GetOrCreateElementAt2")]
		public extern UIElement GetOrCreateElementAt([In] int index, [In] ElementRealizationOptions options);

		// Token: 0x06000C28 RID: 3112
		public extern void RecycleElement([In] UIElement element);

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06000C29 RID: 3113
		public extern int RecommendedAnchorIndex { get; }

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06000C2A RID: 3114
		// (set) Token: 0x06000C2B RID: 3115
		public extern Point LayoutOrigin
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000C2C RID: 3116
		protected virtual extern int ItemCountCore();

		// Token: 0x06000C2D RID: 3117
		protected virtual extern object GetItemAtCore([In] int index);

		// Token: 0x06000C2E RID: 3118
		protected virtual extern Rect RealizationRectCore();

		// Token: 0x06000C2F RID: 3119
		protected virtual extern UIElement GetOrCreateElementAtCore([In] int index, [In] ElementRealizationOptions options);

		// Token: 0x06000C30 RID: 3120
		protected virtual extern void RecycleElementCore([In] UIElement element);

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x06000C31 RID: 3121
		protected virtual extern int RecommendedAnchorIndexCore { get; }

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06000C32 RID: 3122
		// (set) Token: 0x06000C33 RID: 3123
		protected virtual extern Point LayoutOriginCore
		{
			get; [param: In]
			set;
		}
	}
}
