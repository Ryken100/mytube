using System;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020001F7 RID: 503
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MarshalingBehavior(2)]
	public sealed class RefreshInteractionRatioChangedEventArgs : IRefreshInteractionRatioChangedEventArgs
	{
		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06000A41 RID: 2625
		public extern double InteractionRatio { get; }
	}
}
