using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000BB RID: 187
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(ItemsRepeater))]
	[WebHostHidden]
	[Guid(193275530U, 26388, 23844, 168, 80, 212, 51, 142, 106, 145, 168)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	internal interface IItemsRepeaterStatics
	{
		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000279 RID: 633
		DependencyProperty ItemsSourceProperty { get; }

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600027A RID: 634
		DependencyProperty ItemTemplateProperty { get; }

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x0600027B RID: 635
		DependencyProperty LayoutProperty { get; }

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600027C RID: 636
		DependencyProperty HorizontalCacheLengthProperty { get; }

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x0600027D RID: 637
		DependencyProperty VerticalCacheLengthProperty { get; }

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600027E RID: 638
		DependencyProperty BackgroundProperty { get; }
	}
}
