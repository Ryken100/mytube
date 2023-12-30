using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000CA RID: 202
	[ExclusiveTo(typeof(MenuBarItemFlyout))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[Guid(4170519102U, 60756, 23190, 132, 24, 243, 94, 72, 80, 93, 67)]
	internal interface IMenuBarItemFlyoutFactory
	{
		// Token: 0x0600029C RID: 668
		MenuBarItemFlyout CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
