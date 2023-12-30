using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000105 RID: 261
	[WebHostHidden]
	[Guid(412624557U, 63218, 21310, 157, 219, 182, 96, 14, 136, 103, 91)]
	[ExclusiveTo(typeof(ProgressBar))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface IProgressBarFactory
	{
		// Token: 0x06000424 RID: 1060
		ProgressBar CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
