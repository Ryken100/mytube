using System;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000D8 RID: 216
	[WebHostHidden]
	[Guid(3041326753U, 50799, 24045, 181, 215, 190, 208, 162, 97, 151, 227)]
	[ExclusiveTo(typeof(NavigationViewItemCollapsedEventArgs))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface INavigationViewItemCollapsedEventArgs
	{
		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000310 RID: 784
		NavigationViewItemBase CollapsedItemContainer { get; }

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000311 RID: 785
		object CollapsedItem { get; }
	}
}
