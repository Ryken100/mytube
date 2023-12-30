using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000E9 RID: 233
	[ExclusiveTo(typeof(NavigationViewTemplateSettings))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(889154708U, 25701, 24382, 176, 165, 79, 30, 234, 72, 231, 67)]
	[WebHostHidden]
	internal interface INavigationViewTemplateSettingsFactory
	{
		// Token: 0x06000357 RID: 855
		NavigationViewTemplateSettings CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
