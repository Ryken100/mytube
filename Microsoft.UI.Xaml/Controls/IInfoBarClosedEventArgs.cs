using System;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000AC RID: 172
	[ExclusiveTo(typeof(InfoBarClosedEventArgs))]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(1497034931U, 48621, 21466, 143, 86, 128, 237, 60, 100, 50, 44)]
	internal interface IInfoBarClosedEventArgs
	{
		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600023E RID: 574
		InfoBarCloseReason Reason { get; }
	}
}
