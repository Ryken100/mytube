using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000E5 RID: 229
	[Guid(953871147U, 21347, 20963, 190, 212, 101, 54, 65, 181, 99, 54)]
	[ExclusiveTo(typeof(NavigationViewSelectionChangedEventArgs))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	internal interface INavigationViewSelectionChangedEventArgs2
	{
		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000327 RID: 807
		NavigationViewItemBase SelectedItemContainer { get; }

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000328 RID: 808
		NavigationTransitionInfo RecommendedNavigationTransitionInfo { get; }
	}
}
