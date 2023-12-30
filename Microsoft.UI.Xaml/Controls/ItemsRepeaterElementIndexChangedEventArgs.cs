using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200018C RID: 396
	[MarshalingBehavior(2)]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	public sealed class ItemsRepeaterElementIndexChangedEventArgs : IItemsRepeaterElementIndexChangedEventArgs
	{
		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000700 RID: 1792
		public extern UIElement Element { get; }

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000701 RID: 1793
		public extern int OldIndex { get; }

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000702 RID: 1794
		public extern int NewIndex { get; }
	}
}
