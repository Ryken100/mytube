using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000128 RID: 296
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[Guid(3878733115U, 36756, 21939, 139, 193, 152, 247, 124, 87, 102, 189)]
	[ExclusiveTo(typeof(RevealListViewItemPresenter))]
	internal interface IRevealListViewItemPresenterFactory
	{
		// Token: 0x060004CB RID: 1227
		RevealListViewItemPresenter CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
