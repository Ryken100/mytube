using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	// Token: 0x020001E3 RID: 483
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[Guid(3130465533U, 20535, 23435, 169, 94, 101, 44, 101, 236, 170, 191)]
	[ExclusiveTo(typeof(NavigationViewItemPresenterTemplateSettings))]
	internal interface INavigationViewItemPresenterTemplateSettingsStatics
	{
		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06000983 RID: 2435
		DependencyProperty IconWidthProperty { get; }

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06000984 RID: 2436
		DependencyProperty SmallerIconWidthProperty { get; }
	}
}
