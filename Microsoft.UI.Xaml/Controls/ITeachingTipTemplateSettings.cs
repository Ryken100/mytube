using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200014F RID: 335
	[WebHostHidden]
	[Guid(1736066021U, 36850, 20941, 151, 66, 162, 21, 94, 32, 215, 114)]
	[ExclusiveTo(typeof(TeachingTipTemplateSettings))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface ITeachingTipTemplateSettings
	{
		// Token: 0x17000339 RID: 825
		// (get) Token: 0x060005C5 RID: 1477
		// (set) Token: 0x060005C6 RID: 1478
		Thickness TopRightHighlightMargin
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x060005C7 RID: 1479
		// (set) Token: 0x060005C8 RID: 1480
		Thickness TopLeftHighlightMargin
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x060005C9 RID: 1481
		// (set) Token: 0x060005CA RID: 1482
		IconElement IconElement
		{
			get; [param: In]
			set;
		}
	}
}
