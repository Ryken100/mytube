using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000140 RID: 320
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(TabViewItem))]
	[WebHostHidden]
	[Guid(3058443299U, 32342, 23873, 138, 132, 30, 226, 143, 152, 38, 164)]
	internal interface ITabViewItemFactory
	{
		// Token: 0x06000551 RID: 1361
		TabViewItem CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
