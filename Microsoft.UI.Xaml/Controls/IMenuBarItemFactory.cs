using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000C8 RID: 200
	[ExclusiveTo(typeof(MenuBarItem))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[Guid(2278564210U, 33739, 21593, 148, 15, 23, 63, 117, 1, 179, 0)]
	internal interface IMenuBarItemFactory
	{
		// Token: 0x0600029B RID: 667
		MenuBarItem CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
