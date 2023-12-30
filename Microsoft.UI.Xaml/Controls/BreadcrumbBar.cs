using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000061 RID: 97
	[MarshalingBehavior(2)]
	[MUXPropertyChangedCallback(enable = true)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Composable(typeof(IBreadcrumbBarFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Static(typeof(IBreadcrumbBarStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[Threading(3)]
	[WebHostHidden]
	public class BreadcrumbBar : Control, IBreadcrumbBar
	{
		// Token: 0x060000BE RID: 190
		public extern BreadcrumbBar();

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000BF RID: 191
		// (set) Token: 0x060000C0 RID: 192
		public extern object ItemsSource
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000C1 RID: 193
		// (set) Token: 0x060000C2 RID: 194
		public extern object ItemTemplate
		{
			get; [param: In]
			set;
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060000C3 RID: 195
		// (remove) Token: 0x060000C4 RID: 196
		public extern event TypedEventHandler<BreadcrumbBar, BreadcrumbBarItemClickedEventArgs> ItemClicked;

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000C5 RID: 197
		public static extern DependencyProperty ItemsSourceProperty { get; }

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000C6 RID: 198
		public static extern DependencyProperty ItemTemplateProperty { get; }
	}
}
