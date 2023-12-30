using System;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000149 RID: 329
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(TabViewTabDroppedOutsideEventArgs))]
	[Guid(522145117U, 4017, 20907, 182, 111, 247, 163, 34, 191, 45, 19)]
	internal interface ITabViewTabDroppedOutsideEventArgs
	{
		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000577 RID: 1399
		object Item { get; }

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000578 RID: 1400
		TabViewItem Tab { get; }
	}
}
