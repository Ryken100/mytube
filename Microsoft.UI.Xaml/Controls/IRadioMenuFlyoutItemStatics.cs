using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000111 RID: 273
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ExclusiveTo(typeof(RadioMenuFlyoutItem))]
	[WebHostHidden]
	[MUXPropertyChangedCallback(enable = true)]
	[Guid(747623594U, 47320, 21564, 161, 190, 158, 0, 135, 39, 193, 88)]
	internal interface IRadioMenuFlyoutItemStatics
	{
		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000467 RID: 1127
		DependencyProperty IsCheckedProperty { get; }

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000468 RID: 1128
		DependencyProperty GroupNameProperty { get; }
	}
}
