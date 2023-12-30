using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000BF RID: 191
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(618990620U, 40017, 20804, 157, 220, 63, 80, 1, 145, 194, 98)]
	[WebHostHidden]
	[ExclusiveTo(typeof(Layout))]
	internal interface ILayout
	{
		// Token: 0x06000288 RID: 648
		void InitializeForContext([In] LayoutContext context);

		// Token: 0x06000289 RID: 649
		void UninitializeForContext([In] LayoutContext context);

		// Token: 0x0600028A RID: 650
		Size Measure([In] LayoutContext context, [In] Size availableSize);

		// Token: 0x0600028B RID: 651
		Size Arrange([In] LayoutContext context, [In] Size finalSize);

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x0600028C RID: 652
		// (remove) Token: 0x0600028D RID: 653
		event TypedEventHandler<Layout, object> MeasureInvalidated;

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x0600028E RID: 654
		// (remove) Token: 0x0600028F RID: 655
		event TypedEventHandler<Layout, object> ArrangeInvalidated;
	}
}
