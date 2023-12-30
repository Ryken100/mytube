using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020001A4 RID: 420
	[WebHostHidden]
	[MarshalingBehavior(2)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	public sealed class NavigationViewSelectionChangedEventArgs : INavigationViewSelectionChangedEventArgs, INavigationViewSelectionChangedEventArgs2
	{
		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x060007D9 RID: 2009
		public extern object SelectedItem { get; }

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x060007DA RID: 2010
		public extern bool IsSettingsSelected { get; }

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x060007DB RID: 2011
		public extern NavigationViewItemBase SelectedItemContainer { get; }

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x060007DC RID: 2012
		public extern NavigationTransitionInfo RecommendedNavigationTransitionInfo { get; }
	}
}
