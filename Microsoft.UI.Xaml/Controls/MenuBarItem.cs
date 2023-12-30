using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Markup;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000193 RID: 403
	[Static(typeof(IMenuBarItemStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[Threading(3)]
	[ContentProperty(Name = "Items")]
	[MarshalingBehavior(2)]
	[Composable(typeof(IMenuBarItemFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	public class MenuBarItem : Control, IMenuBarItem
	{
		// Token: 0x06000727 RID: 1831
		public extern MenuBarItem();

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06000728 RID: 1832
		// (set) Token: 0x06000729 RID: 1833
		public extern string Title
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x0600072A RID: 1834
		public extern IVector<MenuFlyoutItemBase> Items { get; }

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x0600072B RID: 1835
		public static extern DependencyProperty TitleProperty { get; }

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x0600072C RID: 1836
		public static extern DependencyProperty ItemsProperty { get; }
	}
}
