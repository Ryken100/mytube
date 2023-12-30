using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200017A RID: 378
	[WebHostHidden]
	[ExclusiveTo(typeof(VirtualizingLayoutContext))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(1064897383U, 65019, 20570, 139, 133, 98, 16, 80, 109, 243, 17)]
	internal interface IVirtualizingLayoutContextFactory
	{
		// Token: 0x0600068F RID: 1679
		VirtualizingLayoutContext CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
