using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Media
{
	// Token: 0x02000245 RID: 581
	[ExclusiveTo(typeof(RevealBackgroundBrush))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[Guid(2121214730U, 59149, 21151, 128, 151, 67, 224, 35, 242, 148, 59)]
	internal interface IRevealBackgroundBrushFactory
	{
		// Token: 0x06000C7D RID: 3197
		RevealBackgroundBrush CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
