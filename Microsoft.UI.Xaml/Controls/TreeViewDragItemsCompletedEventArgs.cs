using System;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000220 RID: 544
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MarshalingBehavior(2)]
	[WebHostHidden]
	public sealed class TreeViewDragItemsCompletedEventArgs : ITreeViewDragItemsCompletedEventArgs, ITreeViewDragItemsCompletedEventArgs2
	{
		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x06000BA9 RID: 2985
		public extern DataPackageOperation DropResult { get; }

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x06000BAA RID: 2986
		public extern IVectorView<object> Items { get; }

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x06000BAB RID: 2987
		public extern object NewParentItem { get; }
	}
}
