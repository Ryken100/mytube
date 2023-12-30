using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000CB RID: 203
	[Guid(1652745526U, 7420, 23846, 159, 109, 143, 51, 77, 175, 153, 126)]
	[ExclusiveTo(typeof(MenuBarItem))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	internal interface IMenuBarItemStatics
	{
		// Token: 0x1700014C RID: 332
		// (get) Token: 0x0600029D RID: 669
		DependencyProperty TitleProperty { get; }

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x0600029E RID: 670
		DependencyProperty ItemsProperty { get; }
	}
}
