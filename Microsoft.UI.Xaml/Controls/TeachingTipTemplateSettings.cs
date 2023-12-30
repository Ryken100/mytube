using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200021A RID: 538
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MarshalingBehavior(2)]
	[Composable(typeof(ITeachingTipTemplateSettingsFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[Threading(3)]
	[WebHostHidden]
	[Static(typeof(ITeachingTipTemplateSettingsStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	public class TeachingTipTemplateSettings : DependencyObject, ITeachingTipTemplateSettings
	{
		// Token: 0x06000B61 RID: 2913
		public extern TeachingTipTemplateSettings();

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06000B62 RID: 2914
		// (set) Token: 0x06000B63 RID: 2915
		public extern Thickness TopRightHighlightMargin
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06000B64 RID: 2916
		// (set) Token: 0x06000B65 RID: 2917
		public extern Thickness TopLeftHighlightMargin
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06000B66 RID: 2918
		// (set) Token: 0x06000B67 RID: 2919
		public extern IconElement IconElement
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06000B68 RID: 2920
		public static extern DependencyProperty TopRightHighlightMarginProperty { get; }

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06000B69 RID: 2921
		public static extern DependencyProperty TopLeftHighlightMarginProperty { get; }

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06000B6A RID: 2922
		public static extern DependencyProperty IconElementProperty { get; }
	}
}
