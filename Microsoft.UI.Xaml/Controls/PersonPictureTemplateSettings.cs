using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020001B2 RID: 434
	[MUXPropertyNeedsDependencyPropertyField]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[Threading(3)]
	[MarshalingBehavior(2)]
	public sealed class PersonPictureTemplateSettings : DependencyObject, IPersonPictureTemplateSettings
	{
		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06000887 RID: 2183
		public extern string ActualInitials { get; }

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06000888 RID: 2184
		public extern ImageBrush ActualImageBrush { get; }
	}
}
