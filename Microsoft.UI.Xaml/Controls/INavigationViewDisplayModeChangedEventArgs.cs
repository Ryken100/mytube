using System;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000D0 RID: 208
	[Guid(1490874858U, 40534, 21036, 179, 248, 52, 189, 85, 236, 172, 164)]
	[ExclusiveTo(typeof(NavigationViewDisplayModeChangedEventArgs))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	internal interface INavigationViewDisplayModeChangedEventArgs
	{
		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060002FD RID: 765
		NavigationViewDisplayMode DisplayMode { get; }
	}
}
