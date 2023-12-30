using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200008B RID: 139
	[WebHostHidden]
	[ExclusiveTo(typeof(BreadcrumbBarItem))]
	[Guid(409746387U, 28680, 21828, 141, 58, 101, 175, 143, 233, 254, 105)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface IBreadcrumbBarItemFactory
	{
		// Token: 0x06000193 RID: 403
		BreadcrumbBarItem CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
