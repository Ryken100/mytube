using System;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Media
{
	// Token: 0x0200024D RID: 589
	[WebHostHidden]
	[MarshalingBehavior(2)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Composable(typeof(IRevealBackgroundBrushFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[Threading(3)]
	public class RevealBackgroundBrush : RevealBrush, IRevealBackgroundBrush
	{
		// Token: 0x06000CB0 RID: 3248
		public extern RevealBackgroundBrush();
	}
}
