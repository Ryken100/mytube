using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	// Token: 0x020001E8 RID: 488
	[MarshalingBehavior(2)]
	[Static(typeof(INavigationViewItemPresenterStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[Composable(typeof(INavigationViewItemPresenterFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Threading(3)]
	public class NavigationViewItemPresenter : ContentControl, INavigationViewItemPresenter
	{
		// Token: 0x0600099A RID: 2458
		public extern NavigationViewItemPresenter();

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x0600099B RID: 2459
		// (set) Token: 0x0600099C RID: 2460
		public extern IconElement Icon
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x0600099D RID: 2461
		public extern NavigationViewItemPresenterTemplateSettings TemplateSettings { get; }

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x0600099E RID: 2462
		public static extern DependencyProperty IconProperty { get; }

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x0600099F RID: 2463
		public static extern DependencyProperty TemplateSettingsProperty { get; }
	}
}
