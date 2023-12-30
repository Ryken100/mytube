using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Media
{
	// Token: 0x02000243 RID: 579
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[Guid(1326419421U, 51847, 22575, 153, 7, 44, 196, 213, 126, 99, 54)]
	[ExclusiveTo(typeof(RadialGradientBrush))]
	internal interface IRadialGradientBrushStatics
	{
		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x06000C76 RID: 3190
		DependencyProperty CenterProperty { get; }

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x06000C77 RID: 3191
		DependencyProperty RadiusXProperty { get; }

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x06000C78 RID: 3192
		DependencyProperty RadiusYProperty { get; }

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x06000C79 RID: 3193
		DependencyProperty GradientOriginProperty { get; }

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x06000C7A RID: 3194
		DependencyProperty InterpolationSpaceProperty { get; }

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x06000C7B RID: 3195
		DependencyProperty MappingModeProperty { get; }

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x06000C7C RID: 3196
		DependencyProperty SpreadMethodProperty { get; }
	}
}
