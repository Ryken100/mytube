using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	// Token: 0x020001E5 RID: 485
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[Guid(2315800541U, 34544, 20974, 152, 223, 95, 189, 11, 86, 105, 190)]
	[ExclusiveTo(typeof(TabViewListView))]
	internal interface ITabViewListViewFactory
	{
		// Token: 0x06000985 RID: 2437
		TabViewListView CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
