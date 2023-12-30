using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000B4 RID: 180
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[ExclusiveTo(typeof(InfoBarTemplateSettings))]
	[Guid(3448767095U, 57722, 21193, 128, 148, 15, 180, 245, 204, 25, 184)]
	internal interface IInfoBarTemplateSettingsStatics
	{
		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000254 RID: 596
		DependencyProperty IconElementProperty { get; }
	}
}
