using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000073 RID: 115
	[WebHostHidden]
	[Threading(3)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MarshalingBehavior(2)]
	[MUXPropertyNeedsDependencyPropertyField]
	public sealed class ExpanderTemplateSettings : DependencyObject, IExpanderTemplateSettings
	{
		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600012D RID: 301
		public extern double ContentHeight { get; }

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600012E RID: 302
		public extern double NegativeContentHeight { get; }
	}
}
