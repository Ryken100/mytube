using System;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000135 RID: 309
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(2079661205U, 21410, 23053, 187, 50, 43, 75, 31, 125, 47, 32)]
	[ExclusiveTo(typeof(SwipeItemInvokedEventArgs))]
	internal interface ISwipeItemInvokedEventArgs
	{
		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x060004FE RID: 1278
		SwipeControl SwipeControl { get; }
	}
}
