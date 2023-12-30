using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000201 RID: 513
	[MarshalingBehavior(2)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[Threading(3)]
	[Composable(typeof(IVirtualizingLayoutFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	public class VirtualizingLayout : Layout, IVirtualizingLayout, IVirtualizingLayoutOverrides
	{
		// Token: 0x06000A61 RID: 2657
		public extern VirtualizingLayout();

		// Token: 0x06000A62 RID: 2658
		protected virtual extern void InitializeForContextCore([In] VirtualizingLayoutContext context);

		// Token: 0x06000A63 RID: 2659
		protected virtual extern void UninitializeForContextCore([In] VirtualizingLayoutContext context);

		// Token: 0x06000A64 RID: 2660
		protected virtual extern Size MeasureOverride([In] VirtualizingLayoutContext context, [In] Size availableSize);

		// Token: 0x06000A65 RID: 2661
		protected virtual extern Size ArrangeOverride([In] VirtualizingLayoutContext context, [In] Size finalSize);

		// Token: 0x06000A66 RID: 2662
		protected virtual extern void OnItemsChangedCore([In] VirtualizingLayoutContext context, [In] object source, [In] NotifyCollectionChangedEventArgs args);
	}
}
