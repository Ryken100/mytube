using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020001A8 RID: 424
	[WebHostHidden]
	[Composable(typeof(INonVirtualizingLayoutFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[Threading(3)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MarshalingBehavior(2)]
	public class NonVirtualizingLayout : Layout, INonVirtualizingLayout, INonVirtualizingLayoutOverrides
	{
		// Token: 0x060007F0 RID: 2032
		public extern NonVirtualizingLayout();

		// Token: 0x060007F1 RID: 2033
		protected virtual extern void InitializeForContextCore([In] NonVirtualizingLayoutContext context);

		// Token: 0x060007F2 RID: 2034
		protected virtual extern void UninitializeForContextCore([In] NonVirtualizingLayoutContext context);

		// Token: 0x060007F3 RID: 2035
		protected virtual extern Size MeasureOverride([In] NonVirtualizingLayoutContext context, [In] Size availableSize);

		// Token: 0x060007F4 RID: 2036
		protected virtual extern Size ArrangeOverride([In] NonVirtualizingLayoutContext context, [In] Size finalSize);
	}
}
