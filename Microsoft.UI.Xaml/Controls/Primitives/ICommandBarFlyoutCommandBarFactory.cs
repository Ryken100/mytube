using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	// Token: 0x020001D2 RID: 466
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(CommandBarFlyoutCommandBar))]
	[Guid(1490800041U, 14564, 24316, 183, 64, 38, 253, 163, 208, 163, 198)]
	[WebHostHidden]
	internal interface ICommandBarFlyoutCommandBarFactory
	{
		// Token: 0x06000945 RID: 2373
		CommandBarFlyoutCommandBar CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
