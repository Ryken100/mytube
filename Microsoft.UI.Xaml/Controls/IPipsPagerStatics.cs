using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000102 RID: 258
	[ExclusiveTo(typeof(PipsPager))]
	[MUXPropertyChangedCallback(enable = true)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[Guid(2957807075U, 36858, 24445, 191, 28, 180, 58, 53, 62, 25, 83)]
	internal interface IPipsPagerStatics
	{
		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000412 RID: 1042
		DependencyProperty NumberOfPagesProperty { get; }

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000413 RID: 1043
		DependencyProperty SelectedPageIndexProperty { get; }

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000414 RID: 1044
		DependencyProperty MaxVisiblePipsProperty { get; }

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000415 RID: 1045
		DependencyProperty OrientationProperty { get; }

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000416 RID: 1046
		DependencyProperty PreviousButtonVisibilityProperty { get; }

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000417 RID: 1047
		DependencyProperty NextButtonVisibilityProperty { get; }

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000418 RID: 1048
		DependencyProperty PreviousButtonStyleProperty { get; }

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000419 RID: 1049
		DependencyProperty NextButtonStyleProperty { get; }

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x0600041A RID: 1050
		DependencyProperty SelectedPipStyleProperty { get; }

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x0600041B RID: 1051
		DependencyProperty NormalPipStyleProperty { get; }
	}
}
