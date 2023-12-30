using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200018F RID: 399
	[MarshalingBehavior(2)]
	[WebHostHidden]
	[Composable(typeof(IItemsSourceViewFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[Threading(3)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	public class ItemsSourceView : IItemsSourceView, INotifyCollectionChanged
	{
		// Token: 0x0600070D RID: 1805
		public extern ItemsSourceView([In] object source);

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x0600070E RID: 1806
		public extern int Count { get; }

		// Token: 0x0600070F RID: 1807
		public extern object GetAt([In] int index);

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000710 RID: 1808
		public extern bool HasKeyIndexMapping { get; }

		// Token: 0x06000711 RID: 1809
		public extern string KeyFromIndex([In] int index);

		// Token: 0x06000712 RID: 1810
		public extern int IndexFromKey([In] string key);

		// Token: 0x06000713 RID: 1811
		public extern int IndexOf([In] object item);

		// Token: 0x14000040 RID: 64
		// (add) Token: 0x06000714 RID: 1812
		// (remove) Token: 0x06000715 RID: 1813
		public extern event NotifyCollectionChangedEventHandler CollectionChanged;
	}
}
