using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000FE RID: 254
	[WebHostHidden]
	[MUXPropertyNeedsDependencyPropertyField]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(PersonPictureTemplateSettings))]
	[Guid(2679421456U, 52216, 23999, 145, 138, 131, 35, 218, 164, 247, 228)]
	internal interface IPersonPictureTemplateSettings
	{
		// Token: 0x17000228 RID: 552
		// (get) Token: 0x060003F8 RID: 1016
		string ActualInitials { get; }

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x060003F9 RID: 1017
		ImageBrush ActualImageBrush { get; }
	}
}
