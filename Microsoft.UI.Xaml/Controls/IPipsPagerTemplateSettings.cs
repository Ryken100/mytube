using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000103 RID: 259
	[MUXPropertyNeedsDependencyPropertyField]
	[Guid(2643202642U, 22213, 22447, 154, 58, 8, 233, 185, 71, 229, 250)]
	[WebHostHidden]
	[ExclusiveTo(typeof(PipsPagerTemplateSettings))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface IPipsPagerTemplateSettings
	{
		// Token: 0x1700023E RID: 574
		// (get) Token: 0x0600041C RID: 1052
		IVector<int> PipsPagerItems { get; }
	}
}
