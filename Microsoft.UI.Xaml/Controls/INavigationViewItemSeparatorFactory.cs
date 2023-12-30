using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000E0 RID: 224
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(NavigationViewItemSeparator))]
	[Guid(403859105U, 54520, 23287, 129, 11, 174, 232, 161, 212, 82, 237)]
	internal interface INavigationViewItemSeparatorFactory
	{
		// Token: 0x0600031A RID: 794
		NavigationViewItemSeparator CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
