using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000DA RID: 218
	[ExclusiveTo(typeof(NavigationViewItem))]
	[Guid(3730874369U, 37765, 21813, 128, 225, 43, 104, 244, 191, 222, 38)]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface INavigationViewItemFactory
	{
		// Token: 0x06000314 RID: 788
		NavigationViewItem CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
