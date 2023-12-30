using System;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000199 RID: 409
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MarshalingBehavior(2)]
	[WebHostHidden]
	public sealed class NavigationViewDisplayModeChangedEventArgs : INavigationViewDisplayModeChangedEventArgs
	{
		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x060007B1 RID: 1969
		public extern NavigationViewDisplayMode DisplayMode { get; }
	}
}
