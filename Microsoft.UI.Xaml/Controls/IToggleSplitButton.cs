using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000154 RID: 340
	[WebHostHidden]
	[ExclusiveTo(typeof(ToggleSplitButton))]
	[MUXPropertyChangedCallback(enable = true)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(1544496251U, 48384, 21769, 136, 168, 176, 144, 7, 174, 34, 176)]
	internal interface IToggleSplitButton
	{
		// Token: 0x1700033D RID: 829
		// (get) Token: 0x060005D0 RID: 1488
		// (set) Token: 0x060005D1 RID: 1489
		bool IsChecked
		{
			get; [param: In]
			set;
		}

		// Token: 0x14000033 RID: 51
		// (add) Token: 0x060005D2 RID: 1490
		// (remove) Token: 0x060005D3 RID: 1491
		event TypedEventHandler<ToggleSplitButton, ToggleSplitButtonIsCheckedChangedEventArgs> IsCheckedChanged;
	}
}
