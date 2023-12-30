using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Markup;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000192 RID: 402
	[ContentProperty(Name = "Items")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[Static(typeof(IMenuBarStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(2)]
	[Threading(3)]
	[Composable(typeof(IMenuBarFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	public class MenuBar : Control, IMenuBar
	{
		// Token: 0x06000724 RID: 1828
		public extern MenuBar();

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06000725 RID: 1829
		public extern IVector<MenuBarItem> Items { get; }

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06000726 RID: 1830
		public static extern DependencyProperty ItemsProperty { get; }
	}
}
