using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	// Token: 0x020001D0 RID: 464
	[ExclusiveTo(typeof(CommandBarFlyoutCommandBar))]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(259072197U, 27904, 21641, 145, 113, 190, 221, 45, 78, 246, 119)]
	internal interface ICommandBarFlyoutCommandBar
	{
		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06000941 RID: 2369
		[MUXPropertyNeedsDependencyPropertyField]
		CommandBarFlyoutCommandBarTemplateSettings FlyoutTemplateSettings
		{
			[MUXPropertyNeedsDependencyPropertyField]
			get;
		}
	}
}
