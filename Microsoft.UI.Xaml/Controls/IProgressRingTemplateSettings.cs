using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200010B RID: 267
	[WebHostHidden]
	[MUXPropertyNeedsDependencyPropertyField]
	[Guid(3518474954U, 1952, 21999, 169, 197, 142, 68, 237, 173, 116, 153)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(ProgressRingTemplateSettings))]
	internal interface IProgressRingTemplateSettings
	{
		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000444 RID: 1092
		double EllipseDiameter { get; }

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000445 RID: 1093
		Thickness EllipseOffset { get; }

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000446 RID: 1094
		double MaxSideLength { get; }
	}
}
