using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000B6 RID: 182
	[ExclusiveTo(typeof(ItemsRepeaterElementClearingEventArgs))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[Guid(506508487U, 61884, 23151, 138, 91, 140, 84, 173, 172, 95, 128)]
	internal interface IItemsRepeaterElementClearingEventArgs
	{
		// Token: 0x17000134 RID: 308
		// (get) Token: 0x0600026B RID: 619
		UIElement Element { get; }
	}
}
