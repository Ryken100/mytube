using System;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000147 RID: 327
	[Guid(2032125475U, 51446, 20738, 129, 189, 24, 105, 205, 232, 34, 132)]
	[WebHostHidden]
	[ExclusiveTo(typeof(TabViewTabDragCompletedEventArgs))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface ITabViewTabDragCompletedEventArgs
	{
		// Token: 0x17000301 RID: 769
		// (get) Token: 0x0600056F RID: 1391
		DataPackageOperation DropResult { get; }

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000570 RID: 1392
		object Item { get; }

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000571 RID: 1393
		TabViewItem Tab { get; }
	}
}
