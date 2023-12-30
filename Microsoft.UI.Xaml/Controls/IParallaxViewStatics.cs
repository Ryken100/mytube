using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000F7 RID: 247
	[WebHostHidden]
	[Guid(2977564802U, 59694, 23200, 146, 213, 61, 230, 159, 14, 106, 168)]
	[ExclusiveTo(typeof(ParallaxView))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MUXPropertyChangedCallback(enable = true)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	internal interface IParallaxViewStatics
	{
		// Token: 0x17000202 RID: 514
		// (get) Token: 0x060003C6 RID: 966
		DependencyProperty ChildProperty { get; }

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x060003C7 RID: 967
		DependencyProperty HorizontalSourceEndOffsetProperty { get; }

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x060003C8 RID: 968
		DependencyProperty HorizontalSourceOffsetKindProperty { get; }

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x060003C9 RID: 969
		DependencyProperty HorizontalSourceStartOffsetProperty { get; }

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x060003CA RID: 970
		DependencyProperty MaxHorizontalShiftRatioProperty { get; }

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x060003CB RID: 971
		DependencyProperty HorizontalShiftProperty { get; }

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060003CC RID: 972
		DependencyProperty IsHorizontalShiftClampedProperty { get; }

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060003CD RID: 973
		DependencyProperty IsVerticalShiftClampedProperty { get; }

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x060003CE RID: 974
		DependencyProperty SourceProperty { get; }

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x060003CF RID: 975
		DependencyProperty VerticalSourceEndOffsetProperty { get; }

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x060003D0 RID: 976
		DependencyProperty VerticalSourceOffsetKindProperty { get; }

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x060003D1 RID: 977
		DependencyProperty VerticalSourceStartOffsetProperty { get; }

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x060003D2 RID: 978
		DependencyProperty MaxVerticalShiftRatioProperty { get; }

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x060003D3 RID: 979
		DependencyProperty VerticalShiftProperty { get; }
	}
}
