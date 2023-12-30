using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000115 RID: 277
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(928161864U, 62450, 24310, 135, 141, 73, 149, 114, 240, 82, 155)]
	[WebHostHidden]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ExclusiveTo(typeof(RatingControl))]
	[MUXPropertyChangedCallback(enable = true)]
	internal interface IRatingControlStatics
	{
		// Token: 0x1700027C RID: 636
		// (get) Token: 0x0600047F RID: 1151
		DependencyProperty CaptionProperty { get; }

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000480 RID: 1152
		DependencyProperty InitialSetValueProperty { get; }

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000481 RID: 1153
		DependencyProperty IsClearEnabledProperty { get; }

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000482 RID: 1154
		DependencyProperty IsReadOnlyProperty { get; }

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000483 RID: 1155
		DependencyProperty MaxRatingProperty { get; }

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000484 RID: 1156
		DependencyProperty PlaceholderValueProperty { get; }

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000485 RID: 1157
		DependencyProperty ItemInfoProperty { get; }

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000486 RID: 1158
		DependencyProperty ValueProperty { get; }
	}
}
