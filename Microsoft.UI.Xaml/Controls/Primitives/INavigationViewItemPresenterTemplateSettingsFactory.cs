using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	// Token: 0x020001E2 RID: 482
	[ExclusiveTo(typeof(NavigationViewItemPresenterTemplateSettings))]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(435098408U, 21191, 21987, 177, 187, 146, 63, 47, 57, 189, 110)]
	internal interface INavigationViewItemPresenterTemplateSettingsFactory
	{
		// Token: 0x06000982 RID: 2434
		NavigationViewItemPresenterTemplateSettings CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
