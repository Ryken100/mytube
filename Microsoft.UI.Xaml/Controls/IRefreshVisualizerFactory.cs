using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000125 RID: 293
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MUXPropertyChangedCallback(enable = true)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Guid(2641308658U, 26152, 22570, 137, 43, 104, 194, 119, 12, 23, 60)]
	[ExclusiveTo(typeof(RefreshVisualizer))]
	[WebHostHidden]
	internal interface IRefreshVisualizerFactory
	{
		// Token: 0x060004C6 RID: 1222
		RefreshVisualizer CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
