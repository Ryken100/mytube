using System;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000D9 RID: 217
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(NavigationViewItemExpandingEventArgs))]
	[WebHostHidden]
	[Guid(1862877630U, 59793, 21240, 131, 21, 240, 131, 137, 73, 121, 118)]
	internal interface INavigationViewItemExpandingEventArgs
	{
		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000312 RID: 786
		NavigationViewItemBase ExpandingItemContainer { get; }

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000313 RID: 787
		object ExpandingItem { get; }
	}
}
