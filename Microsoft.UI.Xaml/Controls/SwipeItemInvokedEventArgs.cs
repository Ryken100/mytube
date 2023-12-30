using System;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000206 RID: 518
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MarshalingBehavior(2)]
	public sealed class SwipeItemInvokedEventArgs : ISwipeItemInvokedEventArgs
	{
		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06000A94 RID: 2708
		public extern SwipeControl SwipeControl { get; }
	}
}
