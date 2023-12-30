using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	// Token: 0x020001D5 RID: 469
	[Guid(4054140915U, 19470, 24355, 159, 30, 164, 192, 140, 171, 222, 136)]
	[ExclusiveTo(typeof(CornerRadiusFilterConverter))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	internal interface ICornerRadiusFilterConverterStatics
	{
		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x0600095E RID: 2398
		DependencyProperty FilterProperty { get; }

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x0600095F RID: 2399
		DependencyProperty ScaleProperty { get; }
	}
}
