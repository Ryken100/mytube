using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000F2 RID: 242
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(NumberBox))]
	[Guid(1803678667U, 17828, 23833, 155, 187, 169, 254, 70, 86, 172, 77)]
	internal interface INumberBoxFactory
	{
		// Token: 0x06000391 RID: 913
		NumberBox CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
