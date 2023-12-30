using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200009C RID: 156
	[ExclusiveTo(typeof(Expander))]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(1369812930U, 45421, 20846, 131, 174, 90, 16, 71, 107, 19, 175)]
	internal interface IExpanderFactory
	{
		// Token: 0x060001F3 RID: 499
		Expander CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
