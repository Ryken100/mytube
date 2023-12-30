using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	// Token: 0x020001E9 RID: 489
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MarshalingBehavior(2)]
	[Threading(3)]
	[WebHostHidden]
	[Composable(typeof(INavigationViewItemPresenterTemplateSettingsFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[Static(typeof(INavigationViewItemPresenterTemplateSettingsStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	public class NavigationViewItemPresenterTemplateSettings : DependencyObject, INavigationViewItemPresenterTemplateSettings
	{
		// Token: 0x060009A0 RID: 2464
		public extern NavigationViewItemPresenterTemplateSettings();

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x060009A1 RID: 2465
		public extern double IconWidth { get; }

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x060009A2 RID: 2466
		public extern double SmallerIconWidth { get; }

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x060009A3 RID: 2467
		public static extern DependencyProperty IconWidthProperty { get; }

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x060009A4 RID: 2468
		public static extern DependencyProperty SmallerIconWidthProperty { get; }
	}
}
