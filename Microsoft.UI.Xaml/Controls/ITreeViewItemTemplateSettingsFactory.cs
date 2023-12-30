using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000169 RID: 361
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(488269539U, 62829, 23935, 148, 44, 243, 168, 127, 92, 85, 46)]
	[WebHostHidden]
	[ExclusiveTo(typeof(TreeViewItemTemplateSettings))]
	internal interface ITreeViewItemTemplateSettingsFactory
	{
		// Token: 0x0600062E RID: 1582
		TreeViewItemTemplateSettings CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
