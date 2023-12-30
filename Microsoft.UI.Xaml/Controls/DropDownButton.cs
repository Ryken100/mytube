using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200006B RID: 107
	[WebHostHidden]
	[MarshalingBehavior(2)]
	[Threading(3)]
	[Composable(typeof(IDropDownButtonFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	public class DropDownButton : Button, IDropDownButton
	{
		// Token: 0x0600010D RID: 269
		public extern DropDownButton();
	}
}
