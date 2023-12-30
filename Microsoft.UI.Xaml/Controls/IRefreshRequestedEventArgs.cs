using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000122 RID: 290
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[ExclusiveTo(typeof(RefreshRequestedEventArgs))]
	[Guid(3986139478U, 24601, 21289, 147, 18, 248, 133, 181, 199, 116, 205)]
	internal interface IRefreshRequestedEventArgs
	{
		// Token: 0x060004B9 RID: 1209
		Deferral GetDeferral();
	}
}
