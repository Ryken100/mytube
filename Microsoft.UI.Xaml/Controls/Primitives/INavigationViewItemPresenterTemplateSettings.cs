using System;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	// Token: 0x020001E1 RID: 481
	[WebHostHidden]
	[ExclusiveTo(typeof(NavigationViewItemPresenterTemplateSettings))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(2769393488U, 64113, 22258, 191, 164, 121, 157, 159, 48, 76, 184)]
	internal interface INavigationViewItemPresenterTemplateSettings
	{
		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06000980 RID: 2432
		double IconWidth { get; }

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06000981 RID: 2433
		double SmallerIconWidth { get; }
	}
}
