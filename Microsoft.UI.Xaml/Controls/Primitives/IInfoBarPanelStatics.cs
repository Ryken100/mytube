using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	// Token: 0x020001DA RID: 474
	[WebHostHidden]
	[ExclusiveTo(typeof(InfoBarPanel))]
	[Guid(861789181U, 38778, 22690, 175, 23, 75, 119, 97, 68, 242, 69)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface IInfoBarPanelStatics
	{
		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x0600096B RID: 2411
		DependencyProperty HorizontalOrientationPaddingProperty { get; }

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x0600096C RID: 2412
		DependencyProperty VerticalOrientationPaddingProperty { get; }

		// Token: 0x0600096D RID: 2413
		void SetHorizontalOrientationMargin([In] DependencyObject @object, [In] Thickness value);

		// Token: 0x0600096E RID: 2414
		Thickness GetHorizontalOrientationMargin([In] DependencyObject @object);

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x0600096F RID: 2415
		DependencyProperty HorizontalOrientationMarginProperty { get; }

		// Token: 0x06000970 RID: 2416
		void SetVerticalOrientationMargin([In] DependencyObject @object, [In] Thickness value);

		// Token: 0x06000971 RID: 2417
		Thickness GetVerticalOrientationMargin([In] DependencyObject @object);

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06000972 RID: 2418
		DependencyProperty VerticalOrientationMarginProperty { get; }
	}
}
