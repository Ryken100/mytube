using System;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Media
{
	// Token: 0x0200024E RID: 590
	[Composable(typeof(IRevealBorderBrushFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Threading(3)]
	[MarshalingBehavior(2)]
	[WebHostHidden]
	public class RevealBorderBrush : RevealBrush, IRevealBorderBrush
	{
		// Token: 0x06000CB1 RID: 3249
		public extern RevealBorderBrush();
	}
}
