using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000E2 RID: 226
	[ExclusiveTo(typeof(NavigationViewItem))]
	[Guid(1067395664U, 1847, 24389, 128, 132, 144, 253, 98, 143, 219, 19)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	internal interface INavigationViewItemStatics2
	{
		// Token: 0x1700018D RID: 397
		// (get) Token: 0x0600031D RID: 797
		DependencyProperty SelectsOnInvokedProperty { get; }

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x0600031E RID: 798
		DependencyProperty IsExpandedProperty { get; }

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x0600031F RID: 799
		DependencyProperty HasUnrealizedChildrenProperty { get; }

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000320 RID: 800
		DependencyProperty IsChildSelectedProperty { get; }

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000321 RID: 801
		DependencyProperty MenuItemsProperty { get; }

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000322 RID: 802
		DependencyProperty MenuItemsSourceProperty { get; }
	}
}
