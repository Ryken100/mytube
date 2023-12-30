using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200020D RID: 525
	[Threading(3)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[MarshalingBehavior(2)]
	[Static(typeof(ITabViewItemTemplateSettingsStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[Composable(typeof(ITabViewItemTemplateSettingsFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	public class TabViewItemTemplateSettings : DependencyObject, ITabViewItemTemplateSettings
	{
		// Token: 0x06000B05 RID: 2821
		public extern TabViewItemTemplateSettings();

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06000B06 RID: 2822
		// (set) Token: 0x06000B07 RID: 2823
		public extern IconElement IconElement
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06000B08 RID: 2824
		public static extern DependencyProperty IconElementProperty { get; }
	}
}
