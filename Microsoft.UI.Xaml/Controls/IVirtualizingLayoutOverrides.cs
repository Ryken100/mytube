using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200017D RID: 381
	[Guid(3650711326U, 25278, 20830, 132, 61, 8, 53, 6, 223, 62, 125)]
	[ExclusiveTo(typeof(VirtualizingLayout))]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface IVirtualizingLayoutOverrides
	{
		// Token: 0x06000699 RID: 1689
		void InitializeForContextCore([In] VirtualizingLayoutContext context);

		// Token: 0x0600069A RID: 1690
		void UninitializeForContextCore([In] VirtualizingLayoutContext context);

		// Token: 0x0600069B RID: 1691
		Size MeasureOverride([In] VirtualizingLayoutContext context, [In] Size availableSize);

		// Token: 0x0600069C RID: 1692
		Size ArrangeOverride([In] VirtualizingLayoutContext context, [In] Size finalSize);

		// Token: 0x0600069D RID: 1693
		void OnItemsChangedCore([In] VirtualizingLayoutContext context, [In] object source, [In] NotifyCollectionChangedEventArgs args);
	}
}
