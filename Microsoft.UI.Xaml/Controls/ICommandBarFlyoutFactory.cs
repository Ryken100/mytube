using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000093 RID: 147
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[ExclusiveTo(typeof(CommandBarFlyout))]
	[Guid(2710887398U, 17169, 23506, 168, 235, 180, 156, 71, 51, 163, 60)]
	internal interface ICommandBarFlyoutFactory
	{
		// Token: 0x060001D8 RID: 472
		CommandBarFlyout CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
