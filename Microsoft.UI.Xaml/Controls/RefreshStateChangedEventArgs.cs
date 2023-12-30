using System;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020001FA RID: 506
	[MarshalingBehavior(2)]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	public sealed class RefreshStateChangedEventArgs : IRefreshStateChangedEventArgs
	{
		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06000A43 RID: 2627
		public extern RefreshVisualizerState OldState { get; }

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06000A44 RID: 2628
		public extern RefreshVisualizerState NewState { get; }
	}
}
