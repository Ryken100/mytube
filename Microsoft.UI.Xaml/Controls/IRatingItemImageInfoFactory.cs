using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200011A RID: 282
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(1254919340U, 48296, 21376, 149, 228, 52, 92, 27, 226, 86, 178)]
	[ExclusiveTo(typeof(RatingItemImageInfo))]
	internal interface IRatingItemImageInfoFactory
	{
		// Token: 0x060004A6 RID: 1190
		RatingItemImageInfo CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
