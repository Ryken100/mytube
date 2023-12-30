using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200017C RID: 380
	[Guid(3351324897U, 24055, 21317, 181, 205, 67, 175, 223, 169, 72, 180)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(VirtualizingLayout))]
	[WebHostHidden]
	internal interface IVirtualizingLayoutFactory
	{
		// Token: 0x06000698 RID: 1688
		VirtualizingLayout CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
