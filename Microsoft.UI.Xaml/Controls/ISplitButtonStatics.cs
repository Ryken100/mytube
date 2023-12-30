using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200012C RID: 300
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[MUXPropertyChangedCallback(enable = true)]
	[ExclusiveTo(typeof(SplitButton))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(1919074784U, 38861, 21857, 182, 231, 94, 46, 206, 164, 106, 194)]
	[WebHostHidden]
	internal interface ISplitButtonStatics
	{
		// Token: 0x170002AF RID: 687
		// (get) Token: 0x060004D5 RID: 1237
		DependencyProperty FlyoutProperty { get; }

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x060004D6 RID: 1238
		DependencyProperty CommandProperty { get; }

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x060004D7 RID: 1239
		DependencyProperty CommandParameterProperty { get; }
	}
}
