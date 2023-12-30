using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000109 RID: 265
	[Guid(154118540U, 25255, 23996, 154, 133, 62, 85, 107, 168, 31, 121)]
	[ExclusiveTo(typeof(ProgressRing))]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface IProgressRingFactory
	{
		// Token: 0x0600043E RID: 1086
		ProgressRing CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
