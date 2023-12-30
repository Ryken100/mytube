using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000145 RID: 325
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(TabView))]
	[Guid(1070250252U, 56748, 21477, 131, 171, 122, 142, 158, 233, 56, 137)]
	[WebHostHidden]
	internal interface ITabViewStatics
	{
		// Token: 0x170002FE RID: 766
		// (get) Token: 0x0600055B RID: 1371
		DependencyProperty TabWidthModeProperty { get; }

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x0600055C RID: 1372
		DependencyProperty TabStripHeaderProperty { get; }

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x0600055D RID: 1373
		DependencyProperty TabStripHeaderTemplateProperty { get; }

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x0600055E RID: 1374
		DependencyProperty TabStripFooterProperty { get; }

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x0600055F RID: 1375
		DependencyProperty TabStripFooterTemplateProperty { get; }

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000560 RID: 1376
		DependencyProperty IsAddTabButtonVisibleProperty { get; }

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000561 RID: 1377
		DependencyProperty AddTabButtonCommandProperty { get; }

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000562 RID: 1378
		DependencyProperty AddTabButtonCommandParameterProperty { get; }

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000563 RID: 1379
		DependencyProperty TabItemsSourceProperty { get; }

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000564 RID: 1380
		DependencyProperty TabItemsProperty { get; }

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000565 RID: 1381
		DependencyProperty TabItemTemplateProperty { get; }

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000566 RID: 1382
		DependencyProperty TabItemTemplateSelectorProperty { get; }

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000567 RID: 1383
		DependencyProperty CloseButtonOverlayModeProperty { get; }

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000568 RID: 1384
		DependencyProperty CanDragTabsProperty { get; }

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000569 RID: 1385
		DependencyProperty CanReorderTabsProperty { get; }

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x0600056A RID: 1386
		DependencyProperty AllowDropTabsProperty { get; }

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x0600056B RID: 1387
		DependencyProperty SelectedIndexProperty { get; }

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x0600056C RID: 1388
		DependencyProperty SelectedItemProperty { get; }
	}
}
