using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000EF RID: 239
	[Guid(2708286738U, 56236, 23776, 174, 245, 9, 23, 26, 77, 53, 113)]
	[ExclusiveTo(typeof(NonVirtualizingLayout))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	internal interface INonVirtualizingLayoutFactory
	{
		// Token: 0x06000364 RID: 868
		NonVirtualizingLayout CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
