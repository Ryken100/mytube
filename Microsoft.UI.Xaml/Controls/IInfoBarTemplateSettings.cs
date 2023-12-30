using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000B2 RID: 178
	[ExclusiveTo(typeof(InfoBarTemplateSettings))]
	[Guid(73952399U, 60509, 22699, 131, 249, 63, 23, 17, 60, 236, 24)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	internal interface IInfoBarTemplateSettings
	{
		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000251 RID: 593
		// (set) Token: 0x06000252 RID: 594
		IconElement IconElement
		{
			get; [param: In]
			set;
		}
	}
}
