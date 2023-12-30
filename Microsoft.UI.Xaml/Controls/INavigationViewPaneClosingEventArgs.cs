using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000E3 RID: 227
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[Guid(3898880772U, 28084, 23285, 186, 194, 98, 115, 60, 160, 55, 218)]
	[ExclusiveTo(typeof(NavigationViewPaneClosingEventArgs))]
	internal interface INavigationViewPaneClosingEventArgs
	{
		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000323 RID: 803
		// (set) Token: 0x06000324 RID: 804
		bool Cancel
		{
			get; [param: In]
			set;
		}
	}
}
