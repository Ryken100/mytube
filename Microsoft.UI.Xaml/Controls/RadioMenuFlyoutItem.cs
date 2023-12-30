using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020001F1 RID: 497
	[MarshalingBehavior(2)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[WebHostHidden]
	[Static(typeof(IRadioMenuFlyoutItemStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[Composable(typeof(IRadioMenuFlyoutItemFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[Threading(3)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MUXPropertyChangedCallback(enable = true)]
	[Static(typeof(IRadioMenuFlyoutItemStatics2), 131072U, "Microsoft.UI.Xaml.XamlContract")]
	public class RadioMenuFlyoutItem : MenuFlyoutItem, IRadioMenuFlyoutItem
	{
		// Token: 0x060009EB RID: 2539
		public extern RadioMenuFlyoutItem();

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x060009EC RID: 2540
		// (set) Token: 0x060009ED RID: 2541
		public extern bool IsChecked
		{
			get; [param: In]
			set;
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x060009EE RID: 2542
		// (set) Token: 0x060009EF RID: 2543
		public extern string GroupName
		{
			get; [param: In]
			set;
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x060009F0 RID: 2544
		[MUXPropertyChangedCallbackMethodName(value = "OnAreCheckStatesEnabledPropertyChanged")]
		[MUXPropertyDefaultValue(value = "false")]
		public static extern DependencyProperty AreCheckStatesEnabledProperty
		{
			[MUXPropertyChangedCallbackMethodName(value = "OnAreCheckStatesEnabledPropertyChanged")]
			[MUXPropertyDefaultValue(value = "false")]
			get;
		}

		// Token: 0x060009F1 RID: 2545
		public static extern void SetAreCheckStatesEnabled([In] MenuFlyoutSubItem @object, [In] bool value);

		// Token: 0x060009F2 RID: 2546
		public static extern bool GetAreCheckStatesEnabled([In] MenuFlyoutSubItem @object);

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x060009F3 RID: 2547
		public static extern DependencyProperty IsCheckedProperty { get; }

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x060009F4 RID: 2548
		public static extern DependencyProperty GroupNameProperty { get; }
	}
}
