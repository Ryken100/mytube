using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000120 RID: 288
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MUXPropertyChangedCallback(enable = true)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Guid(522961352U, 23695, 23366, 139, 15, 224, 6, 219, 78, 198, 225)]
	[ExclusiveTo(typeof(RefreshContainer))]
	[WebHostHidden]
	internal interface IRefreshContainerStatics
	{
		// Token: 0x1700029F RID: 671
		// (get) Token: 0x060004B6 RID: 1206
		DependencyProperty VisualizerProperty { get; }

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x060004B7 RID: 1207
		DependencyProperty PullDirectionProperty { get; }
	}
}
