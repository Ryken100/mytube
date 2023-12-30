using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200010F RID: 271
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[MUXPropertyChangedCallback(enable = true)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(2641315317U, 21810, 22121, 143, 2, 5, 115, 89, 83, 2, 106)]
	[ExclusiveTo(typeof(RadioMenuFlyoutItem))]
	[WebHostHidden]
	internal interface IRadioMenuFlyoutItem
	{
		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000462 RID: 1122
		// (set) Token: 0x06000463 RID: 1123
		bool IsChecked
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000464 RID: 1124
		// (set) Token: 0x06000465 RID: 1125
		string GroupName
		{
			get; [param: In]
			set;
		}
	}
}
