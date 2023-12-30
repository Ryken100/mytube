using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	// Token: 0x020001E0 RID: 480
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[ExclusiveTo(typeof(NavigationViewItemPresenter))]
	[Guid(4037404391U, 63014, 21552, 142, 242, 222, 117, 174, 114, 144, 15)]
	internal interface INavigationViewItemPresenterStatics
	{
		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x0600097E RID: 2430
		DependencyProperty IconProperty { get; }

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x0600097F RID: 2431
		DependencyProperty TemplateSettingsProperty { get; }
	}
}
