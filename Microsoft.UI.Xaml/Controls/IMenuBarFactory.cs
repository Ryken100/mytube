using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000C6 RID: 198
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(1990887257U, 1262, 23116, 185, 140, 208, 55, 66, 212, 124, 219)]
	[WebHostHidden]
	[ExclusiveTo(typeof(MenuBar))]
	internal interface IMenuBarFactory
	{
		// Token: 0x06000297 RID: 663
		MenuBar CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
