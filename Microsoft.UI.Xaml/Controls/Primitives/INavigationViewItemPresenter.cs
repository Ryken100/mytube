using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	// Token: 0x020001DE RID: 478
	[Guid(76136288U, 63024, 20748, 152, 220, 177, 35, 34, 38, 14, 31)]
	[ExclusiveTo(typeof(NavigationViewItemPresenter))]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface INavigationViewItemPresenter
	{
		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x0600097A RID: 2426
		// (set) Token: 0x0600097B RID: 2427
		IconElement Icon
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x0600097C RID: 2428
		NavigationViewItemPresenterTemplateSettings TemplateSettings { get; }
	}
}
