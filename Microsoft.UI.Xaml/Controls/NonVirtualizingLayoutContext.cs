using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020001A9 RID: 425
	[Composable(typeof(INonVirtualizingLayoutContextFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(2)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[Threading(3)]
	public class NonVirtualizingLayoutContext : LayoutContext, INonVirtualizingLayoutContext, INonVirtualizingLayoutContextOverrides
	{
		// Token: 0x060007F5 RID: 2037
		public extern NonVirtualizingLayoutContext();

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x060007F6 RID: 2038
		public extern IVectorView<UIElement> Children { get; }

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x060007F7 RID: 2039
		protected virtual extern IVectorView<UIElement> ChildrenCore { get; }
	}
}
