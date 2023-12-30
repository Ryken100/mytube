using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020001B6 RID: 438
	[MarshalingBehavior(2)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Threading(3)]
	[MUXPropertyNeedsDependencyPropertyField]
	[WebHostHidden]
	public sealed class PipsPagerTemplateSettings : DependencyObject, IPipsPagerTemplateSettings
	{
		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x060008AB RID: 2219
		public extern IVector<int> PipsPagerItems { get; }
	}
}
