using System;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200020F RID: 527
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[MarshalingBehavior(2)]
	public sealed class TabViewTabDragCompletedEventArgs : ITabViewTabDragCompletedEventArgs
	{
		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06000B0B RID: 2827
		public extern DataPackageOperation DropResult { get; }

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06000B0C RID: 2828
		public extern object Item { get; }

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06000B0D RID: 2829
		public extern TabViewItem Tab { get; }
	}
}
