using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000DC RID: 220
	[ExclusiveTo(typeof(NavigationViewItemHeader))]
	[WebHostHidden]
	[Guid(1783908301U, 10520, 24547, 137, 155, 147, 214, 150, 18, 133, 230)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface INavigationViewItemHeaderFactory
	{
		// Token: 0x06000315 RID: 789
		NavigationViewItemHeader CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
