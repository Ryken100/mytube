using System;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200015D RID: 349
	[Guid(101529889U, 22432, 23493, 190, 38, 50, 11, 217, 193, 166, 232)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(TreeViewDragItemsCompletedEventArgs))]
	[WebHostHidden]
	internal interface ITreeViewDragItemsCompletedEventArgs2
	{
		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000604 RID: 1540
		object NewParentItem { get; }
	}
}
