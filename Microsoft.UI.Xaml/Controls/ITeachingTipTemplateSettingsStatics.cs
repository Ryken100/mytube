using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000151 RID: 337
	[Guid(1653988040U, 28930, 22018, 184, 249, 229, 0, 229, 152, 68, 143)]
	[WebHostHidden]
	[ExclusiveTo(typeof(TeachingTipTemplateSettings))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface ITeachingTipTemplateSettingsStatics
	{
		// Token: 0x1700033C RID: 828
		// (get) Token: 0x060005CC RID: 1484
		DependencyProperty TopRightHighlightMarginProperty { get; }

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x060005CD RID: 1485
		DependencyProperty TopLeftHighlightMarginProperty { get; }

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x060005CE RID: 1486
		DependencyProperty IconElementProperty { get; }
	}
}
