using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000BC RID: 188
	[Guid(4160226014U, 59292, 23647, 171, 248, 204, 189, 72, 107, 137, 214)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(ItemsSourceView))]
	[WebHostHidden]
	internal interface IItemsSourceView
	{
		// Token: 0x17000144 RID: 324
		// (get) Token: 0x0600027F RID: 639
		int Count { get; }

		// Token: 0x06000280 RID: 640
		object GetAt([In] int index);

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000281 RID: 641
		bool HasKeyIndexMapping { get; }

		// Token: 0x06000282 RID: 642
		string KeyFromIndex([In] int index);

		// Token: 0x06000283 RID: 643
		int IndexFromKey([In] string key);

		// Token: 0x06000284 RID: 644
		int IndexOf([In] object item);
	}
}
