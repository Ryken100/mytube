using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000B7 RID: 183
	[Guid(2573132285U, 58051, 24547, 148, 67, 169, 90, 63, 173, 90, 159)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[ExclusiveTo(typeof(ItemsRepeaterElementIndexChangedEventArgs))]
	internal interface IItemsRepeaterElementIndexChangedEventArgs
	{
		// Token: 0x17000135 RID: 309
		// (get) Token: 0x0600026C RID: 620
		UIElement Element { get; }

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x0600026D RID: 621
		int OldIndex { get; }

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x0600026E RID: 622
		int NewIndex { get; }
	}
}
