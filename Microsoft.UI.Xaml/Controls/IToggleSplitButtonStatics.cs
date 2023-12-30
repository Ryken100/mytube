using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000157 RID: 343
	[Guid(3470862173U, 61916, 23765, 163, 212, 229, 107, 206, 238, 250, 136)]
	[WebHostHidden]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ExclusiveTo(typeof(ToggleSplitButton))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MUXPropertyChangedCallback(enable = true)]
	internal interface IToggleSplitButtonStatics
	{
		// Token: 0x1700033E RID: 830
		// (get) Token: 0x060005D5 RID: 1493
		DependencyProperty IsCheckedProperty { get; }
	}
}
