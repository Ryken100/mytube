using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000189 RID: 393
	[WebHostHidden]
	[Threading(3)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Composable(typeof(IInfoBarTemplateSettingsFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[Static(typeof(IInfoBarTemplateSettingsStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(2)]
	public class InfoBarTemplateSettings : DependencyObject, IInfoBarTemplateSettings
	{
		// Token: 0x060006DE RID: 1758
		public extern InfoBarTemplateSettings();

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x060006DF RID: 1759
		// (set) Token: 0x060006E0 RID: 1760
		public extern IconElement IconElement
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x060006E1 RID: 1761
		public static extern DependencyProperty IconElementProperty { get; }
	}
}
