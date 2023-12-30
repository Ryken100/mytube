using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200010A RID: 266
	[WebHostHidden]
	[Guid(1023567661U, 34819, 24369, 155, 142, 27, 225, 168, 160, 213, 225)]
	[ExclusiveTo(typeof(ProgressRing))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface IProgressRingStatics
	{
		// Token: 0x17000257 RID: 599
		// (get) Token: 0x0600043F RID: 1087
		DependencyProperty IsActiveProperty { get; }

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000440 RID: 1088
		DependencyProperty IsIndeterminateProperty { get; }

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000441 RID: 1089
		DependencyProperty ValueProperty { get; }

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000442 RID: 1090
		DependencyProperty MinimumProperty { get; }

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000443 RID: 1091
		DependencyProperty MaximumProperty { get; }
	}
}
