using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000BD RID: 189
	[Guid(2866573277U, 60160, 24152, 185, 93, 18, 15, 137, 29, 115, 63)]
	[ExclusiveTo(typeof(ItemsSourceView))]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface IItemsSourceViewFactory
	{
		// Token: 0x06000285 RID: 645
		ItemsSourceView CreateInstance([In] object source, [In] object baseInterface, out object innerInterface);
	}
}
