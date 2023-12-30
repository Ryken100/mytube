using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000095 RID: 149
	[ExclusiveTo(typeof(DropDownButton))]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(2096357691U, 26253, 22503, 181, 214, 245, 202, 61, 188, 128, 189)]
	internal interface IDropDownButtonFactory
	{
		// Token: 0x060001D9 RID: 473
		DropDownButton CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
