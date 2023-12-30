using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000141 RID: 321
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[ExclusiveTo(typeof(TabViewItem))]
	[Guid(172992630U, 56394, 22088, 145, 20, 195, 179, 146, 222, 49, 41)]
	internal interface ITabViewItemStatics
	{
		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000552 RID: 1362
		DependencyProperty HeaderProperty { get; }

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000553 RID: 1363
		DependencyProperty HeaderTemplateProperty { get; }

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000554 RID: 1364
		DependencyProperty IconSourceProperty { get; }

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000555 RID: 1365
		DependencyProperty IsClosableProperty { get; }

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000556 RID: 1366
		DependencyProperty TabViewTemplateSettingsProperty { get; }
	}
}
