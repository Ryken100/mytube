using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000B0 RID: 176
	[Guid(1617005152U, 39911, 24053, 190, 13, 147, 61, 52, 221, 180, 76)]
	[WebHostHidden]
	[ExclusiveTo(typeof(InfoBar))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface IInfoBarFactory
	{
		// Token: 0x06000242 RID: 578
		InfoBar CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
