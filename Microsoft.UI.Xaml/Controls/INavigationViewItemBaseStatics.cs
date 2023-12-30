using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000D7 RID: 215
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(NavigationViewItemBase))]
	[Guid(45568400U, 57400, 21043, 157, 125, 166, 0, 153, 222, 181, 139)]
	internal interface INavigationViewItemBaseStatics
	{
		// Token: 0x1700017D RID: 381
		// (get) Token: 0x0600030F RID: 783
		DependencyProperty IsSelectedProperty { get; }
	}
}
