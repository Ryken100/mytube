using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020001F9 RID: 505
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MarshalingBehavior(2)]
	public sealed class RefreshRequestedEventArgs : IRefreshRequestedEventArgs
	{
		// Token: 0x06000A42 RID: 2626
		public extern Deferral GetDeferral();
	}
}
