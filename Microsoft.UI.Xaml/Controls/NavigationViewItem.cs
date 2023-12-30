using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200019B RID: 411
	[Threading(3)]
	[Static(typeof(INavigationViewItemStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(2)]
	[Static(typeof(INavigationViewItemStatics2), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Composable(typeof(INavigationViewItemFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[WebHostHidden]
	public class NavigationViewItem : NavigationViewItemBase, INavigationViewItem, INavigationViewItem2
	{
		// Token: 0x060007B5 RID: 1973
		public extern NavigationViewItem();

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x060007B6 RID: 1974
		// (set) Token: 0x060007B7 RID: 1975
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		public extern IconElement Icon
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x060007B8 RID: 1976
		[MUXPropertyDefaultValue(value = "48.0")]
		public extern double CompactPaneLength
		{
			[MUXPropertyDefaultValue(value = "48.0")]
			get;
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x060007B9 RID: 1977
		// (set) Token: 0x060007BA RID: 1978
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		public extern bool SelectsOnInvoked
		{
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x060007BB RID: 1979
		// (set) Token: 0x060007BC RID: 1980
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "false")]
		[MUXPropertyDefaultValue(value = "false")]
		[MUXPropertyChangedCallback(enable = true)]
		public extern bool IsExpanded
		{
			[MUXPropertyDefaultValue(value = "false")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyDefaultValue(value = "false")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x060007BD RID: 1981
		// (set) Token: 0x060007BE RID: 1982
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "false")]
		[MUXPropertyDefaultValue(value = "false")]
		[MUXPropertyChangedCallback(enable = true)]
		public extern bool HasUnrealizedChildren
		{
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "false")]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "false")]
			[param: In]
			set;
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x060007BF RID: 1983
		// (set) Token: 0x060007C0 RID: 1984
		[MUXPropertyDefaultValue(value = "false")]
		[MUXPropertyDefaultValue(value = "false")]
		public extern bool IsChildSelected
		{
			[MUXPropertyDefaultValue(value = "false")]
			get;
			[MUXPropertyDefaultValue(value = "false")]
			[param: In]
			set;
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x060007C1 RID: 1985
		[MUXPropertyChangedCallback(enable = true)]
		public extern IVector<object> MenuItems
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x060007C2 RID: 1986
		// (set) Token: 0x060007C3 RID: 1987
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		public extern object MenuItemsSource
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x060007C4 RID: 1988
		public static extern DependencyProperty SelectsOnInvokedProperty { get; }

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x060007C5 RID: 1989
		public static extern DependencyProperty IsExpandedProperty { get; }

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x060007C6 RID: 1990
		public static extern DependencyProperty HasUnrealizedChildrenProperty { get; }

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x060007C7 RID: 1991
		public static extern DependencyProperty IsChildSelectedProperty { get; }

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x060007C8 RID: 1992
		public static extern DependencyProperty MenuItemsProperty { get; }

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x060007C9 RID: 1993
		public static extern DependencyProperty MenuItemsSourceProperty { get; }

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x060007CA RID: 1994
		public static extern DependencyProperty IconProperty { get; }

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x060007CB RID: 1995
		public static extern DependencyProperty CompactPaneLengthProperty { get; }
	}
}
