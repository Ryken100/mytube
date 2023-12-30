using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000117 RID: 279
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(RatingItemFontInfo))]
	[Guid(278684993U, 28782, 24535, 186, 174, 2, 11, 36, 137, 159, 97)]
	[WebHostHidden]
	internal interface IRatingItemFontInfoFactory
	{
		// Token: 0x06000493 RID: 1171
		RatingItemFontInfo CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
