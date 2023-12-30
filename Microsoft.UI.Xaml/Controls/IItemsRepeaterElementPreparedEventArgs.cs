using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000B8 RID: 184
	[WebHostHidden]
	[ExclusiveTo(typeof(ItemsRepeaterElementPreparedEventArgs))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(2775398674U, 60928, 22030, 141, 62, 14, 223, 216, 213, 102, 145)]
	internal interface IItemsRepeaterElementPreparedEventArgs
	{
		// Token: 0x17000138 RID: 312
		// (get) Token: 0x0600026F RID: 623
		UIElement Element { get; }

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000270 RID: 624
		int Index { get; }
	}
}
