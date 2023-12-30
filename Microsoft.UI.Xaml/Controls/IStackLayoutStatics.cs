using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200012F RID: 303
	[MUXPropertyChangedCallback(enable = true)]
	[ExclusiveTo(typeof(StackLayout))]
	[Guid(4137463550U, 40303, 23440, 157, 61, 244, 126, 206, 181, 93, 32)]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	internal interface IStackLayoutStatics
	{
		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x060004DD RID: 1245
		DependencyProperty OrientationProperty { get; }

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x060004DE RID: 1246
		DependencyProperty SpacingProperty { get; }
	}
}
