using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020001A2 RID: 418
	[WebHostHidden]
	[MarshalingBehavior(2)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	public sealed class NavigationViewPaneClosingEventArgs : INavigationViewPaneClosingEventArgs
	{
		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x060007D7 RID: 2007
		// (set) Token: 0x060007D8 RID: 2008
		public extern bool Cancel
		{
			get; [param: In]
			set;
		}
	}
}
