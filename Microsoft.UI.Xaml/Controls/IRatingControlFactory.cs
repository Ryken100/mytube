using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000114 RID: 276
	[ExclusiveTo(typeof(RatingControl))]
	[Guid(2772147059U, 49145, 21645, 162, 148, 172, 99, 216, 25, 247, 138)]
	[WebHostHidden]
	[MUXPropertyChangedCallback(enable = true)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface IRatingControlFactory
	{
		// Token: 0x0600047E RID: 1150
		RatingControl CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
