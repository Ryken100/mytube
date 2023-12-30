using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000BE RID: 190
	[Guid(2985540512U, 4238, 22029, 150, 129, 38, 57, 27, 75, 195, 13)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	public interface IKeyIndexMapping
	{
		// Token: 0x06000286 RID: 646
		string KeyFromIndex([In] int index);

		// Token: 0x06000287 RID: 647
		int IndexFromKey([In] string key);
	}
}
