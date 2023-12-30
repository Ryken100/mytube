using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000187 RID: 391
	[Composable(typeof(IInfoBarClosingEventArgsFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(2)]
	[WebHostHidden]
	[Threading(3)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	public class InfoBarClosingEventArgs : IInfoBarClosingEventArgs
	{
		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x060006DB RID: 1755
		public extern InfoBarCloseReason Reason { get; }

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x060006DC RID: 1756
		// (set) Token: 0x060006DD RID: 1757
		public extern bool Cancel
		{
			get; [param: In]
			set;
		}
	}
}
