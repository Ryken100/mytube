using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200010C RID: 268
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(RadioButtons))]
	[MUXPropertyChangedCallback(enable = true)]
	[Guid(3711380836U, 46912, 22329, 141, 36, 182, 222, 204, 145, 244, 8)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[WebHostHidden]
	internal interface IRadioButtons
	{
		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000447 RID: 1095
		// (set) Token: 0x06000448 RID: 1096
		object ItemsSource
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000449 RID: 1097
		IVector<object> Items { get; }

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x0600044A RID: 1098
		// (set) Token: 0x0600044B RID: 1099
		object ItemTemplate
		{
			get; [param: In]
			set;
		}

		// Token: 0x0600044C RID: 1100
		UIElement ContainerFromIndex([In] int index);

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x0600044D RID: 1101
		// (set) Token: 0x0600044E RID: 1102
		[MUXPropertyDefaultValue(value = "-1")]
		[MUXPropertyDefaultValue(value = "-1")]
		int SelectedIndex
		{
			[MUXPropertyDefaultValue(value = "-1")]
			get;
			[MUXPropertyDefaultValue(value = "-1")]
			[param: In]
			set;
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x0600044F RID: 1103
		// (set) Token: 0x06000450 RID: 1104
		object SelectedItem
		{
			get; [param: In]
			set;
		}

		// Token: 0x1400001E RID: 30
		// (add) Token: 0x06000451 RID: 1105
		// (remove) Token: 0x06000452 RID: 1106
		event SelectionChangedEventHandler SelectionChanged;

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000453 RID: 1107
		// (set) Token: 0x06000454 RID: 1108
		[MUXPropertyDefaultValue(value = "1")]
		[MUXPropertyDefaultValue(value = "1")]
		int MaxColumns
		{
			[MUXPropertyDefaultValue(value = "1")]
			get;
			[MUXPropertyDefaultValue(value = "1")]
			[param: In]
			set;
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000455 RID: 1109
		// (set) Token: 0x06000456 RID: 1110
		object Header
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000457 RID: 1111
		// (set) Token: 0x06000458 RID: 1112
		DataTemplate HeaderTemplate
		{
			get; [param: In]
			set;
		}
	}
}
