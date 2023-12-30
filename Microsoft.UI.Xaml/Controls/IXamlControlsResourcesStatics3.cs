using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000181 RID: 385
	[WebHostHidden]
	[ExclusiveTo(typeof(XamlControlsResources))]
	[MUXPropertyChangedCallback(enable = true)]
	[Guid(1345675536U, 2961, 21230, 152, 78, 86, 42, 255, 152, 25, 98)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ContractVersion(typeof(XamlContract), 131072U)]
	internal interface IXamlControlsResourcesStatics3
	{
		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x060006A1 RID: 1697
		DependencyProperty ControlsResourcesVersionProperty { get; }
	}
}
