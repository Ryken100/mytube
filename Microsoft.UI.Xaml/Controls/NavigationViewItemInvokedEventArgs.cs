using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200019F RID: 415
	[Activatable(65536U, "Microsoft.UI.Xaml.XamlContract")]
	[WebHostHidden]
	[MarshalingBehavior(2)]
	[Threading(3)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	public sealed class NavigationViewItemInvokedEventArgs : INavigationViewItemInvokedEventArgs, INavigationViewItemInvokedEventArgs2
	{
		// Token: 0x060007D1 RID: 2001
		public extern NavigationViewItemInvokedEventArgs();

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x060007D2 RID: 2002
		public extern object InvokedItem { get; }

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x060007D3 RID: 2003
		public extern bool IsSettingsInvoked { get; }

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x060007D4 RID: 2004
		public extern NavigationViewItemBase InvokedItemContainer { get; }

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x060007D5 RID: 2005
		public extern NavigationTransitionInfo RecommendedNavigationTransitionInfo { get; }
	}
}
