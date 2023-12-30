using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000ED RID: 237
	[ExclusiveTo(typeof(NonVirtualizingLayoutContext))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[Guid(3669671968U, 6300, 23487, 164, 220, 151, 218, 17, 153, 245, 119)]
	internal interface INonVirtualizingLayoutContextFactory
	{
		// Token: 0x06000362 RID: 866
		NonVirtualizingLayoutContext CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
