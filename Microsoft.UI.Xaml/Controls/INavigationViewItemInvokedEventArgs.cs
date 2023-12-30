using System;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000DD RID: 221
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[ExclusiveTo(typeof(NavigationViewItemInvokedEventArgs))]
	[Guid(122481578U, 23813, 21627, 140, 214, 209, 154, 194, 217, 187, 59)]
	internal interface INavigationViewItemInvokedEventArgs
	{
		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000316 RID: 790
		object InvokedItem { get; }

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000317 RID: 791
		bool IsSettingsInvoked { get; }
	}
}
