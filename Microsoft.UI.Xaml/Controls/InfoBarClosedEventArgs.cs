using System;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000186 RID: 390
	[WebHostHidden]
	[Threading(3)]
	[MarshalingBehavior(2)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Composable(typeof(IInfoBarClosedEventArgsFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	public class InfoBarClosedEventArgs : IInfoBarClosedEventArgs
	{
		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x060006DA RID: 1754
		public extern InfoBarCloseReason Reason { get; }
	}
}
