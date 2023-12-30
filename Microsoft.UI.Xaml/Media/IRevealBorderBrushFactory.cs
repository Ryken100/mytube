using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Media
{
	// Token: 0x02000247 RID: 583
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(RevealBorderBrush))]
	[Guid(3329736130U, 61509, 21292, 187, 19, 60, 238, 225, 145, 67, 178)]
	[WebHostHidden]
	internal interface IRevealBorderBrushFactory
	{
		// Token: 0x06000C7E RID: 3198
		RevealBorderBrush CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
