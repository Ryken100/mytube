using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000142 RID: 322
	[ExclusiveTo(typeof(TabViewItemTemplateSettings))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(3518158688U, 52280, 23190, 188, 146, 16, 238, 59, 54, 152, 140)]
	[WebHostHidden]
	internal interface ITabViewItemTemplateSettings
	{
		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000557 RID: 1367
		// (set) Token: 0x06000558 RID: 1368
		IconElement IconElement
		{
			get; [param: In]
			set;
		}
	}
}
