using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000DE RID: 222
	[ExclusiveTo(typeof(NavigationViewItemInvokedEventArgs))]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(4105432484U, 13107, 20973, 146, 81, 156, 244, 121, 241, 85, 195)]
	internal interface INavigationViewItemInvokedEventArgs2
	{
		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000318 RID: 792
		NavigationViewItemBase InvokedItemContainer { get; }

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000319 RID: 793
		NavigationTransitionInfo RecommendedNavigationTransitionInfo { get; }
	}
}
