using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000FD RID: 253
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MUXPropertyChangedCallback(enable = true)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Guid(3517960000U, 47035, 22643, 154, 181, 158, 230, 240, 101, 221, 30)]
	[ExclusiveTo(typeof(PersonPicture))]
	internal interface IPersonPictureStatics
	{
		// Token: 0x1700021F RID: 543
		// (get) Token: 0x060003EE RID: 1006
		DependencyProperty BadgeNumberProperty { get; }

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x060003EF RID: 1007
		DependencyProperty BadgeGlyphProperty { get; }

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x060003F0 RID: 1008
		DependencyProperty BadgeImageSourceProperty { get; }

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x060003F1 RID: 1009
		DependencyProperty BadgeTextProperty { get; }

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x060003F2 RID: 1010
		DependencyProperty IsGroupProperty { get; }

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x060003F3 RID: 1011
		DependencyProperty ContactProperty { get; }

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x060003F4 RID: 1012
		DependencyProperty DisplayNameProperty { get; }

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x060003F5 RID: 1013
		DependencyProperty InitialsProperty { get; }

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x060003F6 RID: 1014
		DependencyProperty PreferSmallImageProperty { get; }

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x060003F7 RID: 1015
		DependencyProperty ProfilePictureProperty { get; }
	}
}
