using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000190 RID: 400
	[Threading(3)]
	[MarshalingBehavior(2)]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Composable(typeof(ILayoutFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	public class Layout : DependencyObject, ILayout, ILayoutProtected
	{
		// Token: 0x06000716 RID: 1814
		public extern void InitializeForContext([In] LayoutContext context);

		// Token: 0x06000717 RID: 1815
		public extern void UninitializeForContext([In] LayoutContext context);

		// Token: 0x06000718 RID: 1816
		public extern Size Measure([In] LayoutContext context, [In] Size availableSize);

		// Token: 0x06000719 RID: 1817
		public extern Size Arrange([In] LayoutContext context, [In] Size finalSize);

		// Token: 0x14000042 RID: 66
		// (add) Token: 0x0600071A RID: 1818
		// (remove) Token: 0x0600071B RID: 1819
		public extern event TypedEventHandler<Layout, object> MeasureInvalidated;

		// Token: 0x14000041 RID: 65
		// (add) Token: 0x0600071C RID: 1820
		// (remove) Token: 0x0600071D RID: 1821
		public extern event TypedEventHandler<Layout, object> ArrangeInvalidated;

		// Token: 0x0600071E RID: 1822
		protected extern void InvalidateMeasure();

		// Token: 0x0600071F RID: 1823
		protected extern void InvalidateArrange();
	}
}
