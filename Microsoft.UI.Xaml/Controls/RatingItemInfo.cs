using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020001F3 RID: 499
	[Threading(3)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Composable(typeof(IRatingItemInfoFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(2)]
	[WebHostHidden]
	public class RatingItemInfo : DependencyObject, IRatingItemInfo
	{
		// Token: 0x06000A10 RID: 2576
		public extern RatingItemInfo();
	}
}
