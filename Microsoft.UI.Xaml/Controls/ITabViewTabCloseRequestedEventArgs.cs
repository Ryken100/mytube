using System;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000146 RID: 326
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(3580541362U, 57956, 23678, 161, 203, 228, 26, 22, 166, 198, 198)]
	[ExclusiveTo(typeof(TabViewTabCloseRequestedEventArgs))]
	internal interface ITabViewTabCloseRequestedEventArgs
	{
		// Token: 0x170002FF RID: 767
		// (get) Token: 0x0600056D RID: 1389
		object Item { get; }

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x0600056E RID: 1390
		TabViewItem Tab { get; }
	}
}
