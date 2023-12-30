using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000E7 RID: 231
	[MUXPropertyChangedCallback(enable = true)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(NavigationView))]
	[Guid(601441921U, 28348, 22587, 167, 112, 164, 71, 90, 116, 65, 207)]
	[WebHostHidden]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	internal interface INavigationViewStatics2
	{
		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000342 RID: 834
		DependencyProperty IsBackButtonVisibleProperty { get; }

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000343 RID: 835
		DependencyProperty IsBackEnabledProperty { get; }

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000344 RID: 836
		DependencyProperty PaneTitleProperty { get; }

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000345 RID: 837
		DependencyProperty PaneDisplayModeProperty { get; }

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000346 RID: 838
		DependencyProperty PaneHeaderProperty { get; }

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000347 RID: 839
		DependencyProperty PaneCustomContentProperty { get; }

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000348 RID: 840
		DependencyProperty ContentOverlayProperty { get; }

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000349 RID: 841
		DependencyProperty IsPaneVisibleProperty { get; }

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x0600034A RID: 842
		DependencyProperty SelectionFollowsFocusProperty { get; }

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x0600034B RID: 843
		DependencyProperty TemplateSettingsProperty { get; }

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x0600034C RID: 844
		DependencyProperty ShoulderNavigationEnabledProperty { get; }

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x0600034D RID: 845
		DependencyProperty OverflowLabelModeProperty { get; }
	}
}
