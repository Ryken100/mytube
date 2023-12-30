using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200018B RID: 395
	[MarshalingBehavior(2)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	public sealed class ItemsRepeaterElementClearingEventArgs : IItemsRepeaterElementClearingEventArgs
	{
		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x060006FF RID: 1791
		public extern UIElement Element { get; }
	}
}
