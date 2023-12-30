using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Markup;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020001F0 RID: 496
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[ContentProperty(Name = "Items")]
	[Composable(typeof(IRadioButtonsFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[Static(typeof(IRadioButtonsStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(2)]
	[Threading(3)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[MUXPropertyChangedCallback(enable = true)]
	public class RadioButtons : Control, IRadioButtons
	{
		// Token: 0x060009D0 RID: 2512
		public extern RadioButtons();

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x060009D1 RID: 2513
		// (set) Token: 0x060009D2 RID: 2514
		public extern object ItemsSource
		{
			get; [param: In]
			set;
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x060009D3 RID: 2515
		public extern IVector<object> Items { get; }

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x060009D4 RID: 2516
		// (set) Token: 0x060009D5 RID: 2517
		public extern object ItemTemplate
		{
			get; [param: In]
			set;
		}

		// Token: 0x060009D6 RID: 2518
		public extern UIElement ContainerFromIndex([In] int index);

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x060009D7 RID: 2519
		// (set) Token: 0x060009D8 RID: 2520
		[MUXPropertyDefaultValue(value = "-1")]
		[MUXPropertyDefaultValue(value = "-1")]
		public extern int SelectedIndex
		{
			[MUXPropertyDefaultValue(value = "-1")]
			get;
			[MUXPropertyDefaultValue(value = "-1")]
			[param: In]
			set;
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x060009D9 RID: 2521
		// (set) Token: 0x060009DA RID: 2522
		public extern object SelectedItem
		{
			get; [param: In]
			set;
		}

		// Token: 0x14000051 RID: 81
		// (add) Token: 0x060009DB RID: 2523
		// (remove) Token: 0x060009DC RID: 2524
		public extern event SelectionChangedEventHandler SelectionChanged;

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x060009DD RID: 2525
		// (set) Token: 0x060009DE RID: 2526
		[MUXPropertyDefaultValue(value = "1")]
		[MUXPropertyDefaultValue(value = "1")]
		public extern int MaxColumns
		{
			[MUXPropertyDefaultValue(value = "1")]
			get;
			[MUXPropertyDefaultValue(value = "1")]
			[param: In]
			set;
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x060009DF RID: 2527
		// (set) Token: 0x060009E0 RID: 2528
		public extern object Header
		{
			get; [param: In]
			set;
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x060009E1 RID: 2529
		// (set) Token: 0x060009E2 RID: 2530
		public extern DataTemplate HeaderTemplate
		{
			get; [param: In]
			set;
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x060009E3 RID: 2531
		public static extern DependencyProperty ItemsSourceProperty { get; }

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x060009E4 RID: 2532
		public static extern DependencyProperty ItemsProperty { get; }

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x060009E5 RID: 2533
		public static extern DependencyProperty ItemTemplateProperty { get; }

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x060009E6 RID: 2534
		public static extern DependencyProperty SelectedIndexProperty { get; }

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x060009E7 RID: 2535
		public static extern DependencyProperty SelectedItemProperty { get; }

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x060009E8 RID: 2536
		public static extern DependencyProperty MaxColumnsProperty { get; }

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x060009E9 RID: 2537
		public static extern DependencyProperty HeaderProperty { get; }

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x060009EA RID: 2538
		public static extern DependencyProperty HeaderTemplateProperty { get; }
	}
}
