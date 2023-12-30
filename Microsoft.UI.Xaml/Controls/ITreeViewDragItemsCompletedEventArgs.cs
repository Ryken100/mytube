using System;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200015C RID: 348
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(TreeViewDragItemsCompletedEventArgs))]
	[WebHostHidden]
	[Guid(3854062718U, 63545, 21979, 156, 38, 42, 149, 245, 122, 96, 220)]
	internal interface ITreeViewDragItemsCompletedEventArgs
	{
		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000602 RID: 1538
		DataPackageOperation DropResult { get; }

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000603 RID: 1539
		IVectorView<object> Items { get; }
	}
}
