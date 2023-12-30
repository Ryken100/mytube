using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200009E RID: 158
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MUXPropertyNeedsDependencyPropertyField]
	[Guid(2408943640U, 63160, 23554, 190, 8, 205, 25, 108, 159, 205, 45)]
	[ExclusiveTo(typeof(ExpanderTemplateSettings))]
	[WebHostHidden]
	internal interface IExpanderTemplateSettings
	{
		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060001F9 RID: 505
		double ContentHeight { get; }

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060001FA RID: 506
		double NegativeContentHeight { get; }
	}
}
