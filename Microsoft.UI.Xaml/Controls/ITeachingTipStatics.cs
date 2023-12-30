using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200014E RID: 334
	[ExclusiveTo(typeof(TeachingTip))]
	[MUXPropertyChangedCallback(enable = true)]
	[WebHostHidden]
	[Guid(3362930667U, 48584, 22126, 173, 92, 111, 7, 37, 74, 249, 55)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface ITeachingTipStatics
	{
		// Token: 0x1700032E RID: 814
		// (get) Token: 0x060005B0 RID: 1456
		DependencyProperty IsOpenProperty { get; }

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x060005B1 RID: 1457
		DependencyProperty TargetProperty { get; }

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x060005B2 RID: 1458
		DependencyProperty TailVisibilityProperty { get; }

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x060005B3 RID: 1459
		DependencyProperty TitleProperty { get; }

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x060005B4 RID: 1460
		DependencyProperty SubtitleProperty { get; }

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x060005B5 RID: 1461
		DependencyProperty ActionButtonContentProperty { get; }

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x060005B6 RID: 1462
		DependencyProperty ActionButtonStyleProperty { get; }

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x060005B7 RID: 1463
		DependencyProperty ActionButtonCommandProperty { get; }

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x060005B8 RID: 1464
		DependencyProperty ActionButtonCommandParameterProperty { get; }

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x060005B9 RID: 1465
		DependencyProperty CloseButtonContentProperty { get; }

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x060005BA RID: 1466
		DependencyProperty CloseButtonStyleProperty { get; }

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x060005BB RID: 1467
		DependencyProperty CloseButtonCommandProperty { get; }

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x060005BC RID: 1468
		DependencyProperty CloseButtonCommandParameterProperty { get; }

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x060005BD RID: 1469
		DependencyProperty PlacementMarginProperty { get; }

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x060005BE RID: 1470
		DependencyProperty ShouldConstrainToRootBoundsProperty { get; }

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x060005BF RID: 1471
		DependencyProperty IsLightDismissEnabledProperty { get; }

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x060005C0 RID: 1472
		DependencyProperty PreferredPlacementProperty { get; }

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x060005C1 RID: 1473
		DependencyProperty HeroContentPlacementProperty { get; }

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x060005C2 RID: 1474
		DependencyProperty HeroContentProperty { get; }

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x060005C3 RID: 1475
		DependencyProperty IconSourceProperty { get; }

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x060005C4 RID: 1476
		DependencyProperty TemplateSettingsProperty { get; }
	}
}
