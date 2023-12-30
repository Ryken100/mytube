using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000E1 RID: 225
	[WebHostHidden]
	[ExclusiveTo(typeof(NavigationViewItem))]
	[Guid(3370374U, 49605, 21951, 162, 13, 169, 244, 81, 35, 99, 239)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface INavigationViewItemStatics
	{
		// Token: 0x17000187 RID: 391
		// (get) Token: 0x0600031B RID: 795
		DependencyProperty IconProperty { get; }

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x0600031C RID: 796
		DependencyProperty CompactPaneLengthProperty { get; }
	}
}
