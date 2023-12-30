using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000143 RID: 323
	[ExclusiveTo(typeof(TabViewItemTemplateSettings))]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(3416515687U, 19608, 22661, 186, 36, 111, 166, 153, 204, 142, 221)]
	internal interface ITabViewItemTemplateSettingsFactory
	{
		// Token: 0x06000559 RID: 1369
		TabViewItemTemplateSettings CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
