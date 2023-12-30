using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200020C RID: 524
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Threading(3)]
	[Composable(typeof(ITabViewItemFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(2)]
	[Static(typeof(ITabViewItemStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	public class TabViewItem : ListViewItem, ITabViewItem
	{
		// Token: 0x06000AF4 RID: 2804
		public extern TabViewItem();

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06000AF5 RID: 2805
		// (set) Token: 0x06000AF6 RID: 2806
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		public extern object Header
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06000AF7 RID: 2807
		// (set) Token: 0x06000AF8 RID: 2808
		public extern DataTemplate HeaderTemplate
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06000AF9 RID: 2809
		// (set) Token: 0x06000AFA RID: 2810
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		public extern IconSource IconSource
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06000AFB RID: 2811
		// (set) Token: 0x06000AFC RID: 2812
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		public extern bool IsClosable
		{
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06000AFD RID: 2813
		public extern TabViewItemTemplateSettings TabViewTemplateSettings { get; }

		// Token: 0x14000061 RID: 97
		// (add) Token: 0x06000AFE RID: 2814
		// (remove) Token: 0x06000AFF RID: 2815
		public extern event TypedEventHandler<TabViewItem, TabViewTabCloseRequestedEventArgs> CloseRequested;

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06000B00 RID: 2816
		public static extern DependencyProperty HeaderProperty { get; }

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06000B01 RID: 2817
		public static extern DependencyProperty HeaderTemplateProperty { get; }

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06000B02 RID: 2818
		public static extern DependencyProperty IconSourceProperty { get; }

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06000B03 RID: 2819
		public static extern DependencyProperty IsClosableProperty { get; }

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06000B04 RID: 2820
		public static extern DependencyProperty TabViewTemplateSettingsProperty { get; }
	}
}
