using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000110 RID: 272
	[MUXPropertyChangedCallback(enable = true)]
	[Guid(288891602U, 13731, 23309, 157, 13, 195, 131, 14, 193, 151, 59)]
	[ExclusiveTo(typeof(RadioMenuFlyoutItem))]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	internal interface IRadioMenuFlyoutItemFactory
	{
		// Token: 0x06000466 RID: 1126
		RadioMenuFlyoutItem CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
