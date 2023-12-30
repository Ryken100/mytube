using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	// Token: 0x020001BC RID: 444
	[Composable(typeof(ICommandBarFlyoutCommandBarFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[WebHostHidden]
	[Threading(3)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MarshalingBehavior(2)]
	public class CommandBarFlyoutCommandBar : CommandBar, ICommandBarFlyoutCommandBar
	{
		// Token: 0x060008E1 RID: 2273
		public extern CommandBarFlyoutCommandBar();

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x060008E2 RID: 2274
		[MUXPropertyNeedsDependencyPropertyField]
		public extern CommandBarFlyoutCommandBarTemplateSettings FlyoutTemplateSettings
		{
			[MUXPropertyNeedsDependencyPropertyField]
			get;
		}
	}
}
