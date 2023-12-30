using System;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200021B RID: 539
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Composable(typeof(ITextCommandBarFlyoutFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(2)]
	[Threading(3)]
	[WebHostHidden]
	public class TextCommandBarFlyout : CommandBarFlyout, ITextCommandBarFlyout
	{
		// Token: 0x06000B6B RID: 2923
		public extern TextCommandBarFlyout();
	}
}
