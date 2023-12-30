using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Media
{
	// Token: 0x02000242 RID: 578
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[ExclusiveTo(typeof(RadialGradientBrush))]
	[Guid(3641418350U, 40551, 21693, 162, 217, 97, 200, 249, 241, 212, 51)]
	internal interface IRadialGradientBrushFactory
	{
		// Token: 0x06000C75 RID: 3189
		RadialGradientBrush CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
