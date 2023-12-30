using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	// Token: 0x020001DF RID: 479
	[Guid(2995454304U, 556, 22844, 171, 154, 123, 61, 237, 44, 7, 84)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(NavigationViewItemPresenter))]
	[WebHostHidden]
	internal interface INavigationViewItemPresenterFactory
	{
		// Token: 0x0600097D RID: 2429
		NavigationViewItemPresenter CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
