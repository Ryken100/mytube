using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000B3 RID: 179
	[ExclusiveTo(typeof(InfoBarTemplateSettings))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[Guid(693206447U, 51043, 22222, 141, 84, 238, 252, 175, 127, 46, 1)]
	internal interface IInfoBarTemplateSettingsFactory
	{
		// Token: 0x06000253 RID: 595
		InfoBarTemplateSettings CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
