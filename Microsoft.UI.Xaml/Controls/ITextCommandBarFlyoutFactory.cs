using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000153 RID: 339
	[Guid(1549181775U, 25119, 22002, 141, 113, 62, 58, 110, 105, 6, 189)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[ExclusiveTo(typeof(TextCommandBarFlyout))]
	internal interface ITextCommandBarFlyoutFactory
	{
		// Token: 0x060005CF RID: 1487
		TextCommandBarFlyout CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
