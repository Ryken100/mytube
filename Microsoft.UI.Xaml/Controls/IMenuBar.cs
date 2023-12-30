using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000C5 RID: 197
	[Guid(3130520375U, 36638, 20801, 181, 63, 231, 122, 139, 163, 235, 189)]
	[WebHostHidden]
	[ExclusiveTo(typeof(MenuBar))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface IMenuBar
	{
		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000296 RID: 662
		IVector<MenuBarItem> Items { get; }
	}
}
