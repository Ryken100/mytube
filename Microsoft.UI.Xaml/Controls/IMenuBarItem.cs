using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000C7 RID: 199
	[ExclusiveTo(typeof(MenuBarItem))]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(2628403809U, 14860, 23129, 140, 254, 57, 23, 68, 195, 248, 21)]
	internal interface IMenuBarItem
	{
		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000298 RID: 664
		// (set) Token: 0x06000299 RID: 665
		string Title
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x0600029A RID: 666
		IVector<MenuFlyoutItemBase> Items { get; }
	}
}
