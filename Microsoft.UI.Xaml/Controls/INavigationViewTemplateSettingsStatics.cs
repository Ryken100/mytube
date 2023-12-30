using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000EA RID: 234
	[Guid(2991625727U, 47102, 23214, 153, 155, 31, 31, 1, 213, 250, 18)]
	[ExclusiveTo(typeof(NavigationViewTemplateSettings))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	internal interface INavigationViewTemplateSettingsStatics
	{
		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000358 RID: 856
		DependencyProperty TopPaddingProperty { get; }

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000359 RID: 857
		DependencyProperty OverflowButtonVisibilityProperty { get; }

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x0600035A RID: 858
		DependencyProperty PaneToggleButtonVisibilityProperty { get; }

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x0600035B RID: 859
		DependencyProperty BackButtonVisibilityProperty { get; }

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x0600035C RID: 860
		DependencyProperty TopPaneVisibilityProperty { get; }

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x0600035D RID: 861
		DependencyProperty LeftPaneVisibilityProperty { get; }

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x0600035E RID: 862
		DependencyProperty SingleSelectionFollowsFocusProperty { get; }

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x0600035F RID: 863
		DependencyProperty PaneToggleButtonWidthProperty { get; }

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000360 RID: 864
		DependencyProperty SmallerPaneToggleButtonWidthProperty { get; }
	}
}
