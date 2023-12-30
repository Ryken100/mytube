using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000CC RID: 204
	[WebHostHidden]
	[ExclusiveTo(typeof(MenuBar))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(281744116U, 56544, 20815, 172, 209, 13, 83, 250, 2, 117, 209)]
	internal interface IMenuBarStatics
	{
		// Token: 0x1700014D RID: 333
		// (get) Token: 0x0600029F RID: 671
		DependencyProperty ItemsProperty { get; }
	}
}
