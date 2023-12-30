using System;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000E4 RID: 228
	[ExclusiveTo(typeof(NavigationViewSelectionChangedEventArgs))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(346055845U, 51101, 24419, 172, 110, 28, 49, 63, 230, 53, 102)]
	[WebHostHidden]
	internal interface INavigationViewSelectionChangedEventArgs
	{
		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000325 RID: 805
		object SelectedItem { get; }

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000326 RID: 806
		bool IsSettingsSelected { get; }
	}
}
