using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200011D RID: 285
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(1643197568U, 52492, 21866, 181, 50, 160, 207, 83, 227, 205, 160)]
	[ExclusiveTo(typeof(RatingItemInfo))]
	internal interface IRatingItemInfoFactory
	{
		// Token: 0x060004AD RID: 1197
		RatingItemInfo CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
