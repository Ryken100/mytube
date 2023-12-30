using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Media
{
	// Token: 0x02000240 RID: 576
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MUXPropertyChangedCallback(enable = true)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ExclusiveTo(typeof(AcrylicBrush))]
	[Guid(4030654294U, 35481, 23277, 189, 23, 76, 115, 20, 172, 201, 255)]
	internal interface IAcrylicBrushStatics2
	{
		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x06000C65 RID: 3173
		DependencyProperty TintLuminosityOpacityProperty { get; }
	}
}
