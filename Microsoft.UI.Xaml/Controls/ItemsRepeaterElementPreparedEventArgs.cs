using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200018D RID: 397
	[WebHostHidden]
	[MarshalingBehavior(2)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	public sealed class ItemsRepeaterElementPreparedEventArgs : IItemsRepeaterElementPreparedEventArgs
	{
		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000703 RID: 1795
		public extern UIElement Element { get; }

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000704 RID: 1796
		public extern int Index { get; }
	}
}
